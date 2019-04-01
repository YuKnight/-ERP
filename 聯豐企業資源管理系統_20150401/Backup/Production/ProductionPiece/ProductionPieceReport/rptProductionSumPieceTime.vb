Imports LFERP.DataSetting
Imports LFERP.Library.ProductionPieceWorkGroup
Imports LFERP.Library.ProductionPiecePersonnel

Public Class rptProductionSumPieceTime
    ''本模塊用於四類打印報表
    'P_PT-------------個人計時計件表
    'P_PTC------------個人計時計件匯總

    'G_PT-------------組別計時計件表
    'G_PTC------------組別計時計件匯總

    Dim Load_OK As String ''確定Load事件是否已載入完畢
    Dim Str_Choice As String
    Dim Temptest As String

    Private Sub rptProductionSumPieceTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Str_Choice = tempValue
        Temptest = tempValue2
        tempValue = Nothing
        tempValue2 = Nothing

        Select Case Str_Choice
            Case "P_PT"
                LabPer_NO.Text = "員工編號(&I):" 'P_PT-------------個人計時計件表
                LabCaption.Text = "員工計件表"
                Me.Text = "員工計件表打印"
            Case "P_PTC"
                LabPer_NO.Text = "員工編號(&I):" 'P_PTC------------個人計時計件匯總
                LabCaption.Text = "員工計件匯總表"
                Me.Text = "員工計件匯總表打印"
            Case "G_PT"
                LabPer_NO.Text = "組別編號(&G):" 'G_PT-------------組別計時計件表
                LabCaption.Text = "組別計件表"
                Me.Text = "組別計件表打印"
            Case "G_PTC"
                LabPer_NO.Text = "組別編號(&G):" 'G_PTC------------組別計時計件匯總
                LabCaption.Text = "組別計件匯總表"
                Me.Text = "組別計件匯總表打印"
        End Select

        '加載廠別名稱
        Dim fc As New FacControler
        lueFacID.Properties.DisplayMember = "FacName"
        lueFacID.Properties.ValueMember = "FacID"
        lueFacID.Properties.DataSource = fc.GetFacList(strInFacID, Nothing)

        ''載入本部門 
        ' lueFacID.EditValue = strInFacIDFull


        Dim dc As New DepartmentControler
        lueDepID.Properties.DisplayMember = "DepName"
        lueDepID.Properties.ValueMember = "DepID"
        lueDepID.Properties.DataSource = dc.BriName_GetList(strInDepID, Nothing, lueFacID.EditValue)

        Start_Date.EditValue = Format(Now, "yyyy/MM/dd")
        End_Date.EditValue = Format(Now, "yyyy/MM/dd")

        Load_OK = "OK"
        lueFacID.Select()

        ''--------------------查詢時用戶權限------------------------
        If strInUserRank = "生產部" Then
            lueFacID.EditValue = strInFacIDFull
        ElseIf strInUserRank = "管理" Then
        ElseIf strInUserRank = "統計" Then
            lueFacID.EditValue = strInFacIDFull
            lueDepID.EditValue = strInDepIDFull
        End If

        If Str_Choice = "P_PT" Or Str_Choice = "P_PTC" Then
            Dim ptc As New ProductionPiecePersonnelControl  ''載入 員工編號---姓名---部門
            txtPer_NO.Properties.DataSource = ptc.ProductionPiecePersonnel_GetList(Nothing, Nothing, Nothing, Nothing, lueDepID.EditValue, lueFacID.EditValue, Nothing, Nothing, Nothing, "False", Nothing, Nothing)
            txtPer_NO.Properties.DisplayMember = "Per_NOName"
            txtPer_NO.Properties.ValueMember = "Per_NO"
        ElseIf Str_Choice = "G_PT" Or Str_Choice = "G_PTC" Then
            Per_NO.Caption = "組別編號"
            Per_NO.FieldName = "G_NO"
            Per_Name.Caption = "組別名稱"
            Per_Name.FieldName = "G_Name"

            Dim pc As New ProductionPieceWorkGroupControl
            txtPer_NO.Properties.DisplayMember = "G_NOName"
            txtPer_NO.Properties.ValueMember = "G_NO"
            txtPer_NO.Properties.DataSource = pc.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, lueDepID.EditValue, lueFacID.EditValue, Nothing, Nothing, Nothing)
        End If

        txtPer_NO.EditValue = Temptest

    End Sub
    Private Sub lueDepID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueDepID.EditValueChanged

        If lueDepID.EditValue Is Nothing Or Load_OK <> "OK" Then Exit Sub

        If Str_Choice = "G_PT" Or Str_Choice = "G_PTC" Then
            Dim pc As New ProductionPieceWorkGroupControl
            txtPer_NO.Properties.DisplayMember = "G_NOName"
            txtPer_NO.Properties.ValueMember = "G_NO"
            txtPer_NO.Properties.DataSource = pc.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, lueDepID.EditValue, lueFacID.EditValue, Nothing, Nothing, Nothing)
        End If


        If Str_Choice = "P_PT" Or Str_Choice = "P_PTC" Then
            Dim ptc As New ProductionPiecePersonnelControl  ''載入 員工編號---姓名---部門
            txtPer_NO.Properties.DataSource = ptc.ProductionPiecePersonnel_GetList1(Nothing, Nothing, Nothing, lueDepID.EditValue, lueFacID.EditValue, Nothing, "False", Nothing, Nothing)
            txtPer_NO.Properties.DisplayMember = "Per_NOName"
            txtPer_NO.Properties.ValueMember = "Per_NO"
        End If

    End Sub

    Private Sub lueFacID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueFacID.EditValueChanged
        Dim dc As New DepartmentControler
        If lueFacID.EditValue Is Nothing Or Load_OK <> "OK" Then Exit Sub

        lueDepID.Properties.DisplayMember = "DepName"
        lueDepID.Properties.ValueMember = "DepID"
        lueDepID.Properties.DataSource = dc.BriName_GetList(strInDepID, Nothing, lueFacID.EditValue)

        'txtPer_NO.Properties.DataSource = Nothing

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim ds As New DataSet

        Dim strPer_ID, strFacID, strDepID, strStart_Date, strEnd_Date As String

        'If lueFacID.EditValue Is Nothing Then
        '    lueFacID.Select()
        '    lueFacID.Focus()
        '    MsgBox("請選擇廠別!")
        '    Exit Sub
        'End If

        'If lueDepID.EditValue Is Nothing Then
        '    lueDepID.Select()
        '    lueDepID.Focus()
        '    MsgBox("請選擇部門!")
        '    Exit Sub
        'End If

        If txtPer_NO.EditValue Is Nothing Then
            If Str_Choice = "P_PT" Or Str_Choice = "P_PTC" Then
                MsgBox("請輸入員工編號!")
            Else
                MsgBox("請輸入組別編號!")
            End If
            txtPer_NO.Select()
            txtPer_NO.Focus()
            Exit Sub
        End If

        If lueFacID.EditValue = Nothing Then
            strFacID = Nothing
        Else
            strFacID = lueFacID.EditValue
        End If

        If lueDepID.EditValue = Nothing Then
            strDepID = Nothing
        Else
            strDepID = lueDepID.EditValue
        End If

        If txtPer_NO.EditValue = "" Then
            strPer_ID = Nothing
        Else
            strPer_ID = txtPer_NO.EditValue
        End If

        If Start_Date.EditValue = Nothing Then
            strStart_Date = Nothing
        Else
            strStart_Date = Start_Date.Text
        End If

        If End_Date.EditValue = Nothing Then
            strEnd_Date = Nothing
        Else
            strEnd_Date = End_Date.Text
        End If

        ''-----------------------------------------------------------------------------------------------------------------------------

        Dim strCompany As String

        strCompany = Mid(strInDPT_ID, 1, 4)   '獲得登錄者所屬公司ID,以返回公司名稱，LOGO

        ds.Tables.Clear()
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
        Dim ltc4 As New CollectionToDataSet
        Dim ltc5 As New CollectionToDataSet

        If Str_Choice = "P_PT" Or Str_Choice = "P_PTC" Then  ''個人計件+計時 表   與 匯總表    
            Dim mcCompany As New LFERP.DataSetting.CompanyControler
            Dim PPP As New LFERP.Library.ProductionSumPiecePersonnel.ProductionSumPiecePersonnelControl
            Dim PPT As New LFERP.Library.ProductionSumTimePersonnel.ProductionSumTimePersonnelControl
            Dim PPPS As New LFERP.Library.ProductionPieceProcess.ProductionPieceProcessControl
            Dim PPPa As New LFERP.Library.ProductionPiecePersonnel.ProductionPiecePersonnelControl

            ds.Tables.Clear()
            If PPP.ProductionSumPiecePersonnel_GetList(Nothing, Nothing, strPer_ID, Nothing, strDepID, strFacID, Nothing, Nothing, Nothing, Nothing, Nothing, strStart_Date, Nothing, strEnd_Date, UserName).Count <= 0 Then
                ltc1.CollToDataSet(ds, "ProductionSumPiecePersonnel", PPP.NothingNew)
            Else
                ltc1.CollToDataSet(ds, "ProductionSumPiecePersonnel", PPP.ProductionSumPiecePersonnel_GetList(Nothing, Nothing, strPer_ID, Nothing, strDepID, strFacID, Nothing, Nothing, Nothing, Nothing, Nothing, strStart_Date, Nothing, strEnd_Date, UserName))
            End If


            If PPT.ProductionSumTimePersonnel_GetList(Nothing, strPer_ID, Nothing, strDepID, strFacID, strStart_Date, Nothing, strEnd_Date, Nothing, Nothing, Nothing).Count <= 0 Then
                ltc2.CollToDataSet(ds, "ProductionSumTimePersonnel", PPT.NothingNew)
            Else
                ltc2.CollToDataSet(ds, "ProductionSumTimePersonnel", PPT.ProductionSumTimePersonnel_GetList(Nothing, strPer_ID, Nothing, strDepID, strFacID, strStart_Date, Nothing, strEnd_Date, Nothing, Nothing, Nothing))
            End If


            ltc3.CollToDataSet(ds, "ProductionPieceProcess", PPPS.ProductionPieceProcess_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc4.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(strCompany, Nothing, Nothing, Nothing))
            ltc5.CollToDataSet(ds, "ProductionPiecePersonnel", PPPa.ProductionPiecePersonnel_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))


            If Str_Choice = "P_PT" Then
                PreviewRPT1(ds, "rptProductionPersonnelSumPieceTime", "個人計件表打印", strInUserRank, strInUserRank, True, True)
            ElseIf Str_Choice = "P_PTC" Then
                PreviewRPT1(ds, "rptProductionPersonnelSumPieceTimeCollect", "個人計件匯總表打印", strInUserRank, strInUserRank, True, True)
            End If

        End If

        ''rptProductionWorkGroupSumPieceTime
        If Str_Choice = "G_PT" Or Str_Choice = "G_PTC" Then ''組別承包 計件+計時 表   與 匯總表    
            Dim mcCompany As New LFERP.DataSetting.CompanyControler
            Dim PPG As New LFERP.Library.ProductionSumPieceWorkGroup.ProductionSumPieceWorkGroupControl
            Dim PTG As New LFERP.Library.ProductionSumTimeWorkGroup.ProductionSumTimeWorkGroupControl
            Dim PPPS As New LFERP.Library.ProductionPieceProcess.ProductionPieceProcessControl
            Dim PPPa As New LFERP.Library.ProductionPiecePersonnel.ProductionPiecePersonnelControl

            ds.Tables.Clear()
            If PPG.ProductionSumPieceWorkGroup_GetList(Nothing, Nothing, Nothing, strPer_ID, strDepID, strFacID, Nothing, Nothing, Nothing, Nothing, Nothing, strStart_Date, Nothing, strEnd_Date, UserName).Count <= 0 Then
                ltc1.CollToDataSet(ds, "ProductionSumPieceWorkGroup", PPG.NothingNew)
            Else
                ltc1.CollToDataSet(ds, "ProductionSumPieceWorkGroup", PPG.ProductionSumPieceWorkGroup_GetList(Nothing, Nothing, Nothing, strPer_ID, strDepID, strFacID, Nothing, Nothing, Nothing, Nothing, Nothing, strStart_Date, Nothing, strEnd_Date, UserName))
            End If

            If PTG.ProductionSumTimeWorkGroup_GetList(Nothing, Nothing, strPer_ID, strDepID, strFacID, strStart_Date, Nothing, strEnd_Date, Nothing, Nothing).Count <= 0 Then
                ltc2.CollToDataSet(ds, "ProductionSumTimeWorkGroup", PTG.NothingNew)
            Else
                ltc2.CollToDataSet(ds, "ProductionSumTimeWorkGroup", PTG.ProductionSumTimeWorkGroup_GetList(Nothing, Nothing, strPer_ID, strDepID, strFacID, strStart_Date, Nothing, strEnd_Date, Nothing, Nothing))
            End If

            ltc3.CollToDataSet(ds, "ProductionPieceProcess", PPPS.ProductionPieceProcess_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc4.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(strCompany, Nothing, Nothing, Nothing))
            ltc5.CollToDataSet(ds, "ProductionPiecePersonnel", PPPa.ProductionPiecePersonnel_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

            If Str_Choice = "G_PT" Then
                PreviewRPT1(ds, "rptProductionWorkGroupSumPieceTime", "承包計件表打印", strInUserRank, strInUserRank, True, True)
            ElseIf Str_Choice = "G_PTC" Then
                PreviewRPT1(ds, "rptProductionWorkGroupSumPieceTimeCollect", "承包計件匯總表打印", strInUserRank, strInUserRank, True, True)
            End If

        End If

        ltc1 = Nothing
        ltc2 = Nothing
        ltc3 = Nothing
        ltc4 = Nothing
        ltc5 = Nothing

        Me.Close()

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub



    Private Sub lueFacID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lueFacID.KeyDown, lueDepID.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class