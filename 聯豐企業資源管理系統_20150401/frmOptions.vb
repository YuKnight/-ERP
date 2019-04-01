Imports System.IO.Ports

Public Class frmOptions

    Private Sub FrmOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ss As String
        cboSetCOM.Properties.Items.Clear()
        For Each ss In SerialPort.GetPortNames
            cboSetCOM.Properties.Items.Add(ss.ToString)
        Next
        cboSetCOM.Text = My.Settings.strCOM
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        My.Settings.strCOM = cboSetCOM.Text
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class