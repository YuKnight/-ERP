Imports LFERP.Library.Product
Imports LFERP.Library.Orders

Public Class frmOrderMainProduction

    Private Sub frmOrderMainProduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mc As New ProductController
        GridLookNewCode.Properties.DisplayMember = "PM_M_Code"
        GridLookNewCode.Properties.ValueMember = "PM_M_Code"
        GridLookNewCode.Properties.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

    End Sub

    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        'Dim ds As New DataSet
        'Dim ltc As New CollectionToDataSet
        'Dim oc As New OrdersMainController
        'Dim ol As New List(Of OrdersMainInfo)

        'Dim StrPM_M_Code As String

        'If GridLookNewCode.Text = "" Then
        '    StrPM_M_Code = Nothing
        'Else
        '    StrPM_M_Code = GridLookNewCode.EditValue
        'End If

        'ol = oc.OrdersMainProduction_GetList(StrPM_M_Code)
        'If ol.Count > 0 Then
        'Else
        '    MsgBox("無數據！", 64, "提示")
        '    Exit Sub
        'End If

        'ltc.CollToDataSet(ds, "OrdersMainProduction", ol)
        'PreviewRPTDialog1(ds, "rptOrdersMainProduction", "磨刀部---刀具整體流轉表", "", "", True, True)
        'ltc = Nothing
    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub
End Class