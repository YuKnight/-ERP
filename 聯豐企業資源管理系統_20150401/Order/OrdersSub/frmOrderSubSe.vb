Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.DataSetting
Imports LFERP.Library.Product
Public Class frmOrderSubSe
    Dim mc As New ProductController
    Dim mtd As New CusterControler
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If RadioButton1.Checked = True Then
            tempValue = "1"
            tempValue2 = txtLFID.Text
            Me.Close()
        End If

        If RadioButton2.Checked = True Then
            tempValue = "2"
            tempValue2 = gluCuster.Text
            Me.Close()
        End If

        If RadioButton3.Checked = True Then
            tempValue = "3"
            tempValue2 = TextEdit1.Text
            Me.Close()
        End If

        If RadioButton4.Checked = True Then
            tempValue = "4"
            tempValue2 = TextEdit2.Text
            Me.Close()
        End If

        If RadioButton5.Checked = True Then
            tempValue = "5"
            tempValue2 = TextEdit3.Text
            Me.Close()
        End If

    End Sub

    Private Sub frmOrderSubSe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gluCuster.Properties.DisplayMember = "C_CusterID"
        gluCuster.Properties.ValueMember = "C_CusterID"
        gluCuster.Properties.DataSource = mtd.GetCusterList(Nothing, Nothing, Nothing)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            txtLFID.Focus()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            gluCuster.Focus()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            TextEdit1.Focus()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            TextEdit2.Focus()
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            TextEdit3.Focus()
        End If
    End Sub

    'Private Sub txtLFID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLFID.Leave
    '    RadioButton2.Focus()
    'End Sub

    'Private Sub gluCuster_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles gluCuster.Leave
    '    RadioButton3.Focus()
    'End Sub

    'Private Sub TextEdit1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextEdit1.Leave
    '    RadioButton4.Focus()
    'End Sub

    'Private Sub TextEdit2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextEdit2.Leave
    '    RadioButton5.Focus()
    'End Sub

    'Private Sub cmdExit_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit.Leave
    '    RadioButton1.Focus()
    'End Sub
End Class