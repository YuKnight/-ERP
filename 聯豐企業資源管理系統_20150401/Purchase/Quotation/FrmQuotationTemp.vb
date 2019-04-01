Imports LFERP.Library.Purchase.Quotation

Public Class FrmQuotationTemp


    Private Sub FrmQuotationTemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Label2.Text = tempValue2
        Label3.Text = tempValue
        tempValue2 = ""
        tempValue = ""

        Dim qc As New QuotationController


        Grid.AutoGenerateColumns = False
        Grid.RowHeadersWidth = 15
        Grid.DataSource = qc.Quotation_GetlistTop10(Nothing, Label3.Text, Nothing, Nothing, Nothing)


    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Me.Close()
    End Sub
End Class