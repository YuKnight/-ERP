Imports LFERP.Library.Orders
Imports LFERP.Library.Product
Imports LFERP.SystemManager

Public Class frmPurchaseStatusPJMain

    Private Sub frmPurchaseStatusPJMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim osc As New OrdersSubController

        Grid1.DataSource = osc.OrdersSub_GetList(Nothing, Nothing, Nothing, "配件批次", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True)

        LoadPowerUser()
    End Sub
    Sub LoadPowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "40090201")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmsStatusCheck.Enabled = True
        End If
    End Sub
    '狀態審核
    Private Sub cmsStatusCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsStatusCheck.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As frmWLList
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmWLList Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = GridView1.GetFocusedRowCellValue("OS_BatchID").ToString
        fr = New frmWLList
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub cmsStatusRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsStatusRef.Click
        Dim osc As New OrdersSubController

        Grid1.DataSource = osc.OrdersSub_GetList(Nothing, Nothing, Nothing, "配件批次", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True)
    End Sub
End Class