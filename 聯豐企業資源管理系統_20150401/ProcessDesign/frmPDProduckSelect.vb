Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess

Public Class frmPDProduckSelect
    Dim mc As New ProductController
    Dim ppc As New ProcessMainControl

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtLFID.Text.Trim = "" Then
            tempValue = Nothing
        Else
            tempValue = txtLFID.Text.Trim
        End If
        tempValue2 = ComboBoxEdit1.Text
        tempValue3 = gluPM_M_Code.EditValue
        If GluType.EditValue = "" Then
            tempValue4 = Nothing
        Else
            tempValue4 = GluType.EditValue
        End If

        tempValue5 = "³æÀ»¬d¸ß«ö¶s"
        Me.Close()
    End Sub

    Private Sub frmPDProduckSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        gluPM_M_Code.Properties.ValueMember = "PM_M_Code"
        gluPM_M_Code.Properties.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub gluPM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluPM_M_Code.EditValueChanged
        GluType.Text = Nothing
        If IsDBNull(gluPM_M_Code.EditValue) = False Then
            GluType.Properties.ValueMember = "Type3ID"
            GluType.Properties.DisplayMember = "Type3ID"
            GluType.Properties.DataSource = ppc.ProcessMain_GetList2(ComboBoxEdit1.EditValue, gluPM_M_Code.EditValue)
        End If
    End Sub

    'Private Sub ComboBoxEdit1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged
    '    gluPM_M_Code_EditValueChanged(Nothing, Nothing)
    'End Sub

    Private Sub gluPM_M_Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluPM_M_Code.KeyDown, GluType.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub
End Class