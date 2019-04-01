Imports LFERP.Library.ProductionSchedule
Imports LFERP.Library.Product
Imports LFERP.DataSetting
Imports LFERP.Library.ProductProcess

Public Class frmProductionScheduleDemand

#Region "緩存參數"

    Private ds As New DataSet                       '數據集


    Private m_EditItemDescrip As String             '描述

    Public Property EditItemDescrip() As String
        Get
            Return m_EditItemDescrip
        End Get
        Set(ByVal value As String)
            m_EditItemDescrip = value
        End Set
    End Property

#End Region

#Region "創建臨時表"
    Private Sub CreateTables()
        ds.Tables.Clear()
        With ds.Tables.Add("ProductionSchedule")
            .Columns.Add("dtDate", GetType(String))
            .Columns.Add("PlanCount", GetType(String))
            .Columns.Add("C_Qty", GetType(String))
            .Columns.Add("PS_Num", GetType(String))
        End With
        GridProductionSchedule.DataSource = ds.Tables("ProductionSchedule")



        With ds.Tables.Add("ProductType")
            .Columns.Add("PM_Type", GetType(String))
        End With
        gluType.Properties.ValueMember = "PM_Type"
        gluType.Properties.DisplayMember = "PM_Type"
        gluType.Properties.DataSource = ds.Tables("ProductType")

    End Sub
