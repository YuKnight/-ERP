Imports LFERP.Library.Orders

Public Class FrmOrdersMainSe2

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        On Error Resume Next

        Dim osi As New OrdersSubInfo
        Dim osc As New OrdersSubController
        osi = osc.OrdersSub_Get(txtLFID.Text)

        If osi.OS_Check = True Then
            tempValue2 = txtLFID.Text
            tempValue3 = Label1.Text
            Dim fr As frmOrdersSub
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmOrdersSub Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            fr = New frmOrdersSub
            fr.MdiParent = MDIMain
            fr.Show()
            Me.Close()
        Else
            MsgBox("此批次還未被審核，不允許導入！")
        End If
        
    End Sub



    Private Sub FrmOrdersMainSe2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = tempValue4
        tempValue3 = ""
    End Sub

    Private Sub txtLFID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLFID.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class