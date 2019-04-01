Imports LFERP.Library.ProductionPieceWorkGroup
Imports LFERP.Library.ProductionPiecePersonnelDay
Imports LFERP.Library.ProductionPiecePersonnel
Imports LFERP.Library.ProductionSumTimeWorkGroup
Imports System.Math
Imports LFERP.Library.ProductionSumTimeSetting

Public Class ProductionSumTimeWorkGroup
    'Dim StrDepID As String
    Dim Load_OK As String ''確定Load事件是否已載入完畢

    Private Sub ProductionSumTimeWorkGroup_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' Me.Dispose()
        Me.Close()
    End Sub

    Private Sub ProductionSumTimeWorkGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Clr_Text()
        Load_OK = ""

        LabGT_NO.Text = tempValue2
        CaoTypeLabel.Text = MTypeName
        'StrDepID = tempValue4

        tempValue2 = Nothing
        MTypeName = Nothing
        tempValue4 = Nothing

        cmdSave.Visible = True
        cmdAdd.Visible = True
        GT_DateEdit.Enabled = True
        txtPer_NO.Enabled = True

        GT_DateEdit.EditValue = Format(Now, "yyyy/MM/dd")

        'Dim ptc As New ProductionPiecePersonnelDayControl   ''載入 員工編號---姓名---部門 有組別 <> 無
        'txtPer_NO.Properties.DataSource = ptc.ProductionPiecePersonnelDay_GetList1("無", Nothing, Nothing, strInDepID, Nothing, GT_DateEdit.EditValue, "False", GT_DateEdit.EditValue, "<>")
        'txtPer_NO.Properties.DisplayMember = "Per_Name"
        'txtPer_NO.Properties.ValueMember = "Per_NO"

        ''2012-6-5 改為 先選組別編號，再選擇員工編號
        Dim pc As New ProductionPieceWorkGroupControl
        GluG_NO.Properties.DisplayMember = "G_NOName"
        GluG_NO.Properties.ValueMember = "G_NO"
        GluG_NO.Properties.DataSource = pc.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, strInDepID, Nothing, Nothing, Nothing, Nothing)



        '----------------------------------------------------------------------
        GridLookSampType.Properties.ValueMember = "SampID"
        GridLookSampType.Properties.DisplayMember = "SampName"
        Dim Psam As New LFERP.Library.ProductionPiecePaySampType.ProductionPiecePaySampTypeControl

        If strInUserRank = "統計" Then
            GridLookSampType.Properties.DataSource = Psam.ProductionPiecePaySampType_GetList(Nothing, Nothing, True, strInDepIDFull)
        Else
            GridLookSampType.Properties.DataSource = Psam.ProductionPiecePaySampType_GetList(Nothing, Nothing, True, Nothing)
        End If

        GridLookSampType.EditValue = "Z"

        '----------------------------------------------------------------------


        Select Case CaoTypeLabel.Text
            Case "GTAdd"
                Me.Text = "組別計時--增加"
                LabCaption.Text = "組別計時--增加"
            Case "GTEdit"
                If LoadData(LabGT_NO.Text) = False Then Exit Sub
                Me.Text = "組別計時--修改" & "[" & LabGT_NO.Text & "]"
                LabCaption.Text = "組別計時--修改"
                cmdAdd.Visible = False

            Case "GTView"

                If LoadData(LabGT_NO.Text) = False Then Exit Sub
                '查看
                cmdSave.Visible = False
                cmdAdd.Visible = False
                GT_DateEdit.Enabled = False
                txtPer_NO.Enabled = False


                LabCaption.Text = "組別計時--查看"
                Me.Text = "組別計時--查看" & "[" & LabGT_NO.Text & "]"
        End Select

        GT_DateEdit.Focus()
        Load_OK = "OK"

    End Sub

    ''' <summary>
    ''' 根據編號載入數據
    ''' </summary>
    ''' <param name="Str_GT_NO "></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function LoadData(ByVal Str_GT_NO As String) As Boolean
        LoadData = False

        Dim objInfo As New ProductionSumTimeWorkGroupInfo
        Dim objList As New List(Of ProductionSumTimeWorkGroupInfo)
        Dim oc As New ProductionSumTimeWorkGroupControl

        objList = oc.ProductionSumTimeWorkGroup_GetList(Str_GT_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If objList.Count <= 0 Then
            MsgBox("沒有數據！")
            LoadData = False
            Exit Function
        Else
            GT_DateEdit.EditValue = objList(0).GT_Date ''時間


            StartTimeEdit.Text = objList(0).GT_BeginTime
            EndTimeEdit.Text = objList(0).GT_EndTime  '

            txtTotal.Text = objList(0).GT_Total.ToString

            MemoGT_Remark.EditValue = objList(0).GT_Remark   '備注

            'labDepID.Text = objList(0).DepID    ''部門編號
            'labFacID.Text = objList(0).FacID    '廠別

            GluG_NO.EditValue = objList(0).G_NO  '先有組別，再顯人員 
            txtPer_NO.EditValue = objList(0).Per_NO


            GridLookSampType.EditValue = objList(0).SampID

            LoadData = True
        End If

    End Function


    ''' <summary>
    ''' 檢查數據輸入正確
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function CheckData() As Boolean
        CheckData = True

        If txtPer_NO.EditValue = "" Then
            MsgBox("請選擇員工編號")
            txtPer_NO.Select()
            CheckData = False
            Exit Function
        End If '


        If GluG_NO.EditValue = "" Then
            MsgBox("請選擇組別信息")
            GluG_NO.Select()
            CheckData = False
            Exit Function
        End If '


        If GridLookSampType.Text = "" Then
            MsgBox("請選擇類型")
            GridLookSampType.Select()
            CheckData = False
            Exit Function
        End If


        If Val(txtTotal.Text) > 0 Then
        Else
            MsgBox("開始或結束時間輸入有誤，請檢查")
            StartTimeEdit.Focus()
            StartTimeEdit.SelectAll()
            CheckData = False
            Exit Function
        End If

        On Error Resume Next

        Dim date1 As Date
        Dim date2 As Date

        date1 = CDate(StartTimeEdit.Text)

        If Err.Number > 0 Then
            StartTimeEdit.Focus()
            StartTimeEdit.SelectAll()
            MsgBox("你輸入的時間格式有誤,請檢查!")
            CheckData = False
            Exit Function
        End If

        date2 = CDate(EndTimeEdit.Text)

        If Err.Number > 0 Then
            EndTimeEdit.Focus()
            EndTimeEdit.SelectAll()
            MsgBox("你輸入的時間格式有誤,請檢查!")
            CheckData = False
            Exit Function
        End If

        'If DateDiff("n", CDate(StartTimeEdit.Text), CDate(EndTimeEdit.Text)) > 0 Then
        'Else
        '    MsgBox("開始或結束時間輸入有誤，請檢查")
        '    CheckData = False
        '    If Val(txtTotal.Text) < 0 Then
        '        StartTimeEdit.Focus()
        '        StartTimeEdit.SelectAll()
        '    Else
        '        EndTimeEdit.Focus()
        '        EndTimeEdit.SelectAll()
        '    End If
        '    Exit Function
        'End If

        If CSng(txtTotal.Text) = QJSumDateValue(CDate(StartTimeEdit.Text), CDate(EndTimeEdit.Text)) Then ''計算總計時間 判斷最后  輸入的合計時間與計算的是否一樣 
        Else
            If MsgBox("合計時間計算有誤，你確定要繼續保存嗎？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Else
                CheckData = False
                Exit Function
            End If
        End If


        ''2012-12-25
        Dim pc As New ProductionPieceWorkGroupControl
        Dim pcil As New List(Of ProductionPieceWorkGroupInfo)
        pcil = pc.ProductionPieceWorkGroup_GetList(GluG_NO.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pcil.Count <= 0 Then
        Else

            Dim pcA As New LFERP.Library.ProductionSumLock.ProductionSumLockControl
            Dim plA As New List(Of LFERP.Library.ProductionSumLock.ProductionSumLockInfo)
            plA = pcA.ProductionSumLock_GetList(Nothing, Nothing, pcil(0).DepID, Format(CDate(GT_DateEdit.EditValue), "yyyy/MM"))

            If plA.Count > 0 Then
                If plA(0).LockCheck = True Then
                    MsgBox("當前部門記錄已鎖定不能錄入!")
                    CheckData = False
                    Exit Function
                End If
            End If
        End If
    End Function

    ''' <summary>
    ''' 查找 某一員工，當天，在特定時間段，不能參與兩項目計時工作 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function CHECK_Time() As Boolean
        Dim pil As New List(Of ProductionSumTimeWorkGroupInfo)
        Dim pc As New ProductionSumTimeWorkGroupControl
        Dim i As Integer

        Dim strDateEnd, strDateStart As DateTime
        Dim strDateEdit_S, strDateEdit_E As DateTime

        Dim CheckHourS1, CheckHourS2 As TimeSpan
        Dim CheckHourE1, CheckHourE2 As TimeSpan

        CHECK_Time = True
        If CaoTypeLabel.Text = "GTEdit" Then
            pil = pc.ProductionSumTimeWorkGroup_GetList(LabGT_NO.Text, txtPer_NO.EditValue, Nothing, Nothing, Nothing, GT_DateEdit.EditValue, Nothing, GT_DateEdit.EditValue, "in", Nothing)
        Else
            pil = pc.ProductionSumTimeWorkGroup_GetList(Nothing, txtPer_NO.EditValue, Nothing, Nothing, Nothing, GT_DateEdit.EditValue, Nothing, GT_DateEdit.EditValue, Nothing, Nothing)
        End If

        If pil.Count > 0 Then
        Else
            Exit Function
        End If

        For i = 0 To pil.Count - 1
            ''核查時間段----------------
            If pil(i).GT_BeginTime = Nothing Or pil(i).GT_EndTime = Nothing Then
                CHECK_Time = False
                Exit Function
            End If

            strDateEnd = DateTime.Parse(pil(i).GT_EndTime)  ''記件結束時間              讀取數據庫中的時間段
            strDateStart = DateTime.Parse(pil(i).GT_BeginTime) ''記件開始時間

            strDateEdit_S = DateTime.Parse(StartTimeEdit.Text)  ''要加入的時間         要求保存的時間段
            strDateEdit_E = DateTime.Parse(EndTimeEdit.Text)

            ''-----------------------------------------------------------
            CheckHourS1 = strDateEdit_S - strDateStart   ''>0
            CheckHourS2 = strDateEdit_S - strDateEnd     ''<0

            If CheckHourS1.TotalHours >= 0 And CheckHourS2.TotalHours <= 0 Then
                CHECK_Time = False
                StartTimeEdit.Focus()
                MsgBox("在遷定時間段中，此人員已參與作！")
                Exit Function
            End If
            ''-+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            CheckHourE1 = strDateEdit_E - strDateStart   ''>0
            CheckHourE2 = strDateEdit_E - strDateEnd     ''<0

            If CheckHourE1.TotalHours >= 0 And CheckHourE2.TotalHours <= 0 Then
                CHECK_Time = False
                EndTimeEdit.Focus()
                MsgBox("在遷定時間段中，此人員已參與作！")
                Exit Function
            End If
        Next
    End Function


    '求兩個時間的數值﹐轉換為分鐘的倍數(）

    Function QJSumDateValue(ByVal Date1 As Date, ByVal Date2 As Date) As Single
        'Dim i, X, Y, z As Long
        'Dim l As Single

        'i = Math.Abs(DateDiff("n", Date1, Date2))
        '' i = DateDiff("n", Date1, Date2)
        'l = Math.Round(i / 60, 1)
        'Y = 0

        'For X = 1 To Len(l)
        '    If Mid(l, X, 1) = "." Then
        '        Y = X
        '        Exit For
        '    End If
        'Next
        'If Y = 0 Then
        '    QJSumDateValue = l
        'Else
        '    z = i - (CLng(Mid(l, 1, Y - 1) * 60))
        '    Select Case z
        '        Case 1 To 14
        '            QJSumDateValue = CLng(Mid(l, 1, Y - 1))
        '        Case 15 To 44
        '            QJSumDateValue = CLng(Mid(l, 1, Y - 1)) + 0.5
        '        Case 45 To 59
        '            QJSumDateValue = CLng(Mid(l, 1, Y - 1)) + 1
        '        Case Else
        '            QJSumDateValue = Y
        '    End Select
        'End If

        ''------------------------------

        Dim strDate1 As DateTime
        Dim strDate2 As DateTime
        Dim CheckHours As TimeSpan

        strDate1 = DateTime.Parse(StartTimeEdit.Text)
        strDate2 = DateTime.Parse(EndTimeEdit.Text)

        CheckHours = strDate2 - strDate1
        ' QJSumDateValue = Math.Abs(CSng(Format(CheckHours.TotalHours, "0.00")))
        QJSumDateValue = Format(CheckHours.TotalHours, "0.00")

        If QJSumDateValue < 0 Then
            QJSumDateValue = QJSumDateValue + 24
        End If
    End Function


    ''' <summary>
    ''' 數據增加
    ''' </summary>
    ''' <param name="S_model"></param>
    ''' <remarks></remarks>
    Private Sub SaveNew(ByVal S_model As String)
        Dim gc As New ProductionSumTimeWorkGroupControl
        Dim gi As New ProductionSumTimeWorkGroupInfo

        LabGT_NO.Text = GetProductionSumTimeWorkGroupNO()

        If LabGT_NO.Text <> "" Then
        Else
            MsgBox("流水號獲取失敗，請重試!")
        End If

        gi.GT_NO = LabGT_NO.Text  ''要先取得編號
        gi.GT_Date = GT_DateEdit.EditValue  ''統計時間

        gi.Per_NO = txtPer_NO.EditValue.Trim '員工工號
        gi.GT_BeginTime = StartTimeEdit.Text
        gi.GT_EndTime = EndTimeEdit.Text

        gi.G_NO = GluG_NO.EditValue ''組別
        gi.GT_Total = Val(txtTotal.Text) '合計
        gi.GT_Remark = MemoGT_Remark.Text '備注

        gi.GT_Action = InUserID

        ''取得樣辦,價格---------------------------------------------------------------------------
        Dim PsaC As New LFERP.Library.ProductionPiecePaySampType.ProductionPiecePaySampTypeControl
        Dim PsaL As New List(Of LFERP.Library.ProductionPiecePaySampType.ProductionPiecePaySampTypeInfo)
        PsaL = PsaC.ProductionPiecePaySampType_GetList(GridLookSampType.EditValue, Nothing, True, Nothing)
        gi.SampID = GridLookSampType.EditValue
        gi.SampPrice = PsaL(0).SampPrice
        '-----------------------------------------------------------------------------------------

        '' ''部門，廠別 根據員工編號 從計件人員基本信息表中查詢出存，
        ''Dim ptc As New ProductionPiecePersonnelControl
        ''Dim pti As New List(Of ProductionPiecePersonnelInfo)
        ''pti = ptc.ProductionPiecePersonnel_GetList(Nothing, txtPer_NO.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "False", Nothing)
        ''If pti.Count <= 0 Then
        ''    Exit Sub
        ''End If
        ''gi.DepID = pti(0).DepID   ''部門編號
        ''gi.FacID = pti(0).FacID   '廠別 

        '根據組別 查詢出要保存的部門/與廠別
        Dim pc As New ProductionPieceWorkGroupControl
        Dim pcil As New List(Of ProductionPieceWorkGroupInfo)
        pcil = pc.ProductionPieceWorkGroup_GetList(GluG_NO.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pcil.Count <= 0 Then
            Exit Sub
        End If
        gi.DepID = pcil(0).DepID
        gi.FacID = pcil(0).FacID


        If S_model = "S" Then
            If gc.ProductionSumTimeWorkGroup_Add(gi) = True Then
                MsgBox("數據保存成功")
                'Me.Dispose()
                Me.Close()
            End If
        Else
            If gc.ProductionSumTimeWorkGroup_Add(gi) = False Then
                MsgBox("數據保存失敗")
                ' Me.Dispose()
                Me.Close()
            Else
                Clr_Text()
            End If
        End If
    End Sub

    ''' <summary>
    ''' 清空數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub Clr_Text()

        GluG_NO.EditValue = Nothing
        ' GluG_NO.Properties.DataSource = Nothing
        txtPer_NO.EditValue = Nothing
        StartTimeEdit.Text = Nothing
        EndTimeEdit.Text = Nothing
        txtTotal.Text = ""
        MemoGT_Remark.Text = ""

        StartTimeEdit.Text = "00:00"
        EndTimeEdit.Text = "00:00"

        labDepID.Text = ""
        labFacID.Text = ""

        GluG_NO.Focus()
    End Sub



    ''' <summary>
    ''' 修改數據
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveEdit()
        Dim gc As New ProductionSumTimeWorkGroupControl
        Dim gi As New ProductionSumTimeWorkGroupInfo

        gi.GT_NO = LabGT_NO.Text
        gi.GT_Date = GT_DateEdit.Text  ''統計時間


        gi.Per_NO = txtPer_NO.EditValue.Trim '員工工號
        gi.GT_BeginTime = StartTimeEdit.Text
        gi.GT_EndTime = EndTimeEdit.Text
        gi.GT_Total = Val(txtTotal.Text) '合計

        gi.G_NO = GluG_NO.EditValue ''組別
        gi.GT_Remark = MemoGT_Remark.Text '備注
        gi.GT_Action = InUserID


        ''取得樣辦,價格---------------------------------------------------------------------------
        Dim PsaC As New LFERP.Library.ProductionPiecePaySampType.ProductionPiecePaySampTypeControl
        Dim PsaL As New List(Of LFERP.Library.ProductionPiecePaySampType.ProductionPiecePaySampTypeInfo)
        PsaL = PsaC.ProductionPiecePaySampType_GetList(GridLookSampType.EditValue, Nothing, True, Nothing)
        gi.SampID = GridLookSampType.EditValue
        gi.SampPrice = PsaL(0).SampPrice
        '-----------------------------------------------------------------------------------------

        '' ''部門，廠別 根據員工編號 從計件人員基本信息表中查詢出存，
        ''Dim ptc As New ProductionPiecePersonnelControl
        ''Dim pti As New List(Of ProductionPiecePersonnelInfo)
        ''pti = ptc.ProductionPiecePersonnel_GetList(Nothing, txtPer_NO.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "False", Nothing)
        ''If pti.Count <= 0 Then
        ''    Exit Sub
        ''End If
        ''gi.DepID = pti(0).DepID   ''部門編號
        ''gi.FacID = pti(0).FacID   '廠別 

        '根據組別 查詢出要保存的部門/與廠別
        Dim pc As New ProductionPieceWorkGroupControl
        Dim pcil As New List(Of ProductionPieceWorkGroupInfo)
        pcil = pc.ProductionPieceWorkGroup_GetList(GluG_NO.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pcil.Count <= 0 Then
            Exit Sub
        End If
        gi.DepID = pcil(0).DepID
        gi.FacID = pcil(0).FacID


        If gc.ProductionSumTimeWorkGroup_Update(gi) = True Then
            MsgBox("數據保存成功")
            '  Me.Dispose()
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' 獲取流水號基數
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetProductionSumTimeWorkGroupNO() As String
        GetProductionSumTimeWorkGroupNO = ""

        Dim str1, str2 As String
        Dim gc1 As New ProductionSumTimeWorkGroupControl
        Dim gi1 As New ProductionSumTimeWorkGroupInfo

        str1 = Mid(Year(Now), 3)
        If CInt(Month(Now)) < 10 Then
            str2 = "0" & Month(Now)
        Else
            str2 = Month(Now)
        End If

        Dim Stra As String
        Stra = Trim(str1 & str2)

        gi1 = gc1.ProductionSumTimeWorkGroup_GetNO(Stra) '' 讀取基數

        If gi1 Is Nothing Then
            GetProductionSumTimeWorkGroupNO = "GT" & str1 & str2 & "0000001"
        Else
            GetProductionSumTimeWorkGroupNO = "GT" & str1 & str2 & Mid((CInt(Mid(gi1.GT_NO, 7)) + 10000001), 2)
        End If

    End Function

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        'Me.Dispose()
        Me.Close()
    End Sub
    ''' <summary>
    ''' 添加
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckData() = False Then Exit Sub
        If CHECK_Time() = False Then Exit Sub

        If CaoTypeLabel.Text = "GTAdd" Then
            Call SaveNew("A")
            GluG_NO.Select()
        End If
    End Sub
    ''' <summary>
    ''' 保存
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckData() = False Then Exit Sub
        If CHECK_Time() = False Then Exit Sub


        Select Case CaoTypeLabel.Text
            Case "GTAdd"
                Call SaveNew("S")
            Case "GTEdit"
                Call SaveEdit()
        End Select
    End Sub

    Private Sub txtTotal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.GotFocus
        On Error Resume Next
        If Load_OK = "OK" Then
            'txtTotal.Text = QJSumDateValue(CDate(StartTimeEdit.Text), CDate(EndTimeEdit.Text)) ''計算總計時間
        End If
    End Sub

    Private Sub EndTimeEdit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EndTimeEdit.GotFocus
        EndTimeEdit.SelectAll()
    End Sub

    Private Sub EndTimeEdit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EndTimeEdit.LostFocus
        On Error Resume Next
        Dim date1 As Date
        date1 = CDate(EndTimeEdit.Text)

        If Err.Number > 0 Then
            EndTimeEdit.Focus()
            EndTimeEdit.SelectAll()
            Exit Sub
            ' MsgBox("你輸入的時間格式有誤,請重新輸入!")
        End If

        If Load_OK = "OK" Then
            'txtTotal.Text = QJSumDateValue(CDate(StartTimeEdit.Text), CDate(EndTimeEdit.Text)) ''計算總計時間
            Dim TempDoub As Double
            TempDoub = Get_Tatal_Time(StartTimeEdit.Text, EndTimeEdit.Text)

            If TempDoub = 0 Then
                txtTotal.Text = QJSumDateValue(CDate(StartTimeEdit.Text), CDate(EndTimeEdit.Text)) ''計算總計時間
            Else
                txtTotal.Text = TempDoub
            End If
        End If
    End Sub

    Private Sub StartTimeEdit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles StartTimeEdit.GotFocus
        StartTimeEdit.SelectAll()
    End Sub

    Private Sub StartTimeEdit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles StartTimeEdit.LostFocus
        On Error Resume Next
        Dim date1 As Date

        date1 = CDate(StartTimeEdit.Text)

        If Err.Number > 0 Then
            StartTimeEdit.Focus()
            StartTimeEdit.SelectAll()
            ' MsgBox("你輸入的時間格式有誤,請重新輸入!")
        End If
    End Sub

    Private Sub txtPer_NO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPer_NO.EditValueChanged
        'If txtPer_NO.EditValue <> "" Then

        '    If Load_OK = "OK" Then
        '        labDepID.Text = GridLookUpEdit1View.GetFocusedRowCellValue("DepID").ToString
        '        labFacID.Text = GridLookUpEdit1View.GetFocusedRowCellValue("FacID").ToString
        '    End If

        '    ''載入組別信息
        '    Dim pc As New ProductionPiecePersonnelDayControl

        '    GluG_NO.Properties.DisplayMember = "Per_G_Name"
        '    GluG_NO.Properties.ValueMember = "G_NO"
        '    GluG_NO.Properties.DataSource = pc.ProductionPiecePersonnelDay_GetList(Nothing, Nothing, txtPer_NO.EditValue, Nothing, Nothing, labDepID.Text, Nothing, Nothing, GT_DateEdit.EditValue, Nothing, "False", GT_DateEdit.EditValue)
        'End If
    End Sub


    Private Sub GluG_NO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GluG_NO.KeyDown, txtPer_NO.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub

    Private Sub GT_DateEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GT_DateEdit.EditValueChanged
        'Dim ptc As New ProductionPiecePersonnelDayControl   ''載入 員工編號---姓名---部門
        'txtPer_NO.Properties.DataSource = ptc.ProductionPiecePersonnelDay_GetList1("無", Nothing, Nothing, strInDepID, Nothing, GT_DateEdit.EditValue, "False", GT_DateEdit.EditValue, "<>")
        'txtPer_NO.Properties.DisplayMember = "Per_Name"
        'txtPer_NO.Properties.ValueMember = "Per_NO"
    End Sub

    Private Sub GluG_NO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GluG_NO.EditValueChanged
        If GluG_NO.EditValue Is Nothing Then Exit Sub
        Dim ptc As New ProductionPiecePersonnelDayControl   ''載入 員工編號---姓名---部門 有組別 <> 無
        txtPer_NO.Properties.DataSource = ptc.ProductionPiecePersonnelDay_GetList(Nothing, Nothing, Nothing, Nothing, GluG_NO.EditValue, Nothing, Nothing, Nothing, GT_DateEdit.EditValue, Nothing, "False", GT_DateEdit.EditValue, Nothing)
        txtPer_NO.Properties.DisplayMember = "Per_NOName"
        txtPer_NO.Properties.ValueMember = "Per_NO"
    End Sub

    ''' <summary>
    ''' 查詢出設置OK的時長
    ''' </summary>
    ''' <param name="Stime"></param>
    ''' <param name="Etime"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Get_Tatal_Time(ByVal Stime As String, ByVal Etime As String) As Double


        Dim pc As New ProductionSumTimeSettingControl
        Dim pil As New List(Of ProductionSumTimeSettingInfo)

        pil = pc.ProductionSumTimeSetting_GetList(Nothing, Stime, Etime)

        If pil.Count > 0 Then
            Get_Tatal_Time = pil(0).TotalTime
        End If


    End Function



    Private Sub GridLookSampType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridLookSampType.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub
End Class