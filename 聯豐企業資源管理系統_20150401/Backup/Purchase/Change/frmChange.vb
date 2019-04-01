Imports LFERP.Library.Purchase.Change
Imports LFERP.Library.Purchase.Purchase
Imports LFERP.FileManager
Imports LFERP.Library.Purchase.SharePurchase
Imports LFERP.Library.Purchase.Acceptance
Imports LFERP.Library.Purchase.Retrocede

Public Class frmChange

    Dim ds As New DataSet

    Private Sub frmChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mtd As New LFERP.DataSetting.SuppliersControler


        RepositoryItemLookUpEdit1.DisplayMember = "S_SupplierName"
        RepositoryItemLookUpEdit1.ValueMember = "S_Supplier"
        RepositoryItemLookUpEdit1.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")

        Label3.Text = tempValue
        txtQuoID.Text = tempValue3
        Label12.Text = tempValue4
        tempValue = ""
        tempValue3 = ""
        tempValue4 = ""
        CreateTable()

        Select Case Label3.Text

            Case "更改單"
                If Edit = True Then
                    Me.Text = "更改單--修改"
                    LoadData(txtQuoID.Text)
                    DateEdit1.Enabled = False
                    CBSendType.Enabled = False
                    txtQuoID.Enabled = False
                    MemoEdit1.Enabled = False


                    If Label12.Text = "更改未交數" Then
                        C_Qty.Visible = False
                        C_NoSendQty.Visible = True
                    ElseIf Label12.Text = "更改採購數" Then
                        C_Qty.Visible = True
                        C_NoSendQty.Visible = False
                    End If
                Else
                    Me.Text = "更改單--暫改"
                    txtQuoID.Text = ""
                    txtQuoID.Enabled = False

                    DateEdit1.EditValue = Format(Now, "yyyy/MM/dd")
                    DateEdit1.Enabled = False
                    CBSendType.EditValue = Label12.Text
                    CBSendType.Enabled = False
                    Label7.Visible = False

                    If Label12.Text = "更改未交數" Then
                        C_Qty.Visible = False
                        C_NoSendQty.Visible = True
                    ElseIf Label12.Text = "更改採購數" Then
                        C_Qty.Visible = True
                        C_NoSendQty.Visible = False
                    End If
                End If

                CheckEdit1.Enabled = False
                CheckDate.Enabled = False
                CheckAction.Enabled = False
                CheckRemark.Enabled = False
                CBEdit4.Enabled = False
            Case "查看"
                Me.Text = "更改單--查看"
                LoadData(txtQuoID.Text)
                cmdSave.Visible = False
                'GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                'GridView1.OptionsBehavior.Editable = False
                'GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
                DateEdit1.Enabled = False
                CBSendType.Enabled = False
            Case "審核"
                Me.Text = "更改單--審核"
                LoadData(txtQuoID.Text)
                XtraTabControl1.SelectedTabPage = XtraTabPage2
                GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                GridView1.OptionsBehavior.Editable = False
                GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
                DateEdit1.Enabled = False
                CBSendType.Enabled = False
                txtQuoID.Enabled = False
                MemoEdit1.Enabled = False
        End Select

        '加載附件供顯示
        GridFile.AutoGenerateColumns = False
        GridFile.RowHeadersWidth = 15
        Dim dt As New FileController
        GridFile.DataSource = dt.FileBond_GetList("4005", txtQuoID.EditValue, Nothing)
        GridFile.Refresh()
    End Sub

    Function LoadData(ByVal C_ChangeNO As String) As Boolean
        LoadData = True
        Dim ci As List(Of ChangeInfo)
        Dim cc As New ChangeControl
        Dim i As Integer
        Dim row As DataRow
        Try
            ci = cc.Change_GetList(C_ChangeNO, Nothing, Nothing, Nothing)
            If ci Is Nothing Then
                '沒有數據
                Exit Function
            End If
            For i = 0 To ci.Count - 1

                txtQuoID.Text = ci(i).C_ChangeNo
                'txtName.Text = ci(i).PM_NO
                DateEdit1.Text = ci(i).C_Date
                CBSendType.EditValue = ci(i).C_Type
                Label7.Text = ci(i).ActionName
                MemoEdit1.Text = ci(i).C_Remark
                '--------------------------------------------------------
                row = ds.Tables("Change").NewRow
                row("PM_NO") = ci(i).PM_NO
                row("M_Code") = ci(i).M_Code
                row("M_Gauge") = ci(i).M_Gauge
                row("M_Name") = ci(i).M_Name
                row("M_Unit") = ci(i).M_Unit
                row("C_NoSendQty") = ci(i).C_NoSendQty
                row("C_Price") = ci(i).C_Price
                row("IndexNO") = ci(i).IndexNO
                row("C_Reason") = ci(i).C_Reason
                row("PM_Qty") = ci(i).PM_Qty
                row("PM_PurchaseQty") = ci(i).PM_PurchaseQty
                row("S_Supplier") = ci(i).S_Supplier
                row("C_Qty") = ci(i).C_Qty
                '--------------------------------------------------------
                ds.Tables("Change").Rows.Add(row)
                If ci(i).C_Check = False Then
                    CheckEdit1.Checked = False
                Else
                    CheckEdit1.Checked = True
                End If
                CBEdit4.EditValue = ci(i).C_CheckType
                CheckDate.Text = ci(i).C_CheckDate
                CheckAction.Text = ci(i).CheckActionName
                CheckRemark.Text = ci(i).C_CheckRemark

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("Change")

            .Columns.Add("PM_NO", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("C_Price", GetType(Double))
            .Columns.Add("C_NoSendQty", GetType(Double))
            .Columns.Add("C_Reason", GetType(String))
            .Columns.Add("PM_Qty", GetType(Double))
            .Columns.Add("PM_PurchaseQty", GetType(Double))
            .Columns.Add("S_Supplier", GetType(String))

            .Columns.Add("C_Qty", GetType(Double))

            .Columns.Add("IndexNO", GetType(String))

        End With
        '創建刪除數據表
        With ds.Tables.Add("DelData")

            .Columns.Add("IndexNO", GetType(String))

        End With
        '綁定表格
        Grid.DataSource = ds.Tables("Change")

    End Sub
    ''' <summary>
    ''' 自動獲得更改單單號
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetChangeNO() As String
        Dim str As String
        str = CStr(Format(Now, "yyMM"))
        Dim ai As New ChangeInfo
        Dim ac As New ChangeControl

        ai = ac.Change_GetNo(str)
        If ai Is Nothing Then
            GetChangeNO = "PC" & str & "00001"
        Else
            GetChangeNO = "PC" & str & Mid((CInt(Mid(ai.C_ChangeNo, 7)) + 100001), 2)
        End If
    End Function

    Sub SaveDataNew()   '更改未交數
        Dim i As Integer
        Dim GetNO As String
        GetNO = GetChangeNO()

        For i = 0 To ds.Tables("Change").Rows.Count - 1

            Dim ci As New ChangeInfo
            Dim cc As New ChangeControl

            txtQuoID.Text = GetNO
            ci.C_ChangeNO = txtQuoID.Text
            ci.C_Type = CBSendType.EditValue
            'ci.PM_NO = txtName.Text
            ci.C_Remark = MemoEdit1.Text
            ci.C_Check = False

            ci.M_Code = ds.Tables("Change").Rows(i)("M_Code")
            ci.PM_NO = ds.Tables("Change").Rows(i)("PM_NO")
            If IsDBNull(ds.Tables("Change").Rows(i)("M_Unit")) Then
                ci.M_Unit = Nothing
            Else
                ci.M_Unit = ds.Tables("Change").Rows(i)("M_Unit")
            End If
            If IsDBNull(ds.Tables("Change").Rows(i)("M_Name")) Then
                ci.M_Name = Nothing
            Else
                ci.M_Name = ds.Tables("Change").Rows(i)("M_Name")
            End If
            If IsDBNull(ds.Tables("Change").Rows(i)("M_Gauge")) Then
                ci.M_Gauge = Nothing
            Else
                ci.M_Gauge = ds.Tables("Change").Rows(i)("M_Gauge")
            End If
            If IsDBNull(ds.Tables("Change").Rows(i)("C_Price")) Then
                ci.C_Price = 0
            Else
                ci.C_Price = ds.Tables("Change").Rows(i)("C_Price")
            End If
            If IsDBNull(ds.Tables("Change").Rows(i)("C_NoSendQty")) Then
                ci.C_NoSendQty = 0
            Else
                ci.C_NoSendQty = ds.Tables("Change").Rows(i)("C_NoSendQty")
            End If
            If IsDBNull(ds.Tables("Change").Rows(i)("C_Reason")) Then
                ci.C_Reason = Nothing
            Else
                ci.C_Reason = ds.Tables("Change").Rows(i)("C_Reason")
            End If
            If IsDBNull(ds.Tables("Change").Rows(i)("PM_Qty")) Then
                ci.PM_Qty = 0
            Else
                ci.PM_Qty = ds.Tables("Change").Rows(i)("PM_Qty")
            End If
            If IsDBNull(ds.Tables("Change").Rows(i)("PM_PurchaseQty")) Then
                ci.PM_PurchaseQty = 0
            Else
                ci.PM_PurchaseQty = ds.Tables("Change").Rows(i)("PM_PurchaseQty")
            End If
            ci.S_Supplier = ds.Tables("Change").Rows(i)("S_Supplier")

            If IsDBNull(ds.Tables("Change").Rows(i)("C_Qty")) Then
                ci.C_Qty = 0
            Else
                ci.C_Qty = ds.Tables("Change").Rows(i)("C_Qty")
            End If

            ci.C_Action = InUserID
            ci.C_Date = DateEdit1.EditValue

            cc.Change_Add(ci)
        Next
        MsgBox("已保存,單號: " & GetNO & " ")
        Me.Close()
    End Sub

    Sub SaveDataNew1()  '更改採購數
        Dim i As Integer
        Dim GetNO As String
        GetNO = GetChangeNO()

        For i = 0 To ds.Tables("Change").Rows.Count - 1

            Dim ci As New ChangeInfo
            Dim cc As New ChangeControl

            txtQuoID.Text = GetNO
            ci.C_ChangeNO = txtQuoID.Text
            ci.C_Type = CBSendType.EditValue
            ci.C_Remark = MemoEdit1.Text

            ci.M_Code = ds.Tables("Change").Rows(i)("M_Code")
            ci.PM_NO = ds.Tables("Change").Rows(i)("PM_NO")
            If IsDBNull(ds.Tables("Change").Rows(i)("M_Unit")) Then
                ci.M_Unit = Nothing
            Else
                ci.M_Unit = ds.Tables("Change").Rows(i)("M_Unit")
            End If
            If IsDBNull(ds.Tables("Change").Rows(i)("M_Name")) Then
                ci.M_Name = Nothing
            Else
                ci.M_Name = ds.Tables("Change").Rows(i)("M_Name")
            End If
            If IsDBNull(ds.Tables("Change").Rows(i)("M_Gauge")) Then
                ci.M_Gauge = Nothing
            Else
                ci.M_Gauge = ds.Tables("Change").Rows(i)("M_Gauge")
            End If
            If IsDBNull(ds.Tables("Change").Rows(i)("C_Price")) Then
                ci.C_Price = 0
            Else
                ci.C_Price = ds.Tables("Change").Rows(i)("C_Price")
            End If
            '----------------------------------------------------------------------------
            If IsDBNull(ds.Tables("Change").Rows(i)("C_Qty")) Then
                ci.C_Qty = 0                                             '更改後採購數
            Else
                ci.C_Qty = ds.Tables("Change").Rows(i)("C_Qty")
            End If
            '----------------------------------------------------------------------------
            '此時未交數為當前更改后的採購數-已驗收數量+已退貨數量(同一採購單同一物料編碼)

            Dim aci As List(Of AcceptanceInfo)
            Dim acc As New AcceptanceController
            aci = acc.Acceptance_GetList(ds.Tables("Change").Rows(i)("PM_NO"), Nothing, Nothing, Nothing, Nothing, True, Nothing, ds.Tables("Change").Rows(i)("M_Code"), Nothing, Nothing, Nothing, Nothing, Nothing)
            Dim AccQty, RetQty As Double

            If aci.Count = 0 Then
                AccQty = 0
            Else
                AccQty = aci(0).A_Qty
            End If
            Dim rei As List(Of RetrocedeInfo)
            Dim rec As New RetrocedeController
            rei = rec.Retrocede_GetList(ds.Tables("Change").Rows(i)("PM_NO"), Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing, ds.Tables("Change").Rows(i)("M_Code"), Nothing, Nothing, Nothing)
            If rei.Count = 0 Then
                RetQty = 0
            Else
                RetQty = rei(0).R_Qty
            End If
            ci.C_NoSendQty = ds.Tables("Change").Rows(i)("C_Qty") - AccQty + RetQty

            'If IsDBNull(ds.Tables("Change").Rows(i)("C_NoSendQty")) Then
            '    ci.C_NoSendQty = 0
            'Else
            '    ci.C_NoSendQty = ds.Tables("Change").Rows(i)("C_NoSendQty")
            'End If
            If IsDBNull(ds.Tables("Change").Rows(i)("C_Reason")) Then
                ci.C_Reason = Nothing
            Else
                ci.C_Reason = ds.Tables("Change").Rows(i)("C_Reason")
            End If
            If IsDBNull(ds.Tables("Change").Rows(i)("PM_Qty")) Then
                ci.PM_Qty = 0
            Else
                ci.PM_Qty = ds.Tables("Change").Rows(i)("PM_Qty")
            End If
            If IsDBNull(ds.Tables("Change").Rows(i)("PM_PurchaseQty")) Then
                ci.PM_PurchaseQty = 0
            Else
                ci.PM_PurchaseQty = ds.Tables("Change").Rows(i)("PM_PurchaseQty")
            End If
            ci.S_Supplier = ds.Tables("Change").Rows(i)("S_Supplier")

            ci.C_Action = InUserID
            ci.C_Date = DateEdit1.EditValue

            cc.Change_Add(ci)
        Next
        MsgBox("已保存,單號: " & GetNO & " ")
        Me.Close()
    End Sub

    Sub SaveDataEdit()
        Dim i As Integer


        '更新刪除的記錄
        If ds.Tables("DelData").Rows.Count > 0 Then
            Dim j As Integer
            For j = 0 To ds.Tables("DelData").Rows.Count - 1

                Dim odc As New ChangeControl

                If Not IsDBNull(ds.Tables("DelData").Rows(j)("IndexNO")) Then
                    odc.Change_DelIndexNo(ds.Tables("DelData").Rows(j)("IndexNO"))
                End If
            Next j
        End If

        For i = 0 To ds.Tables("Change").Rows.Count - 1

            If Not IsDBNull(ds.Tables("Change").Rows(i)("IndexNO")) Then
                '只是修改
                Dim ci As New ChangeInfo
                Dim cc As New ChangeControl

                ci.IndexNO = ds.Tables("Change").Rows(i)("IndexNO")

                ci.C_Type = CBSendType.EditValue
                ci.C_Date = Format(Now, "yyyy/MM/dd")
                If IsDBNull(ds.Tables("Change").Rows(i)("C_NoSendQty")) Then
                    ci.C_NoSendQty = 0
                Else
                    ci.C_NoSendQty = ds.Tables("Change").Rows(i)("C_NoSendQty")
                End If

                If IsDBNull(ds.Tables("Change").Rows(i)("C_Price")) Then
                    ci.C_Price = 0
                Else
                    ci.C_Price = ds.Tables("Change").Rows(i)("C_Price")
                End If
                If IsDBNull(ds.Tables("Change").Rows(i)("C_Reason")) Then
                    ci.C_Reason = Nothing
                Else
                    ci.C_Reason = ds.Tables("Change").Rows(i)("C_Reason")
                End If

                If IsDBNull(ds.Tables("Change").Rows(i)("C_Qty")) Then
                    ci.C_Qty = 0
                Else
                    ci.C_Qty = ds.Tables("Change").Rows(i)("C_Qty")
                End If

                ci.C_Action = InUserID

                cc.Change_Update(ci)

            End If
            If IsDBNull(ds.Tables("Change").Rows(i)("IndexNO")) Then
                '新增加
                Dim GetNO As String
                GetNO = GetChangeNO()

                Dim ci As New ChangeInfo
                Dim cc As New ChangeControl
                ci.C_ChangeNO = txtQuoID.Text
                ci.C_Type = CBSendType.EditValue
                ci.C_Remark = MemoEdit1.Text
                'ci.PM_NO = txtName.Text

                ci.M_Code = ds.Tables("Change").Rows(i)("M_Code")
                ci.PM_NO = ds.Tables("Change").Rows(i)("PM_NO")
                If IsDBNull(ds.Tables("Change").Rows(i)("M_Unit")) Then
                    ci.M_Unit = Nothing
                Else
                    ci.M_Unit = ds.Tables("Change").Rows(i)("M_Unit")
                End If
                If IsDBNull(ds.Tables("Change").Rows(i)("M_Name")) Then
                    ci.M_Name = Nothing
                Else
                    ci.M_Name = ds.Tables("Change").Rows(i)("M_Name")
                End If
                If IsDBNull(ds.Tables("Change").Rows(i)("M_Gauge")) Then
                    ci.M_Gauge = Nothing
                Else
                    ci.M_Gauge = ds.Tables("Change").Rows(i)("M_Gauge")
                End If

                If IsDBNull(ds.Tables("Change").Rows(i)("C_Price")) Then
                    ci.C_Price = 0
                Else
                    ci.C_Price = ds.Tables("Change").Rows(i)("C_Price")
                End If
                If IsDBNull(ds.Tables("Change").Rows(i)("C_NoSendQty")) Then
                    ci.C_NoSendQty = 0
                Else
                    ci.C_NoSendQty = ds.Tables("Change").Rows(i)("C_NoSendQty")
                End If
                If IsDBNull(ds.Tables("Change").Rows(i)("C_Reason")) Then
                    ci.C_Reason = Nothing
                Else
                    ci.C_Reason = ds.Tables("Change").Rows(i)("C_Reason")
                End If
                If IsDBNull(ds.Tables("Change").Rows(i)("PM_Qty")) Then
                    ci.PM_Qty = 0
                Else
                    ci.PM_Qty = ds.Tables("Change").Rows(i)("PM_Qty")
                End If
                If IsDBNull(ds.Tables("Change").Rows(i)("PM_PurchaseQty")) Then
                    ci.PM_PurchaseQty = 0
                Else
                    ci.PM_PurchaseQty = ds.Tables("Change").Rows(i)("PM_PurchaseQty")
                End If
                ci.S_Supplier = ds.Tables("Change").Rows(i)("S_Supplier")

                If IsDBNull(ds.Tables("Change").Rows(i)("C_Qty")) Then
                    ci.C_Qty = 0
                Else
                    ci.C_Qty = ds.Tables("Change").Rows(i)("C_Qty")
                End If

                ci.C_Action = InUserID
                ci.C_Date = DateEdit1.EditValue

                cc.Change_Add(ci)

            End If
        Next

        MsgBox("已修改！")
        Me.Close()
    End Sub

    Sub CheckNoSendQty()
        Dim ci As New ChangeInfo
        Dim cc As New ChangeControl

        ci.C_ChangeNO = txtQuoID.Text
        ci.C_Check = CheckEdit1.Checked
        CheckDate.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
        ci.C_CheckDate = CheckDate.Text
        ci.C_CheckType = CBEdit4.EditValue
        ci.C_CheckAction = InUserID
        ci.C_CheckRemark = CheckRemark.Text
        If cc.Change_Check(ci) = True Then

            Dim psi As New PurchaseMainInfo
            Dim psc As New PurchaseMainController


            Dim i As Integer
            For i = 0 To ds.Tables("Change").Rows.Count - 1

                psi.PM_NO = ds.Tables("Change").Rows(i)("PM_NO")
                psi.M_Code = ds.Tables("Change").Rows(i)("M_Code")
                psi.PS_NoSendQty = ds.Tables("Change").Rows(i)("C_NoSendQty")
                psi.PS_Price = ds.Tables("Change").Rows(i)("C_Price")
                psi.C_Qty = ds.Tables("Change").Rows(i)("C_Qty")

                psc.UpdatePurchase_NoSendQty(psi)
            Next
            MsgBox("審核成功，采購單中未交數將更改為此單中數量！")
        Else
            MsgBox("審核失敗，請檢查原因！")
        End If

    End Sub

    Sub CheckPurchaseQty()  '更改採購數
        Dim ci As New ChangeInfo
        Dim cc As New ChangeControl

        ci.C_ChangeNO = txtQuoID.Text
        ci.C_Check = CheckEdit1.Checked
        CheckDate.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
        ci.C_CheckDate = CheckDate.Text
        ci.C_CheckType = CBEdit4.EditValue
        ci.C_CheckAction = InUserID
        ci.C_CheckRemark = CheckRemark.Text
        If cc.Change_Check(ci) = True Then

            Dim psi As New PurchaseMainInfo
            Dim psc As New PurchaseMainController

            Dim i As Integer
            For i = 0 To ds.Tables("Change").Rows.Count - 1

                psi.PM_NO = ds.Tables("Change").Rows(i)("PM_NO")
                psi.M_Code = ds.Tables("Change").Rows(i)("M_Code")
                psi.PS_NoSendQty = ds.Tables("Change").Rows(i)("C_NoSendQty")
                psi.PS_Price = ds.Tables("Change").Rows(i)("C_Price")
                psi.C_Qty = ds.Tables("Change").Rows(i)("C_Qty")

                psc.UpdatePurchase_NoSendQty(psi)

            Next

            Dim spc1 As New SharePurchaseController
            Dim spi1 As New SharePurchaseInfo
            Dim j As Integer
            For j = 0 To ds.Tables("Change").Rows.Count - 1

                spi1.PM_NO = ds.Tables("Change").Rows(j)("PM_NO")
                spi1.M_Code = ds.Tables("Change").Rows(j)("M_Code")
           
                spc1.UpdatePurchase_NoSenQty(spi1)     '通過更改採購數來改變採購未交數
            Next
        
            MsgBox("審核成功，采購單中採購數將更改為此單中數量且更改相應的未交數！")
        Else
            MsgBox("審核失敗，請檢查原因！")
        End If


    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case Label3.Text

            Case "更改單"
                If Edit = False Then

                    If Label12.Text = "更改未交數" Then
                        SaveDataNew()
                    ElseIf Label12.Text = "更改採購數" Then
                        SaveDataNew1()
                    End If
                Else
                    SaveDataEdit()
                End If

            Case "審核"
                If Label12.Text = "更改未交數" Then
                    CheckNoSendQty()
                ElseIf Label12.Text = "更改採購數" Then
                    CheckPurchaseQty()
                End If

        End Select
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub PurchaseChangeAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseChangeAdd.Click
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

                Dim row As DataRow = ds.Tables("Change").NewRow

                row("PM_NO") = psi.PM_NO
                row("M_Code") = psi.M_Code
                row("M_Unit") = psi.M_Unit
                row("M_Name") = psi.M_Name
                row("M_Gauge") = psi.M_Gauge
                row("C_Price") = psi.PS_Price
                row("C_NoSendQty") = psi.PS_NoSendQty
                row("C_Reason") = ""
                row("PM_Qty") = psi.PS_NoSendQty
                row("PM_PurchaseQty") = psi.PS_QTY
                row("C_Qty") = psi.PS_QTY

                row("S_Supplier") = pst.PurchaseMain_Get(psi.PM_NO).S_Supplier   '讀取供應商編號

                ds.Tables("Change").Rows.Add(row)
                AdvBandedGridView1.MoveLast()

            Next
        End If
         tempValue = ""
    End Sub

    Private Sub PurchaseChangeDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseChangeDel.Click
        If AdvBandedGridView1.RowCount = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = AdvBandedGridView1.GetRowCellDisplayText(ArrayToString(AdvBandedGridView1.GetSelectedRows()), "IndexNO")

        If DelTemp = "IndexNO" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelData").NewRow
            row("IndexNO") = DelTemp
            ds.Tables("DelData").Rows.Add(row)
        End If
        ds.Tables("Change").Rows.RemoveAt(CInt(ArrayToString(AdvBandedGridView1.GetSelectedRows())))
    End Sub

    Private Sub popFileShowOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popFileShowOpen.Click
        '打開選擇文件
        Dim dt As New FileController
        If GridFile.Rows.Count = 0 Then Exit Sub
        dt.File_Open(Nothing, Nothing, GridFile.CurrentRow.Cells("F_No").Value.ToString)
    End Sub
End Class