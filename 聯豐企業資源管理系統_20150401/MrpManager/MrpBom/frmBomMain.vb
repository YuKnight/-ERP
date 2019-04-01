Imports System
Imports LFERP.SystemManager
Imports LFERP.Library.MrpManager.Bom_M
Imports LFERP.Library.MrpManager.Bom_D
Imports LFERP.Library.MrpManager.MrpSelect
Imports LFERP.Library.MrpManager.MrpSetting
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports Microsoft.Office.Interop
Imports DevExpress.XtraPrinting
Imports System.Threading
Public Class frmBomMain

#Region "屬性"
    Dim bmm As New Bom_MController
    Dim bmd As New Bom_DController
    Dim sc As New Select_Controller
#End Region

#Region "窗體載入"
    Private Sub frmBomMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PowerUser()
        cmdRefresh_Click(Nothing, Nothing)
    End Sub

#Region "設置權限"
    '設置權限
    Sub PowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "48020101")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmdAdd.Visible = True
                cmdAdd.Enabled = True
            End If

        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "48020102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmdEdit.Visible = True
                cmdEdit.Enabled = True
            End If

        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "48020103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmdDel.Visible = True
                cmdDel.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "48020104")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmdCheck.Visible = True
                cmdCheck.Enabled = True
            End If
        End If
    End Sub
#End Region

#End Region

#Region "設置右擊菜單項是否可用"
    Private Sub GridControl1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridBom_Main.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            SetRightClickMenuEnable()
        End If
    End Sub

    Private Sub SetRightClickMenuEnable()
        Dim mbi As New Bom_MInfo
        Dim mbiList As New List(Of Bom_MInfo)

        If GridView1.FocusedRowHandle >= 0 Then
            'mbiList = bmm.Bom_M_GetList(GridView1.GetFocusedRowCellValue("ParentGroup"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If mbiList.Count > 0 Then
                mbi = mbiList(0)
            Else
                MsgBox(GridView1.GetFocusedRowCellValue("ParentGroup") + "的Bom已被其他用戶刪除", MsgBoxStyle.Information, "提示")
                cmdRefresh_Click(Nothing, Nothing)
                Exit Sub
            End If
        End If

        Try
            Dim c As ToolStripItem
            If GridView1.FocusedRowHandle < 0 Then
                For Each c In ContextMenuStrip1.Items
                    If (c.Name = "cmdAdd" Or c.Name = "cmdRefresh") Then
                        c.Enabled = True
                    Else
                        c.Enabled = False
                    End If
                Next
            ElseIf mbi.CheckBit.Equals(True) Then
                For Each c In ContextMenuStrip1.Items
                    If (c.Name = "cmdEdit" Or c.Name = "cmdDel") Then
                        c.Enabled = False
                    Else
                        c.Enabled = True
                    End If
                Next
            Else
                For Each c In ContextMenuStrip1.Items
                    c.Enabled = True
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "SetRightClickMenuEnable方法出錯")
        End Try
    End Sub
#End Region

#Region "新增事件"
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        On Error Resume Next
        Dim fr As frmBom
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmBom Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmBom
        fr.MdiParent = MDIMain
        fr.EditItem = EditEnumType.ADD
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
#End Region

#Region "修改事件"
    ''' <summary>
    ''' 修改操作
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.RowCount = 0 Then Exit Sub
        On Error Resume Next

        Dim fr As frmBom
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmBom Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New frmBom
        fr.MdiParent = MDIMain
        fr.EditItem = EditEnumType.EDIT
        fr.BomAutoID = GridView1.GetFocusedRowCellValue("AutoID")
        fr.BomMCode = GridView1.GetFocusedRowCellValue("ParentGroup")
        fr.BomVersion = GridView1.GetFocusedRowCellValue("Version")
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

#End Region

#Region "查看事件"
    ''' <summary>
    ''' 查看操作
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        If GridView1.RowCount = 0 Then Exit Sub
        On Error Resume Next
        Dim fr As frmBom
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmBom Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmBom
        fr.MdiParent = MDIMain
        fr.EditItem = EditEnumType.VIEW
        fr.BomCheckValue = GridView1.GetFocusedRowCellValue("CheckBit")
        fr.BomCheckRemark = GridView1.GetFocusedRowCellValue("CheckRemark")
        fr.BomMCode = GridView1.GetFocusedRowCellValue("ParentGroup")
        fr.BomVersion = GridView1.GetFocusedRowCellValue("Version")
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
#End Region

