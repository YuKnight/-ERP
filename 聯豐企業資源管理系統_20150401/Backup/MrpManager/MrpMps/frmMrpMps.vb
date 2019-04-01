Imports LFERP.Library.MrpManager.MrpMps
Imports LFERP.Library.MrpManager.Bom_M
Imports LFERP.Library.MrpManager.MrpForecastOrder

Public Class frmMrpMps

#Region "字段屬性"
    Dim ds As New DataSet
    Dim mmc As New MrpMpsController
    Dim mmec As New MrpMpsEntryController
    Dim MrpCon As New MrpForecastOrderController
    Dim mbc As New Bom_MController
    Dim delAutoID As String = ""            '記錄產品明細表被刪除的AutoID
    Dim boCheck As Boolean = False          '用來判斷審核狀態是否有改變
    Private _EditItem As String
    Private _MO As String

    Property EditItem() As String '屬性
        Get
            Return _EditItem
        End Get
        Set(ByVal value As String)
            _EditItem = value
        End Set
    End Property

    Property MO() As String '屬性
        Get
            Return _MO
        End Get
        Set(ByVal value As String)
            _MO = value
        End Set
    End Property

#End Region

#Region "創建臨時表"
    Sub CreateTables()
        ds.Tables.Clear()
        With ds.Tables.Add("MrpMps")
            .Columns.Add("AutoID", GetType(Decimal))
            .Columns.Add("MO", GetType(String))
            .Columns.Add("PlanQty", GetType(Decimal))
            .Columns.Add("ProducedQty", GetType(Decimal))
            .Columns.Add("NeedDate", GetType(Date))
            .Columns.Add("WeeksNumber", GetType(Int32))
            .Columns.Add("TimeSpan", GetType(String))
            .Columns.Add("Remarks", GetType(String))
        End With
        Grid1.DataSource = ds.Tables("MrpMps")
    End Sub
#End Region

#Region "填充臨時表"
    Sub FillTable(ByVal mmeList As List(Of MrpMpsEntryInfo))
        Try
            Dim row As DataRow
            Dim i As Integer
            For i = 0 To mmeList.Count - 1
                row = ds.Tables("MrpMps").NewRow
                row("AutoID") = mmeList(i).AutoID
                row("MO") = mmeList(i).MO
                row("PlanQty") = mmeList(i).PlanQty
                row("ProducedQty") = mmeList(i).ProducedQty
                row("NeedDate") = mmeList(i).NeedDate
                row("WeeksNumber") = mmeList(i).WeeksNumber
                row("TimeSpan") = mmeList(i).TimeSpan
                row("Remarks") = mmeList(i).Remarks
                ds.Tables("MrpMps").Rows.Add(row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "FillTable方法出錯")
        End Try
    End Sub
#End Region

#Region "窗體加載事件"
    Private Sub frmMrpMps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If EditItem = EditEnumType.ADD Then
            'gluM_Code.Properties.DataSource = mbc.Bom_M_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing)
        Else
            'gluM_Code.Properties.DataSource = mbc.Bom_M_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        End If

        gluCusterID.Properties.DataSource = MrpCon.CusterGetName(Nothing, Nothing)
        CreateTables()
        Select Case EditItem
            Case EditEnumType.ADD
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.ADD)
                Me.Text = lblTitle.Text
                txtMO.EditValue = "自動編號"
                SetControlEnable(True, False)
            Case EditEnumType.EDIT
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.EDIT)
                Me.Text = lblTitle.Text
                SetControlEnable(True, False)
                LoadData(MO)
            Case EditEnumType.VIEW
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.VIEW)
                Me.Text = lblTitle.Text
                SetControlEnable(False, False)
                LoadData(MO)
            Case EditEnumType.CHECK
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.CHECK)
                Me.Text = lblTitle.Text
                SetControlEnable(False, True)
                LoadData(MO)
                XtraTabControl1.SelectedTabPage = xtpCheck
        End Select
    End Sub
#End Region

