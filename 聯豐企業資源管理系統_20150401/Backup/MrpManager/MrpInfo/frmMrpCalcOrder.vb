Imports LFERP.Library.MrpManager.Mrpinfo
Public Class frmMrpCalcOrder

    Private Sub frmMrpCalcOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mri As New List(Of MrpCalcRecordInfo)
        Dim mrc As New MrpCalcRecordController
        mri = mrc.MrpCalcRecord_GetList()
        Grid1.DataSource = mri
    End Sub
End Class