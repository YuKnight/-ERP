Imports LFERP.Library.BarCode
Imports LFERP.Library.Material


Public Class frmWareInventoryBarCode

    Dim wi As New MaterialInfo
    Dim wic As New MaterialController

    Private Sub frmWareInventoryBarCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextEdit1.Text = tempValue4
        tempValue4 = ""
        wi = wic.MaterialCode_Get(TextEdit1.Text.Trim)
        If wi Is Nothing Then
        Else
            Label2.Text = wi.M_Name
        End If
        TextEdit2.Focus()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim bc As New BarCodeControl
        bc.PrintSBar1(TextEdit1.Text, Label2.Text, "LPT3", TextEdit2.Text)  '測試端口
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub TextEdit2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit2.KeyDown
        If e.KeyCode = Keys.Down Then
            Dim bc As New BarCodeControl
            bc.PrintSBar1(TextEdit1.Text, Label2.Text, "LPT3", TextEdit2.Text) '測試端口
        End If
    End Sub

    Private Sub TextEdit2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit2.KeyUp
        If (e.KeyValue > 47 And e.KeyValue < 58) Or (e.KeyValue > 95 And e.KeyValue < 106) Or (e.KeyValue = 8) Or (e.KeyValue = 45) Or (e.KeyValue = 46) Then
        Else
            TextEdit2.Text = Nothing
            Exit Sub
        End If
    End Sub
End Class