#Region "設置各控件的Enable屬性"
    Private Sub SetControlEnable(ByVal a As Boolean, ByVal b As Boolean)
        gluM_Code.Enabled = a
        gluCusterID.Enabled = a
        xtpCheck.PageVisible = Not a
        chkCheck.Enabled = b
        txtCheckRemark.Enabled = b
        lblCheckUser.Visible = Not a
        lblCheckDate.Visible = Not a
        View1.OptionsBehavior.Editable = a
        btnSave.Enabled = a Or b

        If a = False Then
            Grid1.ContextMenuStrip = Nothing
        End If
    End Sub
#End Region

#Region "加載數據"
    Private Sub LoadData(ByVal MO As String)
        Dim objInfo As List(Of MrpMpsInfo)
        objInfo = mmc.MrpMps_GetList(MO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If objInfo Is Nothing Then
            Exit Sub
        End If
        txtMO.EditValue = MO
        txtProductionQty.EditValue = objInfo(0).ProductionQty
        gluCusterID.EditValue = objInfo(0).CusterID
        txtCusterName.EditValue = objInfo(0).CusterName
        gluM_Code.EditValue = objInfo(0).M_Code
        txtM_Name.EditValue = objInfo(0).M_Name
        txtM_Unit.EditValue = objInfo(0).M_Unit
        txtM_Gauge.EditValue = objInfo(0).M_Gauge
        txtM_Source.EditValue = objInfo(0).M_Source
        boCheck = objInfo(0).CheckBit

        If objInfo(0).CheckBit = True Then
            chkCheck.Checked = True
            lblCheckUser.Text += objInfo(0).CheckUserName
            lblCheckDate.Text += IIf(objInfo(0).CheckDate = Nothing, "", Format(CDate(objInfo(0).CheckDate), "yyyy/MM/dd"))
            txtCheckRemark.EditValue = objInfo(0).CheckRemarks
        ElseIf EditItem = EditEnumType.CHECK Then
            lblCheckUser.Text += InUser
            lblCheckDate.Text += Format(Now, "yyyy/MM/dd")
        End If

        FillTable(mmec.MrpMpsEntry_GetList(MO))
    End Sub
#End Region

#Region "選擇產品編碼時帶出產品名稱等信息"
    Private Sub gluM_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluM_Code.EditValueChanged, gluCusterID.EditValueChanged
        If sender.name = "gluM_Code" And gluM_Code.EditValue <> Nothing Then
            txtM_Name.EditValue = viewMaterial.GetFocusedRowCellValue("M_Name")
            txtM_Gauge.EditValue = viewMaterial.GetFocusedRowCellValue("M_Gauge")
            txtM_Unit.EditValue = viewMaterial.GetFocusedRowCellValue("M_Unit")
            txtM_Source.EditValue = viewMaterial.GetFocusedRowCellValue("M_Source")
        ElseIf sender.name = "gluCusterID" And gluCusterID.EditValue <> Nothing Then
            txtCusterName.EditValue = viewCuster.GetFocusedRowCellValue("MO_CusterName")
        End If
    End Sub
#End Region

#Region "保存前檢查輸入數據是否正確"
    Private Function CheckSave() As Boolean
        Try
            CheckSave = True
            If gluCusterID.EditValue = Nothing Then
                MsgBox("請選擇客戶", MsgBoxStyle.Information, "提示")
                CheckSave = False
                Exit Function
            End If
            If gluM_Code.EditValue = Nothing Then
                MsgBox("請選擇產品編號", MsgBoxStyle.Information, "提示")
                CheckSave = False
                Exit Function
            End If
            If EditItem = EditEnumType.CHECK And chkCheck.Checked = boCheck Then
                MsgBox("審核狀態沒有改變,無法保存", MsgBoxStyle.Information, "提示")
                CheckSave = False
                Exit Function
            End If
            If ds.Tables("MrpMps").Rows.Count < 1 Then
                MsgBox("需求明細中不存在數據行,無法保存", MsgBoxStyle.Information, "提示")
                CheckSave = False
                Exit Function
            End If
            For i As Int16 = 0 To ds.Tables("MrpMps").Rows.Count - 1
                If IsDBNull(ds.Tables("MrpMps").Rows(i)("PlanQty")) Or IsDBNull(ds.Tables("MrpMps").Rows(i)("NeedDate")) Then
                    View1.FocusedRowHandle = i
                    MsgBox("無法保存，計劃生成數量和生產日期都不能為空", MsgBoxStyle.Information, "提示")
                    CheckSave = False
                    Exit Function
                End If
            Next
            Dim intYear, intWeekNum As Int16
            For i As Int16 = 0 To ds.Tables("MrpMps").Rows.Count - 1
                intYear = Year(ds.Tables("MrpMps").Rows(i)("NeedDate"))
                intWeekNum = ds.Tables("MrpMps").Rows(i)("WeeksNumber")
                For j As Int16 = i + 1 To ds.Tables("MrpMps").Rows.Count - 1
                    If intYear = Year(ds.Tables("MrpMps").Rows(j)("NeedDate")) And intWeekNum = ds.Tables("MrpMps").Rows(j)("WeeksNumber") Then
                        MsgBox(intYear.ToString + "年第" + intWeekNum.ToString + "周存在重復，無法保存", MsgBoxStyle.Information, "提示")
                        View1.FocusedRowHandle = i
                        CheckSave = False
                        Exit Function
                    End If
                Next

            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "提示")
        End Try

    End Function