#End Region


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case m_EditItemDescrip
            Case "Add"
                If CheckData() Then
                    DataNew()
                End If
            Case "Modify"
                If CheckData() Then
                    DataModifyData()
                End If
            Case "Check"
                UpdateCheck()
        End Select

    End Sub

    ''' <summary>
    ''' 審核
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateCheck()

        Dim pi As New ProductionScheduleInfo
        Dim pc As New ProductionScheduleControl

        pi.PS_NO = txtNO.Text
        pi.PS_Check = chkCheck.Checked
        pi.PS_CheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
        pi.PS_CheckAction = InUserID
        pi.PS_CheckRemark = txtCheckRemark.Text
        If pc.ProductionSchedule_UpdateCheck(pi) = True Then
            MsgBox("審核狀態已改變!", 64, "提示")
        Else
            MsgBox("審核失敗,請檢查原因!", 64, "提示")
        End If
        Me.Close()
    End Sub



    ''' <summary>
    ''' 審查保存數據
    ''' </summary>
    ''' <remarks></remarks>
    Private Function CheckData() As Boolean
        CheckData = False

        If GluDep.EditValue = "" Then
            MsgBox("生產部門不能為空!", 64, "提示")
            GluDep.Focus()
            Exit Function
        End If

        If cbType.EditValue = "" Then
            MsgBox("工藝類型不能為空!", 64, "提示")
            cbType.Focus()
            Exit Function
        End If

        If dtPMCode.EditValue = "" Then
            MsgBox("產品編號不能為空!", 64, "提示")
            dtPMCode.Focus()
            Exit Function
        End If

        If gluType.EditValue = "" Then
            MsgBox("類型不能為空!", 64, "提示")
            gluType.Focus()
            Exit Function
        End If

        If txtQty.Text = "" Then
            MsgBox("計畫需求量不能為空!", 64, "提示")
            Exit Function
        End If

        If CInt(txtQty.Text) <= 0 Then
            MsgBox("計畫需求量不能小於等於零!", 64, "提示")
            Exit Function
        End If

        Dim ts As New TimeSpan

        ts = DateTime.Parse(dtPlanEnd.Text) - DateTime.Parse(dtPlanStart.Text)


        If ts.Days > 6 Then
            MsgBox("生產計畫不能超過一週!", 64, "提示")
            Exit Function
        End If



        '2014-03-05  姚駿
        Dim sum As Integer
        For nIndex As Integer = 0 To ds.Tables("ProductionSchedule").Rows.Count - 1


            Try
                If ds.Tables("ProductionSchedule").Rows(nIndex)("PlanCount").ToString() <> String.Empty Then
                    If CInt(ds.Tables("ProductionSchedule").Rows(nIndex)("PlanCount")) <= 0 Then
                        MsgBox("計畫數量不能小於等於零!", 64, "提示")
                        Exit Function
                    End If
                    sum = sum + CInt(ds.Tables("ProductionSchedule").Rows(nIndex)("PlanCount"))
                End If
            Catch ex As Exception
                MsgBox("計畫數量超出範圍!", 64, "提示")
                Exit Function
            End Try

        Next

        If sum > CInt(txtQty.Text) Then
            MsgBox("計畫數量不能大於計畫總需求量!", 64, "提示")
            Exit Function
        End If

        CheckData = True

    End Function

    ''' <summary>
    ''' 保存修改數據
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DataModifyData()
        Dim pi As New ProductionScheduleInfo
        Dim psc As New ProductionScheduleControl

        Dim i As Integer

        For i = 0 To ds.Tables("ProductionSchedule").Rows.Count - 1
            pi.PS_NO = txtNO.Text
            pi.Pro_Type = cbType.EditValue
            pi.PM_M_Code = dtPMCode.EditValue
            pi.PM_Type = gluType.EditValue
            pi.M_Code = GetCode(cbType.EditValue, dtPMCode.EditValue, gluType.EditValue)
            pi.PS_KaiLiao = False
            pi.PS_Detail = "備料中"
            pi.PS_Action = InUserID
            pi.PS_Dep = GluDep.EditValue
            pi.PS_AddDate = Format(Now, "yyyy/MM/dd")

            pi.PS_Num = ds.Tables("ProductionSchedule").Rows(i)("PS_Num")

            If IsDBNull(ds.Tables("ProductionSchedule").Rows(i)("PlanCount")) Then
                pi.PS_DayNumber = 0
            Else
                pi.PS_DayNumber = ds.Tables("ProductionSchedule").Rows(i)("PlanCount")
            End If

            'pi.PS_Date = DateAdd(DateInterval.Day, +i, CDate(dtPlanStart.Text))
            pi.PS_Date = ds.Tables("ProductionSchedule").Rows(i)("dtDate")

            If Not psc.ProductionSchedule_Update(pi) Then
                MsgBox("生產計畫修改失敗,請檢查原因!")
                Exit Sub
            End If


        Next

        MsgBox("修改生產計劃成功!")
      
        Me.Close()

    End Sub

    ''' <summary>
    ''' 保存新增數據
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DataNew()


        

        Dim psi As List(Of ProductionScheduleInfo)
        Dim pi As New ProductionScheduleInfo
        Dim psc As New ProductionScheduleControl


        psi = psc.ProductionSchedule_GetList(Nothing, Nothing, Nothing, dtPMCode.EditValue, Nothing, dtPlanStart.Text, dtPlanEnd.Text, Nothing)

        If psi.Count > 0 Then
            MsgBox("生產計畫已經存在,不能新增!", 64, "提示")
            Exit Sub
        End If


        Dim i As Integer

        pi.PS_NO = GetNO()

        For i = 0 To ds.Tables("ProductionSchedule").Rows.Count - 1

            pi.Pro_Type = cbType.EditValue
            pi.PM_M_Code = dtPMCode.EditValue
            pi.PM_Type = gluType.EditValue
            pi.M_Code = GetCode(cbType.EditValue, dtPMCode.EditValue, gluType.EditValue)
            pi.PS_KaiLiao = False
            pi.PS_Detail = "備料中"
            pi.PS_Action = InUserID
            pi.PS_Dep = GluDep.EditValue

            pi.PS_AddDate = Format(Now, "yyyy/MM/dd")

            pi.PS_Num = GetNum()

            If IsDBNull(ds.Tables("ProductionSchedule").Rows(i)("PlanCount")) Then
                pi.PS_DayNumber = 0
            Else
                pi.PS_DayNumber = ds.Tables("ProductionSchedule").Rows(i)("PlanCount")
            End If

            'pi.PS_Date = DateAdd(DateInterval.Day, +i, CDate(dtPlanStart.Text))

            pi.PS_Date = ds.Tables("ProductionSchedule").Rows(i)("dtDate")

            psc.ProductionSchedule_Add(pi)

        Next

        MsgBox("完成建立當前生產計劃!", 64, "提示")
        Me.Close()
    End Sub

    '獲取最新日期項目流水號
    Public Function GetNum() As String
        Dim psi As New ProductionScheduleInfo
        Dim psc As New ProductionScheduleControl
        Dim strName As String
        strName = "P" + Format(Now, "yyMM")
        psi = psc.ProductionSchedule_GetNum(strName)
        If psi Is Nothing Then
            GetNum = strName + "00001"
        Else
            GetNum = strName + Mid((CInt(Mid(psi.PS_Num, 6)) + 100001), 2)
        End If
    End Function


    '獲取最新項目號
    Public Function GetNO() As String
        Dim psi As New ProductionScheduleInfo
        Dim psc As New ProductionScheduleControl
        Dim strName As String
        strName = Format(Now, "yyMM")
        psi = psc.ProductionSchedule_GetNO(strName)
        If psi Is Nothing Then
            GetNO = "PS" + strName + "0001"
        Else
            GetNO = "PS" + strName + Mid((CInt(Mid(psi.PS_NO, 7)) + 10001), 2)
        End If

    End Function


    Public Function GetCode(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String) As String

        Dim ppc As New ProcessMainControl
        Dim ppi As List(Of ProcessMainInfo)
        ppi = ppc.ProcessMain_GetList(Nothing, PM_M_Code, Pro_Type, PM_Type, Nothing, Nothing)
        If ppi.Count = 0 Then
            GetCode = Nothing
            Exit Function
        Else
            GetCode = ppi(0).M_Code
        End If

    End Function



