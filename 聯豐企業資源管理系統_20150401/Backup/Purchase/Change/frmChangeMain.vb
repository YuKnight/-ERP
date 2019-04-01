Imports LFERP.Library.Purchase.Change
Imports LFERP.SystemManager
Imports LFERP.FileManager

Public Class frmChangeMain

    Dim ci As New ChangeInfo
    Dim cc As New ChangeControl

    Private Sub frmChangeMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Grid1.DataSource = cc.Change_GetList(Nothing, Nothing, Nothing, False)
        LoadUserPower()
    End Sub
    Sub LoadUserPower()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400501")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                popChangeAdd.Enabled = True
                'popChangePurchaseAdd.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400502")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popChangeEdit.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400503")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popChangeDel.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400504")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popChangeCheck.Enabled = True
        End If
    End Sub
    ''' <summary>
    ''' 暫改
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub popChangeAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeAdd.Click
        On Error Resume Next
        Edit = False
     
        tempValue = "更改單"
        tempValue4 = "更改未交數"
        tempValue3 = ""
        'Dim myfrm As New frmChange
        'myfrm.ShowDialog()
        CheckForm(frmChange, frmChange.Name)

    End Sub
    ''' <summary>
    ''' 修改
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub popChangeEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeEdit.Click
        On Error Resume Next
        Edit = True
        If GridView1.RowCount = 0 Then Exit Sub
        Dim ci1 As List(Of ChangeInfo)
        ci1 = cc.Change_GetList(GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, Nothing, Nothing, Nothing)
        If ci1(0).C_Check = True Then
            MsgBox("此更改單已審核，不允許修改")
            Exit Sub
        Else

            tempValue = "更改單"
            tempValue3 = GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString
            tempValue4 = GridView1.GetFocusedRowCellValue("C_Type").ToString
            Dim myfrm As New frmChange
            myfrm.MdiParent = MDIMain
            myfrm.WindowState = FormWindowState.Maximized
            myfrm.Show()

        End If

    End Sub
    ''' <summary>
    ''' 刪除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub popChangeDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim ci1 As List(Of ChangeInfo)
        ci1 = cc.Change_GetList(GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, Nothing, Nothing, Nothing)
        If ci1(0).C_Check = True Then
            MsgBox("此更改單已審核。不允許刪除！")
            Exit Sub
        Else
            If MsgBox("確定刪除單號為" & GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString & "的全部記錄？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                If cc.Change_Del(ci1(0).C_ChangeNO, Nothing) = True Then
                    '****刪除附檔
                    Dim dt As New FileController
                    Dim ldt As New List(Of FilesInfo)
                    Dim ii As Integer
                    ldt = dt.FileBond_GetList("4005", GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, Nothing)
                    If ldt.Count > 0 Then
                        For ii = 0 To ldt.Count - 1
                            dt.File_Delete("4005", GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, ldt(ii).F_No)
                        Next
                    End If
                    '******

                    MsgBox("刪除成功！")
                    Grid1.DataSource = cc.Change_GetList(Nothing, Nothing, Nothing, False)
                Else
                    MsgBox("刪除失敗，請檢查原因！")
                    Exit Sub
                End If
            End If

        End If
    End Sub
    ''' <summary>
    ''' 查看
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub popChangeView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeView.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub

       
        tempValue = "查看"
        tempValue3 = GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString
        Dim myfrm As New frmChange
        myfrm.MdiParent = MDIMain
        myfrm.WindowState = FormWindowState.Maximized
        myfrm.Show()
        
    End Sub
    ''' <summary>
    ''' 審核
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub popChangeCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeCheck.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub
        Dim ci1 As List(Of ChangeInfo)

        Dim dt As New FileController
        Dim di As List(Of FilesInfo)

        di = dt.FileBond_GetList("4005", GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, Nothing)
        If di.Count = 0 Then
            MsgBox("此更改單沒有附檔,不允許審核,請載入附檔！")
            Exit Sub
        Else
            ci1 = cc.Change_GetList(GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, Nothing, Nothing, Nothing)
            If ci1(0).C_Check = True Then
                MsgBox("此更改單已審核，不允許再操作！")
                Exit Sub
            Else
                tempValue = "審核"
                tempValue3 = GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString
                tempValue4 = GridView1.GetFocusedRowCellValue("C_Type").ToString
                Dim myfrm As New frmChange
                myfrm.MdiParent = MDIMain
                myfrm.WindowState = FormWindowState.Maximized
                myfrm.Show()
            End If
        End If
      

    End Sub
    ''' <summary>
    ''' 刷新
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub popChangeRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeRef.Click
        Grid1.DataSource = cc.Change_GetList(Nothing, Nothing, Nothing, False)
    End Sub
    ''' <summary>
    ''' 附加文件
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub popChangeFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeFile.Click
        Dim open, update, down, edit, del, detail As Boolean
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As New List(Of PermissionModuleWarrantSubInfo)

        If GridView1.RowCount = 0 Then Exit Sub
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400505")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then update = True
            If pmwiL.Item(0).PMWS_Value = "否" Then update = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400506")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then down = True
            If pmwiL.Item(0).PMWS_Value = "否" Then down = False
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400507")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then edit = True
            If pmwiL.Item(0).PMWS_Value = "否" Then edit = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400508")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then del = True
            If pmwiL.Item(0).PMWS_Value = "否" Then del = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400509")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then detail = True
            If pmwiL.Item(0).PMWS_Value = "否" Then detail = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400510")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then open = True
            If pmwiL.Item(0).PMWS_Value = "否" Then open = False
        End If

        FileShow("4005", GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, open, update, down, edit, del, detail)
    End Sub
    ''' <summary>
    ''' 查詢
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub popChangeSeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeSeek.Click
        Dim myFrm As New frmChangeSelect
        myFrm.ShowDialog()
        Select Case tempValue
            Case "1"
                Grid1.DataSource = cc.Change_GetList(Nothing, tempValue2, Nothing, Nothing)
            Case "2"
                Grid1.DataSource = cc.Change_GetList(Nothing, Nothing, tempValue2, Nothing)
            Case "3"
                Grid1.DataSource = cc.Change_GetList(tempValue2, Nothing, Nothing, Nothing)
            Case "4"
                If tempValue2 = "已審核" Then
                    Grid1.DataSource = cc.Change_GetList(Nothing, Nothing, Nothing, True)
                ElseIf tempValue2 = "未審核" Then
                    Grid1.DataSource = cc.Change_GetList(Nothing, Nothing, Nothing, False)
                End If
        End Select
        tempValue = ""
        tempValue2 = ""
    End Sub
    '發送消息---查看
    Private Sub popMsgView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popMsgView.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub

        Dim fr As frmMessageSent
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMessageSent Then
                fr.Activate()
                Exit Sub
            End If
        Next

        tempValue = "新增"                                                              '凡是其他模塊調用信息的頁面前的參數都為新增，
        tempValue3 = "採購單" & GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString & "查看"      ' 附件名
        tempValue4 = GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString               ' 單據ID
        tempValue5 = "4005"                                                         '   模塊ID
        tempValue6 = "查看"                                                         '發送類型

        fr = New frmMessageSent
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
    '發送消息---審核
    Private Sub popMsgCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popMsgCheck.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub

        Dim ci1 As List(Of ChangeInfo)
        ci1 = cc.Change_GetList(GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, Nothing, Nothing, Nothing)
        If ci1(0).C_Check = True Then
            MsgBox("此更改單已審核，不允許再操作！")
            Exit Sub
        Else
            Dim fr As frmMessageSent
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmMessageSent Then
                    fr.Activate()
                    Exit Sub
                End If
            Next

            tempValue = "新增"                                                              '凡是其他模塊調用信息的頁面前的參數都為新增，
            tempValue3 = "採購單" & GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString & "部門審核"     ' 附件名
            tempValue4 = GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString               ' 單據ID
            tempValue5 = "4005"                                                         '   模塊ID
            tempValue6 = "部門審核"                                                         '發送類型


            fr = New frmMessageSent
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub
    '列印更改單報表
    Private Sub popChangePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangePrint.Click
        Dim ds As New DataSet
        If GridView1.RowCount = 0 Then Exit Sub

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        'Dim ltc2 As New CollectionToDataSet
        'Dim ltc3 As New CollectionToDataSet
        'Dim ltc4 As New CollectionToDataSet

        Dim Mcc As New LFERP.Library.Material.MaterialController
        Dim Cmc As New LFERP.Library.Purchase.Change.ChangeControl
        Dim suc As New LFERP.SystemManager.SystemUser.SystemUserController
        Dim sc As New LFERP.DataSetting.SuppliersControler

        ds.Tables.Clear()

        ltc.CollToDataSet(ds, "MaterialCode", Mcc.MaterialCode_GetList(Nothing, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "Change", Cmc.Change_GetList(GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, Nothing, Nothing, Nothing))
        'ltc2.CollToDataSet(ds, "SystemUser", suc.SystemUser_GetList(Nothing, Nothing, Nothing))
        'ltc4.CollToDataSet(ds, "Suppliers", sc.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing))

        PreviewRPT(ds, "rptChangeMain", " 更改單--" & GridView1.GetFocusedRowCellValue("C_ChangeNO").ToString, True, True)

        ltc = Nothing
        ltc1 = Nothing
        'ltc4 = Nothing
        'ltc2 = Nothing
        'ltc3 = Nothing

    End Sub

    '更改採購單中採購數量
    Private Sub popChangePurchaseAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangePurchaseAdd.Click
        On Error Resume Next
        Edit = False

        tempValue = "更改單"
        tempValue4 = "更改採購數"
        tempValue3 = ""
        'Dim myfrm As New frmChange
        'myfrm.MdiParent = MDIMain
        'myfrm.WindowState = FormWindowState.Maximized
        'myfrm.Show()
        CheckForm(frmChange, frmChange.Name)
    End Sub
End Class