Imports LFERP.Library.MrpManager.MrpInfo

Public Class frmMrpPurchaseCalcRecord

    Private Sub frmMrpPurchaseCalcRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim mpcrc As New MrpPurchaseCalcRecordController
        GridControl1.DataSource = mpcrc.MrpPurchaseCalcRecord_GetList(Nothing)
        BandedGridView1.Bands.Item(0).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        'BandedGridView1.ActiveFilterString = " CreateDate > " + Now.AddMonths(-3)
        BandedGridView1.ActiveFilterString = "Mrp_ID like 'M%' "
    End Sub

#Region "對Grid中的審核日期和運算類型設置顯示格式"
    Private Sub GridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles BandedGridView1.CustomColumnDisplayText
        Try
            '----------------當訂單開始日期為空時，則不顯示----------------
            If e.Column.FieldName = "NeedBeginDate" Then
                If e.Value = Nothing Then e.DisplayText = ""
            End If
            '----------------當訂單結束日期為空時，則不顯示----------------
            If e.Column.FieldName = "NeedEndDate" Then
                If e.Value = Nothing Then e.DisplayText = ""
            End If
            '----------------當類型為1時顯示正式，否則顯示模擬----------------
            If e.Column.FieldName = "MRPType" Then
                If e.Value = 1 Then
                    e.DisplayText = "正式"
                Else
                    e.DisplayText = "模擬"
                End If
            End If
            '----------------當運算條件為1時則顯示按日期運算，否則顯示按單號運算----------------
            If e.Column.FieldName = "CalcType" Then
                If e.Value = 1 Then
                    e.DisplayText = "按日期運算"
                Else
                    e.DisplayText = "按單號運算"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
#End Region

End Class