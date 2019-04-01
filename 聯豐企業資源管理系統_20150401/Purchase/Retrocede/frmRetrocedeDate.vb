Imports LFERP.Library.Purchase.Retrocede

Public Class frmRetrocedeDate

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Dim ds As New DataSet

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet

        Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim mcSupplier As New LFERP.DataSetting.SuppliersControler
        Dim mcRetrocede As New LFERP.Library.Purchase.Retrocede.RetrocedeController
        Dim mcsysuser As New LFERP.SystemManager.SystemUser.SystemUserController

        ds.Tables.Clear()

        ltc1.CollToDataSet(ds, "Suppliers", mcSupplier.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc2.CollToDataSet(ds, "Retrocede", mcRetrocede.Retrocede_GetList(Nothing, Nothing, Nothing, Nothing, DateEdit1.EditValue, DateEdit2.EditValue, Nothing, False, Nothing, Nothing, Nothing, Nothing))
      
        PreviewRPT(ds, "rptRetrocedeNotAll", "未完成退貨清單", True, True)

        ltc1 = Nothing
        ltc2 = Nothing
        tempValue = ""
        tempValue2 = ""

        Me.Close()


    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmRetrocedeDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = Format(Now, "yyyy/MM/dd")
        DateEdit2.EditValue = Format(Now, "yyyy/MM/dd")
    End Sub
End Class