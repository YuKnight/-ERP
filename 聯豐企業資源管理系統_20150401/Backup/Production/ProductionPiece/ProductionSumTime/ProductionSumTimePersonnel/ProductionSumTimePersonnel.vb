Imports LFERP.Library.ProductionPiecePersonnel
Imports LFERP.Library.ProductionSumTimePersonnel
Imports LFERP.Library.ProductionPiecePersonnelDay
Imports LFERP.DataSetting
Imports System.Math

Imports LFERP.Library.ProductionSumTimeSetting


Public Class ProductionSumTimePersonnel

    Dim ds As New DataSet
    ' Dim StrLabDepID As String
    Dim Load_OK As String ''確定Load事件是否已載入完畢

    Private Sub ProductionSumTimePersonnel_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' Me.Dispose()
        Me.Close()
    End Sub

    Private Sub ProductionSumTimePersonnel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_OK = ""

        Clr_Text() ''清除數據

        LabPT_NO.Text = tempValue2
        CaoTypeLabel.Text = MTypeName
        'StrLabDepID = tempValue4

        tempValue2 = Nothing
        MTypeName = Nothing
        tempValue4 = Nothing
        tempValue3 = Nothing

        txtPer_NO.Enabled = True
        cmdAdd.Visible = True
        cmdSave.Visible = True

        CreatTable()

        PT_DateEdit.EditValue = Format(Now, "yyyy/MM/dd")

        'Dim ptc As New ProductionPiecePersonnelDayControl   ''載入 員工編號---姓名---部門 加入無組別員工
        'txtPer_NO.Properties.DataSource = ptc.ProductionPiecePersonnelDay_GetList1("無", Nothing, Nothing, strInDepID, Nothing, PT_DateEdit.EditValue, "False", PT_DateEdit.EditValue, "=")
        'txtPer_NO.Properties.DisplayMember = "Per_Name"
        'txtPer_NO.Properties.ValueMember = "Per_NO"

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
            Case "PTAdd"
                Me.Text = "員工計時--增加"
                Me.LabCaption.Text = "員工計時--增加"
            Case "PTEdit"
                If LoadData(LabPT_NO.Text) = False Then Exit Sub
                Me.Text = "員工計時--修改" & "[" & LabPT_NO.Text & "]"
                Me.LabCaption.Text = "員工計時--修改"
                cmdAdd.Visible = False

            Case "PTView"

                If LoadData(LabPT_NO.Text) = False Then Exit Sub
                '查看
                cmdSave.Visible = False
                cmdAdd.Visible = False
                PT_DateEdit.Enabled = False
                txtPer_NO.Enabled = False

                'StartTimeEdit.Enabled = False
                'EndTimeEdit.Enabled = False
                'txtTotal.Enabled = False
                'MemoPT_Remark.Enabled = False

                Me.Text = "員工計時--查看" & "[" & LabPT_NO.Text & "]"
                Me.LabCaption.Text = "員工計時--查看"
        End Select

        txtPer_NO.Select()
        txtPer_NO.Focus()

        Load_OK = "OK"

    End Sub

    Sub CreatTable()
        ''2012-5-11
        With ds.Tables.Add("Per_NONameT")
            .Columns.Add("Per_NO", GetType(String))
            .Columns.Add("Per_Name", GetType(String))
            .Columns.Add("DepID", GetType(String))
            .Columns.Add("FacID", GetType(String))
            .Columns.Add("Per_DepName", GetType(String))
            .Columns.Add("Per_FacName", GetType(String))
            .Columns.Add("Per_NOName", GetType(String))
        End With
        '
        txtPer_NO.Properties.DisplayMember = "Per_NOName"
        txtPer_NO.Properties.ValueMember = "Per_NO"
        txtPer_NO.Properties.DataSource = ds.Tables("Per_NONameT")
    End Sub


    ''' <summary>
    ''' 載入當天不在組別和組別編號為“無”的個人計件人員名單 2012/6/4 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Load_Table_New() As String
        Load_Table_New = ""


        Dim i As Integer
        Dim ptil As New List(Of ProductionPiecePersonnelDayInfo)
        Dim ptc As New ProductionPiecePersonnelDayControl
        ptil = ptc.ProductionPiecePersonnelTimeDay_GetList(PT_DateEdit.EditValue, strInDepID)

        ds.Tables("Per_NONameT").Clear()

        If ptil.Count > 0 Then
            For i = 0 To ptil.Count - 1
                Dim row As DataRow

                row = ds.Tables("Per_NONameT").NewRow

                row("Per_NO") = ptil(i).Per_NO
                row("Per_Name") = ptil(i).Per_Name

                row("DepID") = ptil(i).DepID
                row("FacID") = ptil(i).FacID

                row("Per_DepName") = ptil(i).Per_DepName
                row("Per_FacName") = ptil(i).Per_FacName

                row("Per_NOName") = ptil(i).Per_NO & "  " & ptil(i).Per_Name

                ds.Tables("Per_NONameT").Rows.Add(row)
            Next
        End If

        'Dim i, count1 As Integer
        'Dim count2 As Integer

        'ds.Tables("Per_NONameT").Clear()

        'Dim ptil As New List(Of ProductionPiecePersonnelInfo)
        'Dim ptc As New ProductionPiecePersonnelControl   '

        'ptil = ptc.ProductionPiecePersonnel_GetList(Nothing, Nothing, Nothing, Nothing, strInDepID, Nothing, Nothing, Nothing, Nothing, "False", Nothing)
        'count1 = ptil.Count
        'If count1 > 0 Then
        '    For i = 0 To count1 - 1

        '        Dim ppil As New List(Of ProductionPiecePersonnelDayInfo)
        '        Dim ppc As New ProductionPiecePersonnelDayControl   '

        '        ppil = ppc.ProductionPiecePersonnelDay_GetList(Nothing, Nothing, ptil(i).Per_NO, Nothing, Nothing, strInDepID, Nothing, Nothing, PT_DateEdit.EditValue, Nothing, "False", PT_DateEdit.EditValue)
        '        count2 = ppil.Count

        '        If count2 <= 0 Or ptil(i).G_NO = "無" Then
        '            Dim row As DataRow
        '            row = ds.Tables("Per_NONameT").NewRow

        '            row("Per_NO") = ptil(i).Per_NO
        '            row("Per_Name") = ptil(i).Per_Name

        '            row("DepID") = ptil(i).DepID
        '            row("FacID") = ptil(i).FacID

        '            row("Per_DepName") = ptil(i).Per_DepName
        '            row("Per_FacName") = ptil(i).Per_FacName
        '            row("Per_NOName") = ptil(i).Per_NO & "  " & ptil(i).Per_Name

        '            ds.Tables("Per_NONameT").Rows.Add(row)
        '        End If
        '    Next
        'End If


    End Function

    ''' <summary>
    '''  取消不用   ''2012-5-11
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Load_Table() As String
        Load_Table = ""

        Dim i, count1 As Integer
        Dim j, count2 As Integer

        ds.Tables("Per_NONameT").Clear()

        Dim ptil As New List(Of ProductionPiecePersonnelInfo)  ''載入基本表中的“無”記錄
        Dim ptc As New ProductionPiecePersonnelControl   '

        ptil = ptc.ProductionPiecePersonnel_GetList1("無", Nothing, Nothing, strInDepID, Nothing, Nothing, "False", Nothing, "=")
        count1 = ptil.Count
        If count1 > 0 Then
            For i = 0 To count1 - 1
                Dim row As DataRow
                row = ds.Tables("Per_NONameT").NewRow

                row("Per_NO") = ptil(i).Per_NO
                row("Per_Name") = ptil(i).Per_Name

                row("DepID") = ptil(i).DepID
                row("FacID") = ptil(i).FacID

                row("Per_DepName") = ptil(i).Per_DepName
                row("Per_FacName") = ptil(i).Per_FacName

                ds.Tables("Per_NONameT").Rows.Add(row)
            Next
        End If

        ''---------------------------------------------------------------------------------------------
        '從每日表中加入

        Dim ppil As New List(Of ProductionPiecePersonnelDayInfo)  ''載入基本表中的“無”記錄
        Dim ppc As New ProductionPiecePersonnelDayControl   '

        ppil = ppc.ProductionPiecePersonnelDay_GetList1(Nothing, Nothing, Nothing, strInDepID, Nothing, PT_DateEdit.EditValue, "False", PT_DateEdit.EditValue, Nothing)
        count2 = ppil.Count
        If count2 > 0 Then
            For j = 0 To count2 - 1
                Dim row As DataRow
                row = ds.Tables("Per_NONameT").NewRow

                row("Per_NO") = ppil(j).Per_NO
                row("Per_Name") = ppil(j).Per_Name

                row("DepID") = ppil(j).DepID
                row("FacID") = ppil(j).FacID

                row("Per_DepName") = ppil(j).Per_DepName
                row("Per_FacName") = ppil(j).Per_FacName

                ds.Tables("Per_NONameT").Rows.Add(row)
                ' GridView2.MoveLast()
            Next
        End If

    End Function
    ''' <summary>
    ''' 根據編號載入數據
    ''' </summary>
    ''' <param name="Str_PT_NO"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function LoadData(ByVal Str_PT_NO As String) As Boolean
        LoadData = False

        Dim objInfo As New ProductionSumTimePersonnelInfo
        Dim objList As New List(Of ProductionSumTimePersonnelInfo)
        Dim oc As New ProductionSumTimePersonnelControl

        objList = oc.ProductionSumTimePersonnel_GetList(Str_PT_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If objList.Count <= 0 Then
            MsgBox("沒有數據！")
            LoadData = False
            Exit Function
        Else
            PT_DateEdit.EditValue = objList(0).PT_Date ''時間
            StartTimeEdit.Text = objList(0).PT_BeginTime
            EndTimeEdit.Text = objList(0).PT_EndTime  '

            txtTotal.Text = objList(0).PT_Total.ToString

            MemoPT_Remark.EditValue = objList(0).PT_Remark   '備注

            labDepID.Text = objList(0).DepID  ' 部門        不讀取，信息根據 員工編號存入
            labFacID.Text = objList(0).FacID  ' 廠別  

            GridLookSampType.EditValue = objList(0).SampID


            '-------------在修改時--如查果是垮部門的，就載入不了，所以加一條記錄--------------------------------------------------------------
            Dim j As Integer
            Dim strBz As String

            strBz = ""
            If ds.Tables("Per_NONameT").Rows.Count > 0 Then
                For j = 0 To ds.Tables("Per_NONameT").Rows.Count - 1
                    If objList(0).Per_NO = ds.Tables("Per_NONameT").Rows(j)("Per_NO") Then
                        strBz = "Y"
                    End If
                Next
            End If

            If strBz = "" Then
                Dim row As DataRow
                row = ds.Tables("Per_NONameT").NewRow

                row("Per_NO") = objList(0).Per_NO
                row("Per_Name") = objList(0).PT_Per_Name

                row("Per_NOName") = objList(0).Per_NO & "  " & objList(0).PT_Per_Name

                row("DepID") = objList(0).DepID
                row("FacID") = objList(0).FacID

                row("Per_DepName") = objList(0).PT_DepName
                row("Per_FacName") = objList(0).PT_FacName

                ds.Tables("Per_NONameT").Rows.Add(row)
            End If

            txtPer_NO.EditValue = objList(0).Per_NO

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
        End If

        If labDepID.Text = "labFacID" Or labDepID.Text = "" Then
            MsgBox("員工所屬部門為空,請重新選擇員工編號!")
            txtPer_NO.Select()
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


        If GridLookSampType.Text = "" Then
            MsgBox("請選擇類型")
            GridLookSampType.Select()
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

        Dim pcA As New LFERP.Library.ProductionSumLock.ProductionSumLockControl
        Dim plA As New List(Of LFERP.Library.ProductionSumLock.ProductionSumLockInfo)
        plA = pcA.ProductionSumLock_GetList(Nothing, Nothing, labDepID.Text, Format(CDate(PT_DateEdit.EditValue), "yyyy/MM"))

        If plA.Count > 0 Then
            If plA(0).LockCheck = True Then
                MsgBox("當前部門記錄已鎖定不能錄入!")
                CheckData = False
                Exit Function
            End If
        End If

    End Function


    ''' <summary>
    ''' 查找 某一員工，當天，在特定時間段，不能參與兩項目計時工作 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function CHECK_Time() As Boolean
        Dim pil As New List(Of ProductionSumTimePersonnelInfo)
        Dim pc As New ProductionSumTimePersonnelControl
        Dim i As Integer

        Dim strDateEnd, strDateStart As DateTime
        Dim strDateEdit_S, strDateEdit_E As DateTime

        Dim CheckHourS1, CheckHourS2 As TimeSpan
        Dim CheckHourE1, CheckHourE2 As TimeSpan

        CHECK_Time = True


        ''修改   和 增加 操作時，修改在查詢數據庫時不包含本記錄,  增加時查詢所有 符合條件的

        If CaoTypeLabel.Text = "PTEdit" Then
            pil = pc.ProductionSumTimePersonnel_GetList(LabPT_NO.Text, txtPer_NO.EditValue, Nothing, Nothing, Nothing, PT_DateEdit.EditValue, Nothing, PT_DateEdit.EditValue, "in", Nothing, Nothing)
        Else
            pil = pc.ProductionSumTimePersonnel_GetList(Nothing, txtPer_NO.EditValue, Nothing, Nothing, Nothing, PT_DateEdit.EditValue, Nothing, PT_DateEdit.EditValue, Nothing, Nothing, Nothing)
        End If


        If pil.Count > 0 Then
        Else
            Exit Function
        End If

        For i = 0 To pil.Count - 1
            ''核查時間段----------------
            If pil(i).PT_BeginTime = Nothing Or pil(i).PT_EndTime = Nothing Then
                CHECK_Time = False
                Exit Function
            End If

            strDateEnd = DateTime.Parse(pil(i).PT_EndTime)  ''記件結束時間              讀取數據庫中的時間段
            strDateStart = DateTime.Parse(pil(i).PT_BeginTime) ''記件開始時間

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

    ''' <summary>
    ''' 數據增加
    ''' </summary>
    ''' <param name="S_model"></param>
    ''' <remarks></remarks>
    Private Sub SaveNew(ByVal S_model As String)
        Dim gc As New ProductionSumTimePersonnelControl
        Dim gi As New ProductionSumTimePersonnelInfo

        LabPT_NO.Text = GetProductionSumTimePersonnelNO()

        If LabPT_NO.Text <> "" Then
        Else
            MsgBox("流水號獲取失敗，請重試!")
        End If

        gi.PT_NO = LabPT_NO.Text  ''要先取得編號
        gi.PT_Date = PT_DateEdit.EditValue  ''統計時間
        
        gi.Per_NO = txtPer_NO.EditValue.Trim '員工工號
        gi.PT_BeginTime = StartTimeEdit.Text
        gi.PT_EndTime = EndTimeEdit.Text

        gi.PT_Total = Val(txtTotal.Text) '合計
        gi.PT_Remark = MemoPT_Remark.Text '備注
        gi.PT_Action = InUserID

        ''取得樣辦,價格---------------------------------------------------------------------------
        Dim PsaC As New LFERP.Library.ProductionPiecePaySampType.ProductionPiecePaySampTypeControl
        Dim PsaL As New List(Of LFERP.Library.ProductionPiecePaySampType.ProductionPiecePaySampTypeInfo)
        PsaL = PsaC.ProductionPiecePaySampType_GetList(GridLookSampType.EditValue, Nothing, True, Nothing)
        gi.SampID = GridLookSampType.EditValue
        gi.SampPrice = PsaL(0).SampPrice
        '-----------------------------------------------------------------------------------------

        ' ''部門，廠別 根據員工編號 從計件人員基本信息表中查詢出存，
        'Dim ptc As New ProductionPiecePersonnelControl
        'Dim pti As New List(Of ProductionPiecePersonnelInfo)
        'pti = ptc.ProductionPiecePersonnel_GetList(Nothing, txtPer_NO.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "False", Nothing)
        'If pti.Count <= 0 Then
        '    Exit Sub
        'End If
        'gi.DepID = pti(0).DepID   ''部門編號
        'gi.FacID = pti(0).FacID   '廠別 

        gi.DepID = labDepID.Text    ''部門編號
        gi.FacID = labFacID.Text    '廠別 


        If S_model = "S" Then
            If gc.ProductionSumTimePersonnel_Add(gi) = True Then
                MsgBox("數據保存成功")
                'Me.Dispose()
                Me.Close()
            End If
        Else
            If gc.ProductionSumTimePersonnel_Add(gi) = False Then
                MsgBox("數據保存失敗")
                'Me.Dispose()
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
        txtPer_NO.EditValue = Nothing
        StartTimeEdit.Text = Nothing
        EndTimeEdit.Text = Nothing
        txtTotal.Text = ""
        MemoPT_Remark.Text = ""
        LabPT_NO.Text = ""

        StartTimeEdit.Text = "00:00"
        EndTimeEdit.Text = "00:00"

        labDepID.Text = ""
        labFacID.Text = ""

        txtPer_NO.Focus()
    End Sub

    ''' <summary>
    ''' 修改數據
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveEdit()
        Dim gc As New ProductionSumTimePersonnelControl
        Dim gi As New ProductionSumTimePersonnelInfo

        gi.PT_NO = LabPT_NO.Text
        gi.PT_Date = PT_DateEdit.Text  ''統計時間

        gi.Per_NO = txtPer_NO.EditValue.Trim '員工工號
        gi.PT_BeginTime = StartTimeEdit.Text
        gi.PT_EndTime = EndTimeEdit.Text

        gi.PT_Total = Val(txtTotal.Text) '合計
        gi.PT_Remark = MemoPT_Remark.Text '備注
        gi.PT_Action = InUserID

        ''取得樣辦,價格---------------------------------------------------------------------------
        Dim PsaC As New LFERP.Library.ProductionPiecePaySampType.ProductionPiecePaySampTypeControl
        Dim PsaL As New List(Of LFERP.Library.ProductionPiecePaySampType.ProductionPiecePaySampTypeInfo)
        PsaL = PsaC.ProductionPiecePaySampType_GetList(GridLookSampType.EditValue, Nothing, True, Nothing)
        gi.SampID = GridLookSampType.EditValue
        gi.SampPrice = PsaL(0).SampPrice
        '-----------------------------------------------------------------------------------------


        ' ''部門，廠別 根據員工編號 從計件人員每日表中查詢出存，
        'Dim ptc As New ProductionPiecePersonnelDayControl
        'Dim pti As New List(Of ProductionPiecePersonnelDayInfo)
        'pti = ptc.ProductionPiecePersonnelDay_GetList(Nothing, txtPer_NO.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "False", Nothing, Nothing)
        'If pti.Count <= 0 Then
        '    Exit Sub
        'End If
        'gi.DepID = pti(0).DepID   ''部門編號
        'gi.FacID = pti(0).FacID   '廠別 

        gi.DepID = labDepID.Text    ''部門編號
        gi.FacID = labFacID.Text    '廠別 


        If gc.ProductionSumTimePersonnel_Update(gi) = True Then
            MsgBox("數據保存成功")
            'Me.Dispose()
            Me.Close()
        End If
    End Sub
    ''' <summary>
    ''' 獲取流水號基數
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetProductionSumTimePersonnelNO() As String
        GetProductionSumTimePersonnelNO = ""

        Dim str1, str2 As String
        Dim gc1 As New ProductionSumTimePersonnelControl
        Dim gi1 As New ProductionSumTimePersonnelInfo

        str1 = Mid(Year(Now), 3)
        If CInt(Month(Now)) < 10 Then
            str2 = "0" & Month(Now)
        Else
            str2 = Month(Now)
        End If

        Dim Stra As String
        Stra = Trim(str1 & str2)

        gi1 = gc1.ProductionSumTimePersonnel_GetNO(Stra) '' 讀取基數

        If gi1 Is Nothing Then
            GetProductionSumTimePersonnelNO = "PT" & str1 & str2 & "0000001"
        Else
            GetProductionSumTimePersonnelNO = "PT" & str1 & str2 & Mid((CInt(Mid(gi1.PT_NO, 7)) + 10000001), 2)
        End If

        
    End Function

    '求兩個時間的數值﹐轉換為分鐘的倍數(）

    Function QJSumDateValue(ByVal Date1 As Date, ByVal Date2 As Date) As Single
        'Dim i, X, Y, z As Long
        'Dim l As Single

        'i = Math.Abs(DateDiff("n", Date1, Date2))
        ''i = DateDiff("n", Date1, Date2)
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


        ''-------------------------------------------
        ''新算法
        Dim strDate1 As DateTime
        Dim strDate2 As DateTime
        Dim CheckHours As TimeSpan

        strDate1 = DateTime.Parse(StartTimeEdit.Text)
        strDate2 = DateTime.Parse(EndTimeEdit.Text)

        CheckHours = strDate2 - strDate1
        QJSumDateValue = Format(CheckHours.TotalHours, "0.00")

        If QJSumDateValue < 0 Then
            QJSumDateValue = QJSumDateValue + 24
        End If


    End Function


    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckData() = False Then Exit Sub
        If CHECK_Time() = False Then Exit Sub '判斷時間段

        If CaoTypeLabel.Text = "PTAdd" Then
            Call SaveNew("A")
            txtPer_NO.Select()
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckData() = False Then Exit Sub '
        If CHECK_Time() = False Then Exit Sub '判斷時間段

        Select Case CaoTypeLabel.Text
            Case "PTAdd"
                Call SaveNew("S")
            Case "PTEdit"
                Call SaveEdit()
        End Select
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        ' Me.Dispose()
        Me.Close()
    End Sub


    Private Sub txtTotal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.GotFocus
        On Error Resume Next
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
            '  txtTotal.Text = QJSumDateValue(CDate(StartTimeEdit.Text), CDate(EndTimeEdit.Text)) ''計算總計時間
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


    Private Sub txtPer_NO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPer_NO.KeyDown
        If e.KeyCode = Keys.Space Then
            txtPer_NO.ShowPopup()
        End If
    End Sub

    Private Sub PT_DateEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PT_DateEdit.EditValueChanged
        'Dim ptc As New ProductionPiecePersonnelDayControl   ''載入 員工編號---姓名---部門
        'txtPer_NO.Properties.DataSource = ptc.ProductionPiecePersonnelDay_GetList1("無", Nothing, Nothing, strInDepID, Nothing, PT_DateEdit.EditValue, "False", PT_DateEdit.EditValue, "=")
        'txtPer_NO.Properties.DisplayMember = "Per_Name"
        'txtPer_NO.Properties.ValueMember = "Per_NO"

        If PT_DateEdit.EditValue Is Nothing Then
        Else
            Load_Table_New()
        End If

    End Sub



    Private Sub SimpLoadPer_NO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpLoadPer_NO.Click
        frmProductionLoadPiecePersonnel.StartPosition = FormStartPosition.Manual
        frmProductionLoadPiecePersonnel.Left = Me.Left + txtPer_NO.Left + 3
        frmProductionLoadPiecePersonnel.Top = Me.Top + txtPer_NO.Top + txtPer_NO.Height + txtPer_NO.Height
        frmProductionLoadPiecePersonnel.Width = txtPer_NO.Width + SimpLoadPer_NO.Width + 3
        frmProductionLoadPiecePersonnel.TextEditPerNO.Focus()

        tempValue2 = strInFacIDFull  ''默認載入本部門的，萬一是廠別權限的用戶登錄時，就有可能出現 將不是本部門的員工加入本部門作業了
        tempValue3 = strInDepIDFull

        frmProductionLoadPiecePersonnel.ShowDialog()


        If tempValue Is Nothing Then
        Else

            Dim i As Integer
            Dim ptil As New List(Of ProductionPiecePersonnelInfo)  '載入指定員工
            Dim ptc As New ProductionPiecePersonnelControl   '

            ptil = ptc.ProductionPiecePersonnel_GetList(Nothing, tempValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "False", Nothing, Nothing)

            If ptil.Count > 0 Then
                For i = 0 To ptil.Count - 1
                    Dim row As DataRow
                    row = ds.Tables("Per_NONameT").NewRow

                    row("Per_NO") = ptil(i).Per_NO
                    row("Per_Name") = ptil(i).Per_Name

                    row("Per_NOName") = ptil(i).Per_NO & "  " & ptil(i).Per_Name

                    ''得到廠家別名稱
                    Dim fc As New FacControler
                    Dim fl As New List(Of FacInfo)
                    fl = fc.GetFacList(tempValue2, Nothing)
                    row("FacID") = tempValue2
                    row("Per_FacName") = fl(0).FacName

                    ''得到部門名稱
                    Dim dc As New DepartmentControler
                    Dim dl As New List(Of DepartmentInfo)
                    dl = dc.BriName_GetList(tempValue3, Nothing, tempValue2)
                    row("DepID") = tempValue3
                    row("Per_DepName") = dl(0).DepName

                    ds.Tables("Per_NONameT").Rows.Add(row)
                Next

                txtPer_NO.EditValue = ptil(0).Per_NO
                labFacID.Text = tempValue2
                labDepID.Text = tempValue3

            Else
                txtPer_NO.EditValue = Nothing
                labFacID.Text = Nothing
                labDepID.Text = Nothing
            End If

        End If


        tempValue3 = Nothing
        tempValue2 = Nothing
        tempValue = Nothing

        frmProductionLoadPiecePersonnel.Dispose()
    End Sub

    Private Sub txtPer_NO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPer_NO.EditValueChanged
        On Error Resume Next
        If Load_OK = "OK" Then
            labDepID.Text = GridLookUpEdit1View.GetFocusedRowCellValue("DepID").ToString
            labFacID.Text = GridLookUpEdit1View.GetFocusedRowCellValue("FacID").ToString
        End If
    End Sub

    Private Sub SimpLoadPer_NO_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpLoadPer_NO.LostFocus
        On Error Resume Next
        If Load_OK = "OK" Then
            labDepID.Text = GridLookUpEdit1View.GetFocusedRowCellValue("DepID").ToString
            labFacID.Text = GridLookUpEdit1View.GetFocusedRowCellValue("FacID").ToString
        End If
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