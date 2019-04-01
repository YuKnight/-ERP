Imports LFERP.Library.Purchase.ApplyPurchase
Imports LFERP.SystemManager


Public Class frmApplyPurchaseMain

    Dim apc As New ApplyPurchaseControl

    Private Sub frmApplyPurchaseMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Grid1.DataSource = apc.ApplyPurchase_GetList(Nothing, Nothing, Nothing)
    End Sub

    Private Sub frmApplyPurchaseMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Grid1.DataSource = apc.ApplyPurchase_GetList(Nothing, Nothing, Nothing)
        LoadUserPower()
    End Sub

    Sub LoadUserPower()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400601")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdAdd.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400602")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdEdit.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400603")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdDel.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400604")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdCheck.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400605")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdReCheck.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400606")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdHandle.Enabled = True
        End If

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        On Error Resume Next
        Edit = False
        Dim fr As frmApplyPurchase
        'Dim fr As Form
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmApplyPurchase Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "申購單"
        fr = New frmApplyPurchase
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub
        Dim ai As List(Of ApplyPurchaseInfo)
        Dim ac As New ApplyPurchaseControl
        ai = ac.ApplyPurchase_GetList(GridView1.GetFocusedRowCellValue("AP_ID").ToString, Nothing, Nothing)
        If ai(0).AP_Check = True Then
            MsgBox("此申購單已審核，不允許修改!", 64, "提示")
            Exit Sub
        Else
            Edit = True
            Dim fr As frmApplyPurchase
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmApplyPurchase Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue = "申購單"
            tempValue3 = GridView1.GetFocusedRowCellValue("AP_ID").ToString
            fr = New frmApplyPurchase
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If

    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim api As New ApplyPurchaseInfo
        Dim apc As New ApplyPurchaseControl
        api = apc.ApplyPurchase_Get(GridView1.GetFocusedRowCellValue("AP_Num").ToString)

        If api.AP_Check = False Then
            If MsgBox("確定刪除單號為" & GridView1.GetFocusedRowCellValue("AP_ID").ToString & "的全部記錄？", MsgBoxStyle.YesNo + vbQuestion, "提示") = MsgBoxResult.Yes Then
                If apc.ApplyPurchase_Delete(api.AP_ID, Nothing) = True Then
                    MsgBox("刪除成功!", 64, "提示")
                    Grid1.DataSource = apc.ApplyPurchase_GetList(Nothing, Nothing, Nothing)

                End If
            End If
        Else
            MsgBox("此申購單已審核，不允許刪除!", 64, "提示")
        End If

    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub

        Dim fr As frmApplyPurchase
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmApplyPurchase Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "查看"
        tempValue3 = GridView1.GetFocusedRowCellValue("AP_ID").ToString
        fr = New frmApplyPurchase
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub

    Private Sub cmdCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheck.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub
        Dim ai As List(Of ApplyPurchaseInfo)
        Dim ac As New ApplyPurchaseControl
        ai = ac.ApplyPurchase_GetList(GridView1.GetFocusedRowCellValue("AP_ID").ToString, Nothing, Nothing)
        If ai(0).AP_Check = True Then
            MsgBox("此申購單已審核，不需再審核！", 64, "提示")
            Exit Sub
        Else
            Dim fr As frmApplyPurchase
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmApplyPurchase Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue = "審核"
            tempValue3 = GridView1.GetFocusedRowCellValue("AP_ID").ToString
            fr = New frmApplyPurchase
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If

    End Sub

    Private Sub cmdReCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReCheck.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub
        Dim ai As List(Of ApplyPurchaseInfo)
        Dim ac As New ApplyPurchaseControl
        ai = ac.ApplyPurchase_GetList(GridView1.GetFocusedRowCellValue("AP_ID").ToString, Nothing, Nothing)
        If ai(0).AP_Check = False Then
            MsgBox("此申購單還未審核，不允許復核！", 64, "提示")
            Exit Sub
        ElseIf ai(0).AP_ReCheck = True Then
            MsgBox("此申購單還已復核，不需再復核！", 64, "提示")
            Exit Sub
        Else

            Dim fr As frmApplyPurchase
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmApplyPurchase Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue = "復核"
            tempValue3 = GridView1.GetFocusedRowCellValue("AP_ID").ToString
            fr = New frmApplyPurchase
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub

    Private Sub cmdRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRef.Click
        Grid1.DataSource = apc.ApplyPurchase_GetList(Nothing, Nothing, Nothing)
    End Sub

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        Dim api As New ApplyPurchaseInfo
        Dim apc As New ApplyPurchaseControl
        tempAPID = ""
        tempAPCode = ""
        tempAPName = ""
        tempAPGauge = ""
        tempAPDPTID = ""
        tempAPDateStart = ""
        tempAPDateEnd = ""
        frmApplyPurchaseSelect.ShowDialog()
        If tempAPID <> "" Or tempAPCode <> "" Or tempAPName <> "" Or tempAPGauge <> "" Or tempAPDPTID <> "" Or tempAPDateStart <> "" Or tempAPDateEnd <> "" Then
            Grid1.DataSource = apc.ApplyPurchase_GetList1(tempAPID, tempAPCode, tempAPName, tempAPGauge, tempAPDPTID, tempAPDateStart, tempAPDateEnd)
            tempAPID = ""
            tempAPCode = ""
            tempAPName = ""
            tempAPGauge = ""
            tempAPDPTID = ""
            tempAPDateStart = ""
            tempAPDateEnd = ""
        End If

    End Sub

    Private Sub cmdHandle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHandle.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub
        Dim ai As List(Of ApplyPurchaseInfo)
        Dim ac As New ApplyPurchaseControl
        Dim i As Integer
        ai = ac.ApplyPurchase_GetList(GridView1.GetFocusedRowCellValue("AP_ID").ToString, Nothing, Nothing)
        For i = 0 To ai.Count - 1
            If ai(i).AP_M_Code = "" And ai(i).AP_Check = True And ai(i).AP_CheckWare = True Then
                Dim fr As frmApplyPurchase
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmApplyPurchase Then
                        fr.Activate()
                        Exit Sub
                    End If
                Next
                tempValue = "申購單處理"
                tempValue3 = GridView1.GetFocusedRowCellValue("AP_ID").ToString
                fr = New frmApplyPurchase
                fr.MdiParent = MDIMain
                fr.WindowState = FormWindowState.Maximized
                fr.Show()
                Exit Sub
            End If
        Next
        MsgBox("此申購單不需處理!", 64, "提示")
    End Sub

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click

        If GridView1.RowCount = 0 Then Exit Sub

        Dim pmc As New LFERP.Library.Purchase.Purchase.PurchaseMainController

        If GridView1.GetFocusedRowCellValue("AP_M_Code").ToString() <> "" Then
            Grid2.DataSource = pmc.PurchaseSub_GetList("", GridView1.GetFocusedRowCellValue("AP_ID").ToString, GridView1.GetFocusedRowCellValue("AP_M_Code").ToString)
        Else
            Grid2.DataSource = Nothing
        End If
    End Sub

End Class