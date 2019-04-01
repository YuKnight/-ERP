Imports LFERP.DataSetting
Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.Production.ProductionWareShipped
Imports LFERP.Library.WareHouse.WareInventory
Imports LFERP.Library.WareHouse
Imports LFERP.Library.Purchase.SharePurchase
Imports LFERP.Library.ProductionSchedule

Imports LFERP.SystemManager

Public Class ProductionWareShipped
#Region "屬性設置"
    Dim pic As New ProductInventoryController
    Dim upi As List(Of UserPowerInfo)
    Dim upc As New UserPowerControl

    Dim ds As New DataSet
    Dim strWHOutID, strWHInID As String
    Dim oldCheck, oldInCheck As Boolean

    Dim strProType As String '2013

    Private _EditItem As String
    Private _EditValue As String
    Private _EditID As String
    Private _EditName As String
    Private _EditM_Code As String
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
    Public Property EditID() As String
        Get
            Return _EditID
        End Get
        Set(ByVal value As String)
            _EditID = value
        End Set
    End Property
    Public Property EditName() As String
        Get
            Return _EditName
        End Get
        Set(ByVal value As String)
            _EditName = value
        End Set
    End Property
    Public Property EditM_Code() As String
        Get
            Return _EditM_Code
        End Get
        Set(ByVal value As String)
            _EditM_Code = value
        End Set
    End Property
#End Region

#Region "新增修改程序"
    ''' <summary>
    '''  '新增程序   
    ''' </summary>
    Sub DataNew()
        Dim pi As New ProductionWareShippedInfo
        Dim pc As New ProductionWareShippedControl

        txtWIPID.Text = GetNO()
        pi.PWS_NO = txtWIPID.Text
        pi.PWS_WareID = strWHOutID
        pi.PWS_InWareID = strWHInID
        pi.PWS_DepID = GluDep.EditValue
        pi.PWS_Type = cbType.EditValue
        pi.PWS_AddDate = DateEdit1.Text
        pi.PWS_Remark = txtRemark.Text
        pi.PWS_Action = InUserID

        Dim i As Integer
        With ds.Tables("ProductionWareShipped")
            For i = 0 To .Rows.Count - 1
                pi.PWS_SubNO = GetSubNO()
                pi.PM_M_Code = .Rows(i)("PM_M_Code")
                pi.PWS_M_Code = .Rows(i)("M_Code")
                pi.PWS_Qty = IIf(IsDBNull(.Rows(i)("PWS_Qty")), 0, .Rows(i)("PWS_Qty"))
                pi.PWS_SubRemark = IIf(IsDBNull(.Rows(i)("PWS_SubRemark")), String.Empty, .Rows(i)("PWS_SubRemark"))
                pi.PWS_SubType = IIf(IsDBNull(.Rows(i)("PWS_SubType")), String.Empty, .Rows(i)("PWS_SubType"))
                pi.PM_Type = IIf(IsDBNull(.Rows(i)("PM_Type")), String.Empty, .Rows(i)("PM_Type"))
                pc.ProductionWareShipped_Add(pi)
            Next
        End With
        MsgBox("已保存,單號: " & txtWIPID.Text & " ")
        Me.Close()
    End Sub
    ''' <summary>
    '''  修改程序  
    ''' </summary>
    Sub DataEdit()
        Dim i As Integer
        If ds.Tables("DelProductionWareShipped").Rows.Count > 0 Then
            Dim j As Integer
            For j = 0 To ds.Tables("DelProductionWareShipped").Rows.Count - 1
                Dim pc As New ProductionWareShippedControl
                If Not IsDBNull(ds.Tables("DelProductionWareShipped").Rows(j)("PWS_SubNO")) Then
                    pc.ProductionWareShipped_Delete(ds.Tables("ProductionWareShipped").Rows(j)("PWS_NO"), ds.Tables("ProductionWareShipped").Rows(j)("PWS_SubNO"))
                End If
            Next j
        End If

        With ds.Tables("ProductionWareShipped")
            For i = 0 To .Rows.Count - 1
                If IsDBNull(.Rows(i)("PWS_SubNO")) Then
                    Dim pi As New ProductionWareShippedInfo
                    Dim pc As New ProductionWareShippedControl
                    pi.PWS_NO = txtWIPID.Text
                    pi.PWS_WareID = strWHOutID
                    pi.PWS_InWareID = strWHInID
                    pi.PWS_DepID = GluDep.EditValue
                    pi.PWS_Type = cbType.EditValue
                    pi.PWS_AddDate = DateEdit1.Text
                    pi.PWS_Remark = txtRemark.Text
                    pi.PWS_Action = InUserID
                    pi.PWS_SubNO = GetSubNO()

                    pi.PM_M_Code = .Rows(i)("PM_M_Code")
                    pi.PWS_M_Code = .Rows(i)("M_Code")

                    pi.PWS_Qty = IIf(IsDBNull(.Rows(i)("PWS_Qty")), 0, .Rows(i)("PWS_Qty"))
                    pi.PWS_SubRemark = IIf(IsDBNull(.Rows(i)("PWS_SubRemark")), String.Empty, .Rows(i)("PWS_SubRemark"))
                    pi.PWS_SubType = IIf(IsDBNull(.Rows(i)("PWS_SubType")), String.Empty, .Rows(i)("PWS_SubType"))
                    pi.PM_Type = IIf(IsDBNull(.Rows(i)("PM_Type")), String.Empty, .Rows(i)("PM_Type"))
                    pc.ProductionWareShipped_Add(pi)

                ElseIf Not IsDBNull(ds.Tables("ProductionWareShipped").Rows(i)("PWS_SubNO")) Then
                    Dim pi As New ProductionWareShippedInfo
                    Dim pc As New ProductionWareShippedControl

                    pi.PWS_NO = txtWIPID.Text
                    pi.PWS_WareID = strWHOutID
                    pi.PWS_InWareID = strWHInID
                    pi.PWS_DepID = GluDep.EditValue
                    pi.PWS_Type = cbType.EditValue
                    pi.PWS_AddDate = DateEdit1.Text
                    pi.PWS_Remark = txtRemark.Text
                    pi.PWS_Action = InUserID

                    pi.PWS_SubNO = .Rows(i)("PWS_SubNO")
                    pi.PM_M_Code = .Rows(i)("PM_M_Code")
                    pi.PWS_M_Code = .Rows(i)("M_Code")

                    pi.PWS_Qty = IIf(IsDBNull(.Rows(i)("PWS_Qty")), 0, .Rows(i)("PWS_Qty"))
                    pi.PWS_SubRemark = IIf(IsDBNull(.Rows(i)("PWS_SubRemark")), String.Empty, .Rows(i)("PWS_SubRemark"))
                    pi.PWS_SubType = IIf(IsDBNull(.Rows(i)("PWS_SubType")), String.Empty, .Rows(i)("PWS_SubType"))
                    pi.PM_Type = IIf(IsDBNull(.Rows(i)("PM_Type")), String.Empty, .Rows(i)("PM_Type"))
                    pc.ProductionWareShipped_Update(pi)
                End If
            Next
        End With
        MsgBox("已保存,單號: " & txtWIPID.Text & " ")
        Me.Close()
    End Sub
