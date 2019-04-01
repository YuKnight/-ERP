Imports LFERP.Library.Orders
Imports LFERP.Library.Positive
Imports LFERP.Library.Product
Imports LFERP.DataSetting



Public Class frmPositiveOrdersPrint

    Private dsOrders As New DataSet


    Private m_PoCtrl As New PositiveOrdersController

    Private m_PsListInfo As New List(Of PositiveOrdersInfo)


    Private Sub CreateTablesMain()
        dsOrders.Tables.Clear()
        With dsOrders.Tables.Add("OM_Custer")
            .Columns.Add("OM_CusterID", GetType(String))
        End With
        custeridEdit.Properties.DataSource = dsOrders.Tables("OM_Custer")
        custeridEdit.Properties.DisplayMember = "OM_CusterID"
        custeridEdit.Properties.ValueMember = "OM_CusterID"
        LoadDataMain()

        With dsOrders.Tables.Add("PMCode")
            .Columns.Add("PM_M_Code", GetType(String))
        End With
        gluPM_M_Code.Properties.DataSource = dsOrders.Tables("PMCode")
        gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        gluPM_M_Code.Properties.ValueMember = "PM_M_Code"
        LoadPMcodeMain()

    End Sub

    Private Sub LoadPMcodeMain()
        Dim mc As New ProductController
        Dim mcInfo As New List(Of ProductInfo)
        mcInfo = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If mcInfo.Count = 0 Then
            Exit Sub
        End If

        Dim i As Integer = 0

        Dim row As DataRow
        row = dsOrders.Tables("PMCode").NewRow
        row("PM_M_Code") = "全部"
        dsOrders.Tables("PMCode").Rows.Add(row)
        '--------------------------------------

        For i = 0 To mcInfo.Count - 1
            row = dsOrders.Tables("PMCode").NewRow
            row("PM_M_Code") = mcInfo(i).PM_M_Code
            dsOrders.Tables("PMCode").Rows.Add(row)
        Next

    End Sub

    Private Sub LoadDataMain()
        Dim cusCtrl As New CusterControler
        Dim cusInfo As New List(Of CusterInfo)
        'Dim oc As New OrdersMainController
        'Dim ci As New List(Of OrdersMainInfo)

        cusInfo = cusCtrl.GetCusterList(Nothing, Nothing, Nothing)

        If cusInfo.Count = 0 Then
            Exit Sub
        End If
        Dim i As Integer = 0

        Dim row As DataRow
        row = dsOrders.Tables("OM_Custer").NewRow
        row("OM_CusterID") = "全部"
        dsOrders.Tables("OM_Custer").Rows.Add(row)
        '--------------------------------------

        For i = 0 To cusInfo.Count - 1
            row = dsOrders.Tables("OM_Custer").NewRow
            row("OM_CusterID") = cusInfo(i).C_CusterID
            dsOrders.Tables("OM_Custer").Rows.Add(row)
        Next

    End Sub

    Private Sub frmPositiveOrdersPrint_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CreateTablesMain()

        dtStart.EditValue = Format(Now, "yyyy/MM/" & "01")
        dtEnd.EditValue = Format(Now, "yyyy/MM/dd")

        custeridEdit.EditValue = "全部"
        gluPM_M_Code.EditValue = "全部"
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim custerid, pmCode, poDateStart, poDateEnd, sendDateStart, sendDateEnd As String
        Dim dsOrderPrint As New DataSet
        Dim ltc As New CollectionToDataSet


        custerid = Nothing
        pmCode = Nothing
        poDateStart = Nothing
        poDateEnd = Nothing
        sendDateStart = Nothing
        sendDateEnd = Nothing

        If dtStart.Text <> "" Or dtEnd.Text <> "" Then
            If orderEdit.Checked = False And sendEdit.Checked = False Then
                MsgBox("請選擇日期類型!")
                Exit Sub
            End If
        End If

        If CDate(dtStart.Text) > CDate(dtEnd.Text) Then
            MsgBox("起始日期不能大於截至日期", 64, "提示")
            Exit Sub
        End If

        If custeridEdit.EditValue <> "全部" Then
            custerid = custeridEdit.EditValue
        End If

        If gluPM_M_Code.EditValue <> "全部" Then
            pmCode = gluPM_M_Code.EditValue
        End If

        If orderEdit.Checked = True Then
            poDateStart = IIf(dtStart.Text = "", Nothing, dtStart.Text)
            poDateEnd = IIf(dtEnd.Text = "", Nothing, dtEnd.Text)

        End If

        If sendEdit.Checked = True Then
            sendDateStart = IIf(dtStart.Text = "", Nothing, dtStart.Text)
            sendDateEnd = IIf(dtEnd.Text = "", Nothing, dtEnd.Text)
        End If

        '  m_PsListInfo = m_PoCtrl.PositiveOrders_GetList(Nothing, Nothing, custerid, pmCode, Nothing, poDateStart, poDateEnd, Nothing, sendDateStart, sendDateEnd)

        If m_PsListInfo.Count <= 0 Then
            MsgBox("沒有符合要求的數據！", 64, "提示")
            Exit Sub
        End If

        ltc.CollToDataSet(dsOrderPrint, "PositiveOrders", m_PsListInfo)
        PreviewRPTDialog(dsOrderPrint, "rptPositiveOrders", "陽極訂單訂單", True, True)

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class