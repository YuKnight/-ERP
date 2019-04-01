Imports LFERP.Library.Purchase.Purchase
Imports LFERP.Library.Purchase.Acceptance
Imports LFERP.Library.Purchase.SharePurchase
Imports LFERP.Library.WareHouse
Imports LFERP.Library.Purchase.Retrocede
Imports LFERP.SystemManager


Public Class frmAcceptance
    Dim ds As New DataSet
    Dim OldCheck As Boolean
    Private Sub frmAcceptance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mtd As New LFERP.DataSetting.SuppliersControler

        gluSupplier.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")
        gluSupplier.Properties.DisplayMember = "S_SupplierName"
        gluSupplier.Properties.ValueMember = "S_Supplier"

        ButtonEdit1.Enabled = False
        ButtonEdit1.Text = "W0102"

        Label33.Text = MTypeName
        MTypeName = ""
        CreateTables()
        Select Case Label33.Text

            Case "AcceptanceAddEdit"
                '驗收單新增或修改
                txtQuoID.Enabled = False
                DateEdit2.Enabled = False
                Label6.Text = ""
                Select Case Edit
                    Case False
                        Label7.Text = InUserID
                        DateEdit1.Text = Format(Now, "Short Date")
                        Label2.Text = "1"
                        Me.Text = "驗收單--新增"
                        cmdPrintNO.Visible = False
                    Case True
                        If LoadData(tempValue2) = False Then Exit Sub
                        Label2.Text = CStr(CInt(Label2.Text) + 1)
                        txtQuoID.Text = tempValue2
                        DateEdit1.Enabled = False
                        'popAdd.Enabled = False
                        'popDel.Enabled = False
                        Me.Text = "驗收單--修改"
                End Select
                AdvBandedGridView1.Columns.Item("WQC_Status").OptionsColumn.ReadOnly = True
                AdvBandedGridView1.Columns.Item("WQC_Action").OptionsColumn.ReadOnly = True
            Case "AcceptanceCheck"
                '驗收
                If LoadData(tempValue2) = False Then Exit Sub

                XtraTabControl1.SelectedTabPageIndex = 1

                If CheckEdit1.Checked = True Then
                    OldCheck = True
                Else
                    OldCheck = False
                End If

                txtQuoID.Enabled = False
                ButtonEdit1.Enabled = False
                DateEdit2.Enabled = False
                '   Label6.Text = InUserID
                txtName.Enabled = False
                DateEdit1.Enabled = False
                CBSendType.Enabled = False
                DateEdit2.Enabled = True
                txtQuoID.Text = tempValue2
                AdvBandedGridView1.Columns.Item("A_Qty").OptionsColumn.ReadOnly = True
                AdvBandedGridView1.Columns.Item("A_Remark").OptionsColumn.ReadOnly = True
                CheckEdit1.Enabled = True
                CBA_CheckType.Enabled = True
                MemoEdit1.Enabled = True
                CheckEdit3.Enabled = False
                MemoEdit3.Enabled = False
                popAdd.Enabled = False
                popDel.Enabled = False
                Me.Text = "驗收單--驗收"
            Case "AcceptanceAccountCheck"
                '會計部審核
                If LoadData(tempValue2) = False Then Exit Sub
                XtraTabControl1.SelectedTabPageIndex = 2
                txtQuoID.Enabled = False
                ButtonEdit1.Enabled = False
                DateEdit2.Enabled = False
                '   Label3.Text = InUserID
                txtName.Enabled = False
                DateEdit1.Enabled = False
                CBSendType.Enabled = False
                DateEdit2.Enabled = False
                txtQuoID.Text = tempValue2
                AdvBandedGridView1.Columns.Item("A_Qty").OptionsColumn.ReadOnly = True
                AdvBandedGridView1.Columns.Item("A_Remark").OptionsColumn.ReadOnly = True
                Label31.Text = Format(Now, "yyyy/MM/dd")
                CheckEdit1.Enabled = False
                CBA_CheckType.Enabled = False
                MemoEdit1.Enabled = False

                CheckEdit2.Enabled = True
                CBA_AccountCheckType.Enabled = True
                If CBA_AccountCheckType.Text = "" Or IsDBNull(CBA_AccountCheckType.EditValue) Then
                    CBA_AccountCheckType.Text = CBA_AccountCheckType.Properties.Items.Item(0)
                End If
                MemoEdit2.Enabled = True


                CheckEdit3.Enabled = False
                MemoEdit3.Enabled = False
                popAdd.Enabled = False
                popDel.Enabled = False
                Me.Text = "驗收單--會計部審核"
            Case "AcceptancePayCheck"
                '如果是付款確認
                If LoadData(tempValue2) = False Then Exit Sub
                XtraTabControl1.SelectedTabPageIndex = 3

                txtQuoID.Enabled = False
                ButtonEdit1.Enabled = False
                DateEdit2.Enabled = False
                '   Label3.Text = InUserID
                txtName.Enabled = False
                DateEdit1.Enabled = False
                CBSendType.Enabled = False
                DateEdit2.Enabled = False
                txtQuoID.Text = tempValue2
                AdvBandedGridView1.Columns.Item("A_Qty").OptionsColumn.ReadOnly = True
                AdvBandedGridView1.Columns.Item("A_Remark").OptionsColumn.ReadOnly = True
                Label32.Text = Format(Now, "yyyy/MM/dd")
                CheckEdit1.Enabled = False
                CBA_CheckType.Enabled = False
                MemoEdit1.Enabled = False

                CheckEdit2.Enabled = False
                CBA_AccountCheckType.Enabled = False
                MemoEdit2.Enabled = False

                CheckEdit3.Enabled = True
                MemoEdit3.Enabled = True
                popAdd.Enabled = False
                popDel.Enabled = False
                Me.Text = "驗收單--付款確認"
            Case "AcceptanceView"
                If LoadData(tempValue2) = False Then Exit Sub
                txtQuoID.Enabled = False
                ButtonEdit1.Enabled = False
                DateEdit2.Enabled = False
                '   Label3.Text = InUserID
                txtName.Enabled = False
                DateEdit1.Enabled = False
                CBSendType.Enabled = False
                DateEdit2.Enabled = False
                txtQuoID.Text = tempValue2
                AdvBandedGridView1.Columns.Item("A_Qty").OptionsColumn.ReadOnly = True
                AdvBandedGridView1.Columns.Item("A_Remark").OptionsColumn.ReadOnly = True
                CheckEdit1.Enabled = False
                CBA_CheckType.Enabled = False
                MemoEdit1.Enabled = False

                CheckEdit2.Enabled = False
                CBA_AccountCheckType.Enabled = False
                MemoEdit2.Enabled = False

                CheckEdit3.Enabled = False
                MemoEdit3.Enabled = False
                cmdSave.Enabled = False
                popAdd.Enabled = False
                popDel.Enabled = False
                Me.Text = "驗收單--查看"
            Case "AcceptanceQCCheck"
                If LoadData(tempValue2) = False Then Exit Sub
                txtQuoID.Enabled = False
                ButtonEdit1.Enabled = False
                DateEdit2.Enabled = False
                '   Label3.Text = InUserID
                txtName.Enabled = False
                DateEdit1.Enabled = False
                CBSendType.Enabled = False
                DateEdit2.Enabled = False
                txtQuoID.Text = tempValue2
                AdvBandedGridView1.Columns.Item("A_Qty").OptionsColumn.ReadOnly = True
                AdvBandedGridView1.Columns.Item("A_Remark").OptionsColumn.ReadOnly = True
                CheckEdit1.Enabled = False
                CBA_CheckType.Enabled = False
                MemoEdit1.Enabled = False

                CheckEdit2.Enabled = False
                CBA_AccountCheckType.Enabled = False
                MemoEdit2.Enabled = False

                CheckEdit3.Enabled = False
                MemoEdit3.Enabled = False
                cmdSave.Enabled = True
                popAdd.Enabled = False
                popDel.Enabled = False
                cmdBarCode.Visible = False
                Me.Text = "抽檢狀態"
        End Select

    End Sub


   


    Private Sub ButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        frmWareHouseSelect.ShowDialog()
        ButtonEdit1.Text = frmWareHouseSelect.SelectWareID



    End Sub



    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub

    Private Sub cmdBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBarCode.Click

        '
        ' PrintBar() 加聯豐編號
        'Dim i, m As Integer
        'For i = 0 To ds.Tables("Acceptance").Rows.Count - 1
        '    Dim str1, str2, str3, str4, str5, str6, str7 As String

        '    str1 = ds.Tables("Acceptance").Rows(i)("M_Code")
        '    str2 = ds.Tables("Acceptance").Rows(i)("M_Name")
        '    str3 = ds.Tables("Acceptance").Rows(i)("PM_M_Code")
        '    str4 = ds.Tables("Acceptance").Rows(i)("M_Unit")
        '    str5 = ds.Tables("Acceptance").Rows(i)("A_Qty")
        '    str6 = Format(DateEdit1.DateTime, "Short Date")
        '    str7 = ds.Tables("Acceptance").Rows(i)("OS_BatchID")

        '    Dim whc As New WareHouseController
        '    Dim whiL As New List(Of WareHouseInfo)
        '    whiL = whc.WareHouse_GetList(Nothing)
        '    For m = 0 To whiL.Count - 1
        '        If whiL.Item(m).WH_ID = ButtonEdit1.Text Then
        '            If whiL.Item(m).PrintBulk = "大" Then
        '                PrintBar(str1, str2, str3, str4, str5, str6, str7)
        '            End If

        '            If whiL.Item(m).PrintBulk = "小" Then
        '                PrintBar2(str1, str2)
        '            End If
        '            Exit For
        '        End If
        '    Next
        'Next



     
        tempValue3 = "驗收作業"
        tempValue4 = tempValue2
        Dim myfrm As New frmBarCode
        myfrm.ShowDialog()
     
    End Sub

    Sub CreateTables()
        '建立驗收表  Acceptance
        ds.Tables.Clear()
        With ds.Tables.Add("Acceptance")
            .Columns.Add("DepotNO", GetType(String))
            .Columns.Add("PM_NO", GetType(String))
            .Columns.Add("A_AcceptanceNO", GetType(String))
            .Columns.Add("A_NO", GetType(String))
            .Columns.Add("A_SendNO", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("OS_BatchID", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("DPT_ID", GetType(String))
            .Columns.Add("U_ID", GetType(String))
            .Columns.Add("A_Ver", GetType(String))
            .Columns.Add("A_Qty", GetType(String))
            '      .Columns.Add("A_Qty2", GetType(String))
            .Columns.Add("A_SendDate", GetType(String))
            .Columns.Add("A_SendType", GetType(String))
            .Columns.Add("S_Supplier", GetType(String))
            .Columns.Add("A_Action", GetType(String))
            .Columns.Add("A_Remark", GetType(String))
            .Columns.Add("A_Detail", GetType(String))
            .Columns.Add("A_UpdateDate", GetType(String))
            .Columns.Add("A_Check", GetType(Boolean))
            .Columns.Add("A_CheckAction", GetType(String))
            .Columns.Add("A_CheckDate", GetType(String))
            .Columns.Add("A_CheckType", GetType(String))
            .Columns.Add("A_CheckRemark", GetType(String))
            .Columns.Add("A_AccountCheck", GetType(Boolean))
            .Columns.Add("A_AccountCheckAction", GetType(String))
            .Columns.Add("A_AccountCheckDate", GetType(String))
            .Columns.Add("A_AccountCheckType", GetType(String))
            .Columns.Add("A_AccountCheckRemark", GetType(String))
            .Columns.Add("S_SupplierNO", GetType(String))
            .Columns.Add("PN_NO", GetType(String))
            .Columns.Add("A_ToFrom", GetType(String))

            .Columns.Add("WQC_Status", GetType(String))
            .Columns.Add("WQC_Action", GetType(String))
            ' .Columns.Add("S_SupplierName", GetType(String))
        End With


        '創建刪除數據表
        With ds.Tables.Add("DelDataAcceptance")
            .Columns.Add("A_NO", GetType(String))
        End With

        Grid.DataSource = ds.Tables("Acceptance")

     
    End Sub

    Private Sub popAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popAdd.Click
        Dim i, n As Integer
        Dim YanZeng As Boolean    '驗証,看載入各項未交數是否為0或負數

        Dim myfrm As New FrmAcceptanceSelect
        myfrm.ShowDialog()

        YanZeng = True
        If RefreshT = True Then
            Dim arr(n) As String
            arr = Split(tempValue, ",")
            n = Len(Replace(tempValue, ",", "," & "*")) - Len(tempValue)


            For i = 0 To n


                Dim pst As New PurchaseMainController
                Dim psi As New PurchaseMainInfo
                Dim psc As New PurchaseMainController
                Dim psci As New PurchaseMainInfo
                psi = pst.PurchaseSub_Get(arr(i))

                Dim row As DataRow = ds.Tables("Acceptance").NewRow
                row("PM_NO") = psi.PM_NO
                row("M_Code") = psi.M_Code
                row("M_Unit") = psi.M_Unit
                row("M_Name") = psi.M_Name
                row("M_Gauge") = psi.M_Gauge
                row("OS_BatchID") = psi.OS_BatchID
                row("PM_M_Code") = psi.PM_M_Code
                row("DPT_ID") = psi.DPT_ID
                row("U_ID") = psi.U_ID
                row("S_SupplierNO") = psi.S_SupplierNo
                row("A_Qty") = psi.PS_NoSendQty
                If psi.PS_NoSendQty <= 0 Then YanZeng = False
                '      row("A_Qty2") = psi.PS_NoSendQty
                row("PN_NO") = psi.PN_NO

                psci = psc.PurchaseMain_Get(psi.PM_NO)
                row("A_ToFrom") = psci.PM_ToFrom
                '      Label1.Text = psi.PM_ToFrom
                row("WQC_Status") = "不需Q"
                row("WQC_Action") = Nothing

                Dim strSupplier As String
                strSupplier = gluSupplier.EditValue
                Dim psi2 As New PurchaseMainInfo
                psi2 = pst.PurchaseMain_Get(psi.PM_NO)
                gluSupplier.EditValue = psi2.S_Supplier

                If strSupplier = "" Then
                    ds.Tables("Acceptance").Rows.Add(row)
                    AdvBandedGridView1.MoveLast()
                End If

                If strSupplier <> "" Then
                    If strSupplier.Equals(gluSupplier.EditValue) = True Then
                        ds.Tables("Acceptance").Rows.Add(row)
                        AdvBandedGridView1.MoveLast()
                    Else
                        gluSupplier.EditValue = pst.PurchaseMain_Get(ds.Tables("Acceptance").Rows(0)("PM_NO")).S_Supplier
                        MsgBox("同一驗收單號中供應商必須相同！", , "警告")
                        Exit Sub
                    End If
                End If

                'ds.Tables("Acceptance").Rows.Add(row)
                'AdvBandedGridView1.MoveLast()


            Next

        End If

        tempValue = ""
        RefreshT = False
        If YanZeng = False Then
            MsgBox("某物料未交數已經為0或負數,無法再驗收!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case Label33.Text
            Case "AcceptanceAddEdit"
                '驗收單新增修改

                If CBSendType.Text = "" Or ButtonEdit1.Text = "" Or DateEdit1.Text = "" Then
                    MsgBox("請填寫送貨類型,暫收日期及收貨倉庫")
                    Exit Sub
                End If

                If ds.Tables("Acceptance").Rows.Count = 0 Then
                    MsgBox("沒有數據,無法保存!")
                    Exit Sub
                End If
                Select Case Edit
                    Case False
                        SaveNew()
                    Case True
                        SaveEdit()
                End Select
            Case "AcceptanceCheck"
                If DateEdit2.Text = "" Then
                    MsgBox("請填寫驗收日期", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                    Exit Sub
                End If

                If OldCheck = False Then
                    If CheckEdit1.Checked = False Then
                        MsgBox("請先更改驗收狀態,才能保存!", MsgBoxStyle.OkOnly)
                        Exit Sub
                    End If

                End If

                If OldCheck = True Then
                    If CheckEdit1.Checked = True Then
                        MsgBox("請先更改驗收狀態,才能保存!", MsgBoxStyle.OkOnly)
                        Exit Sub
                    End If
                End If
                SaveCheck()
            Case "AcceptanceAccountCheck"
                SaveAccountCheck()
            Case "AcceptancePayCheck"
                SavePayCheck()
            Case "AcceptanceQCCheck"
                UpdateQCCheck()
        End Select
        'If MTypeName = "AcceptanceAddEdit" Then
        '    '驗收單新增修改

        '    If CBSendType.Text = "" Or ButtonEdit1.Text = "" Or DateEdit1.Text = "" Then
        '        MsgBox("請填寫送貨類型,暫收日期及收貨倉庫")
        '        Exit Sub
        '    End If

        '    If ds.Tables("Acceptance").Rows.Count = 0 Then
        '        MsgBox("沒有數據,無法保存!")
        '        Exit Sub
        '    End If


        '    'If CBSendType.Text = "正批送貨" Then
        '    '    Dim i As Integer
        '    '    For i = 0 To ds.Tables("Acceptance").Rows.Count - 1
        '    '        If CInt(ds.Tables("Acceptance").Rows("A_Qty").ToString) > CInt(ds.Tables("Acceptance").Rows("A_Qty2").ToString) Then
        '    '            MsgBox("超過採購單未交數,無法保存,請檢查!")
        '    '            Exit Sub
        '    '        End If
        '    '    Next
        '    ' End If
        '    Select Case Edit
        '        Case False
        '            SaveNew()
        '        Case True
        '            SaveEdit()
        '    End Select
        'End If



        'If MTypeName = "AcceptanceCheck" Then
        '    '驗收時
        '    If DateEdit2.Text = "" Then
        '        MsgBox("請填寫驗收日期", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        '        Exit Sub
        '    End If

        '    If OldCheck = False Then
        '        If CheckEdit1.Checked = False Then
        '            MsgBox("請先更改驗收狀態,才能保存!", MsgBoxStyle.OkOnly)
        '            Exit Sub
        '        End If

        '    End If

        '    If OldCheck = True Then
        '        If CheckEdit1.Checked = True Then
        '            MsgBox("請先更改驗收狀態,才能保存!", MsgBoxStyle.OkOnly)
        '            Exit Sub
        '        End If
        '    End If
        '    SaveCheck()
        'End If



        'If MTypeName = "AcceptanceAccountCheck" Then
        '    '會計部審核時
        '    'If DateEdit3.Text = "" Then
        '    '    MsgBox("請填寫審核日期", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        '    '    Exit Sub
        '    'End If
        '    'If CheckEdit1.Checked = False Then
        '    '    MsgBox("必須先驗收, 會計部才能審核！", MsgBoxStyle.OkOnly)
        '    '    Exit Sub
        '    'End If

        '    SaveAccountCheck()
        'End If

        'If MTypeName = "AcceptancePayCheck" Then
        '    '付款確認
        '    'If DateEdit4.Text = "" Then
        '    '    MsgBox("請填寫付款日期", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        '    '    Exit Sub
        '    'End If
        '    'If CheckEdit2.Checked = False Then
        '    '    MsgBox("必須會計部審核後才能做付款確認!", MsgBoxStyle.OkOnly)
        '    '    Exit Sub
        '    'End If
        '    SavePayCheck()
        'End If
    End Sub

    Sub SaveNew()
        Dim i As Integer
        Dim A_AcceptanceNo As String
        A_AcceptanceNo = GetAcceptanceNO()

        For i = 0 To ds.Tables("Acceptance").Rows.Count - 1
            Dim ac As New AcceptanceController
            Dim ai As New AcceptanceInfo
            ai.DepotNO = ButtonEdit1.Text
            ai.PM_NO = ds.Tables("Acceptance").Rows(i)("PM_NO")
            ai.A_AcceptanceNO = A_AcceptanceNo

            If txtName.Text = "" Then
                ai.A_SendNO = Nothing
            Else
                ai.A_SendNO = txtName.Text
            End If

            ai.M_Code = ds.Tables("Acceptance").Rows(i)("M_Code")


            If IsDBNull(ds.Tables("Acceptance").Rows(i)("M_Unit")) Then
                ai.M_Unit = Nothing
            Else
                ai.M_Unit = ds.Tables("Acceptance").Rows(i)("M_Unit")
            End If

            ai.M_Name = ds.Tables("Acceptance").Rows(i)("M_Name")

            If IsDBNull(ds.Tables("Acceptance").Rows(i)("M_Gauge")) Then
                ai.M_Gauge = Nothing
            Else
                ai.M_Gauge = ds.Tables("Acceptance").Rows(i)("M_Gauge")
            End If



            If IsDBNull(ds.Tables("Acceptance").Rows(i)("OS_BatchID")) Then
                ai.OS_BatchID = Nothing
            Else
                ai.OS_BatchID = ds.Tables("Acceptance").Rows(i)("OS_BatchID")
            End If



            If IsDBNull(ds.Tables("Acceptance").Rows(i)("PM_M_Code")) Then
                ai.PM_M_Code = Nothing
            Else
                ai.PM_M_Code = ds.Tables("Acceptance").Rows(i)("PM_M_Code")
            End If


            If IsDBNull(ds.Tables("Acceptance").Rows(i)("DPT_ID")) Then
                ai.DPT_ID = Nothing
            Else
                ai.DPT_ID = ds.Tables("Acceptance").Rows(i)("DPT_ID")
            End If



            If IsDBNull(ds.Tables("Acceptance").Rows(i)("U_ID")) Then
                ai.U_ID = Nothing
            Else
                ai.U_ID = ds.Tables("Acceptance").Rows(i)("U_ID")
            End If


            ai.A_Ver = Label2.Text

            If IsDBNull(ds.Tables("Acceptance").Rows(i)("A_Qty")) Then
                ai.A_Qty = "0"
            Else
                ai.A_Qty = ds.Tables("Acceptance").Rows(i)("A_Qty")
            End If


            ai.A_SendDate = DateEdit1.Text
            ai.A_SendType = CBSendType.Text
            ai.S_Supplier = gluSupplier.EditValue
            ai.A_Action = Label7.Text

            If IsDBNull(ds.Tables("Acceptance").Rows(i)("A_Remark")) Then
                ai.A_Remark = Nothing
            Else
                ai.A_Remark = ds.Tables("Acceptance").Rows(i)("A_Remark")
            End If

            If IsDBNull(ds.Tables("Acceptance").Rows(i)("S_SupplierNO")) Then
                ai.S_SupplierNO = Nothing
            Else
                ai.S_SupplierNO = ds.Tables("Acceptance").Rows(i)("S_SupplierNO")
            End If


            If IsDBNull(ds.Tables("Acceptance").Rows(i)("PN_NO")) Then
                ai.PN_NO = Nothing
            Else
                ai.PN_NO = ds.Tables("Acceptance").Rows(i)("PN_NO")
            End If

            If IsDBNull(ds.Tables("Acceptance").Rows(i)("A_ToFrom")) Then
                ai.A_ToFrom = Nothing
            Else
                ai.A_ToFrom = ds.Tables("Acceptance").Rows(i)("A_ToFrom")
            End If
            ai.A_UpdateDate = Format(Now, "yyyy/MM/dd")
            If IsDBNull(ds.Tables("Acceptance").Rows(i)("WQC_Status")) Then
                ai.WQC_Status = Nothing
            Else
                ai.WQC_Status = ds.Tables("Acceptance").Rows(i)("WQC_Status")
            End If
            If IsDBNull(ds.Tables("Acceptance").Rows(i)("WQC_Action")) Then
                ai.WQC_Action = Nothing
            Else
                ai.WQC_Action = ds.Tables("Acceptance").Rows(i)("WQC_Action")
            End If

            ac.Acceptance_Add(ai)
        Next
        MsgBox("已保存,單號: " & A_AcceptanceNo & " ")
        Me.Close()

    End Sub


    Sub SaveEdit()


        '更新刪除的記錄
        If ds.Tables("DelDataAcceptance").Rows.Count > 0 Then
            Dim j As Integer
            For j = 0 To ds.Tables("DelDataAcceptance").Rows.Count - 1
                Dim odc As New AcceptanceController

                If Not IsDBNull(ds.Tables("DelDataAcceptance").Rows(j)("A_NO")) Then
                    odc.Acceptance_ANO_Delete(ds.Tables("DelDataAcceptance").Rows(j)("A_NO"))
                End If

            Next j
        End If

        Dim i As Integer

        For i = 0 To ds.Tables("Acceptance").Rows.Count - 1
            If Not IsDBNull(ds.Tables("Acceptance").Rows(i)("A_NO")) Then
                '如果隻是修改
                Dim ac As New AcceptanceController
                Dim ai As New AcceptanceInfo
                ai.DepotNO = ButtonEdit1.Text
                ai.PM_NO = ds.Tables("Acceptance").Rows(i)("PM_NO")

                ai.A_NO = ds.Tables("Acceptance").Rows(i)("A_NO")

                If txtName.Text = "" Then
                    ai.A_SendNO = Nothing
                Else
                    ai.A_SendNO = txtName.Text
                End If

                ai.M_Code = ds.Tables("Acceptance").Rows(i)("M_Code")


                If IsDBNull(ds.Tables("Acceptance").Rows(i)("M_Unit")) Then
                    ai.M_Unit = Nothing
                Else
                    ai.M_Unit = ds.Tables("Acceptance").Rows(i)("M_Unit")
                End If

                ai.M_Name = ds.Tables("Acceptance").Rows(i)("M_Name")

                If IsDBNull(ds.Tables("Acceptance").Rows(i)("M_Gauge")) Then
                    ai.M_Gauge = Nothing
                Else
                    ai.M_Gauge = ds.Tables("Acceptance").Rows(i)("M_Gauge")
                End If



                If IsDBNull(ds.Tables("Acceptance").Rows(i)("OS_BatchID")) Then
                    ai.OS_BatchID = Nothing
                Else
                    ai.OS_BatchID = ds.Tables("Acceptance").Rows(i)("OS_BatchID")
                End If



                If IsDBNull(ds.Tables("Acceptance").Rows(i)("PM_M_Code")) Then
                    ai.PM_M_Code = Nothing
                Else
                    ai.PM_M_Code = ds.Tables("Acceptance").Rows(i)("PM_M_Code")
                End If


                If IsDBNull(ds.Tables("Acceptance").Rows(i)("DPT_ID")) Then
                    ai.DPT_ID = Nothing
                Else
                    ai.DPT_ID = ds.Tables("Acceptance").Rows(i)("DPT_ID")
                End If



                If IsDBNull(ds.Tables("Acceptance").Rows(i)("U_ID")) Then
                    ai.U_ID = Nothing
                Else
                    ai.U_ID = ds.Tables("Acceptance").Rows(i)("U_ID")
                End If


                ai.A_Ver = Label2.Text

                If IsDBNull(ds.Tables("Acceptance").Rows(i)("A_Qty")) Then
                    ai.A_Qty = "0"
                Else
                    ai.A_Qty = ds.Tables("Acceptance").Rows(i)("A_Qty")
                End If


                ai.A_SendDate = DateEdit1.Text
                ai.A_SendType = CBSendType.Text
                ai.S_Supplier = gluSupplier.EditValue
                ai.A_Action = InUserID

                If IsDBNull(ds.Tables("Acceptance").Rows(i)("A_Remark")) Then
                    ai.A_Remark = Nothing
                Else
                    ai.A_Remark = ds.Tables("Acceptance").Rows(i)("A_Remark")
                End If


                If IsDBNull(ds.Tables("Acceptance").Rows(i)("S_SupplierNO")) Then
                    ai.S_SupplierNO = Nothing
                Else
                    ai.S_SupplierNO = ds.Tables("Acceptance").Rows(i)("S_SupplierNO")
                End If


                If IsDBNull(ds.Tables("Acceptance").Rows(i)("PN_NO")) Then
                    ai.PN_NO = Nothing
                Else
                    ai.PN_NO = ds.Tables("Acceptance").Rows(i)("PN_NO")
                End If

                ai.A_UpdateDate = Format(Now, "yyyy/MM/dd")

                ac.Acceptance_Update(ai)
            End If


            If IsDBNull(ds.Tables("Acceptance").Rows(i)("A_NO")) Then
                '如果是新增加
                Dim ac As New AcceptanceController
                Dim ai As New AcceptanceInfo
                ai.DepotNO = ButtonEdit1.Text
                ai.PM_NO = ds.Tables("Acceptance").Rows(i)("PM_NO")
                ai.A_AcceptanceNO = txtQuoID.Text

                If txtName.Text = "" Then
                    ai.A_SendNO = Nothing
                Else
                    ai.A_SendNO = txtName.Text
                End If

                ai.M_Code = ds.Tables("Acceptance").Rows(i)("M_Code")


                If IsDBNull(ds.Tables("Acceptance").Rows(i)("M_Unit")) Then
                    ai.M_Unit = Nothing
                Else
                    ai.M_Unit = ds.Tables("Acceptance").Rows(i)("M_Unit")
                End If

                ai.M_Name = ds.Tables("Acceptance").Rows(i)("M_Name")

                If IsDBNull(ds.Tables("Acceptance").Rows(i)("M_Gauge")) Then
                    ai.M_Gauge = Nothing
                Else
                    ai.M_Gauge = ds.Tables("Acceptance").Rows(i)("M_Gauge")
                End If



                If IsDBNull(ds.Tables("Acceptance").Rows(i)("OS_BatchID")) Then
                    ai.OS_BatchID = Nothing
                Else
                    ai.OS_BatchID = ds.Tables("Acceptance").Rows(i)("OS_BatchID")
                End If



                If IsDBNull(ds.Tables("Acceptance").Rows(i)("PM_M_Code")) Then
                    ai.PM_M_Code = Nothing
                Else
                    ai.PM_M_Code = ds.Tables("Acceptance").Rows(i)("PM_M_Code")
                End If


                If IsDBNull(ds.Tables("Acceptance").Rows(i)("DPT_ID")) Then
                    ai.DPT_ID = Nothing
                Else
                    ai.DPT_ID = ds.Tables("Acceptance").Rows(i)("DPT_ID")
                End If



                If IsDBNull(ds.Tables("Acceptance").Rows(i)("U_ID")) Then
                    ai.U_ID = Nothing
                Else
                    ai.U_ID = ds.Tables("Acceptance").Rows(i)("U_ID")
                End If


                ai.A_Ver = Label2.Text

                If IsDBNull(ds.Tables("Acceptance").Rows(i)("A_Qty")) Then
                    ai.A_Qty = "0"
                Else
                    ai.A_Qty = ds.Tables("Acceptance").Rows(i)("A_Qty")
                End If


                ai.A_SendDate = DateEdit1.Text
                ai.A_SendType = CBSendType.Text
                ai.S_Supplier = gluSupplier.EditValue
                ai.A_Action = InUserID

                If IsDBNull(ds.Tables("Acceptance").Rows(i)("A_Remark")) Then
                    ai.A_Remark = Nothing
                Else
                    ai.A_Remark = ds.Tables("Acceptance").Rows(i)("A_Remark")
                End If


                If IsDBNull(ds.Tables("Acceptance").Rows(i)("S_SupplierNO")) Then
                    ai.S_SupplierNO = Nothing
                Else
                    ai.S_SupplierNO = ds.Tables("Acceptance").Rows(i)("S_SupplierNO")
                End If


                If IsDBNull(ds.Tables("Acceptance").Rows(i)("PN_NO")) Then
                    ai.PN_NO = Nothing
                Else
                    ai.PN_NO = ds.Tables("Acceptance").Rows(i)("PN_NO")
                End If

                If IsDBNull(ds.Tables("Acceptance").Rows(i)("A_ToFrom")) Then
                    ai.A_ToFrom = Nothing
                Else
                    ai.A_ToFrom = ds.Tables("Acceptance").Rows(i)("A_ToFrom")
                End If
                ai.A_UpdateDate = Format(Now, "yyyy/MM/dd")
                If IsDBNull(ds.Tables("Acceptance").Rows(i)("WQC_Status")) Then
                    ai.WQC_Status = Nothing
                Else
                    ai.WQC_Status = ds.Tables("Acceptance").Rows(i)("WQC_Status")
                End If
                If IsDBNull(ds.Tables("Acceptance").Rows(i)("WQC_Action")) Then
                    ai.WQC_Action = Nothing
                Else
                    ai.WQC_Action = ds.Tables("Acceptance").Rows(i)("WQC_Action")
                End If

                ac.Acceptance_Add(ai)
            End If
        Next


        MsgBox("已修改！")
        Me.Close()

    End Sub

    Sub SaveCheck()
        '原代碼 2010-04-02修改前
        '審核保存

        '    Dim i As Integer


        '    For i = 0 To ds.Tables("Acceptance").Rows.Count - 1
        '        Dim ac As New AcceptanceController
        '        Dim ai As New AcceptanceInfo

        '        Dim spc As New SharePurchaseController
        '        Dim spi As New SharePurchaseInfo

        '        ai.A_NO = ds.Tables("Acceptance").Rows(i)("A_NO")
        '        ai.A_Check = CheckEdit1.Checked
        '        ai.A_CheckType = CBA_CheckType.Text
        '        ai.A_CheckDate = DateEdit2.Text
        '        ai.A_CheckAction = InUserID
        '        ai.A_CheckRemark = MemoEdit1.Text

        '        If CheckEdit1.Checked = False Then
        '            ai.A_Detail = "暫收"
        '            spi.WI_Qty = "-" & ds.Tables("Acceptance").Rows(i)("A_Qty")
        '        Else
        '            ai.A_Detail = "驗收"
        '            spi.WI_Qty = ds.Tables("Acceptance").Rows(i)("A_Qty")
        '        End If



        '        ac.Acceptance_UpdateCheck(ai)

        '        spi.PM_NO = ds.Tables("Acceptance").Rows(i)("PM_NO")
        '        spi.M_Code = ds.Tables("Acceptance").Rows(i)("M_Code")
        '        spc.UpdatePurchase_NoSenQty(spi)
        '        spi.WH_ID = ButtonEdit1.Text
        '        spc.UpdateWareInventory_WIQty(spi)

        '    Next
        '    MsgBox("驗收狀態已改變,單號: " & txtQuoID.Text & " ")
        '    Me.Close()

        'End Sub

        'Sub SaveAccountCheck()
        '    '會計部審核保存
        '    Dim i As Integer


        '    For i = 0 To ds.Tables("Acceptance").Rows.Count - 1
        '        Dim ac As New AcceptanceController
        '        Dim ai As New AcceptanceInfo
        '        ai.A_NO = ds.Tables("Acceptance").Rows(i)("A_NO")
        '        ai.A_AccountCheck = CheckEdit2.Checked
        '        ai.A_AccountCheckType = CBA_AccountCheckType.Text
        '        ai.A_AccountCheckDate = DateEdit3.Text
        '        ai.A_AccountCheckAction = InUserID
        '        ai.A_AccountCheckRemark = MemoEdit2.Text


        '        ac.Acceptance_UpdateAccountCheck(ai)
        '    Next
        '    MsgBox("會計部審核狀態已改變,單號: " & txtQuoID.Text & " ")
        '    Me.Close()




        Dim i, m As Integer


        For i = 0 To ds.Tables("Acceptance").Rows.Count - 1
            Dim ac As New AcceptanceController
            Dim ai As New AcceptanceInfo

            'Dim spc As New SharePurchaseController
            'Dim spi As New SharePurchaseInfo

            ai.A_NO = ds.Tables("Acceptance").Rows(i)("A_NO")
            ai.A_Check = CheckEdit1.Checked
            ai.A_CheckType = CBA_CheckType.Text
            ai.A_CheckDate = DateEdit2.Text
            ai.A_CheckAction = InUserID
            ai.A_CheckRemark = MemoEdit1.Text

            If CheckEdit1.Checked = False Then
                ai.A_Detail = "暫收"
                '   spi.WI_Qty = "-" & ds.Tables("Acceptance").Rows(i)("A_Qty")
            Else
                ai.A_Detail = "驗收"
                '  spi.WI_Qty = ds.Tables("Acceptance").Rows(i)("A_Qty")
            End If



            ac.Acceptance_UpdateCheck(ai)

            'spi.PM_NO = ds.Tables("Acceptance").Rows(i)("PM_NO")
            'spi.M_Code = ds.Tables("Acceptance").Rows(i)("M_Code")
            'spc.UpdatePurchase_NoSenQty(spi)
            'spi.WH_ID = ButtonEdit1.Text
            'spc.UpdateWareInventory_WIQty(spi)

        Next

        For m = 0 To ds.Tables("Acceptance").Rows.Count - 1
            Dim spc As New SharePurchaseController
            Dim spi As New SharePurchaseInfo

            spi.PM_NO = ds.Tables("Acceptance").Rows(m)("PM_NO")
            spi.M_Code = ds.Tables("Acceptance").Rows(m)("M_Code")
            spi.WH_ID = ButtonEdit1.Text

            Dim Qty As Single
            Dim wi As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
            Dim wc As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
            wi = wc.WareInventory_GetSub(ds.Tables("Acceptance").Rows(m)("M_Code"), ButtonEdit1.EditValue)

            If wi Is Nothing Then
                Qty = 0
            Else
                Qty = wi.WI_Qty
            End If

            If CheckEdit1.Checked = False Then
                'spi.WI_Qty = "-" & ds.Tables("Acceptance").Rows(m)("A_Qty")
                spi.WI_Qty = Qty - CSng(ds.Tables("Acceptance").Rows(m)("A_Qty"))
            Else
                'spi.WI_Qty = ds.Tables("Acceptance").Rows(m)("A_Qty")
                spi.WI_Qty = Qty + CSng(ds.Tables("Acceptance").Rows(m)("A_Qty"))
            End If

         
            spc.UpdatePurchase_NoSenQty(spi)

            'spc.UpdateWareInventory_WIQty(spi)   '倉庫庫存數量

            spc.UpdateWareInventory_WIQty2(spi)   '當前實時數量

        Next
        MsgBox("驗收狀態已改變,單號: " & txtQuoID.Text & " ")
        Me.Close()

    End Sub

    Sub SaveAccountCheck()
        '會計部審核保存
        Dim i As Integer


        For i = 0 To ds.Tables("Acceptance").Rows.Count - 1
            Dim ac As New AcceptanceController
            Dim ai As New AcceptanceInfo
            ai.A_NO = ds.Tables("Acceptance").Rows(i)("A_NO")
            ai.A_AccountCheck = CheckEdit2.Checked
            ai.A_AccountCheckType = CBA_AccountCheckType.Text
            ai.A_AccountCheckDate = Label31.Text
            ai.A_AccountCheckAction = InUserID
            ai.A_AccountCheckRemark = MemoEdit2.Text


            ac.Acceptance_UpdateAccountCheck(ai)
        Next
        MsgBox("會計部審核狀態已改變,單號: " & txtQuoID.Text & " ")
        Me.Close()
    End Sub

    Sub SavePayCheck()
        '付款確認保存
        Dim i As Integer


        For i = 0 To ds.Tables("Acceptance").Rows.Count - 1
            Dim ac As New AcceptanceController
            Dim ai As New AcceptanceInfo
            ai.A_NO = ds.Tables("Acceptance").Rows(i)("A_NO")
            ai.A_PayCheck = CheckEdit3.Checked
            ai.A_PayCheckDate = Label32.Text
            ai.A_PayCheckAction = InUserID
            ai.A_PayCheckRemark = MemoEdit3.Text

            Dim rc As New RetrocedeController
            Dim riList As New List(Of RetrocedeInfo)
            'Dim strA As String
            'strA = ds.Tables("Acceptance").Rows(i)("A_AcceptanceNO").ToString
            riList = rc.Retrocede_GetList(Nothing, txtQuoID.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If riList.Count > 0 Then
                '如果有退貨記錄的情況下
              
                ai.A_Detail = "退貨未處理"
                If i = ds.Tables("Acceptance").Rows.Count - 1 Then MsgBox("'狀態' 將自動調整為'退貨未處理'", MsgBoxStyle.OkOnly)

            End If
            '如果沒有退貨記錄的情況下
            If riList.Count = 0 Then
                If CheckEdit3.Checked = False Then
                    ai.A_Detail = "驗收"
                    If i = ds.Tables("Acceptance").Rows.Count - 1 Then MsgBox("'狀態' 將自動調整為'驗收'", MsgBoxStyle.OkOnly)
                End If

                If CheckEdit3.Checked = True Then
                    ai.A_Detail = "已結單"
                    If i = ds.Tables("Acceptance").Rows.Count - 1 Then MsgBox("'狀態' 將自動調整為'已結單',刷新後此記錄將不再顯示", MsgBoxStyle.OkOnly)
                End If
            End If
            '     Label1.Text = strA & "  " & riList.Count

            ac.Acceptance_UpdatePay(ai)
        Next
        MsgBox("付款狀態已改變,單號: " & txtQuoID.Text & " ")
        Me.Close()

    End Sub
    Sub UpdateQCCheck()

        Dim ac As New AcceptanceController
        Dim ai As New AcceptanceInfo
        Dim i As Integer
        For i = 0 To ds.Tables("Acceptance").Rows.Count - 1

            ai.A_NO = ds.Tables("Acceptance").Rows(i)("A_NO")
            ai.M_Code = ds.Tables("Acceptance").Rows(i)("M_Code")
            ai.WQC_Status = ds.Tables("Acceptance").Rows(i)("WQC_Status")
            ds.Tables("Acceptance").Rows(i)("WQC_Action") = InUserID
            ai.WQC_Action = ds.Tables("Acceptance").Rows(i)("WQC_Action")

            ac.Acceptance_UpdateQCCheck(ai)
        Next
        MsgBox("QC抽檢狀態已改變,單號: " & txtQuoID.Text & " ")
        Me.Close()
    End Sub

    Function GetAcceptanceNO()
        '生成新的驗收單號
        Dim str1, str2 As String
        Dim ac As New AcceptanceController
        Dim ai As New AcceptanceInfo
        str1 = Mid(Year(Now), 3)
        If CInt(Month(Now)) < 10 Then
            str2 = "0" & Month(Now)
        Else
            str2 = Month(Now)
        End If

        Dim Stra As String
        Stra = "AC" & str1 & str2

        ai = ac.Acceptance_Get(Stra)
        If ai Is Nothing Then
            GetAcceptanceNO = "AC" & str1 & str2 & "0001"
        Else
            GetAcceptanceNO = "AC" & str1 & str2 & Mid((CInt(Mid(ai.A_AcceptanceNO, 7)) + 10001), 2)
        End If
    End Function

    Function LoadData(ByVal A_AcceptanceNO As String) As Boolean
        '載入驗收單數據

        LoadData = True
        Dim objInfo As New AcceptanceInfo
        Dim objList As New List(Of AcceptanceInfo)
        Dim oc As New AcceptanceController
        Try
            objInfo = oc.Acceptance_Get(A_AcceptanceNO)
            If objInfo Is Nothing Then
                '沒有數據
                LoadData = False
                Exit Function
            End If
            ds.Tables("Acceptance").Rows.Clear()
            objList = oc.Acceptance_GetList(Nothing, A_AcceptanceNO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Dim i As Integer
            Dim row As DataRow
            For i = 0 To objList.Count - 1
                row = ds.Tables("Acceptance").NewRow
                row("PM_NO") = objList(i).PM_NO
                row("M_Unit") = objList(i).M_Unit
                row("M_Gauge") = objList(i).M_Gauge
                row("M_Code") = objList(i).M_Code
                row("M_Name") = objList(i).M_Name


                row("OS_BatchID") = objList(i).OS_BatchID
                row("PM_M_Code") = objList(i).PM_M_Code
                row("DPT_ID") = objList(i).DPT_ID
                row("U_ID") = objList(i).U_ID

                row("A_Qty") = objList(i).A_Qty
                row("A_Remark") = objList(i).A_Remark

                row("A_NO") = objList(i).A_NO
                row("PN_NO") = objList(i).PN_NO

                row("WQC_Status") = objList(i).WQC_Status
                row("WQC_Action") = objList(i).WQC_Action

                ds.Tables("Acceptance").Rows.Add(row)

                gluSupplier.Text = objList(i).S_Supplier
                txtName.Text = objList(i).A_SendNO
                ButtonEdit1.Text = objList(i).DepotNO
                DateEdit1.Text = Format(objList(i).A_SendDate, "Short Date")
                DateEdit2.Text = objList(i).A_CheckDate
                CBSendType.Text = objList(i).A_SendType

                If objList(i).A_AccountCheck = False Then
                    CheckEdit2.Checked = False
                Else
                    CheckEdit2.Checked = True
                End If

                CBA_AccountCheckType.Text = objList(i).A_AccountCheckType
                MemoEdit2.Text = objList(i).A_AccountCheckRemark
                'Label8.Text = objList(i).A_AccountCheckDate
                Label31.Text = objList(i).A_AccountCheckDate
                Label3.Text = objList(i).A_AccountCheckAction
                Label2.Text = objList(i).A_Ver
                Label7.Text = objList(i).A_Action
                Label6.Text = objList(i).A_CheckAction

                If objList(i).A_Check = False Then
                    CheckEdit1.Checked = False
                Else
                    CheckEdit1.Checked = True
                End If

                CBA_CheckType.Text = objList(i).A_CheckType
                MemoEdit1.Text = objList(i).A_CheckRemark

                If objList(i).A_PayCheck = False Then
                    CheckEdit3.Checked = False
                Else
                    CheckEdit3.Checked = True
                End If
                Label32.Text = objList(i).A_PayCheckDate
                Label10.Text = objList(i).A_PayCheckAction
                MemoEdit3.Text = objList(i).A_PayCheckRemark
            Next


        Catch ex As Exception
            LoadData = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub popDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popDel.Click

        If AdvBandedGridView1.RowCount = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = AdvBandedGridView1.GetRowCellDisplayText(ArrayToString(AdvBandedGridView1.GetSelectedRows()), "A_NO")

        If DelTemp = "A_NO" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelDataAcceptance").NewRow
            row("A_NO") = DelTemp
            ds.Tables("DelDataAcceptance").Rows.Add(row)
        End If
        ds.Tables("Acceptance").Rows.RemoveAt(CInt(ArrayToString(AdvBandedGridView1.GetSelectedRows())))
        If AdvBandedGridView1.RowCount = 0 Then
            gluSupplier.Text = Nothing
        End If
    End Sub

    Private Sub DateEdit2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateEdit2.EditValueChanged

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
   
    
    Private Sub RepositoryItemButtonEdit1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemButtonEdit1.Click
        '    On Error Resume Next
        Dim strA As String
        strA = ds.Tables("Acceptance").Rows(AdvBandedGridView1.FocusedRowHandle)("PM_NO").ToString
        Dim open, update, down, edit, del, detail As Boolean
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As New List(Of PermissionModuleWarrantSubInfo)

        '   If Grid.Rows.Count = 0 Then Exit Sub
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400210")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then update = True
            If pmwiL.Item(0).PMWS_Value = "否" Then update = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400211")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then down = True
            If pmwiL.Item(0).PMWS_Value = "否" Then down = False
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400212")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then edit = True
            If pmwiL.Item(0).PMWS_Value = "否" Then edit = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400213")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then del = True
            If pmwiL.Item(0).PMWS_Value = "否" Then del = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400214")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then detail = True
            If pmwiL.Item(0).PMWS_Value = "否" Then detail = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400215")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then open = True
            If pmwiL.Item(0).PMWS_Value = "否" Then open = False
        End If

        FileShow("4002", strA, open, update, down, edit, del, detail)
    End Sub

 
    Private Sub cmdPrintNO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintNO.Click
        Dim str1, str2 As String
        str1 = txtQuoID.Text
        If str1 = "" Then
            MsgBox("驗收單號不能為空！")
            Exit Sub
        End If

        str2 = DateEdit1.EditValue
        PrintAcceptanceNO(str2, str1)
    End Sub

End Class