#End Region

#Region "創建臨時表"
    ''' <summary>
    ''' 創建臨時表
    ''' </summary>
    Sub CreateTable()
        ds.Tables.Clear()
        '表一
        With ds.Tables.Add("ProductionWareShipped")
            .Columns.Add("AutoID", GetType(String))

            .Columns.Add("PWS_SubNO", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("PWS_Qty", GetType(Integer))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("PWS_SubType", GetType(String))
            .Columns.Add("PWS_SubRemark", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
            .Columns.Add("PM_JiYu", GetType(String))
            .Columns.Add("PI_Qty", GetType(Integer))
        End With
        Grid.DataSource = ds.Tables("ProductionWareShipped")
        '表二
        With ds.Tables.Add("DelProductionWareShipped")
            .Columns.Add("PWS_NO", GetType(String))
            .Columns.Add("PWS_SubNO", GetType(String))
        End With
    End Sub
#End Region

#Region "返回查詢數據到控件"
    Public Function LoadData(ByVal PWO_NO As String) As Boolean
        LoadData = True
        ds.Tables("ProductionWareShipped").Clear()
        Dim piL As New List(Of ProductionWareShippedInfo)
        Dim pc As New ProductionWareShippedControl
        Dim pii As New List(Of ProductInventoryInfo)
        piL = pc.ProductionWareShipped_GetList(PWO_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        Try
            If piL.Count = 0 Then
                MsgBox("沒有數據")
                LoadData = False
                Exit Function
            Else
                strWHOutID = piL(0).PWS_WareID
                txtWIPID.Text = piL(0).PWS_NO
                txtWH.EditValue = piL(0).PWS_OutName
                txtWHIn.EditValue = piL(0).PWS_InName
                strWHInID = piL(0).PWS_InWareID
                GluDep.EditValue = piL(0).PWS_DepID
                cbType.EditValue = piL(0).PWS_Type
                DateEdit1.EditValue = piL(0).PWS_AddDate
                txtRemark.Text = piL(0).PWS_Remark
                CheckEdit1.Checked = piL(0).PWS_Check
                oldCheck = IIf(CheckEdit1.Checked, True, False)
                CheckEdit3.Checked = piL(0).PWS_InCheck
                oldInCheck = IIf(CheckEdit3.Checked, True, False)
                CheckDate.Text = piL(0).PWS_CheckDate
                CheckAction.Text = piL(0).PWS_CheckActionName
                CheckRemark.Text = piL(0).PWS_CheckRemark
                Dim i As Integer
                Dim row As DataRow
                For i = 0 To piL.Count - 1
                    row = ds.Tables("ProductionWareShipped").NewRow

                    row("AutoID") = piL(i).AutoID

                    row("PWS_SubNO") = piL(i).PWS_SubNO
                    row("PM_M_Code") = piL(i).PM_M_Code
                    row("M_Code") = piL(i).M_Code
                    row("M_Name") = piL(i).M_Name
                    row("M_Gauge") = piL(i).M_Gauge
                    row("M_Unit") = piL(i).M_Unit
                    row("PWS_Qty") = piL(i).PWS_Qty
                    row("PWS_SubType") = piL(i).PWS_SubType
                    row("PWS_SubRemark") = piL(i).PWS_SubRemark
                    If piL(i).PM_Type <> "" Then
                        row("PM_Type") = piL(i).PM_Type
                    Else
                        row("PM_Type") = LoadProductionType(cbType.EditValue, piL(i).PM_M_Code, piL(i).M_Code)
                    End If
                    row("PM_JiYu") = piL(i).PM_JiYu
                    pii = pic.ProductInventory_GetList(piL(i).PM_M_Code, piL(i).M_Code, strWHOutID, Nothing)
                    If pii.Count > 0 Then
                        row("PI_Qty") = pii(0).PI_Qty
                    Else
                        row("PI_Qty") = 0
                    End If
                    ds.Tables("ProductionWareShipped").Rows.Add(row)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

#End Region

#Region "啟動窗體事件"
    Private Sub ProductionWareShipped_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()
        txtWIPID.Enabled = False
        DateEdit1.Text = Format(Now, "yyyy/MM/dd")
        Select Case EditItem
            Case "Shipped" '出貨單
                If Edit = False Then
                    Me.Text = "裝配出貨單--新增"
                    Me.Label1.Text = Me.Text
                    upi = upc.UserPower_GetList(InUserID, Nothing, Nothing, Nothing)
                    GluDep.EditValue = upi(0).DepID
                    GluDep.Enabled = False
                    '  cbType.EditValue = upi(0).UserType

                    cbType.EditValue = "裝配出貨"

                    '--------------------------------------------------------
                    Dim pmws As New PermissionModuleWarrantSubController
                    Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
                    pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881011")
                    If pmwiL.Count > 0 Then
                        If pmwiL.Item(0).PMWS_Value = "是" Then cbType.EditValue = upi(0).UserType
                    End If
                    '---------------------------------------------------------



                    cbType.Enabled = False
                Else
                    txtWIPID.Text = EditValue
                    LoadData(EditValue)
                    CheckEdit1.Enabled = False
                    CheckRemark.Enabled = False
                    Me.Text = "裝配出貨單--修改" & EditValue
                    Me.Label1.Text = Me.Text
                End If

                XtraTabControl1.SelectedTabPage = XtraTabPage1
                XtraTabPage2.PageVisible = False
            Case "PreView"
                Me.Text = "裝配出貨單--查看" & EditValue
                Me.Label1.Text = Me.Text
                LoadData(EditValue)
                cmdSave.Visible = False
                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Case "Check"
                Me.Text = "裝配出貨單--審核" & EditValue
                Me.Label1.Text = Me.Text
                txtWH.Enabled = False
                txtWHIn.Enabled = False
                GluDep.Enabled = False
                cbType.Enabled = False
                DateEdit1.Enabled = False
                txtRemark.Enabled = False
                GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                GridView1.OptionsBehavior.Editable = False
                GridView1.OptionsSelection.EnableAppearanceFocusedCell = False

                LoadData(EditValue)
                XtraTabControl1.SelectedTabPage = XtraTabPage2
            Case "InCheck"
                Me.Text = "裝配出貨單--收貨確認" & EditValue
                Me.Label1.Text = Me.Text
                txtWHIn.Enabled = False
                txtWH.Enabled = False
                GluDep.Enabled = False
                cbType.Enabled = False
                DateEdit1.Enabled = False
                txtRemark.Enabled = False
                XtraTabPage2.PageVisible = False
                CheckEdit3.Enabled = True

                GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                GridView1.OptionsBehavior.Editable = False
                GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
                LoadData(EditValue)
        End Select
        cmdGuideAdd.Visible = False
    End Sub
#End Region

#Region "審核－－確認收貨"
    Sub UpdateCheck()
        Dim pi As New ProductionWareShippedInfo
        Dim pc As New ProductionWareShippedControl
        If oldCheck = CheckEdit1.Checked Then
            MsgBox("審核狀態未改變，請更改狀態後再保存……")
            Exit Sub
        End If

        pi.PWS_NO = txtWIPID.Text
        pi.PWS_Check = CheckEdit1.Checked
        pi.PWS_CheckAction = InUserID
        pi.PWS_CheckDate = Format(Now, "yyyy/MM/dd")
        pi.PWS_CheckRemark = CheckRemark.Text

        If pc.ProductionWareShipped_UpdateCheck(pi) = True Then
            MsgBox("審核狀態已改變!")
        Else
            MsgBox("審核失敗,請檢查原因!")
            Exit Sub
        End If

        'Dim strFac As String
        'strFac = Mid(GluDep.EditValue, 1, 1)
        'Dim psi As New ProductionScheduleInfo
        'Dim psc As New ProductionScheduleControl
        'Dim psi1 As List(Of ProductionScheduleInfo)

        'Dim j As Integer
        'For j = 0 To ds.Tables("ProductionWareShipped").Rows.Count - 1
        '    psi1 = psc.ProductionSchedule_GetList1(Nothing, cbType.EditValue, ds.Tables("ProductionWareShipped").Rows(j)("PM_M_Code"), ds.Tables("ProductionWareShipped").Rows(j)("M_Code"), strFac, Nothing, DateEdit1.Text, DateEdit1.Text, ds.Tables("ProductionWareShipped").Rows(j)("PM_Type"))
        '    If psi1.Count = 0 Then
        '    Else
        '        Dim m As Single
        '        m = psi1(0).PS_ActualNumber
        '        psi.PS_NO = psi1(0).PS_NO '得到當前單號
        '        psi.Pro_Type = cbType.EditValue
        '        psi.PM_M_Code = psi1(0).PM_M_Code
        '        psi.PM_Type = psi1(0).PM_Type
        '        psi.PS_Dep = strFac
        '        psi.PS_Date = CDate(DateEdit1.Text)
        '        If CheckEdit1.Checked = True Then
        '            psi.PS_ActualNumber = m + CSng(ds.Tables("ProductionWareShipped").Rows(j)("PWS_Qty"))
        '        Else
        '            psi.PS_ActualNumber = m - CSng(ds.Tables("ProductionWareShipped").Rows(j)("PWS_Qty"))
        '        End If
        '        psc.ProductionSchedule_UpdateActualNumber(psi)
        '    End If
        'Next
        Me.Close()
    End Sub

    Sub UpdateInCheck()


        If oldInCheck = CheckEdit3.Checked Then
            MsgBox("收貨確認未改變，請更改狀態後再保存……")
            Exit Sub
        End If


        Dim i As Integer
        For i = 0 To ds.Tables("ProductionWareShipped").Rows.Count - 1
            Dim DoublePWS_EndQty As Double
            Dim DoublePWS_EndQty1 As Double

            '----------------出貨扣賬處理----------------------------------------
            Dim pii As New ProductInventoryInfo
            pii.WH_ID = strWHOutID
            Dim piiGet As New List(Of ProductInventoryInfo)

            piiGet = pic.ProductInventory_GetList(ds.Tables("ProductionWareShipped").Rows(i)("PM_M_Code").ToString, ds.Tables("ProductionWareShipped").Rows(i)("M_Code").ToString, strWHOutID, Nothing)
            If CheckEdit3.Checked = True Then
                pii.PI_Qty = piiGet(0).PI_Qty - CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty"))
            ElseIf CheckEdit3.Checked = False Then
                pii.PI_Qty = piiGet(0).PI_Qty + CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty"))
            End If

            DoublePWS_EndQty1 = piiGet(0).PI_Qty

            pii.PM_M_Code = ds.Tables("ProductionWareShipped").Rows(i)("PM_M_Code").ToString
            pii.M_Code = ds.Tables("ProductionWareShipped").Rows(i)("M_Code").ToString

            ''''添加記錄扣數++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            If pic.ProductInventory_Update(pii) = False Then
                MsgBox("出貨扣賬失敗,請檢查原因!", MsgBoxStyle.Information, "提示")
                Exit Sub
            End If

            '----------------收貨扣賬處理----------------------------------------
            Dim wiinfo As New WareInventoryInfo
            Dim wicon As New WareInventoryMTController
            wiinfo.WH_ID = strWHInID

            Dim piiGetA As New List(Of WareInventoryInfo)
            piiGetA = wicon.WareInventory_GetList3(ds.Tables("ProductionWareShipped").Rows(i)("PM_M_Code").ToString, strWHInID, False)
            If CheckEdit3.Checked = True Then
                If piiGetA.Count = 0 Then
                    wiinfo.WI_Qty = CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty"))
                    DoublePWS_EndQty = 0
                Else
                    wiinfo.WI_Qty = piiGetA(0).WI_Qty + CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty"))
                    DoublePWS_EndQty = piiGetA(0).WI_Qty
                End If
            ElseIf CheckEdit3.Checked = False Then
                If piiGetA.Count = 0 Then
                    wiinfo.WI_Qty = 0 - CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty"))
                    DoublePWS_EndQty = 0
                Else
                    wiinfo.WI_Qty = piiGetA(0).WI_Qty - CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty"))
                    DoublePWS_EndQty = piiGetA(0).WI_Qty
                End If
            End If

            wiinfo.M_Code = ds.Tables("ProductionWareShipped").Rows(i)("PM_M_Code").ToString
            wiinfo.WI_UserID = InUserID
            wiinfo.WI_EditDate = Format(Now, "yyyy/MM/dd")
            If wicon.WareInventory_UpdateA(wiinfo) = False Then
                MsgBox("收貨扣賬失敗,請檢查原因!", MsgBoxStyle.Information, "提示")
                Exit Sub
            End If

            ''''添加記錄++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Dim pi As New ProductionWareShippedInfo
            Dim pc As New ProductionWareShippedControl

            pi.PWS_NO = txtWIPID.Text
            pi.PWS_InCheck = CheckEdit3.Checked
            pi.PWS_InAction = InUserID
            pi.PWS_InAddDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
            pi.AutoID = ds.Tables("ProductionWareShipped").Rows(i)("AutoID")
            pi.PWS_EndQty = DoublePWS_EndQty
            pi.PWS_EndQty1 = DoublePWS_EndQty1

            If pc.ProductionWareShipped_UpdateInCheck1(pi) = True Then

            Else
                MsgBox("收貨確認,請檢查原因!")
                Exit Sub
            End If

            ''------2013-10-23----------------------------------------------------------
            '生產計划
            Dim Qty As Int32
            If CheckEdit3.Checked = True Then
                Qty = CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty"))
            ElseIf CheckEdit1.Checked = False Then
                Qty = -CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty"))
            End If

            UpdateSchedule(strWHOutID, cbType.EditValue, pii.PM_M_Code, pii.M_Code, ds.Tables("ProductionWareShipped").Rows(i)("PM_Type").ToString, DateEdit1.EditValue, Qty)

        Next

        MsgBox("收貨確認已改變!")

        '--------------------------------------------------------------------------
        Me.Close()
    End Sub


    'Sub UpdateInCheck()
    '    Dim pi As New ProductionWareShippedInfo
    '    Dim pc As New ProductionWareShippedControl

    '    If oldInCheck = CheckEdit3.Checked Then
    '        MsgBox("收貨確認未改變，請更改狀態後再保存……")
    '        Exit Sub
    '    End If

    '    pi.PWS_NO = txtWIPID.Text
    '    pi.PWS_InCheck = CheckEdit3.Checked
    '    pi.PWS_InAction = InUserID
    '    pi.PWS_InAddDate = Format(Now, "yyyy/MM/dd")

    '    If pc.ProductionWareShipped_UpdateInCheck(pi) = True Then
    '        MsgBox("收貨確認已改變!")
    '    Else
    '        MsgBox("收貨確認,請檢查原因!")
    '        Exit Sub
    '    End If

    '    '----------------出貨扣賬處理----------------------------------------
    '    Dim i%
    '    Dim pii As New ProductInventoryInfo
    '    pii.WH_ID = strWHOutID
    '    For i = 0 To ds.Tables("ProductionWareShipped").Rows.Count - 1
    '        Dim piiGet As New List(Of ProductInventoryInfo)

    '        piiGet = pic.ProductInventory_GetList(ds.Tables("ProductionWareShipped").Rows(i)("PM_M_Code").ToString, ds.Tables("ProductionWareShipped").Rows(i)("M_Code").ToString, strWHOutID, Nothing)
    '        If CheckEdit3.Checked = True Then
    '            pii.PI_Qty = piiGet(0).PI_Qty - CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty"))
    '        ElseIf CheckEdit3.Checked = False Then
    '            pii.PI_Qty = piiGet(0).PI_Qty + CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty"))
    '        End If

    '        pii.PM_M_Code = ds.Tables("ProductionWareShipped").Rows(i)("PM_M_Code").ToString
    '        pii.M_Code = ds.Tables("ProductionWareShipped").Rows(i)("M_Code").ToString

    '        If pic.ProductInventory_Update(pii) = False Then
    '            MsgBox("出貨扣賬失敗,請檢查原因!", MsgBoxStyle.Information, "提示")
    '            Exit Sub
    '        End If

    '        ''------2013-10-23----------------------------------------------------------
    '        '生產計划
    '        Dim Qty As Int32
    '        If CheckEdit3.Checked = True Then
    '            Qty = CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty"))
    '        ElseIf CheckEdit1.Checked = False Then
    '            Qty = -CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty"))
    '        End If

    '        UpdateSchedule(strWHOutID, cbType.EditValue, pii.PM_M_Code, pii.M_Code, ds.Tables("ProductionWareShipped").Rows(i)("PM_Type").ToString, DateEdit1.EditValue, Qty)

    '    Next
    '    '----------------收貨扣賬處理----------------------------------------
    '    Dim wiinfo As New WareInventoryInfo
    '    Dim wicon As New WareInventoryMTController
    '    wiinfo.WH_ID = strWHInID
    '    For i = 0 To ds.Tables("ProductionWareShipped").Rows.Count - 1
    '        Dim piiGet As List(Of WareInventoryInfo)
    '        piiGet = wicon.WareInventory_GetList3(ds.Tables("ProductionWareShipped").Rows(i)("PM_M_Code").ToString, strWHInID, False)
    '        If CheckEdit3.Checked = True Then
    '            If piiGet.Count = 0 Then
    '                wiinfo.WI_Qty = CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty"))
    '            Else
    '                wiinfo.WI_Qty = piiGet(0).WI_Qty + CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty"))
    '            End If
    '        ElseIf CheckEdit3.Checked = False Then
    '            If piiGet.Count = 0 Then
    '                wiinfo.WI_Qty = 0 - CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty"))
    '            Else
    '                wiinfo.WI_Qty = piiGet(0).WI_Qty - CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty"))
    '            End If
    '        End If
    '        wiinfo.M_Code = ds.Tables("ProductionWareShipped").Rows(i)("PM_M_Code").ToString
    '        wiinfo.WI_UserID = InUserID
    '        wiinfo.WI_EditDate = Format(Now, "yyyy/MM/dd")
    '        If wicon.WareInventory_UpdateA(wiinfo) = False Then
    '            MsgBox("收貨扣賬失敗,請檢查原因!", MsgBoxStyle.Information, "提示")
    '            Exit Sub
    '        End If
    '    Next
    '    '--------------------------------------------------------------------------
    '    Me.Close()
    'End Sub
#End Region

#Region "子表新增刪除事件"
    Private Sub cmsCodeAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsCodeAdd.Click
        If Me.txtWH.Text = "" Then
            MsgBox("請先選擇出貨倉！")
            txtWH.Select()
            Exit Sub
        End If

        tempValue13 = strWHOutID

        tempCode = ""
        tempValue6 = "出貨管理"
        frmBOMSelect.XtraTabPage1.PageVisible = False
        frmBOMSelect.XtraTabPage2.PageVisible = False
        frmBOMSelect.XtraTabPage3.PageVisible = True
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
                For j = 0 To ds.Tables("ProductionWareShipped").Rows.Count - 1
                    If arr(i) = ds.Tables("ProductionWareShipped").Rows(j)("M_Code") Then
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

                Dim row As DataRow
                row = ds.Tables("ProductionWareShipped").NewRow
                row("PM_M_Code") = ""
                row("M_Code") = objInfo.M_Code
                row("M_Name") = objInfo.M_Name
                row("M_Unit") = objInfo.M_Unit
                row("M_Gauge") = objInfo.M_Gauge
                row("PWS_Qty") = 0
                row("PWS_SubType") = "正批"
                ds.Tables("ProductionWareShipped").Rows.Add(row)
                GridView1.MoveLast()
            Next
        ElseIf frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 2 Then   '聯豐編號

            frmBOMSelect.Dispose()

            Dim i, n As Integer
            Dim arr(n) As String
            arr = Split(tempValue8, ",")
            n = Len(Replace(tempValue8, ",", "," & "*")) - Len(tempValue8)
            For i = 0 To n
                If arr(i) = "" Then
                    Exit Sub
                End If
                Dim mc As New LFERP.Library.Material.MaterialController
                Dim objInfo As New LFERP.Library.Material.MaterialInfo
                objInfo = mc.MaterialCode_Get(arr(i))
                Dim row As DataRow
                row = ds.Tables("ProductionWareShipped").NewRow
                row("PM_M_Code") = tempValue3
                row("M_Code") = objInfo.M_Code
                row("M_Name") = objInfo.M_Name
                row("M_Gauge") = objInfo.M_Gauge
                row("M_Unit") = objInfo.M_Unit
                row("PWS_Qty") = 0
                row("PWS_SubType") = "正批"
                row("PM_Type") = LoadProductionType(cbType.EditValue, tempValue3, objInfo.M_Code)
                Dim ppc1 As New ProcessMainControl
                Dim ppi1 As New List(Of ProcessMainInfo)
                ppi1 = ppc1.ProcessMain_GetList1(Nothing, tempValue3, cbType.EditValue, objInfo.M_Code)
                If ppi1.Count > 0 Then
                    row("PM_JiYu") = ppi1(0).PM_JiYu
                End If
                Dim pii As New List(Of ProductInventoryInfo)
                pii = pic.ProductInventory_GetList(tempValue3, objInfo.M_Code, strWHOutID, Nothing)
                If pii.Count > 0 Then
                    row("PI_Qty") = pii(0).PI_Qty
                Else
                    row("PI_Qty") = 0
                End If
                ds.Tables("ProductionWareShipped").Rows.Add(row)
                GridView1.MoveLast()
            Next
        End If



        tempValue7 = ""
        tempValue8 = ""
        tempValue13 = ""


    End Sub

    Sub AddRow(ByVal strCode As String)
        If strCode = "" Then
        Else
            Dim i As Integer
            For i = 0 To ds.Tables("ProductionWareShipped").Rows.Count - 1
                If strCode = ds.Tables("ProductionWareShipped").Rows(i)("M_Code") Then
                    MsgBox("一張單不允許有重復物料編碼....")
                    Exit Sub
                End If
            Next
            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)
            Dim row As DataRow
            row = ds.Tables("ProductionWareShipped").NewRow
            row("PM_M_Code") = IIf(Mid(objInfo.M_Code, 1, 2) = "MG", objInfo.M_Code, String.Empty)
            row("M_Code") = objInfo.M_Code
            row("M_Name") = objInfo.M_Name
            row("M_Unit") = objInfo.M_Unit
            row("M_Gauge") = objInfo.M_Gauge
            row("PWS_Qty") = 0
            row("PWS_SubType") = "正批"
            ds.Tables("ProductionWareShipped").Rows.Add(row)
            GridView1.MoveLast()
        End If
    End Sub
    ''' <summary>
    '''     子表刪除
    ''' </summary>
    Private Sub cmsCodeDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsCodeDel.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "PWS_SubNO")
        If DelTemp = "PWS_SubNO" Then
        Else
            Dim row As DataRow = ds.Tables("DelProductionWareShipped").NewRow
            row("PWS_NO") = txtWIPID.Text
            row("PWS_SubNO") = DelTemp
            ds.Tables("DelProductionWareShipped").Rows.Add(row)
        End If
        ds.Tables("ProductionWareShipped").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub

    Private Sub cmdGuideAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuideAdd.Click
        tempValue5 = "生產倉出貨"
        Dim fr As New frmProductionSelect
        fr.ShowDialog()
    End Sub

