Imports LFERP.Library.Purchase.Purchase
Imports LFERP.Library.Material
Imports LFERP.Library.Purchase.Quotation

Imports LFERP.FileManager
Imports LFERP.SystemManager

Public Class frmPurchase
    Dim ds As New DataSet
    Dim S_Associate(2) As String
    Dim S_Tel(2) As String
    Dim S_Fax(2) As String
    Dim strTemp As String = ""


    Private Sub frmPurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mtd As New LFERP.DataSetting.SuppliersControler
        gluSupplier.Properties.DisplayMember = "S_SupplierName"
        gluSupplier.Properties.ValueMember = "S_Supplier"

        If tempValue2 = "查看" Then
            gluSupplier.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        Else
            gluSupplier.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")
        End If


        Dim mtg As New LFERP.DataSetting.CompanyControler
        gluCompany.Properties.DisplayMember = "CO_ID"
        gluCompany.Properties.ValueMember = "CO_ID"
        gluCompany.Properties.DataSource = mtg.Company_Getlist(Nothing, Nothing, Nothing, Nothing)

        Dim mtsCurrency As New LFERP.DataSetting.CurrencyControler

        lueCurrency.Properties.DataSource = mtsCurrency.GetCurrencyList(Nothing)

        Dim mtstarriff As New LFERP.DataSetting.TarriffController
        'TarriffEdit.Properties.DisplayMember = "Tarriff_Value"
        'TarriffEdit.Properties.ValueMember = "Tarriff_Value"
        TarriffEdit.Properties.DataSource = mtstarriff.TarriffGetList(Nothing)



        CreateTables()
        txtPMID.Text = tempValue
        Label24.Text = tempValue2
        Label28.Text = tempValue3
        Label29.Text = tempValue4
        TxtRebate.Text = "0"
        tempValue2 = ""
        tempValue = ""
        tempValue3 = ""
        tempValue4 = ""
        'txtPMID.Enabled = True
        Select Case Label24.Text
            Case "採購單"
                If Edit = True Then
                    Select Case Label28.Text

                        Case "采購作業"
                            Me.Text = "採購單修改"
                            LoadEdit(txtPMID.Text)
                            ComboBoxEdit3.Enabled = False
                            gluSupplier.Enabled = True
                        Case "手開採購單"

                            Me.Text = "手開採購單修改"
                            LoadEdit(txtPMID.Text)
                            ComboBoxEdit3.Enabled = False
                            gluSupplier.Enabled = False
                            Q_QuoID.OptionsColumn.ReadOnly = True
                            GridColumn8.OptionsColumn.ReadOnly = False

                    End Select
                  
                Else
                    Select Case Label28.Text
                        Case "采購作業"
                            Me.Text = "採購單新增"
                            txtPMID.Text = ""
                            Label2.Text = 0
                            ComboBoxEdit3.Enabled = False
                            gluSupplier.Enabled = True
                            ComboBoxEdit3.Text = Label29.Text
                            DateEdit1.Text = Format(Now, "yyyy/MM/dd")
                        Case "手開採購單"
                            Me.Text = "手開採購單新增"
                            txtPMID.Text = ""
                            Label2.Text = 0
                            ComboBoxEdit3.Enabled = False
                            ComboBoxEdit3.EditValue = "物料"
                            gluSupplier.EditValue = "S0795"
                            gluSupplier.Enabled = False
                            DateEdit1.Text = Format(Now, "yyyy/MM/dd")
                            Q_QuoID.OptionsColumn.ReadOnly = True
                            GridColumn8.OptionsColumn.ReadOnly = False
                    End Select

                End If

                XtraTabControl1.SelectedTabPage = XtraTabPage1
                getenable(True, False, False)

            Case "部門審核"
                Me.Text = "部門審核"
                LoadEdit(txtPMID.Text)
                XtraTabControl1.SelectedTabPage = XtraTabPage2
                getenable(False, True, False)
                GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                GridView1.OptionsBehavior.Editable = False
                GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
                popPurchaseAdd.Visible = False
                popApplyAdd.Visible = False
                popPurchaseDel.Visible = False
                ToolStripSeparator1.Visible = False
                popPurchaseCode.Visible = False
                popPurchasefujian.Visible = False

            Case "會計部審核"
                Me.Text = "會計部審核"
                LoadEdit(txtPMID.Text)
                XtraTabControl1.SelectedTabPage = XtraTabPage3
                getenable(False, False, True)
                GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                GridView1.OptionsBehavior.Editable = False
                GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
                popPurchaseAdd.Visible = False
                popApplyAdd.Visible = False
                popPurchaseDel.Visible = False
                ToolStripSeparator1.Visible = False
                popPurchaseCode.Visible = False
                popPurchasefujian.Visible = False
            Case "查看"
                Me.Text = "查看"
                LoadEdit(txtPMID.Text)
                XtraTabControl1.SelectedTabPage = XtraTabPage1
                getenable(False, False, False)

                'GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                'GridView1.OptionsBehavior.Editable = False
                'GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
                TxtRebate.Enabled = False
                ComboBoxEdit3.Enabled = False
                gluSupplier.Enabled = False
                cmdSave.Enabled = False
                txtRemark.Enabled = True  '查看時--備註可允許複製!
                tempCode = ""
                popPurchaseAdd.Visible = False
                popApplyAdd.Visible = False
                popPurchaseDel.Visible = False
                ToolStripSeparator1.Visible = False
                popPurchaseCode.Visible = False
                popPurchasefujian.Visible = False
                '-------------------------------------------------------------------------------------------
                '---設置權限--看是否顯示單價以及總金額信息
                '-------------------------------------------------------------------------------------------
                Dim pmws As New PermissionModuleWarrantSubController
                Dim pmwil1 As List(Of PermissionModuleWarrantSubInfo)

                If Mid(txtPMID.EditValue, 1, 2) = "PM" Then

                    pmwil1 = pmws.PermissionModuleWarrantSub_GetList(InUserID, "40020417")
                    strTemp = pmwil1.Item(0).PMWS_Value

                    Select Case strTemp
                        Case "非采購人員"
                            subaccount.Visible = False
                            subaccount.VisibleIndex = -1
                            GridColumn8.Visible = False
                            GridColumn8.VisibleIndex = -1
                            Label27.Visible = False
                    End Select

                ElseIf Mid(txtPMID.EditValue, 1, 2) = "PF" Then
                    'Dim strTemp As String = ""
                    pmwil1 = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400817")
                    strTemp = pmwil1.Item(0).PMWS_Value

                    Select Case strTemp
                        Case "非采購人員"
                            subaccount.Visible = False
                            subaccount.VisibleIndex = -1
                            GridColumn8.Visible = False
                            GridColumn8.VisibleIndex = -1
                            Label27.Visible = False
                    End Select
                End If
                '-------------------------------------------------------------------------------------------
        End Select
        '顯示附件---2013-6-17 加權限不顯示報價附檔信息

        Dim pmwc2 As New PermissionModuleWarrantSubController
        Dim pmwl2 As List(Of PermissionModuleWarrantSubInfo)

        pmwl2 = pmwc2.PermissionModuleWarrantSub_GetList(InUserID, "40020419")
        Dim str As String = "All"
        If pmwl2.Count <= 0 Then
        Else
            If pmwl2(0).PMWS_Value = "是" Then
                str = ""
            End If
        End If
        '’------------------------

        pmwl2 = pmwc2.PermissionModuleWarrantSub_GetList(InUserID, "40020420")
        Dim str2 As String = "All"
        If pmwl2.Count <= 0 Then
        Else
            If pmwl2(0).PMWS_Value = "是" Then
                str2 = ""
            End If
        End If


        LoadFileDisplay(str, str2)

    End Sub

    Sub CreateTables()

        ds.Tables.Clear()
        '創建數據表
        With ds.Tables.Add("Purchase")
            .Columns.Add("PS_NO", GetType(String))
            .Columns.Add("PM_NO", GetType(String))

            .Columns.Add("Q_QuoID", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("OS_BatchID", GetType(String))

            .Columns.Add("S_SupplierNo", GetType(String))
            .Columns.Add("AP_Num", GetType(String))
            .Columns.Add("PN_NO", GetType(String))
            .Columns.Add("DPT_ID", GetType(String))
            .Columns.Add("U_ID", GetType(String))
            .Columns.Add("PS_NeedPurchaseUse", GetType(String))
            .Columns.Add("C_ID", GetType(String))
            .Columns.Add("PS_Qty", GetType(Double))
            .Columns.Add("PS_NoSendQty", GetType(Double))
            .Columns.Add("PS_Price", GetType(String))


            .Columns.Add("PS_SendDate", GetType(String))
            .Columns.Add("PS_Depict", GetType(String))
            .Columns.Add("PS_Detail", GetType(String))

            .Columns.Add("PS_Tarriff", GetType(Single))
            .Columns.Add("PS_TffCost", GetType(Double))
            .Columns.Add("PS_AmountBf", GetType(Double))
            .Columns.Add("PS_AmountAf", GetType(Double))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("Q_StandardPack", GetType(Single))
            .Columns.Add("Q_MOQ", GetType(Single))
            .Columns.Add("subaccount", GetType(Single))


        End With
        '創建刪除數據表
        With ds.Tables.Add("DelData")
            .Columns.Add("PS_NO", GetType(String))
            .Columns.Add("M_Code", GetType(String))

        End With
        '綁定表格
        Grid.DataSource = ds.Tables("Purchase")

    End Sub
    Sub AddRow(ByVal strCode As String)
        If strCode = "" Then
        Else

            Dim i As Integer

            For i = 0 To ds.Tables("Purchase").Rows.Count - 1
                If strCode = ds.Tables("Purchase").Rows(i)("M_Code") Then
                    MsgBox("一張單不允許有重復物料編碼....")
                    Exit Sub
                End If
            Next
            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)

            If objInfo Is Nothing Then Exit Sub

            If objInfo.M_IsEnabled = False Then  '判斷當前物料是否可用 2012-2-20，不可用不允許報價！
                MsgBox("當前物料不可用，不允許採購！")
                Exit Sub
            End If

            Dim row As DataRow
            row = ds.Tables("Purchase").NewRow
            'CodeSubData.Tables("CodeSub").NewRow()
            row("PS_NO") = Nothing
            row("PM_NO") = Nothing

            row("M_Code") = objInfo.M_Code

            row("M_Name") = objInfo.M_Name
            row("M_Unit") = objInfo.M_Unit
            row("M_Gauge") = objInfo.M_Gauge

            row("PS_Qty") = 0
            row("PS_NoSendQty") = 0
            row("Q_StandardPack") = 0
            row("Q_MOQ") = 0
            If gluSupplier.EditValue = objInfo.M_Supplier Then
                If IsDBNull(objInfo.M_Price) Then
                    row("PS_Price") = 0
                Else
                    row("PS_Price") = objInfo.M_Price
                End If
                row("S_SupplierNo") = objInfo.M_SupplierNo
            Else
                row("PS_Price") = 0
            End If
            row("PS_SendDate") = Format(Now, "yyyy/MM/dd")
            row("PS_Tarriff") = 0
            ds.Tables("Purchase").Rows.Add(row)


            GridView1.MoveLast()
        End If
    End Sub
  
    Sub loadeditsub(ByVal dlist As List(Of PurchaseMainInfo))
        If dlist Is Nothing Then Exit Sub
        On Error Resume Next
        Dim i As Integer
        Dim allaccount As Single
        Dim row As DataRow

        allaccount = 0
        TarriffEdit.EditValue = dlist(0).PS_Tarriff.ToString
        lueCurrency.EditValue = dlist(0).C_ID
        For i = 0 To dlist.Count - 1

            row = ds.Tables("Purchase").NewRow
            row("PS_NO") = dlist(i).PS_NO
            row("PM_NO") = dlist(i).PM_NO

            row("Q_QuoID") = dlist(i).Q_QuoID
            row("M_Code") = dlist(i).M_Code
            row("M_Name") = dlist(i).M_Name
            row("M_Gauge") = dlist(i).M_Gauge
            row("M_Unit") = dlist(i).M_Unit
            row("OS_BatchID") = dlist(i).OS_BatchID

            row("PM_M_Code") = dlist(i).PM_M_Code

            row("S_SupplierNo") = dlist(i).S_SupplierNo
            row("PN_NO") = dlist(i).PN_NO
            row("DPT_ID") = dlist(i).DPT_ID
            row("U_ID") = dlist(i).U_ID
            row("PS_NeedPurchaseUse") = dlist(i).PS_NeedPurchaseUse
            row("C_ID") = dlist(i).C_ID
            row("PS_Qty") = dlist(i).PS_QTY
            row("PS_NoSendQty") = dlist(i).PS_NoSendQty
            row("PS_Price") = dlist(i).PS_Price

            row("Q_StandardPack") = 0
            row("Q_MOQ") = 0

            row("PS_SendDate") = Format(dlist(i).PS_SendDate, "yyyy/MM/dd")
            row("PS_Depict") = dlist(i).PS_Depict
            row("PS_Detail") = dlist(i).PS_Detail

            row("PS_Tarriff") = dlist(i).PS_Tarriff
            row("PS_TffCost") = dlist(i).PS_TffCost
            row("PS_AmountBf") = dlist(i).PS_AmountBf
            row("PS_AmountAf") = dlist(i).PS_AmountAf

            row("subaccount") = row("PS_Price") * row("PS_Qty")
            allaccount = allaccount + row("subaccount")
            ds.Tables("Purchase").Rows.Add(row)
        Next
        Label27.Text = allaccount


    End Sub

    Function LoadEdit(ByVal PM_NO As String) As Boolean

        LoadEdit = True
        Dim objInfo As New PurchaseMainInfo
        Dim pc As New PurchaseMainController
        Try
            objInfo = pc.PurchaseMain_Get(PM_NO)
            If objInfo Is Nothing Then
                '沒有數據
                LoadEdit = False
                Exit Function
            End If

            gluSupplier.EditValue = objInfo.S_Supplier
            cboName.EditValue = objInfo.PM_Associate

            If Not IsDBNull(objInfo.PM_PurchaseDate) Then
                DateEdit1.EditValue = objInfo.PM_PurchaseDate
            End If
            txtRemark.EditValue = objInfo.PM_Remark
            TxtRebate.Text = objInfo.PM_Rebate
            'InUserID = objInfo.PM_Action
            ComboBoxEdit1.EditValue = objInfo.PM_ToFrom
            ComboBoxEdit2.EditValue = objInfo.PM_ComeType
            ComboBoxEdit3.EditValue = objInfo.PM_PurchaseType
            gluCompany.EditValue = objInfo.CO_ID
            Label2.Text = objInfo.PM_Version
            'Label28.Text = objInfo.PM_Type


            CheckEdit1.Checked = objInfo.PM_Check
            CBEdit4.Text = objInfo.PM_CheckType
            CheckRemark.Text = objInfo.PM_CheckRemark
            CheckDate.Text = objInfo.PM_CheckDate
            CheckAction.Text = objInfo.PM_CheckActionName


            CheckEdit2.Checked = objInfo.PM_AccountCheck
            ACheckType.Text = objInfo.PM_AccountCheckType
            MemoEdit2.Text = objInfo.PM_AccountCheckRemark
            ACdate.Text = objInfo.PM_AccountCheckDate
            ACAction.Text = objInfo.PM_AccCheckActionName


            ds.Tables("Purchase").Rows.Clear()
            loadeditsub(pc.PurchaseMain_Getlist(PM_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

        Catch ex As Exception

            LoadEdit = False
            MsgBox(ex.Message)

        End Try
    End Function

    Private Sub popPurchaseAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPurchaseAdd.Click
        If gluSupplier.EditValue = "" Then
            MsgBox("請先確定供應商", , "提示")
            Exit Sub
        End If
        tempCode = ""
        tempValue6 = "採購管理"
        If Label29.Text = "大貨批次" Or Label29.Text = "配件批次" Then
            frmBOMSelect.XtraTabPage1.PageVisible = False
            frmBOMSelect.XtraTabPage2.PageVisible = True
            frmBOMSelect.XtraTabPage3.PageVisible = False
        ElseIf Label29.Text = "物料" Then
            frmBOMSelect.XtraTabPage1.PageVisible = True
            frmBOMSelect.XtraTabPage2.PageVisible = False
            frmBOMSelect.XtraTabPage3.PageVisible = False
        Else
            frmBOMSelect.XtraTabPage1.PageVisible = True
            frmBOMSelect.XtraTabPage2.PageVisible = True
            frmBOMSelect.XtraTabPage3.PageVisible = True
        End If
        frmBOMSelect.ShowDialog()
        '增加記錄
        If frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 0 Then
            If tempCode = "" Then
                Exit Sub
            Else
                AddRow(tempCode)
            End If
        ElseIf frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 1 Then  '批次
            Dim i, n As Integer
            Dim arr(n) As String
            arr = Split(tempValue7, ",")
            n = Len(Replace(tempValue7, ",", "," & "*")) - Len(tempValue7)
            For i = 0 To n

                Dim j As Integer

                For j = 0 To ds.Tables("Purchase").Rows.Count - 1
                    If arr(i) = ds.Tables("Purchase").Rows(j)("M_Code") Then
                        MsgBox("一張單不允許有重復物料編碼....")
                        Exit Sub
                    End If
                Next
                If arr(i) = "" Then
                    Exit Sub
                End If
                Dim mc As New LFERP.Library.Material.MaterialController
                Dim objInfo As New LFERP.Library.Material.MaterialInfo
                objInfo = mc.MaterialCode_Get(arr(i))

                If objInfo Is Nothing Then Exit Sub

                If objInfo.M_IsEnabled = False Then  '判斷當前物料是否可用 2012-2-20，不可用不允許報價！
                    MsgBox("當前物料不可用，不允許採購！")
                    Exit Sub
                End If

                Dim osc As New Library.Orders.OrdersSubController
                Dim osi As List(Of Library.Orders.OrdersSubInfo)
                osi = osc.OrdersSub_GetList(Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                Dim obi As List(Of Library.Orders.OrdersBomInfo)
                Dim obc As New Library.Orders.OrdersBomController

                obi = obc.OrdersBom_GetList(arr(i), tempValue2, Nothing, Nothing)

                Dim row As DataRow
                row = ds.Tables("Purchase").NewRow
                row("PS_NO") = Nothing
                row("PM_NO") = Nothing

                row("M_Code") = objInfo.M_Code

                row("M_Name") = objInfo.M_Name
                row("M_Unit") = objInfo.M_Unit
                row("M_Gauge") = objInfo.M_Gauge
                row("OS_BatchID") = tempValue2

                row("PM_M_Code") = osi(0).PM_M_Code
                row("PS_Qty") = obi(0).OB_MainQty '當前批次中連士啤數量
                row("PS_NoSendQty") = 0
                row("Q_StandardPack") = 0
                row("Q_MOQ") = 0
                row("PS_Price") = 0
                If gluSupplier.EditValue = obi(0).OB_Supplier Then
                    row("S_SupplierNo") = obi(0).OB_SupplierNo
                Else
                    MsgBox("此批次中物料所對應供應商與採購供應商不一致", , "溫馨提示")
                    row("S_SupplierNo") = ""
                End If
                row("PS_SendDate") = osi(0).OS_SendDate '當前批次中要求的交貨期
                row("PS_Tarriff") = 0
                ds.Tables("Purchase").Rows.Add(row)
                GridView1.MoveLast()
            Next

        ElseIf frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 2 Then   '聯豐編號
            Dim i, n As Integer
            Dim arr(n) As String
            'MsgBox(tempValue8)
            arr = Split(tempValue8, ",")
            n = Len(Replace(tempValue8, ",", "," & "*")) - Len(tempValue8)
            For i = 0 To n

                Dim j As Integer

                For j = 0 To ds.Tables("Purchase").Rows.Count - 1
                    If arr(i) = ds.Tables("Purchase").Rows(j)("M_Code") Then
                        MsgBox("一張單不允許有重復物料編碼....")
                        Exit Sub
                    End If
                Next
                If arr(i) = "" Then
                    Exit Sub
                End If
                Dim mc As New LFERP.Library.Material.MaterialController
                Dim objInfo As New LFERP.Library.Material.MaterialInfo
                objInfo = mc.MaterialCode_Get(arr(i))

                If objInfo Is Nothing Then Exit Sub

                If objInfo.M_IsEnabled = False Then  '判斷當前物料是否可用 2012-2-20，不可用不允許報價！
                    MsgBox("當前物料不可用，不允許採購！")
                    Exit Sub
                End If

                Dim row As DataRow
                row = ds.Tables("Purchase").NewRow
                row("PS_NO") = Nothing
                row("PM_NO") = Nothing

                row("M_Code") = objInfo.M_Code

                row("M_Name") = objInfo.M_Name
                row("M_Unit") = objInfo.M_Unit
                row("M_Gauge") = objInfo.M_Gauge
                row("OS_BatchID") = ""
                row("PM_M_Code") = tempValue3
                row("PS_Qty") = 0
                row("PS_NoSendQty") = 0
                row("Q_StandardPack") = 0
                row("Q_MOQ") = 0
                row("PS_Price") = 0
                If gluSupplier.EditValue = objInfo.M_Supplier Then
                    row("S_SupplierNo") = objInfo.M_SupplierNo
                Else
                    row("S_SupplierNo") = ""
                End If
                row("PS_SendDate") = Format(Now, "yyyy/MM/dd")
                row("PS_Tarriff") = 0
                ds.Tables("Purchase").Rows.Add(row)
                GridView1.MoveLast()
            Next
        End If
        tempValue2 = ""
        tempValue7 = ""
        tempValue8 = ""
        tempValue3 = ""
    End Sub

    Private Sub popPurchaseDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPurchaseDel.Click
        If ds.Tables("Purchase").Rows.Count = 0 Then Exit Sub


        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "M_Code")

        If DelTemp = "M_Code" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelData").NewRow
            'row("M_CodeSub") = CodeSubData.Tables("CodeSub").Rows(GridView1.FocusedRowHandle)("M_CodeSub")
            row("PS_NO") = ds.Tables("Purchase").Rows(GridView1.FocusedRowHandle)("PS_NO")
            row("M_Code") = DelTemp
            ds.Tables("DelData").Rows.Add(row)
        End If
        ds.Tables("Purchase").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub

    Private Sub gluSupplier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluSupplier.EditValueChanged
        On Error Resume Next
        If Label24.Text = "採購單" Then
            Dim mi As New LFERP.DataSetting.SuppliersControler
            Dim mc As New LFERP.DataSetting.SuppliersInfo
            mc = mi.Suppliers_Get(gluSupplier.EditValue.ToString, Nothing)
            cboName.Properties.Items.Clear()
            If Trim(mc.S_Associate) <> "" And IsDBNull(mc.S_Associate) = False Then
                cboName.Properties.Items.Add(mc.S_Associate)
                S_Associate(0) = mc.S_Associate
                S_Tel(0) = mc.S_Tel
                S_Fax(0) = mc.S_Fax
            End If
            If Trim(mc.S_Associate1) <> "" And IsDBNull(mc.S_Associate1) = False Then
                cboName.Properties.Items.Add(mc.S_Associate1)
                S_Associate(1) = mc.S_Associate1
                S_Tel(1) = mc.S_Tel1
                S_Fax(1) = mc.S_Fax1
            End If
            If Trim(mc.S_Associate2) <> "" And IsDBNull(mc.S_Associate2) = False Then
                cboName.Properties.Items.Add(mc.S_Associate2)
                S_Associate(2) = mc.S_Associate2
                S_Tel(2) = mc.S_Tel2
                S_Fax(2) = mc.S_Fax2
            End If
            If cboName.Properties.Items.Count > 0 Then cboName.Text = cboName.Properties.Items(0)

            'If GridView1.RowCount > 0 Then
            '    Dim qc As New QuotationController
            '    Dim qi As List(Of QuotationInfo)
            '    Dim i%
            '    For i = 0 To GridView1.RowCount - 1
            '        qi = qc.Quotation_Getlist(GridView1.GetRowCellValue(i, "Q_QuoID"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, gluSupplier.EditValue, Nothing, Nothing, Nothing)
            '        If qi.Count <= 0 Then
            '            GridView1.ClearSorting()

            '        End If
            '    Next
            'End If
            ComboBoxEdit1.Text = mc.S_ToFrom
            lueCurrency.EditValue = mc.S_Currency
        End If
    End Sub

    Sub getenable(ByVal a As Boolean, ByVal b As Boolean, ByVal c As Boolean)
        gluCompany.Enabled = a
        'gluSupplier.Enabled = a
        ComboBoxEdit1.Enabled = a
        cboName.Enabled = a
        ComboBoxEdit2.Enabled = a
        DateEdit1.Enabled = a
        lueCurrency.Enabled = a
        'ComboBoxEdit3.Enabled = a
        txtRemark.Enabled = a
        'Grid.Enabled = a
        TarriffEdit.Enabled = a
        TxtRebate.Enabled = a


        CheckEdit1.Enabled = b
        CBEdit4.Enabled = b
        CheckRemark.Enabled = b

        CheckEdit2.Enabled = c
        ACheckType.Enabled = c
        MemoEdit2.Enabled = c


    End Sub
    Function GetManual_NO() As String
        Dim pm As New PurchaseMainController
        Dim pi As New PurchaseMainInfo
        Dim ndate As String
        ndate = "PF" + Format(Now, "yyMM")
        pi = pm.PurchaseMain_GetID(ndate)
        If pi Is Nothing Then
            GetManual_NO = ndate + "00001"
        Else
            GetManual_NO = ndate + Mid((CInt(Mid(pi.PM_NO, 7)) + 100001), 2)
        End If
    End Function
    Function GetPM_No() As String
        '生成新pm
        Dim pm As New PurchaseMainController
        Dim pi As New PurchaseMainInfo
        Dim ndate As String
        ndate = "PM" + Format(Now, "yyMM")
        pi = pm.PurchaseMain_GetID(ndate)
        If pi Is Nothing Then
            GetPM_No = ndate + "00001"
        Else
            GetPM_No = ndate + Mid((CInt(Mid(pi.PM_NO, 7)) + 100001), 2)
        End If



        'Dim QC As New QuotationController
        'Dim QI As New QuotationInfo
        'Dim tt As String

        'tt = "Q" + Format(Now(), "yyMM")

        'QI = QC.Quotation_GetID(tt)

        'If QI Is Nothing Then
        '    GetQuo_ID = tt + "00001"
        'Else
        '    GetQuo_ID = tt + Mid((CInt(Mid(QI.Q_QuoID, 6)) + 100001), 2)

        'End If


    End Function


    Function GetPS_No() As String

        '生成新pS
        Dim pm As New PurchaseMainController
        Dim pi As New PurchaseMainInfo
        pi = pm.PurchaseSub_Get(Nothing)
        If pi Is Nothing Then
            GetPS_No = "PS00000001"
        Else
            GetPS_No = "PS" & Mid((CInt(Mid(pi.PS_NO, 3)) + 100000001), 2)
        End If

    End Function


    'Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged

    '    On Error Resume Next
    '    MsgBox(GridLookUpEdit1.View.GetFocusedRowCellDisplayText("Q_SupplierNo").ToString)
    '    ds.Tables("Purchase").Rows(GridView1.FocusedRowHandle)("S_SupplierNo") = GridLookUpEdit1.View.GetFocusedRowCellDisplayText("Q_SupplierNo").ToString
    '    ds.Tables("Purchase").Rows(GridView1.FocusedRowHandle)("PS_Price") = GridLookUpEdit1.View.GetFocusedRowCellDisplayText("Q_Price").ToString


    'End Sub

    'Private Sub Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.Click

    '    Dim qo As New LFERP.Library.Purchase.Quotation.QuotationController

    '    GridLookUpEdit1.DataSource = qo.Quotation_Getlist(Nothing, tempCode, Nothing, Nothing, gluSupplier.EditValue, True, True)

    'End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Sub SaveDataNew()
        'On Error Resume Next


        If Len(gluCompany.EditValue) = 0 Then
            MsgBox("請選擇公司")
            Exit Sub
        End If

        If Len(gluSupplier.EditValue) = 0 Then
            MsgBox("請選擇供應商")
            Exit Sub
        End If

        If Len(ComboBoxEdit3.EditValue) = 0 Then
            MsgBox("請選擇採購類型")
            Exit Sub
        End If
        If Len(TarriffEdit.EditValue) = 0 Then
            MsgBox("請選擇稅率")
            Exit Sub
        End If
        If Len(lueCurrency.EditValue) = 0 Then
            MsgBox("請選擇幣別")
            Exit Sub
        End If

        If Len(ComboBoxEdit1.EditValue) = 0 Then
            MsgBox("請選擇付款方式")
            Exit Sub
        End If

        If Len(ComboBoxEdit2.EditValue) = 0 Then
            MsgBox("請選擇送貨方式")
            Exit Sub
        End If

        Dim i As Integer
        For i = 0 To ds.Tables("Purchase").Rows.Count - 1
            If IsDBNull(ds.Tables("Purchase").Rows(i)("Q_QuoID")) Then
                MsgBox("請選擇報價單")
                Exit Sub
            End If

        Next

        Dim mc As New PurchaseMainController
        txtPMID.EditValue = GetPM_No() '取得單號"
        Dim objinfo As New PurchaseMainInfo

        If ds.Tables("Purchase").Rows.Count = 0 Then
            MsgBox("請選擇物料")
            Exit Sub
        End If

        If Len(txtPMID.EditValue) = 0 Then

            MsgBox("不能生成單號，無法保存")
            Exit Sub
        End If

        objinfo.PM_NO = txtPMID.EditValue
        objinfo.PM_Associate = cboName.EditValue
        Dim j%
        For j = 0 To 2
            If cboName.EditValue = S_Associate(j) Then
                objinfo.PM_Tel = S_Tel(j)
                objinfo.PM_Fax = S_Fax(j)
            End If
        Next
        objinfo.S_Supplier = gluSupplier.EditValue
        objinfo.PM_Type = "采購作業"

        objinfo.PM_PurchaseDate = DateEdit1.EditValue

        objinfo.PM_Remark = txtRemark.EditValue
        objinfo.PM_Action = InUserID
        objinfo.PM_ToFrom = ComboBoxEdit1.EditValue
        objinfo.PM_ComeType = ComboBoxEdit2.EditValue
        objinfo.PM_PurchaseType = ComboBoxEdit3.EditValue
        objinfo.PM_Rebate = TxtRebate.Text
        objinfo.PM_Check = False
        objinfo.PM_AccountCheck = False
        objinfo.PM_Version = 0

        objinfo.CO_ID = gluCompany.EditValue

        If mc.PurchaseMain_Add(objinfo) = False Then
            MsgBox("保存失敗...")
            Exit Sub
        End If
        objinfo.C_ID = lueCurrency.EditValue '``````````````````````````````````````````幣別


        For i = 0 To ds.Tables("Purchase").Rows.Count - 1

            objinfo.PS_NO = GetPS_No()

            If IsDBNull(ds.Tables("Purchase").Rows(i)("Q_QuoID")) Then
                objinfo.Q_QuoID = Nothing
            Else
                objinfo.Q_QuoID = ds.Tables("Purchase").Rows(i)("Q_QuoID")
            End If

            objinfo.M_Code = ds.Tables("Purchase").Rows(i)("M_Code")

            If IsDBNull(ds.Tables("Purchase").Rows(i)("S_SupplierNo")) Then
                objinfo.S_SupplierNo = Nothing
            Else
                objinfo.S_SupplierNo = ds.Tables("Purchase").Rows(i)("S_SupplierNo")
            End If

            If IsDBNull(ds.Tables("Purchase").Rows(i)("OS_BatchID")) Then
                objinfo.OS_BatchID = Nothing
            Else
                objinfo.OS_BatchID = ds.Tables("Purchase").Rows(i)("OS_BatchID")
            End If
            'objinfo.M_Unit = ds.Tables("Purchase").Rows(i)("M_Unit")
            'objinfo.M_Name = ds.Tables("Purchase").Rows(i)("M_Name")
            'If IsDBNull(ds.Tables("Purchase").Rows(i)("M_Gauge")) Then
            '    objinfo.M_Gauge = Nothing
            'Else
            '    objinfo.M_Gauge = ds.Tables("Purchase").Rows(i)("M_Gauge")
            'End If
            If IsDBNull(ds.Tables("Purchase").Rows(i)("PN_NO")) Then
                objinfo.PN_NO = Nothing
            Else
                objinfo.PN_NO = ds.Tables("Purchase").Rows(i)("PN_NO")
            End If
            If IsDBNull(ds.Tables("Purchase").Rows(i)("DPT_ID")) Then
                objinfo.DPT_ID = Nothing
            Else
                objinfo.DPT_ID = ds.Tables("Purchase").Rows(i)("DPT_ID")
            End If
            If IsDBNull(ds.Tables("Purchase").Rows(i)("U_ID")) Then
                objinfo.U_ID = Nothing
            Else
                objinfo.U_ID = ds.Tables("Purchase").Rows(i)("U_ID")
            End If
            If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_NeedPurchaseUse")) Then
                objinfo.PS_NeedPurchaseUse = Nothing
            Else
                objinfo.PS_NeedPurchaseUse = ds.Tables("Purchase").Rows(i)("PS_NeedPurchaseUse")
            End If
            objinfo.PS_QTY = CDbl(ds.Tables("Purchase").Rows(i)("PS_QTY"))
            objinfo.PS_NoSendQty = CDbl(ds.Tables("Purchase").Rows(i)("PS_QTY"))
            objinfo.PS_Price = CDbl(ds.Tables("Purchase").Rows(i)("PS_Price"))
            objinfo.PS_SendDate = ds.Tables("Purchase").Rows(i)("PS_SendDate")
            If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_Depict")) Then
                objinfo.PS_Depict = Nothing
            Else
                objinfo.PS_Depict = ds.Tables("Purchase").Rows(i)("PS_Depict")
            End If

            If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_Detail")) Then
                objinfo.PS_Detail = Nothing
            Else
                objinfo.PS_Detail = ds.Tables("Purchase").Rows(i)("PS_Detail")
            End If


            objinfo.PS_Tarriff = CDbl(TarriffEdit.EditValue)
            objinfo.PS_TffCost = CDbl(objinfo.PS_QTY * objinfo.PS_Price * objinfo.PS_Tarriff)
            objinfo.PS_AmountBf = CDbl(objinfo.PS_QTY * objinfo.PS_Price)
            objinfo.PS_AmountAf = objinfo.PS_AmountBf - objinfo.PS_TffCost

            If IsDBNull(ds.Tables("Purchase").Rows(i)("PM_M_Code")) Then
                objinfo.PM_M_Code = Nothing
            Else
                objinfo.PM_M_Code = ds.Tables("Purchase").Rows(i)("PM_M_Code")
            End If



            mc.PurchaseSub_Add(objinfo)
            'MsgBox("數據保存成功!", 64, "提示")
            'Else
            '    MsgBox("數據保存失敗...", 64, "提示")
            '    Exit Sub
            'End If
        Next
        MsgBox("數據保存成功!", 64, "提示")
        Me.Close()
    End Sub '保存新增資料
    Sub SaveDataEdit()
        'On Error Resume Next

        If Len(gluCompany.EditValue) = 0 Then
            MsgBox("請選擇公司")
            Exit Sub
        End If

        If Len(gluSupplier.EditValue) = 0 Then
            MsgBox("請選擇供應商")
            Exit Sub
        End If

        If Len(ComboBoxEdit3.EditValue) = 0 Then
            MsgBox("請選擇採購類型")
            Exit Sub
        End If

        If Len(lueCurrency.EditValue) = 0 Then
            MsgBox("請選擇幣別")
            Exit Sub
        End If

        If Len(ComboBoxEdit1.EditValue) = 0 Then
            MsgBox("請選擇付款方式")
            Exit Sub
        End If

        If Len(ComboBoxEdit2.EditValue) = 0 Then
            MsgBox("請選擇送貨方式")
            Exit Sub
        End If

        If Len(txtPMID.EditValue) = 0 Then
            MsgBox("不能生成單號，無法保存")
            Exit Sub
        End If

        Dim i As Integer
        Dim objInfo As New PurchaseMainInfo
        Dim mc As New PurchaseMainController

        If ds.Tables("Purchase").Rows.Count = 0 Then
            MsgBox("請選擇物料")
            Exit Sub
        End If

        For i = 0 To ds.Tables("Purchase").Rows.Count - 1
            If IsDBNull(ds.Tables("Purchase").Rows(i)("Q_QuoID")) Then
                MsgBox("請選擇報價單")
                Exit Sub
            End If

        Next


        '更新刪除的記錄
        If ds.Tables("DelData").Rows.Count > 0 Then
            For i = 0 To ds.Tables("DelData").Rows.Count - 1
                If Not IsDBNull(ds.Tables("DelData").Rows(i)("PS_NO")) Then

                    mc.PurchaseSub_Delete(Nothing, ds.Tables("DelData").Rows(i)("PS_NO"))

                End If
            Next i
        End If

        objInfo.PM_NO = txtPMID.EditValue
        objInfo.PM_Associate = cboName.EditValue
        Dim j%
        For j = 0 To 2
            If cboName.EditValue = S_Associate(j) Then
                objInfo.PM_Tel = S_Tel(j)
                objInfo.PM_Fax = S_Fax(j)
            End If
        Next
        objInfo.S_Supplier = gluSupplier.EditValue
        objInfo.PM_Type = "采購作業"

        objInfo.PM_PurchaseDate = DateEdit1.EditValue

        objInfo.PM_Remark = txtRemark.EditValue
        objInfo.PM_Action = InUserID
        objInfo.PM_ToFrom = ComboBoxEdit1.EditValue
        objInfo.PM_ComeType = ComboBoxEdit2.EditValue
        objInfo.PM_PurchaseType = ComboBoxEdit3.EditValue
        objInfo.PM_Rebate = TxtRebate.Text
        objInfo.PM_Check = False
        objInfo.PM_AccountCheck = False
        objInfo.PM_Version = CInt(Label2.Text)

        objInfo.CO_ID = gluCompany.EditValue


        If mc.PurchaseMain_Update(objInfo) = False Then
            MsgBox("保存失敗...")
            Exit Sub
        End If
        objInfo.C_ID = lueCurrency.EditValue

        For i = 0 To ds.Tables("Purchase").Rows.Count - 1
            If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_NO")) Then '新增
                objInfo.PS_NO = GetPS_No()
                If IsDBNull(ds.Tables("Purchase").Rows(i)("Q_QuoID")) Then
                    objInfo.Q_QuoID = Nothing
                Else
                    objInfo.Q_QuoID = ds.Tables("Purchase").Rows(i)("Q_QuoID")
                End If

                objInfo.M_Code = ds.Tables("Purchase").Rows(i)("M_Code")

                If IsDBNull(ds.Tables("Purchase").Rows(i)("S_SupplierNo")) Then
                    objInfo.S_SupplierNo = Nothing
                Else
                    objInfo.S_SupplierNo = ds.Tables("Purchase").Rows(i)("S_SupplierNo")
                End If

                If IsDBNull(ds.Tables("Purchase").Rows(i)("OS_BatchID")) Then
                    objInfo.OS_BatchID = Nothing
                Else
                    objInfo.OS_BatchID = ds.Tables("Purchase").Rows(i)("OS_BatchID")
                End If
                'objInfo.M_Unit = ds.Tables("Purchase").Rows(i)("M_Unit")
                'objInfo.M_Name = ds.Tables("Purchase").Rows(i)("M_Name")
                'If IsDBNull(ds.Tables("Purchase").Rows(i)("M_Gauge")) Then
                '    objInfo.M_Gauge = Nothing
                'Else
                '    objInfo.M_Gauge = ds.Tables("Purchase").Rows(i)("M_Gauge")
                'End If
                If IsDBNull(ds.Tables("Purchase").Rows(i)("PN_NO")) Then
                    objInfo.PN_NO = Nothing
                Else
                    objInfo.PN_NO = ds.Tables("Purchase").Rows(i)("PN_NO")
                End If
                If IsDBNull(ds.Tables("Purchase").Rows(i)("DPT_ID")) Then
                    objInfo.DPT_ID = Nothing
                Else
                    objInfo.DPT_ID = ds.Tables("Purchase").Rows(i)("DPT_ID")
                End If
                If IsDBNull(ds.Tables("Purchase").Rows(i)("U_ID")) Then
                    objInfo.U_ID = Nothing
                Else
                    objInfo.U_ID = ds.Tables("Purchase").Rows(i)("U_ID")
                End If
                If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_NeedPurchaseUse")) Then
                    objInfo.PS_NeedPurchaseUse = Nothing
                Else
                    objInfo.PS_NeedPurchaseUse = ds.Tables("Purchase").Rows(i)("PS_NeedPurchaseUse")
                End If
                objInfo.PS_QTY = CDbl(ds.Tables("Purchase").Rows(i)("PS_QTY"))
                objInfo.PS_NoSendQty = CDbl(ds.Tables("Purchase").Rows(i)("PS_QTY"))
                objInfo.PS_Price = CDbl(ds.Tables("Purchase").Rows(i)("PS_Price"))
                objInfo.PS_SendDate = ds.Tables("Purchase").Rows(i)("PS_SendDate")
                If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_Depict")) Then
                    objInfo.PS_Depict = Nothing
                Else
                    objInfo.PS_Depict = ds.Tables("Purchase").Rows(i)("PS_Depict")
                End If

                If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_Detail")) Then
                    objInfo.PS_Detail = Nothing
                Else
                    objInfo.PS_Detail = ds.Tables("Purchase").Rows(i)("PS_Detail")
                End If


                objInfo.PS_Tarriff = CDbl(TarriffEdit.EditValue)
                objInfo.PS_TffCost = CDbl(objInfo.PS_QTY * objInfo.PS_Price * objInfo.PS_Tarriff)
                objInfo.PS_AmountBf = CDbl(objInfo.PS_QTY * objInfo.PS_Price)
                objInfo.PS_AmountAf = objInfo.PS_AmountBf - objInfo.PS_TffCost

                If IsDBNull(ds.Tables("Purchase").Rows(i)("PM_M_Code")) Then
                    objInfo.PM_M_Code = Nothing
                Else
                    objInfo.PM_M_Code = ds.Tables("Purchase").Rows(i)("PM_M_Code")
                End If



                mc.PurchaseSub_Add(objInfo)

            ElseIf Not IsDBNull(ds.Tables("Purchase").Rows(i)("PS_NO")) Then '修改

                objInfo.PS_NO = ds.Tables("Purchase").Rows(i)("PS_NO")

                If IsDBNull(ds.Tables("Purchase").Rows(i)("Q_QuoID")) Then
                    objInfo.Q_QuoID = Nothing
                Else
                    objInfo.Q_QuoID = ds.Tables("Purchase").Rows(i)("Q_QuoID")
                End If

                objInfo.M_Code = ds.Tables("Purchase").Rows(i)("M_Code")

                If IsDBNull(ds.Tables("Purchase").Rows(i)("S_SupplierNo")) Then
                    objInfo.S_SupplierNo = Nothing
                Else
                    objInfo.S_SupplierNo = ds.Tables("Purchase").Rows(i)("S_SupplierNo")
                End If

                If IsDBNull(ds.Tables("Purchase").Rows(i)("OS_BatchID")) Then
                    objInfo.OS_BatchID = Nothing
                Else
                    objInfo.OS_BatchID = ds.Tables("Purchase").Rows(i)("OS_BatchID")
                End If
                'objInfo.M_Unit = ds.Tables("Purchase").Rows(i)("M_Unit")
                'objInfo.M_Name = ds.Tables("Purchase").Rows(i)("M_Name")
                'If IsDBNull(ds.Tables("Purchase").Rows(i)("M_Gauge")) Then
                '    objInfo.M_Gauge = Nothing
                'Else
                '    objInfo.M_Gauge = ds.Tables("Purchase").Rows(i)("M_Gauge")
                'End If
                If IsDBNull(ds.Tables("Purchase").Rows(i)("PN_NO")) Then
                    objInfo.PN_NO = Nothing
                Else
                    objInfo.PN_NO = ds.Tables("Purchase").Rows(i)("PN_NO")
                End If
                If IsDBNull(ds.Tables("Purchase").Rows(i)("DPT_ID")) Then
                    objInfo.DPT_ID = Nothing
                Else
                    objInfo.DPT_ID = ds.Tables("Purchase").Rows(i)("DPT_ID")
                End If
                If IsDBNull(ds.Tables("Purchase").Rows(i)("U_ID")) Then
                    objInfo.U_ID = Nothing
                Else
                    objInfo.U_ID = ds.Tables("Purchase").Rows(i)("U_ID")
                End If
                If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_NeedPurchaseUse")) Then
                    objInfo.PS_NeedPurchaseUse = Nothing
                Else
                    objInfo.PS_NeedPurchaseUse = ds.Tables("Purchase").Rows(i)("PS_NeedPurchaseUse")
                End If
                objInfo.PS_QTY = CDbl(ds.Tables("Purchase").Rows(i)("PS_QTY"))
                objInfo.PS_NoSendQty = CDbl(ds.Tables("Purchase").Rows(i)("PS_QTY"))
                objInfo.PS_Price = CDbl(ds.Tables("Purchase").Rows(i)("PS_Price"))
                objInfo.PS_SendDate = ds.Tables("Purchase").Rows(i)("PS_SendDate")
                If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_Depict")) Then
                    objInfo.PS_Depict = Nothing
                Else
                    objInfo.PS_Depict = ds.Tables("Purchase").Rows(i)("PS_Depict")
                End If

                If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_Detail")) Then
                    objInfo.PS_Detail = Nothing
                Else
                    objInfo.PS_Detail = ds.Tables("Purchase").Rows(i)("PS_Detail")
                End If


                objInfo.PS_Tarriff = CDbl(TarriffEdit.EditValue)
                objInfo.PS_TffCost = CDbl(objInfo.PS_QTY * objInfo.PS_Price * objInfo.PS_Tarriff)
                objInfo.PS_AmountBf = CDbl(objInfo.PS_QTY * objInfo.PS_Price)
                objInfo.PS_AmountAf = objInfo.PS_AmountBf - objInfo.PS_TffCost

                If IsDBNull(ds.Tables("Purchase").Rows(i)("PM_M_Code")) Then
                    objInfo.PM_M_Code = Nothing
                Else
                    objInfo.PM_M_Code = ds.Tables("Purchase").Rows(i)("PM_M_Code")
                End If


                mc.PurchaseSub_Update(objInfo)

            End If
        Next
        MsgBox("數據保存成功!", 64, "提示")
        Me.Close()

    End Sub '保存修改


    Sub UpdateCheck()
        Dim i As Integer

        Dim objInfo As New PurchaseMainInfo
        Dim mc As New PurchaseMainController

        Dim iList As List(Of FilesInfo)
        Dim dt As New FileController
        iList = dt.FileBond_GetList("4002", txtPMID.EditValue, Nothing)

        If iList.Count = 0 Then
            MsgBox("沒有附加文檔,不允許審核,請添加附檔!")
            Exit Sub
        End If


        objInfo.PM_NO = txtPMID.EditValue
        objInfo.PM_Check = CheckEdit1.Checked
        objInfo.PM_CheckType = CBEdit4.Text
        objInfo.PM_CheckRemark = CheckRemark.Text
        objInfo.PM_CheckDate = Format(Now, "yyyy/MM/dd")
        objInfo.PM_CheckAction = InUserID

        If objInfo.PM_Check = True Then
            objInfo.PM_Version = CInt(Label2.Text) + 1

            '部門審核通過時，把單價更新到物料表裡
            If CheckEdit1.Checked = True Then
                For i = 0 To ds.Tables("Purchase").Rows.Count - 1
                    Dim mm As New MaterialController

                    mm.MaterialCode_UpdatePrice(ds.Tables("Purchase").Rows(i)("M_Code"), CDbl(ds.Tables("Purchase").Rows(i)("PS_Price")), lueCurrency.EditValue, gluSupplier.EditValue, ds.Tables("Purchase").Rows(i)("S_SupplierNo"))

                    '------------------------------------------------------更新當前物料最新採購日期
                    Dim mmi As New MaterialInfo
                    mmi.M_Code = ds.Tables("Purchase").Rows(i)("M_Code")
                    mmi.M_FinalDate = Format(Now, "yyyy/MM/dd")
                    mm.MaterialCode_UpdateFinalDate(mmi)
                    '------------------------------------------------------

                    '------------------------------------------------------
                    '判斷當前物料單價信息是否在表MaterialPrice中,存在--不執行
                    '不存在--執行一下操作(將採購審核后的物料單價添加至表中)
                    '------------------------------------------------------
                    Dim mi As New MaterialInfo
                    Dim mii As List(Of MaterialInfo)
                    Dim mtc As New MaterialController

                    mii = mtc.MaterialPrice_GetList(ds.Tables("Purchase").Rows(i)("M_Code"), Nothing, Nothing)
                    If mii.Count > 0 Then
                    Else

                        mi.M_Code = ds.Tables("Purchase").Rows(i)("M_Code")
                        mi.M_Price = ds.Tables("Purchase").Rows(i)("PS_Price")
                        mi.M_Currency = lueCurrency.EditValue
                        mi.M_ChangeDate = Format(Now, "yyyy/MM/dd")

                        mtc.MaterialPrice_Add(mi)

                    End If


                    '------------------------------------------------------
                Next
            End If

        ElseIf objInfo.PM_Check = False Then
            objInfo.PM_Version = CInt(Label2.Text)
        End If


        If mc.PurchaseMain_UpdateCheck(objInfo) = False Then
            MsgBox("審核失敗......")
            Exit Sub
        End If
        Me.Close()
    End Sub '保存部門審核

    Sub ManualUpdateCheck()  '手開單採購審核

        Dim objInfo As New PurchaseMainInfo
        Dim mc As New PurchaseMainController
        Dim i As Integer

        Dim iList As List(Of FilesInfo)
        Dim dt As New FileController
        iList = dt.FileBond_GetList("4008", txtPMID.EditValue, Nothing)

        If iList.Count = 0 Then
            MsgBox("沒有附加文檔,不允許審核,請添加附檔!")
            Exit Sub
        End If

        objInfo.PM_NO = txtPMID.EditValue
        objInfo.PM_Check = CheckEdit1.Checked
        objInfo.PM_CheckType = CBEdit4.Text
        objInfo.PM_CheckRemark = CheckRemark.Text
        objInfo.PM_CheckDate = Format(Now, "yyyy/MM/dd")
        objInfo.PM_CheckAction = InUserID

        If objInfo.PM_Check = True Then
            objInfo.PM_Version = CInt(Label2.Text) + 1

            For i = 0 To ds.Tables("Purchase").Rows.Count - 1
                Dim mm As New MaterialController
                mm.MaterialCode_UpdatePrice(ds.Tables("Purchase").Rows(i)("M_Code"), CDbl(ds.Tables("Purchase").Rows(i)("PS_Price")), lueCurrency.EditValue, gluSupplier.EditValue, ds.Tables("Purchase").Rows(i)("S_SupplierNo"))

                '------------------------------------------------------更新當前物料最新採購日期
                Dim mmi As New MaterialInfo
                mmi.M_Code = ds.Tables("Purchase").Rows(i)("M_Code")
                mmi.M_FinalDate = Format(Now, "yyyy/MM/dd")
                mm.MaterialCode_UpdateFinalDate(mmi)
                '------------------------------------------------------

                '------------------------------------------------------
                '判斷當前物料單價信息是否在表MaterialPrice中,存在--不執行
                '不存在--執行一下操作(將採購審核后的物料單價添加至表中)
                '------------------------------------------------------
                Dim mi As New MaterialInfo
                Dim mii As List(Of MaterialInfo)
                Dim mtc As New MaterialController

                mii = mtc.MaterialPrice_GetList(ds.Tables("Purchase").Rows(i)("M_Code"), Nothing, Nothing)
                If mii.Count > 0 Then

                Else

                    mi.M_Code = ds.Tables("Purchase").Rows(i)("M_Code")
                    mi.M_Price = ds.Tables("Purchase").Rows(i)("PS_Price")
                    mi.M_Currency = lueCurrency.EditValue
                    mi.M_ChangeDate = Format(Now, "yyyy/MM/dd")

                    mtc.MaterialPrice_Add(mi)

                End If


                '------------------------------------------------------
            Next

        ElseIf objInfo.PM_Check = False Then
            objInfo.PM_Version = CInt(Label2.Text)
        End If

        If mc.PurchaseMain_UpdateCheck(objInfo) = False Then
            MsgBox("審核失敗......")
            Exit Sub
        End If
        Me.Close()
    End Sub
    Sub UpdateAccCheck()

        Dim objInfo As New PurchaseMainInfo
        Dim mc As New PurchaseMainController

        objInfo.PM_NO = txtPMID.EditValue
        objInfo.PM_AccountCheck = CheckEdit2.Checked
        objInfo.PM_AccountCheckType = ACheckType.Text
        objInfo.PM_AccountCheckRemark = MemoEdit2.Text
        objInfo.PM_AccountCheckDate = Format(Now, "yyyy/MM/dd")
        objInfo.PM_AccountCheckAction = InUserID


        If mc.PurchaseMain_UpdateAccCheck(objInfo) = False Then
            MsgBox("審核失敗......")
            Exit Sub
        End If
        Me.Close()
    End Sub '保存會計審核
    Sub ManualDataNew() '手開採購單新增
        'On Error Resume Next


        If Len(gluCompany.EditValue) = 0 Then
            MsgBox("請選擇公司")
            Exit Sub
        End If

        If Len(gluSupplier.EditValue) = 0 Then
            MsgBox("請選擇供應商")
            Exit Sub
        End If

        If Len(ComboBoxEdit3.EditValue) = 0 Then
            MsgBox("請選擇採購類型")
            Exit Sub
        End If

        If Len(lueCurrency.EditValue) = 0 Then
            MsgBox("請選擇幣別")
            Exit Sub
        End If

        If Len(ComboBoxEdit1.EditValue) = 0 Then
            MsgBox("請選擇付款方式")
            Exit Sub
        End If

        If Len(ComboBoxEdit2.EditValue) = 0 Then
            MsgBox("請選擇送貨方式")
            Exit Sub
        End If

        Dim i As Integer
        'For i = 0 To ds.Tables("Purchase").Rows.Count - 1
        '    If IsDBNull(ds.Tables("Purchase").Rows(i)("Q_QuoID")) Then
        '        MsgBox("請選擇報價單")
        '        Exit Sub
        '    End If

        'Next

        Dim mc As New PurchaseMainController
        txtPMID.EditValue = GetManual_NO() '取得單號"
        Dim objinfo As New PurchaseMainInfo

        If ds.Tables("Purchase").Rows.Count = 0 Then
            MsgBox("請選擇物料")
            Exit Sub
        End If

        If Len(txtPMID.EditValue) = 0 Then

            MsgBox("不能生成單號，無法保存")
            Exit Sub
        End If

        objinfo.PM_NO = txtPMID.EditValue
        objinfo.PM_Associate = cboName.EditValue
        Dim j%
        For j = 0 To 2
            If cboName.EditValue = S_Associate(j) Then
                objinfo.PM_Tel = S_Tel(j)
                objinfo.PM_Fax = S_Fax(j)
            End If
        Next
        objinfo.S_Supplier = gluSupplier.EditValue
        objinfo.PM_Type = "手開採購單"

        objinfo.PM_PurchaseDate = DateEdit1.EditValue

        objinfo.PM_Remark = txtRemark.EditValue
        objinfo.PM_Action = InUserID
        objinfo.PM_ToFrom = ComboBoxEdit1.EditValue
        objinfo.PM_ComeType = ComboBoxEdit2.EditValue
        objinfo.PM_PurchaseType = ComboBoxEdit3.EditValue
        objinfo.PM_Rebate = TxtRebate.Text
        objinfo.PM_Check = False
        objinfo.PM_AccountCheck = False
        objinfo.PM_Version = 0

        objinfo.CO_ID = gluCompany.EditValue

        If mc.PurchaseMain_Add(objinfo) = False Then
            MsgBox("保存失敗...")
            Exit Sub
        End If
        objinfo.C_ID = lueCurrency.EditValue '``````````````````````````````````````````幣別


        For i = 0 To ds.Tables("Purchase").Rows.Count - 1

            objinfo.PS_NO = GetPS_No()

            If IsDBNull(ds.Tables("Purchase").Rows(i)("Q_QuoID")) Then
                objinfo.Q_QuoID = Nothing
            Else
                objinfo.Q_QuoID = ds.Tables("Purchase").Rows(i)("Q_QuoID")
            End If

            objinfo.M_Code = ds.Tables("Purchase").Rows(i)("M_Code")

            If IsDBNull(ds.Tables("Purchase").Rows(i)("S_SupplierNo")) Then
                objinfo.S_SupplierNo = Nothing
            Else
                objinfo.S_SupplierNo = ds.Tables("Purchase").Rows(i)("S_SupplierNo")
            End If

            If IsDBNull(ds.Tables("Purchase").Rows(i)("OS_BatchID")) Then
                objinfo.OS_BatchID = Nothing
            Else
                objinfo.OS_BatchID = ds.Tables("Purchase").Rows(i)("OS_BatchID")
            End If
            'objinfo.M_Unit = ds.Tables("Purchase").Rows(i)("M_Unit")
            'objinfo.M_Name = ds.Tables("Purchase").Rows(i)("M_Name")
            'If IsDBNull(ds.Tables("Purchase").Rows(i)("M_Gauge")) Then
            '    objinfo.M_Gauge = Nothing
            'Else
            '    objinfo.M_Gauge = ds.Tables("Purchase").Rows(i)("M_Gauge")
            'End If
            If IsDBNull(ds.Tables("Purchase").Rows(i)("PN_NO")) Then
                objinfo.PN_NO = Nothing
            Else
                objinfo.PN_NO = ds.Tables("Purchase").Rows(i)("PN_NO")
            End If
            If IsDBNull(ds.Tables("Purchase").Rows(i)("DPT_ID")) Then
                objinfo.DPT_ID = Nothing
            Else
                objinfo.DPT_ID = ds.Tables("Purchase").Rows(i)("DPT_ID")
            End If
            If IsDBNull(ds.Tables("Purchase").Rows(i)("U_ID")) Then
                objinfo.U_ID = Nothing
            Else
                objinfo.U_ID = ds.Tables("Purchase").Rows(i)("U_ID")
            End If
            If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_NeedPurchaseUse")) Then
                objinfo.PS_NeedPurchaseUse = Nothing
            Else
                objinfo.PS_NeedPurchaseUse = ds.Tables("Purchase").Rows(i)("PS_NeedPurchaseUse")
            End If
            objinfo.PS_QTY = CDbl(ds.Tables("Purchase").Rows(i)("PS_QTY"))
            objinfo.PS_NoSendQty = CDbl(ds.Tables("Purchase").Rows(i)("PS_QTY"))
            objinfo.PS_Price = CDbl(ds.Tables("Purchase").Rows(i)("PS_Price"))
            objinfo.PS_SendDate = ds.Tables("Purchase").Rows(i)("PS_SendDate")
            If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_Depict")) Then
                objinfo.PS_Depict = Nothing
            Else
                objinfo.PS_Depict = ds.Tables("Purchase").Rows(i)("PS_Depict")
            End If

            If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_Detail")) Then
                objinfo.PS_Detail = Nothing
            Else
                objinfo.PS_Detail = ds.Tables("Purchase").Rows(i)("PS_Detail")
            End If


            objinfo.PS_Tarriff = CDbl(TarriffEdit.EditValue)
            objinfo.PS_TffCost = CDbl(objinfo.PS_QTY * objinfo.PS_Price * objinfo.PS_Tarriff)
            objinfo.PS_AmountBf = CDbl(objinfo.PS_QTY * objinfo.PS_Price)
            objinfo.PS_AmountAf = objinfo.PS_AmountBf - objinfo.PS_TffCost

            If IsDBNull(ds.Tables("Purchase").Rows(i)("PM_M_Code")) Then
                objinfo.PM_M_Code = Nothing
            Else
                objinfo.PM_M_Code = ds.Tables("Purchase").Rows(i)("PM_M_Code")
            End If


            If mc.PurchaseSub_Add(objinfo) = False Then
                MsgBox("保存失敗...")
                Exit Sub
            End If
        Next

        Me.Close()
        '保存新增資料
    End Sub
    Sub ManualDataEdit() '手開採購單修改
        'On Error Resume Next

        If Len(gluCompany.EditValue) = 0 Then
            MsgBox("請選擇公司")
            Exit Sub
        End If

        If Len(gluSupplier.EditValue) = 0 Then
            MsgBox("請選擇供應商")
            Exit Sub
        End If

        If Len(ComboBoxEdit3.EditValue) = 0 Then
            MsgBox("請選擇採購類型")
            Exit Sub
        End If

        If Len(lueCurrency.EditValue) = 0 Then
            MsgBox("請選擇幣別")
            Exit Sub
        End If

        If Len(ComboBoxEdit1.EditValue) = 0 Then
            MsgBox("請選擇付款方式")
            Exit Sub
        End If

        If Len(ComboBoxEdit2.EditValue) = 0 Then
            MsgBox("請選擇送貨方式")
            Exit Sub
        End If

        If Len(txtPMID.EditValue) = 0 Then
            MsgBox("不能生成單號，無法保存")
            Exit Sub
        End If

        Dim i As Integer
        Dim objInfo As New PurchaseMainInfo
        Dim mc As New PurchaseMainController

        If ds.Tables("Purchase").Rows.Count = 0 Then
            MsgBox("請選擇物料")
            Exit Sub
        End If

        'For i = 0 To ds.Tables("Purchase").Rows.Count - 1
        '    If IsDBNull(ds.Tables("Purchase").Rows(i)("Q_QuoID")) Then
        '        MsgBox("請選擇報價單")
        '        Exit Sub
        '    End If

        'Next


        '更新刪除的記錄
        If ds.Tables("DelData").Rows.Count > 0 Then
            For i = 0 To ds.Tables("DelData").Rows.Count - 1
                If Not IsDBNull(ds.Tables("DelData").Rows(i)("PS_NO")) Then

                    mc.PurchaseSub_Delete(Nothing, ds.Tables("DelData").Rows(i)("PS_NO"))

                End If
            Next i
        End If

        objInfo.PM_NO = txtPMID.EditValue
        objInfo.PM_Associate = cboName.EditValue
        Dim j%
        For j = 0 To 2
            If cboName.EditValue = S_Associate(j) Then
                objInfo.PM_Tel = S_Tel(j)
                objInfo.PM_Fax = S_Fax(j)
            End If
        Next
        objInfo.S_Supplier = gluSupplier.EditValue
        objInfo.PM_Type = "手開採購單"

        objInfo.PM_PurchaseDate = DateEdit1.EditValue

        objInfo.PM_Remark = txtRemark.EditValue
        objInfo.PM_Action = InUserID
        objInfo.PM_ToFrom = ComboBoxEdit1.EditValue
        objInfo.PM_ComeType = ComboBoxEdit2.EditValue
        objInfo.PM_PurchaseType = ComboBoxEdit3.EditValue
        objInfo.PM_Rebate = TxtRebate.Text
        objInfo.PM_Check = False
        objInfo.PM_AccountCheck = False
        objInfo.PM_Version = CInt(Label2.Text)

        objInfo.CO_ID = gluCompany.EditValue


        If mc.PurchaseMain_Update(objInfo) = False Then
            MsgBox("保存失敗...")
            Exit Sub
        End If
        objInfo.C_ID = lueCurrency.EditValue

        For i = 0 To ds.Tables("Purchase").Rows.Count - 1
            If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_NO")) Then '新增
                objInfo.PS_NO = GetPS_No()
                If IsDBNull(ds.Tables("Purchase").Rows(i)("Q_QuoID")) Then
                    objInfo.Q_QuoID = Nothing
                Else
                    objInfo.Q_QuoID = ds.Tables("Purchase").Rows(i)("Q_QuoID")
                End If

                objInfo.M_Code = ds.Tables("Purchase").Rows(i)("M_Code")

                If IsDBNull(ds.Tables("Purchase").Rows(i)("S_SupplierNo")) Then
                    objInfo.S_SupplierNo = Nothing
                Else
                    objInfo.S_SupplierNo = ds.Tables("Purchase").Rows(i)("S_SupplierNo")
                End If

                If IsDBNull(ds.Tables("Purchase").Rows(i)("OS_BatchID")) Then
                    objInfo.OS_BatchID = Nothing
                Else
                    objInfo.OS_BatchID = ds.Tables("Purchase").Rows(i)("OS_BatchID")
                End If
                'objInfo.M_Unit = ds.Tables("Purchase").Rows(i)("M_Unit")
                'objInfo.M_Name = ds.Tables("Purchase").Rows(i)("M_Name")
                'If IsDBNull(ds.Tables("Purchase").Rows(i)("M_Gauge")) Then
                '    objInfo.M_Gauge = Nothing
                'Else
                '    objInfo.M_Gauge = ds.Tables("Purchase").Rows(i)("M_Gauge")
                'End If
                If IsDBNull(ds.Tables("Purchase").Rows(i)("PN_NO")) Then
                    objInfo.PN_NO = Nothing
                Else
                    objInfo.PN_NO = ds.Tables("Purchase").Rows(i)("PN_NO")
                End If
                If IsDBNull(ds.Tables("Purchase").Rows(i)("DPT_ID")) Then
                    objInfo.DPT_ID = Nothing
                Else
                    objInfo.DPT_ID = ds.Tables("Purchase").Rows(i)("DPT_ID")
                End If
                If IsDBNull(ds.Tables("Purchase").Rows(i)("U_ID")) Then
                    objInfo.U_ID = Nothing
                Else
                    objInfo.U_ID = ds.Tables("Purchase").Rows(i)("U_ID")
                End If
                If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_NeedPurchaseUse")) Then
                    objInfo.PS_NeedPurchaseUse = Nothing
                Else
                    objInfo.PS_NeedPurchaseUse = ds.Tables("Purchase").Rows(i)("PS_NeedPurchaseUse")
                End If
                objInfo.PS_QTY = CDbl(ds.Tables("Purchase").Rows(i)("PS_QTY"))
                objInfo.PS_NoSendQty = CDbl(ds.Tables("Purchase").Rows(i)("PS_QTY"))
                objInfo.PS_Price = CDbl(ds.Tables("Purchase").Rows(i)("PS_Price"))
                objInfo.PS_SendDate = ds.Tables("Purchase").Rows(i)("PS_SendDate")
                If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_Depict")) Then
                    objInfo.PS_Depict = Nothing
                Else
                    objInfo.PS_Depict = ds.Tables("Purchase").Rows(i)("PS_Depict")
                End If

                If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_Detail")) Then
                    objInfo.PS_Detail = Nothing
                Else
                    objInfo.PS_Detail = ds.Tables("Purchase").Rows(i)("PS_Detail")
                End If


                objInfo.PS_Tarriff = CDbl(TarriffEdit.EditValue)
                objInfo.PS_TffCost = CDbl(objInfo.PS_QTY * objInfo.PS_Price * objInfo.PS_Tarriff)
                objInfo.PS_AmountBf = CDbl(objInfo.PS_QTY * objInfo.PS_Price)
                objInfo.PS_AmountAf = objInfo.PS_AmountBf - objInfo.PS_TffCost

                If IsDBNull(ds.Tables("Purchase").Rows(i)("PM_M_Code")) Then
                    objInfo.PM_M_Code = Nothing
                Else
                    objInfo.PM_M_Code = ds.Tables("Purchase").Rows(i)("PM_M_Code")
                End If



                mc.PurchaseSub_Add(objInfo)

            ElseIf Not IsDBNull(ds.Tables("Purchase").Rows(i)("PS_NO")) Then '修改

                objInfo.PS_NO = ds.Tables("Purchase").Rows(i)("PS_NO")

                If IsDBNull(ds.Tables("Purchase").Rows(i)("Q_QuoID")) Then
                    objInfo.Q_QuoID = Nothing
                Else
                    objInfo.Q_QuoID = ds.Tables("Purchase").Rows(i)("Q_QuoID")
                End If

                objInfo.M_Code = ds.Tables("Purchase").Rows(i)("M_Code")

                If IsDBNull(ds.Tables("Purchase").Rows(i)("S_SupplierNo")) Then
                    objInfo.S_SupplierNo = Nothing
                Else
                    objInfo.S_SupplierNo = ds.Tables("Purchase").Rows(i)("S_SupplierNo")
                End If

                If IsDBNull(ds.Tables("Purchase").Rows(i)("OS_BatchID")) Then
                    objInfo.OS_BatchID = Nothing
                Else
                    objInfo.OS_BatchID = ds.Tables("Purchase").Rows(i)("OS_BatchID")
                End If
                'objInfo.M_Unit = ds.Tables("Purchase").Rows(i)("M_Unit")
                'objInfo.M_Name = ds.Tables("Purchase").Rows(i)("M_Name")
                'If IsDBNull(ds.Tables("Purchase").Rows(i)("M_Gauge")) Then
                '    objInfo.M_Gauge = Nothing
                'Else
                '    objInfo.M_Gauge = ds.Tables("Purchase").Rows(i)("M_Gauge")
                'End If
                If IsDBNull(ds.Tables("Purchase").Rows(i)("PN_NO")) Then
                    objInfo.PN_NO = Nothing
                Else
                    objInfo.PN_NO = ds.Tables("Purchase").Rows(i)("PN_NO")
                End If
                If IsDBNull(ds.Tables("Purchase").Rows(i)("DPT_ID")) Then
                    objInfo.DPT_ID = Nothing
                Else
                    objInfo.DPT_ID = ds.Tables("Purchase").Rows(i)("DPT_ID")
                End If
                If IsDBNull(ds.Tables("Purchase").Rows(i)("U_ID")) Then
                    objInfo.U_ID = Nothing
                Else
                    objInfo.U_ID = ds.Tables("Purchase").Rows(i)("U_ID")
                End If
                If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_NeedPurchaseUse")) Then
                    objInfo.PS_NeedPurchaseUse = Nothing
                Else
                    objInfo.PS_NeedPurchaseUse = ds.Tables("Purchase").Rows(i)("PS_NeedPurchaseUse")
                End If
                objInfo.PS_QTY = CDbl(ds.Tables("Purchase").Rows(i)("PS_QTY"))
                objInfo.PS_NoSendQty = CDbl(ds.Tables("Purchase").Rows(i)("PS_QTY"))
                objInfo.PS_Price = CDbl(ds.Tables("Purchase").Rows(i)("PS_Price"))
                objInfo.PS_SendDate = ds.Tables("Purchase").Rows(i)("PS_SendDate")
                If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_Depict")) Then
                    objInfo.PS_Depict = Nothing
                Else
                    objInfo.PS_Depict = ds.Tables("Purchase").Rows(i)("PS_Depict")
                End If

                If IsDBNull(ds.Tables("Purchase").Rows(i)("PS_Detail")) Then
                    objInfo.PS_Detail = Nothing
                Else
                    objInfo.PS_Detail = ds.Tables("Purchase").Rows(i)("PS_Detail")
                End If


                objInfo.PS_Tarriff = CDbl(TarriffEdit.EditValue)
                objInfo.PS_TffCost = CDbl(objInfo.PS_QTY * objInfo.PS_Price * objInfo.PS_Tarriff)
                objInfo.PS_AmountBf = CDbl(objInfo.PS_QTY * objInfo.PS_Price)
                objInfo.PS_AmountAf = objInfo.PS_AmountBf - objInfo.PS_TffCost

                If IsDBNull(ds.Tables("Purchase").Rows(i)("PM_M_Code")) Then
                    objInfo.PM_M_Code = Nothing
                Else
                    objInfo.PM_M_Code = ds.Tables("Purchase").Rows(i)("PM_M_Code")
                End If


                mc.PurchaseSub_Update(objInfo)

            End If
        Next
        MsgBox("數據保存成功!", 64, "提示")
        Me.Close()

        '保存修改
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
  
        Select Case Label24.Text
            Case "採購單"
                
                If Edit = True Then
                    Select Case Label28.Text
                        Case "采購作業"
                            SaveDataEdit()
                        Case "手開採購單"
                            ManualDataEdit()
                    End Select
                Else
                    If GridView1.RowCount = 0 Then
                        MsgBox("請先添加記錄!", 64, "提示")
                    Else
                        Dim sc As New LFERP.DataSetting.SuppliersControler
                        Dim si As New LFERP.DataSetting.SuppliersInfo
                        si = sc.Suppliers_Get(gluSupplier.EditValue, Nothing)
                        If si.S_Rank <> "A" Then
                            MsgBox("非A級供應商, 不能購買!", MsgBoxStyle.OkOnly)
                            Exit Sub
                        End If


                        Select Case Label28.Text
                            Case "采購作業"
                                SaveDataNew()
                            Case "手開採購單"
                                ManualDataNew()
                        End Select
                    End If
                End If

            Case "部門審核"

                Select Case Label28.Text
                    Case "采購作業"
                        UpdateCheck()
                    Case "手開採購單"
                        ManualUpdateCheck()
                End Select

            Case "會計部審核"
                UpdateAccCheck()

        End Select

    End Sub

    Private Sub QuoIDbutton_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles QuoIDbutton.ButtonClick

        On Error Resume Next
        tempValue = ds.Tables("Purchase").Rows(GridView1.FocusedRowHandle)("M_Code").ToString
        tempValue2 = gluSupplier.EditValue
        Dim fr As New FrmQuotationHistory
        fr.ShowDialog()

        If Len(fr.SelectQuoID) <> 0 Then
            ds.Tables("Purchase").Rows(GridView1.FocusedRowHandle)("Q_QuoID") = fr.SelectQuoID
        End If

        If Len(fr.SelectSupplierNo) <> 0 Then
            ds.Tables("Purchase").Rows(GridView1.FocusedRowHandle)("S_SupplierNo") = fr.SelectSupplierNo
        End If
        If fr.SelectPrice <> 0 Then

            ds.Tables("Purchase").Rows(GridView1.FocusedRowHandle)("PS_Price") = fr.SelectPrice

        End If
        If fr.SelectMOQ <> 0 Then
            ds.Tables("Purchase").Rows(GridView1.FocusedRowHandle)("Q_MOQ") = fr.SelectMOQ
        End If
        If fr.SelectStandardPack <> 0 Then
            ds.Tables("Purchase").Rows(GridView1.FocusedRowHandle)("Q_StandardPack") = fr.SelectStandardPack
        End If


    End Sub

    Private Sub popFileShowOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popFileShowOpen.Click
        '打開選擇文件
        Dim dt As New FileController
        If GridFile.Rows.Count = 0 Then Exit Sub

        'If strTemp = "非采購人員" And Microsoft.VisualBasic.Left(GridFile.CurrentRow.Cells("F_Detail").Value.ToString, 1) = "Q" Then
        '    popFileShowOpen.Enabled = False
        'Else
        '    popFileShowOpen.Enabled = True

        'End If
        dt.File_Open(Nothing, Nothing, GridFile.CurrentRow.Cells("F_No").Value.ToString)

    End Sub

    Sub LoadFileDisplay(ByVal BZShow As String, ByVal BZShow2 As String)
        '加載附件供顯示
        GridFile.AutoGenerateColumns = False
        GridFile.RowHeadersWidth = 15
        Dim dt As FileController
        Dim i As Integer
        Dim strFileNoList As String
        Dim iList As List(Of FilesInfo)
        Dim l As Integer
        strFileNoList = ""
        '加載報價單單號清單

        '2013-4-17 加報價附件顯示---------------------------------------------
        If BZShow = "" Then
        Else
            For i = 0 To GridView1.RowCount - 1
                dt = New FileController
                iList = dt.FileBond_GetList("4001", GridView1.GetRowCellDisplayText(i, "Q_QuoID"), Nothing)
                For l = 0 To iList.Count - 1
                    strFileNoList = strFileNoList & "," & iList(l).F_No
                Next
            Next
        End If


        '加載采購單單號清單
        dt = New FileController
        If Mid(txtPMID.EditValue, 1, 2) = "PM" Then
            iList = dt.FileBond_GetList("4002", txtPMID.EditValue, Nothing)
            For i = 0 To iList.Count - 1

                'strFileNoList = strFileNoList & "," & iList(i).F_No
                '------------------------------------------------------------------------------------
                If BZShow2 = "" Then '
                    '采購單中LF的試用報告

                    Dim strF_NameA As String = "AAA"  '為防止孌量為空
                    Dim strF_DetailA As String = "AAA"

                    If iList(i).F_Detail <> "" Then strF_DetailA = iList(i).F_Detail
                    If iList(i).F_Name <> "" Then strF_NameA = iList(i).F_Name

                    If Mid(strF_DetailA, 1, 2) = "LF" Or Mid(strF_NameA, 1, 2) = "LF" Then
                    Else
                        strFileNoList = strFileNoList & "," & iList(i).F_No
                    End If
                Else
                    strFileNoList = strFileNoList & "," & iList(i).F_No
                End If
                '---------------------------------------------------------------


            Next
        ElseIf Mid(txtPMID.EditValue, 1, 2) = "PF" Then
            iList = dt.FileBond_GetList("4008", txtPMID.EditValue, Nothing)
            For i = 0 To iList.Count - 1

                If BZShow = "" Then '
                    '手開采購單中,文件名中包含"報價"字樣的,無權限的不顯示2013-7-1

                    Dim strF_Name As String = "AAA"  '為防止孌量為空
                    Dim strF_Detail As String = "AAA"

                    If iList(i).F_Detail <> "" Then strF_Detail = iList(i).F_Detail
                    If iList(i).F_Name <> "" Then strF_Name = iList(i).F_Name

                    If InStr(strF_Detail, "報價", CompareMethod.Text) > 0 Or InStr(strF_Name, "報價", CompareMethod.Text) > 0 Or Mid(strF_Detail, 1, 2) = "LF" Or Mid(strF_Name, 1, 2) = "LF" Then
                    Else
                        strFileNoList = strFileNoList & "," & iList(i).F_No
                    End If
                Else
                    strFileNoList = strFileNoList & "," & iList(i).F_No
                End If
            Next
        End If
        'If Label28.Text = "采購作業" Then
        '    iList = dt.FileBond_GetList("4002", txtPMID.EditValue, Nothing)
        '    For i = 0 To iList.Count - 1
        '        strFileNoList = strFileNoList & "," & iList(i).F_No
        '    Next
        'ElseIf Label28.Text = "手開採購單" Then
        '    iList = dt.FileBond_GetList("4008", txtPMID.EditValue, Nothing)
        '    For i = 0 To iList.Count - 1

        '        strFileNoList = strFileNoList & "," & iList(i).F_No

        '    Next
        'End If
        iList = Nothing

        If strFileNoList <> "" Then
            strFileNoList = Mid(strFileNoList, 2)
            dt = New FileController
            'MsgBox(strFileNoList)


            Dim m, n As Integer
            Dim TempstrFileNoList As String
            TempstrFileNoList = ""
            Dim arr(n) As String
            arr = Split(strFileNoList, ",")
            n = Len(Replace(strFileNoList, ",", "," & "*")) - Len(strFileNoList)
            For m = 0 To n
                If m = 0 Then
                    TempstrFileNoList = arr(m)
                End If

                If m > 0 Then
                    If arr(m) = arr(m - 1) Then
                        GoTo A
                    Else
                        TempstrFileNoList = TempstrFileNoList & "," & arr(m)
                    End If
                End If
A:          Next

            strFileNoList = TempstrFileNoList



            GridFile.DataSource = dt.FileBond_GetList(Nothing, Nothing, strFileNoList)

        End If

    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        If ds.Tables("Purchase").Rows(e.PrevFocusedRowHandle)("Q_MOQ") <> 0 Then
            If ds.Tables("Purchase").Rows(e.PrevFocusedRowHandle)("PS_Qty") < ds.Tables("Purchase").Rows(e.PrevFocusedRowHandle)("Q_MOQ") Then
                MsgBox("訂購數量小於該報價單最小訂購量")
            End If
        End If

        If ds.Tables("Purchase").Rows(e.PrevFocusedRowHandle)("Q_StandardPack") <> 0 Then
            If ds.Tables("Purchase").Rows(e.PrevFocusedRowHandle)("PS_Qty") Mod ds.Tables("Purchase").Rows(e.PrevFocusedRowHandle)("Q_StandardPack") <> 0 Then
                MsgBox("訂購數量不是該報價單最小包裝的整數倍")
            End If
        End If


    End Sub

    Private Sub TarriffEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TarriffEdit.EditValueChanged

    End Sub
    '查看當前選定物料信息(物料編碼管理中)
    Private Sub popPurchaseCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPurchaseCode.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        tempCode = "PurchaseView"
        Dim fr As frmMaterialCode
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMaterialCode Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmMaterialCode
        fr.MdiParent = MDIMain
        tempValue5 = GridView1.GetFocusedRowCellValue("M_Code").ToString
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub

    Private Sub popPurchasefujian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPurchasefujian.Click
        '調用此產品資料的文件
        'If GridView1.RowCount = 0 Then Exit Sub
        'Dim open, update, down, Edit, del, detail As Boolean
        'Dim pmws As New PermissionModuleWarrantSubController
        'Dim pmwiL As New List(Of PermissionModuleWarrantSubInfo)

        If GridView1.RowCount = 0 Then Exit Sub
        FileShow("1001", GridView1.GetFocusedRowCellValue("M_Code").ToString, True, False, True, False, False, False)
        'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100107")
        'If pmwiL.Count > 0 Then
        '    If pmwiL.Item(0).PMWS_Value = "是" Then update = True
        '    If pmwiL.Item(0).PMWS_Value = "否" Then update = False
        'End If

        'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100108")
        'If pmwiL.Count > 0 Then
        '    If pmwiL.Item(0).PMWS_Value = "是" Then down = True
        '    If pmwiL.Item(0).PMWS_Value = "否" Then down = False
        'End If


        'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100109")
        'If pmwiL.Count > 0 Then
        '    If pmwiL.Item(0).PMWS_Value = "是" Then Edit = True
        '    If pmwiL.Item(0).PMWS_Value = "否" Then Edit = False
        'End If

        'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100110")
        'If pmwiL.Count > 0 Then
        '    If pmwiL.Item(0).PMWS_Value = "是" Then del = True
        '    If pmwiL.Item(0).PMWS_Value = "否" Then del = False
        'End If

        'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100111")
        'If pmwiL.Count > 0 Then
        '    If pmwiL.Item(0).PMWS_Value = "是" Then detail = True
        '    If pmwiL.Item(0).PMWS_Value = "否" Then detail = False
        'End If

        'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100112")
        'If pmwiL.Count > 0 Then
        '    If pmwiL.Item(0).PMWS_Value = "是" Then open = True
        '    If pmwiL.Item(0).PMWS_Value = "否" Then open = False
        'End If

        'FileShow("1001", GridView1.GetFocusedRowCellValue("M_Code").ToString, open, update, down, Edit, del, detail)

    End Sub

    Private Sub popApplyAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popApplyAdd.Click
        If gluSupplier.EditValue = "" Then
            MsgBox("請先確定供應商!", 64, "提示")
            Exit Sub
        End If

        tempAPNum = ""
        frmPurchaseApply.ShowDialog()
        If tempAPNum = "" Then Exit Sub

        Dim i, n As Integer
        Dim arr(n) As String
        arr = Split(tempAPNum, ",")
        n = tempAPNum.Split(",").Length - 1
        'n = Len(Replace(tempAPNum, ",", "," & "*")) - Len(tempAPNum)
        For i = 0 To n
            Dim j As Integer

            For j = 0 To ds.Tables("Purchase").Rows.Count - 1
                If IsDBNull(ds.Tables("Purchase").Rows(j)("AP_Num")) Then

                Else
                    If arr(i) = ds.Tables("Purchase").Rows(j)("AP_Num") Then
                        MsgBox("此(" & ds.Tables("Purchase").Rows(j)("M_Code") & ")申購物料已添加，不需再添加!", 64, "提示")
                        GoTo Abc '跳出本次循環，繼續添加下一條物料
                    End If
                End If
            Next

            If arr(i) = "" Then
                Exit Sub
            End If

            Dim apc As New LFERP.Library.Purchase.ApplyPurchase.ApplyPurchaseControl
            Dim ai As New LFERP.Library.Purchase.ApplyPurchase.ApplyPurchaseInfo
            ai = apc.ApplyPurchase_Get(arr(i))

            'Dim osc As New Library.Orders.OrdersSubController
            'Dim osi As List(Of Library.Orders.OrdersSubInfo)
            'osi = osc.OrdersSub_GetList(Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            'Dim obi As List(Of Library.Orders.OrdersBomInfo)
            'Dim obc As New Library.Orders.OrdersBomController

            'obi = obc.OrdersBom_GetList(arr(i), tempValue2, Nothing, Nothing)

            Dim row As DataRow
            row = ds.Tables("Purchase").NewRow
            row("AP_Num") = ai.AP_Num
            row("PN_NO") = ai.AP_ID

            row("M_Code") = ai.AP_M_Code

            row("M_Name") = ai.AP_M_Name
            row("M_Unit") = ai.AP_M_Unit
            row("M_Gauge") = ai.AP_M_Gauge
            row("DPT_ID") = ai.AP_ApplyDptName
            row("U_ID") = ai.AP_ApplyPersonName
            row("PS_NeedPurchaseUse") = ai.AP_Applyreason
            row("PS_Qty") = ai.AP_Qty
            row("PS_Price") = 0
            row("Q_StandardPack") = 0
            row("Q_MOQ") = 0
            'If gluSupplier.EditValue = obi(0).OB_Supplier Then
            '    row("S_SupplierNo") = obi(0).OB_SupplierNo
            'Else
            '    MsgBox("此批次中物料所對應供應商與採購供應商不一致", , "溫馨提示")
            '    row("S_SupplierNo") = ""
            'End If
            row("PS_SendDate") = Format(Now, "yyyy/MM/dd") '當前批次中要求的交貨期
            'row("PS_Tarriff") = 0
            ds.Tables("Purchase").Rows.Add(row)
            'GridView1.MoveLast()
Abc:
        Next
        tempAPNum = ""
    End Sub

 
    Private Sub gluSupplier_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles gluSupplier.EditValueChanging
        If GridView1.RowCount > 0 Then
            If MsgBox("若修改供應商，報價單也需同時修改，確定要修改供應商嗎？", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "提示") = MsgBoxResult.Cancel Then
                e.Cancel = True
            Else
                Dim i%
                For i = 0 To ds.Tables("Purchase").Rows.Count - 1
                    ds.Tables("Purchase").Rows(i)("Q_QuoID") = Nothing
                Next
            End If
        End If
    End Sub

    '判斷當前使用人員是否有查看到報價信息--通過使用人員級別權限來設置  2013/1/9 楊
    Private Sub GridFile_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridFile.MouseUp
        If strTemp = "非采購人員" And Microsoft.VisualBasic.Left(GridFile.CurrentRow.Cells("F_Detail").Value.ToString, 1) = "Q" Then

            popFileShowOpen.Enabled = False
        Else
            popFileShowOpen.Enabled = True

        End If
        If strTemp = "非采購人員" And Microsoft.VisualBasic.Left(GridFile.CurrentRow.Cells("F_Name").Value.ToString, 1) = "Q" Then

            popFileShowOpen.Enabled = False
        Else
            popFileShowOpen.Enabled = True

        End If
    End Sub
End Class