#Region "審核事件"
    ''' <summary>
    ''' 審核操作
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheck.Click
        If GridView1.RowCount = 0 Then Exit Sub
        On Error Resume Next
        Dim fr As frmBom
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmBom Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmBom
        fr.MdiParent = MDIMain
        fr.EditItem = EditEnumType.CHECK
        fr.BomCheckValue = GridView1.GetFocusedRowCellValue("CheckBit")
        fr.BomCheckRemark = GridView1.GetFocusedRowCellValue("CheckRemark")
        fr.BomMCode = GridView1.GetFocusedRowCellValue("ParentGroup")
        fr.BomAutoID = GridView1.GetFocusedRowCellValue("AutoID")
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
#End Region

#Region "表格事件"

    Dim threadBomGroup As Thread
    Dim threadBomTree As Thread
    Dim threadBomPurchase As Thread
    Dim ParentCode As String
    Delegate Sub DelegateSetDataSource(ByVal dataSource As Object, ByVal control As Object)
    Delegate Sub DelegateSetPictureBox()

    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        SetRightClickMenuEnable()
        If GridView1.FocusedRowHandle < 0 Then
            TreeList1.DataSource = Nothing
            GridBom_Detail.DataSource = Nothing
            Grid3.DataSource = Nothing
            Exit Sub
        End If
        'If GridView1.RowCount = 0 Then Exit Sub
        ParentCode = GridView1.GetFocusedRowCellValue("ParentGroup")

        If threadBomGroup Is Nothing = False Then
            threadBomGroup.Abort()
        End If

        If threadBomTree Is Nothing = False Then
            threadBomTree.Abort()
        End If

        If threadBomPurchase Is Nothing = False Then
            threadBomPurchase.Abort()
        End If

        threadBomGroup = New Thread(AddressOf LoadInGroup)
        threadBomGroup.Start()

        threadBomTree = New Thread(AddressOf LoadInBomTree)
        threadBomTree.Start()

        threadBomPurchase = New Thread(AddressOf LoadInPurchase)
        threadBomPurchase.Start()

    End Sub
    Private Sub LoadInGroup()
        '-----------------物料明細--------------------------
        Dim mii As New List(Of Bom_DInfo)
        'mii = bmd.Bom_D_GetList(ParentCode)

        Dim s As New DelegateSetDataSource(AddressOf SetControlDataSource)
        Dim p As New DelegateSetPictureBox(AddressOf SetPictureBox)

        Me.Invoke(s, mii, GridBom_Detail)
        threadBomGroup.Abort()
        'PictureBox1.Invoke(p)
    End Sub

    Private Sub LoadInBomTree()
        '-----------------展開物料明細--------------------------
        Dim mii As New List(Of Bom_DInfo)
        'mii = bmd.Bom_D_GetList(ParentCode)
        mii = bmd.MRP_GetSingleBomTree(ParentCode, 1, False)
        Dim s As New DelegateSetDataSource(AddressOf SetControlDataSource)
        Me.Invoke(s, mii, TreeList1)
        threadBomTree.Abort()
    End Sub

    Private Sub LoadInPurchase()
        '-----------------請購明細--------------------------
        Dim mii As New List(Of Bom_DInfo)
        mii = bmd.MRP_GetSingleBomTree(ParentCode, 1, False)

        Dim s As New DelegateSetDataSource(AddressOf SetControlDataSource)
        Me.Invoke(s, mii, Grid3)
        threadBomPurchase.Abort()
    End Sub

    Private Sub SetControlDataSource(ByVal dataSource As Object, ByVal control As Object)
        control.DataSource = dataSource
        If control.Name = "TreeList1" Then
            control.ExpandAll()
        End If
    End Sub
    Private Sub SetPictureBox()

    End Sub
#End Region

