Imports LFERP.Library.ProductionReturn
Imports LFERP.SystemManager
Imports LFERP.DataSetting
Imports LFERP.Library.ProductionSelect

Public Class frmProductionReturnMain
#Region "屬性"
    Dim prc As New ProductionReturnControl
    Dim uc As New UserPowerControl
#End Region


    ''' <summary>
    '''  窗體啟動載入事件  
    ''' </summary>
    Private Sub frmProductionReturnMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim uci As List(Of UserPowerInfo)
        uci = uc.UserPower_GetList(InUserID, Nothing, Nothing, Nothing)
        If uci.Count = 0 Then
            MsgBox("此用戶名不在生產模塊中,請先添加!")
            Exit Sub
        Else

        End If
        'Grid1.DataSource = prc.ProductionReturn_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        ReturnRef_Click(Nothing, Nothing)

        PowerUser()
    End Sub

    ''' <summary>
    '''  設置權限  
    ''' </summary>
    Sub PowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880901")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ReturnAdd.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880902")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ReturnEdit.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880903")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ReturnDel.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880904")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ReturnCheck.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880905")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ReturnPrint.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880908")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripIncheck.Enabled = True
        End If

        '

    End Sub

    ''' <summary>
    '''  新增補退貨事件  
    ''' </summary>
    Private Sub ReturnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnAdd.Click
        On Error Resume Next
        Edit = False
        Dim fr As frmProductionReturn
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionReturn Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New frmProductionReturn
        fr.EditItem = "ReturnADD"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    ''' <summary>
    '''  補退貨修改事件  
    ''' </summary>
    Private Sub ReturnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnEdit.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("AR_NO").ToString
        Dim pri As List(Of ProductionReturnInfo)
        pri = prc.ProductionReturn_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pri(0).AR_Check = True Then
            MsgBox("此單已審核,不允許修改!")
            Exit Sub
        Else
            Edit = True
            Dim fr As frmProductionReturn
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmProductionReturn Then
                    fr.Activate()
                    Exit Sub
                End If
            Next

            fr = New frmProductionReturn
            '' fr.EditItem = pri(0).AR_Type
            fr.EditItem = "ReturnADD"
            fr.EditValue = strA
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub

    ''' <summary>
    '''  新增補刪除事件  
    ''' </summary>
    Private Sub ReturnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("AR_NO").ToString
        Dim pri As List(Of ProductionReturnInfo)
        pri = prc.ProductionReturn_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pri(0).AR_Check = True Then
            MsgBox("此單已審核,不允許刪除!")
            Exit Sub
        Else
            If MsgBox("確定要刪除編號為" & strA & "單嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.Yes Then
                If prc.ProductionReturn_Delete(Nothing, strA) = True Then
                Else
                    MsgBox("刪除失敗,請檢查原因!")
                End If

                Grid1.DataSource = prc.ProductionReturn_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            End If
        End If
    End Sub

    ''' <summary>
    '''  新增補查看事件  
    ''' </summary>
    Private Sub ReturnPreView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnPreView.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As frmProductionReturn
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionReturn Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionReturn
        fr.EditItem = "PreView"
        fr.EditValue = GridView1.GetFocusedRowCellValue("AR_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    ''' <summary>
    '''  審核事件  
    ''' </summary>
    Private Sub ReturnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnCheck.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As frmProductionReturn
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionReturn Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionReturn
        fr.EditItem = "Check"
        fr.EditValue = GridView1.GetFocusedRowCellValue("AR_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    ''' <summary>
    '''  '查詢操作--
    ''' </summary>
    Private Sub ReturnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnQuery.Click
        Dim fr As New ProductionRetrocedeSelect
        tempValue = "生產補退貨單"    '查詢類型
        '判斷當前操作員所在部門
        '第一生產部---第一生產倉
        '第二生產部---第二生產倉
        '第三生產部---第三生產倉...
        tempValue2 = ""   '發出倉庫信息---當前使用人員指定倉庫信息

        fr.ShowDialog()

        Dim prc As New ProductionReturnControl
        Dim prc1 As New ProductionSelectControl

        Select Case tempValue

            Case "1"  '固定模塊查詢

                Grid1.DataSource = prc.ProductionReturn_GetList(tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            Case "2"   '自定義多項選擇查詢

                Grid1.DataSource = prc1.ProductionSelect_Return_Getlist("生產補退貨單", tempValue2)

        End Select

        tempValue = ""
        tempValue2 = ""
    End Sub

    ''' <summary>
    '''  '刷新事件操作--
    ''' </summary>
    Private Sub ReturnRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnRef.Click
        Dim InWare As String = FunWareSelect("880907")
        Dim OutWare As String = FunWareSelect("880906")

        Grid1.DataSource = prc.ProductionReturn_GetList1(Nothing, Nothing, Nothing, OutWare, InWare, Nothing, Nothing, Nothing, Nothing, Nothing)
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
    '''   '導出對應的接收單號(收入依據) ---報表
    ''' </summary>
    Private Sub ReturnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnPrint.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim ds As New DataSet
        Dim ltc As New CollectionToDataSet

        Dim prc As New ProductionReturnControl
        ds.Tables.Clear()

        Dim strA, strB As String

        strA = GridView1.GetFocusedRowCellValue("AR_NO").ToString
        strB = GridView1.GetFocusedRowCellValue("AR_Type").ToString

        ltc.CollToDataSet(ds, "ProductionReturn", prc.ProductionReturn_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))


        PreviewRPT(ds, "rptProductionReturn", "接收生產" & strB & "單", True, True)

        ltc = Nothing
        'Me.Close()

    End Sub

    Private Sub ToolStripIncheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripIncheck.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("AR_NO").ToString
        Dim pri As List(Of ProductionReturnInfo)
        pri = prc.ProductionReturn_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pri(0).AR_Check = False Then
            MsgBox("此單未審核,不允許收料確認!")
            Exit Sub
        End If

        If pri(0).AR_InCheck = True Then
            MsgBox("此單已收料確認,不允許收料確認!")
            Exit Sub
        End If

        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As frmProductionReturn
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionReturn Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionReturn
        fr.EditItem = "InCheck"
        fr.EditValue = GridView1.GetFocusedRowCellValue("AR_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub
End Class