#End Region

#Region "保存、退出事件"
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If (CheckSave() = False) Then
            Exit Sub
        End If
        Select Case EditItem
            Case EditEnumType.ADD
                SaveData()
            Case EditEnumType.EDIT
                SaveData()
            Case EditEnumType.CHECK
                Dim mmi As New MrpMpsInfo
                mmi.MO = txtMO.EditValue
                mmi.CheckBit = chkCheck.Checked
                mmi.CheckUserID = InUserID
                mmi.CheckRemarks = txtCheckRemark.Text
                If mmc.MrpMps_UpdateCheck(mmi) = True Then
                    If chkCheck.Checked = True Then
                        MsgBox("審核成功", MsgBoxStyle.Information, "提示")
                    Else
                        MsgBox("取消審核成功", MsgBoxStyle.Information, "提示")
                    End If
                Else
                    MsgBox("保存失敗", MsgBoxStyle.Information, "提示")
                End If
                Me.Close()
        End Select
    End Sub

#Region "保存數據"
    Private Sub SaveData()
        Dim ProductionQty As Decimal = 0
        Try
            If EditItem = EditEnumType.ADD Then
                txtMO.EditValue = mmc.MrpMps_GetID()
            ElseIf EditItem = EditEnumType.EDIT Then
                If String.IsNullOrEmpty(delAutoID) = False Then
                    Dim array1 As String()
                    array1 = delAutoID.Split(",")
                    For x As Int16 = 0 To array1.Length - 2
                        mmec.MrpMpsEntry_Delete(array1(x), Nothing)
                    Next
                End If
            End If
            If ds.Tables("MrpMps").Rows.Count > 0 Then
                Dim mmei As New MrpMpsEntryInfo
                Dim i As Integer
                For i = 0 To ds.Tables("MrpMps").Rows.Count - 1
                    ProductionQty += CDec(ds.Tables("MrpMps").Rows(i)("PlanQty"))
                    mmei.MO = txtMO.EditValue
                    mmei.AutoID = ds.Tables("MrpMps").Rows(i)("AutoID").ToString
                    mmei.PlanQty = ds.Tables("MrpMps").Rows(i)("PlanQty")
                    mmei.NeedDate = Format(CDate(ds.Tables("MrpMps").Rows(i)("NeedDate")), "yyyy/MM/dd")
                    mmei.ProducedQty = ds.Tables("MrpMps").Rows(i)("ProducedQty")
                    mmei.WeeksNumber = ds.Tables("MrpMps").Rows(i)("WeeksNumber")
                    mmei.TimeSpan = ds.Tables("MrpMps").Rows(i)("TimeSpan")
                    mmei.Remarks = ds.Tables("MrpMps").Rows(i)("Remarks").ToString
                    If EditItem = EditEnumType.ADD Then                 '增加
                        mmei.CreateUserID = InUserID
                        mmec.MrpMpsEntry_Add(mmei)
                    ElseIf EditItem = EditEnumType.EDIT Then                        '修改
                        mmei.ModifyUserID = InUserID
                        If mmei.AutoID = 0 Then
                            If mmec.MrpMpsEntry_Add(mmei) = False Then
                                MsgBox("部分保存失敗")
                            End If
                        Else
                            If mmec.MrpMpsEntry_Update(mmei) = False Then
                                MsgBox("部分保存失敗")
                            End If
                        End If
                    End If
                Next
            End If
            Dim mmi As New MrpMpsInfo
            mmi.CusterID = gluCusterID.EditValue
            mmi.M_Code = gluM_Code.EditValue
            mmi.CreateUserID = InUserID
            mmi.ModifyUserID = InUserID
            mmi.ProductionQty = ProductionQty
            mmi.MO = txtMO.EditValue
            If EditItem = EditEnumType.ADD Then
                If mmc.MrpMps_Add(mmi) = True Then
                    MsgBox("添加成功", MsgBoxStyle.Information, "提示")
                Else
                    MsgBox("添加失敗", MsgBoxStyle.Information, "提示")
                End If
            ElseIf EditItem = EditEnumType.EDIT Then
                If mmc.MrpMps_Update(mmi) = True Then
                    MsgBox("修改成功", MsgBoxStyle.Information, "提示")
                Else
                    MsgBox("修改失敗", MsgBoxStyle.Information, "提示")
                End If
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SaveData方法出錯")
        End Try
    End Sub
