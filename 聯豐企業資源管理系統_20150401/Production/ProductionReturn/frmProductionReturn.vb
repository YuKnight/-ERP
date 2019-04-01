Imports LFERP.Library.ProductionReturn
Imports LFERP.Library.WareHouse.WareInventory
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.Purchase.SharePurchase
Imports LFERP.DataSetting
Imports LFERP.Library.ProductionRetrocede
Imports LFERP.Library.Product

Public Class frmProductionReturn
#Region "屬性"
    Dim ds As New DataSet
    Dim prc As New ProductionReturnControl
    Dim uc As New UserPowerControl
    Dim pic As New ProductInventoryController

    Private strWHOutID As String
    Private strWHInID As String
    Private _EditItem As String
    Private _EditValue As String
    Public Property EditItem() As String
        Get
            Return _EditItem
        End Get
        Set(ByVal value As String)
            _EditItem = value
        End Set
    End Property
    Public Property EditValue() As String
        Get
            Return _EditValue
        End Get
        Set(ByVal value As String)
            _EditValue = value
        End Set
    End Property
#End Region

#Region "窗體啟動載入事件"
    Private Sub frmProductionReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()

        strWHInID = ""
        txtNO.Enabled = False
        cbType.Enabled = False

        Select Case EditItem
            Case "ReturnADD"
                If Edit = False Then
                    DateEdit1.EditValue = Format(Now, "yyyy/MM/dd")
                    cbType.EditValue = "補退貨"
                    Me.Text = "生產-送貨單"
                Else
                    LoadData(EditValue)
                    Me.Text = "修改-送貨單" & EditValue
                End If
                XtraTabControl1.SelectedTabPage = XtraTabPage1
                XtraTabPage3.PageVisible = False
            Case "PreView"
                LoadData(EditValue)
                cmdSave.Visible = False
                Me.Text = "查看--" & "送貨單" & "-" & EditValue
                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Case "Check"
                LoadData(EditValue)
                Me.Text = "審核--" & "送貨單" & "-" & EditValue
                XtraTabControl1.SelectedTabPage = XtraTabPage2
                XtraTabPage3.PageVisible = False
                cmdSave.Enabled = False
                GroupBox1.Enabled = False
                GridView1.OptionsBehavior.Editable = False
                Grid.ContextMenuStrip.Enabled = False


            Case "InCheck"
                LoadData(EditValue)
                Me.Text = "收料審核--" & "送貨單" & "-" & EditValue
                XtraTabControl1.SelectedTabPage = XtraTabPage3
                XtraTabPage2.PageVisible = False
                cmdSave.Enabled = False
                GroupBox1.Enabled = False
                GridView1.OptionsBehavior.Editable = False
                Grid.ContextMenuStrip.Enabled = False
        End Select
    End Sub
#End Region