#End Region

#Region "按鍵事件"
    Private Sub txtWH_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtWH.ButtonClick
        tempCode = "生產倉庫"
        frmWareHouseSelect.SelectWareID = ""
        tempValue2 = "881005"
        tempValue3 = "881005"
        frmWareHouseSelect.StartPosition = FormStartPosition.Manual
        frmWareHouseSelect.Left = MDIMain.Left + MDIMain.tvModule.Width + Me.Left + txtWH.Left + 15
        frmWareHouseSelect.Top = MDIMain.Top + Me.Top + txtWH.Top + txtWH.Height + 140
        frmWareHouseSelect.ShowDialog()
        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            strWHOutID = frmWareHouseSelect.SelectWareID
            txtWH.Text = frmWareHouseSelect.SelectWareName
        End If
    End Sub

    Private Sub txtWHIn_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtWHIn.ButtonClick
        tempCode = "生產倉庫"
        frmWareHouseSelect.SelectWareID = ""
        tempValue2 = "881008"
        tempValue3 = "881008"
        frmWareHouseSelect.StartPosition = FormStartPosition.Manual
        frmWareHouseSelect.Left = MDIMain.Left + MDIMain.tvModule.Width + Me.Left + txtWHIn.Left + 15
        frmWareHouseSelect.Top = MDIMain.Top + Me.Top + txtWHIn.Top + txtWHIn.Height + 140
        frmWareHouseSelect.ShowDialog()
        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            strWHInID = frmWareHouseSelect.SelectWareID
            txtWHIn.Text = frmWareHouseSelect.SelectWareName
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case EditItem
            Case "Shipped"
                If Edit = False Then
                    If CheckData() = True Then
                        DataNew()
                    End If
                Else
                    DataEdit()
                End If
            Case "Check"
                If CheckData() = True Then
                    UpdateCheck()
                End If
            Case "InCheck"
                If CheckData() = True Then
                    UpdateInCheck()
                End If
        End Select
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

