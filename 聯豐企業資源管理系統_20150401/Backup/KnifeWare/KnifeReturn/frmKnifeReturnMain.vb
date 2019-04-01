Imports LFERP.Library.WareHouse
Imports LFERP.Library.KnifeWare
Imports LFERP.SystemManager

Public Class frmKnifeReturnMain

    Dim ds As New DataSet

    Private Sub frmKnifeReturnMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mt As New WareHouseController

        ''mt.WareHouse_LoadToTreeView(TreeView1, WareSelect("12022419", "50100101"))
        'Dim str As String = "'W40','W50'"
        'mt.WareHouse_LoadToTreeView(tv1, str)

        'KnifeWareTreeView = tv1
        'KnifeWareBarManager = BarManager1
        'KnifeWareLoad(ImageList1, "510605")
        XtraTabControl1.SelectedTabPage = XtraTabPage1
        CreateTables()
        LabMsg.Text = ""
        LabPerNO.Text = ""
        labLsPerNO.Text = ""
        labLsPerName.Text = ""
        LoadBar()

    End Sub

    Function CheckWHID(ByVal strSelectWHID As String) As Boolean
        CheckWHID = False

        Dim strID As String
        ''-------------------------
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510601")
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


    Private Sub ToolReurnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolReurnNew.Click, ToolReurnOLD.Click, ToolReurnNewold.Click, rpToolReurnNew.Click, rpToolReurnOLD.Click, rpToolReurnNewold.Click
        If CheckWHID(Me.tv1.SelectedNode.Tag) = False Then
            MsgBox("無此倉庫權限", 64, "提示")
            Exit Sub
        End If

        '(ReturnNew--本人還新刀)
        '(ReturnOld--本人還待處理)
        '(ReturnNewOld--本人還待換新)

        '(ReReturnNew--待還新刀)
        '(ReReturnOld--待還待處理)
        '(ReReturnNewOld--待還待換新)

        If Me.GridView4.RowCount <= 0 Then
            Exit Sub
        End If

        If tv1.SelectedNode Is Nothing Then
            MsgBox("請正確選擇倉庫!", 64, "提示")
            Exit Sub
        Else
        End If

        tempValue = sender.tag
        tempValue2 = tv1.SelectedNode.Tag
        tempValue3 = tv1.SelectedNode.Text

        tempValue4 = Me.GridView2.GetFocusedRowCellValue("W_UserID").ToString
        tempValue5 = Me.GridView2.GetFocusedRowCellValue("W_UserName").ToString

        frmKnifeReturn.ShowDialog()
        frmKnifeReturn.Dispose()
    End Sub

    '''' <summary>
    '''' 判斷是否是夜班倉
    '''' </summary>
    '''' <param name="StrWHID"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Function GetNightWareHouse(ByVal StrWHID As String) As Boolean
    '    Dim strWHRemark As String
    '    GetNightWareHouse = False

    '    Dim wc As New WareHouseController
    '    Dim wl As New List(Of WareHouseInfo)
    '    wl = wc.WareHouse_Get(StrWHID)
    '    strWHRemark = wl(0).WH_Remark  '如果是夜班倉

    '    If strWHRemark = "夜班倉" Or strWHRemark = "Night" Then
    '        GetNightWareHouse = True
    '    End If
    'End Function

    Private Sub tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv1.AfterSelect
        If e.Node.Level = 0 Then
            Dim GW As New KnifeWhiteUserController
            Dim rc As New KnifeReturnControl

            Grid5.DataSource = Nothing


            Grid4.DataSource = Nothing
            Grid3.DataSource = rc.KnifeReturn_GetListTop100(Nothing, Nothing, Nothing, tv1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            FreshGrid2(tv1.SelectedNode.Tag)

            'Grid2.DataSource = GW.WhiteUser_GetList(Nothing, Nothing, tv1.SelectedNode.Tag, Nothing, Nothing, False)
            Grid2.DataSource = GW.KnifeBorrowWhiteUser(tv1.SelectedNode.Tag, Nothing)

            LabMsg.Text = tv1.SelectedNode.Tag & "-" & tv1.SelectedNode.Text
            LabPerNO.Text = ""
            labLsPerNO.Text = ""
            labLsPerName.Text = ""

            'If GetNightWareHouse(tv1.SelectedNode.Tag) = True Then ''若是夜班倉
            '    Grid2.DataSource = GW.WhiteUser_NightGetList(tv1.SelectedNode.Tag, Nothing)
            'Else
            '    Grid2.DataSource = GW.WhiteUser_GetList(Nothing, Nothing, tv1.SelectedNode.Tag, Nothing, Nothing, False)
            'End If
        End If


        'If e.Node.Level = 0 Then
        '    Dim GW As New KnifeWhiteUserController
        '    Dim rc As New KnifeReturnControl
        '    If tv1.SelectedNode.Tag = "W5004" Then
        '        Dim arrwhid() As String
        '        arrwhid = WHIDList("510602")
        '        If arrwhid.Length = 0 Then
        '            Grid3.DataSource = Nothing
        '            Grid2.DataSource = Nothing
        '            Exit Sub
        '        Else
        '            Grid3.DataSource = rc.KnifeReturn_GetList(Nothing, Nothing, Nothing, tv1.SelectedNode.Tag, Nothing, DateAdd(DateInterval.Day, -30, CDate(Format(Now, "yyyy/MM/dd"))), Format(Now, "yyyy/MM/dd"), Nothing, Nothing, Nothing)
        '            FreshGrid2(tv1.SelectedNode.Tag)
        '            Dim i As Integer = 0
        '            Dim j As Integer = 0
        '            Dim kwcinfo As New List(Of LFERP.Library.KnifeWare.KnifeWhiteUserInfo)
        '            Dim kwcinfo1 As New List(Of LFERP.Library.KnifeWare.KnifeWhiteUserInfo)
        '            For i = 0 To arrwhid.Length - 1
        '                kwcinfo1 = GW.WhiteUser_GetList(Nothing, Nothing, arrwhid(i), Nothing, Nothing, False)
        '                For j = 0 To kwcinfo1.Count - 1
        '                    kwcinfo.Add(kwcinfo1(j))
        '                Next
        '            Next
        '            Grid2.DataSource = kwcinfo
        '            LabMsg.Text = tv1.SelectedNode.Tag & "-" & tv1.SelectedNode.Text
        '            LabPerNO.Text = ""
        '            labLsPerNO.Text = ""
        '            labLsPerName.Text = ""
        '        End If
        '    Else
        '        Grid3.DataSource = rc.KnifeReturn_GetList(Nothing, Nothing, Nothing, tv1.SelectedNode.Tag, Nothing, DateAdd(DateInterval.Day, -30, CDate(Format(Now, "yyyy/MM/dd"))), Format(Now, "yyyy/MM/dd"), Nothing, Nothing, Nothing)
        '        FreshGrid2(tv1.SelectedNode.Tag)
        '        Grid2.DataSource = GW.WhiteUser_GetList(Nothing, Nothing, tv1.SelectedNode.Tag, Nothing, Nothing, False)
        '        LabMsg.Text = tv1.SelectedNode.Tag & "-" & tv1.SelectedNode.Text
        '        LabPerNO.Text = ""
        '        labLsPerNO.Text = ""
        '        labLsPerName.Text = ""
        '    End If


        '        ' Grid3.DataSource = Nothing
        '    End If
    End Sub

    Function WHIDList(ByVal PMS_ID As String) As String()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        Dim strWHIDList As String
        Dim ArrWHID() As String
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, PMS_ID)
        If pmwiL.Count > 0 Then
            strWHIDList = pmwiL.Item(0).PMWS_Value
            ArrWHID = strWHIDList.Split(",")
        Else
            ArrWHID = Nothing
        End If
        Return ArrWHID
    End Function

    Private Sub ToolStripView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripView.Click
        If Me.GridView3.RowCount <= 0 Then
            Exit Sub
        End If

        Dim strR_NO As String
        strR_NO = Me.GridView3.GetFocusedRowCellValue("R_NO").ToString
        tempValue6 = strR_NO
        tempValue = "View"
        frmKnifeReturn.ShowDialog()
        frmKnifeReturn.Dispose()

    End Sub

    Private Sub ToolStripRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripRefresh.Click
        ' Grid1_Click(Nothing, Nothing)
        Dim rc As New KnifeReturnControl
        Grid3.DataSource = rc.KnifeReturn_GetListTop100(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub OToolStripExel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OToolStripExel.Click
        If GridView3.RowCount = 0 Then Exit Sub
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Title = "導出Excel"
        saveFileDialog.Filter = "Excel2003文件(*.xls)|*.xls"
        '|Excel2007及以上文件(*.xlsx)|*.xlsx  '當前測試2007 以及以上版本有誤！
        Dim dialogResult__1 As DialogResult = saveFileDialog.ShowDialog(Me)
        If dialogResult__1 = Windows.Forms.DialogResult.OK Then
            Grid3.ExportToExcelOld(saveFileDialog.FileName)
            DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripRefreshOnly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripRefreshOnly.Click
        Dim rc As New KnifeReturnControl
        Grid3.DataSource = rc.KnifeReturn_GetListTop100(Nothing, Nothing, Nothing, tv1.SelectedNode.Tag, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub Grid2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid2.Click
        On Error Resume Next
        If GridView2.RowCount <= 0 Then
            Exit Sub
        End If

        Dim StrPer_NO As String

        StrPer_NO = Me.GridView2.GetFocusedRowCellValue("W_UserID").ToString

        Dim kc As New KnifeBorrowControl
        Me.Grid4.DataSource = kc.KnifeBorrow_GetList(Nothing, Nothing, Nothing, tv1.SelectedNode.Tag, StrPer_NO, Nothing, Nothing, Nothing, Nothing, Nothing, "Zero", Nothing)

        Dim rc As New KnifeReturnControl
        Grid3.DataSource = rc.KnifeReturn_GetListTop100(Nothing, Nothing, Nothing, tv1.SelectedNode.Tag, StrPer_NO, Nothing, Nothing, Nothing, Nothing, Nothing)

        labLsPerNO.Text = Me.GridView2.GetFocusedRowCellValue("W_UserID").ToString
        labLsPerName.Text = Me.GridView2.GetFocusedRowCellValue("W_UserName").ToString
        LabPerNO.Text = "領刀人: "

    End Sub


#Region "組別"
    Private Sub GNOaddToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GNOaddToolStrip.Click
        If tv1.SelectedNode Is Nothing Then
            MsgBox("請正確選擇倉庫!", 64, "提示")
            Exit Sub
        Else
            tempValue = tv1.SelectedNode.Tag
            tempValue2 = tv1.SelectedNode.Text
        End If
        'If tv1.SelectedNode.Level = 1 Then
        '    tempValue = tv1.SelectedNode.Tag
        '    tempValue2 = tv1.SelectedNode.Text
        'Else
        '    MsgBox("請選擇倉庫!")
        '    Exit Sub
        'End If

        ''組別維護
        frmKnifeGroupAdd.ShowDialog()
        frmKnifeGroupAdd.Dispose()

        FreshGrid2(tv1.SelectedNode.Tag)
    End Sub


    Private Sub GDeleteToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GDeleteToolStrip.Click
        If GridView1.RowCount = 0 Then Exit Sub
        ''刪除組別時,要判斷在當前組是否存在白名單信息
        Dim strA As String = GridView1.GetFocusedRowCellValue("G_NO").ToString
        Dim WC As New KnifeWhiteUserController
        If WC.WhiteUser_GetList(Nothing, Nothing, Nothing, Nothing, strA, False).Count > 0 Then
            MsgBox("不能刪除,當前組別中存在人員名單!", 64, "提示")
            Exit Sub
        End If

        If MsgBox("你確定要刪除 " & GridView1.GetFocusedRowCellValue("G_Name").ToString & " 這個組別嗎?", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.No Then Exit Sub

        Dim kc As New KnifeGroupControl
        If kc.KnifeGroup_Delete(strA) = True Then
            MsgBox("刪除成功！", 64, "提示")
            FreshGrid2(tv1.SelectedNode.Tag)
        Else
            MsgBox("刪除失敗,請檢查！", 64, "提示")
        End If

    End Sub

    Private Sub Grid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.Click
        If Me.GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        Dim strA, StrB As String
        strA = Me.GridView1.GetFocusedRowCellValue("G_NO").ToString
        StrB = Me.GridView1.GetFocusedRowCellValue("WH_ID").ToString

        Dim GW As New KnifeWhiteUserController
        If strA = "*" Then
            'Grid2.DataSource = GW.WhiteUser_GetList(Nothing, Nothing, StrB, Nothing, Nothing, False)
            Grid2.DataSource = GW.KnifeBorrowWhiteUser(StrB, Nothing)
        Else
            'Grid2.DataSource = GW.WhiteUser_GetList(Nothing, Nothing, StrB, Nothing, strA, False)
            Grid2.DataSource = GW.KnifeBorrowWhiteUser(StrB, strA)
        End If

        Grid4.DataSource = Nothing
        Grid5.DataSource = Nothing
        Grid3.DataSource = Nothing

    End Sub


    ''' <summary>
    ''' 得到組別信息
    ''' </summary>
    ''' <param name="_WH_ID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function FreshGrid2(ByVal _WH_ID As String) As Boolean

        ds.Tables("KnifeGroup").Clear()

        Dim row1 As DataRow
        row1 = ds.Tables("KnifeGroup").NewRow
        row1("G_NO") = "*"
        row1("G_Name") = "全部"
        row1("WH_ID") = _WH_ID
        ds.Tables("KnifeGroup").Rows.Add(row1)

        row1 = ds.Tables("KnifeGroup").NewRow
        row1("G_NO") = "init"
        row1("G_Name") = "未初使化"
        row1("WH_ID") = _WH_ID
        ds.Tables("KnifeGroup").Rows.Add(row1)

        Dim gc As New KnifeGroupControl
        Dim gl As New List(Of KnifeGroupInfo)
        gl = gc.KnifeGroup_GetList(Nothing, Nothing, _WH_ID)

        Dim j As Integer
        If gl.Count > 0 Then
            For j = 0 To gl.Count - 1
                Dim row As DataRow
                row = ds.Tables("KnifeGroup").NewRow
                row("G_NO") = gl(j).G_NO
                row("G_Name") = gl(j).G_Name
                row("WH_ID") = _WH_ID
                ds.Tables("KnifeGroup").Rows.Add(row)
            Next
        End If

    End Function

    Sub CreateTables()
        With ds.Tables.Add("KnifeGroup")
            .Columns.Add("G_NO", GetType(String))
            .Columns.Add("G_Name", GetType(String))
            .Columns.Add("WH_ID", GetType(String))
        End With
        Grid1.DataSource = ds.Tables("KnifeGroup")
    End Sub

    Private Sub ToolStripGNO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripGNO.Click
        If Me.GridView2.RowCount <= 0 Then
            Exit Sub
        End If

        If GetNightWareHouse(tv1.SelectedNode.Tag) = True Then ''若是夜班倉
            MsgBox("此倉為夜班倉,不能分配!")
            Exit Sub
        Else
        End If

        tempValue = Me.GridView2.GetFocusedRowCellValue("W_UserID").ToString
        tempValue2 = tv1.SelectedNode.Tag

        frmGNOdistribute.ShowDialog()
        frmGNOdistribute.Dispose()
    End Sub

#End Region

    Private Sub GridView4_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView4.FocusedRowChanged
        Grid5.DataSource = Nothing

        If GridView4.RowCount <= 0 Then
            Exit Sub
        End If

        Dim strA As String = GridView4.GetFocusedRowCellValue("B_Num").ToString

        Dim kcc As New KnifeChangeControl
        Grid5.DataSource = kcc.KnifeChange_GetList(Nothing, strA, Nothing, Nothing, Nothing, Nothing, Nothing) '"BR_NO"

    End Sub

    Public Sub LoadBar()


        Dim mt As New WareHouseController
        Dim mtl As New List(Of WareHouseInfo)
        mtl = mt.WareHouse_GetList(WareSelect(InUserID, "510603"))

        If mtl.Count <= 0 Then
            Exit Sub
        End If

        Dim i As Integer
        For i = 0 To mtl.Count - 1
            ''-------------------------------------------
            If mtl(i).WH_PID = "" Then
                Dim BarLargeButtonItem As New DevExpress.XtraBars.BarLargeButtonItem
                BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {BarLargeButtonItem})
                Dim bar1 As DevExpress.XtraBars.Bar = BarManager1.Bars.Item(0)
                bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(BarLargeButtonItem)})
                BarLargeButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
                BarLargeButtonItem.Id = i
                BarLargeButtonItem.Glyph = ImageList1.Images(0)
                BarLargeButtonItem.Caption = mtl(i).WH_Name
                BarLargeButtonItem.Tag = mtl(i).WH_ID
                BarLargeButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
                BarLargeButtonItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.Office2003

                AddHandler BarLargeButtonItem.ItemClick, AddressOf KnifeWareLoadEvent
            End If
        Next

        If BarManager1.Items.Count > 0 Then
            Loadtree(BarManager1.Items(0).Tag)
        End If

    End Sub

    Private Sub Loadtree(ByVal sTag As String)
        Dim i As Integer
        Dim mc As New WareHouseController
        Dim mi As New List(Of WareHouseInfo)
        mi = mc.WareHouse_GetList("'" & sTag & "'")
        tv1.Nodes.Clear()
        If mi.Count < 0 Then
            Exit Sub
        End If

        For i = 0 To mi.Count - 1
            If mi(i).WH_PID = "" Then
            Else
                tv1.Nodes.Add(mi(i).WH_Name).Tag = mi(i).WH_ID
            End If
        Next
        tv1.SelectedNode = tv1.Nodes(0)

    End Sub

    Private Sub KnifeWareLoadEvent(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim i As Integer
        Dim sTag As String = CType(sender.PressedLink.Item, DevExpress.XtraBars.BarLargeButtonItem).Tag
        For i = 0 To BarManager1.Bars(0).ItemLinks.Count - 1
            If CType(sender.PressedLink.Item, DevExpress.XtraBars.BarLargeButtonItem).Id = i Then
                CType(sender.PressedLink.Item, DevExpress.XtraBars.BarLargeButtonItem).Down = True
            Else
                CType(BarManager1.Bars(0).ItemLinks(i).Item, DevExpress.XtraBars.BarLargeButtonItem).Down = False
            End If
        Next
        Dim mc As New WareHouseController
        Dim mi As New List(Of WareHouseInfo)
        mi = mc.WareHouse_GetList("'" & sTag & "'")

        tv1.Nodes.Clear()
        If mi.Count < 0 Then
            Exit Sub
        End If

        For i = 0 To mi.Count - 1
            If mi(i).WH_PID = "" Then
            Else
                tv1.Nodes.Add(mi(i).WH_Name).Tag = mi(i).WH_ID
            End If
        Next
        tv1.SelectedNode = tv1.Nodes(0)
    End Sub


    Private Sub ToolStripFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripFind.Click
        Dim rc As New KnifeReturnControl
        Dim fr As New frmKnifeSelect
        fr.ComboBoxEdit1.Properties.Items.Remove("刀具名稱")
        fr.ComboBoxEdit1.Properties.Items.Add("還刀單號")
        fr.ComboBoxEdit1.Properties.Items.Add("還刀流水號")
        tempValue = "刀具還刀"
        Try
            tempValue4 = tv1.SelectedNode.Tag
        Catch ex As Exception
        End Try

        fr.ShowDialog()
        If RefreshT = True Then
            Select Case tempValue
                Case 1
                    Grid3.DataSource = rc.KnifeReturn_GetList(Nothing, tempValue2, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                Case 2
                    Grid3.DataSource = rc.KnifeReturn_GetList(Nothing, Nothing, tempValue2, tempValue4, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                Case 3
                    Grid3.DataSource = rc.KnifeReturn_GetList(Nothing, Nothing, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2)
                Case 4
                    Grid3.DataSource = rc.KnifeReturn_GetList(tempValue2, Nothing, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                Case 5
                    Grid3.DataSource = rc.KnifeReturn_GetList(Nothing, Nothing, Nothing, tempValue4, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing)
                Case 6
                    Dim ws As New KnifeWareSelectController
                    Grid3.DataSource = ws.WareReturn_Getlist("刀具還刀", tempValue2)
                    RefreshT = False
            End Select
            tempValue = ""
            tempValue2 = ""
            tempValue4 = ""
        End If
    End Sub


    Private Sub ReturnToolPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnToolPrint.Click
        If Me.GridView3.RowCount <= 0 Then
            Exit Sub
        End If

        Dim wbc As New KnifeReturnControl
        Dim objInfo As New List(Of KnifeReturnInfo)
        Dim ltc As New CollectionToDataSet
        Dim dsReturnKnife As New DataSet
        objInfo = wbc.KnifeReturn_GetList(Nothing, Me.GridView3.GetFocusedRowCellValue("R_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If objInfo.Count <= 0 Then
            MsgBox("無數據存在!", 64, "提示")
            Exit Sub
        End If

        ltc.CollToDataSet(dsReturnKnife, "KnifeReturn", objInfo)
        PreviewRPTDialog(dsReturnKnife, "rptKnifeReturnRecord", "還刀記錄", True, True)

        ltc = Nothing

    End Sub

    Private Sub ToolStripPrintRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripPrintRecord.Click
        If tv1.SelectedNode.Tag = "" Then
            MsgBox("請先選擇倉庫!", 64, "提示")
            Exit Sub
        End If

        frmBrrowList.ReportWHID = tv1.SelectedNode.Tag
        frmBrrowList.ReportWHName = tv1.SelectedNode.Text

        frmBrrowList.ReportTypeID = "KnifeReturn"
        frmBrrowList.ReportTypeName = "刀具歸還記錄"
        frmBrrowList.ShowDialog()
        frmBrrowList.Dispose()
    End Sub

    '2014-02-08
    Private Sub GridView2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.Click
        Grid5.DataSource = Nothing

        If GridView2.RowCount <= 0 Then
            Exit Sub
        End If

        Dim strA As String = GridView2.GetFocusedRowCellValue("W_UserID").ToString

        Dim kcc As New KnifeChangeControl
        Grid5.DataSource = kcc.KnifeChange_GetList1(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing) '"BR_NO"
    End Sub
End Class