Imports LFERP.Library.Purchase.Acceptance
Imports LFERP.Library.Purchase.Purchase
Imports LFERP.Library.Purchase.Retrocede
Imports LFERP.Library.Purchase.SharePurchase
Imports LFERP.Library.WareHouse.WareInventory

Public Class frmRetrocede
    Dim ds As New DataSet
    Dim OldCheck As New Boolean
    Dim TempStrA As String
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If MTypeName = "RetrocedeAddEdit" Then
            '退貨單新增修改
            If ButtonEdit1.Text = "" Or DateEdit1.Text = "" Then
                MsgBox("請填寫退貨日期及退貨倉庫")
                Exit Sub
            End If

            If ds.Tables("Retrocede").Rows.Count = 0 Then
                MsgBox("沒有數據,無法保存!")
                Exit Sub
            End If

            Select Case Edit
                Case False
                    If Check() = False Then Exit Sub
                    SaveNew()
                Case True
                    If Check() = False Then Exit Sub
                    SaveEdit()
            End Select
        End If


        If MTypeName = "RetrocedeCheck" Then
            '退貨單審核
            If DateEdit2.Text = "" Then
                MsgBox("請填寫審核日期", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                Exit Sub
            End If

            If OldCheck = False Then
                If CheckEdit1.Checked = False Then
                    MsgBox("請先更改審核狀態,才能保存!", MsgBoxStyle.OkOnly)
                    Exit Sub
                End If

            End If

            If OldCheck = True Then
                If CheckEdit1.Checked = True Then
                    MsgBox("請先更改審核狀態,才能保存!", MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
            End If

            If Check() = False Then Exit Sub
            SaveCheck()
        End If


        If MTypeName = "RetrocedeAccountCheck" Then
            '會計部審核時
            'If DateEdit3.Text = "" Then
            '    MsgBox("請填寫審核日期", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            '    Exit Sub
            'End If
            'If CheckEdit1.Checked = False Then
            '    MsgBox("必須先部門退貨審核, 會計部才能審核！", MsgBoxStyle.OkOnly)
            '    Exit Sub
            'End If

            SaveAccountCheck()
        End If

    End Sub

    Function GetRetrocedeNO()
        '生成新的退貨單號
        Dim str1, str2 As String
        Dim ac As New RetrocedeController
        Dim ai As New RetrocedeInfo
        str1 = Mid(Year(Now), 3)
        If CInt(Month(Now)) < 10 Then
            str2 = "0" & Month(Now)
        Else
            str2 = Month(Now)
        End If

        Dim Stra As String
        Stra = "RE" & str1 & str2

        ai = ac.Retrocede_Get(Stra)
        If ai Is Nothing Then
            GetRetrocedeNO = "RE" & str1 & str2 & "0001"
        Else
            GetRetrocedeNO = "RE" & str1 & str2 & Mid((CInt(Mid(ai.R_RetrocedeNO, 7)) + 10001), 2)
        End If
    End Function

    Sub SaveEdit()
        Dim i As Integer
        'Dim R_RetrocedeNO As String
        'R_RetrocedeNO = GetRetrocedeNO()

        For i = 0 To ds.Tables("Retrocede").Rows.Count - 1
            If Not IsDBNull(ds.Tables("Retrocede").Rows(i)("R_NO")) Then
                '如果隻是修改
                Dim ac As New RetrocedeController
                Dim ai As New RetrocedeInfo
                ai.R_RetrocedeNO = txtPMID.Text
                ai.DepotNO = ButtonEdit1.Text
                ai.S_Supplier = gluSupplier.EditValue
                ai.A_AcceptanceNO = ds.Tables("Retrocede").Rows(i)("A_AcceptanceNO")
                ai.M_Code = ds.Tables("Retrocede").Rows(i)("M_Code")
                ai.R_ReturnDate = DateEdit1.Text
                ai.R_Ver = Label2.Text
                ai.R_Action = Label3.Text
                ai.R_NO = ds.Tables("Retrocede").Rows(i)("R_NO")

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("M_Unit")) Then
                    ai.M_Unit = Nothing
                Else
                    ai.M_Unit = ds.Tables("Retrocede").Rows(i)("M_Unit")
                End If

                ai.M_Name = ds.Tables("Retrocede").Rows(i)("M_Name")

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("M_Gauge")) Then
                    ai.M_Gauge = Nothing
                Else
                    ai.M_Gauge = ds.Tables("Retrocede").Rows(i)("M_Gauge")
                End If

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("OS_BatchID")) Then
                    ai.OS_BatchID = Nothing
                Else
                    ai.OS_BatchID = ds.Tables("Retrocede").Rows(i)("OS_BatchID")
                End If



                If IsDBNull(ds.Tables("Retrocede").Rows(i)("PM_M_Code")) Then
                    ai.PM_M_Code = Nothing
                Else
                    ai.PM_M_Code = ds.Tables("Retrocede").Rows(i)("PM_M_Code")
                End If


                If IsDBNull(ds.Tables("Retrocede").Rows(i)("A_SendNO")) Then
                    ai.A_SendNo = Nothing
                Else
                    ai.A_SendNo = ds.Tables("Retrocede").Rows(i)("A_SendNO")
                End If

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("S_SupplierNO")) Then
                    ai.S_SupplierNO = Nothing
                Else
                    ai.S_SupplierNO = ds.Tables("Retrocede").Rows(i)("S_SupplierNO")
                End If

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_Qty")) Then
                    ai.R_Qty = "0"
                Else
                    ai.R_Qty = ds.Tables("Retrocede").Rows(i)("R_Qty")
                End If


                If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_Reason")) Then
                    ai.R_Reason = Nothing
                Else
                    ai.R_Reason = ds.Tables("Retrocede").Rows(i)("R_Reason")
                End If

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_ReturnType")) Then
                    ai.R_ReturnType = Nothing
                Else
                    ai.R_ReturnType = ds.Tables("Retrocede").Rows(i)("R_ReturnType")
                End If

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_Detail")) Then
                    ai.R_Detail = Nothing
                Else
                    ai.R_Detail = ds.Tables("Retrocede").Rows(i)("R_Detail")
                End If

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("PM_NO")) Then
                    ai.PM_NO = Nothing
                Else
                    ai.PM_NO = ds.Tables("Retrocede").Rows(i)("PM_NO")
                End If

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_SendDate")) Then
                    ai.R_SendDate = Nothing
                Else
                    ai.R_SendDate = ds.Tables("Retrocede").Rows(i)("R_SendDate")
                End If

                If txtRemark.Text = "" Then
                    ai.R_RemarkT = Nothing
                Else
                    ai.R_RemarkT = txtRemark.Text
                End If

                ai.R_UpdateDate = Now




                ac.Retrocede_Update(ai)
            End If




            If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_NO")) Then
                '如果是新增加
                Dim ac As New RetrocedeController
                Dim ai As New RetrocedeInfo
                ai.R_RetrocedeNO = txtPMID.Text
                ai.DepotNO = ButtonEdit1.Text
                ai.S_Supplier = gluSupplier.EditValue
                ai.A_AcceptanceNO = ds.Tables("Retrocede").Rows(i)("A_AcceptanceNO")
                ai.M_Code = ds.Tables("Retrocede").Rows(i)("M_Code")
                ai.R_ReturnDate = DateEdit1.Text
                ai.R_Ver = Label2.Text
                ai.R_Action = Label3.Text

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("M_Unit")) Then
                    ai.M_Unit = Nothing
                Else
                    ai.M_Unit = ds.Tables("Retrocede").Rows(i)("M_Unit")
                End If

                ai.M_Name = ds.Tables("Retrocede").Rows(i)("M_Name")

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("M_Gauge")) Then
                    ai.M_Gauge = Nothing
                Else
                    ai.M_Gauge = ds.Tables("Retrocede").Rows(i)("M_Gauge")
                End If

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("OS_BatchID")) Then
                    ai.OS_BatchID = Nothing
                Else
                    ai.OS_BatchID = ds.Tables("Retrocede").Rows(i)("OS_BatchID")
                End If



                If IsDBNull(ds.Tables("Retrocede").Rows(i)("PM_M_Code")) Then
                    ai.PM_M_Code = Nothing
                Else
                    ai.PM_M_Code = ds.Tables("Retrocede").Rows(i)("PM_M_Code")
                End If


                If IsDBNull(ds.Tables("Retrocede").Rows(i)("A_SendNO")) Then
                    ai.A_SendNo = Nothing
                Else
                    ai.A_SendNo = ds.Tables("Retrocede").Rows(i)("A_SendNO")
                End If

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("S_SupplierNO")) Then
                    ai.S_SupplierNO = Nothing
                Else
                    ai.S_SupplierNO = ds.Tables("Retrocede").Rows(i)("S_SupplierNO")
                End If

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_Qty")) Then
                    ai.R_Qty = "0"
                Else
                    ai.R_Qty = ds.Tables("Retrocede").Rows(i)("R_Qty")
                End If


                If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_Reason")) Then
                    ai.R_Reason = Nothing
                Else
                    ai.R_Reason = ds.Tables("Retrocede").Rows(i)("R_Reason")
                End If

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_ReturnType")) Then
                    ai.R_ReturnType = Nothing
                Else
                    ai.R_ReturnType = ds.Tables("Retrocede").Rows(i)("R_ReturnType")
                End If

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_Detail")) Then
                    ai.R_Detail = Nothing
                Else
                    ai.R_Detail = ds.Tables("Retrocede").Rows(i)("R_Detail")
                End If

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("PM_NO")) Then
                    ai.PM_NO = Nothing
                Else
                    ai.PM_NO = ds.Tables("Retrocede").Rows(i)("PM_NO")
                End If

                If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_SendDate")) Then
                    ai.R_SendDate = Nothing
                Else
                    ai.R_SendDate = ds.Tables("Retrocede").Rows(i)("R_SendDate")
                End If

                If txtRemark.Text = "" Then
                    ai.R_RemarkT = Nothing
                Else
                    ai.R_RemarkT = txtRemark.Text
                End If

                ai.R_UpdateDate = Now




                ac.Retrocede_Add(ai)

            End If
        Next

        If ds.Tables("DelDataRetrocede").Rows.Count > 0 Then
            For i = 0 To ds.Tables("DelDataRetrocede").Rows.Count - 1
                Dim odc As New RetrocedeController
                Dim odi As New RetrocedeInfo
                odi.R_NO = ds.Tables("DelDataRetrocede").Rows(i)("R_NO")
                odc.Retrocede_Delete_RNO(odi)
            Next i
        End If

        MsgBox("已修改,單號: " & txtPMID.Text & " ")
        Me.Close()
    End Sub

    Sub SaveNew()
        Dim i As Integer
        Dim R_RetrocedeNO As String

        R_RetrocedeNO = GetRetrocedeNO()

        For i = 0 To ds.Tables("Retrocede").Rows.Count - 1
            Dim ac As New RetrocedeController
            Dim ai As New RetrocedeInfo
            ai.R_RetrocedeNO = R_RetrocedeNO
            ai.DepotNO = ButtonEdit1.Text
            ai.S_Supplier = gluSupplier.EditValue
            ai.A_AcceptanceNO = ds.Tables("Retrocede").Rows(i)("A_AcceptanceNO")

            ai.M_Code = ds.Tables("Retrocede").Rows(i)("M_Code")
            ai.R_ReturnDate = DateEdit1.Text
            ai.R_Ver = Label2.Text
            ai.R_Action = Label3.Text

            If IsDBNull(ds.Tables("Retrocede").Rows(i)("M_Unit")) Then
                ai.M_Unit = Nothing
            Else
                ai.M_Unit = ds.Tables("Retrocede").Rows(i)("M_Unit")
            End If

            ai.M_Name = ds.Tables("Retrocede").Rows(i)("M_Name")

            If IsDBNull(ds.Tables("Retrocede").Rows(i)("M_Gauge")) Then
                ai.M_Gauge = Nothing
            Else
                ai.M_Gauge = ds.Tables("Retrocede").Rows(i)("M_Gauge")
            End If

            If IsDBNull(ds.Tables("Retrocede").Rows(i)("OS_BatchID")) Then
                ai.OS_BatchID = Nothing
            Else
                ai.OS_BatchID = ds.Tables("Retrocede").Rows(i)("OS_BatchID")
            End If



            If IsDBNull(ds.Tables("Retrocede").Rows(i)("PM_M_Code")) Then
                ai.PM_M_Code = Nothing
            Else
                ai.PM_M_Code = ds.Tables("Retrocede").Rows(i)("PM_M_Code")
            End If


            If IsDBNull(ds.Tables("Retrocede").Rows(i)("A_SendNO")) Then
                ai.A_SendNo = Nothing
            Else
                ai.A_SendNo = ds.Tables("Retrocede").Rows(i)("A_SendNO")
            End If

            If IsDBNull(ds.Tables("Retrocede").Rows(i)("S_SupplierNO")) Then
                ai.S_SupplierNO = Nothing
            Else
                ai.S_SupplierNO = ds.Tables("Retrocede").Rows(i)("S_SupplierNO")
            End If

            If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_Qty")) Then
                ai.R_Qty = "0"
            Else
                ai.R_Qty = ds.Tables("Retrocede").Rows(i)("R_Qty")
            End If


            If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_Reason")) Then
                ai.R_Reason = Nothing
            Else
                ai.R_Reason = ds.Tables("Retrocede").Rows(i)("R_Reason")
            End If

            If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_ReturnType")) Then
                ai.R_ReturnType = Nothing
            Else
                ai.R_ReturnType = ds.Tables("Retrocede").Rows(i)("R_ReturnType")
            End If

            If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_Detail")) Then
                ai.R_Detail = Nothing
            Else
                ai.R_Detail = ds.Tables("Retrocede").Rows(i)("R_Detail")
            End If

            If IsDBNull(ds.Tables("Retrocede").Rows(i)("PM_NO")) Then
                ai.PM_NO = Nothing
            Else
                ai.PM_NO = ds.Tables("Retrocede").Rows(i)("PM_NO")
            End If

            If IsDBNull(ds.Tables("Retrocede").Rows(i)("R_SendDate")) Then
                ai.R_SendDate = Nothing
            Else
                ai.R_SendDate = ds.Tables("Retrocede").Rows(i)("R_SendDate")
            End If

            If txtRemark.Text = "" Then
                ai.R_RemarkT = Nothing
            Else
                ai.R_RemarkT = txtRemark.Text
            End If

            ai.R_UpdateDate = Now
          
            ac.Retrocede_Add(ai)

            Dim ac2 As New AcceptanceController
            Dim aci2 As New AcceptanceInfo
            aci2.A_AcceptanceNO = ds.Tables("Retrocede").Rows(i)("A_AcceptanceNO").ToString
            '  Label1.Text = ds.Tables("Retrocede").Rows(i)("A_AcceptanceNO")
            aci2.A_Detail = "退貨未處理"
            ac2.Acceptance_UpdateDetail(aci2)
        Next

      

        MsgBox("已保存,單號: " & R_RetrocedeNO & " ")
        Me.Close()

    End Sub



    Private Sub frmRetrocede_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mtd As New LFERP.DataSetting.SuppliersControler
        gluSupplier.Properties.DisplayMember = "S_SupplierName"
        gluSupplier.Properties.ValueMember = "S_Supplier"
        gluSupplier.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")

        CreateTables()
        ButtonEdit1.Text = "W0102"
        txtPMID.Enabled = False
        If MTypeName = "RetrocedeAddEdit" Then
            '退貨單新增或修改
            Select Case Edit
                Case False
                    DateEdit1.Text = Format(Now, "Short Date")
                    DateEdit1.Enabled = True
                    Label2.Text = "1"
                    Label3.Text = InUserID
                    txtRemark.Enabled = True

                Case True
                    If LoadData(tempValue2) = False Then Exit Sub
                    Label2.Text = CStr(CInt(Label2.Text) + 1)
                    txtPMID.Text = tempValue2
                    txtRemark.Enabled = True


            End Select

        End If


        If MTypeName = "RetrocedeCheck" Then
            '如果是退貨審核
            If LoadData(tempValue2) = False Then Exit Sub

            If CheckEdit1.Checked = True Then
                OldCheck = True
            Else
                OldCheck = False
            End If

            AdvBandedGridView1.Columns.Item("R_Qty").OptionsColumn.ReadOnly = True
            AdvBandedGridView1.Columns.Item("R_Reason").OptionsColumn.ReadOnly = True
            AdvBandedGridView1.Columns.Item("R_ReturnType").OptionsColumn.ReadOnly = True
            AdvBandedGridView1.Columns.Item("R_SendDate").OptionsColumn.ReadOnly = True
            CheckEdit1.Enabled = True
            CBA_CheckType.Enabled = True
            MemoEdit1.Enabled = True
            DateEdit2.Enabled = True
        End If


        If MTypeName = "RetrocecdeView" Then
            '如果是退貨審核
            If LoadData(tempValue2) = False Then Exit Sub

            'If CheckEdit1.Checked = True Then
            '    OldCheck = True
            'Else
            '    OldCheck = False
            'End If

            AdvBandedGridView1.Columns.Item("R_Qty").OptionsColumn.ReadOnly = True
            AdvBandedGridView1.Columns.Item("R_Reason").OptionsColumn.ReadOnly = True
            AdvBandedGridView1.Columns.Item("R_ReturnType").OptionsColumn.ReadOnly = True
            AdvBandedGridView1.Columns.Item("R_SendDate").OptionsColumn.ReadOnly = True
            'CheckEdit1.Enabled = True
            'CBA_CheckType.Enabled = True
            'MemoEdit1.Enabled = True
            'DateEdit2.Enabled = True
            cmdSave.Enabled = False
        End If



        If MTypeName = "RetrocedeAccountCheck" Then
            '如果是會計部審核
            If LoadData(tempValue2) = False Then Exit Sub


            AdvBandedGridView1.Columns.Item("R_Qty").OptionsColumn.ReadOnly = True
            AdvBandedGridView1.Columns.Item("R_Reason").OptionsColumn.ReadOnly = True
            AdvBandedGridView1.Columns.Item("R_ReturnType").OptionsColumn.ReadOnly = True
            AdvBandedGridView1.Columns.Item("R_SendDate").OptionsColumn.ReadOnly = True
            CheckEdit2.Enabled = True
            ComboBoxEdit1.Enabled = True
            MemoEdit2.Enabled = True
            Label23.Text = Format(Now, "yyyy/MM/dd")
        End If
    End Sub


    Function LoadData(ByVal R_RetrocedeNO As String) As Boolean
        '載入退貨單數據

        LoadData = True
        Dim objInfo As New RetrocedeInfo
        Dim objList As New List(Of RetrocedeInfo)
        Dim oc As New RetrocedeController
        Try
            objInfo = oc.Retrocede_Get(R_RetrocedeNO)
            If objInfo Is Nothing Then
                '沒有數據
                LoadData = False
                Exit Function
            End If
            ds.Tables("Retrocede").Rows.Clear()
            objList = oc.Retrocede_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, R_RetrocedeNO)
            Dim i As Integer
            Dim row As DataRow
            For i = 0 To objList.Count - 1
                row = ds.Tables("Retrocede").NewRow
                '   row("PM_NO") = objList(i).PM_NO
                txtPMID.Text = objList(i).R_RetrocedeNO
                ButtonEdit1.Text = objList(i).DepotNO
                gluSupplier.EditValue = objList(i).S_Supplier
                DateEdit1.Text = objList(i).R_ReturnDate
                Label2.Text = objList(i).R_Ver
                Label3.Text = objList(i).R_Action
                row("R_NO") = objList(i).R_NO
                row("A_AcceptanceNO") = objList(i).A_AcceptanceNO
                row("M_Code") = objList(i).M_Code
                row("M_Unit") = objList(i).M_Unit
                row("M_Name") = objList(i).M_Name
                row("M_Gauge") = objList(i).M_Gauge
                row("OS_BatchID") = objList(i).OS_BatchID
                row("A_SendNO") = objList(i).A_SendNo
                row("S_SupplierNO") = objList(i).S_SupplierNO
                row("R_Qty") = objList(i).R_Qty
                row("R_Reason") = objList(i).R_Reason
                row("R_ReturnType") = objList(i).R_ReturnType
                row("R_Detail") = objList(i).R_Detail
                row("PM_NO") = objList(i).PM_NO
                row("R_SendDate") = objList(i).R_SendDate
                row("PM_M_Code") = objList(i).PM_M_Code
                ds.Tables("Retrocede").Rows.Add(row)


                txtRemark.Text = objList(i).R_RemarkT
                If objList(i).R_Check = False Then
                    CheckEdit1.Checked = False
                Else
                    CheckEdit1.Checked = True
                End If
                Label5.Text = objList(i).R_CheckAction
                DateEdit2.Text = objList(i).R_CheckDate
                CBA_CheckType.Text = objList(i).R_CheckType
                MemoEdit1.Text = objList(i).R_CheckRemark



                If objList(i).R_AccountCheck = False Then
                    CheckEdit2.Checked = False
                Else
                    CheckEdit2.Checked = True
                End If
                Label17.Text = objList(i).R_AccountAction
                Label23.Text = objList(i).R_AccountCheckDate
                ComboBoxEdit1.Text = objList(i).R_AccountCheckType
                MemoEdit2.Text = objList(i).R_AccountCheckRemark

            Next


        Catch ex As Exception
            LoadData = False
            MsgBox(ex.Message)
        End Try
    End Function


    Sub CreateTables()
        '建立驗收表  Retrocede
        ds.Tables.Clear()
        With ds.Tables.Add("Retrocede")
            .Columns.Add("R_NO", GetType(String))
            .Columns.Add("R_RetrocedeNO", GetType(String))
            .Columns.Add("A_AcceptanceNO", GetType(String))
            .Columns.Add("PM_NO", GetType(String))
            .Columns.Add("DepotNO", GetType(String))
            .Columns.Add("S_Supplier", GetType(String))
            .Columns.Add("S_SupplierNO", GetType(String))
            .Columns.Add("A_SendNO", GetType(String))
            .Columns.Add("R_ReturnDate", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("OS_BatchID", GetType(String))
            .Columns.Add("R_Qty", GetType(String))
            .Columns.Add("R_RemarkS", GetType(String))
            .Columns.Add("R_Reason", GetType(String))
            .Columns.Add("R_RemarkT", GetType(String))
            .Columns.Add("R_SendDate", GetType(String))
            .Columns.Add("R_ReturnType", GetType(String))
            .Columns.Add("R_Check", GetType(Boolean))
            .Columns.Add("R_CheckAction", GetType(String))
            .Columns.Add("R_CheckDate", GetType(String))
            .Columns.Add("R_CheckType", GetType(String))
            .Columns.Add("R_CheckRemark", GetType(String))
            .Columns.Add("R_AccountCheck", GetType(Boolean))
            .Columns.Add("R_AccountAction", GetType(String))
            .Columns.Add("R_AccountCheckDate", GetType(String))
            .Columns.Add("R_AccountCheckType", GetType(String))
            .Columns.Add("R_AccountCheckReamrk", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("R_Detail", GetType(String))
        End With


        '創建刪除數據表
        With ds.Tables.Add("DelDataRetrocede")
            .Columns.Add("R_NO", GetType(String))
        End With

        Grid.DataSource = ds.Tables("Retrocede")

    End Sub

    Private Sub ButtonEdit1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonEdit1.Click
        frmWareHouseSelect.ShowDialog()
        ButtonEdit1.Text = frmWareHouseSelect.SelectWareID

    End Sub

    Private Sub popRetrocedeAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popRetrocedeAdd.Click
        Dim i, n As Integer
        Dim myfrm As New frmRetrocedeSelect
        tempValue4 = "退貨作業"
        myfrm.ShowDialog()
        If RefreshT = True Then
            Dim arr(n) As String
            arr = Split(tempValue, ",")
            n = Len(Replace(tempValue, ",", "," & "*")) - Len(tempValue)


            For i = 0 To n

                Dim pst As New AcceptanceController
                Dim psi As New AcceptanceInfo

                psi = pst.Acceptance_GetSub(arr(i))

                'cmdExit.Text = tempValue

                Dim row As DataRow = ds.Tables("Retrocede").NewRow
                row("A_AcceptanceNO") = psi.A_AcceptanceNO
                row("A_SendNO") = psi.A_SendNO
                row("M_Code") = psi.M_Code
                row("M_Unit") = psi.M_Unit
                row("M_Name") = psi.M_Name
                row("M_Gauge") = psi.M_Gauge
                row("OS_BatchID") = psi.OS_BatchID
                row("PM_M_Code") = psi.PM_M_Code
                row("S_SupplierNO") = psi.S_SupplierNO
                row("PM_NO") = psi.PM_NO

                ds.Tables("Retrocede").Rows.Add(row)
                AdvBandedGridView1.MoveLast()


                Dim psi2 As New AcceptanceInfo
                psi2 = pst.Acceptance_Get(psi.A_AcceptanceNO)
                gluSupplier.Text = psi2.S_Supplier
            Next
        End If
        tempValue = ""
        RefreshT = False
    End Sub



    Function Check() As Boolean
        '檢查對應倉庫對應物料的庫存是否足夠
        On Error GoTo A

        Check = True
        Dim i As Integer

        'For n = 0 To ds.Tables("Retrocede").Rows.Count - 1
        '    Dim wc As New AcceptanceController
        '    Dim wiL As New List(Of AcceptanceInfo)
        '    wiL = wc.Acceptance_GetList(Nothing, ds.Tables("Retrocede").Rows(i)("A_Acceptance"), Nothing, Nothing, Nothing, Nothing, Nothing, ds.Tables("Retrocede").Rows(i)("M_Code"), Nothing, Nothing, Nothing)
        '    If CInt(wiL.Item(0).A_Qty) < CInt(ds.Tables("Retrocede").Rows(i)("R_Qty")) Then
        '        MsgBox("此驗收單驗收數量<退貨數量,無法退貨!")
        '        Check = False
        '        Exit Function
        '    End If
        'Next
        'Exit Function




        For i = 0 To ds.Tables("Retrocede").Rows.Count - 1
            If OldCheck = True Then GoTo B
            Dim wc As New WareInventoryMTController
            Dim wi As New WareInventoryInfo
            wi = wc.WareInventory_GetSub(ds.Tables("Retrocede").Rows(i)("M_Code"), ButtonEdit1.Text)
            If CInt(wi.WI_Qty) < CInt(ds.Tables("Retrocede").Rows(i)("R_Qty")) Then
                MsgBox("庫存不足,無法退貨!")
                Check = False
                Exit Function
            End If

B:          If ds.Tables("Retrocede").Rows(i)("R_ReturnType").ToString = "" Then
                MsgBox("退貨類型必須填寫！", MsgBoxStyle.OkOnly)
                Check = False
                Exit Function
            End If
        Next
        Exit Function

A:      MsgBox("倉庫無此庫存,請檢查！")
        Check = False


        Exit Function
    End Function


    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub popRetrocedeDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popRetrocedeDel.Click


        If AdvBandedGridView1.RowCount = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = AdvBandedGridView1.GetRowCellDisplayText(ArrayToString(AdvBandedGridView1.GetSelectedRows()), "R_NO")

        If DelTemp = "R_NO" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelDataRetrocede").NewRow
            row("R_NO") = DelTemp
            ds.Tables("DelDataRetrocede").Rows.Add(row)
        End If
        ds.Tables("DelDataRetrocede").Rows.RemoveAt(CInt(ArrayToString(AdvBandedGridView1.GetSelectedRows())))
    End Sub


    Sub SaveCheck()
        '審核保存
        Dim i As Integer



        For i = 0 To ds.Tables("Retrocede").Rows.Count - 1
            Dim ac As New RetrocedeController
            Dim ai As New RetrocedeInfo

            Dim spc As New SharePurchaseController
            Dim spi As New SharePurchaseInfo
            Dim spi1 As New SharePurchaseInfo

            ai.R_NO = ds.Tables("Retrocede").Rows(i)("R_NO")
            ai.R_Check = CheckEdit1.Checked
            ai.R_CheckType = CBA_CheckType.Text
            ai.R_CheckDate = DateEdit2.Text
            ai.R_CheckAction = InUserID
            ai.R_CheckRemark = MemoEdit1.Text

            ac.Retrocede_UpdateCheck(ai)   '退貨審核
            '-------------------------------------------------------------------

            spi.PM_NO = ds.Tables("Retrocede").Rows(i)("PM_NO")
            spi.M_Code = ds.Tables("Retrocede").Rows(i)("M_Code")
            spi.WH_ID = ButtonEdit1.Text

            spc.UpdatePurchase_NoSenQty(spi)  '採購未交數變更

            '-------------------------------------------------------------------
            Dim Qty As Single
            Dim wi As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
            Dim wc As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
            wi = wc.WareInventory_GetSub(ds.Tables("Retrocede").Rows(i)("M_Code"), ButtonEdit1.EditValue)

            If wi Is Nothing Then
                Qty = 0
            Else
                Qty = wi.WI_Qty
            End If

            spi1.M_Code = ds.Tables("Retrocede").Rows(i)("M_Code")
            spi1.WH_ID = ButtonEdit1.Text

            If CheckEdit1.Checked = False Then
                spi1.WI_Qty = Qty + CSng(ds.Tables("Retrocede").Rows(i)("R_Qty"))
            Else
                spi1.WI_Qty = Qty - CSng(ds.Tables("Retrocede").Rows(i)("R_Qty"))

            End If

            spc.UpdateWareInventory_WIQty2(spi1)  '倉庫庫存變更

        Next
        MsgBox("審核狀態已改變,單號: " & txtPMID.Text & " ")
        Me.Close()
    End Sub


    Sub SaveAccountCheck()
        '會計部審核保存
        Dim i As Integer


        For i = 0 To ds.Tables("Retrocede").Rows.Count - 1
            Dim ac As New RetrocedeController
            Dim ai As New RetrocedeInfo
            ai.R_NO = ds.Tables("Retrocede").Rows(i)("R_NO")
            ai.R_AccountCheck = CheckEdit2.Checked
            ai.R_AccountCheckType = ComboBoxEdit1.Text
            ai.R_AccountCheckDate = Label23.Text
            ai.R_AccountAction = InUserID
            ai.R_AccountCheckRemark = MemoEdit2.Text

            ac.Retrocede_UpdateAccCheck(ai)
        Next
        MsgBox("會計部審核狀態已改變,單號: " & txtPMID.Text & " ")
        Me.Close()

    End Sub
End Class