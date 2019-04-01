Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.DataSetting
Imports LFERP.Library.Product
Public Class frmOrdersMainSe
    Dim mc As New ProductController
    Dim mtd As New CusterControler
    Private Sub frmOrdersMainSe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        gluCuster.Properties.DisplayMember = "C_CusterID"
        gluCuster.Properties.ValueMember = "C_CusterID"
        gluCuster.Properties.DataSource = mtd.GetCusterList(Nothing, Nothing, Nothing)


        GridLookPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        GridLookPM_M_Code.Properties.ValueMember = "PM_M_Code"
        GridLookPM_M_Code.Properties.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtOM_No.Text.Trim = "" Then
            tempValue = Nothing
        Else
            tempValue = txtOM_No.Text.Trim
        End If

        If txtLFID.Text.Trim = "" Then
            tempValue2 = Nothing
        Else
            tempValue2 = txtLFID.Text.Trim
        End If

        tempValue3 = gluCuster.EditValue


        If TextEdit1.Text.Trim = "" Then
            tempValue4 = Nothing
        Else
            tempValue4 = TextEdit1.Text.Trim
        End If

        If dteOM_PoDateBegin.Text = "" Then
            tempValue6 = Nothing
        Else
            tempValue6 = dteOM_PoDateBegin.DateTime
        End If

        If dteOM_PoDateEnd.Text = "" Then
            tempValue7 = Nothing
        Else
            tempValue7 = dteOM_PoDateEnd.DateTime
        End If

        If GridLookPM_M_Code.Text = "" Then
            tempValue8 = Nothing
        Else
            tempValue8 = GridLookPM_M_Code.EditValue
        End If

        tempValue5 = "³æÀ»¬d¸ß«ö¶s"
        Me.Close()
    End Sub

    Private Sub txtLFID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLFID.EditValueChanged

    End Sub
End Class