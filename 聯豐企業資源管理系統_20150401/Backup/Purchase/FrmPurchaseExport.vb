Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core
Imports LFERP.FileManager
Imports LFERP.Library.Purchase
Imports LFERP.SystemManager

Public Class FrmPurchaseExport
    Dim tempSTR As String, tempA As String

    Private Sub FrmPurchaseExport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '"采購管理--物料採購"
        tempSTR = tempValue2
        tempValue2 = ""
        DateEdit1.EditValue = Now
        DateEdit2.EditValue = Now
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckBox1.Checked Then
            If DateEdit1.Text = "" Or DateEdit2.Text = "" Then
                MsgBox("日期不能為空!")
                Exit Sub
            End If
            tempValue2 = DateEdit1.Text
            tempValue3 = DateEdit2.Text
            Me.Close()
        End If

    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            DateEdit1.Enabled = True
            DateEdit2.Enabled = True
            DateEdit1.Focus()
        Else
            DateEdit1.Enabled = False
            DateEdit2.Enabled = False
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim ds As New DataSet
        Dim ctd As New CollectionToDataSet
        Dim Pmc As New Purchase.PurchaseMainController
        ds.Tables.Clear()
        If CheckBox1.Checked Then
            If DateEdit1.Text = "" Or DateEdit2.Text = "" Then
                MsgBox("日期不能為空!")
                Exit Sub
            End If

        End If

        If tempSTR = "采購管理--物料採購" Then
            '***判斷用戶是擁有特殊類的權限
            Dim pmws As New PermissionModuleWarrantSubController
            Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
            Dim tesuvalue As String
            tesuvalue = "否"
            pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100115")
            If pmwiL.Item(0).PMWS_Value = "是" Then
                tesuvalue = "是"
            End If
            Dim mc As New Purchase.PurchaseMainController

            If ctd.CollToDataSet(ds, "FrmPurchaseExport", Pmc.PurchaseMain_Getlist1(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "物料", DateEdit1.Text, DateEdit2.Text, Nothing, Nothing, "采購作業", Nothing, Nothing, Nothing, tesuvalue)) Then


                Dim exapp As New Excel.Application
                Dim exbook As Excel.Workbook
                Dim exsheet As Excel.Worksheet

                Dim i As Integer = 0, ii As Integer = 0

                exapp = CreateObject("Excel.Application")
                exbook = exapp.Workbooks.Add
                exsheet = exapp.Worksheets(1)

                exsheet.Cells(1, 1) = "採購單號"
                exsheet.Cells(1, 2) = "供應商名"
                exsheet.Cells(1, 3) = "物料編碼"
                exsheet.Cells(1, 4) = "名稱"
                exsheet.Cells(1, 5) = "規格"
                exsheet.Cells(1, 6) = "批次"
                exsheet.Cells(1, 7) = "供應商編號"
                exsheet.Cells(1, 8) = "單價"
                exsheet.Cells(1, 9) = "幣別"
                exsheet.Cells(1, 10) = "數量"
                exsheet.Cells(1, 11) = "未交數"
                exsheet.Cells(1, 12) = "採購日期"
                exsheet.Cells(1, 13) = "部門審核"
                exsheet.Cells(1, 14) = "會計審核"
                exsheet.Cells(1, 15) = "會計審核類型"
                exsheet.Cells(1, 16) = "會計部審核員"
                exsheet.Cells(1, 17) = "操作員"

                For i = 0 To ds.Tables(0).Rows.Count - 1
                    ii = i + 2
                    exsheet.Cells(ii, 1) = ds.Tables(0).Rows(i)("PM_NO")
                    exsheet.Cells(ii, 2) = ds.Tables(0).Rows(i)("S_SupplierName")
                    exsheet.Cells(ii, 3) = "#" & ds.Tables(0).Rows(i)("M_Code") & "#"
                    exsheet.Cells(ii, 4) = ds.Tables(0).Rows(i)("M_Name")
                    exsheet.Cells(ii, 5) = ds.Tables(0).Rows(i)("M_Gauge")
                    exsheet.Cells(ii, 6) = ds.Tables(0).Rows(i)("OS_BatchID")
                    exsheet.Cells(ii, 7) = ds.Tables(0).Rows(i)("S_SupplierNo")
                    exsheet.Cells(ii, 8) = ds.Tables(0).Rows(i)("PS_Price")
                    exsheet.Cells(ii, 9) = ds.Tables(0).Rows(i)("C_ID")
                    exsheet.Cells(ii, 10) = ds.Tables(0).Rows(i)("PS_QTY")
                    exsheet.Cells(ii, 11) = ds.Tables(0).Rows(i)("PS_NoSendQty")
                    exsheet.Cells(ii, 12) = ds.Tables(0).Rows(i)("PM_PurchaseDate")
                    exsheet.Cells(ii, 13) = ds.Tables(0).Rows(i)("PM_Check")

                    exsheet.Cells(ii, 14) = ds.Tables(0).Rows(i)("PM_AccountCheck")
                    exsheet.Cells(ii, 15) = ds.Tables(0).Rows(i)("PM_AccountCheckType")
                    exsheet.Cells(ii, 16) = ds.Tables(0).Rows(i)("PM_AccCheckActionName")
                    exsheet.Cells(ii, 17) = ds.Tables(0).Rows(i)("PM_ActionName")
                Next
                exapp.Visible = True
            Else
                MsgBox("沒有數據!")
            End If
        ElseIf tempSTR = "采購管理--大貨採購" Then
        End If
        '    If ctd.CollToDataSet(ds, "WareInputExport", wip.WareInputExport_Getlist(tempA, Nothing, DateEdit1.Text, DateEdit2.Text)) Then


        '        Dim exapp As New Excel.Application
        '        Dim exbook As Excel.Workbook
        '        Dim exsheet As Excel.Worksheet

        '        Dim i As Integer = 0, ii As Integer = 0

        '        exapp = CreateObject("Excel.Application")
        '        exbook = exapp.Workbooks.Add
        '        exsheet = exapp.Worksheets(1)

        '        exsheet.Cells(1, 1) = "入庫單號"
        '        exsheet.Cells(1, 2) = "物料編碼"
        '        exsheet.Cells(1, 3) = "物料名稱"
        '        exsheet.Cells(1, 4) = "規格"
        '        exsheet.Cells(1, 5) = "入庫數量"
        '        exsheet.Cells(1, 6) = "單位"
        '        exsheet.Cells(1, 7) = "批次"
        '        exsheet.Cells(1, 8) = "操作員"
        '        exsheet.Cells(1, 9) = "審核"
        '        exsheet.Cells(1, 10) = "入庫日期"
        '        exsheet.Cells(1, 11) = "審核備註"


        '        For i = 0 To ds.Tables(0).Rows.Count - 1
        '            ii = i + 2
        '            exsheet.Cells(ii, 1) = ds.Tables(0).Rows(i)("WIP_ID")
        '            exsheet.Cells(ii, 2) = "#" & ds.Tables(0).Rows(i)("M_Code") & "#"
        '            exsheet.Cells(ii, 3) = ds.Tables(0).Rows(i)("M_Name")
        '            exsheet.Cells(ii, 4) = ds.Tables(0).Rows(i)("M_Gauge")
        '            exsheet.Cells(ii, 5) = ds.Tables(0).Rows(i)("WIP_Qty")
        '            exsheet.Cells(ii, 6) = ds.Tables(0).Rows(i)("M_Unit")
        '            exsheet.Cells(ii, 7) = ds.Tables(0).Rows(i)("OS_BatchID")
        '            exsheet.Cells(ii, 8) = ds.Tables(0).Rows(i)("WIP_ActionName")
        '            exsheet.Cells(ii, 9) = ds.Tables(0).Rows(i)("WIP_Check")
        '            exsheet.Cells(ii, 10) = CDate(ds.Tables(0).Rows(i)("WIP_AddDate"))
        '            exsheet.Cells(ii, 11) = ds.Tables(0).Rows(i)("WIP_CheckRemark")
        '        Next
        '        exapp.Visible = True
        '    Else
        '        MsgBox("沒有數據!")
        '    End If


        Me.Close()
    End Sub
End Class