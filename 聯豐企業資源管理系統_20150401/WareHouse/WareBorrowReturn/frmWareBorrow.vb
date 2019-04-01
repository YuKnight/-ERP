Imports LFERP.Library.WareHouse.WareBorrowReturn
Imports LFERP.Library.WareHouse
Imports LFERP.Library.Purchase.SharePurchase
Imports LFERP.Library.Shared
Imports LFERP.SystemManager

Public Class frmWareBorrow
    Dim ds As New DataSet
    Dim strWHID As String
    Dim strDPTID As String
    Dim isShowLCD As Boolean = False  '是否在LCD小屏幕上顯示出庫信息

    Private Sub frmWareBorrow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        '@ 2013/6/11 添加

        If isShowLCD = False Then Exit Sub

        ApiDisplay.display_wellcome()   'LCD顯示屏恢復為初始界面
        ApiDisplay.com_exit() '斷開COM連接
        isOpenCOM = False   'COM打開標記為False
    End Sub


    Private Sub frmWareBorrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTables()
        LoadUserPower()

        LabMsg.Text = tempValue
        strWHID = tempValue3
        txtWH.EditValue = tempValue4
        txtWBID.Text = tempValue5

        tempValue4 = Nothing
        tempValue3 = Nothing
        tempValue = Nothing
        tempValue5 = Nothing

        ButtonEdit2.Enabled = False
        cmdSave.Enabled = False


        Select Case LabMsg.Text
            Case "借刀單"

                '重置新刷卡機
                Dim reset As New ResetPassWords.SetPassWords
                reset.SetPassWords()
                txtWBID.Enabled = False

                If Edit = False Then
                    WB_EndQty.Visible = False
                    DateEdit1.EditValue = Format(Now, "yyyy/MM/dd")
                    Me.Text = "借刀單-新增"
                End If
                XtraTabPage2.PageVisible = False

            Case "查看"
                tempValue3 = Nothing

                popWareWB.Enabled = False
                WB_EndQty.Visible = True
                cmdSave.Visible = False
                Me.Text = "借刀單-查看"
                sk.Enabled = False
                XtraTabControl1.SelectedTabPage = XtraTabPage1
                loadedit(txtWBID.Text)

            Case "借刀延期"
                tempValue3 = Nothing
                XtraTabPage1.PageVisible = False
                Me.Text = "借刀單-延期"
                sk.Enabled = False
                DateEdit1.Enabled = False
                cmdSave.Enabled = True
                loadeditYanQi(txtWBID.Text)
        End Select



    End Sub

    '@ 2013/6/11 添加 權限控制
    Sub LoadUserPower()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        '在LCD小顯示屏上顯示信息
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "50100104")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then isShowLCD = True
        End If
    End Sub

    Sub UpdateYanQI()

        If ds.Tables("BorrowYQ").Rows.Count > 0 Then
        Else
            MsgBox("無任何數據需要保存!")
            Exit Sub
        End If

        Dim i As Integer

        For i = 0 To ds.Tables("BorrowYQ").Rows.Count - 1
            If IsDBNull(ds.Tables("BorrowYQ").Rows(i)("WB_NUM")) = True Then
                MsgBox("無編號存在請檢查!")
                Exit Sub
            End If
        Next

        Dim wbc As New WareBorrowReturnControl
        Dim wbi As New WareBorrowReturnInfo

        Dim j As New Integer
        For j = 0 To ds.Tables("BorrowYQ").Rows.Count - 1
            wbi.WB_NUM = ds.Tables("BorrowYQ").Rows(j)("WB_NUM").ToString

            If IsDBNull(ds.Tables("BorrowYQ").Rows(j)("DelayDate")) = True Then
                wbi.DelayDate = Nothing
            Else
                wbi.DelayDate = ds.Tables("BorrowYQ").Rows(j)("DelayDate")
            End If

            wbi.DelayRemark = ds.Tables("BorrowYQ").Rows(j)("DelayRemark").ToString
            wbi.DelayAction = InUserID

            If wbc.WareBorrowReturn_UpdateDelay(wbi) = True Then
            Else
                MsgBox("部分保存失敗!")
                Exit Sub
            End If
        Next

        MsgBox("保存成功!")

        Me.Close()

    End Sub


    Sub loadeditYanQi(ByVal WB_ID As String)
        ds.Tables("BorrowYQ").Clear()

        Dim wbc As New WareBorrowReturnControl
        Dim objInfo As New List(Of WareBorrowReturnInfo)

        Dim row As DataRow
        Try
            objInfo = wbc.WareBorrowReturn_GetList(Nothing, WB_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If objInfo.Count <= 0 Then
                '沒有數據
                MsgBox("無數據載入！")
                Exit Sub
            End If

            txtWH.EditValue = objInfo(0).WH_ID
            ButtonEdit2.EditValue = objInfo(0).DPT_Name

            TextEdit1.Text = objInfo(0).WB_PerID
            Label4.Text = objInfo(0).WB_PerName

            DateEdit1.EditValue = objInfo(0).WB_Date

            txtWBID.Text = objInfo(0).WB_NO
            LabCao.Text = objInfo(0).DelayActionName

            Dim i As Integer

            For i = 0 To objInfo.Count - 1
                row = ds.Tables("BorrowYQ").NewRow
                row("WB_NUM") = objInfo(i).WB_NUM
                row("M_Code") = objInfo(i).M_Code
                row("M_Name") = objInfo(i).M_Name
                row("M_Gauge") = objInfo(i).M_Gauge
                row("M_Unit") = objInfo(i).M_Unit

                row("Qty") = objInfo(i).Qty
                row("NO_ReQty") = objInfo(i).NO_ReQty

                If objInfo(i).DelayDate Is Nothing Then
                Else
                    row("DelayDate") = objInfo(i).DelayDate
                End If

                row("DelayRemark") = objInfo(i).DelayRemark

                ds.Tables("BorrowYQ").Rows.Add(row)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub loadedit(ByVal WB_ID As String)
        ds.Tables("Borrow").Clear()

        Dim wbc As New WareBorrowReturnControl
        Dim objInfo As New List(Of WareBorrowReturnInfo)

        Dim row As DataRow
        Try
            objInfo = wbc.WareBorrowReturn_GetList(Nothing, WB_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If objInfo.Count <= 0 Then
                '沒有數據
                MsgBox("無數據載入！")
                Exit Sub
            End If

            txtWH.EditValue = objInfo(0).WH_ID
            ButtonEdit2.EditValue = objInfo(0).DPT_Name

            TextEdit1.Text = objInfo(0).WB_PerID
            Label4.Text = objInfo(0).WB_PerName

            DateEdit1.EditValue = objInfo(0).WB_Date

            txtWBID.Text = objInfo(0).WB_NO

            Dim i As Integer

            For i = 0 To objInfo.Count - 1
                row = ds.Tables("Borrow").NewRow
                row("AutoID") = objInfo(i).AutoID
                row("M_Code") = objInfo(i).M_Code
                row("M_Name") = objInfo(i).M_Name
                row("M_Gauge") = objInfo(i).M_Gauge
                row("M_Unit") = objInfo(i).M_Unit

                row("Qty") = objInfo(i).Qty
                row("WB_EndQty") = objInfo(i).WB_EndQty
                row("Remark") = objInfo(i).Remark

                ds.Tables("Borrow").Rows.Add(row)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub SaveDataNew()
        Dim wbc As New WareBorrowReturnControl
        Dim wbi As New WareBorrowReturnInfo

        txtWBID.EditValue = GetWB_ID()

        If Len(txtWBID.EditValue) = 0 Then
            MsgBox("不能生成單號，無法保存！")
            Exit Sub
        End If

        Dim j As New Integer
        For j = 0 To ds.Tables("Borrow").Rows.Count - 1
            wbi.WB_NO = txtWBID.EditValue
            wbi.WB_NUM = GetWB_NUM()
            wbi.WB_Type = "借刀"

            wbi.M_Code = ds.Tables("Borrow").Rows(j)("M_Code").ToString
            wbi.Qty = ds.Tables("Borrow").Rows(j)("Qty")
            wbi.NO_ReQty = ds.Tables("Borrow").Rows(j)("Qty")

            wbi.DPT_ID = strDPTID
            wbi.WB_PerID = TextEdit1.Text
            wbi.WB_PerName = Label4.Text

            wbi.WH_ID = strWHID
            wbi.WB_Action = InUserID
            wbi.WB_Date = Format(Now, "yyyy/MM/dd")

            wbi.WB_EndQty = ds.Tables("Borrow").Rows(j)("WB_EndQty")

            wbi.Remark = ds.Tables("Borrow").Rows(j)("Remark").ToString

            If wbc.WareBorrowReturn_Add(wbi) = True Then
                ''增加成功后扣除當前選擇倉庫，庫存
                Dim mt As New SharePurchaseController
                Dim mm As New SharePurchaseInfo
                mm.WH_ID = strWHID
                mm.M_Code = ds.Tables("Borrow").Rows(j)("M_Code")

                Dim Qty As Single
                Dim wi As New LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
                Dim wc As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
                wi = wc.WareInventory_GetSub(ds.Tables("Borrow").Rows(j)("M_Code"), strWHID)

                If wi Is Nothing Then
                    Qty = 0
                Else
                    Qty = wi.WI_Qty
                End If

                mm.WI_Qty = Qty - CSng(ds.Tables("Borrow").Rows(j)("Qty"))

                mt.UpdateWareInventory_WIQty2(mm)
            Else
                MsgBox("部分保存失敗!")
                Exit Sub
            End If
        Next

        MsgBox("保存成功!")

    End Sub

    Sub CreateTables()
        ds.Tables.Clear()
        With ds.Tables.Add("Borrow")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))

            .Columns.Add("Qty", GetType(Single))
            .Columns.Add("ShowQty", GetType(Single))
            .Columns.Add("Remark", GetType(String))
            .Columns.Add("WB_EndQty", GetType(Single))

        End With

        Grid.DataSource = ds.Tables("Borrow")


        ''--------------------------------------------------------
        With ds.Tables.Add("BorrowYQ")
            .Columns.Add("WB_NUM", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))

            .Columns.Add("Qty", GetType(Single))
            .Columns.Add("NO_ReQty", GetType(Single))
            .Columns.Add("DelayDate", GetType(Date))
            .Columns.Add("DelayRemark", GetType(String))

        End With

        Grid2.DataSource = ds.Tables("BorrowYQ")
    End Sub

    Function CheckSave() As Boolean
        CheckSave = True

        If txtWH.EditValue = "" Then
            MsgBox("倉庫編號不能為空!")
            CheckSave = False
            Exit Function
        End If

        If TextEdit1.Text = "" Then
            MsgBox("無刷卡信息!")
            CheckSave = False
            Exit Function
        End If


        If ds.Tables("Borrow").Rows.Count <= 0 Then
            MsgBox("無借刀信息!")
            CheckSave = False
            Exit Function
        End If



        Dim i As Integer
        For i = 0 To ds.Tables("Borrow").Rows.Count - 1
            Dim mw As New WareInventory.WareInventoryMTController
            Dim mwi As New WareInventory.WareInventoryInfo

            If ds.Tables("Borrow").Rows(i)("Qty") Is DBNull.Value Then
                MsgBox("請輸入借刀數量!")
                CheckSave = False
                Exit Function
            End If


            If ds.Tables("Borrow").Rows(i)("Qty") = 0 Then
                MsgBox("借刀數量不能為0!")
                CheckSave = False
                Exit Function
            End If

            mwi = mw.WareInventory_GetSub(ds.Tables("Borrow").Rows(i)("M_Code"), strWHID)

            If mwi Is Nothing Then
                MsgBox("物料" & ds.Tables("Borrow").Rows(i)("M_Code") & " 在倉庫" & txtWH.EditValue & "中不存在，不能保存！")
                CheckSave = False
                Exit Function
            End If
            If mwi.WI_Qty - ds.Tables("Borrow").Rows(i)("Qty") < 0 Then
                MsgBox("物料" & ds.Tables("Borrow").Rows(i)("M_Code") & " 在倉庫" & txtWH.EditValue & "庫存不足,不能保存！")
                CheckSave = False
                Exit Function
            End If
        Next
    End Function


    Function GetWB_ID() As String
        '生成新pm
        Dim pm As New WareBorrowReturnControl
        Dim pi As New WareBorrowReturnInfo
        Dim ndate As String
        ndate = "WB" + Format(Now(), "yyMM")
        pi = pm.WareBorrowReturn_GetID(ndate)
        If pi Is Nothing Then
            GetWB_ID = ndate + "00001"
        Else
            GetWB_ID = ndate + Mid((CInt(Mid(pi.WB_NO, 7)) + 100001), 2)
        End If
    End Function

    Function GetWB_NUM() As String
        '生成新pS
        Dim pm1 As New WareBorrowReturnControl
        Dim pi1 As New WareBorrowReturnInfo
        Dim ndate As String
        ndate = "WB"
        pi1 = pm1.WareBorrowReturn_GetNUM(ndate)
        If pi1 Is Nothing Then
            GetWB_NUM = "WB000000001"
        Else
            GetWB_NUM = "WB" & Mid((CInt(Mid(pi1.WB_NUM, 3)) + 1000000001), 2)
        End If
    End Function




    Private Sub popWareOutDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutDel.Click
        If ds.Tables("Borrow").Rows.Count = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "M_Code")
        ds.Tables("Borrow").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub

    Private Sub popWareOutAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutAdd.Click
        tempCode = ""
        tempValue5 = strWHID
        tempValue6 = "倉庫管理"
        tempValue7 = "出庫作業"
        frmBOMSelect.ShowDialog()

        If frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 0 Then
            '增加記錄
            If tempCode = "" Then
                Exit Sub
            Else
                AddRow(tempCode, 0)
            End If
        ElseIf frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 1 Then
            Dim i, n As Integer
            Dim arr(n) As String
            arr = Split(tempValue7, ",")
            n = Len(Replace(tempValue7, ",", "," & "*")) - Len(tempValue7)
            For i = 0 To n
                If arr(i) = "" Then
                    Exit Sub
                End If
                AddRow(arr(i), 0)
            Next
        ElseIf frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 2 Then
            Dim i, n As Integer
            Dim arr(n) As String
            arr = Split(tempValue8, ",")
            n = Len(Replace(tempValue8, ",", "," & "*")) - Len(tempValue8)
            For i = 0 To n

                If arr(i) = "" Then
                    Exit Sub
                End If
                AddRow(arr(i), 0)
            Next
        End If
        tempValue7 = ""
        tempValue8 = ""
    End Sub

    Sub AddRow(ByVal strCode As String, ByVal strQty As Single)

        Dim row As DataRow
        row = ds.Tables("Borrow").NewRow

        If strCode = "" Then
        Else

            Dim j As Integer

            For j = 0 To ds.Tables("Borrow").Rows.Count - 1
                If strCode = ds.Tables("Borrow").Rows(j)("M_Code") Then
                    MsgBox("物料已存在，同一張借刀單中不允許存在相同的刀具編碼！")
                    GridView1.FocusedRowHandle = j
                    Exit Sub
                End If
            Next

            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)

            If objInfo.M_IsEnabled = False Then
                MsgBox("當前刀具不可用，請確認此物料信息！", 64, "提示")
                Exit Sub
            End If

            row("M_Code") = objInfo.M_Code
            row("M_Name") = objInfo.M_Name
            row("M_Unit") = objInfo.M_Unit

            '’-------------------------------------------------------------------------
            Dim unit As New LFERP.DataSetting.UnitController
            Dim unitinfo As List(Of LFERP.DataSetting.UnitInfo)
            unitinfo = unit.GetUnitList(objInfo.M_Unit)
            If unitinfo Is Nothing Then
                row("M_Unit") = unitinfo(0).U_Name
            End If

            '’-------------------------------------------------------------------------
            row("M_Gauge") = objInfo.M_Gauge
            row("ShowQty") = strQty

            '2012-7-16 加入顯示安全庫存與節余數-----------------------------
            Dim wi1 As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
            Dim wc1 As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
            wi1 = wc1.WareInventory_GetSub(strCode, strWHID)

            If wi1 Is Nothing Then
                row("WB_EndQty") = 0
                row("ShowQty") = 0
            Else
                row("WB_EndQty") = wi1.WI_Qty
                row("ShowQty") = wi1.WI_Qty
            End If

            row("Qty") = 0
            ''------------------------------------------------------
            ds.Tables("Borrow").Rows.Add(row)

            '@ 2013/6/11 添加 新增的物料信息在LCD顯示屏上顯示
            If isShowLCD = True Then
                LoadPingMU("借樣辦刀", "名稱：" & ds.Tables("Borrow").Rows(GridView1.FocusedRowHandle)("M_Name"), "規格：" & ds.Tables("Borrow").Rows(GridView1.FocusedRowHandle)("M_Gauge"), "數量：" & ds.Tables("Borrow").Rows(GridView1.FocusedRowHandle)("Qty") & ds.Tables("Borrow").Rows(GridView1.FocusedRowHandle)("M_Unit"))
            End If

        End If
        GridView1.MoveLast()
    End Sub

    Private Sub sk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sk.Click
        TextEdit1.Text = ReadCard1() '讀取卡號

        ' TextEdit1.Text = "00000001"

        Dim wulc As New WhiteUserListController
        Dim wuliL As New List(Of WhiteuserListInfo)
        wuliL = wulc.WhiteUserList_GetList(TextEdit1.Text, Mid(strWHID, 1, 3))
        If wuliL.Count = 0 Then
            MsgBox("未刷卡或非法卡號")
            Exit Sub
        Else
            cmdSave.Text = "確定"
            cmdSave.Enabled = True
        End If

        Label4.Text = wuliL.Item(0).W_UserName
        strDPTID = wuliL.Item(0).DPT_ID
        ButtonEdit2.Text = wuliL.Item(0).DPT_Name
        '-------------------------------------------------------------------------
        ButtonEdit2.Enabled = False
        TextEdit1.Enabled = False
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Me.LabMsg.Text = "借刀延期" Then
            UpdateYanQI()
        End If
        If Me.LabMsg.Text = "借刀單" Then
            If CheckSave() = True Then
                SaveDataNew()
                cmdSave.Enabled = False
                cmdSave.Visible = False
                ButtonBorrow.Visible = True
            End If
        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub ButtonBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBorrow.Click
        Dim ds As New DataSet
        Dim strA As String

        Dim ltc As New CollectionToDataSet
        strA = txtWBID.Text

        Dim bc As New WareBorrowReturnControl
        ltc.CollToDataSet(ds, "WareBorrowReturn", bc.WareBorrowReturn_GetList(Nothing, strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        PreviewRPT(ds, "rptWareBorrow", "借刀單", True, True)
        ltc = Nothing
    End Sub

    '@ 2013/6/11 添加 焦點行改變時，LCD屏幕顯示焦點行物料信息
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If isShowLCD = True Then
            LoadPingMU("借樣辦刀", "名稱：" & ds.Tables("Borrow").Rows(GridView1.FocusedRowHandle)("M_Name"), "規格：" & ds.Tables("Borrow").Rows(GridView1.FocusedRowHandle)("M_Gauge"), "數量：" & ds.Tables("Borrow").Rows(GridView1.FocusedRowHandle)("Qty") & ds.Tables("Borrow").Rows(GridView1.FocusedRowHandle)("M_Unit"))
        End If
    End Sub

    '@ 2013/6/11 數量修改時，LCD屏幕重新顯示物料信息
    Private Sub RepositoryItemCalcEdit2_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCalcEdit2.EditValueChanged
        If isShowLCD = True Then
            LoadPingMU("借樣辦刀", "名稱：" & ds.Tables("Borrow").Rows(GridView1.FocusedRowHandle)("M_Name"), "規格：" & ds.Tables("Borrow").Rows(GridView1.FocusedRowHandle)("M_Gauge"), "數量：" & CDbl(sender.text) & ds.Tables("Borrow").Rows(GridView1.FocusedRowHandle)("M_Unit"))
        End If
    End Sub
End Class