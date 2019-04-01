Imports LFERP.Library.ProductionMerge

Public Class frmProductionMerge

    Dim ds As New DataSet
    Dim pmc As New ProductionMergeControl


    Private Sub frmProductionMerge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()


    End Sub

    Sub CreateTable()

        With ds.Tables.Add("Process")
            .Columns.Add("Pro_SNO", GetType(String))
            .Columns.Add("SName", GetType(String))
        End With

        GluEdit1.Properties.ValueMember = "Pro_SNO"
        GluEdit1.Properties.DisplayMember = "SName"
        GluEdit1.Properties.DataSource = ds.Tables("Process")

        With ds.Tables.Add("Process1")
            .Columns.Add("Pro_MNO", GetType(String))
            .Columns.Add("MName", GetType(String))
        End With

        GluEdit2.Properties.ValueMember = "Pro_MNO"
        GluEdit2.Properties.DisplayMember = "MName"
        GluEdit2.Properties.DataSource = ds.Tables("Process1")

    End Sub

    Function LoadData(ByVal PM_NO As String) As Boolean
        LoadData = True
        Dim pmi As List(Of ProductionMergeInfo)
        pmi = pmc.ProductionMerge_GetList(PM_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pmi.Count = 0 Then
            LoadData = False
            Exit Function
        Else


            txtPMNO.Text = pmi(0).PM_NO
            txtFPNO.Text = pmi(0).FP_NO
            txtCode.Text = pmi(0).PM_M_Code
            txtPType.Text = pmi(0).Pro_Type
            txtType.Text = pmi(0).PM_Type
            Label9.Text = pmi(0).ActionName

            GluEdit1.Properties.DataSource = ""

            GluEdit1.EditValue = pmi(0).Pro_SNO
            GluEdit2.EditValue = pmi(0).Pro_MNO
            txtQty1.Text = pmi(0).Pro_SQty
            txtQty2.Text = pmi(0).Pro_MQty

        End If

    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

End Class