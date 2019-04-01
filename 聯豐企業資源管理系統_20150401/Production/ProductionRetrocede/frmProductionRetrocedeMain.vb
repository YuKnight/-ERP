Imports LFERP.Library.ProductionRetrocede
Imports LFERP.SystemManager
Imports LFERP.Library.ProductionSelect


Public Class frmProductionRetrocedeMain
    Dim prc As New ProductionRetrocedeControl
    ''' <summary>
    ''' 窗體啟動事件
    ''' </summary>
    Private Sub frmProductionRetrocedeMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '        Grid1.DataSource = prc.ProductionRetrocede_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        RetrocedeRef_Click(Nothing, Nothing)
        UserPower()
    End Sub
    Function FunWareSelect(ByVal FunWare As String) As String
        Dim a As New LFERP.SystemManager.PermissionModuleWarrantSubController
        Dim b As New List(Of LFERP.SystemManager.PermissionModuleWarrantSubInfo)
        b = a.PermissionModuleWarrantSub_GetList(InUserID, FunWare)
        Dim i, n As Integer
        Dim arr(n) As String

        Dim WareSelect As String = ""
        If b.Count > 0 Then
            arr = Split(b.Item(0).PMWS_Value, ",")
            n = Len(Replace(b.Item(0).PMWS_Value, ",", "," & "*")) - Len(b.Item(0).PMWS_Value)
            For i = 0 To n
                If i = 0 Then
                    WareSelect = "'" & arr(i) & "'"
                Else
                    WareSelect = WareSelect & ",'" & arr(i) & "'"
                End If
            Next
        End If
        FunWareSelect = WareSelect
    End Function

    ''' <summary>
    ''' 設置用戶權限
    ''' </summary>
    Sub UserPower()  '設置用戶權限
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880801")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then RetrocedeAdd.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880802")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then RetrocedeEdit.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880803")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then RetrocedeDel.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880804")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then RetrocedeCheck.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880805")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then RetrocedePrint.Enabled = True
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880808")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripIncheck.Enabled = True
        End If




    End Sub
    ''' <summary>
    ''' 裝配退料新增
    ''' </summary>
    Private Sub RetrocedeAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetrocedeAdd.Click
        On Error Resume Next
        Edit = False
        Dim fr As frmProductionRetrocede
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionRetrocede Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New frmProductionRetrocede
        fr.EditItem = "ADD"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
    ''' <summary>
    ''' 裝配退料修改
    ''' </summary>
    Private Sub RetrocedeEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetrocedeEdit.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("R_NO").ToString
        Dim pri As List(Of ProductionRetrocedeInfo)
        pri = prc.ProductionRetrocede_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pri(0).R_Check = True Then
            MsgBox("此單已被審核,不允許修改!")
            Exit Sub
        Else
            '-----------------------------------------------------------------------------------
            '如果此退貨單存在有送貨記錄的話，也不允許修改   2012/8/23
            Dim ptc As New LFERP.Library.ProductionReturn.ProductionReturnControl
            Dim pti As List(Of LFERP.Library.ProductionReturn.ProductionReturnInfo)
            pti = ptc.ProductionReturn_GetList(Nothing, strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If pti.Count > 0 Then
                MsgBox("當前退貨單號存在有送貨記錄，不允許修改！")
                Exit Sub
            End If
            '-----------------------------------------------------------------------------------
            Edit = True
            Dim fr As frmProductionRetrocede
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionRetrocede Then
                    fr.Activate()
                    Exit Sub
                End If
            Next

            fr = New frmProductionRetrocede
            fr.EditItem = "ADD"
            fr.EditValue = strA
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub
    ''' <summary>
    ''' 生產補退料刪除
    ''' </summary>
    Private Sub RetrocedeDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetrocedeDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("R_NO").ToString
        Dim pri As List(Of ProductionRetrocedeInfo)
        pri = prc.ProductionRetrocede_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pri(0).R_Check = True Then
            MsgBox("此單已被審核,不允許刪除!")
            Exit Sub
        Else
            If MsgBox("確定要刪除編號為" & strA & "單嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.Yes Then
                If prc.ProductionRetrocede_Delete(Nothing, strA) = True Then
                Else
                    MsgBox("刪除失敗,請檢查原因!")
                End If

                Grid1.DataSource = prc.ProductionRetrocede_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            End If
        End If
    End Sub
    ''' <summary>
    ''' 生產補退料查看
    ''' </summary>
    Private Sub RetrocedePreView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetrocedePreView.Click
        On Error Resume Next

        Dim fr As frmProductionRetrocede
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionRetrocede Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New frmProductionRetrocede
        fr.EditItem = "PreView"
        fr.EditValue = GridView1.GetFocusedRowCellValue("R_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
    ''' <summary>
    ''' 生產補退料查詢
    ''' </summary>
    Private Sub RetrocedeQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetrocedeQuery.Click
        Dim prc As New ProductionRetrocedeControl
        Dim prc1 As New ProductionSelectControl

        Dim fr As New ProductionRetrocedeSelect
        tempValue = "裝配退貨單"    '查詢類型
        '判斷當前操作員所在部門
        '第一裝配部---第一裝配倉
        '第二裝配部---第二裝配倉
        '第三裝配部---第三裝配倉...
        tempValue2 = ""   '發出倉庫信息---當前使用人員指定倉庫信息

        fr.ShowDialog()

        Select Case tempValue
            Case "1"  '固定模塊查詢
                Grid1.DataSource = prc.ProductionRetrocede_GetList(tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "2"   '自定義多項選擇查詢
                Grid1.DataSource = prc1.ProductionSelect_Retrocede_Getlist("裝配退貨單", tempValue2)
        End Select

        tempValue = ""
        tempValue2 = ""
    End Sub
    ''' <summary>
    ''' 生產補退料刷新
    ''' </summary>
    Private Sub RetrocedeRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetrocedeRef.Click

        Dim InWare As String = FunWareSelect("880807")
        Dim OutWare As String = FunWareSelect("880806")

        Grid1.DataSource = prc.ProductionRetrocede_GetList1(Nothing, Nothing, Nothing, OutWare, InWare, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub
    ''' <summary>
    '''  '列印對應的退貨/補退貨單據(為接收部門依據)--設計報表
    ''' </summary>
    Private Sub RetrocedePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetrocedePrint.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim ds As New DataSet
        Dim ltc As New CollectionToDataSet

        Dim prc As New ProductionRetrocedeControl
        ds.Tables.Clear()

        Dim strA, strB As String

        strA = GridView1.GetFocusedRowCellValue("R_NO").ToString
        strB = GridView1.GetFocusedRowCellValue("R_Type").ToString

        ltc.CollToDataSet(ds, "ProductionRetrocede", prc.ProductionRetrocede_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

        PreviewRPT1(ds, "rptProductionRetrocede", "生產" & strB & "單", InUser, "", True, True)

        ltc = Nothing
        'Me.Close()
    End Sub
    ''' <summary>
    ''' 生產補退料審核
    ''' </summary>
    Private Sub RetrocedeCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetrocedeCheck.Click
        On Error Resume Next

        '-----------------------------------------------------------------------------------
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("R_NO").ToString
        '如果此退貨單存在有送貨記錄的話，也不允許修改   2012/8/23
        Dim ptc As New LFERP.Library.ProductionReturn.ProductionReturnControl
        Dim pti As List(Of LFERP.Library.ProductionReturn.ProductionReturnInfo)
        pti = ptc.ProductionReturn_GetList(Nothing, strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pti.Count > 0 Then
            MsgBox("當前退貨單號存在有送貨記錄，不允許審核操作！")
            Exit Sub
        End If
        '-----------------------------------------------------------------------------------

        Dim fr As frmProductionRetrocede
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionRetrocede Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New frmProductionRetrocede
        fr.EditItem = "Check"
        fr.EditValue = GridView1.GetFocusedRowCellValue("R_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
    ''' <summary>
    ''' 子表帶出查詢資料
    ''' </summary>
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount = 0 Then Exit Sub
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("R_NO").ToString
        Dim ptc As New LFERP.Library.ProductionReturn.ProductionReturnControl
        GridControl1.DataSource = ptc.ProductionReturn_GetList(Nothing, strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub RetrocedeTotalPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetrocedeTotalPrint.Click
        '  If GridView1.RowCount = 0 Then Exit Sub
        'tempValue = GridView1.GetFocusedRowCellValue("C_NO").ToString
        Dim frm As New frmWarePrint
        frm.EditItem = "ProductionRetrocede"
        frm.ShowDialog()
    End Sub

    Private Sub ToolStripIncheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripIncheck.Click

        '-----------------------------------------------------------------------------------
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("R_NO").ToString
        '如果此退貨單存在有送貨記錄的話，也不允許修改   2012/8/23
        Dim ptc As New LFERP.Library.ProductionRetrocede.ProductionRetrocedeControl
        Dim pti As List(Of LFERP.Library.ProductionRetrocede.ProductionRetrocedeInfo)
        pti = ptc.ProductionRetrocede_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pti.Count <= 0 Then
            MsgBox("記錄不存在！")
            Exit Sub
        End If

        If pti(0).R_InCheck = True Then
            MsgBox("已收料確認不能再收料操作")
            Exit Sub
        End If

        If pti(0).R_Check = False Then
            MsgBox("此單未審核,不能收料操作")
            Exit Sub
        End If

        '-----------------------------------------------------------------------------------
        On Error Resume Next
        Dim fr As frmProductionRetrocede
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionRetrocede Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New frmProductionRetrocede
        fr.EditItem = "InCheck"
        fr.EditValue = GridView1.GetFocusedRowCellValue("R_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
End Class