#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
#End Region

#Region "右擊菜單事件"
    Private Sub cms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsMpsAdd.Click, cmsMpsDel.Click
        Select Case sender.Name
            Case "cmsMpsAdd"
                Dim row As DataRow
                row = ds.Tables("MrpMps").NewRow
                row("ProducedQty") = 0
                row("AutoID") = 0
                ds.Tables("MrpMps").Rows.Add(row)
                View1.FocusedRowHandle = View1.RowCount - 1
            Case "cmsMpsDel"
                If (View1.GetFocusedRowCellValue("AutoID").ToString <> "0") Then
                    delAutoID += View1.GetFocusedRowCellValue("AutoID").ToString + ","
                End If
                ds.Tables("MrpMps").Rows.RemoveAt(View1.FocusedRowHandle)
                SetRightMenuEnable()
        End Select
    End Sub

    Private Sub grid_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid1.MouseDown
        If e.Button() = Windows.Forms.MouseButtons.Right Then
            SetRightMenuEnable()
        End If
    End Sub
    Private Sub SetRightMenuEnable()
        If View1.RowCount < 1 Then
            cmsMps.Items("cmsMpsDel").Enabled = False
        Else
            cmsMps.Items("cmsMpsDel").Enabled = True
        End If
    End Sub

    Private Sub cmsMpsBatchAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsMpsBatchAdd.Click
        Try
            Dim batchAddQty As Int16
            Dim beginDate As Date
            Dim planQty As Integer  '計劃生產數量
            Dim bFlag As Boolean = False  '用來標記每年最后一同是否跨年
            Dim fr As New frmMrpMpsBatchAdd
            fr.PlanQty = IIf(IsDBNull(View1.GetFocusedRowCellValue("PlanQty")), 0, View1.GetFocusedRowCellValue("PlanQty"))
            fr.BeginDate = IIf(IsDBNull(View1.GetFocusedRowCellValue("NeedDate")), Nothing, View1.GetFocusedRowCellValue("NeedDate"))
            fr.ShowDialog()
            beginDate = fr.BeginDate
            planQty = fr.PlanQty
            batchAddQty = fr.BatchAddQty

            For i As Int16 = 0 To batchAddQty - 1
                'If IsDBNull(View1.GetFocusedRowCellValue("NeedDate")) = False Then
                '    Continue For
                'End If
                Dim row As DataRow = ds.Tables("MrpMps").NewRow
                beginDate = GetNextWeekDate(beginDate, bFlag)
                row("AutoID") = 0
                row("ProducedQty") = 0
                If bFlag = True Then
                    bFlag = False
                    row("PlanQty") = CInt(planQty * DatePart(DateInterval.Weekday, beginDate) / 7)
                    row("NeedDate") = beginDate
                    row("WeeksNumber") = DatePart(DateInterval.WeekOfYear, beginDate)
                    row("TimeSpan") = GetTimeSpan(beginDate)
                    ds.Tables("MrpMps").Rows.Add(row)
                    Dim row1 As DataRow = ds.Tables("MrpMps").NewRow
                    row1("AutoID") = 0
                    row1("PlanQty") = planQty - row("PlanQty")
                    row1("ProducedQty") = 0
                    row1("NeedDate") = (Year(beginDate) + 1).ToString + "/01/01"
                    row1("WeeksNumber") = DatePart(DateInterval.WeekOfYear, row1("NeedDate"))
                    row1("TimeSpan") = GetTimeSpan(row1("NeedDate"))
                    ds.Tables("MrpMps").Rows.Add(row1)
                Else
                    row("PlanQty") = planQty
                    row("NeedDate") = beginDate
                    row("WeeksNumber") = DatePart(DateInterval.WeekOfYear, beginDate)
                    row("TimeSpan") = GetTimeSpan(beginDate)
                    ds.Tables("MrpMps").Rows.Add(row)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "提示")
        End Try
    End Sub