#End Region

#Region "檢查事件----是否為空"
    Function CheckData() As Boolean  '判斷當前發出倉庫物料是否夠數
        CheckData = True
        If txtWH.Text = "" Then
            MsgBox("出貨倉庫不能為空")
            CheckData = False
            Exit Function
        End If
        If txtWHIn.Text = "" Then
            MsgBox("收貨倉庫不能為空")
            CheckData = False
            Exit Function
        End If

        If DateEdit1.Text = "" Then
            MsgBox("出貨日期不能為空")
            CheckData = False
            Exit Function
        End If

        If ds.Tables("ProductionWareShipped").Rows.Count <= 0 Then
            MsgBox("沒有添加任何物料")
            CheckData = False
            Exit Function
        End If

        Dim i, j As Integer
        For i = 0 To ds.Tables("ProductionWareShipped").Rows.Count - 1

            If IsDBNull(ds.Tables("ProductionWareShipped").Rows(i)("PM_M_Code")) Then
                MsgBox("產品編號不能為NULL!")
                CheckData = False
                Exit Function
            End If

            If ds.Tables("ProductionWareShipped").Rows(i)("PM_M_Code") = "" Then
                MsgBox("產品編號不能為空!")
                CheckData = False
                Exit Function
            End If



            If ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty") = 0 Then
                MsgBox("出貨數量不能為0！")
                CheckData = False
                Exit Function
            End If

            '-----------------------出貨到成品檢查只能出成品-------------------------
            Dim whlist As New List(Of WareHouseInfo)
            Dim wh As New WareHouseController
            whlist = wh.WareHouse_GetList("'" + strWHInID + "'")
            If whlist(0).WH_Remark = "成品倉" Then
                If ds.Tables("ProductionWareShipped").Rows(i)("PM_M_Code").ToString <> ds.Tables("ProductionWareShipped").Rows(i)("M_Code").ToString Then
                    MsgBox("成品出貨--產品編號要等於物料編碼！", MsgBoxStyle.Information, "提示")
                    CheckData = False
                    Exit Function
                End If
            End If

            If EditItem = "InCheck" Then
                '----------------收貨確認檢查----------------------------------------
                Dim piiGet As New List(Of ProductInventoryInfo)
                piiGet = pic.ProductInventory_GetList(ds.Tables("ProductionWareShipped").Rows(i)("PM_M_Code").ToString, ds.Tables("ProductionWareShipped").Rows(i)("M_Code").ToString, strWHOutID, Nothing)
                If piiGet.Count = 1 And CheckEdit3.Checked Then
                    If piiGet(0).PI_Qty < CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty")) Then
                        MsgBox("出貨倉庫存不足,無法收貨確認！", MsgBoxStyle.Information, "提示")
                        CheckData = False
                        Exit Function
                    End If
                End If
                '----------------取消收貨確認檢查------------------------------------
                Dim wicon As New WareInventoryMTController
                Dim wilist As List(Of WareInventoryInfo)
                wilist = wicon.WareInventory_GetList3(ds.Tables("ProductionWareShipped").Rows(i)("PM_M_Code").ToString, strWHInID, False)
                If wilist.Count = 1 And CheckEdit3.Checked = False Then
                    If wilist(0).WI_Qty < CInt(ds.Tables("ProductionWareShipped").Rows(i)("PWS_Qty")) Then
                        MsgBox("收貨倉庫存不足,無法取消收貨確認！", MsgBoxStyle.Information, "提示")
                        CheckData = False
                        Exit Function
                    End If
                End If
            End If

            '2013-10-23---------------------------------------------------------------------------------------------
            Dim strFac As String
            Dim fcon As New FacControler
            Dim flist As New List(Of FacInfo)
            flist = fcon.GetFacListA(Nothing, Nothing, strWHOutID)

            If flist.Count <= 0 Then
                Exit Function
            Else
                strFac = flist(0).FacID
            End If

            Dim strPM_M_Code As String
            Dim strM_Code As String
            Dim strgluType As String

            strPM_M_Code = ds.Tables("ProductionWareShipped").Rows(i)("PM_M_Code").ToString
            strM_Code = ds.Tables("ProductionWareShipped").Rows(i)("M_Code").ToString
            strgluType = ds.Tables("ProductionWareShipped").Rows(i)("PM_Type").ToString

            Dim pscA As New ProductionScheduleControl
            Dim psiA As New List(Of ProductionScheduleInfo)

            psiA = pscA.ProductionSchedule_GetList1(Nothing, cbType.EditValue, strPM_M_Code, strM_Code, strFac, Nothing, DateEdit1.EditValue, DateEdit1.EditValue, strgluType)
            If psiA.Count = 0 Then
                MsgBox("產品:" & strPM_M_Code & "  配件:" & strgluType & "在" & DateEdit1.EditValue & "無生產計，請添加生產計划!")
                CheckData = False
                Exit Function
            End If
            '----------------------------------------------------------------------------------------------



        Next

        '子表不能出現相同的產品
        With ds.Tables("ProductionWareShipped")
            If .Rows.Count > 1 Then
                For j = 0 To .Rows.Count - 1
                    For i = 0 To .Rows.Count - 1
                        If i <> j Then
                            If .Rows(i)("PM_M_Code") = .Rows(j)("PM_M_Code") And .Rows(i)("M_Code") = .Rows(j)("M_Code") And .Rows(i)("PM_Type") = .Rows(j)("PM_Type") Then
                                MsgBox("一張單中不能存在相同產品,同類型,同物料編碼的記錄!")
                                CheckData = False
                                Exit Function
                            End If
                        End If
                    Next
                Next
            End If
        End With

    End Function
