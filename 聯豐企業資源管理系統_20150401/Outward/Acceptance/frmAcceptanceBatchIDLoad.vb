Imports LFERP.Library.Outward

Public Class frmAcceptanceBatchIDLoad

    Private Sub frmAcceptanceBatchIDLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNO.Text = ""
        gluBatch.EditValue = ""
        gluCode.EditValue = ""
        txtQty.Text = ""
    End Sub

    Private Sub txtNO_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNO.LostFocus
        Dim oi As List(Of OutwardInfo)
        Dim oc As New OutwardController
        oi = oc.OutwardSub_GetList(txtNO.Text, Nothing, Nothing, Nothing, Nothing)
        If oi.Count = 0 Then Exit Sub

        Me.gluBatch.Properties.DataSource = oc.OutwardSub_GetList(txtNO.Text, Nothing, Nothing, Nothing, Nothing)
        gluBatch.Properties.DisplayMember = "OS_BatchID"
        gluBatch.Properties.ValueMember = "OS_BatchID"

    End Sub

    Private Sub gluBatch_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gluBatch.EditValueChanged
        Dim oc As New OutwardController

        Me.gluCode.Properties.DataSource = oc.OutwardSub_GetList(txtNO.Text, Nothing, Nothing, Nothing, gluBatch.EditValue)
        gluCode.Properties.DisplayMember = "M_Name"
        gluCode.Properties.ValueMember = "M_Code"

    End Sub

    Private Sub gluCode_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gluCode.EditValueChanged
        Dim oi As List(Of OutwardInfo)
        Dim oc As New OutwardController
        oi = oc.OutwardSub_GetList(txtNO.Text, Nothing, gluCode.EditValue, Nothing, gluBatch.EditValue)
        If oi.Count = 0 Then Exit Sub
        txtQty.Text = oi(0).OS_NoSendQty

    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtNO.Text = "" Or gluBatch.EditValue = "" Or gluCode.EditValue = "" Or txtQty.Text = "" Then
                MsgBox("數據填寫不完整,請確認輸入正確！")
                Exit Sub
            Else
                tempValue = txtNO.Text
                tempValue2 = gluBatch.EditValue
                tempValue3 = gluCode.EditValue
                tempValue4 = txtQty.Text
                Me.Close()
            End If

        End If
    End Sub
    Public Function IsNumeric(ByVal str As String) As Boolean
        '判斷是否為數字(包括小數) 
        Dim reg1 As New System.Text.RegularExpressions.Regex("\d|\.")
        Return reg1.IsMatch(str)
    End Function
    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        If txtNO.Text = "" Or gluBatch.EditValue = "" Or gluCode.EditValue = "" Or txtQty.Text = "" Then
            MsgBox("數據填寫不完整,請確認輸入正確！")
            Exit Sub
        Else
            tempValue = txtNO.Text
            tempValue2 = gluBatch.EditValue
            tempValue3 = gluCode.EditValue
            tempValue4 = txtQty.Text
            Me.Close()
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

End Class