#Region "創建臨時表"
    Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("Return")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("R_NO", GetType(String))    '跟單扣除數量
            .Columns.Add("Pro_Type", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
            .Columns.Add("AR_Qty", GetType(Integer))
            .Columns.Add("R_NoSendQty", GetType(Integer))
            .Columns.Add("PI_Qty", GetType(Integer))
            .Columns.Add("AR_Detail", GetType(String))
        End With
        Grid.DataSource = ds.Tables("Return")

        With ds.Tables.Add("DelReturn")
            .Columns.Add("AR_NO", GetType(String))
            .Columns.Add("AutoID", GetType(String))
        End With
    End Sub
#End Region

#Region "返回載入數據列表"
    Function LoadData(ByVal AR_NO As String) As Boolean
        LoadData = True

        Try
            Dim pri As List(Of ProductionReturnInfo)
            pri = prc.ProductionReturn_GetList(AR_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            If pri.Count = 0 Then
                LoadData = False
                Exit Function
            Else
                Dim i As Integer
                txtNO.Text = pri(0).AR_NO
                txtWH.Text = pri(0).WH_Name
                strWHOutID = pri(0).WH_OutID
                txtWHInID.Text = pri(0).WH_InName
                strWHInID = pri(0).WH_InID
                cbType.EditValue = pri(0).AR_Type
                DateEdit1.EditValue = Format(pri(0).AR_Date, "yyyy/MM/dd")
                txtRemark.EditValue = pri(0).AR_Remark

                For i = 0 To pri.Count - 1
                    Dim row As DataRow

                    row = ds.Tables("Return").NewRow
                    row("AutoID") = pri(i).AutoID
                    row("R_NO") = pri(i).R_NO    '對應的退貨單號
                    row("Pro_Type") = pri(i).Pro_Type
                    row("PM_M_Code") = pri(i).PM_M_Code
                    row("PM_Type") = pri(i).PM_Type
                    row("AR_Qty") = pri(i).AR_Qty
                    row("AR_Detail") = pri(i).AR_Detail

                    Dim prrc As New ProductionRetrocedeControl
                    Dim prri As New List(Of ProductionRetrocedeInfo)
                    'prri = prrc.ProductionRetrocede_GetList(pri(i).R_NO, Nothing, Nothing, Nothing, Nothing, pri(i).Pro_Type, pri(i).PM_M_Code, pri(i).PM_Type, Nothing)
                    prri = prrc.ProductionRetrocede_GetList(pri(i).R_NO, Nothing, Nothing, Nothing, Nothing, Nothing, pri(i).PM_M_Code, pri(i).PM_Type, Nothing)
                    If prri.Count > 0 Then
                        row("R_NoSendQty") = prri(0).R_NoSendQty
                    Else
                        row("R_NoSendQty") = 0
                    End If

                    Dim pii As New List(Of ProductInventoryInfo)
                    pii = pic.ProductInventory_GetList(pri(0).PM_M_Code, GetM_Code("裝配出貨", pri(0).PM_M_Code, pri(0).PM_Type), strWHOutID, Nothing)
                    If pii.Count > 0 Then
                        row("PI_Qty") = pii(0).PI_Qty
                    Else
                        row("PI_Qty") = 0
                    End If
                    ds.Tables("Return").Rows.Add(row)

                    CheckEdit1.Checked = pri(i).AR_Check
                    CheckDate.Text = Format(pri(i).AR_CheckDate, "yyyy/MM/dd")
                    CheckAction.Text = pri(i).CheckActionName
                    CheckRemark.EditValue = pri(i).AR_CheckRemark

                    ''收料
                    CheckEdit2.Checked = pri(i).AR_InCheck
                    Label5.Text = Format(pri(i).AR_InCheckDate, "yyyy/MM/dd")
                    Label3.Text = pri(i).AR_InCheckActionName
                    MemoEdit1.EditValue = pri(i).AR_InCheckRemark

                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
#End Region

#Region "自動流水號"
    Function GetRNO() As String '生成-退貨-送貨單單號
        Dim pri As New ProductionReturnInfo
        Dim strA As String
        strA = Format(Now, "yyMM")
        pri = prc.ProductionReturn_GetRNO(strA)
        If pri Is Nothing Then
            GetRNO = "AR" + strA + "0001"
        Else
            GetRNO = "AR" + strA + Mid((CInt(Mid(pri.AR_NO, 7)) + 10001), 2)
        End If
    End Function
    Function GetMRNO() As String '生成-補退貨-送貨單號
        Dim pri As New ProductionReturnInfo
        Dim strA As String
        strA = Format(Now, "yyMM")
        pri = prc.ProductionReturn_GetMRNO(strA)
        If pri Is Nothing Then
            GetMRNO = "AMR" + strA + "0001"
        Else
            GetMRNO = "AMR" + strA + Mid((CInt(Mid(pri.AR_NO, 8)) + 10001), 2)
        End If
    End Function
#End Region

#Region "新增事件方法"
    Sub DataNew()
        Dim pri As New ProductionReturnInfo
        txtNO.Text = GetRNO()
        pri.AR_NO = txtNO.Text
        pri.WH_OutID = strWHOutID
        pri.WH_InID = strWHInID
        pri.AR_Type = cbType.EditValue
        pri.AR_Date = DateEdit1.EditValue
        pri.AR_Remark = txtRemark.Text
        pri.AR_Action = InUserID

        Dim i As Integer
        For i = 0 To ds.Tables("Return").Rows.Count - 1
            pri.R_NO = ds.Tables("Return").Rows(i)("R_NO")
            pri.Pro_Type = ds.Tables("Return").Rows(i)("Pro_Type")
            pri.PM_M_Code = ds.Tables("Return").Rows(i)("PM_M_Code")
            pri.PM_Type = ds.Tables("Return").Rows(i)("PM_Type")
            pri.AR_Qty = CSng(ds.Tables("Return").Rows(i)("AR_Qty"))

            If IsDBNull(ds.Tables("Return").Rows(i)("AR_Detail")) Then
                pri.AR_Detail = Nothing
            Else
                pri.AR_Detail = ds.Tables("Return").Rows(i)("AR_Detail")
            End If
            prc.ProductionReturn_Add(pri)
        Next
        MsgBox("保存單號" & txtNO.Text & "信息成功!")
        Me.Close()
    End Sub
#End Region

#Region "修改事件方法"
    Sub DataEdit()
        Dim pri As New ProductionReturnInfo
        pri.AR_NO = txtNO.Text
        pri.WH_OutID = strWHOutID
        pri.WH_InID = strWHInID
        pri.AR_Type = cbType.EditValue
        pri.AR_Date = DateEdit1.EditValue
        pri.AR_Remark = txtRemark.Text
        pri.AR_Action = InUserID

        Dim i As Integer
        If ds.Tables("DelReturn").Rows.Count > 0 Then
            For i = 0 To ds.Tables("DelReturn").Rows.Count - 1
                Dim mc2 As New ProductionReturnControl
                If Not IsDBNull(ds.Tables("DelReturn").Rows(i)("AutoID")) Then
                    mc2.ProductionReturn_Delete(ds.Tables("DelReturn").Rows(i)("AutoID"), Nothing)
                End If
            Next i
        End If

        For i = 0 To ds.Tables("Return").Rows.Count - 1
            If IsDBNull(ds.Tables("Return").Rows(i)("AutoID")) Then   '新增]
                pri.R_NO = ds.Tables("Return").Rows(i)("R_NO")
                pri.Pro_Type = ds.Tables("Return").Rows(i)("Pro_Type")
                pri.PM_M_Code = ds.Tables("Return").Rows(i)("PM_M_Code")
                pri.PM_Type = ds.Tables("Return").Rows(i)("PM_Type")
                pri.AR_Qty = CSng(ds.Tables("Return").Rows(i)("AR_Qty"))
                If IsDBNull(ds.Tables("Return").Rows(i)("AR_Detail")) Then
                    pri.AR_Detail = Nothing
                Else
                    pri.AR_Detail = ds.Tables("Return").Rows(i)("AR_Detail")
                End If
                prc.ProductionReturn_Add(pri)
            ElseIf Not IsDBNull(ds.Tables("Return").Rows(i)("AutoID")) Then   '修改
                pri.R_NO = ds.Tables("Return").Rows(i)("R_NO")
                pri.AutoID = ds.Tables("Return").Rows(i)("AutoID")
                pri.Pro_Type = ds.Tables("Return").Rows(i)("Pro_Type")
                pri.PM_M_Code = ds.Tables("Return").Rows(i)("PM_M_Code")
                pri.PM_Type = ds.Tables("Return").Rows(i)("PM_Type")
                pri.AR_Qty = CSng(ds.Tables("Return").Rows(i)("AR_Qty"))

                If IsDBNull(ds.Tables("Return").Rows(i)("AR_Detail")) Then
                    pri.AR_Detail = Nothing
                Else
                    pri.AR_Detail = ds.Tables("Return").Rows(i)("AR_Detail")
                End If
                prc.ProductionReturn_Update(pri)
            End If
        Next
        MsgBox("保存單號" & txtNO.Text & "信息成功!")
        Me.Close()
    End Sub
#End Region

#Region "審核事件方法"
    Sub UpdateCheck()
        Dim pri As New ProductionReturnInfo
        pri.AR_Check = CheckEdit1.Checked
        pri.AR_CheckAction = InUserID
        pri.AR_CheckDate = Format(Now, "yyyy/MM/dd")
        pri.AR_CheckRemark = CheckRemark.Text

        Dim i As Integer
        For i = 0 To ds.Tables("Return").Rows.Count - 1
            pri.AutoID = ds.Tables("Return").Rows(i)("AutoID")
            If prc.ProductionReturn_UpdateCheck(pri) = False Then
                GridView1.FocusedRowHandle = i
                MsgBox("記錄：" & ds.Tables("Return").Rows(i)("PM_M_Code").ToString & " / " & ds.Tables("Return").Rows(i)("PM_Type").ToString & " 審核失敗,請檢查原因!")
                GridView1.Focus()
                Exit Sub
            End If
        Next
        MsgBox("審核完成！", 64, "提示")
        '--------------------------------------------
        '------------倉庫扣數由觸發器完成------------
        '-----------ProductionReturn_UpdateQty1------
        '--------------------------------------------
        Me.Close()
    End Sub


    Sub UpdateInCheck()
        Dim pri As New ProductionReturnInfo
        pri.AR_InCheck = CheckEdit2.Checked
        pri.AR_InCheckAction = InUserID
        pri.AR_InCheckDate = Format(Now, "yyyy/MM/dd")
        pri.AR_InCheckRemark = MemoEdit1.Text

        Dim i As Integer
        For i = 0 To ds.Tables("Return").Rows.Count - 1
            pri.AutoID = ds.Tables("Return").Rows(i)("AutoID")
            If prc.ProductionReturn_UpdateInCheck(pri) = False Then
                GridView1.FocusedRowHandle = i
                MsgBox("記錄：" & ds.Tables("Return").Rows(i)("PM_M_Code").ToString & " / " & ds.Tables("Return").Rows(i)("PM_Type").ToString & " 審核失敗,請檢查原因!")
                GridView1.Focus()
                Exit Sub
            End If
        Next
        MsgBox("審核完成！", 64, "提示")
        '--------------------------------------------
        '------------倉庫扣數由觸發器完成------------
        '-----------ProductionReturn_UpdateQty1------
        '--------------------------------------------
        Me.Close()
    End Sub

#End Region

#Region "按鍵事件"
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim i, j, sum%
        Dim strM_Code1, strM_Code2 As String

        If txtWH.EditValue = "" Then
            MsgBox("送貨倉庫不能為空，請輸入送貨倉庫!", 64, "提示")
            txtWH.Focus()
            Exit Sub
        End If
        If txtWHInID.EditValue = "" Then
            MsgBox("接收倉庫不能為空，請輸入接收倉庫!", 64, "提示")
            txtWHInID.Focus()
            Exit Sub
        End If
        If cbType.EditValue = "" Then
            MsgBox("類型不能為空!", 64, "提示")
            cbType.Focus()
            Exit Sub
        End If
        If GridView1.RowCount = 0 Then
            MsgBox("請添加物料明細!", 64, "提示")
            Grid.Focus()
            Exit Sub
        End If

        For i = 0 To ds.Tables("Return").Rows.Count - 1
            If ds.Tables("Return").Rows(i)("PM_M_Code").ToString = "" Then
                MsgBox("產品編號不能為空，請輸入產品編號！", 64, "提示")
                Grid.Focus()
                Exit Sub
            End If
            If ds.Tables("Return").Rows(i)("Pro_Type").ToString = "" Then
                MsgBox("類型不能為空，請輸入類型！", 64, "提示")
                Grid.Focus()
                Exit Sub
            End If
            If CInt(ds.Tables("Return").Rows(i)("AR_Qty")) <= 0 Then
                MsgBox("送貨數量不能小於等於零，請重新輸入送貨數量！", 64, "提示")
                Grid.Focus()
                Exit Sub
            End If
            '2013-11-06
            If EditItem = "Check" And CheckEdit1.Checked = False Then
            Else
                If CInt(ds.Tables("Return").Rows(i)("AR_Qty")) > CInt(ds.Tables("Return").Rows(i)("R_NoSendQty")) Then
                    MsgBox("送貨數量不能大於未交數，請重新輸入送貨數量！", 64, "提示")
                    Grid.Focus()
                    Exit Sub
                End If
            End If

            strM_Code1 = GetM_Code(ds.Tables("Return").Rows(i)("Pro_Type"), ds.Tables("Return").Rows(i)("PM_M_Code"), ds.Tables("Return").Rows(i)("PM_Type"))

            ''先要判斷裝配------>>>生產(生產中有無建立此工藝類型)
            '--------------------------------------------------------------------------
            Dim pc1 As New ProcessMainControl
            Dim pci1 As New List(Of ProcessMainInfo)
            pci1 = pc1.ProcessMain_GetList1(Nothing, ds.Tables("Return").Rows(i)("PM_M_Code"), "生產加工", strM_Code1)

            If pci1.Count <= 0 Then
                MsgBox("沒有建立當前[生產加工]工藝" + ds.Tables("Return").Rows(i)("PM_M_Code") + ",請確認！")
            End If
            '---------------------------------------------------------------------------

            sum = CInt(ds.Tables("Return").Rows(i)("AR_Qty"))
            For j = 0 To ds.Tables("Return").Rows.Count - 1
                strM_Code2 = GetM_Code(ds.Tables("Return").Rows(j)("Pro_Type"), ds.Tables("Return").Rows(j)("PM_M_Code"), ds.Tables("Return").Rows(j)("PM_Type"))
                If i <> j Then
                    If ds.Tables("Return").Rows(i)("PM_M_Code") = ds.Tables("Return").Rows(j)("PM_M_Code") And strM_Code1 = strM_Code2 Then
                        sum = sum + CInt(ds.Tables("Return").Rows(j)("AR_Qty"))
                    End If
                End If
                '------------------------------------------------
                Dim intPI_Qty As Int32
                Dim pii1 As New List(Of ProductInventoryInfo)
                pii1 = pic.ProductInventory_GetList(ds.Tables("Return").Rows(i)("PM_M_Code"), strM_Code1, strWHOutID, Nothing)
                If pii1.Count > 0 Then
                    intPI_Qty = pii1(0).PI_Qty
                Else
                    intPI_Qty = 0
                End If

                '2013-11-06
                If EditItem = "Check" And CheckEdit1.Checked = False Then
                Else
                    If sum > intPI_Qty Then
                        MsgBox("相同物料的總數量不能大於庫存數量！", 64, "提示")
                        Exit Sub
                    End If

                End If
                '-----------------------------------------------
            Next
        Next

        Select Case EditItem
            Case "ReturnADD"
                If Edit = False Then
                    DataNew()
                Else
                    DataEdit()
                End If
            Case "Check"
                UpdateCheck()
            Case "InCheck"
                UpdateInCheck()
        End Select
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub ReturnSubAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnSubAdd.Click
        tempCode = ""
        frmProductionSelect.ShowDialog()
        '增加記錄
        If tempCode = "" Then
            Exit Sub
        Else
            AddRow(tempCode)
        End If
    End Sub

    Sub AddRow(ByVal M_Code As String) '通過工序編號導入相應信息(工藝類型,產品編號,類型,工序名稱等)
        ds.Tables("Return").Clear()
        If M_Code = "" Then
        Else
            Dim pc As New ProcessMainControl
            Dim pci As List(Of ProcessMainInfo)
            pci = pc.ProcessSub_GetList(Nothing, M_Code, Nothing, Nothing, Nothing, Nothing)
            If pci.Count = 0 Then Exit Sub
            Dim i As Integer

            For i = 0 To pci.Count - 1
                Dim row As DataRow
                row = ds.Tables("Return").NewRow

                row("R_NO") = ""     '------退貨單號
                row("Pro_Type") = pci(i).Pro_Type
                row("PM_M_Code") = pci(i).PM_M_Code
                row("PM_Type") = pci(i).PM_Type
                row("AR_Qty") = 0
                ds.Tables("Return").Rows.Add(row)
            Next
        End If
        GridView1.MoveLast()
    End Sub
    '導入輸入的退貨單詳細信息
    Private Sub LoadReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadReturn.Click
        If strWHOutID = Nothing Then
            MsgBox("請選擇發貨倉庫!")
            txtWH.Select()
            Exit Sub
        End If

        If strWHInID = Nothing Then
            MsgBox("請選擇接收倉庫!")
            txtWHInID.Select()
            Exit Sub
        End If


        tempValue = ""
        'StrINWare = tempValue2
        'StrOutWare = tempValue3
        tempValue2 = strWHOutID
        tempValue3 = strWHInID

        frmLoadRetrocede.ShowDialog()

        Dim i, n As Integer
        Dim YanZeng As Boolean    '驗証,看載入各項未交數是否為0或負數
        YanZeng = True
        If RefreshT = True Then
            Dim arr(n) As String
            arr = Split(tempValue, ",")
            n = Len(Replace(tempValue, ",", "," & "*")) - Len(tempValue)

            For i = 0 To n
                Dim prrc As New ProductionRetrocedeControl
                Dim prri As New List(Of ProductionRetrocedeInfo)

                prri = prrc.ProductionRetrocede_GetList2(Nothing, arr(i), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, True, Nothing, Nothing, Nothing)

                If prri.Count = 1 Then
                    Dim j As Integer

                    If strWHOutID <> "" And strWHOutID <> prri(0).WH_InID Then
                        MsgBox("此退貨單不屬於已選定送貨倉庫，不能補退貨！", 64, "提示")
                        Grid.Focus()
                        Exit Sub
                    End If

                    If strWHInID <> "" And strWHInID <> prri(0).WH_OutID Then
                        MsgBox("此退貨單中的接收倉庫與已選定的接收倉庫不一致！", 64, "提示")
                        Grid.Focus()
                        Exit Sub
                    End If

                    For j = 0 To ds.Tables("Return").Rows.Count - 1

                        Dim strA, strB As String

                        strA = prri(0).R_NO & prri(0).Pro_Type & prri(0).PM_M_Code & prri(0).PM_Type
                        strB = ds.Tables("Return").Rows(j)("R_NO") & ds.Tables("Return").Rows(j)("Pro_Type") & ds.Tables("Return").Rows(j)("PM_M_Code") & ds.Tables("Return").Rows(j)("PM_Type")

                        If strA = strB Then
                            MsgBox("一張單相同配件物料信息不允許存在多條記錄····")
                            Exit Sub
                        End If
                    Next

                    Dim row As DataRow
                    row = ds.Tables("Return").NewRow

                    row("R_NO") = prri(0).R_NO
                    row("Pro_Type") = "裝配出貨"
                    row("PM_M_Code") = prri(0).PM_M_Code
                    row("PM_Type") = prri(0).PM_Type
                    row("AR_Qty") = 0
                    row("R_NoSendQty") = prri(0).R_NoSendQty

                    Dim pii As New List(Of ProductInventoryInfo)
                    pii = pic.ProductInventory_GetList(prri(0).PM_M_Code, GetM_Code("裝配出貨", prri(0).PM_M_Code, prri(0).PM_Type), strWHOutID, Nothing)
                    If pii.Count > 0 Then
                        row("PI_Qty") = pii(0).PI_Qty
                    Else
                        row("PI_Qty") = 0
                    End If
                    ds.Tables("Return").Rows.Add(row)
                End If
            Next
        End If
        tempValue = ""
        RefreshT = False
    End Sub

    Private Sub ReturnSubDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnSubDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "AutoID")

        If DelTemp = "AutoID" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelReturn").NewRow
            row("AutoID") = ds.Tables("Return").Rows(GridView1.FocusedRowHandle)("AutoID")
            row("AR_NO") = txtNO.Text
            ds.Tables("DelReturn").Rows.Add(row)
        End If
        ds.Tables("Return").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub

    Private Sub txtWH_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtWH.ButtonClick
        tempCode = "生產倉庫"
        frmWareHouseSelect.SelectWareID = ""
        tempValue3 = "880906"
        tempValue2 = "880906"
        frmWareHouseSelect.StartPosition = FormStartPosition.Manual
        frmWareHouseSelect.Left = MDIMain.Left + MDIMain.tvModule.Width + Me.Left + txtWH.Left + 15
        frmWareHouseSelect.Top = MDIMain.Top + Me.Top + txtWH.Top + txtWH.Height + 143
        frmWareHouseSelect.ShowDialog()
        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            strWHOutID = frmWareHouseSelect.SelectWareID
            txtWH.Text = frmWareHouseSelect.SelectWareName
        End If
    End Sub

    Private Sub txtWHInID_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtWHInID.ButtonClick
        tempCode = "生產倉庫"
        frmWareHouseSelect.SelectWareID = ""
        tempValue3 = "880907"
        tempValue2 = "880907"
        frmWareHouseSelect.StartPosition = FormStartPosition.Manual
        frmWareHouseSelect.Left = MDIMain.Left + MDIMain.tvModule.Width + Me.Left + txtWHInID.Left + 15
        frmWareHouseSelect.Top = MDIMain.Top + Me.Top + txtWHInID.Top + txtWHInID.Height + 143
        frmWareHouseSelect.ShowDialog()

        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            strWHInID = frmWareHouseSelect.SelectWareID
            txtWHInID.Text = frmWareHouseSelect.SelectWareName
        End If
    End Sub
#End Region

#Region "控件載入事件方法"
    '---通過產品工藝信息得到對應加工的物料編碼信息 2012/8/23
    Function GetM_Code(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String) As String
        Dim pc As New ProcessMainControl
        Dim pci As List(Of ProcessMainInfo)
        pci = pc.ProcessMain_GetList(Nothing, PM_M_Code, Pro_Type, PM_Type, Nothing, Nothing)
        If pci.Count = 0 Then
            MsgBox("沒有建立當前產品工藝信息，請確認！")
            GetM_Code = Nothing
            Exit Function
        Else
            GetM_Code = pci(0).M_Code   '得到當前產品工藝信息對應的物料編碼
        End If
    End Function
    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        cmdSave.Enabled = Not cmdSave.Enabled
    End Sub

    Private Sub CheckEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit2.CheckedChanged
        cmdSave.Enabled = Not cmdSave.Enabled
    End Sub
#End Region

  

End Class