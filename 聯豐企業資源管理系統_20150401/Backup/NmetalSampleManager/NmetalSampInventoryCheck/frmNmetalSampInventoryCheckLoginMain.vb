Imports LFERP.Library.NmetalSampleManager.NmetalSampInventoryCheck
Imports LFERP.SystemManager
Public Class frmNmetalSampInventoryCheckLoginMain
    Private Sub frmSampInventoryCheckLoginMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PowerUser()
        cmdRef_Click(Nothing, Nothing)
    End Sub

    Sub PowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "890704")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "¬O" Then cmdEdit.Enabled = True
        End If
    End Sub

    Private Sub cmdRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRef.Click
        Dim rc As New NmetalSampInventoryCheckControl
        Me.gridSampleCollection.DataSource = rc.NmetalSampInventoryCheckLogin_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Dim fr As New frmNmetalSampInventoryCheckUpdate
        fr = New frmNmetalSampInventoryCheckUpdate
        fr.ShowDialog()
    End Sub
End Class