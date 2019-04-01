Imports LFERP.Library.WareHouse
Imports LFERP.Library.Shared
Imports LFERP.SystemManager
Imports LFERP.DataSetting
Imports LFERP.Library.WareHouse.WareInventory
Imports LFERP.Library.BarCode
Imports LFERP.FileManager
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core
Imports LFERP.Library.Product
Imports LFERP.Library
Imports LFERP.Library.Production.ProductionWareShipped
Imports LFERP.Library.ProductionField

Public Class frmWareInventoryMainNew

    Dim VisibleGrid1 As Boolean
    Dim LoadBZ As String = ""
    Dim strWHName As String = ""


    Private Sub frmWareInventoryMainNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PM_JiYu.Visible = False
        NO_ReQty.Visible = False
        Me.XtraTabPage6.PageVisible = False
        Me.XtraTabPage7.PageVisible = False

        LoadBar()

        'Me.GridShelves.AutoGenerateColumns = False
        'GridShelves.RowHeadersWidth = 15

        Dim mt As New WareHouseController
        Dim wic As New WareInventory.WareInventoryMTController
        Dim wil As New List(Of WareInventory.WareInventoryInfo)
        '  mt.WareHouse_LoadToTreeView(twWare, ErpUser.WareHouseList)

        ' mt.WareHouse_LoadToTreeView(twWare, WareSelect(InUserID, "500401"))

        VisibleGrid1 = False

        PowerUser()

        ' ''警告 查詢顯示
        'If tempValue <> "" Then

        '    Grid1.DataSource = wic.WareInventory_GetList2(Nothing, tempValue)
        '    ' MsgBox(tempValue)
        '    tempValue = ""
        'End If
        SplitContainer3.Panel2MinSize = 0
        SplitContainer3.SplitterDistance = SplitContainer3.Height + 100

        If VisibleGrid1 = True Then

            GridControl1.Visible = True
            ' Grid1.DataSource = wic.WareInventory_GetSum(Nothing, "False")     '@2012/12/21  添加
            SplitContainer3.SplitterDistance = SplitContainer3.Height - 120
            Me.XtraTabInvent.SelectedTabPage = XtraTabInvent.TabPages(0)
        End If


        LoadBZ = "Y"



    End Sub

    Sub LoadBar()
        Dim FirstWH As String = ""

        Dim mt As New WareHouseController
        Dim mtl As New List(Of WareHouseInfo)
        mtl = mt.WareHouse_GetList(WareSelect(InUserID, "500401"))

        If mtl.Count <= 0 Then
            Exit Sub
        End If

        Dim i, j As Integer
        For i = 0 To mtl.Count - 1
            ''-------------------------------------------
            If mtl(i).WH_PID = "" Then
                Dim BarLargeButtonItems As New DevExpress.XtraBars.BarLargeButtonItem

                BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {BarLargeButtonItems})
                Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(BarLargeButtonItems)})
                BarLargeButtonItems.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
                BarLargeButtonItems.Id = i

                If j > 11 Then
                    BarLargeButtonItems.Glyph = Me.ImageCollection1.Images(11)
                Else
                    BarLargeButtonItems.Glyph = Me.ImageCollection1.Images(j)
                End If

                BarLargeButtonItems.Caption = mtl(i).WH_Name
                BarLargeButtonItems.Tag = mtl(i).WH_ID
                BarLargeButtonItems.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
                BarLargeButtonItems.Name = Trim("WHBarLargeButtonItem" & j)
                BarLargeButtonItems.Border = DevExpress.XtraEditors.Controls.BorderStyles.Office2003

                If i = 0 Then
                    BarLargeButtonItems.Down = True
                    FirstWH = mtl(i).WH_ID
                End If


                AddHandler BarLargeButtonItems.ItemClick, AddressOf MyEvent
                j = j + 1
            End If
        Next


        ''---------默認載入第一個--------------------------------------------
        Dim mtll As New List(Of WareHouseInfo)
        mtll = mt.WareHouse_GetList("'" & FirstWH & "'")
        twWare.Nodes.Clear()
        If mtll.Count <= 0 Then
            Exit Sub
        End If

        Dim ii As Integer
        For ii = 0 To mtll.Count - 1
            If mtll(ii).WH_PID = "" Then
            Else
                twWare.Nodes.Add(mtll(ii).WH_Name).Tag = mtll(ii).WH_ID
            End If
        Next

        twWare.SelectedNode = twWare.Nodes(0)
        ''---------------------------------------------------------------------


    End Sub


    Private Sub MyEvent(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim j As Integer
        Dim sTag As String = CType(sender.PressedLink.Item, DevExpress.XtraBars.BarLargeButtonItem).Tag
        Dim strWHName As String = CType(sender.PressedLink.Item, DevExpress.XtraBars.BarLargeButtonItem).Caption
        For j = 0 To Bar2.ItemLinks.Count - 1
            If CType(sender.PressedLink.Item, DevExpress.XtraBars.BarLargeButtonItem).Name = Trim("WHBarLargeButtonItem" & j) Then
                CType(sender.PressedLink.Item, DevExpress.XtraBars.BarLargeButtonItem).Down = True
            Else
                CType(Bar2.ItemLinks(j).Item, DevExpress.XtraBars.BarLargeButtonItem).Down = False
            End If
        Next
        '-----------------------------------------------------------------
        Dim mt As New WareHouseController
        Dim mtl As New List(Of WareHouseInfo)
        mtl = mt.WareHouse_GetList("'" & sTag & "'")

        twWare.Nodes.Clear()

        If mtl.Count <= 0 Then
            Exit Sub
        End If

        Dim i As Integer
        For i = 0 To mtl.Count - 1
            If mtl(i).WH_PID = "" Then
            Else
                twWare.Nodes.Add(mtl(i).WH_Name).Tag = mtl(i).WH_ID
            End If
        Next

        twWare.SelectedNode = twWare.Nodes(0)

    End Sub

    Sub PowerUser() '設置權限與出庫新增相同（如果用戶擁有出庫的權限允許更改安全庫存數量）
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500402")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareInventorySafe.Enabled = True '
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500403")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popChangePrice.Enabled = True '
        End If

        '@2013/1/11 添加
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500404")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then VisibleGrid1 = True
        End If

        ''2013-2-22 磨刀部條碼打印
        popWareInventoryBarCode.Enabled = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500405")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareInventoryBarCode.Enabled = True
        End If

        popWareInventoryBarCodeMD.Enabled = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500406")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popWareInventoryBarCodeMD.Enabled = True
        End If

        ToolStripDetail.Visible = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500407")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripDetail.Visible = True
        End If

        ''---------------------------------------

        ToolStripMothPrice.Visible = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500408")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripMothPrice.Visible = True
        End If

        ToolStripMonthDetail.Visible = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500409")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripMonthDetail.Visible = True
        End If



        ''直接出入庫權限
        'ToolStripInput ToolStripOutput
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500410")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripInput.Visible = True : ToolStripOutput.Visible = True : ToolStripMenuItem4.Visible = True
        End If

        ToolStripWareInventoryNG.Enabled = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500411")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripWareInventoryNG.Enabled = True
        End If

        '


    End Sub
    Private Sub twWare_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles twWare.AfterSelect
        Dim mt As New WareInventory.WareInventoryMTController
        Dim pt As New ProductInventoryController

        If twWare.SelectedNode.Level = 0 Then
            mt.LoadNodes(twType, twWare.SelectedNode.Tag())
            WI_Qty.FieldName = "WI_Qty"
            GridColumn5.Visible = True
            PM_JiYu.Visible = False
            NO_ReQty.Visible = False
            Me.XtraTabPage6.PageVisible = False
            Me.XtraTabPage7.PageVisible = False
            ToolStripShowSa.Visible = False

            If twWare.SelectedNode.Tag = "W1101" Then      '@ 2013/4/2  添加
                WI_Qty.FieldName = "PI_Qty"
                GridColumn5.Visible = False
                PM_JiYu.Visible = True
                Grid1.DataSource = pt.ProductInventory_GetList(Nothing, Nothing, "W1101", 0)
                ''暫時先這樣---------------------------------------------
                Dim mtc As New Material.MaterialTypeController
                twType.Nodes.Clear()
                ' mtc.LoadNodes(twType, "40")
                '-------------------------------------------
            ElseIf twWare.SelectedNode.Tag = "W6001" Then
                PM_JiYu.Visible = True
            ElseIf twWare.SelectedNode.Tag = "W2101" Then
                NO_ReQty.Visible = True
                Me.XtraTabPage6.PageVisible = True
                Me.XtraTabPage7.PageVisible = True
                Me.ToolStripShowSa.Visible = True
            End If

            '--------查詢是否是次品倉---------------------
            If GetWH_Remark(twWare.SelectedNode.Tag) = "NG" Then
                NGType.VisibleIndex = 0
                NGName.VisibleIndex = 1
                NGMaterial.VisibleIndex = 2
                ToolStripWareInventoryNG.Visible = True
                GridColumn4.Visible = False
            Else
                NGType.Visible = False
                NGName.Visible = False
                NGMaterial.Visible = False
                ToolStripWareInventoryNG.Visible = False
                GridColumn4.Visible = True
            End If

            'twType.ExpandAll()
            ''---------------------------------------------------------------------------------------------------
            If twType.Nodes.Count > 0 Then
                Dim k, l As Integer
                For k = 0 To twType.Nodes.Count - 1
                    twType.Nodes(k).Expand()
                    'For l = 0 To twType.Nodes(k).Nodes.Count - 1
                    '    twType.Nodes(k).Nodes(l).Expand()
                    'Next
                Next
                twType.SelectedNode = twType.Nodes(0)
            End If
            ''---------------------------------------------------------------------------------------------------

        End If

        If VisibleGrid1 = True Then
            If twWare.SelectedNode.Level = 1 Or twWare.SelectedNode.Level = 0 Then
                Dim wic As New WareInventory.WareInventoryMTController
                Grid1.DataSource = wic.WareInventory_GetSum(Nothing, "False")     '@2012/12/21  添加
            End If
        End If

        If twWare.SelectedNode.Tag = "W1101" Then
        Else
            Grid1.DataSource = Nothing
        End If


        GridControl1.DataSource = Nothing

        GridInput.DataSource = Nothing
        GridMVOUT.DataSource = Nothing
        GridMVIN.DataSource = Nothing
        GridBroow.DataSource = Nothing
        GridReturn.DataSource = Nothing

    End Sub


    Function GetWH_Remark(ByVal strWH_ID As String) As String
        GetWH_Remark = ""
        Dim mt As New WareHouseController
        Dim mtl As New List(Of WareHouseInfo)
        mtl = mt.WareHouse_Get(strWH_ID)

        If mtl.Count > 0 Then
            GetWH_Remark = mtl(0).WH_Remark
        End If


    End Function

    Private Sub twType_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles twType.AfterSelect
        Dim mt As New WareInventory.WareInventoryMTController

        If twType.SelectedNode.Level = 3 Then
            'Grid.DataSource = mt.WareInventory_GetMaterial(twType.SelectedNode.Tag, twWare.SelectedNode.Tag, Nothing)
            If Me.twWare.SelectedNode.Tag = "W2101" Then
                Grid1.DataSource = mt.WareBorrowReturnInventory_GetList(twWare.SelectedNode.Tag, twType.SelectedNode.Tag, Nothing)
            ElseIf Me.twWare.SelectedNode.Tag = "W1101" Then
                Dim pt As New ProductInventoryController
                Grid1.DataSource = pt.ProductInventory_GetList(Nothing, Nothing, "W1101", 0)
            Else
                Grid1.DataSource = mt.WareInventory_GetListType123(Nothing, Nothing, twType.SelectedNode.Tag, twWare.SelectedNode.Tag, Nothing)
            End If

            GridControl1.DataSource = Nothing
            GridInput.DataSource = Nothing
            GridMVOUT.DataSource = Nothing
            GridMVIN.DataSource = Nothing
            GridBroow.DataSource = Nothing
            GridReturn.DataSource = Nothing
        ElseIf twType.SelectedNode.Level = 2 Then
            If Me.twWare.SelectedNode.Tag = "W2101" Then
                Grid1.DataSource = mt.WareBorrowReturnInventory_GetList(twWare.SelectedNode.Tag, twType.SelectedNode.Tag, Nothing)
            Else
                Grid1.DataSource = mt.WareInventory_GetListType123(Nothing, twType.SelectedNode.Tag, Nothing, twWare.SelectedNode.Tag, Nothing)
            End If

            GridControl1.DataSource = Nothing
            GridInput.DataSource = Nothing
            GridMVOUT.DataSource = Nothing
            GridMVIN.DataSource = Nothing
            GridBroow.DataSource = Nothing
            GridReturn.DataSource = Nothing
        ElseIf twType.SelectedNode.Level = 1 Then
            If Me.twWare.SelectedNode.Tag = "W2101" Then
                Grid1.DataSource = mt.WareBorrowReturnInventory_GetList(twWare.SelectedNode.Tag, twType.SelectedNode.Tag, Nothing)
            Else
                Grid1.DataSource = mt.WareInventory_GetListType123(twType.SelectedNode.Tag, Nothing, Nothing, twWare.SelectedNode.Tag, Nothing)
            End If
            GridControl1.DataSource = Nothing
            GridInput.DataSource = Nothing
            GridMVOUT.DataSource = Nothing
            GridMVIN.DataSource = Nothing
            GridBroow.DataSource = Nothing
            GridReturn.DataSource = Nothing
        End If


            ''If twType.SelectedNode.Level = 3 Then
            ''    'Grid.DataSource = mt.WareInventory_GetMaterial(twType.SelectedNode.Tag, twWare.SelectedNode.Tag, Nothing)
            ''    If Me.twWare.SelectedNode.Tag = "W2101" Then
            ''        Grid1.DataSource = mt.WareBorrowReturnInventory_GetList(twWare.SelectedNode.Tag, twType.SelectedNode.Tag, Nothing)
            ''    ElseIf Me.twWare.SelectedNode.Tag = "W1101" Then
            ''        Dim pt As New ProductInventoryController
            ''        Grid1.DataSource = pt.ProductInventory_GetList(Nothing, Nothing, "W1101", 0)
            ''    Else
            ''        Grid1.DataSource = mt.WareInventory_GetMaterial(twType.SelectedNode.Tag, twWare.SelectedNode.Tag, Nothing)
            ''    End If

            ''    GridControl1.DataSource = Nothing
            ''    GridInput.DataSource = Nothing
            ''    GridMVOUT.DataSource = Nothing
            ''    GridMVIN.DataSource = Nothing
            ''    GridBroow.DataSource = Nothing
            ''    GridReturn.DataSource = Nothing

            ''End If
    End Sub

    Private Sub popWareInventorySeek_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popWareInventorySeek.Click
        tempCode = ""
        tempValue6 = "倉庫庫存查詢"
        If Len(twWare.SelectedNode.Tag) = 5 Then
            tempValue5 = twWare.SelectedNode.Tag
        Else
            MsgBox("請選擇具體倉庫名稱!", 64, "提示")
            Exit Sub
        End If

        frmBOMSelect.ShowDialog()

        '2013-11-04
        If frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 2 Then
            tempCode = tempValue
        End If


        frmBOMSelect.XtraTabPage2.PageVisible = False
        frmBOMSelect.XtraTabPage3.PageVisible = False

      

        '增加記錄
        If tempCode = "" Then
            Exit Sub
        Else
            Dim mt As New WareInventory.WareInventoryMTController
            Dim pic As New ProductInventoryController

            'Dim strA As String = "'" & tempCode & "'"
            Dim strB As String
            Dim strA As String
            If twWare.SelectedNode.Tag = "W1101" Then          '@ 2013/4/24 修改 查成品倉庫存
                Grid1.DataSource = pic.ProductInventory_GetList(tempCode, Nothing, twWare.SelectedNode.Tag, Nothing)
            ElseIf Me.twWare.SelectedNode.Tag = "W2101" Then
                Grid1.DataSource = mt.WareBorrowReturnInventory_GetList(twWare.SelectedNode.Tag, Nothing, tempCode)
            Else
                If Len(tempCode) > 17 Then
                    strB = Mid(tempCode, 2, Len(tempCode))
                    strA = strB
                    Grid1.DataSource = mt.WareInventory_GetMaterial(Nothing, twWare.SelectedNode.Tag, strA)
                Else
                    strB = tempCode
                    strA = "'" & strB & "'"
                    Grid1.DataSource = mt.WareInventory_GetMaterial(Nothing, twWare.SelectedNode.Tag, strA)
                End If
            End If
        End If
    End Sub

    Private Sub popWareInventoryPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popWareInventoryPrint.Click
        Dim myfrm As New frmWareInventorySeek
        myfrm.ShowDialog()

        If isClickButton = False Then Exit Sub

        Dim ds As New DataSet
        If tempValue = "" Then
            MsgBox("請選擇正確的倉庫！", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim TC As New TempController
        Dim Ti As New TempInfo
        Dim strReportName As String = ""

        Ti.Str1 = tempValue5
        TC.Temp2_Add(Ti)
        If GetWH_Remark(tempValue) = "NG" Then
            If tempValue8 = "基本表" Then
                strReportName = "rptWareInventoryNG"
            ElseIf tempValue8 = "盤點用表" Then
                strReportName = "rptWareInventory1NG"
            End If
        Else
            If tempValue8 = "基本表" Then
                strReportName = "rptWareInventory"
            ElseIf tempValue8 = "盤點用表" Then
                strReportName = "rptWareInventory1"
            End If
        End If
    

        If tempValue5 = "現時" Then
            Dim ltc As New CollectionToDataSet
            Dim ltc1 As New CollectionToDataSet
            Dim ltc3 As New CollectionToDataSet
            Dim ltc4 As New CollectionToDataSet

            Dim pmc As New WareInventory.WareInventoryMTController
            Dim uc As New UnitController
            Dim wh As New WareHouseController


            ds.Tables.Clear()
            Dim strA As String
            strA = tempValue
            tempValue = ""
            If pmc.WareInventory_GetMaterial(Nothing, strA, Nothing).Count = 0 Then
                Exit Sub
            End If

            If pmc.WareInventory_GetMaterial(Nothing, strA, Nothing).Count = 0 Then
                MsgBox("當前倉庫無物料庫存記錄!")
                Exit Sub
            End If

            ltc.CollToDataSet(ds, "WareInventory", pmc.WareInventory_GetMaterial(Nothing, strA, Nothing))
            ltc1.CollToDataSet(ds, "Unit", uc.GetUnitList(Nothing))
            ltc3.CollToDataSet(ds, "WareHouse", wh.WareHouse_GetList(Nothing))
            ltc4.CollToDataSet(ds, "Temp2", TC.Temp2_GetList(Nothing, Nothing, Nothing))

            PreviewRPT1(ds, strReportName, "庫存表", UserName, "l", True, True)
            ltc = Nothing
            ltc1 = Nothing
            ltc4 = Nothing
            ltc3 = Nothing
        Else
            Dim ltc As New CollectionToDataSet
            Dim ltc1 As New CollectionToDataSet
            Dim ltc3 As New CollectionToDataSet
            Dim ltc4 As New CollectionToDataSet

            Dim pmc As New WareInventory.WareInventoryMTController
            Dim uc As New UnitController
            Dim wh As New WareHouseController


            ds.Tables.Clear()
            Dim strA As String
            strA = tempValue
            tempValue = ""

            If pmc.WareInventoryBackup_GetMaterial(Nothing, strA, Nothing, tempValue6, tempValue7).Count = 0 Then
                MsgBox("當前倉庫月份庫存記錄不存在,請檢查原因!")
                Exit Sub
            End If


            ltc.CollToDataSet(ds, "WareInventory", pmc.WareInventoryBackup_GetMaterial(Nothing, strA, Nothing, tempValue6, tempValue7))
            ltc1.CollToDataSet(ds, "Unit", uc.GetUnitList(Nothing))
            ltc3.CollToDataSet(ds, "WareHouse", wh.WareHouse_GetList(Nothing))
            ltc4.CollToDataSet(ds, "Temp2", TC.Temp2_GetList(Nothing, Nothing, Nothing))

            PreviewRPT1(ds, strReportName, "庫存表", UserName, "l", True, True)
            ltc = Nothing
            ltc1 = Nothing
            ltc4 = Nothing
            ltc3 = Nothing
        End If

        tempValue5 = ""
        tempValue = ""
        tempValue6 = ""
        tempValue7 = ""
        tempValue8 = ""
    End Sub

    Private Sub popWareInventorySafe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWareInventorySafe.Click
        If GridView2.RowCount = 0 Then Exit Sub

        tempValue2 = GridView2.GetFocusedRowCellValue("WI_SafeQty").ToString
        tempValue4 = GridView2.GetFocusedRowCellValue("M_Code").ToString

        Dim frm As New frmWareInventorySafe
        frm.ShowDialog()

        If tempValue3 = Nothing Then Exit Sub

        Dim pmc As New WareInventory.WareInventoryMTController
        Dim pi As New WareInventory.WareInventoryInfo

        pi.WH_ID = GridView2.GetFocusedRowCellValue("WH_ID").ToString
        pi.M_Code = tempValue4
        pi.WI_SafeQty = tempValue3
        pi.WI_UserID = InUserID
        pi.WI_EditDate = Format(Now, "yyyy/MM/dd")

        If pmc.WareInventory_Update(pi) = True Then
            MsgBox("更改安全庫存成功！")
            Grid1.DataSource = pmc.WareInventory_GetMaterial(twType.SelectedNode.Tag, twWare.SelectedNode.Tag, Nothing)
        Else
            MsgBox("更改安全庫存失敗，請檢查原因！")
            Exit Sub
        End If
        tempValue3 = ""
        tempValue4 = ""
    End Sub

    '物料出入庫明細查詢
    Private Sub popBatchCodeSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popBatchCodeSelect.Click
        If twWare.SelectedNode.Level = 0 Then
            tempValue = twWare.SelectedNode.Tag
            'If GridView2.RowCount = 0 Then Exit Sub
            If GridView2.RowCount > 0 Then
                tempValue2 = GridView2.GetFocusedRowCellValue("M_Code").ToString
            End If
        Else
            MsgBox("請選擇正確的倉庫!")
            Exit Sub
        End If

        'frmBatchCodeSelect.ShowDialog()
        frmWareInventoryAll.ShowDialog()  '測試
    End Sub

    Private Sub PrintSetBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSetBarCode.Click

        If GridView2.RowCount = 0 Then Exit Sub
        tempValue4 = GridView2.GetFocusedRowCellValue("M_Code").ToString
        Dim frm As New frmWareInventoryBarCode
        frm.ShowDialog()

    End Sub

    Private Sub PrintAllBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintAllBarCode.Click

        Dim pmc As New WareInventory.WareInventoryMTController
        Dim pmi As List(Of WareInventoryInfo)

        pmi = pmc.WareInventory_GetList3(Nothing, twWare.SelectedNode.Tag, "True")

        If pmi.Count = 0 Then
            Exit Sub
        Else
            Dim i As Integer
            For i = 0 To pmi.Count - 1
                Dim bc As New BarCodeControl

                bc.PrintSBar(pmi(i).M_Code, pmi(i).M_Name, "LPT3")   '測試端口!

                Threading.Thread.Sleep(1000)  '延時秒觸發

            Next
        End If

    End Sub


    Private Sub Popexport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Popexport.Click
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub
        If MsgBox("你確定要導出當前所查詢物料的信息嗎?", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.No Then Exit Sub

        'Dim exapp As New Excel.Application
        'Dim exbook As Excel.Workbook
        'Dim exsheet As Excel.Worksheet

        'Dim i As Integer = 0, ii As Integer = 0

        'exapp = CreateObject("Excel.Application")
        'exbook = exapp.Workbooks.Add
        'exsheet = exapp.Worksheets(1)

        'exsheet.Cells(1, 1) = "物料編碼"
        'exsheet.Cells(1, 2) = "物料名稱"
        'exsheet.Cells(1, 3) = "規格"
        'exsheet.Cells(1, 4) = "庫存數量"
        'exsheet.Cells(1, 5) = "安全庫存數"
        'exsheet.Cells(1, 6) = "單位"

        'For i = 0 To GridView2.RowCount - 1
        '    ii = i + 2
        '    exsheet.Cells(ii, 1) = "$" & GridView2.GetRowCellValue(i, "M_Code") & "$"
        '    exsheet.Cells(ii, 2) = GridView2.GetRowCellValue(i, "M_Name")
        '    exsheet.Cells(ii, 3) = GridView2.GetRowCellValue(i, "M_Gauge")
        '    exsheet.Cells(ii, 4) = GridView2.GetRowCellValue(i, "WI_Qty")
        '    exsheet.Cells(ii, 5) = GridView2.GetRowCellValue(i, "WI_SafeQty")
        '    exsheet.Cells(ii, 6) = GridView2.GetRowCellValue(i, "M_Unit")

        'Next
        'exapp.Visible = True

        Dim saveFileDialog As New SaveFileDialog()

        saveFileDialog.Title = "導出Excel"

        saveFileDialog.Filter = "Excel2003文件(*.xls)|*.xls"
        '|Excel2007及以上文件(*.xlsx)|*.xlsx  '當前測試2007 以及以上版本有誤！

        Dim dialogResult__1 As DialogResult = saveFileDialog.ShowDialog(Me)

        If dialogResult__1 = Windows.Forms.DialogResult.OK Then

            GridView2.BestFitColumns()
            Grid1.ExportToExcelOld(saveFileDialog.FileName)

            DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub PrintNetAllBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintNetAllBarCode.Click
        tempValue3 = "指定倉庫打印"
        tempValue4 = twWare.SelectedNode.Tag
        Dim myfrm As New frmBarCode
        myfrm.ShowDialog()
    End Sub

    Private Sub Grid1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid1.MouseUp
        If GridView2.RowCount = 0 Then Exit Sub

        'Dim woc As New WareOut.WareOutController
        'Dim strWHID, strCode As String

        'strWHID = GridView2.GetFocusedRowCellValue("WH_ID").ToString
        'strCode = GridView2.GetFocusedRowCellValue("M_Code").ToString

        'Grid2.DataSource = woc.WareOut_HalfYearGetList(strWHID, strCode, DateAdd(DateInterval.Month, -6, CDate(Format(Now, "yyyy/MM"))), ">=")

    End Sub
    '變更物料單價信息
    Private Sub popChangePrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangePrice.Click

        'Dim frm As New frmWareInventoryChangePrice
        'frm.ShowDialog()
        Dim frm As New frmPrice
        frm.ShowDialog()


    End Sub

    Private Sub COPYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COPYToolStripMenuItem.Click
        Dim FiledNameStr As String
        FiledNameStr = "M_Code,M_Name,M_Gauge,WI_Qty,M_Unit,WI_SafeQty"

        GridViewCopyMulitRow(GridView2, FiledNameStr, "")
    End Sub

    Private Sub ToolStripMenuItemALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemALL.Click
        Dim FiledNameStr As String
        FiledNameStr = "M_Code,M_Name,M_Gauge,WI_Qty,M_Unit,WI_SafeQty"

        GridViewCopyMulitRow(GridView2, FiledNameStr, "ALL")
    End Sub

    Private Sub WareInventMothItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WareInventMothItemToolStripMenuItem.Click

        If twWare.SelectedNode.Level = 0 Then
            tempValue4 = twWare.SelectedNode.Tag
            tempValue5 = twWare.SelectedNode.Text
            WareInventoryMothCollSelect.ShowDialog()
            WareInventoryMothCollSelect.Dispose()
        Else
            MsgBox("請選擇正確的倉庫!")
            Exit Sub
        End If

        'WareInventoryMothCollSelect.ShowDialog()
        'WareInventoryMothCollSelect.Dispose()
    End Sub

    Private Sub RefreshWarringToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshWarringToolStripMenuItem.Click
        Dim tempWHID As String

        If Len(twWare.SelectedNode.Tag) = 5 Then
            tempWHID = twWare.SelectedNode.Tag
        Else
            MsgBox("請選擇具體倉庫名稱!", 64, "提示")
            Exit Sub
        End If

        Dim wic As New WareInventory.WareInventoryMTController
        Dim wil As New List(Of WareInventory.WareInventoryInfo)
        Grid1.DataSource = wic.WareInventory_GetList2(Nothing, tempWHID)

    End Sub

    '2013/2/22
    Private Sub PrintSetBarCodeMD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSetBarCodeMD.Click
        If GridView2.RowCount = 0 Then Exit Sub
        tempValue4 = GridView2.GetFocusedRowCellValue("M_Code").ToString
        tempValue3 = "磨刀部指定打印"

        Dim myfrm As New frmBarCode
        myfrm.ShowDialog()
        myfrm.Dispose()
    End Sub

    Private Sub PrintNetAllBarCodeMD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintNetAllBarCodeMD.Click
        If twWare.SelectedNode.Tag Is Nothing Then Exit Sub

        tempValue3 = "磨刀部指定倉庫"
        tempValue4 = twWare.SelectedNode.Tag
        Dim myfrm As New frmBarCode
        myfrm.ShowDialog()
        myfrm.Dispose()
    End Sub

    '@2013/3/18  添加
    Private Sub GridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        If GridView2.RowCount <= 0 Or LoadBZ <> "Y" Then Exit Sub

        If VisibleGrid1 = True Then

            GridControl1.DataSource = Nothing
            GridInput.DataSource = Nothing
            GridMVOUT.DataSource = Nothing
            GridMVIN.DataSource = Nothing
            GridBroow.DataSource = Nothing
            GridReturn.DataSource = Nothing
            Grid10.DataSource = Nothing

            Dim strWH_ID As String
            Dim strM_Code As String

            strWH_ID = twWare.SelectedNode.Tag
            strM_Code = GridView2.GetFocusedRowCellValue("M_Code").ToString

            LabelControl1.Text = strWH_ID & "  " & strM_Code

            Dim wic As New WareInventory.WareInventoryMTController
            Dim wil As New List(Of WareInventory.WareInventoryInfo)

            GridControl1.DataSource = wic.WareInventory_GetList3(GridView2.GetFocusedRowCellValue("M_Code").ToString, Nothing, "False")

            '入庫
            Dim w1 As New LFERP.Library.WareHouse.WareInput.WareInputContraller
            Me.GridInput.DataSource = w1.WareInput_GetListTop50(Nothing, Nothing, strM_Code, Nothing, strWH_ID, Nothing, Nothing, Nothing, Nothing)

            '出庫
            Dim w2 As New LFERP.Library.WareHouse.WareOut.WareOutController
            GridOut.DataSource = w2.WareOut_GetListTop50(Nothing, Nothing, strM_Code, Nothing, strWH_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            '調撥發出
            Dim w3 As New LFERP.Library.WareHouse.WareMove.WareMoveController
            GridMVOUT.DataSource = w3.WareMove_GetListTop50(Nothing, strM_Code, Nothing, strWH_ID, Nothing, "發料", Nothing, Nothing, "2", Nothing, Nothing)

            '調撥收入
            Dim w4 As New LFERP.Library.WareHouse.WareMove.WareMoveController
            GridMVIN.DataSource = w4.WareMove_GetListTop50(Nothing, strM_Code, Nothing, strWH_ID, Nothing, "收料", Nothing, Nothing, "2", Nothing, Nothing)

            ''裝配出貨
            Dim w8 As New ProductionWareShippedControl
            Me.Grid.DataSource = w8.ProductionWareShipped_GetListTop50(Nothing, Nothing, Nothing, Nothing, strM_Code, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "'" & strWH_ID & "'")


            ''物料收發
            Dim pfc As New Library.ProductionField.ProductionFieldControl
            Grid10.DataSource = pfc.ProductionField_GetList1(Nothing, Nothing, strM_Code, Nothing, Nothing, "收料", Nothing, strWH_ID, Nothing, Nothing, Nothing, DateAdd(DateInterval.Day, -30, CDate(Format(Now, "yyyy/MM/dd"))), Format(Now, "yyyy/MM/dd"), Nothing, Nothing)

            If twWare.SelectedNode.Tag = "W2101" Then
                '借刀
                Dim w5 As New LFERP.Library.WareHouse.WareBorrowReturn.WareBorrowReturnControl
                GridBroow.DataSource = w5.WareBorrowReturn_GetList(Nothing, Nothing, "借刀", strM_Code, Nothing, Nothing, Nothing, strWH_ID, Nothing, Nothing, Nothing, Nothing, Nothing)

                '還刀
                Dim w6 As New LFERP.Library.WareHouse.WareBorrowReturn.WareBorrowReturnControl
                Me.GridReturn.DataSource = w6.WareBorrowReturn_GetList(Nothing, Nothing, "還刀", strM_Code, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            End If

        End If
    End Sub

    Private Sub ToolStripDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDetail.Click
        On Error Resume Next

        tempValue2 = Nothing
        If Me.GridView2.RowCount <= 0 Then
        Else
            tempValue2 = Me.GridView2.GetFocusedRowCellValue("M_Code").ToString
        End If


        Dim fr As frmWareOutINDetails
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmWareOutINDetails Then
                fr.Activate()
                Exit Sub
            End If
        Next


        fr = New frmWareOutINDetails
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub ToolStripMothPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMothPrice.Click

        tempValue = "500408"

        Dim fr As New Form
        fr = frmWareHouseDetailMothPrice
        fr.ShowDialog()
        fr.Dispose()

        tempValue = Nothing

    End Sub

    Private Sub ToolStripMonthDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMonthDetail.Click

        tempValue = "500409"

        Dim fr As New Form
        fr = frmWareHouseDetailMothPrice
        fr.ShowDialog()
        fr.Dispose()

        tempValue = Nothing

    End Sub


    '入庫操作
    Private Sub ToolStripInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripInput.Click
        Dim strA As String = ""

        If Me.GridView2.RowCount > 0 Then
            strA = Me.GridView2.GetFocusedRowCellValue("M_Code").ToString
        End If

        If twWare.Nodes.Count <= 0 Then
            Exit Sub
        End If

        '-----------------------------------------------------------
        On Error Resume Next
        Edit = False
        If twWare.SelectedNode.Level = 0 Or twWare.SelectedNode.Tag = "" Then
            Dim fr As frmWareInput
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmWareInput Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue = "入庫單"
            tempValue3 = twWare.SelectedNode.Tag
            tempValue4 = twWare.SelectedNode.Text
            tempValue5 = strA
            fr = New frmWareInput
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        Else
            MsgBox("請選擇正確的倉庫!")
            Exit Sub
        End If
    End Sub

    Private Sub ToolStripOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripOutput.Click
        Dim strA As String = ""

        If Me.GridView2.RowCount > 0 Then
            strA = Me.GridView2.GetFocusedRowCellValue("M_Code").ToString
        Else
            Exit Sub
        End If
        '-----------------------------------------------------------

        On Error Resume Next
        Edit = False
        If twWare.SelectedNode.Level = 0 Then
            Dim fr As frmWareOut
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmWareOut Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue = "出庫單"
            tempValue3 = twWare.SelectedNode.Tag
            tempValue4 = twWare.SelectedNode.Text
            tempValue5 = strA
            fr = New frmWareOut
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        Else
            MsgBox("請選擇正確的倉庫!")
            Exit Sub
        End If
    End Sub

    Private Sub Grid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.Click
        GridView2_FocusedRowChanged(Nothing, Nothing)
    End Sub

    Private Sub ToolStripShowSa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripShowSa.Click
        Dim mt As New WareInventory.WareInventoryMTController
        If Me.twWare.SelectedNode.Tag = "W2101" Then
            Grid1.DataSource = mt.WareInventory_GetMaterial(Nothing, twWare.SelectedNode.Tag, Nothing)
        End If
    End Sub

    Private Sub ToolStripWareInventoryNG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripWareInventoryNG.Click
        If Me.GridView2.RowCount <= 0 Then
            Exit Sub
        End If

        tempValue = Me.GridView2.GetFocusedRowCellValue("M_Code").ToString

        frmWareInventoryNGType.ShowDialog()
        frmWareInventoryNGType.Dispose()
    End Sub

    Private Sub XtraTabInvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabInvent.Click

    End Sub
End Class