#Region "取得給定日期的下個星期的日期"
    Private Function GetNextWeekDate(ByVal paraDate As Date, ByRef bFlag As Boolean) As Date
        Dim nextWeekDate As Date = paraDate.AddDays(8 - DatePart(DateInterval.Weekday, paraDate))
        Dim i As Int16 = DatePart(DateInterval.Weekday, nextWeekDate) - 1
        Dim lastDayOfWeek As Date = nextWeekDate.AddDays(6 - i)

        If lastDayOfWeek.Date.Year <> Year(nextWeekDate) Then
            paraDate = CDate(Year(nextWeekDate).ToString + ".12.31")
            bFlag = True
        Else
            paraDate = paraDate.AddDays(7)
        End If
        Return paraDate
    End Function
#End Region
#End Region

    Private Sub ItemdteNeedDate_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles ItemdteNeedDate.EditValueChanging
        Try
            Dim needDate As Date = CDate(e.NewValue)
            View1.SetFocusedRowCellValue(WeeksNumber, DatePart(DateInterval.WeekOfYear, needDate))
            View1.SetFocusedRowCellValue(TimeSpan, GetTimeSpan(needDate))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#Region "取得指定日期的星期所包含的日期段"
    Private Function GetTimeSpan(ByRef paraDate As Date) As String
        Dim i As Int16
        i = DatePart(DateInterval.Weekday, paraDate) - 1
        Dim firstDayOfWeek, lastDayOfWeek As String
        If Year(paraDate) <> Year(paraDate.AddDays(-i)) Then
            firstDayOfWeek = Year(paraDate).ToString + ".01.01"
            paraDate = CDate(Year(paraDate).ToString + ".01.01")
        Else
            firstDayOfWeek = Format(paraDate.AddDays(-i), "yyyy.MM.dd")
        End If

        If Year(paraDate) <> Year(paraDate.AddDays(6 - i)) Then
            lastDayOfWeek = Year(paraDate).ToString + ".12.31"
            paraDate = CDate(Year(paraDate).ToString + ".12.31")
        Else
            lastDayOfWeek = Format(paraDate.AddDays(6 - i), "yyyy.MM.dd")
        End If

        Return firstDayOfWeek + "-" + lastDayOfWeek
    End Function
#End Region

#Region "數據值驗證"
    Private Sub RepositoryItemCalcEdit1_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles RepositoryItemCalcEdit1.EditValueChanging
        If (CDec(e.NewValue) > 999999999 Or CDec(e.NewValue) < 0) Then
            e.Cancel = True
        End If
        If View1.FocusedColumn.FieldName = "PlanQty" Then
            View1.SetFocusedRowCellValue(PlanQty, e.NewValue)
        End If
        Dim qty As Decimal = 0
        Try
            For i As Int16 = 0 To View1.DataRowCount - 1
                qty += Convert.ToDecimal(IIf(IsDBNull(View1.GetDataRow(i)("PlanQty")), 0, View1.GetDataRow(i)("PlanQty")))
            Next
            txtProductionQty.EditValue = qty
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

End Class