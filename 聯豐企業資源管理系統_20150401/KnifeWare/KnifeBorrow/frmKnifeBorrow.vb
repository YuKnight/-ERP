Imports EncodeMy
Imports LFERP.Library.KnifeWare
Imports LFERP.Library.WareHouse
Imports LFERP.SystemManager

Public Class frmKnifeBorrow
    Dim ds As New DataSet
    Public strWHID As String
    Public strWH_Name As String

    Dim LoadStr As String
    Dim LabStr As String
    Dim strAutoID As String
    Dim JS As Integer = 0

    '員工工號屬性
    Private m_StrBNo As String
    Public Property StrBNo() As String
        Get
            Return m_StrBNo
        End Get
        Set(ByVal value As String)
            m_StrBNo = value
        End Set
    End Property

    ''倉庫ID 
    'Private m_StrWHID As String
    'Public Property WHID() As String
    '    Get
    '        Return m_StrWHID
    '    End Get
    '    Set(ByVal value As String)
    '        m_StrWHID = value
    '    End Set
    'End Property


    Private Sub frmKnifeBorrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTables()
        cmdSave.Enabled = False

        ' strAutoID = tempValue

        txtWH.Tag = strWHID
        txtWH.Text = strWH_Name

        LabType.Text = tempValue3
        txtB_NO.Text = tempValue4
        LoadStr = tempValue5

        tempValue3 = Nothing
        tempValue = Nothing
        tempValue2 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing
        tempValue7 = Nothing

        LabStr = LabType.Text
        Select Case LabStr
            Case "AddNew", "AddOld"
                ''載入上限
                '********************************************************2013-11-14 姚駿註釋*************
                'Dim knl As New List(Of KnifeWhiteUserInfo)
                'Dim knc As New KnifeWhiteUserController
                'knl = knc.WhiteUser_GetList(strAutoID, Nothing, Nothing, Nothing, Nothing, False)
                'LabSX.Text = knl(0).WMax
                'txtWH.Tag = knl(0).WH_ID
                'txtWH.Text = knl(0).WH_Name
                'LabPerNO.Text = knl(0).W_UserID
                'labBPer_Name.Text = knl(0).W_UserName

                'strWHID = knl(0).WH_ID
                '*****************************************************************************************
                ''-----------------------------------------------------------------

                If LabStr = "AddNew" Then
                    txtB_Type.Text = "新刀"
                    Me.Text = "借刀登記-新刀"
                    LabMsg.Text = "借刀登記-新刀"
                Else
                    txtB_Type.Text = "待處理"
                    Me.Text = "借刀登記-待處理"
                    LabMsg.Text = "借刀登記-待處理"
                End If

                DateB_Date.Enabled = False
                DateB_Date.EditValue = Format(Now, "yyyy/MM/dd")

                If LoadStr <> "" Then  ''載入選中的
                    AddRow(LoadStr, 1)
                End If

                Dim reset As New ResetPassWords.SetPassWords
                reset.SetPassWords()

            Case "View"
                cmdSave.Visible = False
                LoadData()

        End Select
 


    End Sub



    Sub CreateTables()
        ds.Tables.Clear()
        With ds.Tables.Add("KnifeBorrow")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("B_Num", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))

            .Columns.Add("B_Qty", GetType(Int32))
            .Columns.Add("B_Remark", GetType(String))
            .Columns.Add("B_EndQty", GetType(Int32))
            .Columns.Add("B_AllEndQty", GetType(Int32))

            '查詢出這個人，所有此刀的未還數
            .Columns.Add("B_AllNoReturn", GetType(Int32))

        End With

        Grid1.DataSource = ds.Tables("KnifeBorrow")

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub popWareOutAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutAdd.Click
        tempCode = ""
        tempValue5 = strWHID
        tempValue6 = "Knife"
        tempValue7 = "借刀出庫作業"
        frmKnifeBOMSelect.ShowDialog()

        If frmKnifeBOMSelect.XtraTabControl1.SelectedTabPageIndex = 0 Then
            '增加記錄
            If tempCode = "" Then
                Exit Sub
            Else
                AddRow(tempCode, 0)
            End If
        End If
        tempValue7 = ""
        tempValue8 = ""
    End Sub

    Sub AddRow(ByVal strCode As String, ByVal strQty As Single)
        Dim row As DataRow
        row = ds.Tables("KnifeBorrow").NewRow

        If strCode = "" Then
        Else
            Dim j As Integer
            For j = 0 To ds.Tables("KnifeBorrow").Rows.Count - 1
                If strCode = ds.Tables("KnifeBorrow").Rows(j)("M_Code") Then
                    MsgBox("物料已存在，同一張借刀單中不允許存在相同的刀具編碼！", 64, "提示")
                    GridView1.FocusedRowHandle = j
                    Exit Sub
                End If
            Next

            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)

            'If objInfo.M_IsEnabled = False Then
            '    MsgBox("當前刀具不可用，請確認此物料信息！", 64, "提示")
            '    Exit Sub
            'End If

            row("M_Code") = objInfo.M_Code
            row("M_Name") = objInfo.M_Name
            row("M_Gauge") = objInfo.M_Gauge
            '’-----------------子--------------------------------
            Dim wi6 As LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
            Dim wc6 As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl
            wi6 = wc6.KnifeWareInventorySub_GetList(strCode, strWHID)
            If wi6 Is Nothing Then
                row("B_EndQty") = 0
            Else
                If LabStr = "AddNew" Then
                    row("B_EndQty") = wi6.WI_SQty
                ElseIf LabStr = "AddOld" Then
                    row("B_EndQty") = wi6.WI_SReQty
                End If
            End If

            row("B_Qty") = 0

            '---------------------------------------------

            row("B_AllNoReturn") = GetNORerurn(txtBPer_ID.Text, strCode, strWHID)



            ''------------------------------------------------------
            ds.Tables("KnifeBorrow").Rows.Add(row)
            ''@ 2013/6/11 添加 新增的物料信息在LCD顯示屏上顯示
            'If isShowLCD = True Then
            '    LoadPingMU("借樣辦刀", "名稱：" & ds.Tables("Borrow").Rows(GridView1.FocusedRowHandle)("M_Name"), "規格：" & ds.Tables("Borrow").Rows(GridView1.FocusedRowHandle)("M_Gauge"), "數量：" & ds.Tables("Borrow").Rows(GridView1.FocusedRowHandle)("Qty") & ds.Tables("Borrow").Rows(GridView1.FocusedRowHandle)("M_Unit"))
            'End If
        End If
        GridView1.MoveLast()
    End Sub

    Private Sub sk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sk.Click

        'Me.txtBPer_ID.Text = ReadCard1()
        'Dim bPerId As String = "10020433"

        '************************************************************************************
        '*********************************2013-11-15 姚駿新增修改****************************
        Dim bPerId As String = ReadCard1()
        If bPerId = "" Then Exit Sub

        'Dim strWHRemark As String
        'Dim wc As New WareHouseController
        'Dim wl As New List(Of WareHouseInfo)
        'wl = wc.WareHouse_Get(strWHID)
        'strWHRemark = wl(0).WH_Remark  '如果是夜班倉

        Dim knl As New List(Of KnifeWhiteUserInfo)
        Dim knc As New KnifeWhiteUserController

        If GetNightWareHouse(strWHID) = True Then
            knl = knc.WhiteUser_NightGetList(strWHID, bPerId)
        Else
            knl = knc.WhiteUser_GetListAll(Nothing, bPerId, strWHID, Nothing, Nothing, False)
        End If

        If knl Is Nothing Then
            LoadPingMU("非法卡號！", "", "", "")
            MsgBox(" 查詢對象未實例化!", 64, "提示")
            Exit Sub
        End If

        If knl.Count = 0 Then
            LoadPingMU("非法卡號！", "", "", "")
            MsgBox(bPerId & " 無在[" & strWHID & "]領刀的權限!", 64, "提示")
            Exit Sub
        End If

        Try
            Me.txtBPer_ID.Text = bPerId
            LabSX.Text = knl(0).WMax
            'txtWH.Tag = knl(0).WH_ID
            ' txtWH.Text = knl(0).WH_Name
            LabPerNO.Text = knl(0).W_UserID
            labBPer_Name.Text = knl(0).W_UserName

            ' strWHID = knl(0).WH_ID

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
        '************************************************************************************

        ''加白名單
        If Me.txtBPer_ID.Text <> "" Then
            cmdSave.Enabled = True
            sk.Enabled = False
        End If
        ''顯示屏
        Dim k As Integer

        If ds.Tables("KnifeBorrow").Rows.Count > 0 Then
            For k = 0 To ds.Tables("KnifeBorrow").Rows.Count - 1
                ds.Tables("KnifeBorrow").Rows(k)("B_AllNoReturn") = GetNORerurn(txtBPer_ID.Text, ds.Tables("KnifeBorrow").Rows(k)("M_Code").ToString, strWHID)
            Next
        End If

    End Sub

    Private Sub popWareOutDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutDel.Click
        If ds.Tables("KnifeBorrow").Rows.Count = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "M_Code")
        ds.Tables("KnifeBorrow").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckSave() = True Then
            If JS > 0 Then
                Exit Sub
            End If
            JS = JS + 1

            SaveDataNew()
        End If
    End Sub

    Function GetB_ID() As String
        '生成新pm
        Dim pm As New KnifeBorrowControl
        Dim pi As New KnifeBorrowInfo
        Dim ndate As String
        ndate = "KF" + Format(Now(), "yyMM")
        pi = pm.KnifeBorrow_GetID(ndate)
        If pi Is Nothing Then
            GetB_ID = ndate + "00001"
        Else
            GetB_ID = ndate + Mid((CInt(Mid(pi.B_NO, 7)) + 100001), 2)
        End If
    End Function

    Function GetB_NUM() As String
        '生成新pS
        Dim pm1 As New KnifeBorrowControl
        Dim pi1 As New KnifeBorrowInfo
        Dim ndate As String
        ndate = "KF"
        pi1 = pm1.KnifeBorrow_GetNUM(ndate)
        If pi1 Is Nothing Then
            GetB_NUM = "KF000000001"
        Else
            GetB_NUM = "KF" & Mid((CInt(Mid(pi1.B_Num, 3)) + 1000000001), 2)
        End If
    End Function
    ''' <summary>
    ''' 檢查數據
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function CheckSave() As Boolean
        CheckSave = True

        If txtBPer_ID.Text = "" Then
            MsgBox("無刷卡信息,請檢查!", 64, "提示")
            CheckSave = False
            Exit Function
        End If


        If LabPerNO.Text = txtBPer_ID.Text Then
        Else
            MsgBox("刷卡人與選擇擇借刀人信息不同,請檢查!", 64, "提示")
            CheckSave = False
            Exit Function
        End If

        If ds.Tables("KnifeBorrow").Rows.Count <= 0 Then
            MsgBox("無數據保存!", 64, "提示")
            CheckSave = False
            Exit Function
        End If

        '是否允許多條記錄2013-11-17
        If GetPMWS_Value("510504") = False Then
            If ds.Tables("KnifeBorrow").Rows.Count > 1 Then
                MsgBox("不允許多行數據!", 64, "提示")
                CheckSave = False
                Exit Function
            End If
        End If

        Dim BorrowTatal As Int32 = 0

        ''---------------------------------------------------------------------------------------------
        Dim j As Integer
        For j = 0 To ds.Tables("KnifeBorrow").Rows.Count - 1
            If ds.Tables("KnifeBorrow").Rows(j)("M_Code").ToString.Trim = "" Then
                MsgBox("刀具編碼不能為空", 64, "提示")
                CheckSave = False
                Exit Function
            End If
            If ds.Tables("KnifeBorrow").Rows(j)("M_Name").ToString.Trim = "" Then
                MsgBox("刀具名稱不能為空", 64, "提示")
                CheckSave = False
                Exit Function
            End If
            If ds.Tables("KnifeBorrow").Rows(j)("M_Gauge").ToString.Trim = "" Then
                MsgBox("刀具規格不能為空", 64, "提示")
                CheckSave = False
                Exit Function
            End If
            If ds.Tables("KnifeBorrow").Rows(j)("B_Qty") Is DBNull.Value Then
                MsgBox("數量不能為空!", 64, "提示")
                CheckSave = False
                Exit Function
            End If

            If ds.Tables("KnifeBorrow").Rows(j)("B_Qty") <= 0 Then
                MsgBox("數量不能等於0!", 64, "提示")
                CheckSave = False
                Exit Function
            End If
            '--------------------------------------------------------判斷是否有主檔庫存
            Dim wic As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
            Dim wii As New LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
            wii = wic.WareInventory_GetSub(ds.Tables("KnifeBorrow").Rows(j)("M_Code").ToString, strWHID)
            Dim Qty As Double = 0
            If wii Is Nothing Then
                MsgBox("當前發出倉庫不存在此物料信息", 64, "提示")
                GridView1.FocusedRowHandle = j
                CheckSave = False
                Exit Function
            Else
                Qty = wii.WI_Qty
            End If

            If Qty < CDbl(ds.Tables("KnifeBorrow").Rows(j)("B_Qty").ToString) Then
                MsgBox("發出倉庫存不足!", 64, "提示")
                GridView1.FocusedRowHandle = j
                CheckSave = False
                Exit Function
            End If

            '--------------------------------------------------------判斷是否有子檔庫存
            Dim wi5 As LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
            Dim wc5 As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl
            wi5 = wc5.KnifeWareInventorySub_GetList(ds.Tables("KnifeBorrow").Rows(j)("M_Code"), strWHID)
            If wi5 Is Nothing Then
                MsgBox("當前發出倉庫刀具屬性倉庫不存在此物料信息", 64, "提示")
                GridView1.FocusedRowHandle = j
                CheckSave = False
                Exit Function
            Else
                Select Case LabStr
                    Case "AddNew" ''''新刀
                        If wi5.WI_SQty < CDbl(ds.Tables("KnifeBorrow").Rows(j)("B_Qty").ToString) Then
                            MsgBox("發出新刀沒有此庫存或庫存不足!", 64, "提示")
                            GridView1.FocusedRowHandle = j
                            CheckSave = False
                            Exit Function
                        End If

                        ds.Tables("KnifeBorrow").Rows(j)("B_EndQty") = wi5.WI_SQty

                    Case "AddOld" '待處理
                        If wi5.WI_SReQty < CDbl(ds.Tables("KnifeBorrow").Rows(j)("B_Qty").ToString) Then
                            MsgBox("發出待處理沒有此庫存或庫存不足!", 64, "提示")
                            GridView1.FocusedRowHandle = j
                            CheckSave = False
                            Exit Function
                        End If

                        ds.Tables("KnifeBorrow").Rows(j)("B_EndQty") = wi5.WI_SReQty

                End Select
            End If

            ds.Tables("KnifeBorrow").Rows(j)("B_AllEndQty") = Qty

            BorrowTatal = BorrowTatal + ds.Tables("KnifeBorrow").Rows(j)("B_Qty")
        Next

        ' '' ''記住要判斷庫存,及設定的上限


        '' ''KnifeBorrow_NOReturnGetList
        ' ''Dim kc As New KnifeReturnControl
        ' ''Dim kl As New List(Of KnifeReturnInfo)
        ' ''kl = kc.KnifeBorrow_NOReturnGetList(txtBPer_ID.Text, Nothing, Nothing)

        ' ''Dim knl As New List(Of KnifeWhiteUserInfo)
        ' ''Dim knc As New KnifeWhiteUserController
        ' ''knl = knc.WhiteUser_GetList(strAutoID, Nothing, Nothing, Nothing, Nothing, False)

        ' ''If BorrowTatal + (kl(0).SumB_QTY - kl(0).SumR_QTY) > knl(0).WMax Then
        ' ''    MsgBox(labBPer_Name.Text & " 此員工領刀數量,已超上限值!" & "未還刀數為:" & kl(0).SumB_QTY - kl(0).SumR_QTY, 64, "提示")
        ' ''    CheckSave = False
        ' ''    Exit Function
        ' ''End If

        ''記住要判斷庫存,及設定的上限

        '********************************************************************************************
        '************************************2013-11-15 姚駿修改*************************************
        'KnifeBorrow_NOReturnGetList
        Dim kc As New KnifeReturnControl
        Dim kl As New List(Of KnifeReturnInfo)
        kl = kc.KnifeBorrow_NOReturnGetList(txtBPer_ID.Text, Nothing, Nothing)

        If kl.Count = 0 Then
            MsgBox("未歸還庫存無記錄!", 64, "提示")
            CheckSave = False
            Exit Function
        End If

        Dim knl As New List(Of KnifeWhiteUserInfo)
        Dim knc As New KnifeWhiteUserController

        If GetNightWareHouse(strWHID) = True Then
            knl = knc.WhiteUser_NightGetList(strWHID, txtBPer_ID.Text)
        Else
            knl = knc.WhiteUser_GetListAll(Nothing, txtBPer_ID.Text, strWHID, Nothing, Nothing, False)
        End If

        'Dim knl As New List(Of KnifeWhiteUserInfo)
        'Dim knc As New KnifeWhiteUserController
        'knl = knc.WhiteUser_GetListAll(Nothing, txtBPer_ID.Text, strWHID, Nothing, Nothing, False)

        If knl.Count = 0 Then
            MsgBox("白名單不存在!", 64, "提示")
            CheckSave = False
            Exit Function
        End If

        If BorrowTatal + (kl(0).SumB_QTY - kl(0).SumR_QTY) > knl(0).WMax Then
            MsgBox(labBPer_Name.Text & " 此員工領刀數量,已超上限值!" & "未還刀數為:" & kl(0).SumB_QTY - kl(0).SumR_QTY, 64, "提示")
            CheckSave = False
            Exit Function
        End If
        '***************************************************************************************************************************


    End Function
    ''' <summary>
    ''' 增加數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveDataNew()
        Dim wbc As New KnifeBorrowControl
        Dim wbi As New KnifeBorrowInfo

        txtB_NO.EditValue = GetB_ID()

        If Len(txtB_NO.EditValue) = 0 Then
            MsgBox("不能生成單號，無法保存！", 64, "提示")
            Exit Sub
        End If

        '----------------------------------------------------------------------------------
        '判斷單號是否存在
        Dim wbcA As New KnifeBorrowControl
        Dim wbL As New List(Of KnifeBorrowInfo)

        wbL = wbcA.KnifeBorrow_GetList(Nothing, txtB_NO.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If wbL.Count > 0 Then
            MsgBox("此單已存在,請重新保存！", 64, "提示")
            Exit Sub
        End If
        '----------------------------------------------------------------------------------


        Dim j As New Integer
        wbi.WH_ID = strWHID
        wbi.BPer_ID = Me.txtBPer_ID.EditValue
        wbi.BPer_Name = Me.labBPer_Name.Text
        wbi.B_NO = txtB_NO.EditValue
        wbi.B_Date = Format(CDate(DateB_Date.EditValue), "yyyy-MM-dd") & " " & Format(Now, "HH:mm:ss")
        wbi.B_Action = InUserID
        wbi.B_Type = txtB_Type.Text

        For j = 0 To ds.Tables("KnifeBorrow").Rows.Count - 1
            wbi.B_Num = GetB_NUM()
            wbi.M_Code = ds.Tables("KnifeBorrow").Rows(j)("M_Code").ToString
            wbi.B_Qty = ds.Tables("KnifeBorrow").Rows(j)("B_Qty")
            wbi.NOReturn = ds.Tables("KnifeBorrow").Rows(j)("B_Qty")

            wbi.B_Remark = ds.Tables("KnifeBorrow").Rows(j)("B_Remark").ToString
            wbi.B_EndQty = ds.Tables("KnifeBorrow").Rows(j)("B_EndQty") - ds.Tables("KnifeBorrow").Rows(j)("B_Qty")
            wbi.B_AllEndQty = ds.Tables("KnifeBorrow").Rows(j)("B_AllEndQty") - ds.Tables("KnifeBorrow").Rows(j)("B_Qty")

            If wbc.KnifeBorrow_Add(wbi) = True Then
                ''要扣數
                If UpdateQty(ds.Tables("KnifeBorrow").Rows(j)("M_Code").ToString, ds.Tables("KnifeBorrow").Rows(j)("B_Qty")) = False Then
                    MsgBox(wbi.M_Code & " 扣數失敗,請檢查!", 64, "提示")
                    Exit Sub
                End If
            Else
                MsgBox("部分保存失敗!", 64, "提示")
                Exit Sub
            End If


            Dim str1 As String = ds.Tables("KnifeBorrow").Rows(j)("M_Name").ToString & " " & ds.Tables("KnifeBorrow").Rows(j)("M_Gauge").ToString
            Dim str2 As String = "數量:" & ds.Tables("KnifeBorrow").Rows(j)("B_Qty").ToString
            Dim str3 As String = "狀態:已保存 未結數:" & CStr(ds.Tables("KnifeBorrow").Rows(j)("B_AllNoReturn") + ds.Tables("KnifeBorrow").Rows(j)("B_Qty"))
            Dim str4 As String = "借刀人:" & labBPer_Name.Text


            LoadPingMU(str1, str2, str3, str4)

        Next




        MsgBox("保存成功!", 64, "提示")
        Me.Close()
    End Sub

    Function GetNORerurn(ByVal sBPer_ID As String, ByVal sM_code As String, ByVal sWH_ID As String) As Int32
        Dim kc As New KnifeReturnControl
        Dim kl As New List(Of KnifeReturnInfo)
        kl = kc.KnifeBorrow_NOReturnGetList(sBPer_ID, sM_code, sWH_ID)
        If kl.Count = 0 Then
            GetNORerurn = 0
        Else
            GetNORerurn = kl(0).SumNOReturn
        End If
    End Function


    Function UpdateQty(ByVal _M_code As String, ByVal _B_Qty As String) As Boolean

        UpdateQty = True

        Dim dblWI_All As Double
        Dim dbWI_SReQty As Double
        Dim dblWI_SQty As Double

        Dim wi As New LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
        Dim wc As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
        wi = wc.WareInventory_GetSub(_M_code, txtWH.Tag)

        If wi Is Nothing Then
            dblWI_All = 0
        Else
            dblWI_All = wi.WI_Qty
        End If
        '---------------------庫存子檔------------------------------------------------------------
        Dim wiinfo As New LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
        Dim wcco As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl

        wiinfo = wcco.KnifeWareInventorySub_GetList(_M_code, strWHID)
        If wiinfo Is Nothing Then
            dbWI_SReQty = 0
            dblWI_SQty = 0
        Else
            dblWI_SQty = wiinfo.WI_SQty
            dbWI_SReQty = wiinfo.WI_SReQty
        End If
        '---------------------'---------------------'---------------------'---------------------
        Dim wifo As New LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
        Select Case LabStr
            Case "AddNew" ''''新刀
                wifo.WI_SQty = (dblWI_SQty - _B_Qty)
                wifo.WI_SReQty = dbWI_SReQty
            Case "AddOld" '待處理
                wifo.WI_SQty = dblWI_SQty
                wifo.WI_SReQty = (dbWI_SReQty - _B_Qty)
        End Select

        wifo.WI_All = dblWI_All - _B_Qty
        wifo.M_Code = _M_code
        wifo.WH_ID = txtWH.Tag
        If wcco.KnifeWareInventorySub_Update(wifo) = False Then
            UpdateQty = False
        End If
    End Function

    ''' <summary>
    ''' 載入數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData()
        Dim bc As New KnifeBorrowControl
        Dim objInfo As New List(Of KnifeBorrowInfo)

        objInfo = bc.KnifeBorrow_GetList(Nothing, txtB_NO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If objInfo.Count <= 0 Then
            MsgBox("無數據存在!", 64, "提示")
            Exit Sub
        End If
        ''-----------------------------------------------------------------
        txtWH.Tag = objInfo(0).WH_ID
        txtWH.Text = objInfo(0).WH_Name
        DateB_Date.Text = objInfo(0).B_Date
        txtBPer_ID.Text = objInfo(0).BPer_ID
        labBPer_Name.Text = objInfo(0).BPer_Name

        txtB_Type.Text = objInfo(0).B_Type
        ''------------------------------------------------------------------
        Dim row As DataRow

        Dim i As Integer
        For i = 0 To objInfo.Count - 1
            row = ds.Tables("KnifeBorrow").NewRow
            row("B_Num") = objInfo(i).AutoID
            row("M_Code") = objInfo(i).M_Code
            row("M_Name") = objInfo(i).M_Name
            row("M_Gauge") = objInfo(i).M_Gauge

            row("B_Qty") = objInfo(i).B_Qty
            row("B_EndQty") = objInfo(i).B_EndQty
            row("B_Remark") = objInfo(i).B_Remark
            ds.Tables("KnifeBorrow").Rows.Add(row)
        Next
    End Sub




    Private Sub ButtonTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTest.Click
        LoadPingMU("test", "test", "test", "test")
    End Sub
End Class