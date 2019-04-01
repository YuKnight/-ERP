Imports LFERP.Library.Orders

Public Class frmOrderSubModifyNoSendQty
    Dim osc As New OrdersSubController
    Public strOM_ID As String
    Public strOS_Type As String

    Private Sub frmOrderSubModifyNoSendQty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim osi As List(Of OrdersSubInfo)

        osi = osc.OrdersSub_GetList1(Nothing, txtOS_BatchID.Text, Nothing, Nothing, strOS_Type, Nothing, Nothing)

        txtOS_NoSendQty.Text = osi(0).OS_NoSendQty
        txtOS_NoOutQty.Text = osi(0).OS_NoOutQty
        txtOM_CusterID.Text = osi(0).OM_CusterID
        txtOM_CusterNo.Text = osi(0).OM_CusterNo
        txtOS_SendDate.Text = osi(0).OS_SendDate
        txtPM_M_Code.Text = osi(0).PM_M_Code
        txtM_Name.Text = osi(0).M_Name
        txtOS_Qty.Text = osi(0).OS_Qty

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim osi As New OrdersSubInfo

        osi.OM_ID = strOM_ID
        osi.OS_BatchID = txtOS_BatchID.Text
        osi.OS_NoSendQty = CInt(txtOS_NoSendQty.Text.Trim)
        osi.OS_NoOutQty = CInt(txtOS_NoOutQty.Text)

        If osc.OrdersSub_UpdateNoSendQty(osi) = True Then
            MsgBox("修改完成！", 64, "提示")
            Me.Close()
        End If
    End Sub

    Private Sub txtOS_NoSendQty_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOS_NoSendQty.EditValueChanged
        txtOS_NoOutQty.Text = txtOS_NoSendQty.Text
    End Sub
End Class