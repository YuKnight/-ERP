Imports LFERP.Library.MrpManager.MrpMps
Imports LFERP.Library.MrpManager.MrpSetting
Imports LFERP.Library.MrpManager.MrpSelect
Imports LFERP.SystemManager

Public Class frmMrpMpsMain

#Region "属性"
    Dim frm As frmMrpMps
    Dim mmc As New MrpMpsController
    Dim mmec As New MrpMpsEntryController
#End Region

    Private Sub frmMrpMpsMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PowerUser()
        cmsMpsRefresh_Click(Nothing, Nothing)
    End Sub

#Region "設置右擊菜單項是否可用"
    Private Sub GridControl1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridControl1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            SetRightClickMenuEnable()
        End If
    End Sub

    Private Sub SetRightClickMenuEnable()
        Dim mmi As New MrpMpsInfo
        Dim mmiList As New List(Of MrpMpsInfo)
        If GridView1.FocusedRowHandle >= 0 Then
            mmiList = mmc.MrpMps_GetList(GridView1.GetFocusedRowCellValue("MO"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If mmiList.Count > 0 Then
                mmi = mmiList(0)
            Else
                MsgBox(GridView1.GetFocusedRowCellValue("MO") + "的生產單號已被其他用戶刪除", MsgBoxStyle.Information, "提示")
                cmsMpsRefresh_Click(Nothing, Nothing)
                Exit Sub
            End If
        End If
        Try
            Dim c As ToolStripItem
            If GridView1.FocusedRowHandle < 0 Then
                For Each c In cmsMps.Items
                    If (c.Name = "cmsMpsAdd" Or c.Name = "cmsMpsRefresh") Then
                        c.Enabled = True
                    Else
                        c.Enabled = False
                    End If
                Next
            ElseIf mmi.CheckBit.Equals(True) Then
                For Each c In cmsMps.Items
                    If (c.Name = "cmsMpsEdit" Or c.Name = "cmsMpsDel") Then
                        c.Enabled = False
                    Else
                        c.Enabled = True
                    End If
                Next
            Else
                For Each c In cmsMps.Items
                    c.Enabled = True
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "SetRightClickMenuEnable方法出錯")
        End Try
    End Sub
#End Region

#Region "右擊菜單事件"
    Private Sub cmsMps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsMpsAdd.Click, cmsMpsEdit.Click, cmsMpsView.Click, cmsMpsCheck.Click
        frm = New frmMrpMps
        Select Case sender.name
            Case "cmsMpsAdd"
                frm.EditItem = EditEnumType.ADD
            Case "cmsMpsEdit"
                frm.EditItem = EditEnumType.EDIT
                frm.MO = GridView1.GetFocusedRowCellValue("MO").ToString
            Case "cmsMpsView"
                frm.EditItem = EditEnumType.VIEW
                frm.MO = GridView1.GetFocusedRowCellValue("MO").ToString
            Case "cmsMpsCheck"
                frm.EditItem = EditEnumType.CHECK
                frm.MO = GridView1.GetFocusedRowCellValue("MO").ToString
        End Select
        frm.MdiParent = MDIMain
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub cmsMpsDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsMpsDel.Click
        Dim bo As Boolean
        Dim MO As String = GridView1.GetFocusedRowCellValue("MO").ToString
        If MsgBox("是否確定刪除生產單號：" + MO, MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
            bo = mmc.MrpMps_Delete(MO)
            bo = bo And mmec.MrpMpsEntry_Delete(Nothing, MO)
            If bo = True Then
                GridView1.DeleteRow(GridView1.FocusedRowHandle)
                MsgBox("刪除成功", MsgBoxStyle.Information, "提示")
            Else
                MsgBox("刪除失敗", MsgBoxStyle.Information, "提示")
            End If
        End If
    End Sub

    Private Sub cmsMpsRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsMpsRefresh.Click
        Try
            Dim msi As New List(Of MrpSettingInfo)
            Dim micon As New MrpMpsController
            Dim mscon As New MrpSettingController
            msi = mscon.MrpSetting_GetList(InUserID)
            Dim strIsCheck As String = String.Empty
            If msi.Count > 0 Then
                Select Case msi(0).MrpMpsCheckType
                    Case "0,1"
                        strIsCheck = Nothing
                    Case "0"
                        strIsCheck = "False"
                    Case "1"
                        strIsCheck = "True"
                End Select
                If msi(0).MrpMpsCreateUserID = "All" Then
                    msi(0).MrpMpsCreateUserID = Nothing
                End If
                GridControl1.DataSource = micon.MrpMps_GetList(Nothing, Nothing, strIsCheck, msi(0).MrpMpsBeginDate, Nothing, msi(0).MrpMpsCreateUserID, msi(0).MrpMpsDisplayNum)
            Else
                GridControl1.DataSource = micon.MrpMps_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            End If
            GridView1_FocusedRowChanged(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "cmsMpsRefresh_Click方法出錯")
        End Try
    End Sub

#End Region

    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            SetRightClickMenuEnable()
            If GridView1.FocusedRowHandle < 0 Then
                Grid2.DataSource = Nothing
            Else
                Dim MO As String = IIf(GridView1.GetFocusedRowCellValue("MO") = Nothing, "", GridView1.GetFocusedRowCellValue("MO").ToString)
                Grid2.DataSource = mmec.MrpMpsEntry_GetList(MO)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub tsm_PrintMMAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_PrintMMAll.Click
        On Error Resume Next
        Dim fr As MrpReportSelect
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is MrpReportSelect Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New MrpReportSelect
        fr.intShowPage = 7
        'fr.MdiParent = MDIMain
        'fr.WindowState = FormWindowState.Maximized

        fr.ShowDialog()
        fr.Focus()
    End Sub

    Private Sub tsm_PrintMMInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_PrintMMInfo.Click
        Try
            Dim MrpSetCon As New MrpSettingController
            Dim MrpSet As New MrpSettingInfo
            If MrpSetCon.MrpSetting_GetList(InUserID).Count > 0 Then
                MrpSet = MrpSetCon.MrpSetting_GetList(InUserID)(0)
            Else
                MrpSet.MrpMpsBeginDate = Year(Now) & "/01/01"
            End If

            Dim dss As New DataSet
            Dim ltc1 As New CollectionToDataSet
            Dim ltc2 As New CollectionToDataSet
            Dim StrSend As String = String.Empty
            StrSend = InUser
            ltc1.CollToDataSet(dss, "MrpMps", mmc.MrpMps_GetList(GridView1.GetFocusedRowCellValue("MO"), Nothing, Nothing, MrpSet.MrpMpsBeginDate, Nothing, Nothing, Nothing))
            ltc2.CollToDataSet(dss, "MrpMpsEntry", mmec.MrpMpsEntry_GetList(GridView1.GetFocusedRowCellValue("MO")))
            PreviewRPT1(dss, "rptMrpMpsInfo", StrSend, StrSend, "表", True, True)
            ltc1 = Nothing
            ltc2 = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmsMpsSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsMpsSelect.Click
        'Dim fr As New frmSelect
        ''fr.FormText = "MRP生產計劃"
        ''fr.TableName = "MrpMps"
        ''fr.ID = "MO"
        'fr.ShowDialog()
        'Dim sc As New Select_Controller
        'If String.IsNullOrEmpty(tempValue) = False Then
        '    GridControl1.DataSource = sc.MrpMps_GetList(tempValue)
        'End If
    End Sub

#Region "導出Excel"
    Private Sub cmsExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsExcel.Click, cmsSubExcel.Click
        If sender.Owner Is cmsMps Then
            ConrotlExportExcel(GridControl1)
        Else
            ConrotlExportExcel(Grid2)
        End If
    End Sub
#End Region
#Region "設置權限"
    '設置權限
    Sub PowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "48040101")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsMpsAdd.Visible = True
                cmsMpsAdd.Enabled = True
            End If

        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "48040102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsMpsEdit.Visible = True
                cmsMpsEdit.Enabled = True
            End If

        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "48040103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsMpsDel.Visible = True
                cmsMpsDel.Enabled = True
            End If

        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "48040104")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsMpsCheck.Visible = True
                cmsMpsCheck.Enabled = True
            End If

        End If
    End Sub
#End Region
End Class