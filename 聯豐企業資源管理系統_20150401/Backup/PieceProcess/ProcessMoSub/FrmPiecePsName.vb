Imports System
Imports LFERP.Library
Imports LFERP.Library.ProductProcess
Public Class FrmPiecePsName

    Dim pc As New ProductProcess.ProcessMainControl
    Dim pi As New ProductProcess.ProcessMainInfo

    Private Sub FrmPiecePsName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextEdit1.Text = tempValue
        TextEdit2.Focus()
        tempValue = ""
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        tempValue = TextEdit2.Text
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class