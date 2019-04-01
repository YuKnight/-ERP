Imports LFERP.Library.ProductionKaiLiao
Imports LFERP.SystemManager
Imports LFERP.Library.WareHouse.WareOut
Imports LFERP.DataSetting
Public Class frmProductionKaiLiaoMain
    Dim pkc As New ProductionKaiLiaoControl
    Dim strDPT As String

    Private Sub frmProductionKaiLiaoMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ui As List(Of UserPowerInfo)
        Dim uc As New UserPowerControl
        ui = uc.UserPower_GetList(InUserID, Nothing, Nothing, Nothing)

        If ui.Count = 0 Then
            Exit Sub
        Else
            If ui(0).UserRank = "管理" Then
                strDPT = Nothing
            Else
                strDPT = Mid(ui(0).DepID, 1, 1)
            End If
        End If
        ' Grid.DataSource = pkc.ProductionKaiLiao_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strDPT)
        Grid.DataSource = pkc.ProductionKaiLiaoA_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strDPT, Nothing, Nothing, Nothing, Nothing)
        PowerUser()
    End Sub
    '設置權限
    Sub PowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880201")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsProductionAdd.Enabled = True
                cmsProductionAddA.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880202")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsProductionEdit.Enabled = True
                cmsProductionEditA.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880203")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsProductionDel.Enabled = True
                cmsProductionDelA.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880204")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsProductionCheck.Enabled = True
                cmsProductionCheckA.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880205")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsProductionPrint.Enabled = True
                cmsProductionPrintA.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880207")
        Me.Grid.ContextMenuStrip = Me.cmsProductionKaiLiao
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                Me.Grid.ContextMenuStrip = Me.cmsProductionKaiLiaoA
                Me.C_Number.Visible = True
            Else
                Me.Grid.ContextMenuStrip = Me.cmsProductionKaiLiao
                Me.C_Number.Visible = False
            End If
        End If
    End Sub

    '新增開料單
    Private Sub cmsProductionAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionAdd.Click
        On Error Resume Next
        Edit = False

        Dim fr As frmProductionKaiLiao
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionKaiLiao Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "開料單"
        fr = New frmProductionKaiLiao
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    '修改開料單
    Private Sub cmsProductionEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionEdit.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As List(Of ProductionKaiLiaoInfo)
        pi = pkc.ProductionKaiLiao_GetList(GridView1.GetFocusedRowCellValue("C_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pi(0).C_Check = True Then
            MsgBox("此開料單已被審核,不允許修改")
            Exit Sub
        Else
            Edit = True
            Dim fr As frmProductionKaiLiao
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionKaiLiao Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue2 = "開料單"
            tempValue3 = GridView1.GetFocusedRowCellValue("C_NO").ToString
            fr = New frmProductionKaiLiao
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub

    '刪除開料單
    Private Sub cmsProductionDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As List(Of ProductionKaiLiaoInfo)
        pi = pkc.ProductionKaiLiao_GetList(GridView1.GetFocusedRowCellValue("C_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pi(0).C_Check = True Then
            MsgBox("此開料單已被審核,不允許刪除")
            Exit Sub
        Else
            If MsgBox("確定要刪除編號為" & GridView1.GetFocusedRowCellValue("C_NO").ToString & "的開料單嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.Yes Then
                If pkc.ProductionKaiLiao_Delete(GridView1.GetFocusedRowCellValue("C_NO").ToString, Nothing) = True Then
                    MsgBox("刪除當前開料單成功!")
                Else
                    MsgBox("刪除失敗,請檢查原因!")
                End If
                Grid.DataSource = pkc.ProductionKaiLiao_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strDPT)
            End If
        End If
    End Sub

    '查詢
    Private Sub cmsProductionSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionSelect.Click
        Dim frm As New frmProductionKaiLiaoSelect
        frm.ShowDialog()

        If tempValue = "單擊查詢按鈕" Then
            Grid.DataSource = pkc.ProductionKaiLiao_GetList(tempValue2, tempValue3, tempValue6, Nothing, tempValue7, tempValue4, tempValue5, tempValue8, tempValue9, Nothing, strDPT)
        End If
        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing
        tempValue7 = Nothing
        tempValue8 = Nothing
        tempValue9 = Nothing

    End Sub

    '查看當前開料單
    Private Sub cmsProductionView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionView.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As frmProductionKaiLiao
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionKaiLiao Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "PreView"
        tempValue3 = GridView1.GetFocusedRowCellValue("C_NO").ToString
        fr = New frmProductionKaiLiao
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    '刷新操作
    Private Sub cmsProductionRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionRef.Click
        Grid.DataSource = pkc.ProductionKaiLiaoA_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strDPT, Nothing, Nothing, Nothing, Nothing)
    End Sub

    '審核當前開料單
    Private Sub cmsProductionCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionCheck.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim pi As List(Of ProductionKaiLiaoInfo)
        pi = pkc.ProductionKaiLiao_GetList(GridView1.GetFocusedRowCellValue("C_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pi.Count = 0 Then Exit Sub

        If pi(0).C_Check = True Then

            Dim wic As New WareOutController
            Dim wi As List(Of WareOutInfo)

            wi = wic.WareOut_ProductionGetList(Nothing, GridView1.GetFocusedRowCellValue("C_NO").ToString)

            If wi.Count = 0 Then
                Dim fr As frmProductionKaiLiao
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmProductionKaiLiao Then
                        fr.Activate()
                        Exit Sub
                    End If
                Next
                tempValue2 = "Check"
                tempValue3 = GridView1.GetFocusedRowCellValue("C_NO").ToString
                fr = New frmProductionKaiLiao
                fr.MdiParent = MDIMain
                fr.WindowState = FormWindowState.Maximized
                fr.Show()
            Else
                MsgBox("在倉庫已存在此領料單號記錄,不允許取消！")
                Exit Sub
            End If

        Else

            Dim fr As frmProductionKaiLiao
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionKaiLiao Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue2 = "Check"
            tempValue3 = GridView1.GetFocusedRowCellValue("C_NO").ToString
            fr = New frmProductionKaiLiao
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If

    End Sub

    '列印當前開料單
    Private Sub cmsProductionPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionPrint.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim ds As New DataSet
        Dim ltc As New CollectionToDataSet

        ds.Tables.Clear()
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("C_NO").ToString
        Dim pki As List(Of ProductionKaiLiaoInfo)

        pki = pkc.ProductionKaiLiao_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pki.Count = 0 Then
            MsgBox("當前無此開料單記錄!")
            Exit Sub
        End If

        ltc.CollToDataSet(ds, "ProductionKaiLiao", pkc.ProductionKaiLiao_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

        If pki(0).C_Check = True Then
            PreviewRPT(ds, "rptProductionKaiLiao", "開料單", True, True)
        Else
            PreviewRPT(ds, "rptProductionKaiLiao", "開料單", True, False)

        End If
        ltc = Nothing
    End Sub

    '主要針對從倉庫領回物料后部門領走記錄信息（一次或多次記錄信息直至結單為止!）
    Private Sub cmsOutPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsOutPrint.Click
        If GridView1.RowCount = 0 Then Exit Sub

        tempValue = GridView1.GetFocusedRowCellValue("C_NO").ToString
        Dim frm As New frmOutPrint
        frm.ShowDialog()
    End Sub

    Private Sub cmsProductionAddA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionAddA.Click
        On Error Resume Next
        Edit = False

        Dim fr As frmProductionKaiLiaoA
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionKaiLiaoA Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "開料單"
        fr = New frmProductionKaiLiaoA
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmsProductionViewA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionViewA.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As frmProductionKaiLiaoA
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionKaiLiaoA Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "PreView"
        tempValue3 = GridView1.GetFocusedRowCellValue("C_Number").ToString
        fr = New frmProductionKaiLiaoA
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmsProductionCheckA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionCheckA.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim pi As List(Of ProductionKaiLiaoInfo)
        pi = pkc.ProductionKaiLiaoA_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("C_Number").ToString, Nothing, Nothing, Nothing)

        If pi.Count = 0 Then Exit Sub

        If pi(0).C_Check = True Then
            Dim wic As New WareOutController
            Dim wi As List(Of WareOutInfo)
            wi = wic.WareOut_ProductionGetList(Nothing, GridView1.GetFocusedRowCellValue("C_NO").ToString)

            If wi.Count = 0 Then
                Dim fr As frmProductionKaiLiaoA
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmProductionKaiLiaoA Then
                        fr.Activate()
                        Exit Sub
                    End If
                Next
                tempValue2 = "Check"
                tempValue3 = GridView1.GetFocusedRowCellValue("C_Number").ToString
                fr = New frmProductionKaiLiaoA
                fr.MdiParent = MDIMain
                fr.WindowState = FormWindowState.Maximized
                fr.Show()
            Else
                MsgBox("在倉庫已存在此領料單號記錄,不允許取消！")
                Exit Sub
            End If
        Else

            Dim fr As frmProductionKaiLiaoA
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionKaiLiaoA Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue2 = "Check"
            tempValue3 = GridView1.GetFocusedRowCellValue("C_Number").ToString
            fr = New frmProductionKaiLiaoA
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub

    Private Sub cmsProductionRefA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionRefA.Click
        Grid.DataSource = pkc.ProductionKaiLiaoA_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strDPT, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub cmsProductionDelA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionDelA.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As List(Of ProductionKaiLiaoInfo)
        pi = pkc.ProductionKaiLiaoA_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("C_Number").ToString, Nothing, Nothing, Nothing)

        If pi(0).C_Check = True Then
            MsgBox("此開料單已被審核,不允許刪除")
            Exit Sub
        Else
            If MsgBox("確定要刪除編號為" & GridView1.GetFocusedRowCellValue("C_Number").ToString & "的開料單號嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.Yes Then
                If pkc.ProductionKaiLiaoA_Delete(GridView1.GetFocusedRowCellValue("C_Number").ToString, Nothing) = True Then
                    MsgBox("刪除當前開料單成功!")
                Else
                    MsgBox("刪除失敗,請檢查原因!")
                End If
                Grid.DataSource = pkc.ProductionKaiLiaoA_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strDPT, Nothing, Nothing, Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub cmsProductionEditA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionEditA.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As List(Of ProductionKaiLiaoInfo)
        pi = pkc.ProductionKaiLiaoA_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("C_Number").ToString, Nothing, Nothing, Nothing)
        If pi(0).C_Check = True Then
            MsgBox("此開料單已被審核,不允許修改")
            Exit Sub
        Else
            Edit = True
            Dim fr As frmProductionKaiLiaoA
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionKaiLiaoA Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue2 = "開料單"
            tempValue3 = GridView1.GetFocusedRowCellValue("C_Number").ToString
            fr = New frmProductionKaiLiaoA
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub

    Private Sub cmsProductionPrintA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionPrintA.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim ds As New DataSet
        Dim ltc As New CollectionToDataSet

        ds.Tables.Clear()
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("C_NO").ToString
        Dim pki As List(Of ProductionKaiLiaoInfo)

        pki = pkc.ProductionKaiLiao_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pki.Count = 0 Then
            MsgBox("當前無此開料單記錄!")
            Exit Sub
        End If

        ltc.CollToDataSet(ds, "ProductionKaiLiao", pkc.ProductionKaiLiao_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

        If pki(0).C_Check = True Then
            PreviewRPT(ds, "rptProductionKaiLiao", "開料單", True, True)
        Else
            PreviewRPT(ds, "rptProductionKaiLiao", "開料單", True, False)

        End If

        ltc = Nothing
    End Sub

    Private Sub cmsProductionSelectA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionSelectA.Click
        Dim frm As New frmProductionKaiLiaoSelect
        frm.ShowDialog()

        If tempValue = "單擊查詢按鈕" Then
            Grid.DataSource = pkc.ProductionKaiLiao_GetList(tempValue2, tempValue3, tempValue6, Nothing, tempValue7, tempValue4, tempValue5, tempValue8, tempValue9, Nothing, strDPT)
        End If
        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing
        tempValue7 = Nothing
        tempValue8 = Nothing
        tempValue9 = Nothing
    End Sub

    Private Sub cmsOutPrintA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsOutPrintA.Click
        If GridView1.RowCount = 0 Then Exit Sub

        tempValue = GridView1.GetFocusedRowCellValue("C_NO").ToString
        Dim frm As New frmOutPrint
        frm.ShowDialog()
    End Sub
End Class