#End Region

#Region "控件載入列表"
    Private Sub cboPM_Type_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPM_Type.Click
        Dim Get_LoadP_YN As Boolean
        If GridView1.RowCount > 0 Then
        Else
            Exit Sub
        End If
        Dim strA, strB, strC As String
        strA = ds.Tables("ProductionWareShipped").Rows((GridView1.FocusedRowHandle)).Item("PM_M_Code")
        strB = cbType.EditValue
        strC = ds.Tables("ProductionWareShipped").Rows((GridView1.FocusedRowHandle)).Item("M_Code")

        If EditID <> strA Or EditName <> strB Or EditM_Code <> strC Then
            EditID = strA
            EditName = strB
            EditM_Code = strC
            Get_LoadP_YN = True
        Else
            Get_LoadP_YN = False
        End If
        If Get_LoadP_YN = True Then
            LoadProductionType(strB, strA, strC)
        End If
    End Sub
    Function LoadProductionType(ByVal _Pro_Type As String, ByVal _PM_M_Code As String, ByVal _M_Code As String) As String
        LoadProductionType = ""
        Dim ppc As New ProcessMainControl
        Dim ppi As New List(Of ProcessMainInfo)
        cboPM_Type.Items.Clear()
        ppi = ppc.ProcessMain_GetList1(Nothing, _PM_M_Code, _Pro_Type, _M_Code)
        If ppi.Count > 0 Then
            Dim k As Integer
            For k = 0 To ppi.Count - 1
                cboPM_Type.Items.Add(ppi(k).Type3ID)
            Next
            LoadProductionType = ppi(0).Type3ID
        End If
    End Function
