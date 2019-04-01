Imports LFERP.Library.ProductionFieldChange
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.PieceProcess
Imports LFERP.Library.ProductionField
Imports LFERP.Library.ProductionDPTWareInventory
Imports LFERP.Library.Production.ProductionFieldDaySummary
Imports LFERP.Library.Production.ProductionAffair



Public Class frmProductionFieldChange

    Dim ds As New DataSet
    Dim pc As New ProductionFieldChangeControl
    Dim oldCheck As Boolean

    Dim uc As New WorkGroupControl

    Sub LoadBriName()
        Me.RepositoryItemLookUpEdit1.DataSource = uc.FacBriSearch_GetList(Nothing, Nothing, Nothing, Nothing, Nothing)
        Me.RepositoryItemLookUpEdit1.DisplayMember = "DepName"
        Me.RepositoryItemLookUpEdit1.ValueMember = "DepID"
    End Sub


    Private Sub frmProductionFieldChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '@ 2012/5/14 添加 判斷是否需要刷卡
        If strRefCard = "是" Then
        Else
            btnRefCard.Visible = False
            txtCardID.Visible = False
            SimpleButton2.Visible = False
        End If

        Label7.Text = tempValue2
        txtNO.Text = tempValue3

        tempValue2 = ""
        tempValue3 = ""
        CreateTable()
        LoadBriName()

        '重置新刷卡機
        Dim reset As New ResetPassWords.SetPassWords
        reset.SetPassWords()

        txtNO.Enabled = False
        DateEdit1.Enabled = False

        Select Case Label7.Text
            Case "Change"

                If Edit = False Then
                    Me.Text = "更改單--新增大貨"
                    DateEdit1.Text = Format(Now, "yyyy/MM/dd")
                    Label5.Text = UserName

                Else
                    LoadData(txtNO.Text)
                    Me.Text = "更改單--修改" & txtNO.Text
                End If
                PC_Qty.Visible = True
                PC_ReQty.Visible = False
                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Case "ChangeReQty"
                If Edit = False Then
                    Me.Text = "更改單--新增返修"
                    DateEdit1.EditValue = Format(Now, "yyyy/MM/dd")
                    Label5.Text = UserName

                Else
                    LoadData(txtNO.Text)
                    Me.Text = "更改單--修改" & txtNO.Text
                End If
                PC_Qty.Visible = False
                PC_ReQty.Visible = True
                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Case "PreView"
                LoadData(txtNO.Text)
                Me.Text = "更改單--查看" & txtNO.Text
                XtraTabControl1.SelectedTabPage = XtraTabPage1
                cmdSave.Visible = False
            Case "Check"
                Me.Text = "更改單--審核" & txtNO.Text
                LoadData(txtNO.Text)
                PC_Qty.Visible = True
                PC_ReQty.Visible = False
                XtraTabControl1.SelectedTabPage = XtraTabPage2

                GridView1.OptionsBehavior.Editable = False
                Grid.ContextMenuStrip.Enabled = False
            Case "ReCheck"
                Me.Text = "更改單--審核" & txtNO.Text
                LoadData(txtNO.Text)
                PC_Qty.Visible = False
                PC_ReQty.Visible = True
                XtraTabControl1.SelectedTabPage = XtraTabPage2

                GridView1.OptionsBehavior.Editable = False
                Grid.ContextMenuStrip.Enabled = False
        End Select
    End Sub

    Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("ProductionChange")

            .Columns.Add("IndexNO", GetType(String))
            .Columns.Add("Pro_Type", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
            .Columns.Add("PS_Name", GetType(String))
            .Columns.Add("Pro_NO", GetType(String))
            .Columns.Add("DepID", GetType(String))
            '.Columns.Add("PC_Type", GetType(String))
            .Columns.Add("PC_Qty", GetType(Single))   '大貨結餘
            .Columns.Add("PC_ReQty", GetType(Single))  '返修結餘
            .Columns.Add("PC_Remark", GetType(String))
            .Columns.Add("FP_NO", GetType(String)) '
            .Columns.Add("PM_JiYu", GetType(String)) 'PM_JiYu

        End With
        Grid.DataSource = ds.Tables("ProductionChange")

        With ds.Tables.Add("DelProductionChange")
            .Columns.Add("IndexNO", GetType(String))
        End With
    End Sub

    Function LoadData(ByVal PC_NO As String) As Boolean
        LoadData = True

        ds.Tables("ProductionChange").Clear()

        Dim pi As List(Of ProductionFieldChangeInfo)

        pi = pc.ProductionFieldChange_GetList(PC_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pi.Count = 0 Then
            MsgBox("沒有數據")
            LoadData = False
            Exit Function
        Else
            txtNO.Text = pi(0).PC_NO
            DateEdit1.Text = Format(pi(0).PC_Date, "yyyy/MM/dd")
            Label5.Text = pi(0).ActionName
            txtCardID.Text = pi(0).CardID

            '---------------------------------------------------導入審核信息
            If pi(0).PC_Check = True Then
                CheckEdit1.Checked = True
                oldCheck = True
            Else
                CheckEdit1.Checked = False
                oldCheck = False
            End If
            txtCheckAction.Text = pi(0).CheckActionName
            txtCheckDate.Text = Format(pi(0).PC_CheckDate, "yyyy/MM/dd")
            txtCheckRemark.Text = pi(0).PC_CheckRemark
            '---------------------------------------------------

            Dim row As DataRow
            Dim i As Integer

            For i = 0 To pi.Count - 1

                row = ds.Tables("ProductionChange").NewRow

                row("IndexNO") = pi(i).IndexNO
                row("Pro_Type") = pi(i).Pro_Type
                row("PM_M_Code") = pi(i).PM_M_Code
                row("PM_Type") = pi(i).PM_Type
                row("Pro_NO") = pi(i).Pro_NO  '隱藏不顯示
                row("PS_Name") = pi(i).PS_Name
                row("DepID") = pi(i).DepID
                'row("PC_Type") = pi(i).PC_Type
                row("PC_Qty") = pi(i).PC_Qty
                row("PC_ReQty") = pi(i).PC_ReQty
                row("PC_Remark") = pi(i).PC_Remark
                row("FP_NO") = pi(i).FP_NO '物料收發單號

                row("PM_JiYu") = pi(i).PM_JiYu '機玉

                ds.Tables("ProductionChange").Rows.Add(row)

            Next

        End If

    End Function

    Public Function GetNO() As String

        Dim pi As New ProductionFieldChangeInfo

        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = pc.ProductionFieldChange_GetNO(strA)

        If pi Is Nothing Then
            GetNO = "PC" & strA & "001"
        Else
            GetNO = "PC" + strA + Mid((CInt(Mid(pi.PC_NO, 7)) + 1001), 2)
        End If
    End Function

    Sub DataNew() '新增
        Dim pi As New ProductionFieldChangeInfo

        txtNO.Text = GetNO()
        pi.PC_NO = txtNO.Text
        pi.PC_Date = DateEdit1.EditValue
        pi.PC_Action = InUserID
        pi.CardID = txtCardID.Text

        Dim j As Integer

        For j = 0 To ds.Tables("ProductionChange").Rows.Count - 1
            If Len(ds.Tables("ProductionChange").Rows(j)("DepID")) = 0 Then
                MsgBox("部門編號不能為空! ")
                Exit Sub
            End If
        Next

        Dim i As Integer
        For i = 0 To ds.Tables("ProductionChange").Rows.Count - 1

            pi.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
            pi.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
            pi.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")
            pi.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")

            pi.DepID = ds.Tables("ProductionChange").Rows(i)("DepID")

            If IsDBNull(ds.Tables("ProductionChange").Rows(i)("PC_Qty")) Then
                pi.PC_Qty = 0
            Else
                pi.PC_Qty = ds.Tables("ProductionChange").Rows(i)("PC_Qty")
                If CSng(ds.Tables("ProductionChange").Rows(i)("PC_Qty")) > 0 Then
                    pi.PC_Type = "P"
                Else
                    pi.PC_Type = "D"
                End If
            End If
            pi.PC_ReQty = ds.Tables("ProductionChange").Rows(i)("PC_ReQty")
            pi.PC_Remark = ds.Tables("ProductionChange").Rows(i)("PC_Remark")

            pc.ProductionFieldChange_Add(pi)  '添加信息

        Next

        MsgBox("已保存,單號: " & txtNO.Text & " ")
        Me.Close()
    End Sub

    Sub DataEdit() '修改

        Dim pi As New ProductionFieldChangeInfo

        pi.PC_NO = txtNO.Text
        pi.PC_Date = DateEdit1.EditValue
        pi.PC_Action = InUserID
        pi.CardID = txtCardID.Text

        '更新刪除的記錄
        If ds.Tables("DelProductionChange").Rows.Count > 0 Then
            Dim m As Integer
            For m = 0 To ds.Tables("DelProductionChange").Rows.Count - 1

                If Not IsDBNull(ds.Tables("DelProductionChange").Rows(m)("IndexNO")) Then
                    pc.ProductionFieldChange_Delete(ds.Tables("DelKaiLiao").Rows(m)("IndexNO"), Nothing)
                End If
            Next m
        End If

        '判斷當前記錄中部門信息是否有空值~~!!
        Dim j As Integer

        For j = 0 To ds.Tables("ProductionChange").Rows.Count - 1
            If Len(ds.Tables("ProductionChange").Rows(j)("DepID")) = 0 Then
                MsgBox("部門編號不能為空! ")
                Exit Sub
            End If
        Next

        Dim i As Integer
        For i = 0 To ds.Tables("ProductionChange").Rows.Count - 1

            If Not IsDBNull(ds.Tables("ProductionChange").Rows(i)("IndexNO")) Then

                pi.IndexNO = ds.Tables("ProductionChange").Rows(i)("IndexNO")
                pi.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
                pi.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
                pi.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")
                pi.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")

                pi.DepID = ds.Tables("ProductionChange").Rows(i)("DepID")

                If IsDBNull(ds.Tables("ProductionChange").Rows(i)("PC_Qty")) Then
                    pi.PC_Qty = 0
                Else
                    pi.PC_Qty = ds.Tables("ProductionChange").Rows(i)("PC_Qty")
                    If CSng(ds.Tables("ProductionChange").Rows(i)("PC_Qty")) > 0 Then
                        pi.PC_Type = "P"
                    Else
                        pi.PC_Type = "D"
                    End If
                End If
                pi.PC_ReQty = ds.Tables("ProductionChange").Rows(i)("PC_ReQty")
                pi.PC_Remark = ds.Tables("ProductionChange").Rows(i)("PC_Remark")

                pc.ProductionFieldChange_Update(pi)  '添加信息

            ElseIf IsDBNull(ds.Tables("ProductionChange").Rows(i)("IndexNO")) Then

                pi.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
                pi.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
                pi.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")
                pi.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")

                pi.DepID = ds.Tables("ProductionChange").Rows(i)("DepID")

                If IsDBNull(ds.Tables("ProductionChange").Rows(i)("PC_Qty")) Then
                    pi.PC_Qty = 0
                Else
                    pi.PC_Qty = ds.Tables("ProductionChange").Rows(i)("PC_Qty")
                    If CSng(ds.Tables("ProductionChange").Rows(i)("PC_Qty")) > 0 Then
                        pi.PC_Type = "P"
                    Else
                        pi.PC_Type = "D"
                    End If
                End If
                pi.PC_ReQty = ds.Tables("ProductionChange").Rows(i)("PC_ReQty")
                pi.PC_Remark = ds.Tables("ProductionChange").Rows(i)("PC_Remark")

                pc.ProductionFieldChange_Add(pi)  '添加信息
            End If
       
        Next

        MsgBox("已保存,單號: " & txtNO.Text & " ")

        Me.Close()

    End Sub

    Sub UpdateCheck() '審核

        Dim pi As New ProductionFieldChangeInfo
        Dim i As Integer

        If oldCheck = CheckEdit1.Checked Then
            MsgBox("未改變當前審核信息")
            Exit Sub
        End If

        For i = 0 To ds.Tables("ProductionChange").Rows.Count - 1
            pi.IndexNO = ds.Tables("ProductionChange").Rows(i)("IndexNO")
            pi.PC_Check = CheckEdit1.Checked
            pi.PC_CheckAction = InUserID
            pi.PC_CheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
            pi.PC_CheckRemark = txtCheckRemark.Text

            If pc.ProductionFieldChange_UpdateCheck(pi) = False Then
                MsgBox("審核失敗,請檢查原因!")
                Exit Sub
            End If
        Next
        MsgBox("審核完成!")
        '---------------------------------------------------------------判斷當前部門此工序變更后數量

        'If CheckEdit1.Checked = True Then
        '    Dim i As Integer

        '    For i = 0 To ds.Tables("ProductionChange").Rows.Count - 1

        '        'Dim Qty, Qty1 As Integer '定義數量(得到當前部門此工序數量)
        '        'Dim pdi As List(Of ProductionDPTWareInventoryInfo)
        '        'Dim pdc As New ProductionDPTWareInventoryControl

        '        'pdi = pdc.ProductionDPTWareInventory_GetList(ds.Tables("ProductionChange").Rows(i)("DepID"), ds.Tables("ProductionChange").Rows(i)("Pro_NO"), Nothing)

        '        'If pdi.Count = 0 Then
        '        '    Qty = 0
        '        '    Qty1 = 0
        '        'Else
        '        '    Qty = pdi(0).WI_Qty '大貨結餘
        '        '    Qty1 = pdi(0).WI_ReQty  '返修結餘
        '        'End If

        '        'Dim pdi1 As New ProductionDPTWareInventoryInfo

        '        'pdi1.DPT_ID = ds.Tables("ProductionChange").Rows(i)("DepID")  '當前某條記錄部門
        '        'pdi1.M_Code = ds.Tables("ProductionChange").Rows(i)("Pro_NO") '當前某條記錄工序編號(物料編碼)
        '        'pdi1.WI_Qty = Qty + ds.Tables("ProductionChange").Rows(i)("PC_Qty") '當前某條記錄數量,一旦審核此部門工序數量變更為此數量且不允許再次更改!!
        '        'pdi1.WI_ReQty = Qty1  '返修結餘

        '        'pdc.UpdateProductionField_Qty(pdi1)

        '        If CSng(ds.Tables("ProductionChange").Rows(i)("PC_Qty")) < 0 Then  '物料發出 從部門到會計部

        '            Dim pi1 As New ProductionFieldInfo
        '            Dim pc As New ProductionFieldControl

        '            ds.Tables("ProductionChange").Rows(i)("FP_NO") = GetFPNO()
        '            pi1.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")

        '            pi1.FP_Num = GetNum()

        '            pi1.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '            pi1.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '            pi1.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")


        '            pi1.Pro_Type1 = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '            pi1.PM_M_Code1 = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '            pi1.PM_Type1 = ds.Tables("ProductionChange").Rows(i)("PM_Type")

        '            pi1.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")
        '            pi1.Pro_NO1 = ds.Tables("ProductionChange").Rows(i)("Pro_NO")

        '            pi1.FP_Qty = Math.Abs(ds.Tables("ProductionChange").Rows(i)("PC_Qty"))


        '            pi1.FP_Weight = 0

        '            pi1.FP_Date = Format(Now, "yyyy/MM/dd HH:mm:ss")
        '            pi1.FP_Detail = "PT15"
        '            pi1.FP_OutDep = ds.Tables("ProductionChange").Rows(i)("DepID")
        '            pi1.FP_InDep = "F102" '會計部
        '            pi1.FP_Remark = txtNO.Text & "  " & ds.Tables("ProductionChange").Rows(i)("PC_Remark")
        '            pi1.FP_OutAction = InUserID

        '            pi1.FP_SendType = "正常"
        '            pi1.FP_Qty1 = 0
        '            pi1.CardID = txtCardID.Text
        '            pi1.FP_OutOK = True

        '            If pc.ProductionField_Add(pi1) = True Then   '添加收發記錄



        '                '-----------------------------------------------2011-12-3  
        '                Dim pai As New ProductionAffairInfo
        '                Dim pac As New ProductionAffairControl

        '                Dim pdi As List(Of ProductionDPTWareInventoryInfo)
        '                Dim pdc As New ProductionDPTWareInventoryControl

        '                Dim pdsi As List(Of ProductionFieldDaySummaryInfo)
        '                Dim pdsc As New ProductionFieldDaySummaryControl

        '                Dim strQty, strReQty As Integer
        '                Dim strShouLiao, strJiaCun, strQuCun, strFaLiao, strCunHuo, strFanXiuIn, strFanXiuOut, strLiuBan, strSunHuai, strDiuShi, strBuNiang, strCunCang, strQuCang, strChuHuo, strWaiFaIn, strWaiFaOut, strAccIn, strAccOut, strRePairOut, strZuheOut As Integer

        '                pdi = pdc.ProductionDPTWareInventory_GetList(ds.Tables("ProductionChange").Rows(i)("DepID"), ds.Tables("ProductionChange").Rows(i)("Pro_NO"), Nothing)

        '                If pdi.Count = 0 Then
        '                    strQty = 0
        '                    strReQty = 0
        '                Else
        '                    strQty = pdi(0).WI_Qty
        '                    strReQty = pdi(0).WI_ReQty
        '                End If
        '                pdsi = pdsc.ProductionFieldDaySummary_GetList(Nothing, Nothing, Nothing, ds.Tables("ProductionChange").Rows(i)("Pro_NO"), ds.Tables("ProductionChange").Rows(i)("DepID"), Nothing, DateEdit1.Text, DateEdit1.Text)

        '                If pdsi.Count = 0 Then
        '                    strShouLiao = 0
        '                    strJiaCun = 0
        '                    strQuCun = 0
        '                    strFaLiao = 0
        '                    strCunHuo = 0
        '                    strFanXiuIn = 0
        '                    strFanXiuOut = 0
        '                    strLiuBan = 0
        '                    strSunHuai = 0
        '                    strDiuShi = 0
        '                    strBuNiang = 0
        '                    strCunCang = 0
        '                    strQuCang = 0
        '                    strChuHuo = 0
        '                    strWaiFaIn = 0
        '                    strWaiFaOut = 0
        '                    strAccIn = 0
        '                    strAccOut = 0
        '                    strRePairOut = 0
        '                    strZuheOut = 0
        '                Else
        '                    strShouLiao = pdsi(0).ShouLiao
        '                    strJiaCun = pdsi(0).JiaCun
        '                    strQuCun = pdsi(0).QuCun
        '                    strFaLiao = pdsi(0).FaLiao
        '                    strCunHuo = pdsi(0).CunHuo
        '                    strFanXiuIn = pdsi(0).FanXiuIn
        '                    strFanXiuOut = pdsi(0).FanXiuOut
        '                    strLiuBan = pdsi(0).LiuBan
        '                    strSunHuai = pdsi(0).SunHuai
        '                    strDiuShi = pdsi(0).DiuShi
        '                    strBuNiang = pdsi(0).BuNiang
        '                    strCunCang = pdsi(0).CunCang
        '                    strQuCang = pdsi(0).QuCang
        '                    strChuHuo = pdsi(0).ChuHuo
        '                    strWaiFaIn = pdsi(0).WaiFaIn
        '                    strWaiFaOut = pdsi(0).WaiFaOut
        '                    strAccIn = pdsi(0).AccIn
        '                    strAccOut = pdsi(0).AccOut
        '                    strRePairOut = pdsi(0).RePairOut
        '                    strZuheOut = pdsi(0).ZuheOut

        '                End If

        '                '-------------------------------------------------------------------
        '                pai.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '                pai.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '                pai.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")
        '                pai.Pro_Type1 = Nothing
        '                pai.PM_M_Code1 = Nothing
        '                pai.PM_Type1 = Nothing
        '                pai.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")
        '                pai.Pro_NO1 = Nothing
        '                pai.FP_OutDep = ds.Tables("ProductionChange").Rows(i)("DepID")
        '                pai.FP_InDep = Nothing

        '                pai.FP_Detail = "PT15"
        '                pai.Type = "D"

        '                '-------------------------------------------------------

        '                pai.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")
        '                pai.FP_Type = "發料"
        '                pai.FP_InAction = InUserID
        '                If CheckEdit1.Checked = True Then
        '                    pai.FP_InCheck = True
        '                Else
        '                    pai.FP_InCheck = False
        '                End If
        '                pai.CardID = txtCardID.Text

        '                pai.FP_InCheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")

        '                '------------------------------------------------------變更部門結餘數信息
        '                pai.WI_Qty = strQty + ds.Tables("ProductionChange").Rows(i)("PC_Qty")
        '                pai.WI_ReQty = strReQty
        '                pai.WI_Qty1 = 0
        '                pai.WI_ReQty1 = 0

        '                '--------------------------------------------------------------------
        '                pai.ShouLiao = strShouLiao
        '                pai.JiaCun = strJiaCun
        '                pai.LiuBan = strLiuBan
        '                pai.SunHuai = strSunHuai
        '                pai.DiuShi = strDiuShi
        '                pai.CunHuo = strCunHuo
        '                pai.BuNiang = strBuNiang
        '                pai.QuCun = strQuCun
        '                pai.FaLiao = strFaLiao
        '                pai.FanXiuIn = strFanXiuIn
        '                pai.FanXiuOut = strFanXiuOut
        '                pai.CunCang = strCunCang
        '                pai.QuCang = strQuCang
        '                pai.ChuHuo = strChuHuo
        '                pai.WaiFaIn = strWaiFaIn
        '                pai.WaiFaOut = strWaiFaOut
        '                pai.AccIn = strAccIn
        '                pai.AccOut = strAccOut + Math.Abs(ds.Tables("ProductionChange").Rows(i)("PC_Qty"))
        '                pai.RePairOut = strRePairOut
        '                pai.ZuheOut = strZuheOut

        '                '------------------------------------------存在有收有發情況下
        '                pai.ShouLiao1 = 0
        '                pai.JiaCun1 = 0
        '                pai.QuCun1 = 0
        '                pai.FaLiao1 = 0
        '                pai.CunHuo1 = 0
        '                pai.FanXiuIn1 = 0
        '                pai.FanXiuOut1 = 0
        '                pai.LiuBan1 = 0
        '                pai.SunHuai1 = 0
        '                pai.DiuShi1 = 0
        '                pai.BuNiang1 = 0
        '                pai.CunCang1 = 0
        '                pai.QuCang1 = 0
        '                pai.ChuHuo1 = 0
        '                pai.WaiFaIn1 = 0
        '                pai.WaiFaOut1 = 0
        '                pai.AccIn1 = 0
        '                pai.AccOut1 = 0
        '                pai.RePairOut1 = 0
        '                pai.ZuheOut1 = 0

        '                '------------------------------------------
        '                pai.PM_Date = DateEdit1.Text

        '                If pac.UpdateProductionCheck_Qty(pai) = True Then
        '                    '-------------------------------------------------------------------------'確認收料后的審核記錄
        '                    Dim pi2 As New ProductionFieldInfo
        '                    Dim pc2 As New ProductionFieldControl

        '                    pi2.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")
        '                    pi2.FP_Check = True
        '                    pi2.FP_CheckAction = InUserID
        '                    pi2.FP_CheckRemark = "調賬發出記錄"

        '                    pc2.ProductionField_UpdateCheck(pi2)

        '                    '-------------------------------------------------------------------------
        '                End If

        '            End If
        '        ElseIf CSng(ds.Tables("ProductionChange").Rows(i)("PC_Qty")) > 0 Then

        '            Dim pi1 As New ProductionFieldInfo
        '            Dim pc As New ProductionFieldControl

        '            ds.Tables("ProductionChange").Rows(i)("FP_NO") = GetFPNO()
        '            pi1.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")

        '            pi1.FP_Num = GetNum()

        '            pi1.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '            pi1.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '            pi1.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")


        '            pi1.Pro_Type1 = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '            pi1.PM_M_Code1 = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '            pi1.PM_Type1 = ds.Tables("ProductionChange").Rows(i)("PM_Type")

        '            pi1.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")
        '            pi1.Pro_NO1 = ds.Tables("ProductionChange").Rows(i)("Pro_NO")

        '            pi1.FP_Qty = Math.Abs(ds.Tables("ProductionChange").Rows(i)("PC_Qty"))


        '            pi1.FP_Weight = 0

        '            pi1.FP_Date = Format(Now, "yyyy/MM/dd HH:mm:ss")
        '            pi1.FP_Detail = "PT15"
        '            pi1.FP_OutDep = "F102" '會計部
        '            pi1.FP_InDep = ds.Tables("ProductionChange").Rows(i)("DepID")
        '            pi1.FP_Remark = txtNO.Text & "  " & ds.Tables("ProductionChange").Rows(i)("PC_Remark")
        '            pi1.FP_OutAction = InUserID

        '            pi1.FP_SendType = "正常"
        '            pi1.FP_Qty1 = 0
        '            pi1.CardID = txtCardID.Text
        '            pi1.FP_OutOK = True

        '            pc.ProductionField_Add(pi1) '添加調賬記錄---收入


        '            'Dim pii As New ProductionFieldInfo

        '            'pii.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")
        '            'pii.FP_Type = "收料"
        '            'pii.FP_InCheck = True
        '            'pii.FP_InAction = InUserID
        '            'pii.FP_InCheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")

        '            '    If pc.ProductionField_UpdateInCheck(pii) = True Then


        '            '        '變更當前部門當前工序確認審核后--此收發單號的結餘數量(保存此時此部門庫存數)

        '            '        Dim pi11 As New ProductionFieldInfo

        '            '        pi11.FP_NO = pi1.FP_NO
        '            '        pi11.FP_OutDep = ds.Tables("ProductionChange").Rows(i)("DepID")
        '            '        pi11.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")
        '            '        pi11.FP_Type = "收料"
        '            '        pi11.FP_EndQty = pdi1.WI_Qty
        '            '        pi11.FP_EndReQty = pdi1.WI_ReQty

        '            '        pc.ProductionField_UpdateEndQty(pi11)
        '            '        '-----------------


        '            '        '-------------------------------------------------------------------------'確認收料后的審核記錄
        '            '        '-------------------------------------------------------------------------

        '            '        Dim pfdi As List(Of ProductionFieldDaySummaryInfo)
        '            '        Dim pfdc As New ProductionFieldDaySummaryControl

        '            '        Dim udi As New ProductionFieldDaySummaryInfo

        '            '        Dim StrType As String  '類型
        '            '        Dim IntQty As Integer  '數量

        '            '        pfdi = pfdc.ProductionFieldDaySummary_GetList(Nothing, Nothing, Nothing, ds.Tables("ProductionChange").Rows(i)("Pro_NO"), ds.Tables("ProductionChange").Rows(i)("DepID"), Nothing, DateEdit1.Text, DateEdit1.Text)

        '            '        StrType = "調賬收入"
        '            '        If pfdi.Count = 0 Then
        '            '            IntQty = 0
        '            '        Else
        '            '            IntQty = pfdi(0).AccOut
        '            '        End If

        '            '        udi.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '            '        udi.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '            '        udi.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")
        '            '        udi.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")
        '            '        udi.FP_OutDep = ds.Tables("ProductionChange").Rows(i)("DepID")
        '            '        udi.PM_Date = DateEdit1.EditValue

        '            '        udi.BuNiang = 0
        '            '        udi.CunCang = 0
        '            '        udi.CunHuo = 0
        '            '        udi.DiuShi = 0
        '            '        udi.ShouLiao = 0
        '            '        udi.FanXiuIn = 0
        '            '        udi.FanXiuOut = 0
        '            '        udi.JiaCun = 0
        '            '        udi.ChuHuo = 0
        '            '        If CheckEdit1.Checked = True Then

        '            '            udi.AccIn = IntQty + Math.Abs(ds.Tables("ProductionChange").Rows(i)("PC_Qty"))

        '            '        End If
        '            '        udi.QuCang = 0
        '            '        udi.QuCun = 0
        '            '        udi.LiuBan = 0
        '            '        udi.SunHuai = 0
        '            '        udi.FaLiao = 0
        '            '        udi.WaiFaIn = 0
        '            '        udi.WaiFaOut = 0
        '            '        udi.AccOut = 0
        '            '        udi.RePairOut = 0
        '            '        udi.Type = StrType

        '            '        pfdc.UpdateProductionDaySummary_Qty(udi)   '變更發料數量(大貨產生)


        '            '    End If

        '            Dim pai As New ProductionAffairInfo
        '            Dim pac As New ProductionAffairControl

        '            Dim pdi As List(Of ProductionDPTWareInventoryInfo)
        '            Dim pdc As New ProductionDPTWareInventoryControl

        '            Dim pdsi As List(Of ProductionFieldDaySummaryInfo)
        '            Dim pdsc As New ProductionFieldDaySummaryControl

        '            Dim strQty, strReQty As Integer
        '            Dim strShouLiao, strJiaCun, strQuCun, strFaLiao, strCunHuo, strFanXiuIn, strFanXiuOut, strLiuBan, strSunHuai, strDiuShi, strBuNiang, strCunCang, strQuCang, strChuHuo, strWaiFaIn, strWaiFaOut, strAccIn, strAccOut, strRePairOut, strZuheout As Integer

        '            pdi = pdc.ProductionDPTWareInventory_GetList(ds.Tables("ProductionChange").Rows(i)("DepID"), ds.Tables("ProductionChange").Rows(i)("Pro_NO"), Nothing)

        '            If pdi.Count = 0 Then
        '                strQty = 0
        '                strReQty = 0
        '            Else
        '                strQty = pdi(0).WI_Qty
        '                strReQty = pdi(0).WI_ReQty
        '            End If
        '            pdsi = pdsc.ProductionFieldDaySummary_GetList(Nothing, Nothing, Nothing, ds.Tables("ProductionChange").Rows(i)("Pro_NO"), ds.Tables("ProductionChange").Rows(i)("DepID"), Nothing, DateEdit1.Text, DateEdit1.Text)

        '            If pdsi.Count = 0 Then
        '                strShouLiao = 0
        '                strJiaCun = 0
        '                strQuCun = 0
        '                strFaLiao = 0
        '                strCunHuo = 0
        '                strFanXiuIn = 0
        '                strFanXiuOut = 0
        '                strLiuBan = 0
        '                strSunHuai = 0
        '                strDiuShi = 0
        '                strBuNiang = 0
        '                strCunCang = 0
        '                strQuCang = 0
        '                strChuHuo = 0
        '                strWaiFaIn = 0
        '                strWaiFaOut = 0
        '                strAccIn = 0
        '                strAccOut = 0
        '                strRePairOut = 0
        '                strZuheout = 0
        '            Else
        '                strShouLiao = pdsi(0).ShouLiao
        '                strJiaCun = pdsi(0).JiaCun
        '                strQuCun = pdsi(0).QuCun
        '                strFaLiao = pdsi(0).FaLiao
        '                strCunHuo = pdsi(0).CunHuo
        '                strFanXiuIn = pdsi(0).FanXiuIn
        '                strFanXiuOut = pdsi(0).FanXiuOut
        '                strLiuBan = pdsi(0).LiuBan
        '                strSunHuai = pdsi(0).SunHuai
        '                strDiuShi = pdsi(0).DiuShi
        '                strBuNiang = pdsi(0).BuNiang
        '                strCunCang = pdsi(0).CunCang
        '                strQuCang = pdsi(0).QuCang
        '                strChuHuo = pdsi(0).ChuHuo
        '                strWaiFaIn = pdsi(0).WaiFaIn
        '                strWaiFaOut = pdsi(0).WaiFaOut
        '                strAccIn = pdsi(0).AccIn
        '                strAccOut = pdsi(0).AccOut
        '                strRePairOut = pdsi(0).RePairOut
        '                strZuheout = pdsi(0).ZuheOut

        '            End If

        '            'If CheckEdit1.Checked = oldCheck Then
        '            '    MsgBox("未改變確認狀態,不允許保存!")
        '            '    Exit Sub
        '            'End If

        '            pai.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")
        '            pai.FP_Type = "收料"
        '            pai.FP_InAction = InUserID
        '            If CheckEdit1.Checked = True Then
        '                pai.FP_InCheck = True
        '            Else
        '                pai.FP_InCheck = False
        '            End If
        '            pai.CardID = txtCardID.Text

        '            pai.FP_InCheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
        '            '-------------------------------------------------------------------
        '            pai.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '            pai.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '            pai.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")
        '            pai.Pro_Type1 = Nothing
        '            pai.PM_M_Code1 = Nothing
        '            pai.PM_Type1 = Nothing
        '            pai.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")
        '            pai.Pro_NO1 = Nothing
        '            pai.FP_OutDep = ds.Tables("ProductionChange").Rows(i)("DepID")
        '            pai.FP_InDep = "F102"

        '            pai.FP_Detail = "PT15"
        '            pai.Type = "P"

        '            '------------------------------------------------------變更部門結餘數信息
        '            pai.WI_Qty = strQty + Math.Abs(ds.Tables("ProductionChange").Rows(i)("PC_Qty"))
        '            pai.WI_ReQty = strReQty
        '            pai.WI_Qty1 = 0
        '            pai.WI_ReQty1 = 0

        '            '--------------------------------------------------------------------
        '            pai.ShouLiao = strShouLiao
        '            pai.JiaCun = strJiaCun
        '            pai.LiuBan = strLiuBan
        '            pai.SunHuai = strSunHuai
        '            pai.DiuShi = strDiuShi
        '            pai.CunHuo = strCunHuo
        '            pai.BuNiang = strBuNiang
        '            pai.QuCun = strQuCun
        '            pai.FaLiao = strFaLiao
        '            pai.FanXiuIn = strFanXiuIn
        '            pai.FanXiuOut = strFanXiuOut
        '            pai.CunCang = strCunCang
        '            pai.QuCang = strQuCang
        '            pai.ChuHuo = strChuHuo
        '            pai.WaiFaIn = strWaiFaIn
        '            pai.WaiFaOut = strWaiFaOut
        '            pai.AccIn = strAccIn + Math.Abs(ds.Tables("ProductionChange").Rows(i)("PC_Qty"))
        '            pai.AccOut = strAccOut
        '            pai.RePairOut = strRePairOut
        '            pai.ZuheOut = strZuheout

        '            '------------------------------------------存在有收有發情況下
        '            pai.ShouLiao1 = 0
        '            pai.JiaCun1 = 0
        '            pai.QuCun1 = 0
        '            pai.FaLiao1 = 0
        '            pai.CunHuo1 = 0
        '            pai.FanXiuIn1 = 0
        '            pai.FanXiuOut1 = 0
        '            pai.LiuBan1 = 0
        '            pai.SunHuai1 = 0
        '            pai.DiuShi1 = 0
        '            pai.BuNiang1 = 0
        '            pai.CunCang1 = 0
        '            pai.QuCang1 = 0
        '            pai.ChuHuo1 = 0
        '            pai.WaiFaIn1 = 0
        '            pai.WaiFaOut1 = 0
        '            pai.AccIn1 = 0
        '            pai.AccOut1 = 0
        '            pai.RePairOut1 = 0
        '            pai.ZuheOut1 = 0

        '            '------------------------------------------
        '            pai.PM_Date = DateEdit1.Text

        '            If pac.UpdateProductionCheck_Qty(pai) = True Then
        '                '-------------------------------------------------------------------- '對當前更改單生成的收發記錄審核確認
        '                Dim pi2 As New ProductionFieldInfo
        '                Dim pc2 As New ProductionFieldControl

        '                pi2.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")
        '                pi2.FP_Check = True
        '                pi2.FP_CheckAction = InUserID
        '                pi2.FP_CheckRemark = "調賬收入記錄"

        '                pc2.ProductionField_UpdateCheck(pi2)

        '                '--------------------------------------------------------------------
        '            End If


        '        End If

        '    Next

        'End If


        ''---------------------------------------------------------------判斷針對是物料收入---物料發出

        ''---------------------------------------------------------------
        Me.Close()
    End Sub

    Function GetFPNO() As String

        Dim pi As New ProductionFieldInfo
        Dim pc As New ProductionFieldControl
        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = pc.ProductionField_GetNO(strA)

        If pi Is Nothing Then
            GetFPNO = "PF" & strA & "000001"
        Else
            GetFPNO = "PF" + strA + Mid((CInt(Mid(pi.FP_NO, 7)) + 1000001), 2)
        End If

    End Function

    Function GetNum() As String

        Dim pi As New ProductionFieldInfo
        Dim pc As New ProductionFieldControl
        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = pc.ProductionField_GetNO(strA)

        If pi Is Nothing Then
            GetNum = strA & "000001"
        Else
            GetNum = strA + Mid((CInt(Mid(pi.FP_Num, 5)) + 1000001), 2)
        End If

    End Function

    Sub ReDataNew()
        Dim pi As New ProductionFieldChangeInfo

        txtNO.Text = GetNO()
        pi.PC_NO = txtNO.Text
        pi.PC_Date = DateEdit1.EditValue
        pi.PC_Action = InUserID
        pi.CardID = txtCardID.Text

        Dim j As Integer

        For j = 0 To ds.Tables("ProductionChange").Rows.Count - 1
            If Len(ds.Tables("ProductionChange").Rows(j)("DepID")) = 0 Then
                MsgBox("部門編號不能為空! ")
                Exit Sub
            End If
        Next

        Dim i As Integer
        For i = 0 To ds.Tables("ProductionChange").Rows.Count - 1

            pi.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
            pi.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
            pi.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")
            pi.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")

            pi.DepID = ds.Tables("ProductionChange").Rows(i)("DepID")

            If IsDBNull(ds.Tables("ProductionChange").Rows(i)("PC_ReQty")) Then
                pi.PC_ReQty = 0
            Else
                pi.PC_ReQty = ds.Tables("ProductionChange").Rows(i)("PC_ReQty")
                If CSng(ds.Tables("ProductionChange").Rows(i)("PC_ReQty")) > 0 Then
                    pi.PC_Type = "P"
                Else
                    pi.PC_Type = "D"
                End If
            End If
            pi.PC_Qty = ds.Tables("ProductionChange").Rows(i)("PC_Qty")
            pi.PC_Remark = ds.Tables("ProductionChange").Rows(i)("PC_Remark")

            pc.ProductionFieldChange_Add(pi)  '添加信息

        Next

        MsgBox("已保存,單號: " & txtNO.Text & " ")
        Me.Close()
    End Sub

    Sub ReDataEdit()
        Dim pi As New ProductionFieldChangeInfo

        pi.PC_NO = txtNO.Text
        pi.PC_Date = DateEdit1.EditValue
        pi.PC_Action = InUserID
        pi.CardID = txtCardID.Text


        '更新刪除的記錄
        If ds.Tables("DelProductionChange").Rows.Count > 0 Then
            Dim m As Integer
            For m = 0 To ds.Tables("DelProductionChange").Rows.Count - 1

                If Not IsDBNull(ds.Tables("DelProductionChange").Rows(m)("IndexNO")) Then
                    pc.ProductionFieldChange_Delete(ds.Tables("DelKaiLiao").Rows(m)("IndexNO"), Nothing)
                End If
            Next m
        End If

        '判斷當前記錄中部門信息是否有空值~~!!
        Dim j As Integer

        For j = 0 To ds.Tables("ProductionChange").Rows.Count - 1
            If Len(ds.Tables("ProductionChange").Rows(j)("DepID")) = 0 Then
                MsgBox("部門編號不能為空! ")
                Exit Sub
            End If
        Next

        Dim i As Integer
        For i = 0 To ds.Tables("ProductionChange").Rows.Count - 1

            If Not IsDBNull(ds.Tables("ProductionChange").Rows(i)("IndexNO")) Then

                pi.IndexNO = ds.Tables("ProductionChange").Rows(i)("IndexNO")
                pi.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
                pi.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
                pi.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")
                pi.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")

                pi.DepID = ds.Tables("ProductionChange").Rows(i)("DepID")

                If IsDBNull(ds.Tables("ProductionChange").Rows(i)("PC_ReQty")) Then
                    pi.PC_ReQty = 0
                Else
                    pi.PC_ReQty = ds.Tables("ProductionChange").Rows(i)("PC_ReQty")
                    If CSng(ds.Tables("ProductionChange").Rows(i)("PC_ReQty")) > 0 Then
                        pi.PC_Type = "P"
                    Else
                        pi.PC_Type = "D"
                    End If
                End If
                pi.PC_Qty = ds.Tables("ProductionChange").Rows(i)("PC_Qty")
                pi.PC_Remark = ds.Tables("ProductionChange").Rows(i)("PC_Remark")

                pc.ProductionFieldChange_Update(pi)  '添加信息

            ElseIf IsDBNull(ds.Tables("ProductionChange").Rows(i)("IndexNO")) Then

                pi.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
                pi.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
                pi.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")
                pi.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")

                pi.DepID = ds.Tables("ProductionChange").Rows(i)("DepID")

                If IsDBNull(ds.Tables("ProductionChange").Rows(i)("PC_ReQty")) Then
                    pi.PC_ReQty = 0
                Else
                    pi.PC_ReQty = ds.Tables("ProductionChange").Rows(i)("PC_ReQty")
                    If CSng(ds.Tables("ProductionChange").Rows(i)("PC_ReQty")) > 0 Then
                        pi.PC_Type = "P"
                    Else
                        pi.PC_Type = "D"
                    End If
                End If
                pi.PC_Qty = ds.Tables("ProductionChange").Rows(i)("PC_Qty")
                pi.PC_Remark = ds.Tables("ProductionChange").Rows(i)("PC_Remark")

                pc.ProductionFieldChange_Add(pi)  '添加信息
            End If

        Next

        MsgBox("已保存,單號: " & txtNO.Text & " ")

        Me.Close()
    End Sub

    Sub ReUpdateCheck() '審核--返修結餘

        Dim pi As New ProductionFieldChangeInfo
        Dim i As Integer

        If oldCheck = CheckEdit1.Checked Then
            MsgBox("未改變當前審核信息")
            Exit Sub
        End If

        For i = 0 To ds.Tables("ProductionChange").Rows.Count - 1
            pi.IndexNO = ds.Tables("ProductionChange").Rows(i)("IndexNO")
            pi.PC_Check = CheckEdit1.Checked
            pi.PC_CheckAction = InUserID
            pi.PC_CheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
            pi.PC_CheckRemark = txtCheckRemark.Text

            If pc.ProductionFieldChange_UpdateCheck(pi) = False Then
                MsgBox("審核失敗,請檢查原因!")
                Exit Sub
            End If
        Next

        MsgBox("審核完成!")
        '---------------------------------------------------------------判斷當前部門此工序變更后數量

        'If CheckEdit1.Checked = True Then
        '    Dim i As Integer

        '    For i = 0 To ds.Tables("ProductionChange").Rows.Count - 1

        '        Dim Qty, Qty1 As Integer '定義數量(得到當前部門此工序數量)
        '        Dim pdi As List(Of ProductionDPTWareInventoryInfo)
        '        Dim pdc As New ProductionDPTWareInventoryControl

        '        pdi = pdc.ProductionDPTWareInventory_GetList(ds.Tables("ProductionChange").Rows(i)("DepID"), ds.Tables("ProductionChange").Rows(i)("Pro_NO"), Nothing)

        '        If pdi.Count = 0 Then
        '            Qty = 0
        '            Qty1 = 0
        '        Else
        '            Qty = pdi(0).WI_Qty '大貨結餘
        '            Qty1 = pdi(0).WI_ReQty  '返修結餘
        '        End If

        '        Dim pdi1 As New ProductionDPTWareInventoryInfo

        '        pdi1.DPT_ID = ds.Tables("ProductionChange").Rows(i)("DepID")  '當前某條記錄部門
        '        pdi1.M_Code = ds.Tables("ProductionChange").Rows(i)("Pro_NO") '當前某條記錄工序編號(物料編碼)
        '        pdi1.WI_Qty = Qty
        '        pdi1.WI_ReQty = Qty1 + ds.Tables("ProductionChange").Rows(i)("PC_ReQty") '當前某條記錄數量,一旦審核此部門工序數量變更為此數量且不允許再次更改!!

        '        pdc.UpdateProductionField_Qty(pdi1)

        '        If CSng(ds.Tables("ProductionChange").Rows(i)("PC_ReQty")) < 0 Then  '物料發出 從部門到會計部

        '            Dim pi1 As New ProductionFieldInfo
        '            Dim pc As New ProductionFieldControl

        '            ds.Tables("ProductionChange").Rows(i)("FP_NO") = GetFPNO()
        '            pi1.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")

        '            pi1.FP_Num = GetNum()

        '            pi1.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '            pi1.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '            pi1.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")


        '            pi1.Pro_Type1 = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '            pi1.PM_M_Code1 = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '            pi1.PM_Type1 = ds.Tables("ProductionChange").Rows(i)("PM_Type")

        '            pi1.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")
        '            pi1.Pro_NO1 = ds.Tables("ProductionChange").Rows(i)("Pro_NO")

        '            pi1.FP_Qty = Math.Abs(ds.Tables("ProductionChange").Rows(i)("PC_ReQty"))


        '            pi1.FP_Weight = 0

        '            pi1.FP_Date = Format(Now, "yyyy/MM/dd HH:mm:ss")
        '            pi1.FP_Detail = "PT15"
        '            pi1.FP_OutDep = ds.Tables("ProductionChange").Rows(i)("DepID")
        '            pi1.FP_InDep = "F102" '會計部
        '            pi1.FP_Remark = ds.Tables("ProductionChange").Rows(i)("PC_Remark")
        '            pi1.FP_OutAction = InUserID

        '            pi1.FP_SendType = "正常"
        '            pi1.FP_Qty1 = 0


        '            pc.ProductionField_Add(pi1)  '添加收發記錄

        '            Dim pii As New ProductionFieldInfo

        '            pii.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")
        '            pii.FP_Type = "發料"
        '            pii.FP_InCheck = True
        '            pii.FP_InAction = InUserID
        '            pii.FP_InCheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")

        '            If pc.ProductionField_UpdateInCheck(pii) = True Then


        '                '變更當前部門當前工序確認審核后--此收發單號的結餘數量(保存此時此部門庫存數)

        '                Dim pi11 As New ProductionFieldInfo

        '                pi11.FP_NO = pi1.FP_NO
        '                pi11.FP_OutDep = ds.Tables("ProductionChange").Rows(i)("DepID")
        '                pi11.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")
        '                pi11.FP_Type = "發料"
        '                pi11.FP_EndQty = pdi1.WI_Qty
        '                pi11.FP_EndReQty = pdi1.WI_ReQty

        '                pc.ProductionField_UpdateEndQty(pi11)
        '                '-----------------

        '                '-------------------------------------------------------------------------'確認收料后的審核記錄
        '                Dim pi2 As New ProductionFieldInfo
        '                Dim pc2 As New ProductionFieldControl

        '                pi2.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")
        '                pi2.FP_Check = True
        '                pi2.FP_CheckAction = InUserID
        '                pi2.FP_CheckRemark = "調賬發出記錄"

        '                pc2.ProductionField_UpdateCheck(pi2)

        '                '-------------------------------------------------------------------------

        '                Dim pfdi As List(Of ProductionFieldDaySummaryInfo)
        '                Dim pfdc As New ProductionFieldDaySummaryControl

        '                Dim udi As New ProductionFieldDaySummaryInfo

        '                Dim StrType As String  '類型
        '                Dim IntQty As Integer  '數量

        '                pfdi = pfdc.ProductionFieldDaySummary_GetList(Nothing, Nothing, Nothing, ds.Tables("ProductionChange").Rows(i)("Pro_NO"), ds.Tables("ProductionChange").Rows(i)("DepID"), Nothing, DateEdit1.Text, DateEdit1.Text)

        '                StrType = "調賬發出"
        '                If pfdi.Count = 0 Then
        '                    IntQty = 0
        '                Else
        '                    IntQty = pfdi(0).AccOut
        '                End If

        '                udi.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '                udi.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '                udi.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")
        '                udi.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")
        '                udi.FP_OutDep = ds.Tables("ProductionChange").Rows(i)("DepID")
        '                udi.PM_Date = DateEdit1.EditValue

        '                udi.BuNiang = 0
        '                udi.CunCang = 0
        '                udi.CunHuo = 0
        '                udi.DiuShi = 0
        '                udi.ShouLiao = 0
        '                udi.FanXiuIn = 0
        '                udi.FanXiuOut = 0
        '                udi.JiaCun = 0
        '                udi.ChuHuo = 0
        '                If CheckEdit1.Checked = True Then

        '                    udi.AccOut = IntQty + Math.Abs(ds.Tables("ProductionChange").Rows(i)("PC_ReQty"))

        '                End If
        '                udi.QuCang = 0
        '                udi.QuCun = 0
        '                udi.LiuBan = 0
        '                udi.SunHuai = 0
        '                udi.FaLiao = 0
        '                udi.WaiFaIn = 0
        '                udi.WaiFaOut = 0
        '                udi.AccIn = 0
        '                udi.RePairOut = 0
        '                udi.Type = StrType

        '                pfdc.UpdateProductionDaySummary_Qty(udi)   '變更發料數量(大貨產生)

        '            End If

        '        ElseIf CSng(ds.Tables("ProductionChange").Rows(i)("PC_ReQty")) > 0 Then

        '            Dim pi1 As New ProductionFieldInfo
        '            Dim pc As New ProductionFieldControl

        '            ds.Tables("ProductionChange").Rows(i)("FP_NO") = GetFPNO()
        '            pi1.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")

        '            pi1.FP_Num = GetNum()

        '            pi1.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '            pi1.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '            pi1.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")


        '            pi1.Pro_Type1 = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '            pi1.PM_M_Code1 = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '            pi1.PM_Type1 = ds.Tables("ProductionChange").Rows(i)("PM_Type")

        '            pi1.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")
        '            pi1.Pro_NO1 = ds.Tables("ProductionChange").Rows(i)("Pro_NO")

        '            pi1.FP_Qty = Math.Abs(ds.Tables("ProductionChange").Rows(i)("PC_ReQty"))


        '            pi1.FP_Weight = 0

        '            pi1.FP_Date = Format(Now, "yyyy/MM/dd HH:mm:ss")
        '            pi1.FP_Detail = "PT15"
        '            pi1.FP_OutDep = "F102" '會計部
        '            pi1.FP_InDep = ds.Tables("ProductionChange").Rows(i)("DepID")
        '            pi1.FP_Remark = ds.Tables("ProductionChange").Rows(i)("PC_Remark")
        '            pi1.FP_OutAction = InUserID

        '            pi1.FP_SendType = "正常"
        '            pi1.FP_Qty1 = 0

        '            pc.ProductionField_Add(pi1) '添加調賬記錄---收入


        '            Dim pii As New ProductionFieldInfo

        '            pii.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")
        '            pii.FP_Type = "收料"
        '            pii.FP_InCheck = True
        '            pii.FP_InAction = InUserID
        '            pii.FP_InCheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")

        '            If pc.ProductionField_UpdateInCheck(pii) = True Then

        '                '變更當前部門當前工序確認審核后--此收發單號的結餘數量(保存此時此部門庫存數)

        '                Dim pi11 As New ProductionFieldInfo

        '                pi11.FP_NO = pi1.FP_NO
        '                pi11.FP_OutDep = ds.Tables("ProductionChange").Rows(i)("DepID")
        '                pi11.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")
        '                pi11.FP_Type = "收料"
        '                pi11.FP_EndQty = pdi1.WI_Qty
        '                pi11.FP_EndReQty = pdi1.WI_ReQty

        '                pc.ProductionField_UpdateEndQty(pi11)
        '                '-----------------

        '                '-------------------------------------------------------------------------'確認收料后的審核記錄
        '                Dim pi2 As New ProductionFieldInfo
        '                Dim pc2 As New ProductionFieldControl

        '                pi2.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")
        '                pi2.FP_Check = True
        '                pi2.FP_CheckAction = InUserID
        '                pi2.FP_CheckRemark = "調賬收入記錄"

        '                pc2.ProductionField_UpdateCheck(pi2)

        '                '-------------------------------------------------------------------------

        '                Dim pfdi As List(Of ProductionFieldDaySummaryInfo)
        '                Dim pfdc As New ProductionFieldDaySummaryControl

        '                Dim udi As New ProductionFieldDaySummaryInfo

        '                Dim StrType As String  '類型
        '                Dim IntQty As Integer  '數量

        '                pfdi = pfdc.ProductionFieldDaySummary_GetList(Nothing, Nothing, Nothing, ds.Tables("ProductionChange").Rows(i)("Pro_NO"), ds.Tables("ProductionChange").Rows(i)("DepID"), Nothing, DateEdit1.Text, DateEdit1.Text)

        '                StrType = "調賬收入"
        '                If pfdi.Count = 0 Then
        '                    IntQty = 0
        '                Else
        '                    IntQty = pfdi(0).AccOut
        '                End If

        '                udi.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '                udi.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '                udi.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")
        '                udi.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")
        '                udi.FP_OutDep = ds.Tables("ProductionChange").Rows(i)("DepID")
        '                udi.PM_Date = DateEdit1.EditValue

        '                udi.BuNiang = 0
        '                udi.CunCang = 0
        '                udi.CunHuo = 0
        '                udi.DiuShi = 0
        '                udi.ShouLiao = 0
        '                udi.FanXiuIn = 0
        '                udi.FanXiuOut = 0
        '                udi.JiaCun = 0
        '                udi.ChuHuo = 0
        '                If CheckEdit1.Checked = True Then

        '                    udi.AccIn = IntQty + Math.Abs(ds.Tables("ProductionChange").Rows(i)("PC_ReQty"))

        '                End If
        '                udi.QuCang = 0
        '                udi.QuCun = 0
        '                udi.LiuBan = 0
        '                udi.SunHuai = 0
        '                udi.FaLiao = 0
        '                udi.WaiFaIn = 0
        '                udi.WaiFaOut = 0
        '                udi.AccOut = 0
        '                udi.RePairOut = 0
        '                udi.Type = StrType

        '                pfdc.UpdateProductionDaySummary_Qty(udi)   '變更發料數量(大貨產生)


        '            End If

        '        End If

        '    Next

        'End If

        ''---------------------------------------------------------------判斷針對是物料收入---物料發出

        ''---------------------------------------------------------------
        'Me.Close()

        'If CheckEdit1.Checked = True Then
        '    Dim i As Integer

        '    For i = 0 To ds.Tables("ProductionChange").Rows.Count - 1

        '        If CSng(ds.Tables("ProductionChange").Rows(i)("PC_ReQty")) < 0 Then  '物料發出 從部門到會計部

        '            Dim pi1 As New ProductionFieldInfo
        '            Dim pc As New ProductionFieldControl

        '            ds.Tables("ProductionChange").Rows(i)("FP_NO") = GetFPNO()
        '            pi1.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")

        '            pi1.FP_Num = GetNum()

        '            pi1.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '            pi1.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '            pi1.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")


        '            pi1.Pro_Type1 = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '            pi1.PM_M_Code1 = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '            pi1.PM_Type1 = ds.Tables("ProductionChange").Rows(i)("PM_Type")

        '            pi1.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")
        '            pi1.Pro_NO1 = ds.Tables("ProductionChange").Rows(i)("Pro_NO")

        '            pi1.FP_Qty = Math.Abs(ds.Tables("ProductionChange").Rows(i)("PC_ReQty"))


        '            pi1.FP_Weight = 0

        '            pi1.FP_Date = Format(Now, "yyyy/MM/dd HH:mm:ss")
        '            pi1.FP_Detail = "PT15"
        '            pi1.FP_OutDep = ds.Tables("ProductionChange").Rows(i)("DepID")
        '            pi1.FP_InDep = "F102" '會計部
        '            pi1.FP_Remark = txtNO.Text & "  " & ds.Tables("ProductionChange").Rows(i)("PC_Remark")
        '            pi1.FP_OutAction = InUserID

        '            pi1.FP_SendType = "正常"
        '            pi1.FP_Qty1 = 0
        '            pi1.CardID = txtCardID.Text
        '            pi1.FP_OutOK = True

        '            pc.ProductionField_Add(pi1)  '添加收發記錄

        '            '-------------------------------------------------------------------------'確認收料后的審核記錄
        '            Dim pi2 As New ProductionFieldInfo
        '            Dim pc2 As New ProductionFieldControl

        '            pi2.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")
        '            pi2.FP_Check = True
        '            pi2.FP_CheckAction = InUserID
        '            pi2.FP_CheckRemark = "調賬發出記錄"

        '            pc2.ProductionField_UpdateCheck(pi2)

        '            Dim pai As New ProductionAffairInfo
        '            Dim pac As New ProductionAffairControl

        '            Dim pdi As List(Of ProductionDPTWareInventoryInfo)
        '            Dim pdc As New ProductionDPTWareInventoryControl

        '            Dim pdsi As List(Of ProductionFieldDaySummaryInfo)
        '            Dim pdsc As New ProductionFieldDaySummaryControl

        '            Dim strQty, strReQty As Integer
        '            Dim strShouLiao, strJiaCun, strQuCun, strFaLiao, strCunHuo, strFanXiuIn, strFanXiuOut, strLiuBan, strSunHuai, strDiuShi, strBuNiang, strCunCang, strQuCang, strChuHuo, strWaiFaIn, strWaiFaOut, strAccIn, strAccOut, strRePairOut, strZuheOut As Integer

        '            pdi = pdc.ProductionDPTWareInventory_GetList(ds.Tables("ProductionChange").Rows(i)("DepID"), ds.Tables("ProductionChange").Rows(i)("Pro_NO"), Nothing)

        '            If pdi.Count = 0 Then
        '                strQty = 0
        '                strReQty = 0
        '            Else
        '                strQty = pdi(0).WI_Qty
        '                strReQty = pdi(0).WI_ReQty
        '            End If
        '            pdsi = pdsc.ProductionFieldDaySummary_GetList(Nothing, Nothing, Nothing, ds.Tables("ProductionChange").Rows(i)("Pro_NO"), ds.Tables("ProductionChange").Rows(i)("DepID"), Nothing, DateEdit1.Text, DateEdit1.Text)

        '            If pdsi.Count = 0 Then
        '                strShouLiao = 0
        '                strJiaCun = 0
        '                strQuCun = 0
        '                strFaLiao = 0
        '                strCunHuo = 0
        '                strFanXiuIn = 0
        '                strFanXiuOut = 0
        '                strLiuBan = 0
        '                strSunHuai = 0
        '                strDiuShi = 0
        '                strBuNiang = 0
        '                strCunCang = 0
        '                strQuCang = 0
        '                strChuHuo = 0
        '                strWaiFaIn = 0
        '                strWaiFaOut = 0
        '                strAccIn = 0
        '                strAccOut = 0
        '                strRePairOut = 0
        '                strZuheOut = 0
        '            Else
        '                strShouLiao = pdsi(0).ShouLiao
        '                strJiaCun = pdsi(0).JiaCun
        '                strQuCun = pdsi(0).QuCun
        '                strFaLiao = pdsi(0).FaLiao
        '                strCunHuo = pdsi(0).CunHuo
        '                strFanXiuIn = pdsi(0).FanXiuIn
        '                strFanXiuOut = pdsi(0).FanXiuOut
        '                strLiuBan = pdsi(0).LiuBan
        '                strSunHuai = pdsi(0).SunHuai
        '                strDiuShi = pdsi(0).DiuShi
        '                strBuNiang = pdsi(0).BuNiang
        '                strCunCang = pdsi(0).CunCang
        '                strQuCang = pdsi(0).QuCang
        '                strChuHuo = pdsi(0).ChuHuo
        '                strWaiFaIn = pdsi(0).WaiFaIn
        '                strWaiFaOut = pdsi(0).WaiFaOut
        '                strAccIn = pdsi(0).AccIn
        '                strAccOut = pdsi(0).AccOut
        '                strRePairOut = pdsi(0).RePairOut
        '                strZuheOut = pdsi(0).ZuheOut

        '            End If

        '            pai.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")
        '            pai.FP_Type = "發料"
        '            pai.FP_InAction = InUserID
        '            If CheckEdit1.Checked = True Then
        '                pai.FP_InCheck = True
        '            Else
        '                pai.FP_InCheck = False
        '            End If
        '            pai.CardID = txtCardID.Text

        '            pai.FP_InCheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
        '            '-------------------------------------------------------------------
        '            pai.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '            pai.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '            pai.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")
        '            pai.Pro_Type1 = Nothing
        '            pai.PM_M_Code1 = Nothing
        '            pai.PM_Type1 = Nothing
        '            pai.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")
        '            pai.Pro_NO1 = Nothing
        '            pai.FP_OutDep = ds.Tables("ProductionChange").Rows(i)("DepID")
        '            pai.FP_InDep = Nothing

        '            pai.FP_Detail = "PT15"
        '            pai.Type = "D"

        '            '------------------------------------------------------變更部門結餘數信息
        '            pai.WI_Qty = strQty
        '            pai.WI_ReQty = strReQty + ds.Tables("ProductionChange").Rows(i)("PC_ReQty")
        '            pai.WI_Qty1 = 0
        '            pai.WI_ReQty1 = 0

        '            '--------------------------------------------------------------------
        '            pai.ShouLiao = strShouLiao
        '            pai.JiaCun = strJiaCun
        '            pai.LiuBan = strLiuBan
        '            pai.SunHuai = strSunHuai
        '            pai.DiuShi = strDiuShi
        '            pai.CunHuo = strCunHuo
        '            pai.BuNiang = strBuNiang
        '            pai.QuCun = strQuCun
        '            pai.FaLiao = strFaLiao
        '            pai.FanXiuIn = strFanXiuIn
        '            pai.FanXiuOut = strFanXiuOut
        '            pai.CunCang = strCunCang
        '            pai.QuCang = strQuCang
        '            pai.ChuHuo = strChuHuo
        '            pai.WaiFaIn = strWaiFaIn
        '            pai.WaiFaOut = strWaiFaOut
        '            pai.AccIn = strAccIn
        '            pai.AccOut = strAccOut + Math.Abs(ds.Tables("ProductionChange").Rows(i)("PC_ReQty"))
        '            pai.RePairOut = strRePairOut
        '            pai.ZuheOut = strZuheOut

        '            '------------------------------------------存在有收有發情況下
        '            pai.ShouLiao1 = 0
        '            pai.JiaCun1 = 0
        '            pai.QuCun1 = 0
        '            pai.FaLiao1 = 0
        '            pai.CunHuo1 = 0
        '            pai.FanXiuIn1 = 0
        '            pai.FanXiuOut1 = 0
        '            pai.LiuBan1 = 0
        '            pai.SunHuai1 = 0
        '            pai.DiuShi1 = 0
        '            pai.BuNiang1 = 0
        '            pai.CunCang1 = 0
        '            pai.QuCang1 = 0
        '            pai.ChuHuo1 = 0
        '            pai.WaiFaIn1 = 0
        '            pai.WaiFaOut1 = 0
        '            pai.AccIn1 = 0
        '            pai.AccOut1 = 0
        '            pai.RePairOut1 = 0
        '            pai.ZuheOut1 = 0

        '            '------------------------------------------
        '            pai.PM_Date = DateEdit1.Text

        '            pac.UpdateProductionCheck_Qty(pai)


        '        ElseIf CSng(ds.Tables("ProductionChange").Rows(i)("PC_ReQty")) > 0 Then

        '            Dim pi1 As New ProductionFieldInfo
        '            Dim pc As New ProductionFieldControl

        '            ds.Tables("ProductionChange").Rows(i)("FP_NO") = GetFPNO()
        '            pi1.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")

        '            pi1.FP_Num = GetNum()

        '            pi1.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '            pi1.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '            pi1.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")


        '            pi1.Pro_Type1 = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '            pi1.PM_M_Code1 = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '            pi1.PM_Type1 = ds.Tables("ProductionChange").Rows(i)("PM_Type")

        '            pi1.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")
        '            pi1.Pro_NO1 = ds.Tables("ProductionChange").Rows(i)("Pro_NO")

        '            pi1.FP_Qty = Math.Abs(ds.Tables("ProductionChange").Rows(i)("PC_ReQty"))


        '            pi1.FP_Weight = 0

        '            pi1.FP_Date = Format(Now, "yyyy/MM/dd HH:mm:ss")
        '            pi1.FP_Detail = "PT15"
        '            pi1.FP_OutDep = "F102" '會計部
        '            pi1.FP_InDep = ds.Tables("ProductionChange").Rows(i)("DepID")
        '            pi1.FP_Remark = txtNO.Text & "  " & ds.Tables("ProductionChange").Rows(i)("PC_Remark")
        '            pi1.FP_OutAction = InUserID

        '            pi1.FP_SendType = "正常"
        '            pi1.FP_Qty1 = 0
        '            pi1.CardID = txtCardID.Text
        '            pi1.FP_OutOK = True

        '            pc.ProductionField_Add(pi1) '添加調賬記錄---收入

        '            Dim pi2 As New ProductionFieldInfo
        '            Dim pc2 As New ProductionFieldControl

        '            pi2.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")
        '            pi2.FP_Check = True
        '            pi2.FP_CheckAction = InUserID
        '            pi2.FP_CheckRemark = "調賬收入記錄"

        '            pc2.ProductionField_UpdateCheck(pi2)

        '            Dim pai As New ProductionAffairInfo
        '            Dim pac As New ProductionAffairControl

        '            Dim pdi As List(Of ProductionDPTWareInventoryInfo)
        '            Dim pdc As New ProductionDPTWareInventoryControl

        '            Dim pdsi As List(Of ProductionFieldDaySummaryInfo)
        '            Dim pdsc As New ProductionFieldDaySummaryControl

        '            Dim strQty, strReQty As Integer
        '            Dim strShouLiao, strJiaCun, strQuCun, strFaLiao, strCunHuo, strFanXiuIn, strFanXiuOut, strLiuBan, strSunHuai, strDiuShi, strBuNiang, strCunCang, strQuCang, strChuHuo, strWaiFaIn, strWaiFaOut, strAccIn, strAccOut, strRePairOut, strZuheOut As Integer

        '            pdi = pdc.ProductionDPTWareInventory_GetList(ds.Tables("ProductionChange").Rows(i)("DepID"), ds.Tables("ProductionChange").Rows(i)("Pro_NO"), Nothing)

        '            If pdi.Count = 0 Then
        '                strQty = 0
        '                strReQty = 0
        '            Else
        '                strQty = pdi(0).WI_Qty
        '                strReQty = pdi(0).WI_ReQty
        '            End If
        '            pdsi = pdsc.ProductionFieldDaySummary_GetList(Nothing, Nothing, Nothing, ds.Tables("ProductionChange").Rows(i)("Pro_NO"), ds.Tables("ProductionChange").Rows(i)("DepID"), Nothing, DateEdit1.Text, DateEdit1.Text)

        '            If pdsi.Count = 0 Then
        '                strShouLiao = 0
        '                strJiaCun = 0
        '                strQuCun = 0
        '                strFaLiao = 0
        '                strCunHuo = 0
        '                strFanXiuIn = 0
        '                strFanXiuOut = 0
        '                strLiuBan = 0
        '                strSunHuai = 0
        '                strDiuShi = 0
        '                strBuNiang = 0
        '                strCunCang = 0
        '                strQuCang = 0
        '                strChuHuo = 0
        '                strWaiFaIn = 0
        '                strWaiFaOut = 0
        '                strAccIn = 0
        '                strAccOut = 0
        '                strRePairOut = 0
        '                strZuheOut = 0
        '            Else
        '                strShouLiao = pdsi(0).ShouLiao
        '                strJiaCun = pdsi(0).JiaCun
        '                strQuCun = pdsi(0).QuCun
        '                strFaLiao = pdsi(0).FaLiao
        '                strCunHuo = pdsi(0).CunHuo
        '                strFanXiuIn = pdsi(0).FanXiuIn
        '                strFanXiuOut = pdsi(0).FanXiuOut
        '                strLiuBan = pdsi(0).LiuBan
        '                strSunHuai = pdsi(0).SunHuai
        '                strDiuShi = pdsi(0).DiuShi
        '                strBuNiang = pdsi(0).BuNiang
        '                strCunCang = pdsi(0).CunCang
        '                strQuCang = pdsi(0).QuCang
        '                strChuHuo = pdsi(0).ChuHuo
        '                strWaiFaIn = pdsi(0).WaiFaIn
        '                strWaiFaOut = pdsi(0).WaiFaOut
        '                strAccIn = pdsi(0).AccIn
        '                strAccOut = pdsi(0).AccOut
        '                strRePairOut = pdsi(0).RePairOut
        '                strZuheOut = pdsi(0).ZuheOut

        '            End If

        '            pai.FP_NO = ds.Tables("ProductionChange").Rows(i)("FP_NO")
        '            pai.FP_Type = "收料"
        '            pai.FP_InAction = InUserID
        '            If CheckEdit1.Checked = True Then
        '                pai.FP_InCheck = True
        '            Else
        '                pai.FP_InCheck = False
        '            End If
        '            pai.CardID = txtCardID.Text

        '            pai.FP_InCheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
        '            '-------------------------------------------------------------------
        '            pai.Pro_Type = ds.Tables("ProductionChange").Rows(i)("Pro_Type")
        '            pai.PM_M_Code = ds.Tables("ProductionChange").Rows(i)("PM_M_Code")
        '            pai.PM_Type = ds.Tables("ProductionChange").Rows(i)("PM_Type")
        '            pai.Pro_Type1 = Nothing
        '            pai.PM_M_Code1 = Nothing
        '            pai.PM_Type1 = Nothing
        '            pai.Pro_NO = ds.Tables("ProductionChange").Rows(i)("Pro_NO")
        '            pai.Pro_NO1 = Nothing
        '            pai.FP_OutDep = ds.Tables("ProductionChange").Rows(i)("DepID")
        '            pai.FP_InDep = "F102"

        '            pai.FP_Detail = "PT15"
        '            pai.Type = "P"

        '            '------------------------------------------------------變更部門結餘數信息
        '            pai.WI_Qty = strQty
        '            pai.WI_ReQty = strReQty + ds.Tables("ProductionChange").Rows(i)("PC_ReQty")
        '            pai.WI_Qty1 = 0
        '            pai.WI_ReQty1 = 0

        '            '--------------------------------------------------------------------
        '            pai.ShouLiao = strShouLiao
        '            pai.JiaCun = strJiaCun
        '            pai.LiuBan = strLiuBan
        '            pai.SunHuai = strSunHuai
        '            pai.DiuShi = strDiuShi
        '            pai.CunHuo = strCunHuo
        '            pai.BuNiang = strBuNiang
        '            pai.QuCun = strQuCun
        '            pai.FaLiao = strFaLiao
        '            pai.FanXiuIn = strFanXiuIn
        '            pai.FanXiuOut = strFanXiuOut
        '            pai.CunCang = strCunCang
        '            pai.QuCang = strQuCang
        '            pai.ChuHuo = strChuHuo
        '            pai.WaiFaIn = strWaiFaIn
        '            pai.WaiFaOut = strWaiFaOut
        '            pai.AccIn = strAccIn + Math.Abs(ds.Tables("ProductionChange").Rows(i)("PC_ReQty"))
        '            pai.AccOut = strAccOut
        '            pai.RePairOut = strRePairOut
        '            pai.ZuheOut = strZuheOut

        '            '------------------------------------------存在有收有發情況下
        '            pai.ShouLiao1 = 0
        '            pai.JiaCun1 = 0
        '            pai.QuCun1 = 0
        '            pai.FaLiao1 = 0
        '            pai.CunHuo1 = 0
        '            pai.FanXiuIn1 = 0
        '            pai.FanXiuOut1 = 0
        '            pai.LiuBan1 = 0
        '            pai.SunHuai1 = 0
        '            pai.DiuShi1 = 0
        '            pai.BuNiang1 = 0
        '            pai.CunCang1 = 0
        '            pai.QuCang1 = 0
        '            pai.ChuHuo1 = 0
        '            pai.WaiFaIn1 = 0
        '            pai.WaiFaOut1 = 0
        '            pai.AccIn1 = 0
        '            pai.AccOut1 = 0
        '            pai.RePairOut1 = 0
        '            pai.ZuheOut1 = 0

        '            '------------------------------------------
        '            pai.PM_Date = DateEdit1.Text

        '            pac.UpdateProductionCheck_Qty(pai)

        '        End If

        '    Next

        'End If

        ''---------------------------------------------------------------判斷針對是物料收入---物料發出

        ''---------------------------------------------------------------
        Me.Close()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtCardID.Text.Trim = "" And txtCardID.Visible = True Then
            MsgBox("刷卡人信息不能為空，請刷卡！", 64, "提示")
            btnRefCard.Focus()
            Exit Sub
        End If

        Select Case Label7.Text
            Case "Change"
                If SaveCheck("Change") = True Then
                    If Edit = False Then
                        DataNew()
                    Else
                        DataEdit()
                    End If
                End If
            Case "ChangeReQty"
                If SaveCheck("ChangeReQty") = True Then
                    If Edit = False Then
                        ReDataNew()
                    Else
                        ReDataEdit()
                    End If
                End If
            Case "Check"
                UpdateCheck()

            Case "ReCheck"
                ReUpdateCheck()

        End Select

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    '添加子項
    Private Sub cmsChangeSubAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsChangeSubAdd.Click
        tempCode = ""
        tempValue2 = "更改單管理"

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

            'AddRow(tempCode)
        End If
        tempCode = ""
    End Sub

    Sub AddRow(ByVal M_Code As String) '通過工序編號導入相應信息(工藝類型,產品編號,類型,工序名稱等)

        'ds.Tables("ProductionChange").Clear()

        If M_Code = "" Then
        Else
            Dim pic As New ProcessMainControl
            Dim pci As List(Of ProcessMainInfo)
            pci = pic.ProcessSub_GetList(Nothing, M_Code, Nothing, Nothing, Nothing, Nothing)
            If pci.Count = 0 Then Exit Sub
            Dim i As Integer

            For i = 0 To ds.Tables("ProductionChange").Rows.Count - 1
                If M_Code = ds.Tables("ProductionChange").Rows(i)("Pro_NO") Then
                    MsgBox("一張單不允許有重復相同工序編碼信息....")
                    Exit Sub
                End If
            Next

            For i = 0 To pci.Count - 1

                Dim row As DataRow
                row = ds.Tables("ProductionChange").NewRow

                row("Pro_Type") = pci(i).Pro_Type
                row("PM_M_Code") = pci(i).PM_M_Code
                row("PM_Type") = pci(i).Type3ID  '實際類型
                row("Pro_NO") = M_Code
                row("PS_Name") = pci(i).PS_Name
                row("PC_Qty") = 0
                row("PC_ReQty") = 0
                row("DepID") = ""
                row("PC_Remark") = ""

                row("PM_JiYu") = pci(i).PM_JiYu '機玉

                ds.Tables("ProductionChange").Rows.Add(row)
            Next
        End If
        GridView1.MoveLast()
    End Sub
    '刪除子項
    Private Sub cmsChangeSubDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsChangeSubDel.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "IndexNO")

        If DelTemp = "IndexNO" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelProductionChange").NewRow

            row("IndexNO") = ds.Tables("ProductionChange").Rows(GridView1.FocusedRowHandle)("IndexNO")

            ds.Tables("DelProductionChange").Rows.Add(row)
        End If
        ds.Tables("ProductionChange").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub

    Function SaveCheck(ByVal strType As String) As Boolean
        SaveCheck = True

        Dim i As Integer

        For i = 0 To ds.Tables("ProductionChange").Rows.Count - 1
            Dim Qty, ReQty As Integer '定義數量(得到當前部門此工序數量)
            Dim pdi As List(Of ProductionDPTWareInventoryInfo)
            Dim pdc As New ProductionDPTWareInventoryControl

            pdi = pdc.ProductionDPTWareInventory_GetList(ds.Tables("ProductionChange").Rows(i)("DepID"), ds.Tables("ProductionChange").Rows(i)("Pro_NO"), Nothing)

            If pdi.Count = 0 Then
                Qty = 0
                ReQty = 0
            Else
                Qty = pdi(0).WI_Qty  '大貨結餘數
                ReQty = pdi(0).WI_ReQty '返修結餘數
            End If

            If strType = "Change" Then
                If Qty + ds.Tables("ProductionChange").Rows(i)("PC_Qty") < 0 Then
                    MsgBox("當前部門工序數量執行后為負數!請確認此部門工序數量信息!")
                    SaveCheck = False
                    Exit Function
                End If
                If ds.Tables("ProductionChange").Rows(i)("PC_Qty") = 0 Then
                    MsgBox("當前存在有變更數量為0的情況，請確認變更數量！")
                    SaveCheck = False
                    Exit Function

                End If
            ElseIf strType = "ChangeReQty" Then
                If ReQty + ds.Tables("ProductionChange").Rows(i)("PC_ReQty") < 0 Then
                    MsgBox("當前部門工序數量執行后為負數!請確認此部門工序數量信息!")
                    SaveCheck = False
                    Exit Function
                End If
                If ds.Tables("ProductionChange").Rows(i)("PC_ReQty") = 0 Then
                    MsgBox("當前存在有變更數量為0的情況，請確認變更數量！")
                    SaveCheck = False
                    Exit Function

                End If
            End If

        Next

    End Function

    '@ 2012/4/27 添加 刷卡信息
    Private Sub btnRefCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefCard.Click
        txtCardID.Text = ReadCard()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim frm As New frmException
        frm.ShowDialog()

        txtCardID.Text = tempValue
        tempValue = ""

    End Sub
End Class