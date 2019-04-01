Imports LFERP.Library.KnifeWare
Public Class frmKnifeChange
    Dim ds As New DataSet
    Dim strType As String

    Private Sub frmKnifeChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtCH_Num.Text = tempValue2
        strType = tempValue

        tempValue2 = Nothing
        tempValue = Nothing

        Dim cc As New KnifeChangeControl
        GridLookChangeType.Properties.ValueMember = "ChangeID"
        GridLookChangeType.Properties.DisplayMember = "ChangeName"
        GridLookChangeType.Properties.DataSource = cc.KnifeChangeType_GetList(Nothing, Nothing)

        GridLookChangeType.Enabled = False
        GridLookChangeType.EditValue = strType
        DateC_Date.EditValue = Format(Now, "yyyy/MM/dd HH:mm:ss")

        CreateTables()

        Select Case strType
            Case "WT1", "WT2", "KT3", "KT4", "KT5"
                txtCH_Num.Text = ""
                GridLookChangeType.Enabled = False
                GridLookChangeType.EditValue = strType

                Me.Text = "更改單" & "[" & GridLookChangeType.Text & "]"
                LabMsg.Text = "更改單" & "-" & GridLookChangeType.Text

                DateC_Date.EditValue = Format(Now, "yyyy/MM/dd HH:mm:ss")

                If strType = "WT1" Or strType = "WT2" Then
                    XtraTabControl1.TabPages(0).PageVisible = False
                    XtraTabControl1.TabPages(1).PageVisible = False
                    XtraTabControl1.TabPages(2).PageVisible = True
                    XtraTabControl1.TabPages(3).PageVisible = False
                    B_Num.Visible = False
                ElseIf strType = "KT3" Then '員工領刀
                    XtraTabControl1.TabPages(0).PageVisible = True
                    XtraTabControl1.TabPages(1).PageVisible = False
                    XtraTabControl1.TabPages(2).PageVisible = False
                    XtraTabControl1.TabPages(3).PageVisible = False
                    B_Num.Visible = True
                ElseIf strType = "KT4" Then '員工還刀
                    XtraTabControl1.TabPages(0).PageVisible = True
                    XtraTabControl1.TabPages(1).PageVisible = True
                    XtraTabControl1.TabPages(2).PageVisible = False
                    XtraTabControl1.TabPages(3).PageVisible = False
                ElseIf strType = "KT5" Then '更改單增加
                    XtraTabControl1.TabPages(0).PageVisible = False
                    XtraTabControl1.TabPages(1).PageVisible = False
                    XtraTabControl1.TabPages(2).PageVisible = False
                    XtraTabControl1.TabPages(3).PageVisible = True
                    B_Num.Visible = False
                End If

            Case "View"

                Me.Text = "更改單-查看"
                LabMsg.Text = "更改單-查看"

                cmdSave.Visible = False
                LoadData(txtCH_Num.Text)
                ''對載入不類型的
                If GridLookChangeType.EditValue = "WT1" Or GridLookChangeType.EditValue = "WT2" Or GridLookChangeType.EditValue = "KT5" Then
                    B_Num.Visible = False
                Else
                    B_Num.Visible = True
                End If
        End Select

        popWareOutAdd.Visible = False
        ToolStripBorrowReturn.Visible = False
        '------------------------------------------
        txtWH.Select()
        ButtonLoadBnum2.Left = ButtonLoadBnum1.Left
        ButtonLoadBnum2.Top = ButtonLoadBnum1.Top

        ButtonM_CodeA.Left = ButtonLoadBnum1.Left
        ButtonM_CodeA.Top = ButtonLoadBnum1.Top
        '------------------------------------------


        ' Me.TextBrrow.Text = "KF000000001"

    End Sub
    ''' <summary>
    ''' 建表結構
    ''' </summary>
    ''' <remarks></remarks>
    Sub CreateTables()
        ds.Tables.Clear()
        With ds.Tables.Add("KnifeChange")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("B_Num", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("CBegin_Qty", GetType(Int32))
            .Columns.Add("CEnd_Qty", GetType(Int32))
            .Columns.Add("CReMark", GetType(String))

            .Columns.Add("BQty", GetType(Int32)) '員工領刀數
            .Columns.Add("RQty", GetType(Int32)) '員工還刀數 
            .Columns.Add("NOReturn", GetType(Int32)) '未還數

        End With

        Grid1.DataSource = ds.Tables("KnifeChange")

    End Sub

    ''' <summary>
    ''' 判斷數據
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function CheckData() As Boolean
        CheckData = True

        If txtWH.Text = "" Then
            MsgBox("倉庫編號不能為空!", 64, "提示")
            CheckData = False
            Exit Function
        End If

        If ds.Tables("KnifeChange").Rows.Count <= 0 Then
            MsgBox("無記錄保存!", 64, "提示")
            CheckData = False
            Exit Function
        End If

        Dim i As Integer
        For i = 0 To ds.Tables("KnifeChange").Rows.Count - 1

            If ds.Tables("KnifeChange").Rows(i)("M_Code").ToString.Trim = "" Then
                MsgBox("物料編碼不能為空", 64, "提示")
                CheckData = False
                Exit Function
            End If
            If ds.Tables("KnifeChange").Rows(i)("M_Name").ToString.Trim = "" Then
                MsgBox("物料名稱不能為空", 64, "提示")
                CheckData = False
                Exit Function
            End If
            If ds.Tables("KnifeChange").Rows(i)("M_Gauge").ToString.Trim = "" Then
                MsgBox("物料規格不能為空", 64, "提示")
                CheckData = False
                Exit Function
            End If

            '----------------------
            If ds.Tables("KnifeChange").Rows(i)("CBegin_Qty") = ds.Tables("KnifeChange").Rows(i)("CEnd_Qty") Then
                CheckData = False
                MsgBox("更改前數量與更改后數量相同,請檢查!", 64, "提示")
                Exit Function
            End If


            Dim M_Code1 As String
            Dim NowWareInvent As Double '讀取保存時的最后庫存
            M_Code1 = ds.Tables("KnifeChange").Rows(i)("M_Code").ToString
            '----------------------
            ' If strType = "WT1" Or strType = "WT2" Then
            Select Case strType
                Case "WT1", "WT2"
                    Dim wi As LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
                    Dim wc As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl
                    wi = wc.KnifeWareInventorySub_GetList(M_Code1, txtWH.Tag)
                    If wi Is Nothing Then
                        NowWareInvent = 0
                    Else
                        If strType = "WT1" Then  '待處理
                            NowWareInvent = wi.WI_SReQty
                        ElseIf strType = "WT2" Then '新刀
                            NowWareInvent = wi.WI_SQty
                        End If
                    End If

                    If NowWareInvent = ds.Tables("KnifeChange").Rows(i)("CBegin_Qty") Then
                    Else
                        CheckData = False
                        MsgBox("當前物料編碼庫存已孌更,請檢查!", 64, "提示")
                        Exit Function
                    End If

                Case "KT3" '員工領刀
                    'B_Num
                    Dim strB_Num As String
                    strB_Num = ds.Tables("KnifeChange").Rows(i)("B_Num").ToString

                    Dim bl As New List(Of KnifeBorrowInfo)
                    Dim bc As New KnifeBorrowControl
                    bl = bc.KnifeBorrow_GetList(strB_Num, Nothing, Nothing, txtWH.Tag, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

                    If bl.Count = 1 Then
                    Else
                        CheckData = False
                        MsgBox(strB_Num & "領刀單已不存在,請檢查！", 64, "提示")
                        Exit Function
                    End If

                    If ds.Tables("KnifeChange").Rows(i)("CBegin_Qty") <> bl(0).B_Qty Then
                        CheckData = False
                        MsgBox("領刀數有變更,請檢查!  最新領刀數為" & bl(0).B_Qty, 64, "提示")
                        Exit Function
                    End If

                    If ds.Tables("KnifeChange").Rows(i)("CEnd_Qty") < bl(0).R_Qty Then
                        CheckData = False
                        MsgBox("調整后數量不能小於已還刀數!" & "當前還刀數為:" & bl(0).R_Qty, 64, "提示")
                        Exit Function
                    End If

                    Dim wi As LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
                    Dim wc As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl
                    wi = wc.KnifeWareInventorySub_GetList(M_Code1, txtWH.Tag)

                    If wi.WI_SQty - (ds.Tables("KnifeChange").Rows(i)("CEnd_Qty") - ds.Tables("KnifeChange").Rows(i)("CBegin_Qty")) < 0 Then
                        CheckData = False
                        MsgBox("當前庫存不足扣除當前差異數!" & "當前庫存數為:" & wi.WI_SQty, 64, "提示")
                        Exit Function
                    End If

                Case "KT4" '員工還刀
                    'B_Num
                    Dim strB_Num As String
                    strB_Num = ds.Tables("KnifeChange").Rows(i)("B_Num").ToString

                    Dim bl As New List(Of KnifeBorrowInfo)
                    Dim bc As New KnifeBorrowControl
                    bl = bc.KnifeBorrow_GetList(strB_Num, Nothing, Nothing, txtWH.Tag, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

                    If bl.Count = 1 Then
                    Else
                        CheckData = False
                        MsgBox(strB_Num & "領刀單已不存在,請檢查！", 64, "提示")
                        Exit Function
                    End If

                    If ds.Tables("KnifeChange").Rows(i)("CBegin_Qty") <> bl(0).R_Qty Then
                        CheckData = False
                        MsgBox("還刀數有變更,請檢查!  最新還刀數為" & bl(0).R_Qty, 64, "提示")
                        Exit Function
                    End If

                    If ds.Tables("KnifeChange").Rows(i)("CEnd_Qty") > bl(0).B_Qty Then
                        CheckData = False
                        MsgBox("調整后數量不能大於,已領刀數!", 64, "提示")
                        Exit Function
                    End If

                    Dim wi As LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
                    Dim wc As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl
                    wi = wc.KnifeWareInventorySub_GetList(M_Code1, txtWH.Tag)

                    If (ds.Tables("KnifeChange").Rows(i)("CEnd_Qty") - ds.Tables("KnifeChange").Rows(i)("CBegin_Qty")) + wi.WI_SQty < 0 Then
                        CheckData = False
                        MsgBox("當前庫存不足扣除當前差異數!" & "當前庫存數為:" & wi.WI_SQty, 64, "提示")
                        Exit Function
                    End If

                Case "KT5" '更改單增加
            End Select
        Next

    End Function


    Private Sub txtWH_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtWH.ButtonClick
        If ds.Tables("KnifeChange").Rows.Count > 0 Then
            MsgBox("不能更改倉庫,當前保存數據中已存在記錄!", 64, "提示")
            Exit Sub
        End If

        frmWareHouseSelect.SelectWareID = ""
        frmWareHouseSelect.StartPosition = FormStartPosition.Manual
        frmWareHouseSelect.Left = Me.Left + txtWH.Left + 2
        frmWareHouseSelect.Top = Me.Top + txtWH.Top + txtWH.Height + 21 + GroupBox1.Height
        frmWareHouseSelect.SelectWareID = ""
        tempValue3 = "510706"
        frmWareHouseSelect.ShowDialog()
        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            txtWH.Tag = frmWareHouseSelect.SelectWareID
            txtWH.Text = frmWareHouseSelect.SelectWareName
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckData() = False Then
            Exit Sub
        End If

        If strType = "KT5" Then
            SaveDataNewBorrow()
        Else
            SaveData()
        End If



    End Sub
    ''' <summary>
    ''' 更改單流水
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function KnifeChange_GetNUM() As String
        '生成新pm
        Dim pm As New KnifeChangeControl
        Dim pi As New KnifeChangeInfo
        Dim ndate As String
        ndate = "KV" + Format(Now(), "yyMM")
        pi = pm.KnifeChange_GetNUM(ndate)
        If pi Is Nothing Then
            KnifeChange_GetNUM = ndate + "00001"
        Else
            KnifeChange_GetNUM = ndate + Mid((CInt(Mid(pi.CH_Num, 7)) + 100001), 2)
        End If
    End Function
    Function SaveData() As String
        SaveData = ""

        txtCH_Num.Text = KnifeChange_GetNUM()
        If Len(txtCH_Num.Text) <= 0 Then
            MsgBox("獲取流水號失敗!")
            Exit Function
        End If
        '---------------------------------------
        Dim k As Integer
        For k = 0 To ds.Tables("KnifeChange").Rows.Count - 1
            ''增加一條更改記錄
            Dim cc As New KnifeChangeControl
            Dim ci As New KnifeChangeInfo

            ci.CH_Num = txtCH_Num.Text

            ci.M_Code = ds.Tables("KnifeChange").Rows(k)("M_Code").ToString
            ci.WH_ID = txtWH.Tag

            ci.CBegin_Qty = ds.Tables("KnifeChange").Rows(k)("CBegin_Qty")
            ci.CEnd_Qty = ds.Tables("KnifeChange").Rows(k)("CEnd_Qty")
            ci.CKType = GridLookChangeType.EditValue

            ci.CReMark = ds.Tables("KnifeChange").Rows(k)("CReMark").ToString
            ci.C_Action = InUserID
            ci.C_Date = Format(CDate(DateC_Date.EditValue), "yyyy/MM/dd HH:mm:ss")
            ci.CReMark = "被動調整--" & ds.Tables("KnifeChange").Rows(k)("CReMark")


            If IsDBNull(ds.Tables("KnifeChange").Rows(k)("B_Num")) = True Then
            Else
                ci.BR_NO = ds.Tables("KnifeChange").Rows(k)("B_Num").ToString
            End If

            If cc.KnifeChange_Add(ci) = True Then

                Select Case strType
                    Case "WT1", "WT2"  '調整庫存
                        If UpdateQty(ds.Tables("KnifeChange").Rows(k)("M_Code").ToString, ds.Tables("KnifeChange").Rows(k)("CEnd_Qty"), strType) = True Then
                        Else
                            MsgBox(ds.Tables("KnifeChange").Rows(k)("M_Code").ToString & "庫存調整失敗!", 64, "提示")
                            Exit Function
                        End If
                    Case "KT3", "KT4" '員工領刀數  '員工還刀
                        ''更改員工領刀單中的領刀數 
                        ''再更新庫存
                        Dim strB_Num As String
                        strB_Num = ds.Tables("KnifeChange").Rows(k)("B_Num").ToString

                        Dim bl As New List(Of KnifeBorrowInfo)
                        Dim bc As New KnifeBorrowControl
                        bl = bc.KnifeBorrow_GetList(strB_Num, Nothing, Nothing, txtWH.Tag, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                        ''----------------------------------------------------------------------------------
                        Dim BCC As New KnifeBorrowControl
                        Dim BII As New KnifeBorrowInfo
                        BII.B_Num = strB_Num
                        If strType = "KT3" Then
                            BII.R_Qty = bl(0).R_Qty
                            BII.B_Qty = ds.Tables("KnifeChange").Rows(k)("CEnd_Qty")
                            BII.NOReturn = ds.Tables("KnifeChange").Rows(k)("CEnd_Qty") - bl(0).R_Qty
                        ElseIf strType = "KT4" Then
                            BII.R_Qty = ds.Tables("KnifeChange").Rows(k)("CEnd_Qty")
                            BII.B_Qty = bl(0).B_Qty
                            BII.NOReturn = bl(0).B_Qty - ds.Tables("KnifeChange").Rows(k)("CEnd_Qty")
                        End If

                        If BCC.KnifeBorrow_UpdateChangeBRQty(BII) = True Then
                            '不更改庫存
                            'Dim WareCha As Int32
                            'WareCha = ds.Tables("KnifeChange").Rows(k)("CEnd_Qty") - ds.Tables("KnifeChange").Rows(k)("CBegin_Qty")

                            'If UpdateQty(ds.Tables("KnifeChange").Rows(k)("M_Code").ToString, WareCha, strType) = True Then
                            'Else
                            '    MsgBox(strB_Num & "庫存調整失敗!")
                            '    Exit Function
                            'End If
                        End If

                    Case "KT5" '更改單增加
                        '要判斷驗証倉庫
                        '領刀上限
                End Select
            End If
        Next
        MsgBox("保存成功!", 64, "提示")
        Me.Close()



    End Function
    ''' <summary>
    ''' 更新庫存
    ''' </summary>
    ''' <param name="_M_code"></param>
    ''' <param name="_CEnd_Qty"></param>
    ''' <param name="_strType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function UpdateQty(ByVal _M_code As String, ByVal _CEnd_Qty As Int32, ByVal _strType As String) As Boolean

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

        wiinfo = wcco.KnifeWareInventorySub_GetList(_M_code, txtWH.Tag)
        If wiinfo Is Nothing Then
            dbWI_SReQty = 0
            dblWI_SQty = 0
        Else
            dblWI_SQty = wiinfo.WI_SQty
            dbWI_SReQty = wiinfo.WI_SReQty
        End If
        '---------------------'---------------------'---------------------'---------------------
        Dim wifo As New LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
        Select Case _strType
            Case "WT2" ''''新刀  '直接更改為多少數量
                wifo.WI_SQty = _CEnd_Qty
                wifo.WI_SReQty = dbWI_SReQty
                wifo.WI_All = dblWI_All + (_CEnd_Qty - dblWI_SQty)
            Case "WT1" '待處理
                wifo.WI_SQty = dblWI_SQty
                wifo.WI_SReQty = _CEnd_Qty
                wifo.WI_All = dblWI_All + (_CEnd_Qty - dbWI_SReQty)
            Case "KT3" ''''新刀     減掉多少數
                wifo.WI_SQty = dblWI_SQty - _CEnd_Qty
                wifo.WI_SReQty = dbWI_SReQty
                wifo.WI_All = dblWI_All - _CEnd_Qty
            Case "KT4" '還刀
                wifo.WI_SQty = dblWI_SQty + _CEnd_Qty
                wifo.WI_SReQty = dbWI_SReQty
                wifo.WI_All = dblWI_All + _CEnd_Qty
        End Select


        wifo.M_Code = _M_code
        wifo.WH_ID = txtWH.Tag
        If wcco.KnifeWareInventorySub_Update(wifo) = False Then
            UpdateQty = False
        End If

    End Function


    ''' <summary>
    ''' 載入數據
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function LoadData(ByVal CH_NumText As String) As Boolean
        Dim cC As New KnifeChangeControl
        Dim cL As New List(Of KnifeChangeInfo)
        cL = cC.KnifeChange_GetList(CH_NumText, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If cL.Count <= 0 Then
            MsgBox("無數據保存!", 64, "提示")
            Exit Function
        End If

        txtWH.Tag = cL(0).WH_ID
        txtWH.Text = cL(0).WH_Name
        GridLookChangeType.EditValue = cL(0).CKType
        DateC_Date.EditValue = cL(0).C_Date
        '-------------------------------------------------------------------
        Dim K As Integer
        For K = 0 To cL.Count - 1
            Dim row As DataRow
            row = ds.Tables("KnifeChange").NewRow

            row("AutoID") = cL(K).AutoID
            row("M_Code") = cL(K).M_Code
            row("M_Name") = cL(K).M_Name
            row("M_Gauge") = cL(K).M_Gauge

            row("CBegin_Qty") = cL(K).CBegin_Qty
            row("CEnd_Qty") = cL(K).CEnd_Qty
            row("CReMark") = cL(K).CReMark

            row("B_Num") = cL(K).BR_NO
            ds.Tables("KnifeChange").Rows.Add(row)
        Next

        '------------------------------------------------------------------
    End Function

    Private Sub popWareOutDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutDel.Click
        If ds.Tables("KnifeChange").Rows.Count = 0 Then Exit Sub

        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "AutoID")
        ds.Tables("KnifeChange").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))

    End Sub

    Private Sub ToolStripBorrowReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripBorrowReturn.Click

        If txtWH.Text = "" Then
            txtWH.Select()
            MsgBox("請選擇倉庫編號!", 64, "提示")
            Exit Sub
        End If
        tempValue2 = GridLookChangeType.EditValue
        tempValue = txtWH.Tag
        frmKnifeChangeLoad.ShowDialog()
        frmKnifeChangeLoad.Dispose()

    End Sub


#Region "樣式1"
    Private Sub ButtonLoadBnum1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoadBnum1.Click
        '領刀流水號------------------

        If txtWH.Text = "" Then
            txtWH.Select()
            MsgBox("請選擇倉庫編號!", 64, "提示")
            Exit Sub
        End If

        If TextBrrow.Text = "" Then
            TextBrrow.Select()
            MsgBox("領刀單不能為空!", 64, "提示")
            Exit Sub
        End If
        AddKnifeNO(TextBrrow.Text, txtWH.Tag)
    End Sub

    Sub AddKnifeNO(ByVal TextBrrow As String, ByVal txtWHTag As String)
        ' ds.Tables("KnifeChangeLoad").Clear()

        Dim cb As New List(Of KnifeBorrowInfo)
        Dim cc As New KnifeBorrowControl
        cb = cc.KnifeBorrow_GetList(TextBrrow, Nothing, Nothing, txtWHTag, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If cb.Count = 1 Then
        Else
            MsgBox("此領刀單輸入有誤!", 64, "提示")
            Exit Sub
        End If
        ''-------------------------------------------------------------------------------

        Dim j As Integer
        For j = 0 To ds.Tables("KnifeChange").Rows.Count - 1
            If TextBrrow = ds.Tables("KnifeChange").Rows(j)("B_Num").ToString Then
                MsgBox("同一張更改單中不允許存在相同的領刀單！", 64, "提示")
                GridView1.FocusedRowHandle = j
                Exit Sub
            End If
        Next
        ''-------------------------------------------------------------------------------
        Dim row As DataRow
        row = ds.Tables("KnifeChange").NewRow

        row("B_Num") = TextBrrow
        row("M_Code") = cb(0).M_Code
        row("M_Name") = cb(0).M_Name
        row("M_Gauge") = cb(0).M_Gauge

        row("BQty") = cb(0).B_Qty '員工領刀數
        row("RQty") = cb(0).R_Qty '員工還刀數 
        row("NOReturn") = cb(0).NOReturn '未還數

        '’-----------------子--------------------------------

        If strType = "KT3" Then  '待處理
            row("CBegin_Qty") = cb(0).B_Qty
        ElseIf strType = "KT4" Then '新刀
            row("CBegin_Qty") = cb(0).R_Qty
        End If
        row("CEnd_Qty") = 0
        ''------------------------------------------------------
        ds.Tables("KnifeChange").Rows.Add(row)

    End Sub
    '領刀流水號:
    Private Sub TextBrrow_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBrrow.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonLoadBnum1_Click(Nothing, Nothing)
        End If
    End Sub
#End Region

#Region "庫存更改"

    Private Sub ButtonM_CodeA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonM_CodeA.Click
        '調整倉庫數
        If txtWH.Text = "" Then
            txtWH.Select()
            MsgBox("請選擇倉庫編號!", 64, "提示")
            Exit Sub
        End If

        If TxtM_CodeA.Text = "" Then
            TxtM_CodeA.Select()
            MsgBox("刀具編碼為空!", 64, "提示")
            Exit Sub
        End If

        AddRow(TxtM_CodeA.Text, 0)
    End Sub

    Private Sub TxtM_CodeA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtM_CodeA.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonM_CodeA_Click(Nothing, Nothing)
        End If
    End Sub

    'Private Sub popWareOutAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutAdd.Click

    '    If txtWH.Text = "" Then
    '        txtWH.Select()
    '        MsgBox("請選擇倉庫編號!", 64, "提示")
    '        Exit Sub
    '    End If


    '    tempCode = ""
    '    tempValue5 = txtWH.Tag
    '    tempValue6 = "Knife"
    '    frmBOMSelect.ShowDialog()

    '    If frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 0 Then
    '        '增加記錄
    '        If tempCode = "" Then
    '            Exit Sub
    '        Else
    '            AddRow(tempCode, 0)
    '        End If
    '    End If


    '    tempValue7 = ""
    '    tempValue8 = ""
    'End Sub

    Sub AddRow(ByVal strCode As String, ByVal strQty As Single)
        Dim row As DataRow
        row = ds.Tables("KnifeChange").NewRow
        If strCode = "" Then
        Else
            Dim j As Integer
            For j = 0 To ds.Tables("KnifeChange").Rows.Count - 1
                If strCode = ds.Tables("KnifeChange").Rows(j)("M_Code") Then
                    MsgBox("物料已存在,同一張更改單中不允許存在相同的刀具編碼！", 64, "提示")
                    GridView1.FocusedRowHandle = j
                    Exit Sub
                End If
            Next

            Dim wi6 As LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
            Dim wc6 As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl
            wi6 = wc6.KnifeWareInventorySub_GetList(strCode, txtWH.Tag)

            If wi6 Is Nothing Then
                MsgBox("當前倉庫無此刀具信息！", 64, "提示")
                Exit Sub
            End If

            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)

            row("M_Code") = objInfo.M_Code
            row("M_Name") = objInfo.M_Name
            row("M_Gauge") = objInfo.M_Gauge
            '’-----------------子--------------------------------

            If strType = "WT1" Then  '待處理
                row("CBegin_Qty") = wi6.WI_SReQty
            ElseIf strType = "WT2" Then '新刀
                row("CBegin_Qty") = wi6.WI_SQty
            End If
            row("CEnd_Qty") = 0
            ''------------------------------------------------------
            ds.Tables("KnifeChange").Rows.Add(row)
        End If
        GridView1.MoveLast()
    End Sub

#End Region




#Region "樣式2"
    Private Sub ButtonLoadBnum2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoadBnum2.Click
        If txtPerNO2.Text = "" Then
            txtPerNO2.Select()
            MsgBox("借刀工號不能為空!", 64, "提示")
            Exit Sub
        End If

        If txtM_Code.Text = "" Then
            txtM_Code.Select()
            MsgBox("刀具編號不能為空!", 64, "提示")
            Exit Sub
        End If

        If Val(txtQty.Text) = 0 Then
            txtQty.Select()
            MsgBox("數量不能為0!", 64, "提示")
            Exit Sub
        End If

        If txtWH.Text = "" Then
            txtWH.Select()
            MsgBox("請選擇倉庫編號!", 64, "提示")
            Exit Sub
        End If

        ' ds.Tables("KnifeChange").Clear()


        Dim kcc As New KnifeReturnControl
        Dim kll As New List(Of KnifeReturnInfo)
        kll = kcc.KnifeBorrow_NOReturnGroupGetList(Me.txtPerNO2.Text, Me.txtM_Code.Text, txtWH.Tag, Nothing, Nothing)

        If kll.Count <> 1 Then
            MsgBox("當前人員無此刀具借刀信息！", 64, "提示")
            Exit Sub
        Else
            If kll(0).SumB_QTY - kll(0).SumR_QTY < Val(txtQty.Text) Then
                MsgBox("未結數不夠", 64, "提示")
                Exit Sub
            End If
        End If

        Dim kc As New KnifeBorrowControl
        Dim kl As New List(Of KnifeBorrowInfo)
        kl = kc.KnifeBorrowDedu_GetList(Me.txtM_Code.Text, txtWH.Tag, txtPerNO2.Text, Nothing)
        If kl.Count <= 0 Then
            MsgBox("無數據存在!", 64, "提示")
            Exit Sub
        End If

        Dim RQty As Int32
        RQty = Val(txtQty.Text)

        'Dim j As Integer

        Dim i As Integer
        Dim TempDouble As Double
        TempDouble = RQty '本次還的數量

        For i = 0 To kl.Count - 1

            ''-------------------------------------------------------------------------------
            Dim TextBrrow As String = kl(i).B_Num
            Dim j As Integer
            For j = 0 To ds.Tables("KnifeChange").Rows.Count - 1
                If TextBrrow = ds.Tables("KnifeChange").Rows(j)("B_Num").ToString Then
                    MsgBox("同一張更改單中不允許存在相同的領刀單！", 64, "提示")
                    GridView1.FocusedRowHandle = j
                    Exit Sub
                End If
            Next
            ''-------------------------------------------------------------------------------


            Dim doubleNOReturn As Double '未還刀數
            doubleNOReturn = kl(i).B_Qty - kl(i).R_Qty

            Dim NODouble As Double '
            Dim KnifeReturnDouble As Double '本單已還數
            Dim DoubleDeafautCEndQty As Double ''更改后的初使值

            If TempDouble > 0 Then
                If TempDouble > doubleNOReturn Then '歸還數 大於 未還數
                    NODouble = 0
                    TempDouble = TempDouble - doubleNOReturn
                    KnifeReturnDouble = kl(i).B_Qty
                    DoubleDeafautCEndQty = kl(i).B_Qty
                Else
                    NODouble = doubleNOReturn - TempDouble
                    KnifeReturnDouble = TempDouble + kl(i).R_Qty '本次歸還數加上已歸還數  '上下兩行不能交換
                    DoubleDeafautCEndQty = kl(i).R_Qty + TempDouble ''已還數+可還數
                    TempDouble = 0

                End If

                Dim row As DataRow
                row = ds.Tables("KnifeChange").NewRow
                row("B_Num") = kl(i).B_Num
                row("M_Code") = kl(i).M_Code
                row("M_Name") = kl(i).M_Name
                row("M_Gauge") = kl(i).M_Gauge
                row("CBegin_Qty") = kl(i).R_Qty
                row("CEnd_Qty") = DoubleDeafautCEndQty
                ''-------------------------------------

                row("BQty") = kl(i).B_Qty '員工領刀數
                row("RQty") = kl(i).R_Qty '員工還刀數 
                row("NOReturn") = kl(i).NOReturn '未還數

                ds.Tables("KnifeChange").Rows.Add(row)
            Else
                Exit For
            End If
        Next



    End Sub

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
#End Region

    ''------------
#Region "更改單增加"
    Private Sub ButtonChangeAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonChangeAdd.Click

        If TxtM_Code4.Text = "" Then
            TxtM_Code4.Select()
            MsgBox("刀具編號不能為空!", 64, "提示")
            Exit Sub
        End If

        If txtPerNO4.Text = "" Then
            txtPerNO4.Select()
            MsgBox("工號不能為空!", 64, "提示")
            Exit Sub
        End If

        If txtWH.Text = "" Then
            txtWH.Select()
            MsgBox("請選擇倉庫編號!", 64, "提示")
            Exit Sub
        End If

        ds.Tables("KnifeChange").Clear()
        AddRow4(TxtM_Code4.Text)

    End Sub

    Sub AddRow4(ByVal strCode As String)
        Dim row As DataRow
        row = ds.Tables("KnifeChange").NewRow

        If strCode = "" Then
        Else
            Dim j As Integer
            For j = 0 To ds.Tables("KnifeChange").Rows.Count - 1
                If strCode = ds.Tables("KnifeChange").Rows(j)("M_Code") Then
                    MsgBox("物料已存在,同一張更改單中不允許存在相同的刀具編碼！", 64, "提示")
                    GridView1.FocusedRowHandle = j
                    Exit Sub
                End If
            Next

            Dim wi6 As LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
            Dim wc6 As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl
            wi6 = wc6.KnifeWareInventorySub_GetList(strCode, txtWH.Tag)

            If wi6 Is Nothing Then
                MsgBox("當前倉庫無此刀具信息！", 64, "提示")
                Exit Sub
            End If

            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)

            row("M_Code") = objInfo.M_Code
            row("M_Name") = objInfo.M_Name
            row("M_Gauge") = objInfo.M_Gauge
            row("CBegin_Qty") = 0
            row("CEnd_Qty") = 0
            ''------------------------------------------------------
            ds.Tables("KnifeChange").Rows.Add(row)
        End If
        GridView1.MoveLast()
    End Sub

    ''' <summary>
    ''' 增加數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveDataNewBorrow()
        Dim wbc As New KnifeBorrowControl
        Dim wbi As New KnifeBorrowInfo
        Dim txtB_NOEditValue As String

        txtB_NOEditValue = GetB_ID()

        If Len(txtB_NOEditValue) = 0 Then
            MsgBox("不能生成單號，無法保存！", 64, "提示")
            Exit Sub
        End If

        ''更改單流水號----------------------
        Dim txtCH_Num As String
        txtCH_Num = KnifeChange_GetNUM()
        If Len(txtCH_Num) <= 0 Then
            MsgBox("獲取流水號失敗!", 64, "提示")
            Exit Sub
        End If
        '-----------------------------------
        Dim j As New Integer
        wbi.WH_ID = txtWH.Tag
        wbi.BPer_ID = txtPerNO4.Text
        wbi.BPer_Name = ""
        wbi.B_NO = txtB_NOEditValue
        wbi.B_Date = Format(CDate(DateC_Date.EditValue), "yyyy/MM/dd")
        wbi.B_Action = InUserID
        wbi.B_Type = "新刀"

        For j = 0 To ds.Tables("KnifeChange").Rows.Count - 1
            wbi.B_Num = GetB_NUM()
            Dim Ls As String
            Ls = wbi.B_Num

            wbi.M_Code = ds.Tables("KnifeChange").Rows(j)("M_Code").ToString
            wbi.B_Qty = ds.Tables("KnifeChange").Rows(j)("CEnd_Qty")
            wbi.NOReturn = ds.Tables("KnifeChange").Rows(j)("CEnd_Qty")
            wbi.B_Remark = "系統自動增加:" & ds.Tables("KnifeChange").Rows(j)("CReMark").ToString

            Dim wi As LFERP.Library.KnifeWare.KnifeWareInventorySubInfo
            Dim wc As New LFERP.Library.KnifeWare.KnifeWareInventorySubControl
            Dim intEndQty As Int32 = 0
            Dim intAllEndQty As Int32 = 0

            wi = wc.KnifeWareInventorySub_GetList(ds.Tables("KnifeChange").Rows(j)("M_Code").ToString, txtWH.Tag)
            If wi Is Nothing Then
            Else
                intEndQty = wi.WI_SQty
                intAllEndQty = wi.WI_Qty
            End If

            wbi.B_EndQty = intEndQty - ds.Tables("KnifeChange").Rows(j)("CEnd_Qty")
            wbi.B_AllEndQty = intAllEndQty - ds.Tables("KnifeChange").Rows(j)("CEnd_Qty")

            If wbc.KnifeBorrow_Add(wbi) = True Then
                ''增加更改單記錄
                If SaveDataChange(txtCH_Num, j, Ls) = True Then
                Else
                    MsgBox("部分保存失敗!", 64, "提示")
                    Exit Sub
                End If
            End If
        Next
        MsgBox("保存成功!", 64, "提示")
        Me.Close()
    End Sub
    ''' <summary>
    ''' 增加更改單記錄
    ''' </summary>
    ''' <param name="_txtCH_Num"></param>
    ''' <param name="k"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function SaveDataChange(ByVal _txtCH_Num As String, ByVal k As Integer, ByVal _BR_NO As String) As Boolean

        SaveDataChange = True

        ''增加一條更改記錄
        Dim cc As New KnifeChangeControl
        Dim ci As New KnifeChangeInfo

        ci.CH_Num = _txtCH_Num

        '2014-01-08
        ci.BR_NO = _BR_NO

        ci.M_Code = ds.Tables("KnifeChange").Rows(k)("M_Code").ToString
        ci.WH_ID = txtWH.Tag

        ci.CBegin_Qty = ds.Tables("KnifeChange").Rows(k)("CBegin_Qty")
        ci.CEnd_Qty = ds.Tables("KnifeChange").Rows(k)("CEnd_Qty")
        ci.CKType = GridLookChangeType.EditValue

        ci.CReMark = ds.Tables("KnifeChange").Rows(k)("CReMark").ToString
        ci.C_Action = InUserID
        ci.C_Date = Format(CDate(DateC_Date.EditValue), "yyyy/MM/dd HH:mm:ss")
        ci.CReMark = "被動調整--" & ds.Tables("KnifeChange").Rows(k)("CReMark")

        If cc.KnifeChange_Add(ci) = True Then
        Else
            SaveDataChange = True
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
#End Region

End Class