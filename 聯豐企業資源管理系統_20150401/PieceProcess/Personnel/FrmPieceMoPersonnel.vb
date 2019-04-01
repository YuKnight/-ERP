Imports System
Imports LFERP.SystemManager
Imports LFERP.Library
Imports LFERP.Library.PieceProcess
Public Class FrmPieceMoPersonnel
    Dim pc As New PieceProcess.PersonnelControl
    Dim pi As New PieceProcess.PersonnelInfo
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Edit = False
        tempValue2 = "員工錄入"
        Dim fr As New FrmPersonnelSub
        fr.ShowDialog()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Edit = True
        tempValue2 = "員工錄入"
        tempValue = GridView1.GetFocusedRowCellValue("Per_NO")
        Dim fr As New FrmPersonnelSub
        fr.ShowDialog()
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        If MsgBox("確定要刪除廠證編號為:" & GridView1.GetFocusedRowCellValue("Per_NO"), MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        If pc.PieceMoPersonnel_Del(GridView1.GetFocusedRowCellValue("Per_NO"), Nothing) Then
            MsgBox("已刪除成功！")
        End If
        Grid.DataSource = pc.PieceMoPersonnel_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub FrmPieceMoPersonnel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PowerUser()
        Grid.DataSource = pc.PieceMoPersonnel_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub
    '設置權限
    Sub PowerUser()

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "860201")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "860202")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "860203")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdDel.Enabled = True
        End If
      

    End Sub
    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        tempValue2 = "View"
        tempValue = GridView1.GetFocusedRowCellValue("Per_NO")
        Dim fr As New FrmPersonnelSub
        fr.ShowDialog()
    End Sub

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        tempValue = "計件名單-人員"
        Dim fr As New FrmPieceSelect
        fr.ShowDialog()

    End Sub

    Private Sub cmdRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRef.Click
        Grid.DataSource = pc.PieceMoPersonnel_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub ccmdCiGong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ccmdCiGong.Click
        If MsgBox("你確實是要處理這個員工嗎?", vbYesNo + vbQuestion, "辭工處理") = vbNo Then
        Else
            pi.Per_NO = GridView1.GetFocusedRowCellValue("Per_NO")
            If pc.PieceMoPersonnel_GetList(GridView1.GetFocusedRowCellValue("Per_NO"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)(0).Per_Dismiss = False Then
                pi.Per_Dismiss = True
            Else
                pi.Per_Dismiss = False
            End If
            If pc.PieceMoPersonnel2_Update(pi) = False Then
                MsgBox("員工辭工處理出錯!")
                Exit Sub
            End If
        End If
    End Sub
End Class