#End Region

#Region "自動流水號"
    '流水號
    Public Function GetNO() As String
        Dim pi As New ProductionWareShippedInfo
        Dim pc As New ProductionWareShippedControl
        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = pc.ProductionWareShipped_GetNo(strA)
        If pi Is Nothing Then
            GetNO = "PWS" & strA & "0001"
        Else
            GetNO = "PWS" + strA + Mid((CInt(Mid(pi.PWS_NO, 8)) + 10001), 2)
        End If
    End Function
    '流水號
    Private Function GetSubNO() As String
        Dim pi As New ProductionWareShippedInfo
        Dim pc As New ProductionWareShippedControl
        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = pc.ProductionWareShipped_GetSubNO(strA)
        If pi Is Nothing Then
            GetSubNO = "PSub" & strA & "0001"
        Else
            GetSubNO = "PSub" + strA + Mid((CInt(Mid(pi.PWS_SubNO, 9)) + 10001), 2)
        End If
    End Function
    '獲取最新項目號
    Public Function GetPSNO() As String
        Dim psi As New ProductionScheduleInfo
        Dim psc As New ProductionScheduleControl
        Dim strName As String
        strName = Format(Now, "yyMM")
        psi = psc.ProductionSchedule_GetNO(strName)
        If psi Is Nothing Then
            GetPSNO = "PS" + strName + "0001"
        Else
            GetPSNO = "PS" + strName + Mid((CInt(Mid(psi.PS_NO, 7)) + 10001), 2)
        End If

    End Function
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
#End Region



    Sub UpdateSchedule(ByVal WH_ID As String, ByVal cbType As String, ByVal PM_M_Code As String, ByVal M_Code As String, ByVal PM_Type As String, ByVal FDate As String, ByVal PWO_Qty As Int32)

        '根據倉庫得到生產部
        Dim strFac As String
        Dim fcon As New FacControler
        Dim flist As New List(Of FacInfo)
        flist = fcon.GetFacListA(Nothing, Nothing, WH_ID)

        If flist.Count <= 0 Then
            Exit Sub
        Else
            strFac = flist(0).FacID
        End If
        '--------------------------------------------------------------------
        Dim psi As New ProductionScheduleInfo
        Dim psc As New ProductionScheduleControl
        Dim psi1 As New List(Of ProductionScheduleInfo)

        psi1 = psc.ProductionSchedule_GetList1(Nothing, cbType, PM_M_Code, M_Code, strFac, Nothing, FDate, FDate, PM_Type)

        If psi1.Count = 0 Then
        Else
            Dim m As Double
            m = psi1(0).PS_ActualNumber

            psi.PS_NO = psi1(0).PS_NO '得到當前單號
            psi.Pro_Type = cbType
            psi.PM_M_Code = psi1(0).PM_M_Code
            psi.PM_Type = psi1(0).PM_Type
            psi.PS_Dep = strFac
            psi.PS_Date = Format(CDate(FDate), "yyyy-MM-dd")
            psi.PS_ActualNumber = m + PWO_Qty

            psc.ProductionSchedule_UpdateActualNumber(psi)
        End If

    End Sub

End Class