#Region "刪除操作"
    ''' <summary>
    ''' 刪除操作
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If GridView1.FocusedRowHandle < 0 Then
            Exit Sub
        End If

        Dim a As String = GridView1.GetFocusedRowCellValue("AutoID")
        Dim Code As String = GridView1.GetFocusedRowCellValue("ParentGroup")
        If MsgBox("是否確定刪除產品編碼：" + Code + "的Bom結構？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
            Try
                If bmm.Bom_M_PreDelete(Code) = False Then
                    Exit Sub
                End If
                bmm.Bom_M_Delete(GridView1.GetFocusedRowCellValue("AutoID"), Nothing)
                bmd.Bom_D_Delete(Nothing, Code)
                MsgBox("刪除成功", 64, "提示")
            Catch ex As Exception
                MsgBox("錯誤，請檢查原因", 64, "提示")
            End Try
        End If
        cmdRefresh_Click(Nothing, Nothing)
    End Sub
#End Region

#Region "刷新事件"
    ''' <summary>
    ''' 刷新操作
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click

        '相關參數設置
        Dim msi As New List(Of MrpSettingInfo)
        Dim msc As New MrpSettingController

        Dim StrCheck As String = Nothing
        Dim StrUser As String = Nothing
        Dim StrProductType As String = Nothing

        msi = msc.MrpSetting_GetList(InUserID)
        If msi.Count > 0 Then
            '1.審核類型
            Select Case msi(0).bomCheckType
                Case "0,1"
                    StrCheck = Nothing
                Case "1"
                    StrCheck = "1"
                Case "0"
                    StrCheck = "0"
            End Select
            '1.用戶選擇
            If msi(0).bomCreateUserID = "All" Then
                StrUser = Nothing
            Else
                StrUser = msi(0).bomCreateUserID
            End If

            '顯示數量展開圖表
            Select Case msi(0).bomDisplayType
                Case "All"
                    Me.xtpA.PageVisible = True
                    Me.xtpB.PageVisible = True
                    Me.xtpC.PageVisible = True
                Case "1"
                    Me.xtpA.PageVisible = True
                    Me.xtpB.PageVisible = False
                    Me.xtpC.PageVisible = False
                Case "0"
                    Me.xtpA.PageVisible = False
                    Me.xtpB.PageVisible = True
                    Me.xtpC.PageVisible = False
                Case "2"
                    Me.xtpA.PageVisible = False
                    Me.xtpB.PageVisible = False
                    Me.xtpC.PageVisible = True
            End Select

            '顯示產品類型
            Select Case msi(0).bomProductType
                Case "All"
                    StrProductType = Nothing
                Case "0"
                    StrProductType = "T"
                Case "1"
                    StrProductType = "C"
                Case "2"
                    StrProductType = "P"
            End Select


            'GridBom_Main.DataSource = bmm.Bom_M_GetList(Nothing, Nothing, msi(0).bomBeginDate, Nothing, StrCheck, StrUser, StrProductType, Nothing, msi(0).bomDisplayNum)
        Else
            'GridBom_Main.DataSource = bmm.Bom_M_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        End If
    End Sub
#End Region

#Region "查詢操作"
    ''' <summary>
    ''' 查詢操作
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        'Dim fr As New frmSelect
        'fr.FormText = "MRP產品結構"
        'fr.TableName = "Bom_M"
        'fr.ID = "ParentGroup"
        'fr.ShowDialog()
        'If String.IsNullOrEmpty(tempValue) = False Then
        '    GridBom_Main.DataSource = sc.MrpBom_GetList(tempValue)
        'End If

        'Dim fr As New frmMrpSelect
        'fr = New frmMrpSelect
        'fr.EditItem = "MrpBOM_M"
        'fr.lblinfo.Text = "產品結構--查詢"
        'fr.ShowDialog()
        'Select Case tempValue
        '    Case "固定樣式"
        '        GridBom_Main.DataSource = bmm.Bom_M_GetList(tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        '    Case "自定義樣式"
        '        Dim MScon As New MrpSelect_Controller
        'GridBom_Main.DataSource = MScon.MrpBom_M_Select_GetList("MrpBOM_M", tempValue2)
        'End Select
    End Sub
#End Region

#Region "列印"
    '''' <summary>
    '''' 列印單張報表
    '''' </summary>
    '''' <param name="sender"></param>
    '''' <param name="e"></param>
    '''' <remarks></remarks>
    'Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
    '    Dim ds As New DataSet
    '    Dim ltc1 As New CollectionToDataSet
    '    Dim ltc2 As New CollectionToDataSet
    '    Dim bmminfo As New List(Of Bom_MInfo)
    '    Dim bmdinfo As New List(Of Bom_DInfo)
    '    bmminfo = bmm.Bom_M_GetList(GridView1.GetFocusedRowCellValue("ParentGroup"), GridView1.GetFocusedRowCellValue("Version"), Nothing, Nothing, Nothing, Nothing)
    '    bmdinfo = bmd.Bom_D_GetList(GridView1.GetFocusedRowCellValue("ParentGroup"))
    '    ltc1.CollToDataSet(ds, "Bom_M", bmminfo)
    '    ltc2.CollToDataSet(ds, "Bom_D", bmdinfo)
    '    PreviewRPT(ds, "rptBomSingle", "產品結構單張報表", True, True)
    '    ltc1 = Nothing
    'End Sub

#End Region

#Region "BOM產品展開"
    Private Sub cmdBom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBom.Click
        On Error Resume Next
        Dim fr As frmBomTree
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmBomTree Then
                fr.Close()
                ' Exit Sub
            End If
        Next
        fr = New frmBomTree
        fr.MdiParent = MDIMain
        fr.EditItem = GridView1.GetFocusedRowCellValue("ParentGroup")
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
#End Region

    Private Sub tsm_BOM_D1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_BOM_D1.Click
        Dim ds As New DataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim bmminfo As New List(Of Bom_MInfo)
        Dim bmdinfo As New List(Of Bom_DInfo)
        Dim StrSend As String = String.Empty
        StrSend = InUser
        'bmminfo = bmm.Bom_M_GetList(GridView1.GetFocusedRowCellValue("ParentGroup"), GridView1.GetFocusedRowCellValue("Version"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        'bmdinfo = bmd.Bom_D_GetList(GridView1.GetFocusedRowCellValue("ParentGroup"))
        ltc1.CollToDataSet(ds, "Bom_M", bmminfo)
        ltc2.CollToDataSet(ds, "Bom_D", bmdinfo)
        PreviewRPT1(ds, "rptBOMInfo", StrSend, StrSend, "產品結構物料明細表", True, True)
        ltc1 = Nothing
        ltc2 = Nothing
    End Sub

    Private Sub tsm_PrintBOM_M_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_PrintBOM_M_All.Click
        On Error Resume Next
        Dim fr As MrpReportSelect
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is MrpReportSelect Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New MrpReportSelect
        fr.intShowPage = 1
        'fr.MdiParent = MDIMain
        'fr.WindowState = FormWindowState.Maximized
        fr.ShowDialog()
        fr.Focus()

        'Dim ds As New DataSet
        'Dim ltc1 As New CollectionToDataSet
        'Dim bmminfo As New List(Of Bom_MInfo)
        'Dim StrSend As String = String.Empty
        'StrSend = InUser
        'bmminfo = bmm.Bom_M_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        'ltc1.CollToDataSet(ds, "Bom_M", bmminfo)
        'PreviewRPT1(ds, "rptBomAll", StrSend, StrSend, "產品結構物料信息總表", True, True)
        'ltc1 = Nothing
    End Sub

#Region "導出Excel"
    Private Sub cmsExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsBom_MExcel.Click, cmsBom_DExcel.Click
        If sender.Owner Is ContextMenuStrip1 Then 
            ConrotlExportExcel(GridBom_Main)
        ElseIf xtcTable.SelectedTabPage Is xtpB Then
            ConrotlExportExcel(TreeList1)
        ElseIf xtcTable.SelectedTabPage Is xtpA Then
            ConrotlExportExcel(GridBom_Detail)
        ElseIf xtcTable.SelectedTabPage Is xtpC Then
            ConrotlExportExcel(Grid3)
        End If
    End Sub
#End Region

End Class