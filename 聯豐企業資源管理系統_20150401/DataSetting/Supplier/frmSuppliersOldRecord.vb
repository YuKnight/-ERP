Imports LFERP.DataSetting

Public Class frmSuppliersOldRecord
    Dim mtt As New SuppliersControler
    Dim mcc As New SuppliersTypeControler

    Private Sub frmSuppliersOldRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TreeList1.DataSource = mcc.SuppliersType_GetList(Nothing, Nothing, Nothing)
        cmsRef_Click(Nothing, Nothing)        '調用刷新過程
    End Sub

    Private Sub TreeList1_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList1.FocusedNodeChanged
        Dim mt As New SuppliersControler
        Dim strA As String
        strA = TreeList1.FocusedNode.Item("S_TypeID").ToString()
        If TreeList1.FocusedNode.Id = 0 Then
            strA = Nothing
        End If
        Grid1.DataSource = mt.SuppliersOldRecord_GetList(Nothing, Nothing, strA, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub cmsFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsFind.Click
        Dim Myfrm As New frmSupplierSelect
        Dim sc As New SuppliersControler
        tempValue = ""
        tempValue2 = ""
        Myfrm.ShowDialog()
        Select Case tempValue
            Case "1"
                Grid1.DataSource = sc.SuppliersOldRecord_GetList(tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "2"
                Grid1.DataSource = sc.SuppliersOldRecord_GetList(Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing)

            Case "3"
                Grid1.DataSource = sc.SuppliersOldRecord_GetList(Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing)

            Case "4"
                Grid1.DataSource = sc.SuppliersOldRecord_GetList(Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing)

        End Select
        tempValue = ""
        tempValue2 = ""
    End Sub

    Private Sub cmsRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsRef.Click
        Grid1.DataSource = mtt.SuppliersOldRecord_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub
End Class