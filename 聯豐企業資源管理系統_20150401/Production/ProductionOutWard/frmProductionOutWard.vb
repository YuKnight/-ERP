Imports LFERP.Library.Production.ProductionOutWard
Imports LFERP.Library.Production.ProductionType
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.ProductionDPTWareInventory
Imports LFERP.DataSetting

Public Class frmProductionOutWard
    Dim ds1 As New DataSet
    Dim ds As New DataSet
    Dim strDPT As String  '物料操作部門(針對外發部)
    Dim poc As New ProductionOutWardControl
    Dim oldcheck As Boolean

    Dim strTo, strFrom, strType As String

    Sub LoadProductionType(ByVal strCode As String, ByVal strType As String)

        ' ''Dim ptc As New ProductionOutWardTypeControl

        '' ''RepositoryItemLookUpEdit1.DataSource = ptc.ProductionOutWardType_GetList(Nothing, strCode, strType, Nothing, Nothing)
        '' ''RepositoryItemLookUpEdit1.DisplayMember = "OW_Do"
        '' ''RepositoryItemLookUpEdit1.ValueMember = "OW_Do"

        ' ''Dim pti As List(Of ProductionOutWardTypeInfo)

        ' ''ds.Tables("ProductionOutWardType").Clear()
        ' ''pti = ptc.ProductionOutWardType_GetList(Nothing, strCode, strType, Nothing, Nothing)

        ' ''Dim i As Integer

        ' ''For i = 0 To pti.Count - 1
        ' ''    Dim row As DataRow
        ' ''    row = ds.Tables("ProductionOutWardType").NewRow
        ' ''    row("OW_Do") = pti(i).OW_Do
        ' ''    ds.Tables("ProductionOutWardType").Rows.Add(row)
        ' ''    'RepositoryItemLookUpEdit1.ValueMember = pti(i).OW_Do

        ' ''Next

        ''mao 2012/3/6 改  RepositoryItemLookUpEdit1 重新加入數據時  覆蓋GridView1 顯示數據
        Dim ptc As New ProductionOutWardTypeControl
        Dim pti As List(Of ProductionOutWardTypeInfo)

        pti = ptc.ProductionOutWardType_GetList(Nothing, strCode, strType, Nothing, Nothing)
        RepositoryItemComboBox3.Items.Clear()

        Dim i As Integer
        For i = 0 To pti.Count - 1
            RepositoryItemComboBox3.Items.Add(pti(i).OW_Do)
        Next

    End Sub
    Sub LoadComanpy()

        Dim mtg As New LFERP.DataSetting.CompanyControler
        gluCompany.Properties.DisplayMember = "CO_ChsName"
        gluCompany.Properties.ValueMember = "CO_ID"
        gluCompany.Properties.DataSource = mtg.Company_Getlist(Nothing, Nothing, Nothing, Nothing)

    End Sub

    '@ 2012/1/6 添加快捷鍵    
    Private Sub frmProductionOutWard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text = tempValue
        Label7.Text = tempValue3
        Label8.Text = tempValue2
        tempValue = ""
        tempValue2 = ""
        tempValue3 = ""
        CreateTable()
        'LoadProductionType()
        LoadComanpy()

        If Label8.Text = "收料" Then '收聯豐物料
           
            txtID.Enabled = True
            OW_Do.Caption = "已完成工序"
            Label3.Text = "送貨日期(&D)：" '@ 2012/1/6 添加快捷鍵
            Label2.Text = "送貨單號(&I)："
            Label1.Text = "送貨單"
            Label11.Text = "送貨公司(&P)：" '@ 2012/1/6 添加快捷鍵

            '' ''If strInCompany = "1001" Then
            '' ''    gluCompany.EditValue = "LF"
            '' ''ElseIf strInCompany = "1002" Then
            '' ''    gluCompany.EditValue = "MG"
            '' ''ElseIf strInCompany = "1003" Then
            '' ''    gluCompany.EditValue = "WT"
            '' ''ElseIf strInCompany = "1004" Then
            '' ''    gluCompany.EditValue = "MT"
            '' ''End If

            gluCompany.EditValue = DPT_IDGetCO_ID(strInCompany)

        ElseIf Label8.Text = "發料" Then '發聯豐
     
            txtID.Enabled = False
            OW_Do.Caption = "加工要求"
            Label2.Text = "外發單號(&I)："
            Label1.Text = "外發單"
            Label11.Text = "收貨公司(&P)：" '@ 2012/1/6 添加快捷鍵

        End If

        Select Case Label4.Text

            Case "OutWard"
                If Edit = False Then

                    DateEdit1.Text = Format(Now, "yyyy/MM/dd")

                    If Label8.Text = "收料" Then
                        Me.Text = "新增--送貨單" & txtID.Text
                    Else
                        Me.Text = "新增--外發單" & txtID.Text
                    End If


                ElseIf Edit = True Then
                    txtID.Enabled = False

                    LoadData(Label7.Text)
                    Me.Text = "修改--" & txtID.Text
                End If

                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Case "PreView"
               
                LoadData(Label7.Text)
                txtID.Enabled = False
                DateEdit1.Enabled = False
                Me.Text = "查看--" & txtID.Text
                XtraTabControl1.SelectedTabPage = XtraTabPage1
                cmdSave.Visible = False
            Case "Check"
               
                LoadData(Label7.Text)
                txtID.Enabled = False
                DateEdit1.Enabled = False
                Me.Text = "審核--" & txtID.Text

                'Grid.Enabled = False

                XtraTabControl1.SelectedTabPage = XtraTabPage2

                GroupBox1.Enabled = False
                GridView1.OptionsBehavior.Editable = False
                Grid.ContextMenuStrip.Enabled = False
        End Select

    End Sub

    Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("ProductionOutWard")

            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
            .Columns.Add("Pro_NO", GetType(String))
            .Columns.Add("PS_Name", GetType(String))
            .Columns.Add("OW_Do", GetType(String))
            .Columns.Add("OW_Type", GetType(String))
            .Columns.Add("OW_Weight", GetType(Single))
            .Columns.Add("OW_Qty", GetType(Single))
            .Columns.Add("OW_Return", GetType(String))
            .Columns.Add("OW_Unit", GetType(String))
            .Columns.Add("OW_Remark", GetType(String))
            .Columns.Add("PM_JiYu", GetType(String))


        End With

        Grid.DataSource = ds.Tables("ProductionOutWard")
        With ds.Tables.Add("DelOutWard")

            .Columns.Add("OW_ID", GetType(String))
            .Columns.Add("AutoID", GetType(String))

        End With

        With ds.Tables.Add("ProductionOutWardType")
            .Columns.Add("OW_Do", GetType(String))
        End With
        RepositoryItemLookUpEdit1.DataSource = ds.Tables("ProductionOutWardType")
        RepositoryItemLookUpEdit1.DisplayMember = "OW_Do"
        RepositoryItemLookUpEdit1.ValueMember = "OW_Do"


    End Sub

    Function LoadData(ByVal OW_ID As String) As Boolean
        LoadData = True
        ds.Tables("ProductionOutWard").Clear()



        Dim poi As List(Of ProductionOutWardInfo)
        poi = poc.ProductionOutWard_GetList(OW_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If poi.Count = 0 Then
            MsgBox("沒有數據")
            LoadData = False
            Exit Function
        Else

            LoadProductionType(Nothing, Nothing)

            txtID.Text = poi(0).OW_ID
            DateEdit1.Text = Format(poi(0).OW_Date, "yyyy/MM/dd")
            txtout.Text = poi(0).OW_Out
            txtIn.Text = poi(0).OW_IN
            strType = poi(0).OW_Detail
            Label8.Text = strType
            'strTo = poi(0).OW_TO
            'strFrom = poi(0).OW_From
            If strType = "收料" Then
                gluCompany.EditValue = poi(0).OW_From
                strTo = poi(0).OW_TO
            Else
                gluCompany.EditValue = poi(0).OW_TO
                strFrom = poi(0).OW_From
            End If

            Dim row As DataRow
            Dim i As Integer

            For i = 0 To poi.Count - 1

                row = ds.Tables("ProductionOutWard").NewRow

                row("AutoID") = poi(i).AutoID
                row("PM_M_Code") = poi(i).PM_M_Code
                row("PM_Type") = poi(i).PM_Type  '實際類型

                row("Pro_NO") = poi(i).Pro_NO
                row("PS_Name") = poi(i).PS_Name
                row("OW_Do") = poi(i).OW_Do
                row("OW_Type") = poi(i).OW_Type
                row("OW_Weight") = poi(i).OW_Weight
                row("OW_Qty") = poi(i).OW_Qty
                row("OW_Return") = poi(i).OW_Return
                row("OW_Unit") = poi(i).OW_Unit
                row("OW_Remark") = poi(i).OW_Remark
                row("PM_JiYu") = poi(i).PM_JiYu '機玉

                ds.Tables("ProductionOutWard").Rows.Add(row)

            Next

            '-------------------------------------導入審核信息
            If poi(0).OW_Check = True Then
                CheckEdit1.Checked = True
                oldcheck = True
            Else
                CheckEdit1.Checked = False
                oldcheck = False
            End If
            txtCheckAction.Text = poi(0).CheckActionName
            txtCheckRemark.Text = poi(0).OW_CheckRemark
            txtCheckDate.Text = poi(0).OW_CheckDate

        End If

    End Function
#Region "獲取流水號"

    Public Function DPT_IDGetCO_ID(ByVal DPT_ID As String) As String
        DPT_IDGetCO_ID = Nothing
        Dim mtg1 As New LFERP.DataSetting.CompanyControler
        Dim mtl1 As New List(Of LFERP.DataSetting.CompanyInfo)

        mtl1 = mtg1.Company_Getlist(DPT_ID, Nothing, Nothing, Nothing)

        If mtl1.Count > 0 Then
            DPT_IDGetCO_ID = mtl1(0).CO_ID
        End If

    End Function

    Public Function GetNON(ByVal QZ As String) As String

        Dim pi As New ProductionOutWardInfo

        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = poc.ProductionOutWard_GetNO(strA)

        If pi Is Nothing Then
            GetNON = QZ & strA & "001"
        Else
            GetNON = QZ + strA + Mid((CInt(Mid(pi.OW_ID, 7)) + 1001), Len(QZ))
        End If

    End Function


    Public Function GetNO() As String   '米亞單號

        Dim pi As New ProductionOutWardInfo

        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = poc.ProductionOutWard_GetNO(strA)

        If pi Is Nothing Then
            GetNO = "MG" & strA & "001"
        Else
            GetNO = "MG" + strA + Mid((CInt(Mid(pi.OW_ID, 7)) + 1001), 2)
        End If

    End Function

    Public Function GetNO1() As String  '瓦克單號

        Dim pi As New ProductionOutWardInfo

        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = poc.ProductionOutWard_GetNO(strA)

        If pi Is Nothing Then
            GetNO1 = "WT" & strA & "001"
        Else
            GetNO1 = "WT" + strA + Mid((CInt(Mid(pi.OW_ID, 7)) + 1001), 2)
        End If

    End Function

    Public Function GetNO2() As String  '聯豐單號

        Dim pi As New ProductionOutWardInfo

        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = poc.ProductionOutWard_GetNO(strA)

        If pi Is Nothing Then
            GetNO2 = "LF" & strA & "001"
        Else
            GetNO2 = "LF" + strA + Mid((CInt(Mid(pi.OW_ID, 7)) + 1001), 2)
        End If

    End Function

    Public Function GetNO3() As String   '米亞二廠單號

        Dim pi As New ProductionOutWardInfo

        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = poc.ProductionOutWard_GetNO(strA)

        If pi Is Nothing Then
            GetNO3 = "MT" & strA & "001"
        Else
            GetNO3 = "MT" + strA + Mid((CInt(Mid(pi.OW_ID, 7)) + 1001), 2)
        End If

    End Function

#End Region

    Sub DataNew()

        Dim pi As New ProductionOutWardInfo

        If Label8.Text = "收料" Then

            If gluCompany.EditValue = "" Or IsDBNull(gluCompany.EditValue) = True Then
                MsgBox("請選擇送貨公司!", 64, "提示")
                gluCompany.Focus()
                Exit Sub
            End If

            '' ''If Mid(strInDPT_ID, 1, 4) = "1002" Then
            '' ''    pi.OW_TO = "MG"
            '' ''ElseIf Mid(strInDPT_ID, 1, 4) = "1003" Then
            '' ''    pi.OW_TO = "WT"
            '' ''ElseIf Mid(strInDPT_ID, 1, 4) = "1001" Then
            '' ''    pi.OW_TO = "LF"
            '' ''ElseIf Mid(strInDPT_ID, 1, 4) = "1004" Then
            '' ''    pi.OW_TO = "MT"
            '' ''End If

            pi.OW_TO = DPT_IDGetCO_ID(Mid(strInDPT_ID, 1, 4))

            pi.OW_From = gluCompany.EditValue
            pi.OW_Detail = "收料"
        ElseIf Label8.Text = "發料" Then

            If gluCompany.EditValue = "" Or IsDBNull(gluCompany.EditValue) = True Then
                MsgBox("請選擇收貨公司!", 64, "提示")
                gluCompany.Focus()
                Exit Sub
            End If

            '' ''If Mid(strInDPT_ID, 1, 4) = "1002" Then
            '' ''    txtID.Text = GetNO()  '調用米亞MG開頭
            '' ''    pi.OW_From = "MG"
            '' ''ElseIf Mid(strInDPT_ID, 1, 4) = "1003" Then
            '' ''    txtID.Text = GetNO1()   '調用瓦克WT開頭  
            '' ''    pi.OW_From = "WT"
            '' ''ElseIf Mid(strInDPT_ID, 1, 4) = "1001" Then
            '' ''    txtID.Text = GetNO2()   '調用聯豐LF開頭  
            '' ''    pi.OW_From = "LF"
            '' ''ElseIf Mid(strInDPT_ID, 1, 4) = "1004" Then
            '' ''    txtID.Text = GetNO3()  '調用米亞二廠MT開頭
            '' ''    pi.OW_From = "MT"
            '' ''End If

            Dim LSstr As String
            LSstr = DPT_IDGetCO_ID(Mid(strInDPT_ID, 1, 4))

            pi.OW_From = DPT_IDGetCO_ID(LSstr)
            txtID.Text = GetNON(LSstr)



            pi.OW_TO = gluCompany.EditValue
            pi.OW_Detail = "發料"
        End If


        pi.OW_ID = txtID.Text
        pi.OW_Date = DateEdit1.Text
        pi.OW_IN = txtIn.Text
        pi.OW_Out = txtout.Text
        pi.OW_Reason = MemoEdit1.Text
        pi.OW_Action = InUserID

        Dim i As Integer

        For i = 0 To ds.Tables("ProductionOutWard").Rows.Count - 1




            pi.PM_M_Code = ds.Tables("ProductionOutWard").Rows(i)("PM_M_Code")
            pi.PM_Type = ds.Tables("ProductionOutWard").Rows(i)("PM_Type")
            pi.Pro_NO = ds.Tables("ProductionOutWard").Rows(i)("Pro_NO")
            pi.OW_Do = ds.Tables("ProductionOutWard").Rows(i)("OW_Do")
            pi.OW_Type = ds.Tables("ProductionOutWard").Rows(i)("OW_Type")
            If IsDBNull(ds.Tables("ProductionOutWard").Rows(i)("OW_Weight")) Then
                pi.OW_Weight = 0
            Else
                pi.OW_Weight = ds.Tables("ProductionOutWard").Rows(i)("OW_Weight")
            End If
            If IsDBNull(ds.Tables("ProductionOutWard").Rows(i)("OW_Qty")) Then
                pi.OW_Qty = 0
            Else
                pi.OW_Qty = ds.Tables("ProductionOutWard").Rows(i)("OW_Qty")
            End If

            Dim ptc As New ProductionOutWardTypeControl
            ds.Tables("ProductionOutWard").Rows(i)("OW_Return") = ptc.ProductionOutWardType_GetList(Nothing, pi.PM_M_Code, pi.PM_Type, pi.OW_Do, Nothing)(0).OW_Return()

            pi.OW_Return = ds.Tables("ProductionOutWard").Rows(i)("OW_Return")
            pi.OW_Unit = ds.Tables("ProductionOutWard").Rows(i)("OW_Unit")
            pi.OW_Remark = ds.Tables("ProductionOutWard").Rows(i)("OW_Remark")

            poc.ProductionOutWard_Add(pi)
        Next

        MsgBox("已保存,單號: " & txtID.Text & " ")
        Me.Close()
    End Sub

    Sub DataEdit()
        Dim pi As New ProductionOutWardInfo

        pi.OW_ID = txtID.Text
        'If Mid(txtID.Text, 1, 2) = "MG" Then

        '    pi.OW_TO = gluCompany.EditValue
        '    pi.OW_From = "MG"
        '    pi.OW_Detail = "發料"
        'Else
        '    pi.OW_TO = "MG"
        '    pi.OW_From = gluCompany.EditValue
        '    pi.OW_Detail = "收料"
        'End If

        If strType = "收料" Then

            If gluCompany.EditValue = "" Or IsDBNull(gluCompany.EditValue) = True Then
                MsgBox("請選擇送貨公司!", 64, "提示")
                gluCompany.Focus()
                Exit Sub
            End If

            '' ''If Mid(txtID.Text, 1, 2) = "MG" Then
            '' ''    pi.OW_TO = "MG"
            '' ''ElseIf Mid(txtID.Text, 1, 2) = "WT" Then
            '' ''    pi.OW_TO = "WT"
            '' ''ElseIf Mid(txtID.Text, 1, 2) = "LF" Then
            '' ''    pi.OW_TO = "LF"
            '' ''ElseIf Mid(txtID.Text, 1, 2) = "MT" Then
            '' ''    pi.OW_TO = "MT"
            '' ''End If
            pi.OW_TO = DPT_IDGetCO_ID(Mid(strInDPT_ID, 1, 4))


            pi.OW_From = gluCompany.EditValue
            pi.OW_Detail = "收料"
        ElseIf strType = "發料" Then

            If gluCompany.EditValue = "" Or IsDBNull(gluCompany.EditValue) = True Then
                MsgBox("請選擇收貨公司!", 64, "提示")
                gluCompany.Focus()
                Exit Sub
            End If

            '' ''If Mid(txtID.Text, 1, 2) = "MG" Then
            '' ''    pi.OW_From = "MG"
            '' ''ElseIf Mid(txtID.Text, 1, 2) = "WT" Then
            '' ''    pi.OW_From = "WT"
            '' ''ElseIf Mid(txtID.Text, 1, 2) = "LF" Then
            '' ''    pi.OW_From = "LF"
            '' ''ElseIf Mid(txtID.Text, 1, 2) = "MT" Then
            '' ''    pi.OW_From = "MT"
            '' ''End If

            pi.OW_From = DPT_IDGetCO_ID(Mid(strInDPT_ID, 1, 4))

            pi.OW_Detail = "發料"
            pi.OW_TO = gluCompany.EditValue
        End If


        'pi.OW_TO = strTo
        'pi.OW_From = strFrom
        pi.OW_Date = DateEdit1.Text
        pi.OW_IN = txtIn.Text
        pi.OW_Out = txtout.Text
        pi.OW_Reason = MemoEdit1.Text
        pi.OW_Action = InUserID

        '更新刪除的記錄
        If ds.Tables("DelOutWard").Rows.Count > 0 Then
            Dim m As Integer
            For m = 0 To ds.Tables("DelOutWard").Rows.Count - 1

                If Not IsDBNull(ds.Tables("DelOutWard").Rows(m)("AutoID")) Then
                    poc.ProductionOutWard_Delete(Nothing, ds.Tables("DelOutWard").Rows(m)("AutoID"))
                End If
            Next m
        End If
        '判斷當前記錄中加工要求等信息是否有空值~~!!
        Dim j As Integer

        For j = 0 To ds.Tables("ProductionOutWard").Rows.Count - 1
            If Len(ds.Tables("ProductionOutWard").Rows(j)("OW_Do")) = 0 Or Len(ds.Tables("ProductionOutWard").Rows(j)("OW_Type")) = 0 Then
                MsgBox("加工要求以及類型不能為空! ")
                Exit Sub
            End If
        Next

        Dim i As Integer

        For i = 0 To ds.Tables("ProductionOutWard").Rows.Count - 1

            If IsDBNull(ds.Tables("ProductionOutWard").Rows(i)("AutoID")) Then

                pi.PM_M_Code = ds.Tables("ProductionOutWard").Rows(i)("PM_M_Code")
                pi.PM_Type = ds.Tables("ProductionOutWard").Rows(i)("PM_Type")
                pi.Pro_NO = ds.Tables("ProductionOutWard").Rows(i)("Pro_NO")
                pi.OW_Do = ds.Tables("ProductionOutWard").Rows(i)("OW_Do")
                pi.OW_Type = ds.Tables("ProductionOutWard").Rows(i)("OW_Type")
                If IsDBNull(ds.Tables("ProductionOutWard").Rows(i)("OW_Weight")) Then
                    pi.OW_Weight = 0
                Else
                    pi.OW_Weight = ds.Tables("ProductionOutWard").Rows(i)("OW_Weight")
                End If
                If IsDBNull(ds.Tables("ProductionOutWard").Rows(i)("OW_Qty")) Then
                    pi.OW_Qty = 0
                Else
                    pi.OW_Qty = ds.Tables("ProductionOutWard").Rows(i)("OW_Qty")
                End If
                Dim ptc As New ProductionOutWardTypeControl
                ds.Tables("ProductionOutWard").Rows(i)("OW_Return") = ptc.ProductionOutWardType_GetList(Nothing, pi.PM_M_Code, pi.PM_Type, pi.OW_Do, Nothing)(0).OW_Return()

                pi.OW_Return = ds.Tables("ProductionOutWard").Rows(i)("OW_Return")
                pi.OW_Remark = ds.Tables("ProductionOutWard").Rows(i)("OW_Remark")
                pi.OW_Unit = ds.Tables("ProductionOutWard").Rows(i)("OW_Unit")

                poc.ProductionOutWard_Add(pi)

            ElseIf Not IsDBNull(ds.Tables("ProductionOutWard").Rows(i)("AutoID")) Then

                pi.AutoID = ds.Tables("ProductionOutWard").Rows(i)("AutoID")
                pi.PM_M_Code = ds.Tables("ProductionOutWard").Rows(i)("PM_M_Code")
                pi.PM_Type = ds.Tables("ProductionOutWard").Rows(i)("PM_Type")
                pi.Pro_NO = ds.Tables("ProductionOutWard").Rows(i)("Pro_NO")
                pi.OW_Do = ds.Tables("ProductionOutWard").Rows(i)("OW_Do")
                pi.OW_Type = ds.Tables("ProductionOutWard").Rows(i)("OW_Type")
                If IsDBNull(ds.Tables("ProductionOutWard").Rows(i)("OW_Weight")) Then
                    pi.OW_Weight = 0
                Else
                    pi.OW_Weight = ds.Tables("ProductionOutWard").Rows(i)("OW_Weight")
                End If
                If IsDBNull(ds.Tables("ProductionOutWard").Rows(i)("OW_Qty")) Then
                    pi.OW_Qty = 0
                Else
                    pi.OW_Qty = ds.Tables("ProductionOutWard").Rows(i)("OW_Qty")
                End If

                Dim ptc As New ProductionOutWardTypeControl
                ds.Tables("ProductionOutWard").Rows(i)("OW_Return") = ptc.ProductionOutWardType_GetList(Nothing, pi.PM_M_Code, pi.PM_Type, pi.OW_Do, Nothing)(0).OW_Return()
                pi.OW_Return = ds.Tables("ProductionOutWard").Rows(i)("OW_Return")

                pi.OW_Remark = ds.Tables("ProductionOutWard").Rows(i)("OW_Remark")
                pi.OW_Unit = ds.Tables("ProductionOutWard").Rows(i)("OW_Unit")

                poc.ProductionOutWard_Update(pi)

            End If

        Next

        MsgBox("已保存,單號: " & txtID.Text & " ")

        Me.Close()

    End Sub

    Sub UpdateCheck()
        Dim pi As New ProductionOutWardInfo

        pi.OW_ID = txtID.Text

        If CheckEdit1.Checked = oldcheck Then
            MsgBox("未改變當前審核狀態信息!")
            Exit Sub
        End If
        pi.OW_Check = CheckEdit1.Checked
        pi.OW_CheckAction = InUserID
        pi.OW_CheckRemark = txtCheckRemark.Text
        pi.OW_CheckDate = Format(Now, "yyyy/MM/dd")

        If poc.ProductionOutWard_UpdateCheck(pi) = True Then
            MsgBox("審核完成!")
        Else
            MsgBox("審核失敗,請檢查原因!")
            Exit Sub
        End If
        '---------------------------------變更當前外發部(F101)此部門工序數量
        ' If pi.OW_Check = True Then
        strDPT = "F101" '外發部
        If Label8.Text = "發料" Then '外發單記錄
            Dim pdi As List(Of ProductionDPTWareInventoryInfo)
            Dim pdc As New ProductionDPTWareInventoryControl

            Dim i As Integer

            For i = 0 To ds.Tables("ProductionOutWard").Rows.Count - 1
                Dim strQty, strReQty As Integer

                pdi = pdc.ProductionDPTWareInventory_GetList(strDPT, ds.Tables("ProductionOutWard").Rows(i)("Pro_NO"), Nothing)

                If pdi.Count = 0 Then
                    strQty = 0
                    strReQty = 0
                Else
                    strQty = pdi(0).WI_Qty '原存有大貨數量
                    strReQty = pdi(0).WI_ReQty
                End If

                Dim di As New ProductionDPTWareInventoryInfo
                di.DPT_ID = strDPT
                di.M_Code = ds.Tables("ProductionOutWard").Rows(i)("Pro_NO")


                ''2013-6-1   OW_Type

                If ds.Tables("ProductionOutWard").Rows(i)("OW_Type").ToString = "返修" Then
                    If pi.OW_Check = True Then
                        di.WI_ReQty = strReQty - CInt(ds.Tables("ProductionOutWard").Rows(i)("OW_Qty"))
                    Else
                        di.WI_ReQty = strReQty + CInt(ds.Tables("ProductionOutWard").Rows(i)("OW_Qty"))
                    End If
                    di.WI_Qty = strQty

                Else
                    If pi.OW_Check = True Then
                        di.WI_Qty = strQty - CInt(ds.Tables("ProductionOutWard").Rows(i)("OW_Qty"))
                    Else
                        di.WI_Qty = strQty + CInt(ds.Tables("ProductionOutWard").Rows(i)("OW_Qty"))
                    End If
                    di.WI_ReQty = strReQty
                End If


                pdc.UpdateProductionField_Qty(di)

                If ds.Tables("ProductionOutWard").Rows(i)("OW_Return") = "需回" Then

                    Dim pti As List(Of ProductionOutWardTypeInfo)
                    Dim pti1 As New ProductionOutWardTypeInfo
                    Dim ptc As New ProductionOutWardTypeControl

                    Dim strReturnQty As Integer

                    pti = ptc.ProductionOutWardType_GetList(Nothing, ds.Tables("ProductionOutWard").Rows(i)("PM_M_Code"), ds.Tables("ProductionOutWard").Rows(i)("PM_Type"), ds.Tables("ProductionOutWard").Rows(i)("OW_Do"), ds.Tables("ProductionOutWard").Rows(i)("OW_Return"))

                    If pti.Count = 0 Then
                        strReturnQty = 0
                    Else
                        strReturnQty = pti(0).OW_ReQty

                    End If

                    pti1.PM_M_Code = ds.Tables("ProductionOutWard").Rows(i)("PM_M_Code")
                    pti1.PM_Type = ds.Tables("ProductionOutWard").Rows(i)("PM_Type")
                    pti1.OW_Do = ds.Tables("ProductionOutWard").Rows(i)("OW_Do")
                    pti1.OW_Return = ds.Tables("ProductionOutWard").Rows(i)("OW_Return")
                    If pi.OW_Check = True Then
                        pti1.OW_ReQty = strReturnQty + CInt(ds.Tables("ProductionOutWard").Rows(i)("OW_Qty"))
                    Else
                        pti1.OW_ReQty = strReturnQty - CInt(ds.Tables("ProductionOutWard").Rows(i)("OW_Qty"))
                    End If

                    ptc.ProductionOutWardType_UpdateQty(pti1)

                End If

            Next

        ElseIf Label8.Text = "收料" Then   '送貨單記錄
            Dim pdi As List(Of ProductionDPTWareInventoryInfo)
            Dim pdc As New ProductionDPTWareInventoryControl

            Dim i As Integer

            For i = 0 To ds.Tables("ProductionOutWard").Rows.Count - 1
                Dim strQty, strReQty As Integer

                pdi = pdc.ProductionDPTWareInventory_GetList(strDPT, ds.Tables("ProductionOutWard").Rows(i)("Pro_NO"), Nothing)

                If pdi.Count = 0 Then
                    strQty = 0
                    strReQty = 0
                Else
                    strQty = pdi(0).WI_Qty '原存有大貨數量
                    strReQty = pdi(0).WI_ReQty
                End If

                Dim di As New ProductionDPTWareInventoryInfo

                di.DPT_ID = strDPT
                di.M_Code = ds.Tables("ProductionOutWard").Rows(i)("Pro_NO")


                If ds.Tables("ProductionOutWard").Rows(i)("OW_Type").ToString = "返修" Then
                    If pi.OW_Check = True Then
                        di.WI_ReQty = strReQty + CInt(ds.Tables("ProductionOutWard").Rows(i)("OW_Qty"))
                    Else
                        di.WI_ReQty = strReQty - CInt(ds.Tables("ProductionOutWard").Rows(i)("OW_Qty"))
                    End If
                    di.WI_Qty = strQty
                Else
                    If pi.OW_Check = True Then
                        di.WI_Qty = strQty + CInt(ds.Tables("ProductionOutWard").Rows(i)("OW_Qty"))
                    Else
                        di.WI_Qty = strQty - CInt(ds.Tables("ProductionOutWard").Rows(i)("OW_Qty"))
                    End If
                    di.WI_ReQty = strReQty
                End If

                pdc.UpdateProductionField_Qty(di)


                If ds.Tables("ProductionOutWard").Rows(i)("OW_Return") = "需回" Then

                    Dim pti As List(Of ProductionOutWardTypeInfo)
                    Dim pti1 As New ProductionOutWardTypeInfo
                    Dim ptc As New ProductionOutWardTypeControl

                    Dim strReturnQty As Integer

                    pti = ptc.ProductionOutWardType_GetList(Nothing, ds.Tables("ProductionOutWard").Rows(i)("PM_M_Code"), ds.Tables("ProductionOutWard").Rows(i)("PM_Type"), ds.Tables("ProductionOutWard").Rows(i)("OW_Do"), ds.Tables("ProductionOutWard").Rows(i)("OW_Return"))

                    If pti.Count = 0 Then
                        strReturnQty = 0
                    Else
                        strReturnQty = pti(0).OW_ReQty

                    End If

                    pti1.PM_M_Code = ds.Tables("ProductionOutWard").Rows(i)("PM_M_Code")
                    pti1.PM_Type = ds.Tables("ProductionOutWard").Rows(i)("PM_Type")
                    pti1.OW_Do = ds.Tables("ProductionOutWard").Rows(i)("OW_Do")
                    pti1.OW_Return = ds.Tables("ProductionOutWard").Rows(i)("OW_Return")

                    If pi.OW_Check = True Then
                        pti1.OW_ReQty = strReturnQty - CInt(ds.Tables("ProductionOutWard").Rows(i)("OW_Qty"))
                    Else
                        pti1.OW_ReQty = strReturnQty + CInt(ds.Tables("ProductionOutWard").Rows(i)("OW_Qty"))
                    End If


                    ptc.ProductionOutWardType_UpdateQty(pti1)

                End If

            Next

        End If

        '---------------------------------
        'End If

        Me.Close()

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Select Case Label4.Text
            Case "OutWard"
                If Edit = False Then
                    If Label8.Text = "發料" Then

                        If CheckData() = True Then
                            DataNew()
                        End If
                    Else
                        If txtID.Text.Trim = "" Then
                            MsgBox("單號信息不能為空！")
                            Exit Sub
                        End If
                        ''2012-10-10檢查單號是否存在
                        Dim poca As New ProductionOutWardControl
                        If poca.ProductionOutWard_GetList(txtID.Text.Trim, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing).Count > 0 Then
                            txtID.Select()
                            MsgBox("此單號已存在！")
                            Exit Sub
                        End If


                        DataNew()
                    End If
                Else
                    If Label8.Text = "發料" Then
                        If CheckData() = True Then
                            DataEdit()
                        End If
                    Else
                        If txtID.Text.Trim = "" Then
                            MsgBox("單號信息不能為空！")
                            Exit Sub
                        End If

                        DataEdit()
                    End If

                End If
            Case "Check"

                If CheckEdit1.Checked = oldcheck Then
                    MsgBox("未改變當前審核狀態信息!")
                    Exit Sub
                End If

                If Label8.Text = "發料" Then
                    If CheckEdit1.Checked = True Then  '發料 在審核時 要減庫存，就要判斷
                        If CheckData() = True Then
                            UpdateCheck()
                        End If
                    Else
                        UpdateCheck()
                    End If

                Else
                    If CheckEdit1.Checked = False Then '收料 在取消審核時 要減庫存，就要判斷
                        If CheckData() = True Then
                            UpdateCheck()
                        End If
                    Else
                        UpdateCheck()
                    End If

                End If


                'If Label8.Text = "發料" Then
                '    If CheckData() = True Then
                '        UpdateCheck()
                '    End If
                'Else
                '    UpdateCheck()
                'End If

        End Select

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub MenuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAdd.Click
        tempCode = ""
        tempValue2 = "外發單管理"
        If Label8.Text = "發料" Then

            tempValue3 = "發料"
        Else
            tempValue3 = "收料"
        End If

        frmProductionSelect.ShowDialog()
        '增加記錄
        If tempCode = "" Then
            Exit Sub
        Else
            Dim i, n As Integer
            Dim arr(n) As String
            arr = Split(tempCode, ",")
            n = Len(Replace(tempCode, ",", "," & "*")) - Len(tempCode)
            For i = 0 To n
                If arr(i) = "" Then
                    Exit Sub
                End If

                AddRow(arr(i))
            Next

        End If
        tempCode = ""
    End Sub

    Private Sub MenuDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDel.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "AutoID")

        If DelTemp = "AutoID" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelOutWard").NewRow

            row("AutoID") = ds.Tables("ProductionOutWard").Rows(GridView1.FocusedRowHandle)("AutoID")

            ds.Tables("DelOutWard").Rows.Add(row)
        End If
        ds.Tables("ProductionOutWard").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub

    Sub AddRow(ByVal M_Code As String) '通過工序編號導入相應信息(工藝類型,產品編號,類型,工序名稱等)

        'ds.Tables("ProductionOutWard").Clear()

        If M_Code = "" Then
        Else
            Dim pic As New ProcessMainControl
            Dim pci As List(Of ProcessMainInfo)

            Dim pdi As List(Of ProductionDPTWareInventoryInfo)
            Dim pdc As New ProductionDPTWareInventoryControl

            pci = pic.ProcessSub_GetList(Nothing, M_Code, Nothing, Nothing, Nothing, Nothing)
            If pci.Count = 0 Then Exit Sub
            Dim i As Integer

            For i = 0 To ds.Tables("ProductionOutWard").Rows.Count - 1
                If M_Code = ds.Tables("ProductionOutWard").Rows(i)("Pro_NO") Then
                    MsgBox("一張單不允許有重復相同工序編碼信息....")
                    Exit Sub
                End If

            Next

            For i = 0 To pci.Count - 1

                LoadProductionType(Nothing, Nothing)

                Dim row As DataRow
                row = ds.Tables("ProductionOutWard").NewRow

                row("AutoID") = Nothing
                row("PM_M_Code") = pci(i).PM_M_Code
                row("PM_Type") = pci(i).Type3ID  '實際類型
                row("PM_JiYu") = pci(i).PM_JiYu '機玉

                LoadProductionType(pci(i).PM_M_Code, pci(i).Type3ID)

                row("Pro_NO") = M_Code
                row("PS_Name") = pci(i).PS_Name
                row("OW_Do") = ""
                row("OW_Type") = ""


                If Label8.Text = "發料" Then
                    pdi = pdc.ProductionDPTWareInventory_GetList("F101", M_Code, Nothing)

                    Dim strQty As Integer
                    Dim strWeight1 As Single

                    If pdi.Count = 0 Then

                        Exit Sub
                    Else
                        strQty = pdi(0).WI_Qty
                        Dim AllWeight, strWeight, strG As Single

                        strWeight = pci(0).PS_Weight  '克/個  單重
                        strG = strWeight * CInt(pdi(0).WI_Qty)
                        AllWeight = strG / 1000  '當前數量的重量(KG)
                        strWeight1 = Format(AllWeight, "0.00") '(轉化為兩位小數)

                        row("OW_Qty") = strQty
                        row("OW_Weight") = strWeight1

                    End If

                    row("OW_Return") = ""
                    row("OW_Remark") = ""
                    row("OW_Unit") = ""

                    ds.Tables("ProductionOutWard").Rows.Add(row)
                Else
                    row("OW_Qty") = 0
                    row("OW_Weight") = 0
                    row("OW_Return") = ""
                    row("OW_Remark") = ""
                    row("OW_Unit") = ""

                    ds.Tables("ProductionOutWard").Rows.Add(row)
                End If

            Next
        End If
        GridView1.MoveLast()
    End Sub
    'mao 2012/3/6 此處不再使用
    Private Sub RepositoryItemLookUpEdit1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemLookUpEdit1.Click
        Dim Rlue As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)

        Dim ptc As New ProductionOutWardTypeControl

        Dim strA, strB As String
        strA = ds.Tables("ProductionOutWard").Rows((GridView1.FocusedRowHandle)).Item("PM_M_Code")
        strB = ds.Tables("ProductionOutWard").Rows((GridView1.FocusedRowHandle)).Item("PM_Type")
        ds.Tables("ProductionOutWardType").Clear()
        LoadProductionType(strA, strB)

        'GridView1.SetFocusedRowCellValue(OW_Do, Rlue.EditValue)
    End Sub

    '變更當前加工要求--是否需交回信息
    'mao 2012/3/6 此處不再使用
    Private Sub RepositoryItemLookUpEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemLookUpEdit1.EditValueChanged


        Dim Rlue As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)

        'Dim ptc As New ProductionOutWardTypeControl

        'Dim strA, strB As String
        'strA = ds.Tables("ProductionOutWard").Rows((GridView1.FocusedRowHandle)).Item("PM_M_Code")
        'strB = ds.Tables("ProductionOutWard").Rows((GridView1.FocusedRowHandle)).Item("PM_Type")
        'MsgBox(strA)
        'MsgBox(strB)
        Dim strC, strD As String
        strC = GridView1.GetFocusedRowCellValue("PM_M_Code").ToString
        strD = GridView1.GetFocusedRowCellValue("PM_Type").ToString

        ''MsgBox(strC)
        ''MsgBox(strD)


        LoadProductionType(strc, strd)


        GridView1.SetFocusedRowCellValue(OW_Do, Rlue.EditValue)


        'ds.Tables("ProductionOutWard").Rows((GridView1.FocusedRowHandle)).Item("OW_Return") = ptc.ProductionOutWardType_GetList(Nothing, strA, strB, Rlue.EditValue, Nothing)(0).OW_Return

        'ds.Tables("ProductionOutWard").Rows((GridView1.FocusedRowHandle)).Item("OW_Do") = Rlue.EditValue

    End Sub

    Function CheckData() As Boolean    '判斷當前外發信息

        CheckData = True

        Dim pdi As List(Of ProductionDPTWareInventoryInfo)
        Dim pdc As New ProductionDPTWareInventoryControl

        'If Edit = False Then

        '    If Label8.Text = "發料" Then

        '        If Mid(strInDPT_ID, 1, 4) = "1002" Then
        '            txtID.Text = GetNO()  '調用米亞MG開頭

        '        ElseIf Mid(strInDPT_ID, 1, 4) = "1003" Then
        '            txtID.Text = GetNO1()   '調用瓦克WT開頭  

        '        ElseIf Mid(strInDPT_ID, 1, 4) = "1001" Then
        '            txtID.Text = GetNO2()   '調用瓦克WT開頭  
        '        End If

        '    End If

        'End If


        'If txtID.Text.Trim = "" Then
        '    MsgBox("單號信息不能為空！")
        '    CheckData = False
        '    Exit Function
        'End If

        If ds.Tables("ProductionOutWard").Rows.Count <= 0 Then
            MsgBox("請添加物料明細!", 64, "提示")
            Grid.Focus()
            CheckData = False
            Exit Function
        End If

        Dim i As Integer
        For i = 0 To ds.Tables("ProductionOutWard").Rows.Count - 1

            If Len(ds.Tables("ProductionOutWard").Rows(i)("OW_Do")) = 0 Then
                MsgBox("加工要求/完成工序不能為空！")
                CheckData = False
                Exit Function
            End If

            pdi = pdc.ProductionDPTWareInventory_GetList("F101", ds.Tables("ProductionOutWard").Rows(i)("Pro_NO"), Nothing)

            If pdi.Count = 0 Then
                MsgBox("外發部當前不存在有此工序庫存信息")
                CheckData = False
                Exit Function
            Else
                '2012-7-27 暫時 不進行庫存判斷
                'If pdi(0).WI_Qty < ds.Tables("ProductionOutWard").Rows(i)("OW_Qty") Then
                '    MsgBox("當前工序外發數量大於當前外發部庫存,請確認輸入小於等於庫存數!")
                '    CheckData = False
                '    Exit Function
                'Else
                '    CheckData = True
                'End If

            End If
        Next

    End Function

    ''mao 2012/3/6 改  RepositoryItemLookUpEdit1 重新加入數據時  覆蓋GridView1 顯示數據
    Private Sub RepositoryItemComboBox3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemComboBox3.Click
        ''mao 2012/3/5
        Dim Get_LoadP_YN As Boolean

        If GridView1.RowCount > 0 Then
        Else
            Exit Sub
        End If

        Dim strA, strB As String

        strA = ds.Tables("ProductionOutWard").Rows((GridView1.FocusedRowHandle)).Item("PM_M_Code")
        strB = ds.Tables("ProductionOutWard").Rows((GridView1.FocusedRowHandle)).Item("PM_Type")

        If LabelID.Text <> strA Or LabelName.Text <> strB Then
            LabelID.Text = strA
            LabelName.Text = strB
            Get_LoadP_YN = True
        Else
            Get_LoadP_YN = False
        End If

        If Get_LoadP_YN = True Then
            LoadProductionType(strA, strB)
        End If
    End Sub

    Private Sub gluCompany_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gluCompany.EditValueChanged
        If Label8.Text = "發料" Then
            '' ''If strInCompany = "1001" And gluCompany.EditValue = "LF" Then
            '' ''    MsgBox("收貨公司不能是本公司，請重新選擇!", 64, "提示")
            '' ''    gluCompany.EditValue = ""
            '' ''    gluCompany.Focus()
            '' ''ElseIf strInCompany = "1002" And gluCompany.EditValue = "MG" Then
            '' ''    MsgBox("收貨公司不能是本公司，請重新選擇!", 64, "提示")
            '' ''    gluCompany.EditValue = ""
            '' ''    gluCompany.Focus()
            '' ''ElseIf strInCompany = "1003" And gluCompany.EditValue = "WT" Then
            '' ''    MsgBox("收貨公司不能是本公司，請重新選擇!", 64, "提示")
            '' ''    gluCompany.EditValue = ""
            '' ''    gluCompany.Focus()
            '' ''ElseIf strInCompany = "1004" And gluCompany.EditValue = "MT" Then
            '' ''    MsgBox("收貨公司不能是本公司，請重新選擇!", 64, "提示")
            '' ''    gluCompany.EditValue = ""
            '' ''    gluCompany.Focus()
            '' ''End If

            If DPT_IDGetCO_ID(Mid(strInDPT_ID, 1, 4)) = gluCompany.EditValue Then
                MsgBox("收貨公司不能是本公司，請重新選擇!", 64, "提示")
                gluCompany.EditValue = ""
                gluCompany.Focus()
            End If

        End If
    End Sub
End Class