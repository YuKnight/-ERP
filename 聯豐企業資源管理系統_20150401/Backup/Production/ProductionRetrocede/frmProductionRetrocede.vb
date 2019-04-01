Imports LFERP.Library.ProductionRetrocede
Imports LFERP.Library.WareHouse.WareInventory
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.Purchase.SharePurchase
Imports LFERP.DataSetting
Imports LFERP.Library.Product
Public Class frmProductionRetrocede
#Region "屬性"
    Dim ds As New DataSet
    Dim prc As New ProductionRetrocedeControl
    Dim uc As New UserPowerControl
    Dim mpc As New ProductController
    Dim ppc As New ProcessMainControl
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

#Region "載入窗體事件"
    Private Sub frmProductionRetrocede_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()
        txtNO.Enabled = False
        cbType.Enabled = False

        Select Case EditItem
            Case "ADD"
                If Edit = False Then
                    DateEdit1.EditValue = Format(Now, "yyyy/MM/dd")
                    cbType.EditValue = "退貨"
                    Me.Text = "裝配-退貨"
                Else
                    LoadData(EditValue)
                    Me.Text = "修改--" & EditItem & "-" & EditValue
                End If
                XtraTabControl1.SelectedTabPage = XtraTabPage1
                XtraTabPage2.PageVisible = False
                XtraTabPage3.PageVisible = False
            Case "PreView"
                LoadData(EditValue)
                cmdSave.Visible = False
                Me.Text = "查看--" & EditItem & "-" & EditValue
                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Case "Check"
                LoadData(EditValue)
                Me.Text = "審核--" & EditItem & "-" & EditValue
                cmdSave.Enabled = False
                XtraTabControl1.SelectedTabPage = XtraTabPage2

                GroupBox1.Enabled = False
                GridView1.OptionsBehavior.Editable = False
                Grid.ContextMenuStrip.Enabled = False
                XtraTabPage3.PageVisible = False

            Case "InCheck"
                LoadData(EditValue)
                Me.Text = "收料審核--" & EditItem & "-" & EditValue

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
        With ds.Tables.Add("Retrocede")
            .Columns.Add("IndexNO", GetType(String))
            .Columns.Add("Pro_Type", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
            .Columns.Add("R_Qty", GetType(Integer))
            .Columns.Add("PI_Qty", GetType(Integer))
            .Columns.Add("R_Detail", GetType(String))
        End With
        Grid.DataSource = ds.Tables("Retrocede")

        With ds.Tables.Add("DelRetrocede")
            .Columns.Add("R_NO", GetType(String))
            .Columns.Add("IndexNO", GetType(String))
        End With

        ''2013-10-18產品動態增加
        With ds.Tables.Add("PM_M_Code")
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_JiYu", GetType(String))
        End With
        PM_M_CodeLook.ValueMember = "PM_M_Code"
        PM_M_CodeLook.DisplayMember = "PM_M_Code"
        PM_M_CodeLook.DataSource = ds.Tables("PM_M_Code")


    End Sub
#End Region

#Region "返回數據列表"
    Function LoadData(ByVal R_NO As String) As Boolean
        LoadData = True
        Try
            Dim pri As List(Of ProductionRetrocedeInfo)
            Dim pii As List(Of ProductInventoryInfo)
            pri = prc.ProductionRetrocede_GetList(R_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            If pri.Count = 0 Then
                LoadData = False
                Exit Function
            Else
                Dim mc As New ProcessMainControl
                PM_M_CodeLook.DisplayMember = "PM_M_Code"
                PM_M_CodeLook.ValueMember = "PM_M_Code"
                PM_M_CodeLook.DataSource = mc.ProcessMain_GetList3(Nothing, Nothing)

                Dim i As Integer
                For i = 0 To pri.Count - 1
                    txtNO.Text = pri(i).R_NO
                    txtWH.EditValue = pri(i).WH_Name
                    strWHOutID = pri(i).WH_OutID
                    txtWHInID.EditValue = pri(i).WH_InName
                    strWHInID = pri(i).WH_InID
                    cbType.EditValue = pri(i).R_Type
                    DateEdit1.EditValue = Format(pri(i).R_Date, "yyyy/MM/dd")
                    txtRemark.EditValue = pri(i).R_Remark
                    Dim row As DataRow

                    row = ds.Tables("Retrocede").NewRow
                    row("IndexNO") = pri(i).IndexNO
                    row("Pro_Type") = pri(i).Pro_Type
                    row("PM_M_Code") = pri(i).PM_M_Code
                    row("PM_Type") = pri(i).PM_Type
                    row("R_Qty") = pri(i).R_Qty
                    row("R_Detail") = pri(i).R_Detail
                    '-----------------加載庫存--------------------------
                    pii = pic.ProductInventory_GetList(pri(i).PM_M_Code, GetM_Code(pri(i).Pro_Type, pri(i).PM_M_Code, pri(i).PM_Type), strWHOutID, Nothing)
                    If pii.Count > 0 Then
                        row("PI_Qty") = pii(0).PI_Qty
                    Else
                        row("PI_Qty") = 0
                    End If
                    '----------------------------------------------------------
                    ds.Tables("Retrocede").Rows.Add(row)

                    CheckEdit1.Checked = pri(i).R_Check
                    CheckDate.Text = Format(pri(i).R_CheckDate, "yyyy/MM/dd")
                    CheckAction.Text = pri(i).CheckActionName
                    CheckRemark.EditValue = pri(i).R_CheckRemark

                    '收料
                    CheckEdit2.Checked = pri(i).R_InCheck
                    Label5.Text = Format(pri(i).R_InCheckDate, "yyyy/MM/dd")
                    Label3.Text = pri(i).R_InCheckActionName
                    MemoEdit1.EditValue = pri(i).R_InCheckRemark

                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
#End Region

#Region "自動流水號"
    Public Function GetRNO() As String '退貨單號
        Dim pri As New ProductionRetrocedeInfo
        Dim strA As String
        strA = Format(Now, "yyMM")
        pri = prc.ProductionRetrocede_GetRNO(strA)
        If pri Is Nothing Then
            GetRNO = "R" + strA + "0001"
        Else
            GetRNO = "R" + strA + Mid((CInt(Mid(pri.R_NO, 6)) + 10001), 2)
        End If
    End Function
#End Region

#Region "新增事件"
    Sub DataNew()
        Dim pri As New ProductionRetrocedeInfo

            txtNO.Text = GetRNO()
            pri.R_NO = txtNO.Text
            pri.WH_OutID = strWHOutID
            pri.WH_InID = strWHInID
            pri.R_Type = cbType.EditValue
            pri.R_Date = DateEdit1.EditValue
            pri.R_Remark = txtRemark.Text
            pri.R_Action = InUserID

            Dim i As Integer
            For i = 0 To ds.Tables("Retrocede").Rows.Count - 1
                pri.Pro_Type = ds.Tables("Retrocede").Rows(i)("Pro_Type")
                pri.PM_M_Code = ds.Tables("Retrocede").Rows(i)("PM_M_Code")
                pri.PM_Type = ds.Tables("Retrocede").Rows(i)("PM_Type")
                pri.R_Qty = CDbl(ds.Tables("Retrocede").Rows(i)("R_Qty"))
                pri.R_NoSendQty = CDbl(ds.Tables("Retrocede").Rows(i)("R_Qty"))
                If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_Detail")) Then
                    pri.R_Detail = Nothing
                Else
                    pri.R_Detail = ds.Tables("Retrocede").Rows(i)("R_Detail")
                End If
                prc.ProductionRetrocede_Add(pri)
            Next
            MsgBox("保存單號" & txtNO.Text & "信息成功!")
            Me.Close()
    End Sub
#End Region

#Region "修改事件"
    Sub DataEdit()
        Dim pri As New ProductionRetrocedeInfo
        pri.R_NO = txtNO.Text
        pri.WH_OutID = strWHOutID
        pri.WH_InID = strWHInID
        pri.R_Type = cbType.EditValue
        pri.R_Date = DateEdit1.EditValue
        pri.R_Remark = txtRemark.Text
        pri.R_Action = InUserID

        '更新刪除的記錄
        Dim i As Integer
        If ds.Tables("DelRetrocede").Rows.Count > 0 Then
            For i = 0 To ds.Tables("DelRetrocede").Rows.Count - 1
                Dim mc2 As New ProductionRetrocedeControl
                If Not IsDBNull(ds.Tables("DelRetrocede").Rows(i)("IndexNO")) Then
                    mc2.ProductionRetrocede_Delete(ds.Tables("DelRetrocede").Rows(i)("IndexNO"), Nothing)
                End If
            Next i
        End If

        For i = 0 To ds.Tables("Retrocede").Rows.Count - 1
            If IsDBNull(ds.Tables("Retrocede").Rows(i)("IndexNO")) Then   '新增
                pri.Pro_Type = ds.Tables("Retrocede").Rows(i)("Pro_Type")
                pri.PM_M_Code = ds.Tables("Retrocede").Rows(i)("PM_M_Code")
                pri.PM_Type = ds.Tables("Retrocede").Rows(i)("PM_Type")
                pri.R_Qty = CDbl(ds.Tables("Retrocede").Rows(i)("R_Qty"))
                pri.R_NoSendQty = CSng(ds.Tables("Retrocede").Rows(i)("R_Qty"))
                If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_Detail")) Then
                    pri.R_Detail = Nothing
                Else
                    pri.R_Detail = ds.Tables("Retrocede").Rows(i)("R_Detail")
                End If
                prc.ProductionRetrocede_Add(pri)
            ElseIf Not IsDBNull(ds.Tables("Retrocede").Rows(i)("IndexNO")) Then   '修改
                pri.IndexNO = ds.Tables("Retrocede").Rows(i)("IndexNO")
                pri.Pro_Type = ds.Tables("Retrocede").Rows(i)("Pro_Type")
                'MsgBox(pri.Pro_Type & "," & ds.Tables("Retrocede").Rows(i)("Pro_Type"))
                pri.PM_M_Code = ds.Tables("Retrocede").Rows(i)("PM_M_Code")
                pri.PM_Type = ds.Tables("Retrocede").Rows(i)("PM_Type")
                pri.R_Qty = CDbl(ds.Tables("Retrocede").Rows(i)("R_Qty"))
                pri.R_NoSendQty = CDbl(ds.Tables("Retrocede").Rows(i)("R_Qty"))
                If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_Detail")) Then
                    pri.R_Detail = Nothing
                Else
                    pri.R_Detail = ds.Tables("Retrocede").Rows(i)("R_Detail")
                End If
                If prc.ProductionRetrocede_Update(pri) = False Then
                    MsgBox("保存失敗!")
                    Exit Sub
                End If
            End If
        Next
        MsgBox("保存單號" & txtNO.Text & "信息成功!")
        Me.Close()
    End Sub
#End Region

#Region "審核事件"
    Sub UpdateCheck()
        Dim i As Integer
        Dim pri As New ProductionRetrocedeInfo

        For i = 0 To ds.Tables("Retrocede").Rows.Count - 1
            pri.IndexNO = ds.Tables("Retrocede").Rows(i)("IndexNO")
            pri.R_Check = CheckEdit1.Checked
            pri.R_CheckAction = InUserID
            pri.R_CheckDate = Format(Now, "yyyy/MM/dd")
            pri.R_CheckRemark = CheckRemark.Text

            If prc.ProductionRetrocede_UpdateCheck(pri) = False Then
                GridView1.FocusedRowHandle = i
                MsgBox("記錄：" & ds.Tables("Retrocede").Rows(i)("PM_M_Code") & " / " & ds.Tables("Retrocede").Rows(i)("PM_Type") & "審核失敗!")
                Exit Sub
            End If
        Next
        MsgBox("審核完成")
        '-----------扣賬處理由觸發器-----------
        '-------ProductionRetrocede_UpdateQty1
        '--------------------------------------
        Me.Close()
    End Sub


    Sub UpdateInCheck()
        Dim i As Integer
        Dim pri As New ProductionRetrocedeInfo

        For i = 0 To ds.Tables("Retrocede").Rows.Count - 1
            pri.IndexNO = ds.Tables("Retrocede").Rows(i)("IndexNO")
            pri.R_InCheck = CheckEdit2.Checked
            pri.R_InCheckAction = InUserID
            pri.R_InCheckDate = Format(Now, "yyyy/MM/dd")
            pri.R_InCheckRemark = MemoEdit1.Text

            If prc.ProductionRetrocede_UpdateInCheck(pri) = False Then
                GridView1.FocusedRowHandle = i
                MsgBox("記錄：" & ds.Tables("Retrocede").Rows(i)("PM_M_Code") & " / " & ds.Tables("Retrocede").Rows(i)("PM_Type") & "審核失敗!")
                Exit Sub
            End If
        Next
        MsgBox("收料審核完成")
        '-----------扣賬處理由觸發器-----------
        '-------ProductionRetrocede_UpdateQty1
        '--------------------------------------
        Me.Close()
    End Sub


#End Region

#Region "按鍵事件－保存確認－退出事件"
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim i, j, sum%
        Dim strM_Code1, strM_Code2 As String

        If txtWH.EditValue = "" Then
            MsgBox("退貨倉庫不能為空!", 64, "提示")
            txtWH.Focus()
            Exit Sub
        End If
        If txtWHInID.EditValue = "" Then
            MsgBox("接收倉庫不能為空!", 64, "提示")
            txtWHInID.Focus()
            Exit Sub
        End If
        If txtWH.EditValue = txtWHInID.EditValue Then
            MsgBox("退貨倉庫與接收倉庫不能是同一個倉庫!", 64, "提示")
            txtWH.Focus()
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
        For i = 0 To ds.Tables("Retrocede").Rows.Count - 1
            If ds.Tables("Retrocede").Rows(i)("PM_M_Code").ToString = "" Then
                MsgBox("產品編號不能為空，請輸入產品編號！", 64, "提示")
                Grid.Focus()
                Exit Sub
            End If
            If ds.Tables("Retrocede").Rows(i)("Pro_Type").ToString = "" Then
                MsgBox("類型不能為空，請輸入類型！", 64, "提示")
                Grid.Focus()
                Exit Sub
            End If
            If CInt(ds.Tables("Retrocede").Rows(i)("R_Qty")) <= 0 Then
                MsgBox("數量不能小於等於零，請重新輸入數量！", 64, "提示")
                Grid.Focus()
                Exit Sub
            End If
            If ds.Tables("Retrocede").Rows(i)("R_Detail").ToString = "" Then
                MsgBox("退貨原因不能為空，請輸入退貨原因！", 64, "提示")
                Grid.Focus()
                Exit Sub
            End If
            '---------------------判斷相同物料的庫存是否足夠------------------
            sum = CInt(ds.Tables("Retrocede").Rows(i)("R_Qty"))
            strM_Code1 = GetM_Code(ds.Tables("Retrocede").Rows(i)("Pro_Type"), ds.Tables("Retrocede").Rows(i)("PM_M_Code"), ds.Tables("Retrocede").Rows(i)("PM_Type"))


            ''先要判斷裝配------>>>生產(生產中有無建立此工藝類型)
            '--------------------------------------------------------------------------
            Dim pc1 As New ProcessMainControl
            Dim pci1 As New List(Of ProcessMainInfo)
            pci1 = pc1.ProcessMain_GetList1(Nothing, ds.Tables("Retrocede").Rows(i)("PM_M_Code"), "生產加工", strM_Code1)

            If pci1.Count <= 0 Then
                MsgBox("沒有建立當前[生產加工]工藝" + ds.Tables("Retrocede").Rows(i)("PM_M_Code") + ",請確認！")
            End If
            '---------------------------------------------------------------------------

            For j = 0 To ds.Tables("Retrocede").Rows.Count - 1
                If i <> j Then
                    '獲取物料編碼
                    strM_Code2 = GetM_Code(ds.Tables("Retrocede").Rows(j)("Pro_Type"), ds.Tables("Retrocede").Rows(j)("PM_M_Code"), ds.Tables("Retrocede").Rows(j)("PM_Type"))
                    If strM_Code1 = strM_Code2 And ds.Tables("Retrocede").Rows(i)("PM_M_Code") = ds.Tables("Retrocede").Rows(j)("PM_M_Code") Then
                        sum = sum + CInt(ds.Tables("Retrocede").Rows(j)("R_Qty"))     '累加相同物料數量
                    End If
                End If
                '---------------------------------------------------------------------------
                Dim intPI_Qty As Int32
                Dim pii1 As New List(Of ProductInventoryInfo)
                pii1 = pic.ProductInventory_GetList(ds.Tables("Retrocede").Rows(i)("PM_M_Code"), strM_Code1, strWHOutID, Nothing)
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

            Next
        Next

        Select Case EditItem
            Case "ADD"
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

    Private Sub ReSubAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReSubAdd.Click
        'tempCode = ""

        'frmProductionSelect.ShowDialog()
        ''增加記錄
        'If tempCode = "" Then
        '    Exit Sub
        'Else
        '    AddRow(tempCode)
        'End If
        'tempCode = ""

        If txtWH.Text = "" Then
            txtWH.Select()
            MsgBox("請先選擇退貨倉庫!")
            Exit Sub
        End If

        If txtWHInID.Text = "" Then
            txtWHInID.Select()
            MsgBox("請選擇收貨倉庫！")
            Exit Sub
        End If
        '-------------------------------------------------
        '使用新添加行記錄的模式進行退貨記錄添加送
        '-------------------------------------------------

        Dim row As DataRow
        Dim mc As New ProcessMainControl

        row = ds.Tables("Retrocede").NewRow

        row("Pro_Type") = "裝配出貨" '默認為裝配出貨
        row("PM_M_Code") = ""
        row("PM_Type") = ""
        row("R_Qty") = 0
        row("PI_Qty") = 0
        row("R_Detail") = ""

        ds.Tables("Retrocede").Rows.Add(row)


        'PM_M_CodeLook.DisplayMember = "PM_M_Code"
        'PM_M_CodeLook.ValueMember = "PM_M_Code" 
        'PM_M_CodeLook.DataSource = mc.ProcessMain_GetList3(Nothing, Nothing)

    End Sub
    Private Sub ReSubDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReSubDel.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "IndexNO")

        If DelTemp = "IndexNO" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelRetrocede").NewRow

            row("IndexNO") = ds.Tables("Retrocede").Rows(GridView1.FocusedRowHandle)("IndexNO")
            row("R_NO") = txtNO.Text

            ds.Tables("DelRetrocede").Rows.Add(row)
        End If
        ds.Tables("Retrocede").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub
    Private Sub txtWHInID_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtWHInID.ButtonClick
        tempCode = "生產倉庫"
        frmWareHouseSelect.SelectWareID = ""
        tempValue2 = "880807"
        tempValue3 = "880807"
        frmWareHouseSelect.StartPosition = FormStartPosition.Manual
        frmWareHouseSelect.Left = MDIMain.Left + MDIMain.tvModule.Width + Me.Left + txtWHInID.Left + 16
        frmWareHouseSelect.Top = MDIMain.Top + Me.Top + txtWHInID.Top + txtWHInID.Height + 143
        frmWareHouseSelect.ShowDialog()

        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            strWHInID = frmWareHouseSelect.SelectWareID
            txtWHInID.Text = frmWareHouseSelect.SelectWareName
        End If
    End Sub

    Private Sub txtWH_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtWH.ButtonClick
        tempCode = "生產倉庫"
        frmWareHouseSelect.SelectWareID = ""
        tempValue2 = "880806"
        tempValue3 = "880806"

        frmWareHouseSelect.StartPosition = FormStartPosition.Manual
        frmWareHouseSelect.Left = MDIMain.Left + MDIMain.tvModule.Width + Me.Left + txtWH.Left + 16
        frmWareHouseSelect.Top = MDIMain.Top + Me.Top + txtWH.Top + txtWH.Height + 143
        frmWareHouseSelect.ShowDialog()

        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            strWHOutID = frmWareHouseSelect.SelectWareID
            txtWH.Text = frmWareHouseSelect.SelectWareName
            '2013-10-18
            LoadPM_M_Code(strWHOutID)

        End If
    End Sub

    Sub AddRow(ByVal M_Code As String) '通過工序編號導入相應信息(工藝類型,產品編號,類型,工序名稱等)
        ds.Tables("Retrocede").Clear()
        If M_Code = "" Then
        Else
            Dim pc As New ProcessMainControl
            Dim pci As List(Of ProcessMainInfo)
            pci = pc.ProcessSub_GetList(Nothing, M_Code, Nothing, Nothing, Nothing, Nothing)
            If pci.Count = 0 Then Exit Sub
            Dim i As Integer

            For i = 0 To pci.Count - 1
                Dim row As DataRow
                row = ds.Tables("Retrocede").NewRow
                row("Pro_Type") = "裝配出貨" ''pci(i).Pro_Type
                row("PM_M_Code") = pci(i).PM_M_Code
                row("PM_Type") = pci(i).PM_Type
                row("R_Qty") = 0
                ds.Tables("Retrocede").Rows.Add(row)
            Next
        End If
        GridView1.MoveLast()

    End Sub
#End Region

#Region "控件載入方法"
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

    Private Sub PM_M_CodeLook_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PM_M_CodeLook.EditValueChanged
        ds.Tables("Retrocede").Rows(GridView1.FocusedRowHandle)("PM_Type") = ""
        ds.Tables("Retrocede").Rows(GridView1.FocusedRowHandle)("R_Qty") = 0
        ds.Tables("Retrocede").Rows(GridView1.FocusedRowHandle)("R_Detail") = ""
        GridView1.Focus()
    End Sub

    Private Sub GridView2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.Click
        On Error Resume Next
        If GridView2.RowCount > 0 Then
            GridView1.SetFocusedRowCellValue(PM_Type, GridView2.GetFocusedRowCellValue("Type3ID"))       '傳值
            GridView1.Focus()
            Dim i As Integer
            For i = 0 To ds.Tables("Retrocede").Rows.Count - 1
                If IsDBNull(ds.Tables("Retrocede").Rows(i)("PM_Type")) = False And i <> GridView1.FocusedRowHandle Then

                    If ds.Tables("Retrocede").Rows(i)("PM_M_Code") = GridView1.GetFocusedRowCellValue("PM_M_Code") And ds.Tables("Retrocede").Rows(i)("PM_Type") = GridView1.GetFocusedRowCellValue("PM_Type") Then
                        PopupContainerControl1.OwnerEdit.ClosePopup()
                        MsgBox("此產品類型已存在,不能添加相同的類型!", 64, "提示")

                        GridView1.SetFocusedRowCellValue(PM_Type, "")  '將當前行PM_Type賦值為空

                        Exit Sub
                    End If
                End If
            Next
            '------加載庫存----
            Dim pii As List(Of ProductInventoryInfo)
            pii = pic.ProductInventory_GetList(GridView1.GetFocusedRowCellValue("PM_M_Code"), GetM_Code(GridView1.GetFocusedRowCellValue("Pro_Type"), GridView1.GetFocusedRowCellValue("PM_M_Code"), GridView1.GetFocusedRowCellValue("PM_Type")), strWHOutID, Nothing)
            If pii.Count > 0 Then
                GridView1.SetFocusedRowCellValue(PI_Qty, pii(0).PI_Qty)
            Else
                GridView1.SetFocusedRowCellValue(PI_Qty, 0)
            End If
            '-------------------------
        End If
        '重新賦值

        ds.Tables("Retrocede").Rows(GridView1.FocusedRowHandle)("R_Qty") = 0
        ds.Tables("Retrocede").Rows(GridView1.FocusedRowHandle)("R_Detail") = ""
    End Sub

    Private Sub RepositoryItemPopupContainerEdit1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemPopupContainerEdit1.Enter
        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "PM_M_Code").ToString = "" Then   '產品編號為空時,類型表格也為空
            GridControl1.DataSource = Nothing
        Else
            GridControl1.DataSource = ppc.ProcessMain_GetList2(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Pro_Type").ToString, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "PM_M_Code").ToString)
        End If
    End Sub

    '設置快捷鍵
    Private Sub PM_M_CodeLook_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PM_M_CodeLook.KeyDown, RepositoryItemPopupContainerEdit1.KeyDown, RepositoryItemComboBox1.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If

    End Sub
    ''' <summary>
    ''' 按鍵事件
    ''' </summary>
    Private Sub GridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView2.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView2_Click(Nothing, Nothing)
        End If
    End Sub
    ''' <summary>
    ''' 審核確認復選框值改變時，確定按鈕才有效
    ''' </summary>
    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        cmdSave.Enabled = Not cmdSave.Enabled
    End Sub

    Private Sub CheckEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit2.CheckedChanged
        cmdSave.Enabled = Not cmdSave.Enabled
    End Sub


    Sub LoadPM_M_Code(ByVal strGluDep As String)
        Dim mi As New List(Of LFERP.Library.Production.Datasetting.ProductionDataSettingInfo)
        Dim mc As New LFERP.Library.Production.Datasetting.ProductionDataSettingControl
        mi = mc.ProductionUser_GetList(strGluDep, Nothing)

        ds.Tables("PM_M_Code").Clear()

        If mi.Count > 0 Then    '判斷是否有權限限制
            Dim row As DataRow
            Dim j As Integer
            For j = 0 To mi.Count - 1
                row = ds.Tables("PM_M_Code").NewRow
                row("PM_M_Code") = mi(j).PM_M_Code
                row("PM_JiYu") = mi(j).PM_JiYu '
                ds.Tables("PM_M_Code").Rows.Add(row)
            Next
        Else
            Dim row As DataRow
            Dim j As Integer

            Dim mpi As New List(Of ProcessMainInfo)
            Dim mpc As New ProcessMainControl
            mpi = mpc.ProcessMain_GetList3(Nothing, Nothing)

            If mpi.Count > 0 Then
                For j = 0 To mpi.Count - 1
                    row = ds.Tables("PM_M_Code").NewRow
                    row("PM_M_Code") = mpi(j).PM_M_Code
                    row("PM_JiYu") = mpi(j).PM_JiYu '
                    ds.Tables("PM_M_Code").Rows.Add(row)
                Next
            End If

        End If
    End Sub






#End Region


End Class