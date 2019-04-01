Imports System
Imports LFERP.SystemManager
Imports LFERP.Library.Product
Imports LFERP.Library.Production.ProuctionWareOutB

Public Class ProductionWareOutMainB

#Region "新增"
    Private Sub popWareOutAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutAdd.Click
        On Error Resume Next
        Edit = False
        Dim fr As ProductionWareOutSubB
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is ProductionWareOutSubB Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New ProductionWareOutSubB
        fr.EditItem = "Add"
        fr.lblFrom.Text = fr.lblFrom.Text + "--新增"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
#End Region

#Region "修改"
    Private Sub popWareOutEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutEdit.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As List(Of ProductionWareOutBInfo)
        Dim pc As New ProductionWareOutBControl
        pi = pc.ProductionWareOutB_GetList(GridView1.GetFocusedRowCellValue("P_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pi(0).P_Check = True Then
            MsgBox("此出貨單已被審核,不允許修改")
            Exit Sub
        Else
            Edit = True
            Dim fr As ProductionWareOutSubB
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is ProductionWareOutSubB Then
                    fr.Activate()
                    Exit Sub
                End If
            Next

            fr = New ProductionWareOutSubB
            fr.EditItem = "Edit"
            fr.lblFrom.Text = fr.lblFrom.Text + "--修改"
            fr.EditValue = GridView1.GetFocusedRowCellValue("P_NO").ToString
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        End If
    End Sub
#End Region

#Region "刪除"
    Private Sub popWareOutDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As List(Of ProductionWareOutBInfo)
        Dim pc As New ProductionWareOutBControl
        pi = pc.ProductionWareOutB_GetList(GridView1.GetFocusedRowCellValue("P_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pi(0).P_Check = True Then
            MsgBox("此出貨單已被審核,不允許修改")
            Exit Sub
        Else
            If MsgBox("確定要刪除編號為" & GridView1.GetFocusedRowCellValue("P_NO").ToString & "的出貨單嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.Yes Then
                If pc.ProductionWareOutB_Delete(GridView1.GetFocusedRowCellValue("P_NO").ToString) = True Then
                    MsgBox("刪除當前出貨單成功!")
                Else
                    MsgBox("刪除失敗,請檢查原因!")
                End If
                Grid.DataSource = pc.ProductionWareOutB_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            End If
        End If
    End Sub
#End Region

#Region "查看"
    Private Sub popWareOutView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutView.Click, popWareInView.Click
        On Error Resume Next
        Select Case XtraTabControl1.SelectedTabPageIndex
            Case 0
                If GridView1.RowCount = 0 Then Exit Sub
            Case 1
                If GridView3.RowCount = 0 Then Exit Sub
        End Select

        Dim fr As ProductionWareOutSubB
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is ProductionWareOutSubB Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New ProductionWareOutSubB
        fr.EditItem = "View"
        fr.lblFrom.Text = fr.lblFrom.Text + "--查看"
        Select Case XtraTabControl1.SelectedTabPageIndex
            Case 0
                fr.EditValue = GridView1.GetFocusedRowCellValue("P_NO").ToString
            Case 1
                fr.EditValue = GridView3.GetFocusedRowCellValue("P_NO").ToString
        End Select

        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
#End Region

#Region "刷新"
    Private Sub popWareOutflesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutflesh.Click, popWareInflesh.Click
        DateFill(XtraTabControl1.SelectedTabPageIndex)
    End Sub
#End Region

#Region "審核"
    Private Sub popWareOutCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutCheck.Click
        On Error Resume Next
        Dim pi As List(Of ProductionWareOutBInfo)
        Dim pc As New ProductionWareOutBControl
        pi = pc.ProductionWareOutB_GetList(GridView1.GetFocusedRowCellValue("P_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pi(0).P_InCheck = True Then
            MsgBox("此出貨單已收貨確認,不允許更改審核狀態")
            Exit Sub
        End If

        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As ProductionWareOutSubB
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is ProductionWareOutSubB Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New ProductionWareOutSubB
        fr.EditItem = "Check"
        fr.lblFrom.Text = fr.lblFrom.Text + "--審核"
        fr.EditValue = GridView1.GetFocusedRowCellValue("P_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
#End Region

#Region "確認收貨"
    Private Sub popWareInInCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareInInCheck.Click
        On Error Resume Next
        Select Case XtraTabControl1.SelectedTabPageIndex
            Case 0
                If GridView1.RowCount = 0 Then Exit Sub
            Case 1
                If GridView3.RowCount = 0 Then Exit Sub
        End Select

        Dim pi As List(Of ProductionWareOutBInfo)
        Dim pc As New ProductionWareOutBControl

        Dim boolPwo As Boolean
        Dim boolCH As Boolean
        Select Case XtraTabControl1.SelectedTabPageIndex
            Case 0
                pi = pc.ProductionWareOutB_GetList(GridView1.GetFocusedRowCellValue("P_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                boolPwo = pi(0).P_Check
                boolCH = pi(0).P_InCheck
            Case 1
                pi = pc.ProductionWareOutB_GetList(GridView3.GetFocusedRowCellValue("P_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                boolPwo = pi(0).P_Check
                boolCH = pi(0).P_InCheck
        End Select

        If boolPwo = False Then
            MsgBox("此出貨單沒審核,不允許收貨")
            Exit Sub
        End If
        If boolCH = True Then
            MsgBox("此出貨單已確認收貨,不允許取消")
            Exit Sub
        End If
        '-------------------------------------------
        Dim fr As ProductionWareOutSubB
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is ProductionWareOutSubB Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New ProductionWareOutSubB
        fr.EditItem = "CheckIn"
        fr.lblFrom.Text = fr.lblFrom.Text + "--確認收貨"
        Select Case XtraTabControl1.SelectedTabPageIndex
            Case 0
                fr.EditValue = GridView1.GetFocusedRowCellValue("P_NO").ToString
            Case 1
                fr.EditValue = GridView3.GetFocusedRowCellValue("P_NO").ToString
        End Select
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
#End Region

#Region "窗體載入"
    Private Sub ProductionWareOutMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        ' ''Dim IntCheck As Integer = 0

        ' ''WareInVoid(0, "880709", "880710", "Out")

        ' ''IntCheck = FunWareCheck(0, "880709", "880710")
        ' ''If IntCheck > 0 Then
        ' ''    lblCheck.Text = "(" + CStr(IntCheck) + "筆)" + "末審核"
        ' ''Else
        ' ''    lblCheck.Text = String.Empty
        ' ''End If

        '' ''-------------------------------------------------
        ' ''WareInVoid(1, "880710", "In")

        ' ''IntCheck = FunWareCheck(1, "880710")
        ' ''If IntCheck > 0 Then
        ' ''    lblCheck.Text = "(" + CStr(IntCheck) + "筆)" + "末收貨"
        ' ''Else
        ' ''    lblCheck.Text = String.Empty
        ' ''End If

        If GridView1.RowCount = 0 Then
            XtraTabControl1.SelectedTabPage = XtraTabPage2
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

#Region "印列"
    Private Sub popWareOutSeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutSeek.Click
        'ProductionWareOutSelect.ShowDialog()
        'Dim pc As New ProductionWareOutControl
        'If tempValue <> Nothing Then
        '    Grid.DataSource = pc.ProductionWareOut_GetList(tempValue4, Nothing, tempValue3, Nothing, tempValue5, Nothing, Nothing, tempValue6, tempValue7, tempValue2, tempValue8)
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


    Private Sub popWareOutReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareOutReport.Click
        'Dim ds As New DataSet
        'If GridView1.RowCount = 0 Then Exit Sub
        'Dim Str As String

        'Str = GridView1.GetFocusedRowCellValue("PWO_NO").ToString

        'Dim ltc As New CollectionToDataSet
        'Dim pc As New ProductionWareOutControl
        'Dim pi As New ProductionWareOutInfo

        'ds.Tables.Clear()

        'ltc.CollToDataSet(ds, "ProductionWareOut", pc.ProductionWareOut_GetList(Str, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        'ds.Tables("ProductionWareOut").Columns.Add("PWO_ID", GetType(Integer))
        'Dim i As Long
        'For i = 0 To ds.Tables("ProductionWareOut").Rows.Count - 1
        '    ds.Tables("ProductionWareOut").Rows(i)("PWO_ID") = i + 1
        'Next

        'PreviewRPT(ds, "ProductionWareOut", "成品出庫單", True, True)

        'ltc = Nothing
    End Sub
#End Region

#Region "設置權限"
    '設置權限
    Sub PowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880701")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880702")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880703")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutDel.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880704") '審核
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareOutCheck.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880707") '確認審核
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareInInCheck.Enabled = True
        End If
    End Sub
#End Region

#Region "方法程序"
    ''' <summary>
    '''    按鍵事件多頁面
    ''' </summary>
    Private Sub XtraTabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Click
        DateFill(XtraTabControl1.SelectedTabPageIndex)
    End Sub

    Private Sub WareInVoid(ByVal FunInt As Integer, ByVal FunWareOut As String, ByVal FunWareIn As String, ByVal StrGrid As String)
        ''Dim WareSelect As String = FunWareSelect(FunWare)
        ''Dim pc As New ProductionWareOutBControl
        ''Select Case FunInt
        ''    Case 0
        ''        If StrGrid = "Out" Then
        ''            Grid.DataSource = pc.ProductionWareOutB_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, WareSelect, Nothing)
        ''        Else
        ''            Grid1.DataSource = pc.ProductionWareOutB_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, WareSelect, Nothing)
        ''        End If
        ''    Case 1
        ''        If StrGrid = "Out" Then
        ''            Grid.DataSource = pc.ProductionWareOutB_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, WareSelect)
        ''        Else
        ''            Grid1.DataSource = pc.ProductionWareOutB_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, WareSelect)
        ''        End If
        ''End Select



        Dim pc As New ProductionWareOutBControl
        Dim WareSelectOut As String = FunWareSelect(FunWareOut)
        Dim WareSelectIn As String = FunWareSelect(FunWareIn)
        Grid.DataSource = pc.ProductionWareOutB_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, WareSelectOut, WareSelectIn)
        Grid1.DataSource = pc.ProductionWareOutB_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, WareSelectOut, WareSelectIn)

    End Sub

    Function FunWareCheck(ByVal FunInt As Integer, ByVal FunWareOut As String, ByVal FunWareIn As String) As Integer
        Dim WareSelectOut As String = FunWareSelect(FunWareOut)
        Dim WareSelectIn As String = FunWareSelect(FunWareIn)

        Dim pc As New ProductionWareOutBControl
        Select Case FunInt
            Case 0
                FunWareCheck = pc.ProductionWareOutB_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "False", Nothing, WareSelectOut, WareSelectIn).Count
            Case 1
                FunWareCheck = pc.ProductionWareOutB_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "False", WareSelectOut, WareSelectIn).Count
        End Select
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

        Dim strWareValeOut As String = "880709"
        Dim strWareValeIn As String = "880710"


        Select Case indexA
            Case 0
                '-------------------------------------------------

                WareInVoid(0, strWareValeOut, strWareValeIn, "Out")
                Dim IntCheck As Integer = 0
                IntCheck = FunWareCheck(0, strWareValeOut, strWareValeIn)
                If IntCheck > 0 Then
                    lblCheck.Text = "(" + CStr(IntCheck) + "筆)" + "末審核"
                Else
                    lblCheck.Text = String.Empty
                End If
            Case 1
                '-------------------------------------------------

                WareInVoid(0, strWareValeOut, strWareValeIn, "In")
                Dim IntCheck As Integer = 0
                IntCheck = FunWareCheck(1, strWareValeOut, strWareValeIn)
                If IntCheck > 0 Then
                    lblCheck.Text = "(" + CStr(IntCheck) + "筆)" + "末收貨"
                Else
                    lblCheck.Text = String.Empty
                End If
        End Select
    End Sub
#End Region

End Class