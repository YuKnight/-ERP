Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess

Public Class frmProductionOutWardFindS

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        tempValue = Nothing
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        tempValue = "F"
        If PM_M_Code.Text = "" Then
            tempValue2 = Nothing
        Else
            tempValue2 = PM_M_Code.EditValue
        End If

        If GluType.Text = "" Then
            tempValue3 = Nothing
        Else
            tempValue3 = GluType.EditValue
        End If

        Me.Close()
    End Sub

    Private Sub frmProductionOutWardFindS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mc As New ProcessMainControl
        PM_M_Code.Properties.DisplayMember = "PM_M_Code"
        PM_M_Code.Properties.ValueMember = "PM_M_Code"
        PM_M_Code.Properties.DataSource = mc.ProcessMain_GetList3(Nothing, Nothing)
    End Sub

    Private Sub PM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PM_M_Code.EditValueChanged
        Dim ppc As New ProcessMainControl
        If PM_M_Code.Text = "" Then
            GluType.Properties.DataSource = Nothing
            Exit Sub
        End If

        GluType.Properties.ValueMember = "Type3ID"
        GluType.Properties.DisplayMember = "Type3ID"
        GluType.Properties.DataSource = ppc.ProcessMain_GetList2("生產加工", PM_M_Code.EditValue)
    End Sub

    '@ 2012/8/13 添加 按空格鍵彈出下拉菜單
    Private Sub PM_M_Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PM_M_Code.KeyDown, GluType.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub
End Class