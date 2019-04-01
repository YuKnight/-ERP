Imports DevExpress.XtraGrid.Views.BandedGrid
Imports LFERP.Library.MrpManager.MrpMps
Imports LFERP.Library.MrpManager.Bom_M
Imports LFERP.Library.MrpManager.MrpSetting

Public Class frmMrpMpsBrowse
    Dim mmc As New MrpMpsController
    Dim bc As New Bom_MController
    Dim msc As New MrpSettingController

    Private Sub frmMrpMpsBrowse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bi As New Bom_MInfo
        Dim biList As New List(Of Bom_MInfo)
        bi.ParentGroup = "ALL"
        bi.M_Name = "全部"
        'biList = bc.Bom_M_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        biList.Insert(0, bi)
        gluM_Code.Properties.DataSource = biList

        Dim msiList As List(Of MrpSettingInfo)
        msiList = msc.MrpSetting_GetList(InUserID)
        If msiList.Count > 0 Then
            dteBeginDate.EditValue = msiList(0).mrpMpsBrowserBeginDate
            dteEndDate.EditValue = msiList(0).mrpMpsBrowserEndDate
        Else
            dteBeginDate.EditValue = CDate(Now.Year.ToString + "/01/01")
            dteEndDate.EditValue = CDate(Now.Year.ToString + "/12/31")
        End If

    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim GroupType As String = String.Empty
        Dim M_Code As String = String.Empty
        Dim CusterFlag As Boolean = False
        If CDate(dteBeginDate.EditValue).CompareTo(CDate(dteEndDate.EditValue)) > 0 Then
            MsgBox("開始日期不能晚于結束日期", MsgBoxStyle.Information, "提示")
            Exit Sub
        End If
        GroupType = IIf(cboGroupType.SelectedIndex = 0 Or cboGroupType.SelectedIndex = 2, "week", "month")
        CusterFlag = IIf(cboGroupType.SelectedIndex = 2 Or cboGroupType.SelectedIndex = 3, True, False)
        M_Code = IIf(gluM_Code.EditValue = "ALL", Nothing, gluM_Code.EditValue.ToString)
        Dim dt As DataTable = mmc.MrpMps_GetGroupList(CDate(dteBeginDate.EditValue), CDate(dteEndDate.EditValue), GroupType, M_Code, CusterFlag)
        LoadBandedGrid(dt, BandedView1, GroupType, CusterFlag)
    End Sub

    Private Sub LoadBandedGrid(ByVal dt As DataTable, ByVal BandedView As BandedGridView, ByVal GroupType As String, ByVal CusterFlag As Boolean)
        BandedView.Bands.Clear()      '清空BandedGridView 
        BandedView.Columns.Clear()
        BandedView.OptionsBehavior.Editable = False
        Dim strYear As String = String.Empty     '加載年份的band時保存前一個band的顯示文字
        If dt Is Nothing Then
            Exit Sub
        End If
        Try
            BandedView.Bands.AddBand("產品信息").Name = "ProductionInfo"
            BandedView.Bands("ProductionInfo").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Grid1.DataSource = dt

            BandedView.Bands.AddBand("客戶信息").Name = "CusterInfo"
            BandedView.Bands("CusterInfo").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left

            For Each dc As DataColumn In dt.Columns
                If dc.DataType Is GetType(String) Then
                    If dc.ColumnName.StartsWith("Custer") Then
                        BandedView.Bands("CusterInfo").Columns.Add(BandedView.Columns(dc.ColumnName))
                        BandedView.Bands("CusterInfo").Visible = CusterFlag
                    Else
                        BandedView.Bands("ProductionInfo").Columns.Add(BandedView.Columns(dc.ColumnName))
                    End If
                End If
                If Int32.TryParse(dc.ColumnName, 1) = True Then
                    If dc.ColumnName.Remove(4) <> strYear Then
                        BandedView.Bands.AddBand(dc.ColumnName.Remove(4) + "年").Name = dc.ColumnName.Remove(4)
                        BandedView.Bands(dc.ColumnName.Remove(4)).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    End If
                    If GroupType = "week" Then
                        BandedView.Bands(dc.ColumnName.Remove(4)).Children.AddBand(GetWeekRange(dc.ColumnName)).Name = GetWeekRange(dc.ColumnName)
                        BandedView.Bands(dc.ColumnName.Remove(4)).Children(GetWeekRange(dc.ColumnName)).Columns.Add(BandedView.Columns(dc.ColumnName))
                        BandedView.Bands(dc.ColumnName.Remove(4)).Children(GetWeekRange(dc.ColumnName)).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                        BandedView.Columns(dc.ColumnName).Caption = (dc.ColumnName + "周").Insert(4, "年")
                    Else
                        BandedView.Bands(dc.ColumnName.Remove(4)).Children.AddBand(dc.ColumnName.Remove(0, 4) + "月").Name = dc.ColumnName.Remove(0, 4)
                        BandedView.Bands(dc.ColumnName.Remove(4)).Children(dc.ColumnName.Remove(0, 4)).Columns.Add(BandedView.Columns(dc.ColumnName))
                        BandedView.Bands(dc.ColumnName.Remove(4)).Children(dc.ColumnName.Remove(0, 4)).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                        BandedView.Columns(dc.ColumnName).Caption = (dc.ColumnName + "月").Insert(4, "年")
                    End If
                    BandedView.Columns(dc.ColumnName).Width = 90
                    strYear = dc.ColumnName.Remove(4)   '保存年份
                End If
                If dc.DataType Is GetType(Decimal) Then
                    BandedView.Columns(dc.ColumnName).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    BandedView.Columns(dc.ColumnName).DisplayFormat.FormatString = " {0:N0}"
                End If
            Next
            BandedView.Bands.AddBand("總計").Name = "PlanQtySum"
            BandedView.Bands("PlanQtySum").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
            BandedView.Bands("PlanQtySum").Columns.Add(BandedView.Columns("PlanQtySum"))
            BandedView.Columns("PlanQtySum").Width = 95

            SetBandedViewStyle(BandedView)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "提示")
        End Try

    End Sub

