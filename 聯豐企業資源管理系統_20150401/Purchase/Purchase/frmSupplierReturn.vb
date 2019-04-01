Imports LFERP.Library.Purchase

Public Class frmSupplierReturn

    Dim ps As New Purchase.PurchaseSubsControl

    Private Sub frmSupplierReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label10.Text = tempValue
        Label12.Text = tempValue2
        LoadData(Label10.Text, Label12.Text)
        DateEdit1.Text = Label8.Text
        Grid1.DataSource = ps.PurchaseSubs_GetList(Label10.Text, Label12.Text, Nothing)
        tempValue = ""
        tempValue2 = ""
        tempValue3 = ""
    End Sub
    Sub LoadData(ByVal PM_NO As String, ByVal M_Code As String)
        Dim pmi As List(Of Purchase.PurchaseMainInfo)
        Dim pmc As New Purchase.PurchaseMainController
        pmi = pmc.PurchaseSub_GetBatchList(PM_NO, M_Code, Nothing)
        If pmi.Count = 0 Then Exit Sub
        Label6.Text = pmi(0).S_SupplierName
        Label7.Text = pmi(0).OS_BatchID
        Label8.Text = Format(pmi(0).PS_SendDate, "yyyy/MM/dd")
        Label14.Text = pmi(0).M_Name
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        DataNew()
        Grid1.DataSource = ps.PurchaseSubs_GetList(Label10.Text, Label12.Text, Nothing)
    End Sub
    Sub DataNew()

        Dim pssi As New Purchase.PurchaseSubsInfo
        Dim pssc As New Purchase.PurchaseSubsControl
        pssi.M_Code = Label12.Text
        pssi.OS_BatchID = Label7.Text
        pssi.PM_NO = Label10.Text
        pssi.PSs_Date = DateEdit1.Text
        pssi.PSs_Remark = TextEdit1.Text
        If pssc.PurchaseSubs_Add(pssi) = True Then
            MsgBox("添加復回信息成功")
        Else
            MsgBox("添加失敗，請檢查原因！")
        End If
    End Sub
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If GridView2.RowCount = 0 Then Exit Sub
        If MsgBox("確定要刪除此選擇的復回信息嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.Yes Then
            Dim pssc As New Purchase.PurchaseSubsControl
            If pssc.PurchaseSubs_Delete(GridView2.GetFocusedRowCellValue("AutoID").ToString) = True Then
                MsgBox("刪除完成！")
            End If
            Grid1.DataSource = ps.PurchaseSubs_GetList(Label10.Text, Label12.Text, Nothing)
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class