Imports System
Imports LFERP.SystemManager
Imports LFERP.Library.Product
Imports LFERP.Library.Production.ProductionWareShipped
Imports LFERP.Library.Production.ProductInventoryOut


Public Class ProductInventoryOutMain
    Dim strWareValeOut As String = "881009"
    Dim strWareValeIn As String = "881010"
#Region "新增事件"
    ''' <summary>
    '''     新增事件
    ''' </summary>
    Private Sub popWareOutAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutAdd.Click
        On Error Resume Next
        Edit = False
        Dim fr As ProductInventoryOut
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is ProductInventoryOut Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New ProductInventoryOut
        fr.EditItem = "Shipped" '出貨單
        fr.EditValue = ""
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
#End Region

#Region "修改"
    ''' <summary>
    '''     修改事件
    ''' </summary>
    Private Sub popWareOutEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutEdit.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As List(Of ProductInventoryOutInfo)
        Dim pc As New ProductInventoryOutControl
        pi = pc.ProductInventoryOut_GetList(Nothing, GridView1.GetFocusedRowCellValue("PO_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pi(0).PO_Check = True Then
            MsgBox("此出貨單已被審核,不允許修改")
            Exit Sub
        Else
            Edit = True
            Dim fr As ProductInventoryOut
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is ProductInventoryOut Then
                    fr.Activate()
                    Exit Sub
                End If
            Next

            fr = New ProductInventoryOut
            fr.EditItem = "ShippedUpdate"
            fr.EditValue = GridView1.GetFocusedRowCellValue("PO_NO").ToString
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub
#End Region

#Region "刪除"
    ''' <summary>
    '''     刪除事件
    ''' </summary>
    Private Sub popWareOutDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As List(Of ProductInventoryOutInfo)
        Dim pc As New ProductInventoryOutControl
        pi = pc.ProductInventoryOut_GetList(GridView1.GetFocusedRowCellValue("AutoID").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pi(0).PO_Check = True Then
            MsgBox("此出貨單已被審核,不允許刪除")
            Exit Sub
        Else
            If MsgBox("確定要刪除此條出貨記錄嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.Yes Then
                If pc.ProductInventoryOut_Delete(GridView1.GetFocusedRowCellValue("AutoID").ToString) = True Then
                    MsgBox("刪除當前出貨單成功!")
                Else
                    MsgBox("刪除失敗,請檢查原因!")
                End If
                DateFill(XtraTabControl1.SelectedTabPageIndex)
            End If
        End If
    End Sub
#End Region

#Region "查看"
    ''' <summary>
    '''     查看事件
    ''' </summary>
    Private Sub popWareOutView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutView.Click, popWareInView.Click
        On Error Resume Next

        '-------------------------------------------------------
        '2013-12-5新增
        If GridView1.RowCount = 0 Then Exit Sub
        '-------------------------------------------------------
        Dim fr As ProductInventoryOut
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is ProductInventoryOut Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New ProductInventoryOut
        fr.EditItem = "PreView"
        '-----------------------------------------------------------------
        '2013-12-5新增
        fr.EditValue = GridView1.GetFocusedRowCellValue("PO_NO").ToString
        '-----------------------------------------------------------------
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
#End Region

#Region "刷新"
    ''' <summary>
    '''     刷新事件
    ''' </summary>
    Private Sub popWareOutflesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutflesh.Click, popWareInflesh.Click
        DateFill(XtraTabControl1.SelectedTabPageIndex)
    End Sub
    ''' <summary>
    '''     查詢事件
    ''' </summary>
    Private Sub popWareOutSeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutSeek.Click, popWareInSeek.Click
        'ProductionWareOutSelect.ShowDialog()
        'Dim pc As New ProductionWareShippedControl
        'If tempValue <> Nothing Then
        '    Grid.DataSource = pc.ProductionWareShipped_GetList(tempValue4, Nothing, tempValue3, Nothing, tempValue5, Nothing, Nothing, tempValue6, tempValue7, tempValue2, tempValue8, Nothing, Nothing, Nothing)
        'End If
        'ProductionWareOutSelect.Dispose()
        'tempValue = Nothing
        'tempValue2 = Nothing
        'tempValue3 = Nothing
        'tempValue4 = Nothing
        'tempValue5 = Nothing
        'tempValue6 = Nothing
        'tempValue7 = Nothing
        'tempValue8 = Nothing
    End Sub
#End Region

#Region "報表"
    ''' <summary>
    '''     報表事件
    ''' </summary>
    Private Sub popWareOutReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutReport.Click, popWareInReport.Click
        'Dim ds As New DataSet
        'Dim Str As String = String.Empty

        'If GridView1.RowCount = 0 Then Exit Sub
        'Str = GridView1.GetFocusedRowCellValue("PO_NO").ToString

        'Dim ltc As New CollectionToDataSet
        'Dim pc As New ProductionWareShippedControl
        'Dim pi As New ProductionWareShippedInfo

        'ds.Tables.Clear()

        'ltc.CollToDataSet(ds, "ProductionWareShipped", pc.ProductionWareShipped_GetList(Str, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        'ds.Tables("ProductionWareShipped").Columns.Add("PWS_ID", GetType(Integer))
        'Dim i As Long
        'For i = 0 To ds.Tables("ProductionWareShipped").Rows.Count - 1
        '    ds.Tables("ProductionWareShipped").Rows(i)("PWS_ID") = i + 1
        'Next

        'PreviewRPT1(ds, "rptProductionWareShipped", "成品出庫單", InUser, InUser, True, True)

        'ltc = Nothing
    End Sub
#End Region

#Region "審核"
    ''' <summary>
    '''     審核事件
    ''' </summary>
    Private Sub popWareOutCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutCheck.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub

        Dim pi As List(Of ProductInventoryOutInfo)
        Dim pc As New ProductInventoryOutControl
        pi = pc.ProductInventoryOut_GetList(Nothing, GridView1.GetFocusedRowCellValue("PO_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)


        '-------------------------------------------------------------
        '2013-12-5
        If pi(0).PO_Check = True Then
            MsgBox("此出貨單已經審核,不允許更改審核狀態")
            Exit Sub
        End If
        '-------------------------------------------------------------

        '---------------------------
        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As ProductInventoryOut
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is ProductInventoryOut Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New ProductInventoryOut
        fr.EditItem = "Check"
        fr.EditValue = GridView1.GetFocusedRowCellValue("PO_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
#End Region


#Region "窗體初始化"
    ''' <summary>
    '''     窗體啟動事件
    ''' </summary>
    Private Sub ProductionWareOutMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim IntCheck As Integer = 0

        WareInVoid(0, strWareValeOut, strWareValeIn, "Out")

        IntCheck = FunWareCheck(0, "881009")
        If IntCheck > 0 Then
            lblCheck.Text = "(" + CStr(IntCheck) + "筆)" + "末審核"
        Else
            lblCheck.Text = String.Empty
        End If



        Select Case XtraTabControl1.SelectedTabPageIndex
            Case 0
                DateFill(0)
            Case 1
                DateFill(1)
        End Select

        PowerUser()
    End Sub
#End Region

#Region "設置權限"
    ''' <summary>
    '''    設置權限
    ''' </summary>
    Sub PowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881001")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutAdd.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881002")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutEdit.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881003")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutDel.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881004")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutCheck.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "881007")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareInInCheck.Enabled = True
        End If
    End Sub
#End Region

#Region "按鍵事件"
    ''' <summary>
    '''    按鍵事件多頁面
    ''' </summary>
    Private Sub XtraTabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Click
        DateFill(XtraTabControl1.SelectedTabPageIndex)
    End Sub
#End Region

#Region "方法程序"
    Private Sub WareInVoid(ByVal FunInt As Integer, ByVal FunWareOut As String, ByVal FunWareIn As String, ByVal StrGrid As String)
        Dim StartDate As String
        StartDate = Format(Now, "yyyy/MM") & "/01"


        Dim WareSelectIn As String = FunWareSelect(FunWareIn)
        Dim WareSelectOut As String = FunWareSelect(FunWareOut)


        '-----------------------------------------------------------------------------------------
        ''新增2013-12-5
        Dim pc As New ProductInventoryOutControl
        Grid.DataSource = pc.ProductInventoryOut_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, WareSelectOut, StartDate, Format(Now, "yyyy/MM/dd"), Nothing)

        '-----------------------------------------------------------------------------------------


    End Sub
    Function FunWareCheck(ByVal FunInt As Integer, ByVal FunWare As String) As Integer
        Dim pi As List(Of ProductInventoryOutInfo)
        Dim pc As New ProductInventoryOutControl
        Dim WareSelect As String = FunWareSelect(FunWare)
        pi = pc.ProductInventoryOut_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, WareSelect, Nothing, Nothing, "false")
        FunWareCheck = pi.Count

    End Function
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
    Private Sub DateFill(ByVal indexA As Integer)
        Select Case indexA
            Case 0
                '-------------------------------------------------


                WareInVoid(0, strWareValeOut, strWareValeIn, "Out")
                Dim IntCheck As Integer = 0
                IntCheck = FunWareCheck(0, strWareValeOut)
                If IntCheck > 0 Then
                    lblCheck.Text = "(" + CStr(IntCheck) + "筆)" + "末審核"
                Else
                    lblCheck.Text = String.Empty
                End If

            Case 1
                '-------------------------------------------------


                WareInVoid(1, strWareValeOut, strWareValeIn, "In")
                Dim IntCheck As Integer = 0
                IntCheck = FunWareCheck(1, strWareValeIn)
                If IntCheck > 0 Then
                    lblCheck.Text = "(" + CStr(IntCheck) + "筆)" + "末收貨"
                Else
                    lblCheck.Text = String.Empty
                End If

        End Select
    End Sub
#End Region

#Region "報表匯總"
    Private Sub popWareInTotalAReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareInTotalAReport.Click, popWareInTotalBReport.Click

        'Dim frm As New frmWarePrint
        'frm.EditItem = "ProductionWareShipped"
        'frm.ShowDialog()
    End Sub
#End Region

#Region "自動刷新"
    Private Sub ProductInventoryOutMain_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        popWareOutflesh_Click(Nothing, Nothing)
    End Sub
#End Region

End Class