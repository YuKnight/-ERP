Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.DataSetting
Imports LFERP.Library.Product
Public Class frmProductMainSe
    Dim mc As New ProductController
    Dim mtd As New CusterControler
    Private Sub frmProductMainSe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gluCuster.Properties.DisplayMember = "C_CusterID"
        gluCuster.Properties.ValueMember = "C_CusterID"
        gluCuster.Properties.DataSource = mtd.GetCusterList(Nothing, Nothing, Nothing)
        txtLFID.Select()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'If RadioButton1.Checked = True Then
        '    tempValue = "1"
        '    tempValue2 = txtLFID.Text
        '    Me.Close()
        'End If

        'If RadioButton2.Checked = True Then
        '    tempValue = "2"
        '    tempValue2 = gluCuster.Text
        '    Me.Close()
        'End If

        'If RadioButton3.Checked = True Then
        '    tempValue = "3"
        '    tempValue2 = TextEdit1.Text
        '    Me.Close()
        'End If
        If txtLFID.Text = "" Then
            tempValue2 = Nothing
        Else
            tempValue2 = txtLFID.Text
        End If

        If gluCuster.EditValue Is Nothing Or gluCuster.EditValue = "" Then
            tempValue3 = Nothing
        Else
            tempValue3 = gluCuster.EditValue
        End If

        If TextEdit1.Text = "" Then
            tempValue4 = Nothing
        Else
            tempValue4 = TextEdit1.Text
        End If

        If TexM_Guge.Text = "" Then
            tempValue5 = Nothing
        Else
            tempValue5 = TexM_Guge.Text
        End If

        If Mid(ComProd_Check.EditValue, 1, 1) = 0 Then
            tempValue6 = False
        ElseIf Mid(ComProd_Check.EditValue, 1, 1) = 1 Then
            tempValue6 = True
        ElseIf Mid(ComProd_Check.EditValue, 1, 1) = 2 Then
            tempValue6 = Nothing
        End If


        Me.Close()

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If RadioButton1.Checked = True Then
        '    txtLFID.Focus()
        'End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If RadioButton2.Checked = True Then
        '    gluCuster.Focus()
        'End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If RadioButton3.Checked = True Then
        '    TextEdit1.Focus()
        'End If
    End Sub
End Class