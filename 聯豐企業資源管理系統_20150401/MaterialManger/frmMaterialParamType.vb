Imports LFERP.Library.MaterialParam

Public Class frmMaterialParamType
    Dim MPController As New MaterialParamController
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub


    Private Sub frmMaterialParamType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dGrid.DataSource = MPController.MaterialParamType_GetList()

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Edit = False
        frmMaterialParamTypeSub.ShowDialog()
        dGrid.DataSource = MPController.MaterialParamType_GetList()

    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If MsgBox("你確定要刪除此參數嗎?", MsgBoxStyle.YesNo, "警告") = MsgBoxResult.No Then Exit Sub

        MPController.MaterialParamType_Delete(dGrid.CurrentRow.Cells("ParamID").Value.ToString)
        dGrid.DataSource = MPController.MaterialParamType_GetList()

    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Edit = True
        'MsgBox(dGrid.CurrentRow.Cells(0).Value.ToString)
        frmMaterialParamTypeSub.lblID.Text = dGrid.CurrentRow.Cells("ParamID").Value.ToString
        frmMaterialParamTypeSub.ShowDialog()
        dGrid.DataSource = MPController.MaterialParamType_GetList()
    End Sub

    

    
   
End Class