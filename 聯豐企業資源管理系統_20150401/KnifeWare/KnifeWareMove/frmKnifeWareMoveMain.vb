Imports LFERP.Library.WareHouse.WareMove
Imports LFERP.Library.WareHouse
Imports LFERP.SystemManager
Imports LFERP.Library.WareHouse.WareSelect
Imports LFERP.Library.KnifeWare
'Imports Microsoft.Office.Interop
'Imports Microsoft.Office.Core

Public Class frmKnifeWareMoveMain
    Private LableText As String
    Private Sub frmKnifeWareMoveMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mt As New WareHouseController
        'mt.WareHouse_LoadToTreeView(TreeView1, WareSelect(InUserID, "510306"))
        KnifeWareTreeView = TreeView1
        KnifeWareBarManager = BarManager1
        KnifeWareLoad(ImageList1, "510306")
        'isBarCode = False
        LoadUserPower()
        'tv1.CollapseAll()
    End Sub

    Sub LoadUserPower()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510301")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdAdd.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510302")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdEdit.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510303")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdDel.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510304")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdIn.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510305")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdCheck.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510307")
        If pmwiL.Count > 0 Then
            '  If pmwiL.Item(0).PMWS_Value = "是" Then isBarCode = True
        End If

        '2014-02-28   姚駿  修改審核權限備註
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510311")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdRemarkEdit.Enabled = True : cmdRemarkEdit.Visible = True
        End If



        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510310")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdAddKnife.Enabled = True
        End If

    End Sub
    Private Sub popKnifeWareMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click, cmdView.Click, cmdSeek.Click, cmdPrint.Click, cmdLook.Click, cmdIn.Click, cmdflesh.Click, cmdEdit.Click, cmdDel.Click, cmdCopyAll.Click, cmdCopy.Click, cmdCheck.Click, cmdAddKnife.Click, cmdRemarkEdit.Click
        Select Case sender.Name
            Case "cmdAdd"
                On Error Resume Next
                If TreeView1.SelectedNode Is Nothing Then
                    MsgBox("請選擇正確的倉庫!", 64, "提示")
                    Exit Sub
                Else
                    Dim fr As frmKnifeWareMoveOut
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmKnifeWareMoveOut Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next
                    tempValue2 = TreeView1.SelectedNode.Tag
                    tempValue3 = TreeView1.SelectedNode.Text

                    fr = New frmKnifeWareMoveOut
                    fr.EditItem = "KnifeWareMoveAddNew"
                    'fr.isBarCode = isBarCode
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Maximized
                    fr.Show()
                End If
            Case "cmdAddKnife"
                On Error Resume Next
                If TreeView1.SelectedNode Is Nothing Then
                    MsgBox("請選擇正確的倉庫!", 64, "提示")
                    Exit Sub
                Else
                    Dim fr As frmKnifeWareMoveOut
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmKnifeWareMoveOut Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next

                    tempValue2 = TreeView1.SelectedNode.Tag
                    tempValue3 = TreeView1.SelectedNode.Text

                    fr = New frmKnifeWareMoveOut
                    fr.EditItem = "KnifeWareMoveAddOld"
                    'fr.isBarCode = isBarCode
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Maximized
                    fr.Show()
                End If
            Case "cmdEdit" '-------------------------------------------------------------修改
                On Error Resume Next
                Dim osc As New KnifeWareMoveController
                Dim osilist As New List(Of KnifeWareMoveInfo)
                osilist = osc.KnifeWareMove_GetList(GridView1.GetFocusedRowCellValue("MV_NO").ToString, Nothing, Nothing, Nothing, Nothing, "收料", True, Nothing, "1", Nothing)
                If osilist.Count <> 0 Then
                    MsgBox("無法修改,此調撥單已確認！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "提示")
                    Exit Sub
                End If
                osilist = osc.KnifeWareMove_GetList(GridView1.GetFocusedRowCellValue("MV_NO").ToString, Nothing, Nothing, Nothing, Nothing, "收料", Nothing, True, "1", Nothing)
                If osilist.Count <> 0 Then
                    MsgBox("無法修改,此驗收單已審核！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "提示")
                    Exit Sub
                End If
                If GridView1.GetFocusedRowCellValue("MV_InOrOut").ToString <> "發料" Then
                    MsgBox("您隻能對'發料'性質的記錄進行修改刪除操作！", MsgBoxStyle.OkOnly, "提示")
                    Exit Sub
                End If
                tempValue = GridView1.GetFocusedRowCellValue("MV_NO").ToString

                Dim fr As frmKnifeWareMoveOut
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmKnifeWareMoveOut Then
                        fr.Activate()
                        Exit Sub
                    End If
                Next
                fr = New frmKnifeWareMoveOut
                fr.EditItem = "KnifeWareMoveEdit"
                fr.KnifeType = GridView1.GetFocusedRowCellValue("KnifeType").ToString
                fr.EditID = GridView1.GetFocusedRowCellValue("MV_NO").ToString
                fr.MdiParent = MDIMain
                ' fr.isBarCode = isBarCode
                fr.WindowState = FormWindowState.Maximized
                fr.Show()
            Case "cmdDel" '-----------------------------------------------------------------------刪除
                On Error Resume Next
                Dim osc As New LFERP.Library.KnifeWare.KnifeWareMoveController
                Dim osilist As New List(Of LFERP.Library.KnifeWare.KnifeWareMoveInfo)
                osilist = osc.KnifeWareMove_GetList(GridView1.GetFocusedRowCellValue("MV_NO").ToString, Nothing, Nothing, Nothing, Nothing, "收料", True, Nothing, "1", Nothing)
                If osilist.Count <> 0 Then
                    MsgBox("無法刪除,此調撥單已確認！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "提示")
                    Exit Sub
                End If
                osilist = osc.KnifeWareMove_GetList(GridView1.GetFocusedRowCellValue("MV_NO").ToString, Nothing, Nothing, Nothing, Nothing, "收料", Nothing, True, "1", Nothing)
                If osilist.Count <> 0 Then
                    MsgBox("無法刪除,此調撥單已審核！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "提示")
                    Exit Sub
                End If
                If GridView1.GetFocusedRowCellValue("MV_InOrOut").ToString <> "發料" Then
                    MsgBox("您隻能對'發料'性質的記錄進行修改刪除操作！", MsgBoxStyle.OkOnly, "提示")
                    Exit Sub
                End If
                Dim StrA As String
                StrA = GridView1.GetFocusedRowCellValue("MV_NO").ToString
                If MsgBox("你確定刪除調撥單號為  '" & StrA & "'  的記錄嗎?", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                    Dim mc As New KnifeWareMoveInfo
                    Dim mt As New KnifeWareMoveController
                    mc.MV_NO = StrA
                    If mt.KnifeWareMove_DelNO(mc) = True Then
                        Grid1.DataSource = mt.KnifeWareMove_GetList(Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, "2", Nothing)
                    Else
                        MsgBox("刪除失敗", 64, "提示")
                    End If
                End If
            Case "cmdView" '-------------------------------------------------------------------查看
                On Error Resume Next
                'tempValue = GridView1.GetFocusedRowCellValue("MV_NO").ToString
                ' MTypeName = "WareMoveView"
                Dim fr As frmKnifeWareMoveOut
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmKnifeWareMoveOut Then
                        fr.Activate()
                        Exit Sub
                    End If
                Next

                fr = New frmKnifeWareMoveOut
                fr.EditItem = "KnifeWareMoveView"
                fr.EditID = GridView1.GetFocusedRowCellValue("MV_NO").ToString
                fr.MdiParent = MDIMain
                fr.WindowState = FormWindowState.Maximized
                fr.Show()
            Case "cmdLook"
            Case "cmdIn"
                On Error Resume Next
                If GridView1.RowCount = 0 Then Exit Sub

                '2013
                If CheckWHID(GridView1.GetFocusedRowCellValue("DepotNO").ToString) = False Then
                    MsgBox("此用戶無此倉庫收料權限")
                    Exit Sub
                End If

                ' tempValue = GridView1.GetFocusedRowCellValue("MV_NO").ToString
                Dim a As New KnifeWareMoveController
                Dim b As Integer = a.KnifeWareMove_GetList(GridView1.GetFocusedRowCellValue("MV_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, "1", Nothing).Count

                If b > 0 Then
                    MsgBox("此單已審核,無法再收貨！", MsgBoxStyle.OkOnly, "提示")
                    Exit Sub
                End If

                If GridView1.GetFocusedRowCellValue("MV_InOrOut").ToString <> "收料" Then
                    MsgBox("您隻能對'收料'性質的記錄收貨確認操作！", MsgBoxStyle.OkOnly, "提示")
                    Exit Sub
                End If
                ' MTypeName = "WareMoveIn"
                Dim fr As frmKnifeWareMoveOut
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmKnifeWareMoveOut Then
                        fr.Activate()
                        Exit Sub
                    End If
                Next
                fr = New frmKnifeWareMoveOut
                fr.EditItem = "KnifeWareMoveIn"
                fr.EditID = GridView1.GetFocusedRowCellValue("MV_NO").ToString
                fr.MdiParent = MDIMain
                fr.WindowState = FormWindowState.Maximized
                fr.Show()
            Case "cmdCheck"
                '審核
                On Error Resume Next
                If GridView1.RowCount = 0 Then Exit Sub

                '2013
                If CheckWHID(GridView1.GetFocusedRowCellValue("DepotNO").ToString) = False Then
                    MsgBox("此用戶無此倉庫收料權限")
                    Exit Sub
                End If


                'tempValue = GridView1.GetFocusedRowCellValue("MV_NO").ToString
                Dim a As New KnifeWareMoveController
                Dim b As New List(Of KnifeWareMoveInfo)
                '      b = a.WareMove_GetList(tempValue, Nothing, Nothing, Nothing, Nothing, Nothing, False, Nothing, "2")
                b = a.KnifeWareMove_GetList(GridView1.GetFocusedRowCellValue("MV_NO").ToString, Nothing, Nothing, Nothing, Nothing, "收料", True, Nothing, "1", Nothing)
                Dim c As New List(Of KnifeWareMoveInfo)
                c = a.KnifeWareMove_GetList(GridView1.GetFocusedRowCellValue("MV_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, "1", Nothing)
                If c.Count > 0 Then
                    MsgBox("此單已審核,不允許再次操作！", MsgBoxStyle.OkOnly, "提示")
                    Exit Sub
                End If

                If b.Count = 0 Then
                    MsgBox("審核之前需要先收貨!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "提示")
                    Exit Sub
                End If

                If GridView1.GetFocusedRowCellValue("MV_InOrOut").ToString <> "收料" Then
                    MsgBox("您隻能對'收料'性質的記錄進行審核操作！", MsgBoxStyle.OkOnly, "提示")
                    Exit Sub
                End If
                '     Edit = True
                Dim fr As frmKnifeWareMoveOut
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmKnifeWareMoveOut Then
                        fr.Activate()
                        Exit Sub
                    End If
                Next
                fr = New frmKnifeWareMoveOut
                fr.EditItem = "KnifeWareMoveCheck"
                fr.EditID = GridView1.GetFocusedRowCellValue("MV_NO").ToString
                fr.MdiParent = MDIMain
                fr.WindowState = FormWindowState.Maximized
                fr.Show()
            Case "cmdflesh"
            Case "cmdSeek"
                On Error Resume Next
                Dim wmc As New LFERP.Library.KnifeWare.KnifeWareMoveController
                Dim fr As New frmKnifeSelect
                fr.ComboBoxEdit1.Properties.Items.Add("調撥單號")
                tempValue = "刀具調撥"
                tempValue4 = TreeView1.SelectedNode.Tag
                fr.ShowDialog()
                If RefreshT = True Then
                    Select Case tempValue
                        Case 1
                            Grid1.DataSource = wmc.KnifeWareMove_GetList(tempValue2, Nothing, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                        Case 2
                            Grid1.DataSource = wmc.KnifeWareMove_GetList(Nothing, tempValue2, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                        Case 3
                            Grid1.DataSource = wmc.KnifeWareMove_GetList(Nothing, Nothing, tempValue2, tempValue4, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                        Case 4
                            Grid1.DataSource = wmc.KnifeWareMove_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                        Case 5
                            Grid1.DataSource = wmc.KnifeWareMove_GetList(Nothing, Nothing, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2)
                        Case 6
                            Dim ws As New KnifeWareSelectController
                            Grid1.DataSource = ws.WareMove_Getlist("刀具調撥", tempValue2)
                            RefreshT = False
                    End Select
                    tempValue = ""
                    tempValue2 = ""
                    tempValue4 = ""
                End If
            Case "cmdPrint"
                Dim dss As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim mc As New KnifeWareMoveController

                'Dim strSO_No As String
                'strSO_No = GridView1.GetFocusedRowCellValue("WIP_ID").ToString

                ltc.CollToDataSet(dss, "KnifeWareMove", mc.KnifeWareMove_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

                PreviewRPT(dss, "rptKnifeWareMove", "刀具調撥表", True, True)
                ltc = Nothing
            Case "cmdCopy"
            Case "cmdCopyAll"
            Case "cmdRemarkEdit"         '2014-02-28   姚駿
                On Error Resume Next


                Dim fr As frmKnifeWareMoveOut
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmKnifeWareMoveOut Then
                        fr.Activate()
                        Exit Sub
                    End If
                Next
                fr = New frmKnifeWareMoveOut
                fr.EditItem = "KnifeWareMoveRemarkEdit"
                fr.KnifeType = GridView1.GetFocusedRowCellValue("KnifeType").ToString
                fr.EditID = GridView1.GetFocusedRowCellValue("MV_NO").ToString
                fr.MdiParent = MDIMain

                fr.WindowState = FormWindowState.Maximized
                fr.Show()

        End Select
    End Sub



    Function CheckWHID(ByVal strSelectWHID As String) As Boolean
        CheckWHID = False

        Dim strID As String
        ''-------------------------
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510309")
        If pmwiL.Count > 0 Then
            strID = pmwiL.Item(0).PMWS_Value
        Else
            Exit Function
        End If
        ''-------------------------
        Dim arrWHID() As String
        arrWHID = strID.Split(",")
        Dim i As Integer
        For i = 0 To arrWHID.Length - 1
            If strSelectWHID = arrWHID(i) Then
                CheckWHID = True
                Exit Function
            Else

            End If
        Next
    End Function

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

        tempValue2 = ""
        Dim wmc As New KnifeWareMoveController
        Dim wmi As New KnifeWareMoveInfo
        If e.Node.Level = 0 Then
            Grid1.DataSource = wmc.KnifeWareMove_GetList1(Nothing, Nothing, Nothing, TreeView1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, "2", DateAdd(DateInterval.Day, -30, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
            tempValue2 = TreeView1.SelectedNode.Tag

            tv1.ExpandAll() 'TV1展開所有目錄

            Dim a As New KnifeWareMoveController
            Dim b, c As Integer
            'Dim b As New List(Of KnifeWareMoveInfo)
            'Dim c As New List(Of KnifeWareMoveInfo)

            b = a.KnifeWareMove_GetList(Nothing, Nothing, Nothing, tempValue2, Nothing, "發料", Nothing, False, "2", Nothing).Count
            c = a.KnifeWareMove_GetList(Nothing, Nothing, Nothing, tempValue2, Nothing, "收料", Nothing, False, "2", Nothing).Count
            If b > 0 Then
                tv1.Nodes.Item(1).Nodes.Item(0).Text = "未審核 (" & b & ")"
                tv1.Nodes.Item(1).Nodes.Item(0).ForeColor = Color.Green
            Else

                tv1.Nodes.Item(1).Nodes.Item(0).Text = "未審核"
                tv1.Nodes.Item(1).Nodes.Item(0).ForeColor = Color.Black

            End If
            If c > 0 Then
                tv1.Nodes.Item(0).Nodes.Item(0).Text = "未審核 (" & c & ")"
                tv1.Nodes.Item(0).Nodes.Item(0).ForeColor = Color.Green
            Else

                tv1.Nodes.Item(0).Nodes.Item(0).Text = "未審核"
                tv1.Nodes.Item(0).Nodes.Item(0).ForeColor = Color.Black

            End If
        End If
        tv1.Nodes.Item(1).Text = "發出項目"

    End Sub

    Private Sub tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv1.AfterSelect
        Dim wmc As New KnifeWareMoveController
        Dim wmi As New KnifeWareMoveInfo
        If e.Node.Level = 1 Then
            Select Case Mid(tv1.SelectedNode.Text, 1, 3)
                Case "未審核"
                    If tv1.SelectedNode.Parent.Text = "收入項目" Then
                        Grid1.DataSource = wmc.KnifeWareMove_GetList1(Nothing, Nothing, Nothing, tempValue2, Nothing, "收料", Nothing, False, "2", Nothing, Nothing)
                    End If
                    If tv1.SelectedNode.Parent.Text = "發出項目" Then
                        Grid1.DataSource = wmc.KnifeWareMove_GetList1(Nothing, Nothing, Nothing, tempValue2, Nothing, "發料", Nothing, False, "2", Nothing, Nothing)
                    End If
                Case "已審核"
                    If tv1.SelectedNode.Parent.Text = "收入項目" Then
                        Grid1.DataSource = wmc.KnifeWareMove_GetList1(Nothing, Nothing, Nothing, tempValue2, Nothing, "收料", Nothing, True, "2", DateAdd(DateInterval.Day, -30, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
                    End If
                    If tv1.SelectedNode.Parent.Text = "發出項目" Then
                        Grid1.DataSource = wmc.KnifeWareMove_GetList1(Nothing, Nothing, Nothing, tempValue2, Nothing, "發料", Nothing, True, "2", DateAdd(DateInterval.Day, -30, CDate(Format(Now, "yyyy/MM/dd"))), CDate(Format(Now, "yyyy/MM/dd")))
                    End If
            End Select
            '    Label1.Text = Mid(tv1.SelectedNode.Text, 1, 3) & tv1.SelectedNode.Parent.Text
            ' Grid1.DataSource = wmc.WareMove_GetList("2")
        End If
    End Sub

    'Private Sub frmKnifeWareMoveMain_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    '    'KnifeWareTreeView = TreeView1
    '    'KnifeWareBarManager = BarManager1
    '    'KnifeWareLoad(ImageList1, "510306")
    '    'tv1.ExpandAll()
    'End Sub

    Private Sub TreeView1_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        Dim str2 As String = TreeView1.SelectedNode.Tag
    End Sub

    Private Sub ToolStripMoveRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMoveRecord.Click
        frmBrrowList.ReportTypeID = "KnifeWareMove"
        frmBrrowList.ReportTypeName = "刀具調撥記錄"
        frmBrrowList.ShowDialog()
        frmBrrowList.Dispose()
    End Sub
End Class