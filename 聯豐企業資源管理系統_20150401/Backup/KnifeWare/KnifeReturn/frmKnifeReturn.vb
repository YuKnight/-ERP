Imports LFERP.Library.KnifeWare
Public Class frmKnifeReturn

    Dim JS As Integer = 0

    Dim ds As New DataSet

    Dim strReturnType As String '還刀類型
    '(ReturnNew--本人還新刀)
    '(ReturnOld--本人還待處理)
    '(ReturnNewOld--本人還待換新)

    '(ReReturnNew--待還新刀)
    '(ReReturnOld--待還待處理)
    '(ReReturnNewOld--待還待換新)

    Private Sub frmKnifeReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateR_Date.EditValue = Format(Now, "yyyy/MM/dd")

        strReturnType = tempValue
        txtWH.Tag = tempValue2
        txtWH.Text = tempValue3
        txtRPer_ID.Text = tempValue4
        labRPer_Name.Text = tempValue5
        txtR_NO.Text = tempValue6

        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing

        CreateTables()
        LabType.Text = strReturnType

        Select Case strReturnType
            Case "ReturnNew"
                Me.Text = "還刀登記--本人還新刀"
                LabMsg.Text = "還刀登記--本人還新刀"
                txtR_Type.Text = "新刀"
            Case "ReturnOld"
                Me.Text = "還刀登記--本人還待處理"
                LabMsg.Text = "還刀登記--本人還待處理"
                txtR_Type.Text = "待處理"
            Case "ReturnNewOld"
                Me.Text = "還刀登記--本人還待處理換新"
                LabMsg.Text = "還刀登記--本人還待處理換新"
                txtR_Type.Text = "待處理換新"
            Case "ReReturnNew"
                Me.Text = "還刀登記--代還新刀"
                LabMsg.Text = "還刀登記--代還新刀"
                txtR_Type.Text = "新刀"
            Case "ReReturnOld"
                Me.Text = "還刀登記--代還待處理"
                LabMsg.Text = "還刀登記--代還待處理"
                txtR_Type.Text = "待處理"
            Case "ReReturnNewOld"
                Me.Text = "還刀登記--代還待處理換新"
                LabMsg.Text = "還刀登記--代還待處理換新"
                txtR_Type.Text = "待處理換新"
            Case "View"
                loadedit(txtR_NO.Text)
                cmdSave.Visible = False
                popWareWB.Enabled = False
        End Select

        If Mid(strReturnType, 1, 1) = "R" Then '表示是新增
            DateR_Date.Enabled = False
            DateR_Date.EditValue = Format(Now, "yyyy/MM/dd")
        End If
        ''---------------------------

        Dim reset As New ResetPassWords.SetPassWords
        reset.SetPassWords()

    End Sub

    Private Sub sk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sk.Click
        Dim RRstr As String
        RRstr = ReadCard()

        If RRstr <> "" Then
            If InStr(RRstr, "-", CompareMethod.Text) > 0 Then
                txtRRPer_ID.Text = Mid(RRstr, 1, InStr(RRstr, "-", CompareMethod.Text) - 1)
                '本人還刀時,卡號要一致
                'txtRPer_ID
                If strReturnType = "ReReturnNew" Or strReturnType = "ReReturnOld" Or strReturnType = "ReReturnNewOld" Then
                Else
                    If txtRPer_ID.Text <> txtRRPer_ID.Text Then
                        MsgBox("本人還刀,卡號要與還刀人工號相同!")
                        txtRRPer_ID.Text = ""
                        cmdSave.Enabled = False
                        Exit Sub
                    End If
                End If

                LabRRPer_Name.Text = Mid(RRstr, InStr(RRstr, "-", CompareMethod.Text) + 1, Len(RRstr) - InStr(RRstr, "-", CompareMethod.Text))
                cmdSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub popReturnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popReturnAdd.Click
        If txtRPer_ID.Text = "" Then
            MsgBox("還刀人為空!錯誤!", 64, "提示")
            Exit Sub
        End If

        tempValue2 = txtRPer_ID.Text
        tempValue3 = Me.txtWH.Tag

        Dim fr As New frmKnifeReturnLoad
        fr.ShowDialog()

        If tempValue = "Y" Then
        Else
            Exit Sub
        End If

        Dim K As Integer
        For K = 0 To fr.DSA.Tables("KnifeReturnLoad").Rows.Count - 1

            If fr.DSA.Tables("KnifeReturnLoad").Rows(K)("GOIN") = True Then

                ''加判斷加入了重復編碼--------------------------------
                If ds.Tables("KReturn").Rows.Count > 0 Then
                    Dim X As Integer
                    For X = 0 To ds.Tables("KReturn").Rows.Count - 1
                        If fr.DSA.Tables("KnifeReturnLoad").Rows(K)("M_Code").ToString = ds.Tables("KReturn").Rows(X)("M_Code").ToString Then
                            MsgBox(ds.Tables("KReturn").Rows(X)("M_Code").ToString & ",刀具編碼已加入!", 64, "提示")
                            GoTo AA
                        End If
                    Next
                End If

                ''-------------------------------------------------------------------
                Dim row As DataRow
                row = ds.Tables("KReturn").NewRow
                row("M_Code") = fr.DSA.Tables("KnifeReturnLoad").Rows(K)("M_Code").ToString
                row("M_Name") = fr.DSA.Tables("KnifeReturnLoad").Rows(K)("M_Name").ToString

                row("M_Gauge") = fr.DSA.Tables("KnifeReturnLoad").Rows(K)("M_Gauge").ToString
                row("Qty") = fr.DSA.Tables("KnifeReturnLoad").Rows(K)("Qty")
                row("NoReturnQty") = fr.DSA.Tables("KnifeReturnLoad").Rows(K)("Qty")
                ds.Tables("KReturn").Rows.Add(row)


                ''-------------------------------------------------------------------
