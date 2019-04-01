Imports LFERP.DataSetting
Imports LFERP.Library.Orders
Imports LFERP.Library.Product
Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library

Public Class frmPCPrintSelect

    Dim ds As New DataSet

    Private Sub frmPCPrintSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = Format(Now, "yyyy/MM/dd")
        DateEdit2.EditValue = Format(Now, "yyyy/MM/dd")
        CreateTable()
        LoadFacName()
        LoadCuster()
        gluCuster.EditValue = "*"
        OS_Fac.EditValue = "*"

    End Sub

    Sub LoadFacName()

        Dim fc As New FacControler
        Dim fi As List(Of FacInfo)
        Dim row1 As DataRow
        row1 = ds.Tables("Fac").NewRow
        row1("FacID") = "*"
        row1("FacName") = "全部"
        ds.Tables("Fac").Rows.Add(row1)
        fi = fc.GetFacList(Nothing, Nothing)
        If fi.Count = 0 Then
        Else
            Dim i As Integer
            For i = 0 To fi.Count - 1
                Dim row As DataRow
                row = ds.Tables("Fac").NewRow
                row("FacID") = fi(i).FacID
                row("FacName") = fi(i).FacName
                ds.Tables("Fac").Rows.Add(row)
            Next

        End If
    End Sub
    Sub CreateTable()
        ds.Tables.Clear()
        '創建數據表(客戶信息表)
        With ds.Tables.Add("Custer")
            .Columns.Add("C_CusterID", GetType(String))
            .Columns.Add("C_EngName", GetType(String))
            .Columns.Add("C_ChsName", GetType(String))
        End With
        gluCuster.Properties.DisplayMember = "C_CusterID"
        gluCuster.Properties.ValueMember = "C_CusterID"
        gluCuster.Properties.DataSource = ds.Tables("Custer")

        With ds.Tables.Add("Fac")
            .Columns.Add("FacID", GetType(String))
            .Columns.Add("FacName", GetType(String))
        End With
        OS_Fac.Properties.DisplayMember = "FacID"
        OS_Fac.Properties.ValueMember = "FacID"
        OS_Fac.Properties.DataSource = ds.Tables("Fac")

    End Sub

    Sub LoadCuster()
        Dim mtd As New CusterControler
        Dim cci As List(Of CusterInfo)
        Dim row1 As DataRow
        row1 = ds.Tables("Custer").NewRow
        row1("C_CusterID") = "*"
        row1("C_EngName") = "All"
        row1("C_ChsName") = "全部"
        ds.Tables("Custer").Rows.Add(row1)
        cci = mtd.GetCusterList(Nothing, Nothing, Nothing)
        If cci.Count = 0 Then
        Else
            Dim i As Integer
            For i = 0 To cci.Count - 1
                Dim row As DataRow
                row = ds.Tables("Custer").NewRow
                row("C_CusterID") = cci(i).C_CusterID
                row("C_EngName") = cci(i).C_EngName
                row("C_ChsName") = cci(i).C_ChsName
                ds.Tables("Custer").Rows.Add(row)
            Next
        
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            DateEdit1.Enabled = False
            DateEdit2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            DateEdit1.Enabled = True
            DateEdit2.Enabled = True
            DateEdit1.Focus()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim ds As New DataSet
        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet

        Dim mcProduct As New ProductController
        Dim osc As New OrdersSubController
        Dim omc As New OrdersMainController
        ds.Tables.Clear()

        If gluCuster.EditValue = "*" Then
            tempValue = Nothing
        Else
            tempValue = gluCuster.EditValue
        End If
        If OS_Fac.EditValue = "*" Then
            tempValue2 = Nothing
        Else
            tempValue2 = OS_Fac.EditValue
        End If

        If RadioButton1.Checked = True Then
            ltc.CollToDataSet(ds, "Prod_Main_New", mcProduct.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc1.CollToDataSet(ds, "OrdersSub", osc.OrdersSub_GetReportList(Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, tempValue, Nothing, Nothing, Nothing, Nothing, True, False))
            'ltc1.CollToDataSet(ds, "OrdersSub", osc.OrdersSub_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, tempValue, Nothing, Nothing))
            ltc2.CollToDataSet(ds, "OrdersMain", omc.OrdersMain_GetList(Nothing, tempValue, Nothing, Nothing, Nothing, Nothing))

        End If
        If RadioButton2.Checked = True Then
            ltc.CollToDataSet(ds, "Prod_Main_New", mcProduct.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc1.CollToDataSet(ds, "OrdersSub", osc.OrdersSub_GetReportList(Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, tempValue, Nothing, Nothing, DateEdit1.EditValue, DateEdit2.EditValue, True, False))
            'ltc1.CollToDataSet(ds, "OrdersSub", osc.OrdersSub_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, tempValue, Nothing, Nothing))
            ltc2.CollToDataSet(ds, "OrdersMain", omc.OrdersMain_GetList(Nothing, tempValue, Nothing, Nothing, Nothing, Nothing))
        End If
        PreviewRPT(ds, "rptBatchSchedule", " 交貨進度表", True, True)
        ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing
        Me.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class