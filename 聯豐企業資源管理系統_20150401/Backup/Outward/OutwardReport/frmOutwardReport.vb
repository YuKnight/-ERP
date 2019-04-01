Imports LFERP.Library.Outward
Imports LFERP.Library.Orders
Imports LFERP.DataSetting

Public Class frmOutwardReport

    Dim ds As New DataSet

    Private Sub frmOutwardReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '載入供應商資料,加工類型資料
        Label8.Text = tempValue3
        tempValue3 = ""
        If Label8.Text = "700501" Then
            '加工資料詳細查詢（外發加工記錄）
            Label1.Text = "外發加工記錄"

        ElseIf Label8.Text = "700502" Then
            '供應商送貨資料查詢（外發加工返回記錄）
            Label1.Text = "外發加工返回記錄"
            Label3.Text = "返回日期"
        ElseIf Label8.Text = "700503" Then
            '未交回資料查詢（未完成外發加工資料）
            Label1.Text = "未完成外發加工資料"

        End If
       
        CreateTable()
        LoadSupplier()
        LoadItemType()
        gluSupplier.EditValue = "*"
        gluType.EditValue = "*"
        DateEdit1.EditValue = Format(DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), "yyyy/MM/dd")
        DateEdit2.EditValue = Format(Now, "yyyy/MM/dd")
        'GB1.Left = Me.Width / 2 + GB1.Width / 2 - MDIMain.tvModule.Width - MDIMain.Splitter1.Width
        'GB2.Left = Me.Width / 2 + GB2.Width / 2 - MDIMain.tvModule.Width - MDIMain.Splitter1.Width
    End Sub

    Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("Supplier")  '供應商

            .Columns.Add("S_Supplier", GetType(String))
            .Columns.Add("S_SupplierName", GetType(String))

        End With
        gluSupplier.Properties.DisplayMember = "S_SupplierName"
        gluSupplier.Properties.ValueMember = "S_Supplier"
        gluSupplier.Properties.DataSource = ds.Tables("Supplier")

        With ds.Tables.Add("ItemType")  '加工類別

            .Columns.Add("OT_NO", GetType(String))
            .Columns.Add("OT_Name", GetType(String))

        End With
        gluType.Properties.DisplayMember = "OT_Name"
        gluType.Properties.ValueMember = "OT_NO"
        gluType.Properties.DataSource = ds.Tables("ItemType")
    End Sub

    Sub LoadSupplier()
        Dim si As List(Of SuppliersInfo)
        Dim sc As New SuppliersControler

        Dim row1 As DataRow
        row1 = ds.Tables("Supplier").NewRow
        row1("S_Supplier") = "*"
        row1("S_SupplierName") = "全部"
        ds.Tables("Supplier").Rows.Add(row1)

        si = sc.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")
        If si.Count = 0 Then
        Else
            Dim i As Integer
            For i = 0 To si.Count - 1
                Dim row As DataRow
                row = ds.Tables("Supplier").NewRow
                row("S_Supplier") = si(i).S_Supplier
                row("S_SupplierName") = si(i).S_SupplierName
                ds.Tables("Supplier").Rows.Add(row)
            Next
        End If
    End Sub

    Sub LoadItemType()
        Dim ti As List(Of OutwardInfo)
        Dim tc As New OutwardController

        Dim row1 As DataRow

        row1 = ds.Tables("ItemType").NewRow
        row1("OT_NO") = "*"
        row1("OT_Name") = "全部"
        ds.Tables("ItemType").Rows.Add(row1)

        ti = tc.OutwardType_GetList(Nothing, Nothing)
        If ti.Count = 0 Then
        Else
            Dim i As Integer
            For i = 0 To ti.Count - 1
                Dim row As DataRow
                row = ds.Tables("ItemType").NewRow
                row("OT_NO") = ti(i).OT_NO
                row("OT_Name") = ti(i).OT_Name
                ds.Tables("ItemType").Rows.Add(row)
            Next
        End If

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        On Error Resume Next
        Dim ds As New DataSet

        Dim strSupplier, strItemType, strDate1, strDate2 As String

        If gluSupplier.EditValue = "*" Then
            strSupplier = Nothing
        Else
            strSupplier = gluSupplier.EditValue
        End If

        If gluType.EditValue = "*" Then
            strItemType = Nothing
        Else
            strItemType = gluType.EditValue
        End If
        strDate1 = DateEdit1.EditValue
        strDate2 = DateEdit2.EditValue

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
        Dim ltc4 As New CollectionToDataSet

        Dim sfc As New OutwardController
        Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim mcSupplier As New LFERP.DataSetting.SuppliersControler
        Dim osc As New LFERP.Library.Orders.OrdersSubController
        Dim oac As New OutwardAcceptance.OutwardAcceptanceControl

        ds.Tables.Clear()

        If Label8.Text = "700501" Then

            ltc.CollToDataSet(ds, "OutwardMain", sfc.OutwardMain_GetList(Nothing, Nothing, strSupplier, strItemType, Nothing, strDate1, strDate2, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc3.CollToDataSet(ds, "OrdersSub", osc.OrdersSub_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

            PreviewRPT(ds, "rptOutwardDesign", "加工資料信息", True, True)

            ltc = Nothing
            ltc3 = Nothing

        ElseIf Label8.Text = "700502" Then
            ltc.CollToDataSet(ds, "OutwardMain", sfc.OutwardMain_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc3.CollToDataSet(ds, "OrdersSub", osc.OrdersSub_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc4.CollToDataSet(ds, "OutwardAcceptance", oac.OutwardAcceptance_GetList(Nothing, Nothing, Nothing, Nothing, strItemType, strDate1, strDate2, Nothing, Nothing, Nothing, Nothing, strSupplier))

            PreviewRPT(ds, "rptOutwardReturn", "加工返回資料信息", True, True)

            ltc = Nothing
            ltc3 = Nothing
            ltc4 = Nothing
        ElseIf Label8.Text = "700503" Then

            ltc.CollToDataSet(ds, "OutwardMain", sfc.OutwardMain_GetList(Nothing, Nothing, strSupplier, strItemType, Nothing, strDate1, strDate2, Nothing, Nothing, Nothing, Nothing, False))
            ltc3.CollToDataSet(ds, "OrdersSub", osc.OrdersSub_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

            PreviewRPT(ds, "rptOutwardNoComplete", "加工資料信息", True, True)

            ltc = Nothing
            ltc3 = Nothing
        End If
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

End Class