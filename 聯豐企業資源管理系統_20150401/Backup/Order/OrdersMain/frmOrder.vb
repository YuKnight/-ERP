Imports LFERP.DataSetting
Imports LFERP.Library.Orders
Imports DevExpress.XtraGrid.Columns
Imports LFERP.Library.Product

Public Class frmOrder
    Dim ds As New DataSet
    Dim oldCheck As Boolean
    Dim oldCheckA As Boolean

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub

    Private Sub frmOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        '  Dim SC As New SuppliersControler

        ''---------------------------------------------------------

        r_PM_M_Code.VisibleIndex = 0
        r_PM_M_Code.Width = 100
        PM_JiYu.VisibleIndex = 4
        PM_CusterNO.VisibleIndex = 3
        M_Gauge.VisibleIndex = 2
        M_Gauge.Width = 120
        Type3Name.VisibleIndex = 1
        Type3Name.Width = 120


        ''---------------------------------------------------------------------
        Dim CC As New CurrencyControler
        Dim mtd As New CusterControler
        Dim mc As New ProductController

        gluCuster.Properties.DisplayMember = "C_CusterID"
        gluCuster.Properties.ValueMember = "C_CusterID"
        gluCuster.Properties.DataSource = mtd.GetCusterList(Nothing, Nothing, Nothing)

        lueCurrency.Properties.DisplayMember = "C_ID"
        lueCurrency.Properties.ValueMember = "C_ID"
        lueCurrency.Properties.DataSource = CC.GetCurrencyList(Nothing)


        Dim mtg As New LFERP.DataSetting.CompanyControler
        gluCompany.Properties.DisplayMember = "CO_ID"
        gluCompany.Properties.ValueMember = "CO_ID"
        gluCompany.Properties.DataSource = mtg.Company_Getlist(Nothing, Nothing, Nothing, Nothing)

        rGrid.DisplayMember = "PM_M_Code"
        rGrid.ValueMember = "PM_M_Code"
        rGrid.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        CreateTables()

        Label7.Text = tempValue
        Label8.Text = tempCode
        tempValue = ""
        tempCode = ""
        TextEdit1.Text = Label7.Text

        Select Case Label8.Text
            Case "訂單資料"
                Select Case Edit

                    Case True
                        Me.Text = "訂單資料--修改"


                        TextEdit1.Enabled = False
                        gluCuster.Enabled = False

                        lueCurrency.Enabled = False
                        DateEdit1.Enabled = False
                        cmdSave.Visible = True
                        If LoadData(TextEdit1.Text) = False Then Me.Close()
                    Case False
                        Me.Text = "訂單資料--新增"

                        TextEdit1.Enabled = False
                        gluCuster.Enabled = True
                        gluCompany.Text = "LF"

                        lueCurrency.Enabled = True
                        DateEdit1.Text = Format(Now, "yyyy/MM/dd")
                        DateEdit1.Enabled = True
                        cmdSave.Visible = True
                        TextEdit1.Text = GetOM_No()

                        lueCurrency.EditValue = "RMB"

                        'SaveNew()
                End Select

                OM_Price.Visible = False
                OM_PriceCheck.Visible = False
                OM_PriceReCheck.Visible = False
                CheckEdit1.Visible = False

            Case "PreView"
                Me.Text = "訂單資料--查看"

                TextEdit1.Enabled = False
                gluCuster.Enabled = False

                lueCurrency.Enabled = False
                DateEdit1.Enabled = False
                LoadData(TextEdit1.Text)
                cmdSave.Visible = False
                OM_Price.Visible = False
                OM_PriceCheck.Visible = False
                OM_PriceReCheck.Visible = False
                CheckEdit1.Visible = False
            Case "Price"
                Me.Text = "訂單資料--單價錄入"

                LoadData(Label7.Text)

                OM_Price.Visible = True
                OM_PriceCheck.Visible = False
                OM_PriceReCheck.Visible = False
                CheckEdit1.Visible = False

                popOrderMainAdd.Visible = False   '針對單價信息操作時不允許修改訂單其他信息
                popOrderMainDel.Visible = False
            Case "CheckPrice"
                Me.Text = "訂單資料--單價審核"

                LoadData(Label7.Text)

                OM_Price.Visible = True
                OM_Price.OptionsColumn.ReadOnly = True
                OM_PriceCheck.Visible = True
                OM_PriceReCheck.Visible = False
                CheckEdit1.Visible = False
                popOrderMainAdd.Visible = False
                popOrderMainDel.Visible = False
            Case "ReCheckPrice"
                Me.Text = "訂單資料--單價鍞定"

                LoadData(Label7.Text)

                OM_Price.Visible = True
                OM_Price.OptionsColumn.ReadOnly = True
                OM_PriceCheck.Visible = True
                OM_PriceReCheck.Visible = True
                CheckEdit1.Visible = False
                popOrderMainAdd.Visible = False
                popOrderMainDel.Visible = False
            Case "OrderCheck"
                Me.Text = "訂單資料--訂單鍞定"

                LoadData(Label7.Text)

                OM_Price.Visible = True
                OM_PriceCheck.Visible = True
                OM_PriceReCheck.Visible = True
                CheckEdit1.Visible = True
                popOrderMainAdd.Visible = False
                popOrderMainDel.Visible = False

            Case "OrderCheckA"
                Me.Text = "訂單資料--訂單審核"

                LoadData(Label7.Text)

                OM_Price.Visible = False
                OM_PriceCheck.Visible = False
                OM_PriceReCheck.Visible = False
                CheckEdit1.Visible = False
                popOrderMainAdd.Visible = False
                popOrderMainDel.Visible = False
                Panel1.Visible = True


        End Select
     
    End Sub



    Function LoadData(ByVal OM_No As String) As Boolean


        LoadData = True
        Dim objInfo As New OrdersMainInfo
        Dim oc As New OrdersMainController
        Try
            objInfo = oc.OrdersMain_Get(OM_No, Nothing)
            If objInfo Is Nothing Then
                '沒有數據
                LoadData = False
                Exit Function
            End If


            gluCuster.EditValue = objInfo.OM_CusterID
            TextEdit2.Text = objInfo.OM_CusterPO
            DateEdit1.Text = CDate(objInfo.OM_PoDate)
            lueCurrency.EditValue = objInfo.OM_CurrencyID
            gluCompany.Text = objInfo.CO_ID

            '2013-8-28
            If objInfo.OM_CheckA = True Then
                oldCheckA = True
                CheckA.Checked = True
            Else
                oldCheckA = False
                CheckA.Checked = False
            End If
            LabAction.Text = "審核人:" & objInfo.OM_CheckAActionName
            LabCheckDate.Text = "審核日期:" & objInfo.OM_CheckADate

            If objInfo.OM_Check = True Then '訂單是否鎖定

                CheckEdit1.Checked = True
                oldCheck = True
            Else
                CheckEdit1.Checked = False
                oldCheck = False
            End If

            ds.Tables("OrdersMain").Rows.Clear()

            '@ 2012/9/13       修改
            If Me.Text = "訂單資料--修改" Then      '只能修改未交數大於0的記錄
                LoadOrdersMainToTable(oc.OrdersMain_GetList2(OM_No, Nothing))
            ElseIf Me.Text = "訂單資料--單價錄入" Then      '只加載單價未審核的記錄，已審核的不允許再修改
                LoadOrdersMainToTable(oc.OrdersMain_GetList1(OM_No, Nothing, Nothing, Nothing, Nothing, Nothing, "false", "false", "false", Nothing, Nothing))
            ElseIf Me.Text = "訂單資料--單價審核" Then      '只加載單價未鍞定的記錄，已鍞定的不允許再審核
                LoadOrdersMainToTable(oc.OrdersMain_GetList1(OM_No, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "false", "false", Nothing, Nothing))
            Else
                LoadOrdersMainToTable(oc.OrdersMain_GetList(OM_No, Nothing, Nothing, Nothing, Nothing, Nothing))
            End If

        Catch ex As Exception
            LoadData = False
            MsgBox(ex.Message)
        End Try



    End Function

    Sub CreateTables()

        ds.Tables.Clear()
        '創建數據表
        With ds.Tables.Add("OrdersMain")
   
            .Columns.Add("OM_ID", GetType(String))

            .Columns.Add("OM_CusterNO", GetType(String))
            .Columns.Add("OM_SendDate", GetType(Date))
            .Columns.Add("OM_CheckDate", GetType(Date))
  
            .Columns.Add("OM_OrderQty", GetType(Integer))
       
            .Columns.Add("OM_OrderSpare", GetType(Single))

            .Columns.Add("OM_Remark", GetType(String))

            .Columns.Add("OM_Gauge", GetType(String))

            .Columns.Add("OM_Price", GetType(Decimal))   '單價
            .Columns.Add("OM_PriceCheck", GetType(Boolean))   '單價審核
            .Columns.Add("OM_PriceReCheck", GetType(Boolean))  '單價鎖定
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_JiYu", GetType(String))

            ''2013-5-27 中規格與類型

            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("Type3Name", GetType(String))
        End With
        '創建刪除數據表
        With ds.Tables.Add("DelData")
            .Columns.Add("OM_ID", GetType(String))
        End With
        '綁定表格
        Grid.DataSource = ds.Tables("OrdersMain")
    End Sub


    Sub LoadOrdersMainToTable(ByVal tList As List(Of OrdersMainInfo))

        '載入本訂單號各行資料
        If tList Is Nothing Then Exit Sub

        On Error Resume Next
        Dim i As Integer
        Dim row As DataRow
        For i = 0 To tList.Count - 1
            row = ds.Tables("OrdersMain").NewRow

            row("OM_ID") = tList(i).OM_ID
            row("OM_CusterNO") = tList(i).OM_CusterNO
            row("OM_SendDate") = CDate(tList(i).OM_SendDate)
            row("OM_CheckDate") = CDate(tList(i).OM_CheckDate)
            row("OM_OrderQty") = tList(i).OM_OrderQty
            row("OM_OrderSpare") = tList(i).OM_OrderSpare
            row("OM_Remark") = tList(i).OM_Remark
            row("OM_Gauge") = tList(i).OM_Gauge
            row("PM_M_Code") = tList(i).PM_M_Code
            row("PM_JiYu") = tList(i).PM_JiYu

            row("OM_Price") = tList(i).OM_Price
            row("OM_PriceCheck") = tList(i).OM_PriceCheck
            row("OM_PriceReCheck") = tList(i).OM_PriceReCheck

            ''-----2013-5-27-----------------------------------------
            Dim ptc As New ProductController
            Dim pti As New ProductInfo
            pti = ptc.Product_Get(tList(i).PM_M_Code)
            row("M_Gauge") = pti.M_Gauge
            row("Type3Name") = pti.Type3Name

            ds.Tables("OrdersMain").Rows.Add(row)
        Next


    End Sub


    Function GetOM_No() As String
        '生成新訂單號
        Dim oc As New OrdersMainController
        Dim oi As New OrdersMainInfo
        oi = oc.OrdersMain_Get(Nothing, Nothing)
        If oi Is Nothing Then
            GetOM_No = "OM00000001"
        Else
            GetOM_No = "OM" & Mid((CInt(Mid(oi.OM_No, 3)) + 100000001), 2)
        End If


    End Function

    Sub SaveNew()
        Dim i As Integer
        Dim OM_No As String
   
        OM_No = GetOM_No()

        If ds.Tables("OrdersMain").Rows.Count = 0 Then Exit Sub
        For i = 0 To ds.Tables("OrdersMain").Rows.Count - 1

            Dim oi As New OrdersMainInfo
            Dim oc As New OrdersMainController
            oi.OM_No = OM_No
            oi.OM_ID = Nothing
            oi.OM_CusterID = gluCuster.Text
            '   oi.OM_CusterPO = TextEdit2.Text
            If TextEdit2.Text = "" Then
                oi.OM_CusterPO = Nothing
            Else
                oi.OM_CusterPO = TextEdit2.Text
            End If

            oi.OM_CusterNO = ds.Tables("OrdersMain").Rows(i)("OM_CusterNO")

            If IsDBNull(ds.Tables("OrdersMain").Rows(i)("OM_SendDate")) Then
                oi.OM_SendDate = Nothing
            Else
                oi.OM_SendDate = ds.Tables("OrdersMain").Rows(i)("OM_SendDate")
            End If

            If IsDBNull(ds.Tables("OrdersMain").Rows(i)("OM_CheckDate")) Then
                oi.OM_CheckDate = Nothing
            Else
                oi.OM_CheckDate = ds.Tables("OrdersMain").Rows(i)("OM_CheckDate")
            End If


            If IsDBNull(ds.Tables("OrdersMain").Rows(i)("OM_Gauge")) Then
                oi.OM_Gauge = Nothing
            Else
                oi.OM_Gauge = ds.Tables("OrdersMain").Rows(i)("OM_Gauge")
            End If


            If IsDBNull(ds.Tables("OrdersMain").Rows(i)("OM_Remark")) Then
                oi.OM_Remark = Nothing
            Else
                oi.OM_Remark = ds.Tables("OrdersMain").Rows(i)("OM_Remark")
            End If

            oi.CO_ID = gluCompany.Text




            oi.OM_AddDate = Now
            oi.OM_EditDate = Now

            If DateEdit1.Text <> "" Then
                oi.OM_PoDate = DateEdit1.Text

            Else
                oi.OM_PoDate = Nothing
            End If


            If IsDBNull(ds.Tables("OrdersMain").Rows(i)("OM_OrderQty")) Then
                oi.OM_OrderQty = 0
            Else
                oi.OM_OrderQty = ds.Tables("OrdersMain").Rows(i)("OM_OrderQty")
            End If

            oi.OM_NoMakeQty = ds.Tables("OrdersMain").Rows(i)("OM_OrderQty")
            oi.OM_NoSendQty = ds.Tables("OrdersMain").Rows(i)("OM_OrderQty")
            oi.OM_NoOutQty = ds.Tables("OrdersMain").Rows(i)("OM_OrderQty")

            If IsDBNull(ds.Tables("OrdersMain").Rows(i)("OM_OrderSpare")) Then
                oi.OM_OrderSpare = 0
            Else
                oi.OM_OrderSpare = ds.Tables("OrdersMain").Rows(i)("OM_OrderSpare")
            End If
    
            oi.OM_CurrencyID = lueCurrency.Text
            oi.OM_Action = InUserID
            oi.PM_M_Code = ds.Tables("OrdersMain").Rows(i)("PM_M_Code")

            oc.OrdersMain_Add(oi)

        Next


        If OM_No <> TextEdit1.Text Then
            MsgBox("單號已經更改為 '" & OM_No & " '")
        End If

        MsgBox("新增完成!", 64, "提示")

        Me.Close()


    End Sub

    Sub SaveEdit()
        On Error Resume Next
        Dim i As Integer
        If ds.Tables("OrdersMain").Rows.Count = 0 Then Exit Sub
        For i = 0 To ds.Tables("OrdersMain").Rows.Count - 1

            If IsDBNull(ds.Tables("OrdersMain").Rows(i)("OM_ID")) Then
                '如果資料是新增加的
                Dim oi As New OrdersMainInfo
                Dim oc As New OrdersMainController
                oi.OM_No = TextEdit1.Text
                oi.OM_ID = Nothing
                oi.OM_CusterID = gluCuster.Text
                '  oi.OM_CusterPO = TextEdit2.Text
                oi.OM_CusterNO = ds.Tables("OrdersMain").Rows(i)("OM_CusterNO")


                If TextEdit2.Text = "" Then
                    oi.OM_CusterPO = Nothing
                Else
                    oi.OM_CusterPO = TextEdit2.Text
                End If

                If IsDBNull(ds.Tables("OrdersMain").Rows(i)("OM_SendDate")) Then
                    oi.OM_SendDate = Nothing
                Else
                    oi.OM_SendDate = ds.Tables("OrdersMain").Rows(i)("OM_SendDate")
                End If

                If IsDBNull(ds.Tables("OrdersMain").Rows(i)("OM_CheckDate")) Then
                    oi.OM_CheckDate = Nothing
                Else
                    oi.OM_CheckDate = ds.Tables("OrdersMain").Rows(i)("OM_CheckDate")
                End If



                oi.CO_ID = gluCompany.Text
                oi.OM_AddDate = Now
                oi.OM_EditDate = Now

                If DateEdit1.Text <> "" Then
                    oi.OM_PoDate = DateEdit1.Text

                Else
                    oi.OM_PoDate = Nothing
                End If



                oi.OM_OrderQty = ds.Tables("OrdersMain").Rows(i)("OM_OrderQty")
                oi.OM_NoMakeQty = ds.Tables("OrdersMain").Rows(i)("OM_OrderQty")
                oi.OM_NoSendQty = ds.Tables("OrdersMain").Rows(i)("OM_OrderQty")
                oi.OM_NoOutQty = ds.Tables("OrdersMain").Rows(i)("OM_OrderQty")

                oi.OM_OrderSpare = ds.Tables("OrdersMain").Rows(i)("OM_OrderSpare")
                oi.OM_CurrencyID = lueCurrency.Text
                oi.OM_Action = InUserID
                If IsDBNull(ds.Tables("OrdersMain").Rows(i)("OM_Gauge")) Then
                    oi.OM_Gauge = Nothing
                Else
                    oi.OM_Gauge = ds.Tables("OrdersMain").Rows(i)("OM_Gauge")
                End If


                If IsDBNull(ds.Tables("OrdersMain").Rows(i)("OM_Remark")) Then
                    oi.OM_Remark = Nothing
                Else
                    oi.OM_Remark = ds.Tables("OrdersMain").Rows(i)("OM_Remark")
                End If

                oi.PM_M_Code = ds.Tables("OrdersMain").Rows(i)("PM_M_Code")

                oc.OrdersMain_Add(oi)
            End If

            If Not IsDBNull(ds.Tables("OrdersMain").Rows(i)("OM_ID")) Then
                '如果資料隻是修改
                Dim oi As New OrdersMainInfo
                Dim oc As New OrdersMainController
                oi.OM_ID = ds.Tables("OrdersMain").Rows(i)("OM_ID")
                oi.OM_CusterNO = ds.Tables("OrdersMain").Rows(i)("OM_CusterNO")

                If TextEdit2.Text = " " Then
                    oi.OM_CusterPO = Nothing
                Else
                    oi.OM_CusterPO = TextEdit2.Text
                End If


                If IsDBNull(ds.Tables("OrdersMain").Rows(i)("OM_SendDate")) Then
                    oi.OM_SendDate = Nothing
                Else
                    oi.OM_SendDate = ds.Tables("OrdersMain").Rows(i)("OM_SendDate")
                End If

                If IsDBNull(ds.Tables("OrdersMain").Rows(i)("OM_CheckDate")) Then
                    oi.OM_CheckDate = Nothing
                Else
                    oi.OM_CheckDate = ds.Tables("OrdersMain").Rows(i)("OM_CheckDate")
                End If

                oi.OM_EditDate = Now
                oi.CO_ID = gluCompany.Text


                oi.OM_OrderQty = ds.Tables("OrdersMain").Rows(i)("OM_OrderQty")
                oi.OM_OrderSpare = ds.Tables("OrdersMain").Rows(i)("OM_OrderSpare")
                oi.OM_Action = InUserID
                If IsDBNull(ds.Tables("OrdersMain").Rows(i)("OM_Gauge")) Then
                    oi.OM_Gauge = Nothing
                Else
                    oi.OM_Gauge = ds.Tables("OrdersMain").Rows(i)("OM_Gauge")
                End If


                If IsDBNull(ds.Tables("OrdersMain").Rows(i)("OM_Remark")) Then
                    oi.OM_Remark = Nothing
                Else
                    oi.OM_Remark = ds.Tables("OrdersMain").Rows(i)("OM_Remark")
                End If

                oi.PM_M_Code = ds.Tables("OrdersMain").Rows(i)("PM_M_Code")

                oc.OrdersMain_Update(oi)


            End If

         
        Next

        '更新刪除的記錄
        If ds.Tables("DelData").Rows.Count > 0 Then
            For i = 0 To ds.Tables("DelData").Rows.Count - 1
                Dim oi As New OrdersMainInfo
                Dim oc As New OrdersMainController
                oi.OM_ID = ds.Tables("DelData").Rows(i)("OM_ID")
                oc.OrdersMain_OMID_Del(oi)
            Next i
        End If

        MsgBox("修改完成!", 64, "提示")

        Me.Close()
    End Sub

    Sub UpdatePrice()   '設置單價

        Dim i As Integer
        Dim oi As New OrdersMainInfo
        Dim oc As New OrdersMainController

        For i = 0 To ds.Tables("OrdersMain").Rows.Count - 1

            oi.OM_ID = ds.Tables("OrdersMain").Rows(i)("OM_ID")
            oi.OM_Price = ds.Tables("OrdersMain").Rows(i)("OM_Price")

            oc.OrdersMain_UpdatePrice(oi)
        Next
        MsgBox("完成單價設置！")
        Me.Close()
    End Sub

    Sub UpdateCheck()   '審核單價
        Dim i As Integer
        Dim oi As New OrdersMainInfo
        Dim oc As New OrdersMainController

        For i = 0 To ds.Tables("OrdersMain").Rows.Count - 1

            oi.OM_ID = ds.Tables("OrdersMain").Rows(i)("OM_ID")

            oi.OM_PriceCheck = ds.Tables("OrdersMain").Rows(i)("OM_PriceCheck")

            oc.OrdersMain_UpdateCheck(oi)
        Next
        MsgBox("完成單價審核！")
        Me.Close()
    End Sub

    Sub UpdateReCheck() '鎖定子項單價
        Dim i As Integer
        Dim oi As New OrdersMainInfo
        Dim oc As New OrdersMainController

        For i = 0 To ds.Tables("OrdersMain").Rows.Count - 1

            oi.OM_ID = ds.Tables("OrdersMain").Rows(i)("OM_ID")
            oi.OM_PriceReCheck = ds.Tables("OrdersMain").Rows(i)("OM_PriceReCheck")
            oi.OM_PriceCheck = ds.Tables("OrdersMain").Rows(i)("OM_PriceCheck")

            oc.OrdersMain_UpdateCheck(oi)
            oc.OrdersMain_UpdateReCheck(oi)
        Next
        MsgBox("完成單價鎖定！")
        Me.Close()
    End Sub

    Sub UpdateOrderCheck() '鎖定訂單單價
        Dim oi As New OrdersMainInfo
        Dim oc As New OrdersMainController

        If CheckEdit1.Checked = oldCheck Then
            MsgBox("當前審核狀態未改變")
            Exit Sub
        End If

        oi.OM_No = TextEdit1.Text
        oi.OM_Check = CheckEdit1.Checked

        oc.OrdersMain_Check(oi)
        MsgBox("完成訂單鎖定！")
        Me.Close()
    End Sub


    Sub OrdersMain_UpdateCheckA() '

        If CheckA.Checked = oldCheckA Then
            MsgBox("當前審核狀態未改變")
            CheckA.Select()
            Exit Sub
        End If
        '-------------------------------------
        Dim i As Integer
        Dim oi As New OrdersMainInfo
        Dim oc As New OrdersMainController

        For i = 0 To ds.Tables("OrdersMain").Rows.Count - 1

            oi.OM_ID = ds.Tables("OrdersMain").Rows(i)("OM_ID").ToString
            oi.OM_CheckA = Me.CheckA.Checked
            oi.OM_CheckAAction = InUserID
            oi.OM_CheckADate = Format(Now, "yyyy/MM/dd HH:mm:ss")

            If oc.OrdersMain_UpdateCheckA(oi) = True Then
            Else
                Exit Sub
            End If
        Next
        MsgBox("審核成功！")
        Me.Close()
    End Sub

    Private Sub popOrderMainAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popOrderMainAdd.Click

        Dim row As DataRow = ds.Tables("OrdersMain").NewRow()
        row("OM_OrderQty") = 0
        row("OM_OrderSpare") = 0
        row("PM_M_Code") = ""
        ds.Tables("OrdersMain").Rows.Add(row)
        GridView1.MoveLast()
    End Sub

  

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim i, j%

        '@ 2012/9/11       添加  條件判斷
        'If gluCuster.Text = "" Or gluCuster.Text Is Nothing Then
        '    MsgBox("客戶代號不能為空，請輸入客戶代號！", 64, "提示")
        '    gluCuster.Focus()
        '    Exit Sub
        'End If
        'If TextEdit2.Text = "" Then
        '    MsgBox("客戶PO不能為空，請輸入客戶PO！", 64, "提示")
        '    TextEdit2.Focus()
        '    Exit Sub
        'End If

        If ds.Tables("OrdersMain").Rows.Count = 0 Then
            MsgBox("請添加客戶編號等基本信息！", 64, "提示")
            Grid.Focus()
            Exit Sub
        End If

        For i = 0 To ds.Tables("OrdersMain").Rows.Count - 1
            If IsDBNull(ds.Tables("OrdersMain").Rows(i)("PM_M_Code")) Then
                MsgBox("產品編號不能為空，請輸入產品編號！", 64, "提示")
                Grid.Focus()
                GridView1.FocusedRowHandle = i
                Exit Sub
            End If

            If ds.Tables("OrdersMain").Rows(i)("OM_OrderQty") <= 0 Then
                MsgBox("訂單數量不能小於等於零！", 64, "提示")
                Grid.Focus()
                GridView1.FocusedRowHandle = i
                Exit Sub
            End If

            For j = 0 To ds.Tables("OrdersMain").Rows.Count - 1
                If i <> j Then
                    If ds.Tables("OrdersMain").Rows(i)("PM_M_Code").ToString = ds.Tables("OrdersMain").Rows(j)("PM_M_Code").ToString Then
                        MsgBox("同一張訂單中不能存在相同的產品編號！", 64, "提示")
                        Grid.Focus()
                        GridView1.FocusedRowHandle = j
                        Exit Sub
                    End If
                End If
            Next
        Next

        Select Case Label8.Text
            Case "訂單資料"
                Select Case Edit
                    Case False
                        Grid.DataSource = ds.Tables("OrdersMain")
                        SaveNew()

                    Case True
                        SaveEdit()

                End Select

            Case "Price"

                UpdatePrice()

            Case "CheckPrice"

                UpdateCheck()

            Case "ReCheckPrice"

                UpdateReCheck()

            Case "OrderCheck"

                UpdateOrderCheck()
            Case "OrderCheckA"
                OrdersMain_UpdateCheckA()

        End Select

    End Sub

    Private Sub popOrderMainDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popOrderMainDel.Click
      

        'If ds.Tables("OrdersMain").Rows.Count = 1 Then
        '    MsgBox("不能刪除最后一條記錄!", , "提示")
        '    Exit Sub
        'End If
        If GridView1.RowCount = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "OM_ID")
        Dim osc As New OrdersSubController
        Dim osilist As New List(Of OrdersSubInfo)


        osilist = osc.OrdersSub_GetList(DelTemp, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If osilist.Count <> 0 Then
            MsgBox("此行記錄已經創建了批次,請刪除相應批次後再刪除此記錄!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If


        If DelTemp = "OM_ID" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelData").NewRow
            row("OM_ID") = DelTemp
            ds.Tables("DelData").Rows.Add(row)
        End If
        ds.Tables("OrdersMain").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))

    End Sub
  
    Private Sub gluCuster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluCuster.KeyDown, gluCompany.KeyDown, lueCurrency.KeyDown, RepositoryItemMemoExEdit1.KeyDown, RepositoryItemMemoExEdit2.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub

    '@ 2012/9/12   添加  單價小於等於零時，不允許審核
    Private Sub RepositoryItemCheckEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit1.CheckedChanged
        If sender.checked = True Then
            If ds.Tables("OrdersMain").Rows(GridView1.FocusedRowHandle)("OM_Price") <= 0 Then
                MsgBox("單價不能小於等於零，請重新輸入單價！", 64, "提示")
                sender.checked = False
            End If
        Else
            GridView1.SetFocusedRowCellValue(OM_PriceCheck, False)
            GridView1.SetFocusedRowCellValue(OM_PriceReCheck, False)
        End If
    End Sub

    '@ 2012/9/12   添加  單價小於等於零時，不允許鍞定
    Private Sub RepositoryItemCheckEdit2_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit2.EditValueChanged
        If sender.checked = True Then
            If ds.Tables("OrdersMain").Rows(GridView1.FocusedRowHandle)("OM_PriceCheck") = False Then
                If ds.Tables("OrdersMain").Rows(GridView1.FocusedRowHandle)("OM_Price") <= 0 Then
                    MsgBox("單價不能小於等於零，請重新輸入單價！", 64, "提示")
                    sender.checked = False
                Else
                    GridView1.SetFocusedRowCellValue(OM_PriceCheck, True)
                    GridView1.SetFocusedRowCellValue(OM_PriceReCheck, True)
                End If
            End If
        End If
    End Sub

    '@ 2013/3/27 添加
    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim osc As New OrdersSubController
        If IsDBNull(GridView1.GetFocusedRowCellValue("OM_ID")) Then
            PM_M_Code.OptionsColumn.ReadOnly = False
            Exit Sub
        Else
            PM_M_Code.OptionsColumn.ReadOnly = True
        End If

        'If osc.OrdersSub_GetList1(GridView1.GetFocusedRowCellValue("OM_ID"), Nothing, Nothing, Nothing, "大貨批次", Nothing, Nothing).Count > 0 Then
        '    PM_M_Code.OptionsColumn.ReadOnly = True
        'Else
        '    PM_M_Code.OptionsColumn.ReadOnly = False
        'End If

    End Sub

    '@ 2013/3/27 添加
    Private Sub rGrid_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rGrid.EditValueChanged
        Dim ptc As New ProductController
        Dim pti As New ProductInfo
        pti = ptc.Product_Get(sender.text)

        ds.Tables("OrdersMain").Rows(GridView1.FocusedRowHandle)("PM_JiYu") = pti.PM_JiYu
        ds.Tables("OrdersMain").Rows(GridView1.FocusedRowHandle)("OM_CusterNO") = pti.PM_CusterNO


        ds.Tables("OrdersMain").Rows(GridView1.FocusedRowHandle)("M_Gauge") = pti.M_Gauge
        ds.Tables("OrdersMain").Rows(GridView1.FocusedRowHandle)("Type3Name") = pti.Type3Name
    End Sub

End Class