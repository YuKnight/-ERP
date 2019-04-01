Imports LFERP.Library.SingleFactory
Imports LFERP.SystemManager

Public Class frmSingleFactoryMain

    Private Sub frmSingleFactoryMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sfc As New SingleFactoryControl
        Grid.DataSource = sfc.SingleFactory_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        LoadPowerUser()
     
    End Sub

    Sub LoadPowerUser()

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "800101")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then SFAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "800102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then SFEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "800103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then SFDel.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "800104")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then SFCheck.Enabled = True
        End If

    End Sub

    Private Sub SFAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SFAdd.Click
        On Error Resume Next
        Edit = False
        Dim fr As frmSingleFactory
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmSingleFactory Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "出廠單"
        fr = New frmSingleFactory
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub

    Private Sub SFEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SFEdit.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim sfi As List(Of SingleFactoryInfo)
        Dim sfc As New SingleFactoryControl
        sfi = sfc.SingleFactory_GetList(GridView1.GetFocusedRowCellValue("SF_ID").ToString, Nothing, Nothing, Nothing, Nothing, Nothing)
        If sfi.Count = 0 Then Exit Sub
        If sfi(0).SF_Check = True Then
            MsgBox("此出廠單已審核，不允許修改！")
            Exit Sub
        Else
            Edit = True
            Dim fr As frmSingleFactory
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmSingleFactory Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue = "出廠單"
            tempValue2 = GridView1.GetFocusedRowCellValue("SF_ID").ToString
            fr = New frmSingleFactory
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
           
        End If

    End Sub

    Private Sub SFDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SFDel.Click
        On Error Resume Next
        Dim sfi As List(Of SingleFactoryInfo)
        Dim sfc As New SingleFactoryControl
        sfi = sfc.SingleFactory_GetList(GridView1.GetFocusedRowCellValue("SF_ID").ToString, Nothing, Nothing, Nothing, Nothing, Nothing)
        If sfi.Count = 0 Then
            Exit Sub
        Else
            If sfi(0).SF_Check = True Then
                MsgBox("此出廠單已被審核，不允許刪除！")
                Exit Sub
            Else
                If MsgBox("確定刪除單號為" & GridView1.GetFocusedRowCellValue("SF_ID").ToString & "的全部記錄？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    If sfc.SingleFactory_Delete(GridView1.GetFocusedRowCellValue("SF_ID").ToString, Nothing, Nothing) = True Then
                        Dim sfi1 As List(Of SingleFactoryInfo)
                        sfi1 = sfc.Packing_GetList(GridView1.GetFocusedRowCellValue("SF_ID").ToString, Nothing, Nothing)
                        If sfi1.Count <> 0 Then
                            Dim j As Integer
                            For j = 0 To sfi1.Count - 1
                                sfc.Packing_Delete(sfi1(j).P_NO, Nothing, Nothing)
                            Next
                            Dim i As Integer
                            For i = 0 To sfi1.Count - 1
                                Dim sfi2 As List(Of SingleFactoryInfo)
                                sfi2 = sfc.PackingSub_GetList(sfi1(i).PB_NO, Nothing)
                                If sfi2.Count <> 0 Then
                                    sfc.PackingSub_Delete(sfi1(i).PB_NO, Nothing)
                                End If
                            Next
                        End If
                        MsgBox("刪除成功！")
                        Grid.DataSource = sfc.SingleFactory_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                    Else
                        MsgBox("刪除失敗,請檢查原因！")
                        Exit Sub
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub SFRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SFRef.Click
        Dim sfc As New SingleFactoryControl
        Grid.DataSource = sfc.SingleFactory_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub SFView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SFView.Click
        On Error Resume Next
        Dim fr As frmSingleFactory
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmSingleFactory Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "PreView"
        tempValue2 = GridView1.GetFocusedRowCellValue("SF_ID").ToString
        fr = New frmSingleFactory
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub SFQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SFQuery.Click
        Dim sfc As New SingleFactoryControl
        Dim frm As New frmSingleFactorySelect
        frm.ShowDialog()
        Grid.DataSource = sfc.SingleFactory_GetList(tempValue2, tempValue3, tempValue4, tempValue6, tempValue7, tempValue5)

        tempValue2 = ""
        tempValue3 = ""
        tempValue4 = ""
        tempValue5 = ""
        tempValue6 = ""
        tempValue7 = ""
    End Sub

    Private Sub SFCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SFCheck.Click
        On Error Resume Next
        Dim fr As frmSingleFactory
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmSingleFactory Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "Check"
        tempValue2 = GridView1.GetFocusedRowCellValue("SF_ID").ToString
        fr = New frmSingleFactory
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
    '列印出廠單報表
    Private Sub SFPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SFPrint.Click

        Dim ds As New DataSet

        If GridView1.RowCount = 0 Then Exit Sub

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet

        Dim sfc As New SingleFactoryControl

        ds.Tables.Clear()

        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("SF_ID").ToString

        ltc.CollToDataSet(ds, "SingleFactory", sfc.SingleFactory_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "Packing", sfc.Packing_GetList(Nothing, Nothing, Nothing))
        ltc2.CollToDataSet(ds, "PackingSub", sfc.PackingSub_GetList(Nothing, Nothing))

        PreviewRPT(ds, "rptSingleFactory", "出廠單", True, True)

        ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing


    End Sub

  
End Class