#Region "輸入年周返回指定周數的日期范圍"
    Private Function GetWeekRange(ByVal yearWeek As String) As String
        Dim firstDayOfYear As Date = CDate(yearWeek.Remove(4) + ".01.01")
        Dim endDayofYear As Date = CDate(yearWeek.Remove(4) + ".12.31")
        Dim week As Int16 = CInt(yearWeek.Remove(0, 4))
        Dim sencondWeekBeginDate As Date          '指定年的第二周的開始日期

        Dim i As Int16 = Microsoft.VisualBasic.DatePart(DateInterval.Weekday, firstDayOfYear) - 1
        sencondWeekBeginDate = firstDayOfYear.AddDays(6 - i + 1)
        Dim beginDayOfWeek As Date = sencondWeekBeginDate.AddDays((week - 2) * 7)
        Dim endDayofWeek As Date = beginDayOfWeek.AddDays(6)
        If endDayofWeek > endDayofYear Then
            endDayofWeek = endDayofYear
        End If
        Return Format(beginDayOfWeek, "MM.dd") + "-" + Format(endDayofWeek, "MM.dd")
    End Function
#End Region

#Region "設置BandedView的樣式"
    Private Sub SetBandedViewStyle(ByVal BandedView As BandedGridView)
        BandedView.Bands("ProductionInfo").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        BandedView.Bands("PlanQtySum").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        BandedView.Columns("M_Code").Caption = "產品編碼"
        BandedView.Columns("M_Code").Width = 135
        BandedView.Columns("M_Gauge").Caption = "產品規格"
        BandedView.Columns("M_Gauge").Width = 170
        BandedView.Columns("M_Name").Caption = "產品名稱"
        BandedView.Columns("M_Name").Width = 135
        BandedView.Columns("M_Unit").Caption = "單位"
        BandedView.Columns("M_Unit").Width = 45
        BandedView.Columns("M_Source").Caption = "來源碼"
        BandedView.Columns("M_Source").Width = 60

        BandedView.Columns("CusterID").Caption = "客戶編號"
        BandedView.Columns("CusterID").Width = 70
        BandedView.Columns("CusterName").Caption = "客戶名稱"
        BandedView.Columns("CusterName").Width = 80

        BandedView.Columns("PlanQtySum").Caption = "數量"
        BandedView.Columns("PlanQtySum").Width = 50

        Dim ItemMemoex As New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        ItemMemoex.ShowIcon = False
        BandedView.Columns("M_Gauge").ColumnEdit = ItemMemoex
    End Sub
#End Region

#Region "導出Excel"
    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        If BandedView1.RowCount < 1 Then
            MsgBox("沒有可導出的數據", MsgBoxStyle.Information, "提示")
            Exit Sub
        End If
        Dim sfd As New SaveFileDialog
        sfd.DefaultExt = ".xls"
        sfd.Filter = "Excel Files|*.xls|All Files|*.*"
        If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Grid1.ExportToXls(sfd.FileName)
            MsgBox("已成功導出", MsgBoxStyle.Information, "提示")
        End If
    End Sub
#End Region

End Class