Imports LFERP.Library.WareHouse.WareChange
Imports LFERP.SystemManager

Public Class frmWareChangeMain

    Dim cc As New WareChangeControl

    Private Sub frmWareChangeMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Grid1.DataSource = cc.WareChange_GetList(Nothing, Nothing, Nothing, Nothing, Nothing)
        PowerUser()

    End Sub

    Sub PowerUser()

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "5006101")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popChangeAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "5006102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popChangeEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "5006103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popChangeDel.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "5006104")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popChangeCheck.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "5006105")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popChangeReCheck.Enabled = True
        End If

    End Sub

    Private Sub popChangeAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeAdd.Click
        On Error Resume Next

        Edit = False

        Dim fr As frmWareChange
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmWareChange Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "WareChange"
        fr = New frmWareChange
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
      
    End Sub

    Private Sub popChangeEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeEdit.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub

        Dim ci As List(Of WareChangeInfo)
        ci = cc.WareChange_GetList(GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, Nothing, Nothing, Nothing, Nothing)
        If ci.Count = 0 Then Exit Sub
        If ci(0).C_Check = True Then
            MsgBox("此單已審核不允許修改", , "提示")
            Exit Sub
        End If
        Edit = True
        Dim fr As frmWareChange
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmWareChange Then
                fr.Activate()
                Exit Sub
            End If
        Next

        tempValue = "WareChange"
        tempValue2 = GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString
        fr = New frmWareChange
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popChangeDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeDel.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim ci As List(Of WareChangeInfo)
        ci = cc.WareChange_GetList(GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, Nothing, Nothing, Nothing, Nothing)
        If ci.Count = 0 Then Exit Sub
        If ci(0).C_Check = True Then
            MsgBox("此單已審核不允許刪除!", , "提示")
            Exit Sub
        End If
        If MsgBox("確定刪除單號為" & GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString & "的全部記錄？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If cc.WareChange_Delete(GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, Nothing) = True Then
                MsgBox("刪除此單成功!", , "提示")

                Grid1.DataSource = cc.WareChange_GetList(Nothing, Nothing, Nothing, Nothing, Nothing)
            End If

        End If

    End Sub

    Private Sub popChangeView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeView.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim fr As frmWareChange
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmWareChange Then
                fr.Activate()
                Exit Sub
            End If
        Next

        tempValue = "PreView"
        tempValue2 = GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString
        fr = New frmWareChange
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popChangeCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeCheck.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub

        Dim ci As List(Of WareChangeInfo)
        ci = cc.WareChange_GetList(GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, Nothing, Nothing, Nothing, Nothing)
        If ci.Count = 0 Then Exit Sub
        If ci(0).C_Check = True Then
            MsgBox("此單已審核不允許再次審核", , "提示")
            Exit Sub
        End If
        Dim fr As frmWareChange
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmWareChange Then
                fr.Activate()
                Exit Sub
            End If
        Next

        tempValue = "Check"
        tempValue2 = GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString
        fr = New frmWareChange
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popChangeRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeRef.Click
        Grid1.DataSource = cc.WareChange_GetList(Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub popChangeSeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeSeek.Click

        Dim Myfrm As New frmWareChangeSelect
        Myfrm.ShowDialog()

        Grid1.DataSource = cc.WareChange_GetList(tempValue2, tempValue4, tempValue5, tempValue, Nothing)

        tempValue = ""
        tempValue2 = ""
        tempValue4 = ""
        tempValue5 = ""

    End Sub
    '更改單報表---倉庫更改庫存數(調數)
    Private Sub popChangePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangePrint.Click
        Dim ds As New DataSet
        If GridView1.RowCount = 0 Then Exit Sub

        Dim ltc1 As New CollectionToDataSet

        Dim Cmc As New LFERP.Library.WareHouse.WareChange.WareChangeControl
     
        ds.Tables.Clear()

        ltc1.CollToDataSet(ds, "WareChange", Cmc.WareChange_GetList(GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, Nothing, Nothing, Nothing, Nothing))

        PreviewRPT(ds, "rptWareChange", "更改單--" & GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, True, True)


        ltc1 = Nothing
    End Sub

    '附加文件---針對更改倉庫庫存數量的備註
    Private Sub popChangeFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeFile.Click

        Dim open, update, down, edit, del, detail As Boolean
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As New List(Of PermissionModuleWarrantSubInfo)

        If GridView1.RowCount = 0 Then Exit Sub
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "505001")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then update = True
            If pmwiL.Item(0).PMWS_Value = "否" Then update = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "505002")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then down = True
            If pmwiL.Item(0).PMWS_Value = "否" Then down = False
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "505003")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then edit = True
            If pmwiL.Item(0).PMWS_Value = "否" Then edit = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "505004")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then del = True
            If pmwiL.Item(0).PMWS_Value = "否" Then del = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "505005")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then detail = True
            If pmwiL.Item(0).PMWS_Value = "否" Then detail = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "505006")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then open = True
            If pmwiL.Item(0).PMWS_Value = "否" Then open = False
        End If

        FileShow("50061", GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, open, update, down, edit, del, detail)
    End Sub

    Private Sub popChangeReCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeReCheck.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub

        Dim ci As List(Of WareChangeInfo)
        ci = cc.WareChange_GetList(GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, Nothing, Nothing, Nothing, Nothing)
        If ci.Count = 0 Then Exit Sub
        If ci(0).C_Check = False Then
            MsgBox("此單未審核不允許復核", , "提示")
            Exit Sub
        End If
        Dim fr As frmWareChange
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmWareChange Then
                fr.Activate()
                Exit Sub
            End If
        Next

        tempValue = "ReCheck"
        tempValue2 = GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString
        fr = New frmWareChange
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
End Class