Imports LFERP.SystemManager
Imports LFERP.Library
Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess


Public Class frmProductMain
    Dim mc As New ProductController
    '  Dim SstrA As String
    Dim StratCheck As Boolean = False
    Dim pmc As New ProcessMainControl

    Private Sub popProductMainPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popProductMainPrint.Click
        '測試報表用
        On Error Resume Next
        Dim ds As New DataSet
        If GridView2.RowCount = 0 Then Exit Sub
      
        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim mcProduct As New ProductController
        Dim mcProductBom As New ProductBomController
        ds.Tables.Clear()
        ltc.CollToDataSet(ds, "Prod_Main_New", mcProduct.Product_GetList(GridView2.GetFocusedRowCellValue("PM_M_Code").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "Prod_Mounting_New", mcProductBom.ProductBom_GetList(GridView2.GetFocusedRowCellValue("PM_M_Code").ToString, Nothing, Nothing, Nothing, Nothing, Nothing))

        PreviewRPT(ds, "rptProductBom", " 產品資料--" & GridView2.GetFocusedRowCellValue("PM_M_Code").ToString, True, True)
        ltc = Nothing
        ltc1 = Nothing

    End Sub

    Private Sub popProductMainAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popProductMainAdd.Click
        On Error Resume Next
        Edit = False
        tempValue = "Product"
        Dim fr As frmProduct
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProduct Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProduct
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub

    Private Sub popProductMainEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popProductMainEdit.Click
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub
        '----------------------------------------
        If CheckPro(GridView2.GetFocusedRowCellValue("PM_M_Code").ToString) = True And StratCheck = False Then
            MsgBox("不能修改,此產品編號已審核!")
            Exit Sub
        End If

        ''---------------------------------------------
        Edit = True
        tempValue = "Product"
        Dim fr As frmProduct
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProduct Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProduct
        fr.MdiParent = MDIMain
        fr.txtLFID.EditValue = GridView2.GetFocusedRowCellValue("PM_M_Code").ToString
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Sub LoadProduct()
        Grid1.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

    End Sub

    Private Sub frmProductMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mtc As New Material.MaterialTypeController
        'Me.Grid.AutoGenerateColumns = False

        '' 為磨刀部
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200112")
        If pmwiL.Count > 0 Then
            If pmwiL(0).PMWS_Value.ToString <> "" Then
                mtc.LoadNodes(tv1, pmwiL(0).PMWS_Value.ToString)    '只選擇成品類
            Else
                mtc.LoadNodes(tv1, "40")    '只選擇成品類
            End If
        Else
            mtc.LoadNodes(tv1, "40")    '只選擇成品類
        End If




            tv1.ExpandAll()
            'Grid.RowHeadersWidth = 15
            LoadPowerUser()

    End Sub
    Sub LoadPowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200101")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popProductMainAdd.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popProductMainEdit.Enabled = True
            If pmwiL.Item(0).PMWS_Value = "是" Then popProductMainReplace.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popProductMainDel.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200104")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popProductMainCopy.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200111")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popProductMainCheck.Enabled = True
        End If

        ''審核
        ToolStripCheck.Visible = False
        ToolStripCheck.Enabled = False
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200115")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripCheck.Enabled = True : ToolStripCheck.Visible = True
        End If

        '--------------StratCheck---------------------
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200116")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then StratCheck = True
        End If


    End Sub

    Private Sub tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv1.AfterSelect
        If e.Node.Level = 3 Then
            Grid1.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, tv1.SelectedNode.Tag, Nothing, Nothing, Nothing)
            '      SstrA = tv1.SelectedNode.Tag
            'MsgBox(tv1.SelectedNode.Tag)
        End If
    End Sub

    Private Sub popProductMainDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popProductMainDel.Click
        '刪除產品資料
        If GridView2.RowCount = 0 Then Exit Sub

        '----------------------------------------
        If CheckPro(GridView2.GetFocusedRowCellValue("PM_M_Code").ToString) = True Then
            MsgBox("不能刪除,此產品編號已審核!")
            Exit Sub
        End If

        ''---------------------------------------------


        If MsgBox("你確定要刪除 " & GridView2.GetFocusedRowCellValue("PM_M_Code").ToString & " 這個產品資料嗎?", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.No Then Exit Sub

        Dim pmi As List(Of ProcessMainInfo)
        pmi = pmc.ProcessMain_GetList(Nothing, GridView2.GetFocusedRowCellValue("PM_M_Code").ToString, Nothing, Nothing, Nothing, Nothing)
        If pmi.Count > 0 Then
            MsgBox("當前產品信息已建立工藝流程,不允許刪除!")
            Exit Sub
        End If

        Dim mtcBom As New ProductController
        Dim mtcBomSub As New ProductBomController
        If mtcBom.Product_Delete(GridView2.GetFocusedRowCellValue("PM_M_Code").ToString) = True Then
            mtcBomSub.ProductBom_Delete(GridView2.GetFocusedRowCellValue("PM_M_Code").ToString, Nothing)
            Grid1.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, tv1.SelectedNode.Tag, Nothing, Nothing, Nothing)
        End If



        'mc.MaterialCode_Delete(Grid.CurrentRow.Cells("M_Code").Value.ToString)
        ''mtc.LoadNodes(tv1, ErpUser.MaterialType)
        ''Grid.Rows.Remove(Grid.CurrentRow)
        'Grid.DataSource = mc.MaterialCode_GetList(Nothing, Nothing, Nothing, tv1.SelectedNode.Tag)
    End Sub

    Private Sub popProductMainCopy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popProductMainCopy.Click
        '產品資料復制
        On Error Resume Next
        tempValue = "Copy"
        tempValue2 = GridView2.GetFocusedRowCellValue("PM_M_Code").ToString

        Dim fr As frmProduct
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProduct Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProduct
        fr.MdiParent = MDIMain
        fr.txtLFID.EditValue = GridView2.GetFocusedRowCellValue("PM_M_Code").ToString
        fr.WindowState = FormWindowState.Maximized
        fr.Show()


    End Sub

    Private Sub popProductMainFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popProductMainFile.Click
        '調用此產品資料的文件
        If GridView2.RowCount = 0 Then Exit Sub

        Dim open, update, down, Edit, del, detail As Boolean
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As New List(Of PermissionModuleWarrantSubInfo)

        If GridView2.RowCount = 0 Then Exit Sub
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200105")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then update = True
            If pmwiL.Item(0).PMWS_Value = "否" Then update = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200106")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then down = True
            If pmwiL.Item(0).PMWS_Value = "否" Then down = False
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200107")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then Edit = True
            If pmwiL.Item(0).PMWS_Value = "否" Then Edit = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200108")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then del = True
            If pmwiL.Item(0).PMWS_Value = "否" Then del = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200109")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then detail = True
            If pmwiL.Item(0).PMWS_Value = "否" Then detail = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200110")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then open = True
            If pmwiL.Item(0).PMWS_Value = "否" Then open = False
        End If
        FileShow("2001", GridView2.GetFocusedRowCellValue("PM_M_Code").ToString, open, update, down, Edit, del, detail)

    End Sub

    
    Private Sub popProductMainSe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popProductMainSe.Click
        Dim myfrm As New frmProductMainSe
        myfrm.ShowDialog()
        'Select Case tempValue
        '    Case "1"
        '        Grid1.DataSource = mc.Product_GetList(tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        '    Case "2"
        '        Grid1.DataSource = mc.Product_GetList(Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing)

        '    Case "3"
        '        Grid1.DataSource = mc.Product_GetList(Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing)

        'End Select

        Grid1.DataSource = mc.Product_GetList1(tempValue2, tempValue3, tempValue4, Nothing, Nothing, Nothing, tempValue5)

        tempValue = ""
        tempValue2 = ""
    End Sub

    Private Sub popProductMainView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popProductMainView.Click
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub
        tempValue = "PreView"
        Dim fr As frmProduct
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProduct Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProduct
        fr.MdiParent = MDIMain
        fr.txtLFID.EditValue = GridView2.GetFocusedRowCellValue("PM_M_Code").ToString
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popProductMainCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popProductMainCheck.Click
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub

        '----------------------------------------
        If CheckPro(GridView2.GetFocusedRowCellValue("PM_M_Code").ToString) = True And StratCheck = False Then
            MsgBox("不能核對資料,此產品編號已審核!")
            Exit Sub
        End If

        ''---------------------------------------------


        tempValue = "Check"
        Dim fr As frmProduct
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProduct Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProduct
        fr.MdiParent = MDIMain
        fr.txtLFID.EditValue = GridView2.GetFocusedRowCellValue("PM_M_Code").ToString
        fr.WindowState = FormWindowState.Maximized
        fr.Show()


    End Sub

    Private Sub popProductMainUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popProductMainUpdate.Click
        Grid1.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub
    ''' <summary>
    ''' 2010-11-11添加----主要為了不同殼號,但需相同配件的情況下可直接互相導入相對應的配件資料
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub popProductMainReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popProductMainReplace.Click
        Dim frm As New frmProductReplace
        frm.ShowDialog()
    End Sub

    Private Sub ToolPrintBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPrintBarCode.Click

        If Me.GridView2.RowCount <= 0 Then
            Exit Sub
        End If

        Dim StrPM_M_Code As String
        Dim strM_Gauge As String
        Dim strType3ID As String

        StrPM_M_Code = Me.GridView2.GetFocusedRowCellValue("PM_M_Code").ToString
        strM_Gauge = Me.GridView2.GetFocusedRowCellValue("M_Gauge").ToString
        strType3ID = Me.GridView2.GetFocusedRowCellValue("Type3ID").ToString

        tempValue = StrPM_M_Code
        frmMaterialGaugeNew.strGauge = strM_Gauge
        frmMaterialGaugeNew.Label2.Text = Mid(strType3ID, 1, 8) '@ 2012/1/7 修改
        tempValue2 = "Print"

        frmMaterialGaugeNew.ShowDialog()
        frmMaterialGaugeNew.Dispose()
    End Sub

    '--------------------------------------------------------------------------------
    ''' <summary>
    ''' 判斷是否審核已鎖定
    ''' </summary>
    ''' <param name="_PM_M_Code"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function CheckPro(ByVal _PM_M_Code As String) As Boolean
        Dim ol As ProductInfo
        Dim oc As New ProductController

        ol = oc.Product_Get(_PM_M_Code)
        If ol Is Nothing Then
            CheckPro = True
            Exit Function
        End If

        If ol.M_IsEnabled = True Then
            CheckPro = True
        Else
            CheckPro = False
        End If

    End Function




    Private Sub ToolStripCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripCheck.Click
        On Error Resume Next
        If GridView2.RowCount = 0 Then Exit Sub

        tempValue = "ProCheck"
        Dim fr As frmProduct
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProduct Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProduct
        fr.MdiParent = MDIMain
        fr.txtLFID.EditValue = GridView2.GetFocusedRowCellValue("PM_M_Code").ToString
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub ToolStripCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripCopy.Click
        Dim FiledNameStr As String
        FiledNameStr = "PM_M_Code,M_Gauge"
        GridViewCopyMulitRow(GridView2, FiledNameStr, "ALL")
    End Sub
End Class