AA:
                GridView1.FocusedRowHandle = K

            End If
        Next
        fr.Dispose()
    End Sub

#Region "還刀"

    Sub CreateTables()
        ds.Tables.Clear()
        With ds.Tables.Add("KReturn")
            .Columns.Add("R_Num", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            '
            .Columns.Add("Qty", GetType(Int32))
            .Columns.Add("NoReturnQty", GetType(Int32))
            .Columns.Add("Remark", GetType(String))

            .Columns.Add("R_EndQty", GetType(Int32))
            .Columns.Add("R_AllEndQty", GetType(Int32))

          

        End With
        Grid1.DataSource = ds.Tables("KReturn")
    End Sub


    Sub loadedit(ByVal KR_ID As String)
        ds.Tables("KReturn").Clear()

        Dim wbc As New KnifeReturnControl
        Dim objInfo As New List(Of KnifeReturnInfo)

        Dim row As DataRow
        Try
            objInfo = wbc.KnifeReturn_GetList(Nothing, KR_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If objInfo.Count <= 0 Then
                MsgBox("無數據載入！", 64, "提示")
                Exit Sub
            End If

            txtWH.Tag = objInfo(0).WH_ID
            txtWH.EditValue = objInfo(0).WH_Name

            DateR_Date.Text = objInfo(0).R_Date
            txtRRPer_ID.Text = objInfo(0).RRPer_ID

            LabRRPer_Name.Text = objInfo(0).RRPer_Name
            txtR_Type.Text = objInfo(0).R_Type
            txtRPer_ID.Text = objInfo(0).RPer_ID
            labRPer_Name.Text = objInfo(0).RPer_Name

            Dim i As Integer

            For i = 0 To objInfo.Count - 1
                row = ds.Tables("KReturn").NewRow
                row("R_Num") = objInfo(i).R_NUM
                row("M_Code") = objInfo(i).M_Code
                row("M_Name") = objInfo(i).M_Name
                row("M_Gauge") = objInfo(i).M_Gauge

                row("Qty") = objInfo(i).R_Qty
                row("Remark") = objInfo(i).RR_Mark
                ds.Tables("KReturn").Rows.Add(row)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function CheckData() As Boolean
        CheckData = True
        If txtRRPer_ID.Text = "" Then
            MsgBox("刷卡人不能為空!", 64, "提示")
            CheckData = False
            txtRRPer_ID.Select()
            Exit Function
        End If

        If txtRPer_ID.Text = "" Then
            MsgBox("還刀人不能為空!", 64, "提示")
            CheckData = False
            txtRPer_ID.Select()
            Exit Function
        End If

        If ds.Tables("KReturn").Rows.Count <= 0 Then
            MsgBox("無記錄保存!", 64, "提示")
            CheckData = False
            Exit Function
        End If

        '是否允許多條記錄2013-11-17
        If GetPMWS_Value("510604") = False Then
            If ds.Tables("KReturn").Rows.Count > 1 Then
                MsgBox("不允許多行數據!", 64, "提示")
                CheckData = False
                Exit Function
            End If
        End If

        Dim i As Integer
        For i = 0 To ds.Tables("KReturn").Rows.Count - 1
            If ds.Tables("KReturn").Rows(i)("M_Code").ToString.Trim = "" Then
                MsgBox("刀具編碼不能為空", 64, "提示")
                CheckData = False
                Exit Function
            End If
            If ds.Tables("KReturn").Rows(i)("M_Name").ToString.Trim = "" Then
                MsgBox("刀具名稱不能為空", 64, "提示")
                CheckData = False
                Exit Function
            End If
            If ds.Tables("KReturn").Rows(i)("M_Gauge").ToString.Trim = "" Then
                MsgBox("刀具規格不能為空", 64, "提示")
                CheckData = False
                Exit Function
            End If
            'Qty
            If ds.Tables("KReturn").Rows(i)("Qty") <= 0 Then
                MsgBox("第" & CStr(i + 1) & "數量不能小於等於0", 64, "提示")
                CheckData = False
                Exit Function
            End If

            ''查詢出所借刀的數量
            Dim intQty As Integer = 0
            Dim rccA As New KnifeReturnControl
            Dim RclA As New List(Of KnifeReturnInfo)
            RclA = rccA.KnifeBorrow_NOReturnGroupGetList(txtRPer_ID.Text, ds.Tables("KReturn").Rows(i)("M_Code").ToString, txtWH.Tag, Nothing, Nothing)
            If RclA.Count >= 0 Then
                'intQty = RclA(0).SumB_QTY
                intQty = RclA(0).SumNOReturn
            End If

            If ds.Tables("KReturn").Rows(i)("Qty") > intQty Then
                MsgBox("刀具編碼為:" & ds.Tables("KReturn").Rows(i)("M_Code").ToString & "還刀數大于總未還數量!", 64, "提示")
                CheckData = False
                Exit Function
            End If

            '待處理換新時檢查新刀數量是否足
            If strReturnType = "ReturnNewOld" Or strReturnType = "ReReturnNewOld" Then
                Dim wi5 As LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
                Dim wc5 As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl
                wi5 = wc5.KnifeWareInventorySub_GetList(ds.Tables("KReturn").Rows(i)("M_Code"), txtWH.Tag)

                Dim strA As String
                strA = ds.Tables("KReturn").Rows(i)("M_Code").ToString

                If wi5 Is Nothing Then
                    MsgBox(strA & "無庫存信息！", 64, "提示")
                    CheckData = False
                    GridView1.FocusedRowHandle = i
                    Exit Function
                Else
                    If wi5.WI_SQty < CDbl(ds.Tables("KReturn").Rows(i)("Qty").ToString) Then
                        MsgBox("發出新刀庫存不足! 新刀" & wi5.WI_SQty, 64, "提示")
                        GridView1.FocusedRowHandle = i
                        CheckData = False
                        Exit Function
                    End If
                End If
            End If
        Next
    End Function

    ''' <summary>
    ''' 保存數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveDataNew()
        Dim wbc As New KnifeReturnControl
        Dim wbi As New KnifeReturnInfo

        txtR_NO.EditValue = GetR_ID()

        If Len(txtR_NO.EditValue) = 0 Then
            MsgBox("不能生成單號，無法保存！", 64, "提示")
            Exit Sub
        End If

        '----------------------------------------------------------------------------------
        '判斷單號是否存在
        Dim wbcA As New KnifeReturnControl
        Dim wbL As New List(Of KnifeReturnInfo)

        wbL = wbcA.KnifeReturn_GetList(Nothing, txtR_NO.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If wbL.Count > 0 Then
            MsgBox("此單已存在,請重新保存！", 64, "提示")
            Exit Sub
        End If
        '----------------------------------------------------------------------------------
        wbi.R_NO = txtR_NO.EditValue
        wbi.WH_ID = txtWH.Tag
        wbi.R_Date = Format(CDate(DateR_Date.EditValue), "yyyy-MM-dd") & " " & Format(Now, "HH:mm:ss")
        wbi.RRPer_ID = txtRRPer_ID.Text
        wbi.RRPer_Name = LabRRPer_Name.Text

        wbi.R_Type = txtR_Type.Text
        wbi.RPer_ID = txtRPer_ID.Text
        wbi.RPer_Name = labRPer_Name.Text

        Dim j As New Integer
        For j = 0 To ds.Tables("KReturn").Rows.Count - 1
            Dim strWR_NUM As String
            strWR_NUM = GetR_NUM()
            wbi.R_NUM = strWR_NUM
            ''-------------------------------------------
            wbi.M_Code = ds.Tables("KReturn").Rows(j)("M_Code").ToString
            wbi.R_Qty = ds.Tables("KReturn").Rows(j)("Qty")
            wbi.RR_Mark = ds.Tables("KReturn").Rows(j)("Remark").ToString
            wbi.R_Action = InUserID

            Dim TemM_Code As String
            Dim TemQty As Int32

            TemM_Code = ds.Tables("KReturn").Rows(j)("M_Code").ToString
            TemQty = ds.Tables("KReturn").Rows(j)("Qty")

            ''查詢出當前庫存,保存結余---------------------------------------
            wbi.R_EndQty = GetR_EndQty(TemM_Code, TemQty)
            '--------------------------------------------------------判斷是否有子檔庫存
            wbi.R_AllEndQty = GetR_ALLEndQty(TemM_Code, TemQty)
            '’-------------------------------------------------------------
            If wbc.KnifeReturn_Add(wbi) = True Then
                If ReduceKnifeBrrow(TemM_Code, txtWH.Tag, txtRPer_ID.Text, TemQty, strWR_NUM) = False Then
                    Exit Sub
                Else
                    ''''更新庫存
                    If UpdateQtyRturn(TemM_Code, TemQty) = True Then
                    Else
                        MsgBox(TemM_Code & ",扣數失敗!", 64, "提示")
                        Exit Sub
                    End If
                End If
            Else
                MsgBox("部分保存失敗!", 64, "提示")
                Exit Sub
            End If


            If strReturnType = "ReturnNewOld" Or strReturnType = "ReReturnNewOld" Then
                If SaveDataNewOld(TemM_Code, TemQty) = False Then
                    MsgBox(TemM_Code & "換新刀失敗,請檢查！", 64, "提示")
                    Exit Sub
                End If
            End If
            '----------------------------------------------------------------------
            Dim str1 As String
            Dim str2 As String
            Dim str3 As String
            Dim str4 As String

            str1 = ds.Tables("KReturn").Rows(j)("M_Name").ToString & " " & ds.Tables("KReturn").Rows(j)("M_Gauge").ToString
            str2 = "數量:" & ds.Tables("KReturn").Rows(j)("Qty").ToString
            If strReturnType = "ReturnNewOld" Or strReturnType = "ReReturnNewOld" Then
                str3 = "狀態:已保存 未結數: " & CStr(ds.Tables("KReturn").Rows(j)("NoReturnQty"))
            Else
                str3 = "狀態:已保存 未結數: " & CStr(ds.Tables("KReturn").Rows(j)("NoReturnQty") - ds.Tables("KReturn").Rows(j)("Qty"))
            End If

            str4 = "借刀人:" & labRPer_Name.Text & "  還刀人:" & LabRRPer_Name.Text
            LoadPingMU(str1, str2, str3, str4)
            '----------------------------------------------------------------------

        Next

        MsgBox("還刀成功!")
        Me.Close()

    End Sub

    ''' <summary>
    ''' 取得結余數
    ''' </summary>
    ''' <param name="_M_Code"></param>
    ''' <param name="_Qty"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetR_ALLEndQty(ByVal _M_Code As String, ByVal _Qty As Int32) As Int32
        Dim wic As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
        Dim wii As New LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
        wii = wic.WareInventory_GetSub(_M_Code, txtWH.Tag)
        Dim Qty As Double = 0
        If wii Is Nothing Then
            Qty = _Qty
        Else
            Qty = wii.WI_Qty + _Qty
        End If

        GetR_ALLEndQty = Qty
    End Function

    Function GetR_EndQty(ByVal _M_Code As String, ByVal _Qty As Int32) As Int32
        '(ReturnNew--本人還新刀)
        '(ReturnOld--本人還待處理)
        '(ReturnNewOld--本人還待換新)

        '(ReReturnNew--待還新刀)
        '(ReReturnOld--待還待處理)
        '(ReReturnNewOld--待還待換新)
        Dim EQty As Int32 = 0

        Dim wi5 As LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
        Dim wc5 As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl
        wi5 = wc5.KnifeWareInventorySub_GetList(_M_Code, txtWH.Tag)
        If wi5 Is Nothing Then
            EQty = _Qty
        Else
            Select Case strReturnType
                Case "ReturnNew", "ReReturnNew" ''''新刀
                    EQty = _Qty + wi5.WI_SQty
                Case "ReturnOld", "ReturnNewOld", "ReReturnOld", "ReReturnNewOld" '待處理
                    EQty = _Qty + wi5.WI_SReQty
            End Select
        End If

        GetR_EndQty = EQty
    End Function
    ''' <summary>
    ''' 更新庫存
    ''' </summary>
    ''' <param name="_M_Code"></param>
    ''' <param name="_Qty"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function UpdateQtyRturn(ByVal _M_Code As String, ByVal _Qty As Int32) As Boolean

        UpdateQtyRturn = True

        Dim dblWI_All As Double
        Dim dbWI_SReQty As Double
        Dim dblWI_SQty As Double

        Dim wi As New LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
        Dim wc As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
        wi = wc.WareInventory_GetSub(_M_Code, txtWH.Tag)

        If wi Is Nothing Then
            dblWI_All = 0
        Else
            dblWI_All = wi.WI_Qty
        End If
        '---------------------庫存子檔------------------------------------------------------------
        Dim wiinfo As New LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
        Dim wcco As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl

        wiinfo = wcco.KnifeWareInventorySub_GetList(_M_Code, txtWH.Tag)
        If wiinfo Is Nothing Then
            dbWI_SReQty = 0
            dblWI_SQty = 0
        Else
            dblWI_SQty = wiinfo.WI_SQty
            dbWI_SReQty = wiinfo.WI_SReQty
        End If
        '---------------------'---------------------'---------------------'---------------------
        Dim wifo As New LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
        Select Case strReturnType
            Case "ReturnNew", "ReReturnNew" ''''新刀
                wifo.WI_SQty = (dblWI_SQty + _Qty)
                wifo.WI_SReQty = dbWI_SReQty
            Case "ReturnOld", "ReturnNewOld", "ReReturnOld", "ReReturnNewOld" '待處理
                wifo.WI_SQty = dblWI_SQty
                wifo.WI_SReQty = (dbWI_SReQty + _Qty)
        End Select

        wifo.WI_All = dblWI_All + _Qty
        wifo.M_Code = _M_Code
        wifo.WH_ID = txtWH.Tag
        If wcco.KnifeWareInventorySub_Update(wifo) = False Then
            UpdateQtyRturn = False
        End If
    End Function


    Function ReduceKnifeBrrow(ByVal M_Code As String, ByVal WH_ID As String, ByVal BPer_ID As String, ByVal RQty As Double, ByVal WR_Num As String) As Boolean
        ReduceKnifeBrrow = True

        Dim kc As New KnifeBorrowControl
        Dim kl As New List(Of KnifeBorrowInfo)
        kl = kc.KnifeBorrowDedu_GetList(M_Code, WH_ID, BPer_ID, Nothing)

        If kl.Count <= 0 Then
            ReduceKnifeBrrow = False
            Exit Function
        End If

        Dim i As Integer
        Dim TempDouble As Double
        TempDouble = RQty '本次還的數量

        For i = 0 To kl.Count - 1
            Dim doubleNOReturn As Double '未還刀數
            doubleNOReturn = kl(i).B_Qty - kl(i).R_Qty

            Dim NODouble As Double '
            Dim KnifeReturnDouble As Double '本單已還數

            If TempDouble > 0 Then
                If TempDouble > doubleNOReturn Then '歸還數 大於 未還數
                    NODouble = 0
                    TempDouble = TempDouble - doubleNOReturn
                    KnifeReturnDouble = kl(i).B_Qty
                Else
                    NODouble = doubleNOReturn - TempDouble
                    KnifeReturnDouble = TempDouble + kl(i).R_Qty '本次歸還數加上已歸還數  '上下兩行不能交換
                    TempDouble = 0
                End If

                ''更新此單數據----------------------------------------------------------------
                Dim wt As New KnifeBorrowControl
                Dim wi As New KnifeBorrowInfo

                wi.B_Num = kl(i).B_Num
                wi.NOReturn = NODouble
                wi.R_Qty = KnifeReturnDouble
                wi.R_Date = Format(Now, "yyyy/MM/dd HH:mm:ss")

                If wt.KnifeBorrow_UpdateRQty(wi) = True Then
                Else
                    ReduceKnifeBrrow = False
                    MsgBox("扣數數據保存失敗,請檢查!", 64, "提示")
                    Exit Function
                End If
                '更新狀態
                Dim wtt As New KnifeReturnControl
                If wtt.KnifeReturnDedu_Update(WR_Num, "True") = False Then
                    ReduceKnifeBrrow = False
                    MsgBox("還刀單狀態保存失敗,請檢查!", 64, "提示")
                    Exit Function
                End If
            Else
                Exit For
            End If
        Next

    End Function


    Function GetR_ID() As String
        '生成新pm
        Dim pm As New KnifeReturnControl
        Dim pi As New KnifeReturnInfo
        Dim ndate As String
        ndate = "KR" + Format(Now(), "yyMM")
        pi = pm.KnifeReturn_GetID(ndate)
        If pi Is Nothing Then
            GetR_ID = ndate + "00001"
        Else
            GetR_ID = ndate + Mid((CInt(Mid(pi.R_NO, 7)) + 100001), 2)
        End If
    End Function

    Function GetR_NUM() As String
        '生成新pS
        Dim pm1 As New KnifeReturnControl
        Dim pi1 As New KnifeReturnInfo
        Dim ndate As String
        ndate = "KR"
        pi1 = pm1.KnifeReturn_GetNUM(ndate)
        If pi1 Is Nothing Then
            GetR_NUM = "KR000000001"
        Else
            GetR_NUM = "KR" & Mid((CInt(Mid(pi1.R_NUM, 3)) + 1000000001), 2)
        End If
    End Function


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckData() = True Then
        Else
            Exit Sub
        End If

        If JS > 0 Then
            Exit Sub
        End If
        JS = JS + 1

        SaveDataNew()

    End Sub


#End Region

#Region "待處理換新"
    ''' <summary>
    ''' 待處理換新
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function SaveDataNewOld(ByVal NewOld_M_Code As String, ByVal NewOld_Qty As Int32) As Boolean  ''以舊換新
        SaveDataNewOld = True

        Dim wbc As New KnifeBorrowControl
        Dim wbi As New KnifeBorrowInfo

        Dim txtstrB_NO As String
        txtstrB_NO = GetB_ID()

        If Len(txtstrB_NO) = 0 Then
            SaveDataNewOld = False
            Exit Function
        End If

        Dim j As New Integer
        wbi.WH_ID = txtWH.Tag
        wbi.BPer_ID = txtRPer_ID.Text
        wbi.BPer_Name = labRPer_Name.Text
        wbi.B_NO = txtstrB_NO
        wbi.B_Date = Format(CDate(DateR_Date.EditValue), "yyyy/MM/dd")
        wbi.B_Action = InUserID
        wbi.B_Type = "新刀"


        wbi.B_Num = GetB_NUM()
        wbi.M_Code = NewOld_M_Code
        wbi.B_Qty = NewOld_Qty
        wbi.NOReturn = NewOld_Qty

        wbi.B_Remark = "以舊換新"

        ''查詢出當前庫存,保存結余---------------------------------------
        wbi.B_EndQty = GetB_ALLEndQty(NewOld_M_Code, NewOld_Qty)
        '--------------------------------------------------------判斷是否有子檔庫存
        wbi.B_AllEndQty = GetB_EndQty(NewOld_M_Code, NewOld_Qty)

        If wbc.KnifeBorrow_Add(wbi) = True Then
            ''要扣數
            If UpdateQtyBrrow(NewOld_M_Code, NewOld_Qty) = False Then
                SaveDataNewOld = False
            End If
        Else
            SaveDataNewOld = False
            Exit Function
        End If


    End Function


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

    Function GetB_ALLEndQty(ByVal _M_Code As String, ByVal _Qty As Int32) As Int32
        Dim wic As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
        Dim wii As New LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
        wii = wic.WareInventory_GetSub(_M_Code, txtWH.Tag)
        Dim Qty As Double = 0
        If wii Is Nothing Then
            Qty = _Qty
        Else
            Qty = wii.WI_Qty - _Qty
        End If

        GetB_ALLEndQty = Qty
    End Function
    ''' <summary>
    ''' 還刀時,待處理換新
    ''' </summary>
    ''' <param name="_M_Code"></param>
    ''' <param name="_Qty"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetB_EndQty(ByVal _M_Code As String, ByVal _Qty As Int32) As Int32
        Dim EQty As Int32 = 0

        Dim wi5 As LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
        Dim wc5 As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl
        wi5 = wc5.KnifeWareInventorySub_GetList(_M_Code, txtWH.Tag)
        If wi5 Is Nothing Then
            EQty = _Qty
        Else
            EQty = _Qty - wi5.WI_SQty
        End If

        GetB_EndQty = EQty
    End Function

    ''' <summary>
    ''' 還刀時,待處理換新
    ''' </summary>
    ''' <param name="_M_Code"></param>
    ''' <param name="_Qty"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function UpdateQtyBrrow(ByVal _M_Code As String, ByVal _Qty As Int32) As Boolean

        UpdateQtyBrrow = True

        Dim dblWI_All As Double
        Dim dbWI_SReQty As Double
        Dim dblWI_SQty As Double

        Dim wi As New LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
        Dim wc As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
        wi = wc.WareInventory_GetSub(_M_Code, txtWH.Tag)

        If wi Is Nothing Then
            dblWI_All = 0
        Else
            dblWI_All = wi.WI_Qty
        End If
        '---------------------庫存子檔------------------------------------------------------------
        Dim wiinfo As New LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
        Dim wcco As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl

        wiinfo = wcco.KnifeWareInventorySub_GetList(_M_Code, txtWH.Tag)
        If wiinfo Is Nothing Then
            dbWI_SReQty = 0
            dblWI_SQty = 0
        Else
            dblWI_SQty = wiinfo.WI_SQty
            dbWI_SReQty = wiinfo.WI_SReQty
        End If
        '---------------------'---------------------'---------------------'---------------------
        Dim wifo As New LFERP.Library.KnifeWare.KnifeWareInventorySubInfo

        wifo.WI_SQty = (dblWI_SQty - _Qty)
        wifo.WI_SReQty = dbWI_SReQty
        wifo.WI_All = dblWI_All - _Qty

        wifo.M_Code = _M_Code
        wifo.WH_ID = txtWH.Tag

        If wcco.KnifeWareInventorySub_Update(wifo) = False Then
            UpdateQtyBrrow = False
        End If
    End Function

#End Region

End Class