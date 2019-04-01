Imports LFERP.Library.ProductionMerge

Public Class frmProductionMergeMain

    Dim pmc As New ProductionMergeControl

    Private Sub frmProductionMergeMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Grid1.DataSource = pmc.ProductionMerge_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

    End Sub

    Private Sub cmsPreView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsPreView.Click
        On Error Resume Next

        Dim fr As New frmProductionMerge
        tempValue = GridView1.GetFocusedRowCellValue("PM_NO").ToString
        fr.ShowDialog()

    End Sub

    Private Sub cmsQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsQuery.Click

    End Sub

End Class