Imports LFERP.FileManager
Imports LFERP.Library.Purchase
Imports LFERP.Library.Purchase.Acceptance
Imports LFERP.Library.Purchase.Retrocede
Imports LFERP.SystemManager
Imports LFERP.Library.Purchase.purselect
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core

Public Class frmManualPurchaseMain

    Private Sub frmManualPurchaseMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mc As New Purchase.PurchaseMainController
        'Grid.AutoGenerateColumns = False

        '***判斷用戶是擁有特殊類的權限
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        Dim tesuvalue As String
        tesuvalue = "否"
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100115")
        If pmwiL.Item(0).PMWS_Value = "是" Then
            tesuvalue = "是"
        End If

        '************


        Dim pmwil1 As List(Of PermissionModuleWarrantSubInfo)
        Dim strTemp As String = ""
        pmwil1 = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400817")
        strTemp = pmwil1.Item(0).PMWS_Value
        Select Case strTemp

            Case "非采購人員"
                Grid1.DataSource = Nothing
                PS_Price.Visible = False
                PS_Price.VisibleIndex = -1

            Case "采購員"
                Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, InUserID, "手開採購單", Nothing, Nothing, False, tesuvalue)
            Case "采購主管"
                Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "手開採購單", False, Nothing, Nothing, tesuvalue)
            Case "會計部"
                Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "手開採購單", True, False, Nothing, tesuvalue)
            Case "管理員"
                Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "手開採購單", Nothing, Nothing, Nothing, tesuvalue)
        End Select
        LoadUserPower1()
        Label1.Text = "采購管理--手開採購單"

        Me.Text = Label1.Text

    End Sub
    Sub LoadUserPower1()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400801")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPurchaseNew.Enabled = True
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400802")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPurchaseEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400803")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPurchaseDel.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400804")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPurchaseCheck.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400805")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPurchaseAccCheck.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400806")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPurchaseSend.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400807")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPurchasePrint.Enabled = True
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400808")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPurchasePrintEng.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400809")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then PurchaseRead.Enabled = True
        End If
    End Sub
    Private Sub popPurchaseNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPurchaseNew.Click
        On Error Resume Next

        Edit = False
        Dim fr As frmPurchase
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmPurchase Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "採購單"
        tempValue3 = "手開採購單"
        fr = New frmPurchase
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popPurchaseEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPurchaseEdit.Click
        On Error Resume Next

        If GridView2.RowCount = 0 Then Exit Sub

        Dim pc As New Purchase.PurchaseMainController
        Dim pi As New Purchase.PurchaseMainInfo
        pi = pc.PurchaseMain_Get(GridView2.GetFocusedRowCellValue("PM_NO").ToString)

        If (IsDBNull(pi.PM_AccountCheck) = True And IsDBNull(pi.PM_Check) = True) Or (pi.PM_AccountCheck = False And pi.PM_Check = False) Then
            If GridView1.RowCount = 0 And GridView3.RowCount = 0 Then
                Edit = True

                Dim fr As frmPurchase
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmPurchase Then
                        fr.Activate()
                        Exit Sub
                    End If
                Next

                tempValue2 = "採購單"
                tempValue3 = "手開採購單"
                tempValue = GridView2.GetFocusedRowCellValue("PM_NO").ToString
                fr = New frmPurchase
                fr.MdiParent = MDIMain
                fr.WindowState = FormWindowState.Maximized
                fr.Show()
            Else
                MsgBox("此採購單已有送貨/退貨記錄，不能修改")
                Exit Sub
            End If
        Else
            MsgBox("此單已被審核，不允許修改")
            Exit Sub
        End If
    End Sub

    Private Sub popPurchaseDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPurchaseDel.Click
        If GridView2.RowCount = 0 Then Exit Sub

        Dim pc As New Purchase.PurchaseMainController
        Dim pi As New Purchase.PurchaseMainInfo

        '***判斷用戶是擁有特殊類的權限
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        Dim tesuvalue As String
        tesuvalue = "否"
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100115")
        If pmwiL.Item(0).PMWS_Value = "是" Then
            tesuvalue = "是"
        End If

        '************

        pi = pc.PurchaseMain_Get(GridView2.GetFocusedRowCellValue("PM_NO").ToString)
        'If pi.PM_AccountCheckAction = Nothing And pi.PM_CheckAction = Nothing Then
        If (IsDBNull(pi.PM_AccountCheck) = True And IsDBNull(pi.PM_Check) = True) Or (pi.PM_AccountCheck = False And pi.PM_Check = False) Then

            If GridView4.RowCount = 0 Then
                If MsgBox("確定要刪除編號為" & GridView2.GetFocusedRowCellValue("PM_NO").ToString & "的所有採購單嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.Yes Then

                    If pc.PurchaseMain_Delete(GridView2.GetFocusedRowCellValue("PM_NO").ToString) = True Then
                        If pc.PurchaseSub_Delete(GridView2.GetFocusedRowCellValue("PM_NO").ToString, Nothing) = True Then

                            '****刪除附檔
                            Dim dt As New FileController
                            Dim ldt As New List(Of FilesInfo)
                            Dim ii As Integer
                            ldt = dt.FileBond_GetList("4008", GridView2.GetFocusedRowCellValue("PM_NO").ToString, Nothing)
                            If ldt.Count > 0 Then
                                For ii = 0 To ldt.Count - 1
                                    dt.File_Delete("4008", GridView2.GetFocusedRowCellValue("PM_NO").ToString, ldt(ii).F_No)
                                Next
                            End If
                            '******
                            MsgBox("刪除成功.....")

                        End If
                    End If
                    Grid1.DataSource = pc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "手開採購單", Nothing, Nothing, False, tesuvalue)
                End If
            Else

                MsgBox("此採購單已有送貨記錄，請先確認刪除送貨單記錄！", 60, "提示")
                Exit Sub
            End If
        Else
            MsgBox("此單已被審核，不允許刪除")
            Exit Sub
        End If
    End Sub

    Private Sub PurchaseRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseRead.Click
        On Error Resume Next

        If GridView2.RowCount = 0 Then Exit Sub

        Dim fr As frmPurchase
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmPurchase Then
                fr.Activate()
                Exit Sub
            End If
        Next

        tempValue2 = "查看"
        tempValue3 = "手開採購單"
        tempValue = GridView2.GetFocusedRowCellValue("PM_NO").ToString
        fr = New frmPurchase
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popPurchaseAccCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPurchaseAccCheck.Click
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub

        Dim pc As New Purchase.PurchaseMainController
        Dim pi As New Purchase.PurchaseMainInfo
        pi = pc.PurchaseMain_Get(GridView2.GetFocusedRowCellValue("PM_NO").ToString)
        If pi.PM_Check = True Then

            Dim fr As frmPurchase
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmPurchase Then
                    fr.Activate()
                    Exit Sub
                End If
            Next

            tempValue2 = "會計部審核"
            tempValue = GridView2.GetFocusedRowCellValue("PM_NO").ToString

            fr = New frmPurchase
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        Else
            MsgBox("此單未經過部門審核，不允許操作")
            Exit Sub
        End If
    End Sub

    Private Sub popPurchaseCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPurchaseCheck.Click
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub

        Dim pc As New Purchase.PurchaseMainController
        Dim pi As New Purchase.PurchaseMainInfo
        pi = pc.PurchaseMain_Get(GridView2.GetFocusedRowCellValue("PM_NO").ToString)
        If pi.PM_AccountCheck = False Or IsDBNull(pi.PM_AccountCheck) = True Then

            If GridView4.RowCount = 0 Then

                Dim fr As frmPurchase
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmPurchase Then

                        fr.Activate()
                        Exit Sub
                    End If
                Next
                tempValue2 = "部門審核"
                tempValue3 = "手開採購單"
                fr = New frmPurchase
                fr.MdiParent = MDIMain
                tempValue = GridView2.GetFocusedRowCellValue("PM_NO").ToString

                fr.WindowState = FormWindowState.Maximized
                fr.Show()
            Else
                MsgBox("此採購單已有送貨記錄，請先確認刪除送貨單記錄！", 60, "提示")
                Exit Sub
            End If


        Else
            MsgBox("此單已被會計部審核，不允許操作")
            Exit Sub
        End If
    End Sub

    Private Sub popPurchaseRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPurchaseRef.Click
        Dim mc As New Purchase.PurchaseMainController
        '***判斷用戶是擁有特殊類的權限
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        Dim tesuvalue As String
        tesuvalue = "否"
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100115")
        If pmwiL.Item(0).PMWS_Value = "是" Then
            tesuvalue = "是"
        End If

        '************
        
        Dim pmwil1 As List(Of PermissionModuleWarrantSubInfo)
        Dim strTemp As String = ""
        pmwil1 = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400817")
        strTemp = pmwil1.Item(0).PMWS_Value
        Select Case strTemp

            Case "非采購人員"
                Grid1.DataSource = Nothing
                PS_Price.Visible = False
                PS_Price.VisibleIndex = -1

            Case "采購員"
                Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, InUserID, "手開採購單", Nothing, Nothing, False, tesuvalue)
            Case "采購主管"
                Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "手開採購單", False, Nothing, Nothing, tesuvalue)
            Case "會計部"
                Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "手開採購單", True, False, Nothing, tesuvalue)
            Case "管理員"
                Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "手開採購單", Nothing, Nothing, Nothing, tesuvalue)
        End Select


    End Sub

    Private Sub popPurchaseSeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPurchaseSeek.Click
        'Dim mc As New Purchase.PurchaseMainController
        'Dim frm As New frmPurchaseSelect
        'frm.ShowDialog()

        ''***判斷用戶是擁有特殊類的權限
        'Dim pmws As New PermissionModuleWarrantSubController
        'Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        'Dim tesuvalue As String
        'tesuvalue = "否"
        'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100115")
        'If pmwiL.Item(0).PMWS_Value = "是" Then
        '    tesuvalue = "是"
        'End If

        ''************


        'Select Case tempValue

        '    Case "1"
        '        Grid1.DataSource = mc.PurchaseMain_Getlist(tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "手開採購單", Nothing, Nothing, Nothing, tesuvalue)
        '    Case "2"
        '        Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "手開採購單", Nothing, Nothing, Nothing, tesuvalue)
        '    Case "3"
        '        Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, "手開採購單", Nothing, Nothing, Nothing, tesuvalue)

        '    Case "4"
        '        If tempValue2 = "已審核" Then
        '            Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "手開採購單", True, Nothing, Nothing, tesuvalue)
        '        ElseIf tempValue2 = "未審核" Then
        '            Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "手開採購單", False, Nothing, Nothing, tesuvalue)
        '        End If
        '    Case "5"
        '        If tempValue2 = "已審核" Then
        '            Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "手開採購單", Nothing, True, Nothing, tesuvalue)
        '        ElseIf tempValue2 = "未審核" Then
        '            Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "手開採購單", Nothing, False, Nothing, tesuvalue)
        '        End If

        '    Case "6"
        '        Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "手開採購單", Nothing, Nothing, Nothing, tesuvalue)
        '    Case "7"
        '        Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "手開採購單", Nothing, Nothing, Nothing, tesuvalue)
        '    Case "8"
        '        Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, "手開採購單", Nothing, Nothing, Nothing, tesuvalue)
        '    Case "9"
        '        Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, "手開採購單", Nothing, Nothing, Nothing, tesuvalue)
        'End Select

        'tempValue = ""
        'tempValue2 = ""

        Dim mc As New Purchase.PurchaseMainController
        tempValue = Me.Text

        Dim frm As New FrmpurSelect
        frm.ShowDialog()

        '***判斷用戶是擁有特殊類的權限
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        Dim tesuvalue As String
        tesuvalue = "否"
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100115")
        If pmwiL.Item(0).PMWS_Value = "是" Then
            tesuvalue = "是"
        End If

        '************
        Dim pc As New PurSelectControl

        Select Case tempValue

            Case "1" '採購單號
                Grid1.DataSource = mc.PurchaseMain_Getlist(tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, "物料", Nothing, Nothing, Nothing, Nothing, "手開採購單", Nothing, Nothing, Nothing, tesuvalue)
            Case "2" '物料規格
                Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, "物料", Nothing, Nothing, Nothing, Nothing, "手開採購單", Nothing, Nothing, Nothing, tesuvalue)
            Case "3" '物料名稱
                Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, "物料", Nothing, Nothing, Nothing, Nothing, "手開採購單", Nothing, Nothing, Nothing, tesuvalue)

            Case "4" '物料編碼 物料類型 
                Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, "物料", Nothing, Nothing, Nothing, Nothing, "手開採購單", Nothing, Nothing, Nothing, tesuvalue)

            Case "5" '供應商
                Grid1.DataSource = mc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "物料", Nothing, Nothing, tempValue2, Nothing, "手開採購單", Nothing, Nothing, Nothing, tesuvalue)

            Case "6" '自定義查詢

                Grid1.DataSource = pc.PurchaseMain_Getlist("採購管理-手開採購單", tempValue2)

        End Select


        tempValue = ""
        tempValue2 = ""

    End Sub

    Private Sub popPurchaseSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPurchaseSend.Click
        Dim ds As New DataSet
        If GridView2.RowCount = 0 Then Exit Sub

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
        Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim mcSupplier As New LFERP.DataSetting.SuppliersControler
        Dim mcPurchase As New LFERP.Library.Purchase.Purchase.PurchaseMainController
        Dim mcsysuser As New LFERP.SystemManager.SystemUser.SystemUserController
        ds.Tables.Clear()

        ltc.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(Nothing, GridView2.GetFocusedRowCellValue("CO_ID").ToString, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "Suppliers", mcSupplier.GetSuppliersList(GridView2.GetFocusedRowCellValue("S_Supplier").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc2.CollToDataSet(ds, "PurchaseMain", mcPurchase.PurchaseMain_Getlist(GridView2.GetFocusedRowCellValue("PM_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc3.CollToDataSet(ds, "SystemUser", mcsysuser.SystemUser_GetList(Nothing, Nothing, Nothing))
        ds.Tables("PurchaseMain").Columns.Add("P_ID", GetType(Integer))
        Dim i As Long

        For i = 0 To ds.Tables("PurchaseMain").Rows.Count - 1
            ds.Tables("PurchaseMain").Rows(i)("P_ID") = i + 1
        Next
        '   MsgBox(Grid.CurrentRow.Cells("Q_QuoID").Value.ToString)
        ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing
        ltc3 = Nothing

        Dim Sup As New List(Of LFERP.DataSetting.SuppliersInfo)
        Sup = mcSupplier.GetSuppliersList(GridView2.GetFocusedRowCellValue("S_Supplier").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        Dim strBody As String
        Dim tempName As String

        strBody = Sup(0).S_SupplierName & ":" & Chr(13) & " 你好!" & Chr(13) & "    這是本公司的採購單!" & Chr(13) & "請盡快復回，謝謝!"

        Dim ReportDoc As New ReportDocument
        tempName = Application.StartupPath & "\TempFile\" & GridView2.GetFocusedRowCellValue("PM_NO").ToString & ".pdf"
        ExportToPDF(ds, "rptPurchaseChs", ReportDoc, tempName)

        SendEmail(" 採購單", Sup(0).S_Email, strBody, tempName)
    End Sub

    Private Sub popPurchasePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPurchasePrint.Click
        Dim ds As New DataSet
        If GridView2.RowCount = 0 Then Exit Sub

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
        Dim ltc4 As New CollectionToDataSet
        Dim ltc5 As New CollectionToDataSet
        Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim mcSupplier As New LFERP.DataSetting.SuppliersControler
        Dim mcPurchase As New LFERP.Library.Purchase.Purchase.PurchaseMainController
        Dim mcsysuser As New LFERP.SystemManager.SystemUser.SystemUserController
        Dim mctarriff As New LFERP.DataSetting.TarriffController
        Dim mcunit As New LFERP.DataSetting.UnitController

        ds.Tables.Clear()
        ltc.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(Nothing, GridView2.GetFocusedRowCellValue("CO_ID").ToString, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "Suppliers", mcSupplier.GetSuppliersList(GridView2.GetFocusedRowCellValue("S_Supplier").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc2.CollToDataSet(ds, "PurchaseMain", mcPurchase.PurchaseMain_Getlist(GridView2.GetFocusedRowCellValue("PM_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc3.CollToDataSet(ds, "SystemUser", mcsysuser.SystemUser_GetList(Nothing, Nothing, Nothing))
        ltc4.CollToDataSet(ds, "Tarriff", mctarriff.TarriffGetList(Nothing))
        ltc5.CollToDataSet(ds, "Unit", mcunit.GetUnitList(Nothing))
        ds.Tables("PurchaseMain").Columns.Add("P_ID", GetType(Integer))
        Dim i As Long

        For i = 0 To ds.Tables("PurchaseMain").Rows.Count - 1
            ds.Tables("PurchaseMain").Rows(i)("P_ID") = i + 1
        Next
        '   MsgBox(Grid.CurrentRow.Cells("Q_QuoID").Value.ToString)
        PreviewRPT(ds, "rptPurchaseChs", " 採購單--" & GridView2.GetFocusedRowCellValue("PM_NO").ToString, True, True)
        ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing
        ltc3 = Nothing
        ltc4 = Nothing
    End Sub

    Private Sub popPurchasePrintEng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPurchasePrintEng.Click
        Dim ds As New DataSet
        If GridView2.RowCount = 0 Then Exit Sub

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
        Dim ltc4 As New CollectionToDataSet
        Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim mcSupplier As New LFERP.DataSetting.SuppliersControler
        Dim mcPurchase As New LFERP.Library.Purchase.Purchase.PurchaseMainController
        Dim mcsysuser As New LFERP.SystemManager.SystemUser.SystemUserController
        Dim mctarriff As New LFERP.DataSetting.TarriffController
        ds.Tables.Clear()
        ltc.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(Nothing, GridView2.GetFocusedRowCellValue("CO_ID").ToString, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "Suppliers", mcSupplier.GetSuppliersList(GridView2.GetFocusedRowCellValue("S_Supplier").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc2.CollToDataSet(ds, "PurchaseMain", mcPurchase.PurchaseMain_Getlist(GridView2.GetFocusedRowCellValue("PM_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc3.CollToDataSet(ds, "SystemUser", mcsysuser.SystemUser_GetList(Nothing, Nothing, Nothing))
        ltc4.CollToDataSet(ds, "Tarriff", mctarriff.TarriffGetList(Nothing))

        ds.Tables("PurchaseMain").Columns.Add("P_ID", GetType(Integer))
        Dim i As Long

        For i = 0 To ds.Tables("PurchaseMain").Rows.Count - 1
            ds.Tables("PurchaseMain").Rows(i)("P_ID") = i + 1
        Next
        '   MsgBox(GridView2.GetFocusedRowCellValue("Q_QuoID").Value.ToString)
        PreviewRPT(ds, "rptPurchaseEng", " 採購單--" & GridView2.GetFocusedRowCellValue("PM_NO").ToString, True, True)
        ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing
        ltc3 = Nothing
        ltc4 = Nothing
    End Sub

    Private Sub popPurchaseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPurchaseFile.Click
        If GridView2.RowCount = 0 Then Exit Sub

        Dim pc As New Purchase.PurchaseMainController
        Dim pi As New Purchase.PurchaseMainInfo
        pi = pc.PurchaseMain_Get(GridView2.GetFocusedRowCellValue("PM_NO").ToString)

        If pi.PM_Check = True Then
            MsgBox("此採購單已被審核,不允許操作!")
            Exit Sub
        Else
            Dim open As Boolean
            Dim update As Boolean
            Dim down As Boolean
            Dim edit As Boolean
            Dim del As Boolean
            Dim detail As Boolean

            Dim pmws As New PermissionModuleWarrantSubController
            Dim pmwiL As New List(Of PermissionModuleWarrantSubInfo)

            If GridView2.RowCount = 0 Then Exit Sub
            pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400810")
            If pmwiL.Count > 0 Then
                If pmwiL.Item(0).PMWS_Value = "是" Then update = True Else update = False
            End If

            pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400811")
            If pmwiL.Count > 0 Then
                If pmwiL.Item(0).PMWS_Value = "是" Then down = True Else down = False
            End If

            pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400812")
            If pmwiL.Count > 0 Then
                If pmwiL.Item(0).PMWS_Value = "是" Then edit = True Else edit = False
            End If

            pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400813")
            If pmwiL.Count > 0 Then
                If pmwiL.Item(0).PMWS_Value = "是" Then del = True Else del = False
            End If

            pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400814")
            If pmwiL.Count > 0 Then
                If pmwiL.Item(0).PMWS_Value = "是" Then detail = True Else detail = False
            End If

            pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400815")
            If pmwiL.Count > 0 Then
                If pmwiL.Item(0).PMWS_Value = "是" Then open = True Else open = False
            End If

            FileShow("4008", GridView2.GetFocusedRowCellValue("PM_NO").ToString, open, update, down, edit, del, detail)
        End If

    End Sub

   
    Private Sub PopMsgLookPur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopMsgLookPur.Click
        On Error Resume Next

        If GridView2.RowCount = 0 Then Exit Sub

        Dim fr As frmMessageSent
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMessageSent Then
                fr.Activate()
                Exit Sub
            End If
        Next

        tempValue = "新增"                                                              '凡是其他模塊調用信息的頁面前的參數都為新增，
        tempValue3 = "採購單" & GridView2.GetFocusedRowCellValue("PM_NO").ToString & "查看"      ' 附件名
        tempValue4 = GridView2.GetFocusedRowCellValue("PM_NO").ToString               ' 單據ID
        tempValue5 = "4008"                                                         '   模塊ID
        tempValue6 = "查看"                                                         '發送類型

        fr = New frmMessageSent
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub PopMsgCheckPur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopMsgCheckPur.Click
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub

        Dim pc As New Purchase.PurchaseMainController
        Dim pi As New Purchase.PurchaseMainInfo
        pi = pc.PurchaseMain_Get(GridView2.GetFocusedRowCellValue("PM_NO").ToString)
        If pi.PM_AccountCheck = False Or IsDBNull(pi.PM_AccountCheck) = True Then

            Dim fr As frmMessageSent
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmMessageSent Then
                    fr.Activate()
                    Exit Sub
                End If
            Next


            tempValue = "新增"                                                              '凡是其他模塊調用信息的頁面前的參數都為新增，
            tempValue3 = "採購單" & GridView2.GetFocusedRowCellValue("PM_NO").ToString & "部門審核"     ' 附件名
            tempValue4 = GridView2.GetFocusedRowCellValue("PM_NO").ToString               ' 單據ID
            tempValue5 = "4008"                                                         '   模塊ID
            tempValue6 = "部門審核"                                                         '發送類型


            fr = New frmMessageSent
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        Else
            MsgBox("此單已被會計部審核，不允許操作")
            Exit Sub
        End If
    End Sub

    Private Sub PopMsgAccCheckPur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopMsgAccCheckPur.Click
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub

        Dim pc As New Purchase.PurchaseMainController
        Dim pi As New Purchase.PurchaseMainInfo
        pi = pc.PurchaseMain_Get(GridView2.GetFocusedRowCellValue("PM_NO").ToString)
        If pi.PM_Check = True Then

            Dim fr As frmMessageSent
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmMessageSent Then
                    fr.Activate()
                    Exit Sub
                End If
            Next


            tempValue = "新增"                                                              '凡是其他模塊調用信息的頁面前的參數都為新增，
            tempValue3 = "採購單" & GridView2.GetFocusedRowCellValue("PM_NO").ToString & "會計審核"      ' 附件名
            tempValue4 = GridView2.GetFocusedRowCellValue("PM_NO").ToString               ' 單據ID
            tempValue5 = "4008"                                                         '   模塊ID
            tempValue6 = "會計部審核"                                                         '發送類型




            fr = New frmMessageSent
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        Else
            MsgBox("此單未經過部門審核，不允許操作")
            Exit Sub
        End If
    End Sub
    Private Sub Grid1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid1.MouseUp
        If GridView2.RowCount = 0 Then Exit Sub

        Dim strA, strB As String
        strA = GridView2.GetFocusedRowCellValue("PM_NO").ToString()
        strB = GridView2.GetFocusedRowCellValue("M_Code").ToString()
        Dim ac As New AcceptanceController
        GridControl3.DataSource = ac.Acceptance_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strB, Nothing, Nothing, Nothing, Nothing, Nothing)

        Dim rc As New RetrocedeController
        '  GridControl2.DataSource = rc.Retrocede_GetList(strA, Nothing, Nothing, Nothing, True, Nothing, strB, Nothing, Nothing, Nothing)
        GridControl4.DataSource = rc.Retrocede_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing, strB, Nothing, Nothing, Nothing)

        Dim cc As New Change.ChangeControl
        GridControl5.DataSource = cc.Change_GetList(Nothing, strA, strB, Nothing)
    End Sub

    Private Sub popPurchaseExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPurchaseExport.Click
        'On Error Resume Next
        'If GridView2.RowCount = 0 Then Exit Sub
        'If MsgBox("你確定要導出當前所有物料採購的信息嗎?", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.No Then Exit Sub

        'Dim exapp As New Excel.Application
        'Dim exbook As Excel.Workbook
        'Dim exsheet As Excel.Worksheet

        'Dim i As Integer = 0, ii As Integer = 0

        'exapp = CreateObject("Excel.Application")
        'exbook = exapp.Workbooks.Add
        'exsheet = exapp.Worksheets(1)

        'exsheet.Cells(1, 1) = "採購單號"
        'exsheet.Cells(1, 2) = "供應商名"
        'exsheet.Cells(1, 3) = "物料編碼"
        'exsheet.Cells(1, 4) = "物料類別"
        'exsheet.Cells(1, 5) = "名稱"
        'exsheet.Cells(1, 6) = "規格"
        'exsheet.Cells(1, 7) = "批次"
        'exsheet.Cells(1, 8) = "供應商編號"
        'exsheet.Cells(1, 9) = "單價"
        'exsheet.Cells(1, 10) = "幣別"
        'exsheet.Cells(1, 11) = "數量"
        'exsheet.Cells(1, 12) = "單位"
        'exsheet.Cells(1, 13) = "未交數"
        'exsheet.Cells(1, 14) = "採購日期"
        'exsheet.Cells(1, 15) = "部門審核"
        'exsheet.Cells(1, 16) = "會計審核"
        'exsheet.Cells(1, 17) = "會計審核類型"
        'exsheet.Cells(1, 18) = "會計部審核員"
        'exsheet.Cells(1, 19) = "操作員"

        'For i = 0 To GridView2.RowCount - 1
        '    ii = i + 2
        '    exsheet.Cells(ii, 1) = GridView2.GetRowCellValue(i, "PM_NO")
        '    exsheet.Cells(ii, 2) = GridView2.GetRowCellValue(i, "S_SupplierName")
        '    exsheet.Cells(ii, 3) = "$" & GridView2.GetRowCellValue(i, "M_Code") & "$"
        '    exsheet.Cells(ii, 4) = GridView2.GetRowCellValue(i, "Type3Name")
        '    exsheet.Cells(ii, 5) = GridView2.GetRowCellValue(i, "M_Name")
        '    exsheet.Cells(ii, 6) = GridView2.GetRowCellValue(i, "M_Gauge")
        '    exsheet.Cells(ii, 7) = GridView2.GetRowCellValue(i, "OS_BatchID")
        '    exsheet.Cells(ii, 8) = GridView2.GetRowCellValue(i, "S_SupplierNo")
        '    exsheet.Cells(ii, 9) = GridView2.GetRowCellValue(i, "PS_Price")
        '    exsheet.Cells(ii, 10) = GridView2.GetRowCellValue(i, "C_ID")
        '    exsheet.Cells(ii, 11) = GridView2.GetRowCellValue(i, "PS_QTY")
        '    exsheet.Cells(ii, 12) = GridView2.GetRowCellValue(i, "M_Unit")
        '    exsheet.Cells(ii, 13) = GridView2.GetRowCellValue(i, "PS_NoSendQty")
        '    exsheet.Cells(ii, 14) = GridView2.GetRowCellValue(i, "PM_PurchaseDate")
        '    exsheet.Cells(ii, 15) = GridView2.GetRowCellValue(i, "PM_Check")
        '    exsheet.Cells(ii, 16) = GridView2.GetRowCellValue(i, "PM_AccountCheck")
        '    exsheet.Cells(ii, 17) = GridView2.GetRowCellValue(i, "PM_AccountCheckType")
        '    exsheet.Cells(ii, 18) = GridView2.GetRowCellValue(i, "PM_AccCheckActionName")
        '    exsheet.Cells(ii, 19) = GridView2.GetRowCellValue(i, "PM_ActionName")
        'Next
        'exapp.Visible = True


        '2012/9/25  ---------------------------------------------------------

        If GridView2.RowCount = 0 Then Exit Sub
        ' ''ExportGridToXls()

        ''Dim saveFileDialog As New SaveFileDialog()

        ''saveFileDialog.Title = "導出Excel"

        ''saveFileDialog.Filter = "Excel2003文件(*.xls)|*.xls"
        ' ''|Excel2007及以上文件(*.xlsx)|*.xlsx  '當前測試2007 以及以上版本有誤！

        ''Dim dialogResult__1 As DialogResult = saveFileDialog.ShowDialog(Me)

        ''If dialogResult__1 = Windows.Forms.DialogResult.OK Then

        ''    'Grid1.ExportToXls(saveFileDialog.FileName)
        ''    GridView2.BestFitColumns()

        ''    Grid1.ExportToExcelOld(saveFileDialog.FileName)

        ''    DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ''End If
        '--------------------------------------------------------------------

        Dim i, j As Integer
        Dim exapp As New Excel.Application   '定義一個excel對象
        Dim exbook As Excel.Workbook     '定義一個excel活頁
        Dim exsheet As Excel.Worksheet   '定義一個excel工作區

        exapp = CreateObject("Excel.Application")   '生成一個excel對象
        exbook = exapp.Workbooks.Open(Application.StartupPath & "\ModuleFile\Module.xls")
        exsheet = exbook.Worksheets(1)

        exsheet.Cells(1, 1) = "採購單號"
        exsheet.Cells(1, 2) = "採購日期"
        exsheet.Cells(1, 3) = "供應商編號"
        exsheet.Cells(1, 4) = "供應商名稱"
        exsheet.Cells(1, 5) = "物料編碼"

        exsheet.Cells(1, 6) = "大類"
        exsheet.Cells(1, 7) = "中類"


        exsheet.Cells(1, 8) = "小類"
        exsheet.Cells(1, 9) = "名稱"
        exsheet.Cells(1, 10) = "規格"
        exsheet.Cells(1, 11) = "單位"
        exsheet.Cells(1, 12) = "數量"

        exsheet.Cells(1, 13) = "單價"
        exsheet.Cells(1, 14) = "金額"

        exsheet.Cells(1, 15) = "幣別"
        exsheet.Cells(1, 16) = "付款方式"
        exsheet.Cells(1, 17) = "操作員"

        exsheet.Cells(1, 18) = "未交數"
        exsheet.Cells(1, 19) = "部門審核"
        exsheet.Cells(1, 20) = "會計審核"
        exsheet.Cells(1, 21) = "會計審核類型"
        exsheet.Cells(1, 22) = "會計部審核員"

        exsheet.Cells(1, 23) = "批次"

        exsheet.Cells(1, 24) = "金額(港幣)"
        exsheet.Cells(1, 25) = "備注"
        'PM_Remark

        Dim ii As Integer

        For i = 0 To GridView2.RowCount - 1
            ii = i + 2
            exsheet.Cells(ii, 1) = GridView2.GetRowCellValue(i, "PM_NO")
            exsheet.Cells(ii, 2) = GridView2.GetRowCellValue(i, "PM_PurchaseDate")
            exsheet.Cells(ii, 3) = GridView2.GetRowCellValue(i, "S_Supplier") 'S_SupplierNo
            exsheet.Cells(ii, 4) = GridView2.GetRowCellValue(i, "S_SupplierName")
            exsheet.Cells(ii, 5) = GridView2.GetRowCellValue(i, "M_Code")

            exsheet.Cells(ii, 6) = GridView2.GetRowCellValue(i, "Type1Name")
            exsheet.Cells(ii, 7) = GridView2.GetRowCellValue(i, "Type2Name")

            exsheet.Cells(ii, 8) = GridView2.GetRowCellValue(i, "Type3Name")
            exsheet.Cells(ii, 9) = GridView2.GetRowCellValue(i, "M_Name")
            exsheet.Cells(ii, 10) = GridView2.GetRowCellValue(i, "M_Gauge")
            exsheet.Cells(ii, 11) = GridView2.GetRowCellValue(i, "M_Unit")
            exsheet.Cells(ii, 12) = GridView2.GetRowCellValue(i, "PS_QTY")

            exsheet.Cells(ii, 13) = GridView2.GetRowCellValue(i, "PS_Price")
            exsheet.Cells(ii, 14) = Val(GridView2.GetRowCellValue(i, "PS_Price")) * Val(GridView2.GetRowCellValue(i, "PS_QTY"))
            exsheet.Cells(ii, 15) = GridView2.GetRowCellValue(i, "C_ID")
            exsheet.Cells(ii, 16) = GridView2.GetRowCellValue(i, "PM_ToFrom")
            exsheet.Cells(ii, 17) = GridView2.GetRowCellValue(i, "PM_ActionName")

            exsheet.Cells(ii, 18) = GridView2.GetRowCellValue(i, "PS_NoSendQty")
            exsheet.Cells(ii, 19) = GridView2.GetRowCellValue(i, "PM_Check")
            exsheet.Cells(ii, 20) = GridView2.GetRowCellValue(i, "PM_AccountCheck")
            exsheet.Cells(ii, 21) = GridView2.GetRowCellValue(i, "PM_AccountCheckType")
            exsheet.Cells(ii, 22) = GridView2.GetRowCellValue(i, "PM_AccCheckActionName")

            exsheet.Cells(ii, 23) = GridView2.GetRowCellValue(i, "OS_BatchID")

            exsheet.Cells(ii, 24) = Format(Val(GridView2.GetRowCellValue(i, "PS_Price")) * Val(GridView2.GetRowCellValue(i, "PS_QTY")) * Val(GridView2.GetRowCellValue(i, "HKDRate")), "0.0000")
            exsheet.Cells(ii, 25) = GridView2.GetRowCellValue(i, "PM_Remark")

            exsheet.Rows(ii).RowHeight = 18

        Next

        exbook.ActiveSheet.range(exsheet.Cells(1, 1), exsheet.Cells(GridView2.RowCount + 1, 25)).borders(1).linestyle = 1
        exbook.ActiveSheet.range(exsheet.Cells(1, 1), exsheet.Cells(GridView2.RowCount + 1, 25)).borders(2).linestyle = 1
        exbook.ActiveSheet.range(exsheet.Cells(1, 1), exsheet.Cells(GridView2.RowCount + 1, 25)).borders(3).linestyle = 1
        exbook.ActiveSheet.range(exsheet.Cells(1, 1), exsheet.Cells(GridView2.RowCount + 1, 25)).borders(4).linestyle = 1

        Dim tempName As String
        SaveFileDialog1.InitialDirectory = "c:\"
        SaveFileDialog1.Filter = "txt files (*.xls)|*.xls"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            tempName = SaveFileDialog1.FileName
        Else
            'tempName = Application.StartupPath & Format(Now, "yyyyMMdd") & ".xls"
            Exit Sub
        End If

        exsheet.SaveAs(tempName)
        exapp.Quit()
        exsheet = Nothing
        exbook = Nothing
        exapp = Nothing

        MsgBox("導出成功! 至" & tempName)



    End Sub
End Class