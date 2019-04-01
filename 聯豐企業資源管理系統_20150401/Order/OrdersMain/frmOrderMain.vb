Imports LFERP.Library.Orders
Imports LFERP.Library.Product
Imports LFERP.SystemManager
Imports LFERP.Library.OutWards
Imports LFERP.Library.OrdersChange
Imports LFERP.Library.ProductionKaiLiao

Public Class frmOrderMain
    Dim boolAllow As Boolean = False

    Dim mc As New OrdersMainController

    Private Sub frmOrderMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PopRefresh_Click(Nothing, Nothing)          '@ 2012/9/20 修改 調用刷新過程

        '判斷用戶權限   如果是聯豐用戶--允許建立配件批次，其他均不允許建立配件批次（當前限制--2012/8/30）
        '----------------------------
        If strInCompany = "1001" Then   '聯豐代號
            popOrderPJ.Visible = True
            popOrderDHCopy.Visible = True
            popOrderMainPrice.Visible = False
            popOrderMainCheck.Visible = False
            popOrderMainReCheck.Visible = False
        Else

            popOrderPJ.Visible = False
            popOrderDHCopy.Visible = True

        End If

        LoadPowerUser()
    End Sub
    Sub LoadPowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300101")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popOrderMainAdd.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popOrderMainEdit.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popOrderMainDel.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300104")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popOrderMainAddMo.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300105")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popOrderMainFile.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300111")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popOrderMainPrice.Enabled = True Else popOrderMainPrice.Visible = False
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300112")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popOrderMainCheck.Enabled = True Else popOrderMainCheck.Visible = False
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300113")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popOrderMainReCheck.Enabled = True Else popOrderMainReCheck.Visible = False
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300114")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popOrderCheck.Enabled = True Else popOrderCheck.Visible = False
        End If

        ''------------------------------------------------------------------------
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300115")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripModify.Visible = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300116")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then boolAllow = True
        End If


        ''------------------------------------------------------------------------
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300117")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripChcekA.Visible = True Else ToolStripChcekA.Visible = False
        End If

        ToolStripModifyQ.Visible = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300118")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripModifyQ.Visible = True Else ToolStripModifyQ.Visible = False
        End If


        '


    End Sub


    Private Sub popOrderMainAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popOrderMainAdd.Click
        On Error Resume Next
        Edit = False

        Dim fr As frmOrder
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmOrder Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempCode = "訂單資料"
        fr = New frmOrder
        fr.MdiParent = MDIMain
        fr.Show()

    End Sub

    Private Sub popOrderMainEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popOrderMainEdit.Click
        On Error Resume Next
        'Dim osc As New OrdersSubController
        'Dim osilist As New List(Of OrdersSubInfo)


        'osilist = osc.OrdersSub_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Grid.CurrentRow.Cells("OM_No").Value.ToString())
        'If osilist.Count <> 0 Then

        '    MsgBox("無法修改,此訂單已創建批次！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        '    Exit Sub
        'End If


        If GridView1.RowCount = 0 Then
            Exit Sub
        Else


            Dim omi1 As List(Of OrdersMainInfo)
            Dim omc1 As New OrdersMainController
            omi1 = omc1.OrdersMain_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("OM_ID").ToString)

            If omi1.Count > 0 Then
                '訂單未審核不能,創建批次2013-8-29
                If omi1(0).OM_CheckA = True Then
                    MsgBox("此訂單已審核,不允許修改!", 64, "提示")
                    Exit Sub
                End If
            End If
            '-------------------------------



            Dim strA, strB As String
            strA = GridView1.GetFocusedRowCellValue("OM_No").ToString '讀取當前行訂單單號

            Dim omi As List(Of OrdersMainInfo)
            Dim omc As New OrdersMainController
            omi = omc.OrdersMain_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing)

            If omi.Count > 0 Then
                If omi(0).OM_Check = False Then
                    tempValue = strA
                    Edit = True
                    Dim fr As frmOrder
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmOrder Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next
                    tempCode = "訂單資料"
                    fr = New frmOrder
                    fr.MdiParent = MDIMain
                    fr.Show()
                Else
                    MsgBox("此訂單信息已鎖定，不允許再修改！", 64, "提示")
                End If
            End If
        End If


    End Sub

    Private Sub popOrderMainDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popOrderMainDel.Click
        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        '@ 2012/9/19 添加 訂單鎖定後，不允許再添加批次
        Dim omi As List(Of OrdersMainInfo)
        Dim omc As New OrdersMainController
        omi = omc.OrdersMain_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("OM_ID").ToString)

        If omi.Count > 0 Then
            '訂單未審核不能,創建批次2013-8-29
            If omi(0).OM_CheckA = True Then
                MsgBox("此訂單已審核,不允許刪除!", 64, "提示")
                Exit Sub
            End If
        End If
        '-------------------------------

        Dim osc As New OrdersSubController
        Dim osilist As New List(Of OrdersSubInfo)


        osilist = osc.OrdersSub_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("OM_No").ToString, Nothing, Nothing, Nothing, Nothing)
        If osilist.Count <> 0 Then

            MsgBox("無法刪除,此訂單已創建批次！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim StrA As String
        StrA = GridView1.GetFocusedRowCellValue("OM_No").ToString
        If MsgBox("你確定刪除訂單編號為  '" & StrA & "'  的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim mi As New OrdersMainInfo
            'Dim mt As New OrdersMainController
            mi.OM_No = StrA
            If mc.OrdersMain_OMNo_Del(mi) = True Then
                PopRefresh_Click(Nothing, Nothing)          '@ 2012/9/20 修改 調用刷新過程
            Else
                MsgBox("刪除失敗")
            End If

        End If
    End Sub
    ''' <summary>
    ''' 刷新
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 此過程被以下過程調用：
    ''' popOrderMainDel_Click()
    ''' frmOrderMain_Load()
    Private Sub PopRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopRefresh.Click
        'Dim mc As New OrdersMainController

        Grid1.DataSource = mc.OrdersMain_GetList2(Nothing, Nothing)         '@ 2012/9/20 修改 限制只顯示500條記錄
    End Sub

    Private Sub popOrderMainFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popOrderMainFile.Click
        '調用此訂單流水號的文件
        If GridView1.RowCount = 0 Then Exit Sub

        Dim open, update, down, Edit, del, detail As Boolean
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As New List(Of PermissionModuleWarrantSubInfo)

        If GridView1.RowCount = 0 Then Exit Sub
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300105")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then update = True
            If pmwiL.Item(0).PMWS_Value = "否" Then update = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300106")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then down = True
            If pmwiL.Item(0).PMWS_Value = "否" Then down = False
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300107")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then Edit = True
            If pmwiL.Item(0).PMWS_Value = "否" Then Edit = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300108")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then del = True
            If pmwiL.Item(0).PMWS_Value = "否" Then del = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300109")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then detail = True
            If pmwiL.Item(0).PMWS_Value = "否" Then detail = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "300110")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then open = True
            If pmwiL.Item(0).PMWS_Value = "否" Then open = False
        End If
        FileShow("3001", GridView1.GetFocusedRowCellValue("OM_No").ToString, open, update, down, Edit, del, detail)


    End Sub

    Private Sub popOrderMainSe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popOrderMainSe.Click
        'Dim mc As New OrdersMainController
        Dim myfrm As New frmOrdersMainSe
        myfrm.ShowDialog()
        If tempValue5 = "單擊查詢按鈕" Then
            Grid1.DataSource = mc.OrdersMain_GetList3(tempValue, tempValue3, tempValue4, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue6, tempValue7, tempValue8)
        End If

        tempValue = ""
        tempValue2 = ""
        tempValue3 = ""
        tempValue4 = ""
        tempValue5 = ""
        tempValue6 = ""
        tempValue7 = ""
        tempValue8 = ""
    End Sub

    'Private Sub popOrderMainAddMo2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popOrderMainAddMo2.Click
    '    'On Error Resume Next
    '    ''tempValue = Grid.CurrentRow.Cells("OM_ID").Value.ToString()
    '    'tempValue = GridView1.GetFocusedRowCellValue("OM_ID").ToString
    '    'Edit = False
    '    'Dim fr As frmOrdersSub
    '    'For Each fr In MDIMain.MdiChildren
    '    '    If TypeOf fr Is frmOrdersSub Then
    '    '        fr.Activate()
    '    '        Exit Sub
    '    '    End If
    '    'Next
    '    'fr = New frmOrdersSub
    '    'fr.MdiParent = MDIMain
    '    'fr.Show()
    'End Sub

    'Private Sub popOrderMainAddMo3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popOrderMainAddMo3.Click
    '    On Error Resume Next
    '    tempValue = GridView1.GetFocusedRowCellValue("OM_ID").ToString

    '    Edit = False
    '    tempCode = "Copy"

    '    Dim myfrm As New FrmOrdersMainSe2
    '    myfrm.Show()
    '    'Dim fr As frmOrdersSub
    '    'For Each fr In MDIMain.MdiChildren
    '    '    If TypeOf fr Is frmOrdersSub Then
    '    '        fr.Activate()
    '    '        Exit Sub
    '    '    End If
    '    'Next
    '    'fr = New frmOrdersSub
    '    'fr.MdiParent = MDIMain
    '    'fr.Show()

    'End Sub

    'Private Sub Grid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.Click
    '    Dim ms As New OrdersSubController
    '    Dim owc As New OutWardsController

    '    If GridView1.RowCount = 0 Then Exit Sub

    '    Grid2.DataSource = ms.OrdersSub_GetList(GridView1.GetFocusedRowCellValue("OM_ID").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

    '    'Dim mi As List(Of OrdersSubInfo)
    '    'mi = ms.OrdersSub_GetList(GridView1.GetFocusedRowCellValue("OM_ID").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

    '    'If mi.Count > 0 Then
    '    Grid3.DataSource = owc.OutWards_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("OM_ID").ToString, Nothing, Nothing, Nothing, True, Nothing, Nothing)

    '    'End If

    'End Sub

    Private Sub popOrderMainView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrderMainView.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then
            Exit Sub
        Else
            tempValue = GridView1.GetFocusedRowCellValue("OM_No").ToString

        End If

        Dim fr As frmOrder
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmOrder Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempCode = "PreView"
        fr = New frmOrder
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub popOrderMainPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrderMainPrint.Click

    End Sub
    '創建批次--大貨
    'Private Sub popLarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popLarge.Click
    '    On Error Resume Next
    '    tempValue = GridView1.GetFocusedRowCellValue("OM_ID").ToString
    '    Edit = False
    '    tempCode = "大貨批次"
    '    Dim fr As frmOrdersSub
    '    For Each fr In MDIMain.MdiChildren
    '        If TypeOf fr Is frmOrdersSub Then
    '            fr.Activate()
    '            Exit Sub
    '        End If
    '    Next
    '    fr = New frmOrdersSub
    '    fr.MdiParent = MDIMain
    '    fr.Show()
    'End Sub
    '創建批次--另購
    'Private Sub popOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOther.Click
    '    On Error Resume Next
    '    tempValue = GridView1.GetFocusedRowCellValue("OM_ID").ToString
    '    Edit = False
    '    tempCode = "配件批次"
    '    Dim fr As frmOrdersSub
    '    For Each fr In MDIMain.MdiChildren
    '        If TypeOf fr Is frmOrdersSub Then
    '            fr.Activate()
    '            Exit Sub
    '        End If
    '    Next
    '    fr = New frmOrdersSub
    '    fr.MdiParent = MDIMain
    '    fr.Show()
    'End Sub
    '手動創建大貨批次
    Private Sub popOrderDHAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrderDHAdd.Click
        On Error Resume Next
        tempValue = GridView1.GetFocusedRowCellValue("OM_ID").ToString
        tempValue7 = GridView1.GetFocusedRowCellValue("OM_SendDate").ToString
        tempValue8 = GridView1.GetFocusedRowCellValue("OM_CheckDate").ToString

        '@ 2012/9/19 添加 訂單鎖定後，不允許再添加批次
        Dim omi As List(Of OrdersMainInfo)
        Dim omc As New OrdersMainController
        omi = omc.OrdersMain_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("OM_ID").ToString)

        If omi.Count > 0 Then
            '訂單未審核不能,創建批次2013-8-29
            If omi(0).OM_CheckA = False Then
                MsgBox("此訂單未審核,不允許創建批次!", 64, "提示")
                Exit Sub
            End If


            If omi(0).OM_NoMakeQty <= 0 Then
                MsgBox("未生產數量小於等於零時，不允許再創建新批次!", 64, "提示")
                Exit Sub
            End If
            If omi(0).OM_Check = True Then
                MsgBox("此訂單信息已鎖定，不允許再創建新批次！", 64, "提示")
                Exit Sub
            End If
        End If
        '------------------------------------------------------------2012/8/30 
        ''先判斷當前用戶所在公司--聯豐允許同一訂單子項分多個批次進行，但其他公司當前均不允許
        '判斷當前訂單子項是否已建立過批次，Yes--不允許再次建立，No--允許建立不同的批次編號
        '------------------------------------------------------------
        ''If strInCompany = "1001" Then
        ''    GoTo A   '添加
        ''Else
        'Dim osi As List(Of OrdersSubInfo)
        'Dim osc As New OrdersSubController

        'osi = osc.OrdersSub_GetList(tempValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        'If osi.Count > 0 Then
        '    MsgBox("此物料已建立過批次，不允許再次添加新批次！")
        '    Exit Sub
        '    'Else
        '    '    GoTo A   '添加
        'End If
        ''        End If
        ''A:
        Edit = False
        tempCode = "大貨批次"
        Dim fr As frmOrdersSub
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmOrdersSub Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmOrdersSub
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub
    '導入舊的大貨批次
    Private Sub popOrderDHCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrderDHCopy.Click
        On Error Resume Next
        tempValue = GridView1.GetFocusedRowCellValue("OM_ID").ToString

        '@ 2012/9/19 添加 訂單鎖定後，不允許再添加批次
        Dim omi As List(Of OrdersMainInfo)
        Dim omc As New OrdersMainController
        omi = omc.OrdersMain_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("OM_ID").ToString)

        If omi.Count > 0 Then
            '訂單未審核不能,創建批次2013-8-29
            If omi(0).OM_CheckA = False Then
                MsgBox("此訂單未審核,不允許創建批次!", 64, "提示")
                Exit Sub
            End If


            If omi(0).OM_NoMakeQty <= 0 Then
                MsgBox("未生產數量小於等於零時，不允許再創建新批次!", 64, "提示")
                Exit Sub
            End If
            If omi(0).OM_Check = True Then
                MsgBox("此訂單信息已鎖定，不允許再創建新批次！", 64, "提示")
                Exit Sub
            End If
        End If



        Edit = False
        tempCode = "Copy"
        tempValue4 = "大貨批次"

        Dim myfrm As New FrmOrdersMainSe2
        myfrm.Show()
    End Sub
    '手動創建配件批次
    Private Sub popOrderPJAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrderPJAdd.Click
        On Error Resume Next
        tempValue = GridView1.GetFocusedRowCellValue("OM_ID").ToString

        '@ 2012/9/19 添加 訂單鎖定後，不允許再添加批次
        Dim omi As List(Of OrdersMainInfo)
        Dim omc As New OrdersMainController
        omi = omc.OrdersMain_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("OM_No").ToString)

        If omi.Count > 0 Then
            If omi(0).OM_Check = True Then
                MsgBox("此訂單信息已鎖定，不允許再添加新批次！", 64, "提示")
                Exit Sub
            End If
        End If

        '@ 2012/9/19 添加 所有訂單勻只能創建一個批次
        Dim osi As List(Of OrdersSubInfo)
        Dim osc As New OrdersSubController

        osi = osc.OrdersSub_GetList(tempValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If osi.Count > 0 Then
            MsgBox("此物料已建立過批次，不允許再次添加新批次！")
            Exit Sub
        End If

        Edit = False
        tempCode = "配件批次"
        Dim fr As frmOrdersSub
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmOrdersSub Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmOrdersSub
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub
    '導入舊的配件批次
    Private Sub popOrderPJCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrderPJCopy.Click
        On Error Resume Next
        tempValue = GridView1.GetFocusedRowCellValue("OM_ID").ToString

        Edit = False
        tempCode = "Copy"
        tempValue4 = "配件批次"
        Dim myfrm As New FrmOrdersMainSe2
        myfrm.Show()
    End Sub

    '錄入當前訂單單價信息  -以子項為標準來執行，同一訂單存在有多項須分別設置單價（唯一編號）
    Private Sub popOrderMainPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrderMainPrice.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim strA, strB As String
        strA = GridView1.GetFocusedRowCellValue("OM_No").ToString '讀取當前行訂單單號
        strB = GridView1.GetFocusedRowCellValue("OM_ID").ToString '讀取當前行訂單流水號

        Dim omi As List(Of OrdersMainInfo)
        Dim omc As New OrdersMainController
        omi = omc.OrdersMain_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, strB)

        If omi.Count > 0 Then

            If omi(0).OM_PriceCheck = False Then
                On Error Resume Next

                Dim fr As frmOrder
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmOrder Then
                        fr.Activate()
                        Exit Sub
                    End If
                Next
                tempCode = "Price"
                tempValue = strA
                fr = New frmOrder
                fr.MdiParent = MDIMain
                fr.Show()
            Else

                MsgBox("此單價信息已審核，不允許再修改單價！", 64, "提示")
                Exit Sub

            End If

        End If

    End Sub
    '審核當前訂單單價信息--以子項為標準來執行，同一訂單存在有多項須分別審核單價（唯一編號）
    Private Sub popOrderMainCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrderMainCheck.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim strA, strB As String
        strA = GridView1.GetFocusedRowCellValue("OM_No").ToString '讀取當前行訂單單號
        strB = GridView1.GetFocusedRowCellValue("OM_ID").ToString '讀取當前行訂單流水號

        Dim omi As List(Of OrdersMainInfo)
        Dim omc As New OrdersMainController
        omi = omc.OrdersMain_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, strB)

        If omi.Count > 0 Then

            If omi(0).OM_PriceReCheck = False Then
                On Error Resume Next

                Dim fr As frmOrder
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmOrder Then
                        fr.Activate()
                        Exit Sub
                    End If
                Next
                tempCode = "CheckPrice"
                tempValue = strA
                fr = New frmOrder
                fr.MdiParent = MDIMain
                fr.Show()
            Else

                MsgBox("此單價信息已鎖定，不允許再審核單價！", 64, "提示")
                Exit Sub

            End If

        End If
    End Sub
    '鎖定當前訂單單價信息 -以子項為標準來執行，同一訂單存在有多項須分別鎖定單價（唯一編號）
    Private Sub popOrderMainReCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrderMainReCheck.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim strA, strB As String
        strA = GridView1.GetFocusedRowCellValue("OM_No").ToString '讀取當前行訂單單號
        strB = GridView1.GetFocusedRowCellValue("OM_ID").ToString '讀取當前行訂單流水號

        Dim omi As List(Of OrdersMainInfo)
        Dim omc As New OrdersMainController
        omi = omc.OrdersMain_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing)

        If omi.Count > 0 Then

            If omi(0).OM_Check = False Then
                On Error Resume Next

                Dim fr As frmOrder
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmOrder Then
                        fr.Activate()
                        Exit Sub
                    End If
                Next
                tempCode = "ReCheckPrice"
                tempValue = strA
                fr = New frmOrder
                fr.MdiParent = MDIMain
                fr.Show()
            Else

                MsgBox("此訂單信息已鎖定，不允許再鎖定單價！", 64, "提示")
                Exit Sub

            End If

        End If
    End Sub
    '鎖定當前訂單單價信息 -以訂單單號為標準來執行
    Private Sub popOrderCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popOrderCheck.Click

        If GridView1.RowCount = 0 Then Exit Sub

        Dim strA, strB As String
        strA = GridView1.GetFocusedRowCellValue("OM_No").ToString '讀取當前行訂單單號

        Dim omi As List(Of OrdersMainInfo)
        Dim omc As New OrdersMainController
        omi = omc.OrdersMain_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing)

        If omi.Count > 0 Then

            If omi(0).OM_Check = False Then
                On Error Resume Next

                Dim fr As frmOrder
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmOrder Then
                        fr.Activate()
                        Exit Sub
                    End If
                Next
                tempCode = "OrderCheck"
                tempValue = strA
                fr = New frmOrder
                fr.MdiParent = MDIMain
                fr.Show()
            Else

                MsgBox("此訂單信息已鎖定，不需要再鎖定！", 64, "提示")
                Exit Sub

            End If

        End If
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim ms As New OrdersSubController
        Dim owc As New OutWardsController
        Dim oc As New OrdersChangeControl
        Dim pk As New ProductionKaiLiaoControl


        If GridView1.RowCount = 0 Then Exit Sub

        Grid2.DataSource = ms.OrdersSub_GetList(GridView1.GetFocusedRowCellValue("OM_ID").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        Grid3.DataSource = owc.OutWards_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("OM_ID").ToString, Nothing, Nothing, Nothing, True, Nothing, Nothing)

        Grid6.DataSource = oc.OrdersChange_GetList1(GridView1.GetFocusedRowCellValue("OM_ID").ToString, Nothing)

        Grid7.DataSource = pk.ProductionKaiLiaoA_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("OM_ID").ToString, Nothing, Nothing)

    End Sub

    Private Sub PopOrderCollect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopOrderCollect.Click
        FrmOrderCollect.ShowDialog()
        FrmOrderCollect.Dispose()
    End Sub

    ''修改名稱
    Private Sub ToolStripModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripModify.Click
        If GridView1.RowCount = 0 Then Exit Sub

        If boolAllow = False Then
            Dim oc As New OrdersChangeControl
            Dim ol As New List(Of OrdersChangeInfo)
            ol = oc.OrdersChange_GetList(GridView1.GetFocusedRowCellValue("OM_ID").ToString)
            If ol.Count <= 0 Then
            Else
                MsgBox("不能多次修改此編碼!")
                Exit Sub
            End If
        End If
        ''----------------------------------

        Dim OW As New OutWardsController
        Dim OLl As New List(Of OutWardsInfo)
        OLl = OW.OutWards_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("OM_ID").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If OLl.Count <= 0 Then
        Else
            MsgBox("此訂單流水號,已有送貨記錄!")
            Exit Sub
        End If

        Dim osc As New OrdersSubController
        Dim osl As New List(Of OrdersSubInfo)

        osl = osc.OrdersSub_GetList(GridView1.GetFocusedRowCellValue("OM_ID").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If osl.Count > 0 Then
            Dim k As Integer

            For k = 0 To osl.Count - 1
                Dim obomc As New OrdersBomController
                Dim obocl As New List(Of OrdersBomInfo)
                obocl = obomc.OrdersBom_GetList(Nothing, osl(k).OS_BatchID, Nothing, Nothing)

                If obocl.Count > 0 Then
                    MsgBox("此訂單流水號,相關批次已在物料清單中存在!")
                    Exit Sub
                End If
            Next
        End If


        '----------------------------------------------------------------------------------
        Dim omi As List(Of OrdersMainInfo)
        Dim omc As New OrdersMainController
        omi = omc.OrdersMain_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("OM_ID").ToString)

        If omi.Count <> 1 Then
            Exit Sub
        End If

        tempValue = GridView1.GetFocusedRowCellValue("OM_ID").ToString
        tempValue2 = omi(0).PM_M_Code
        tempValue3 = "M"

        frmOrdersChange.ShowDialog()
        frmOrdersChange.Dispose()

    End Sub

    Private Sub ToolStripChcekA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripChcekA.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim strA, strB As String
        strA = GridView1.GetFocusedRowCellValue("OM_No").ToString '讀取當前行訂單單號

        Dim omi As List(Of OrdersMainInfo)
        Dim omc As New OrdersMainController
        omi = omc.OrdersMain_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing)

        If omi.Count > 0 Then

            If omi(0).OM_Check = False Then
                On Error Resume Next

                Dim fr As frmOrder
                For Each fr In MDIMain.MdiChildren
                    If TypeOf fr Is frmOrder Then
                        fr.Activate()
                        Exit Sub
                    End If
                Next
                tempCode = "OrderCheckA"
                tempValue = strA
                fr = New frmOrder
                fr.MdiParent = MDIMain
                fr.Show()
            Else
                MsgBox("此訂單信息已鎖定，不能審核！", 64, "提示")
                Exit Sub
            End If

        End If
    End Sub

    Private Sub ToolStripNOPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripNOPrice.Click
        ''列印無單價,有編碼的信息
        Dim ds As New DataSet
        Dim ltc As New CollectionToDataSet
        Dim oc As New OrdersMainController
        Dim ol As New List(Of OrdersMainInfo)

        ol = oc.OrdersMain_GetListNoPrice(Nothing, Nothing)
        If ol.Count <= 0 Then
            MsgBox("無需要進行單價錄入編碼！", 64, "提示")
            Exit Sub
        End If

        ltc.CollToDataSet(ds, "OrdersMain", ol)
        PreviewRPTDialog1(ds, "rptOutwardMainNoPrice", "磨刀部---單價錄入表", "", "", True, True)
        ltc = Nothing

    End Sub

    Private Sub ToolStripModifyQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripModifyQ.Click

        If GridView1.RowCount <= 0 Then Exit Sub
        '----------------------------------------------------------------------------------

        Dim omi As List(Of OrdersMainInfo)
        Dim omc As New OrdersMainController
        omi = omc.OrdersMain_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, GridView1.GetFocusedRowCellValue("OM_ID").ToString)

        If omi.Count <> 1 Then
            Exit Sub
        End If

        tempValue = GridView1.GetFocusedRowCellValue("OM_ID").ToString
        tempValue2 = omi(0).OM_NoSendQty
        tempValue3 = "Q"

        frmOrdersChange.ShowDialog()
        frmOrdersChange.Dispose()
    End Sub
End Class