#Region "初始化"
    Private Sub frmProductionScheduleDemand_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTables()

        LoadFacName()
        LoadProductNo()
        LoadDateTime()


        Select Case m_EditItemDescrip
            Case "Add"
                AddControlValid()
                XtraTabPage2.PageVisible = False
                cbType.SelectedIndex = 1
                pnlCheck.Enabled = False
                Me.Text = "添加生產計劃需求"
            Case "Modify"
                ModifyLoadData()
                pnlCheck.Enabled = False
                btnQuery.Enabled = True
                XtraTabPage2.PageEnabled = False
                Me.Text = "修改生產計劃需求"
            Case "Check"
                ModifyLoadData()
                GridView1.OptionsBehavior.Editable = False
                lblCheckAction.Text = InUserID
                lblCheckDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                Me.Text = "審核生產計劃需求"
                XtraTabControl1.SelectedTabPage = XtraTabPage2
            Case "View"
                ModifyLoadData()
                cmdSave.Enabled = False
              
                pnlCheck.Enabled = False
                GridView1.OptionsBehavior.Editable = False
                Me.Text = "審核查看計劃需求"
        End Select
    End Sub

    ''' <summary>
    ''' 修改加載數據
    ''' </summary>
    ''' <remarks></remarks>
    Private Function ModifyLoadData() As Boolean
        ModifyLoadData = False

        txtNO.Text = tempValue3

        Dim psi As List(Of ProductionScheduleInfo)
        Dim psc As New ProductionScheduleControl

        psi = psc.ProductionSchedule_GetList(txtNO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If psi Is Nothing Then
            Exit Function
        End If

        If psi.Count <= 0 Then
            Exit Function
        End If


        dtPlanStart.EditValue = Format(psi(0).PS_Date, "yyyy/MM/dd")
        dtPlanEnd.EditValue = Format(psi(0).PS_Date.AddDays(psi.Count - 1), "yyyy/MM/dd")

        cbType.EditValue = psi(0).Pro_Type
        GluDep.EditValue = psi(0).PS_Dep

        dtPMCode.EditValue = psi(0).PM_M_Code
  

        dtPMCode_EditValueChanged(Nothing, Nothing)
        gluType.EditValue = psi(0).PM_Type


        '加載審核數據
      
        chkCheck.Checked = psi(0).PS_Check
        lblCheckDateTime.Text = psi(0).PS_CheckDate
        lblCheckAction.Text = psi(0).PS_CheckAction
        txtCheckRemark.Text = psi(0).PS_CheckRemark


        Dim i As Integer
        For i = 0 To psi.Count - 1
            Dim row As DataRow
            row = ds.Tables("ProductionSchedule").NewRow

            row("dtDate") = psi(i).PS_Date.ToString("yyyy/MM/dd")
            row("PlanCount") = psi(i).PS_DayNumber
            row("C_Qty") = psi(i).C_Qty
            row("PS_Num") = psi(i).PS_Num
            ds.Tables("ProductionSchedule").Rows.Add(row)
        Next

        LoadQty()

    End Function



    ''' <summary>
    ''' 新增,控件有效
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AddControlValid()


        GluDep.Enabled = True
        dtPMCode.Enabled = True

        gluType.Enabled = True
        cbType.Enabled = True
        btnQuery.Enabled = True
    End Sub

    ''' <summary>
    ''' 生產部門
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadFacName()
        Dim fc As New FacControler
        Dim fi As New FacInfo

        GluDep.Properties.DataSource = fc.GetFacList(Nothing, Nothing)
        GluDep.Properties.DisplayMember = "FacName"
        GluDep.Properties.ValueMember = "FacID"

    End Sub

    ''' <summary>
    ''' 加載產品編號
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadProductNo()
        Dim pc As New ProcessMainControl
        dtPMCode.Properties.DisplayMember = "PM_M_Code"
        dtPMCode.Properties.ValueMember = "PM_M_Code"
        dtPMCode.Properties.DataSource = pc.ProcessMain_GetList3(Nothing, Nothing)
    End Sub

    ''' <summary>
    ''' 初始化計畫日期
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadDateTime()
        dtPlanStart.Text = Format(Now.AddDays(8 - Now.DayOfWeek), "yyyy/MM/dd")
        dtPlanEnd.Text = Format(Now.AddDays(8 - Now.DayOfWeek + 6), "yyyy/MM/dd")
    End Sub

    '加載需求數量
    Private Function LoadQty() As Boolean

        LoadQty = False

        txtQty.Text = String.Empty


        Dim psc As New ProductionScheduleControl
        Dim psi As New List(Of ProductionScheduleInfo)
        psi = psc.ProductPlan_GetQty(dtPMCode.EditValue, dtPlanStart.Text)

        If psi.Count <= 0 Then
            Exit Function
        End If

        Dim scheduleQty As String
        scheduleQty = psi(0).SumNoSendQty - (psi(0).SumDayQty + psi(0).SumPIQty)

        If scheduleQty > 0 Then
            GridView1.OptionsBehavior.Editable = True
            GridView1.Columns.Item("dtDate").OptionsColumn.ReadOnly = True
            GridView1.Columns.Item("C_Qty").OptionsColumn.ReadOnly = True
            LoadQty = True
        End If

        lblCount.Text = String.Empty
        lblCount.Text = "訂單未交數：" & psi(0).SumNoSendQty.ToString() & ",  產線結餘數：" & psi(0).SumDayQty.ToString() & ",  庫存數量：" & psi(0).SumPIQty.ToString()
        lblCount.Visible = True
        txtQty.Text = scheduleQty


    End Function

    ''' <summary>
    ''' 填充數據網格
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FillDataGrid()
        Dim ts As New TimeSpan

        Dim strDate1 As DateTime
        Dim strDate2 As DateTime


        strDate1 = DateTime.Parse(dtPlanEnd.Text)
        strDate2 = DateTime.Parse(dtPlanStart.Text)

        ts = strDate1 - strDate2


        Dim i As Integer
        For i = 0 To ts.Days
            Dim row As DataRow
            row = ds.Tables("ProductionSchedule").NewRow
            row("dtDate") = Convert.ToDateTime(dtPlanStart.Text).AddDays(i).ToString("yyyy/MM/dd")
            ds.Tables("ProductionSchedule").Rows.Add(row)
        Next

    End Sub

#End Region

#Region "根據產品編號加載數據"
    Private Sub dtPMCode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtPMCode.EditValueChanged

        On Error Resume Next

        Dim ppc As New ProcessMainControl
        Dim ppi As List(Of ProcessMainInfo)
        ds.Tables("ProductType").Clear()
        ppi = ppc.ProcessMain_GetList2(cbType.EditValue, dtPMCode.EditValue)
        If ppi.Count = 0 Then
        Else

            Dim i As Integer
            For i = 0 To ppi.Count - 1
                Dim row As DataRow
                row = ds.Tables("ProductType").NewRow
                row("PM_Type") = ppi(i).Type3ID
                ds.Tables("ProductType").Rows.Add(row)
            Next

        End If

    End Sub
#End Region

#Region "根據工藝類型調用產品編號加載數據"
    Private Sub cbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbType.SelectedIndexChanged
        If dtPMCode.Text <> "" Then
            dtPMCode_EditValueChanged(Nothing, Nothing)
        End If
    End Sub
#End Region

#Region "查詢生產計畫數量"
    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click

        If dtPMCode.Text <> "" And dtPlanStart.Text <> "" Then
            GridView1.OptionsBehavior.Editable = False
       
            ds.Tables("ProductionSchedule").Clear()
            Select Case m_EditItemDescrip
                Case "Add"
                    If LoadQty() Then
                        FillDataGrid()
                    End If
                Case Else
                    ModifyLoadData()
            End Select

          
           
        Else
            MsgBox("計畫起始日期或者產品編號不能為空！", 64, "提示")
        End If

    End Sub
#End Region

#Region "關閉窗體"
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
#End Region

End Class