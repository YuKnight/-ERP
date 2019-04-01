Imports LFERP.DataSetting
Imports LFERP.SystemManager
Public Class frmSupplier



    Dim mt As New SuppliersControler

    Sub LoadSuppliersType()
        Dim mc As New SuppliersTypeControler
        'gluCuster.Properties.DisplayMember = "S_TypeID"
        'gluCuster.Properties.ValueMember = "S_TypeID"
        TreeList1.DataSource = mc.SuppliersType_GetList(Nothing, Nothing, Nothing)
    End Sub


    Private Sub frmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grid1.DataSource = mt.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        LoadSuppliersType()
        LoadUserPower()
    End Sub

    Private Sub Grid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If GridView1.RowCount = 0 Then
            Exit Sub
        Else
            tempValue = GridView1.GetSelectedCells("S_Supplier").ToString
        End If
    End Sub



    Private Sub popAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popAdd.Click


        On Error Resume Next
        Edit = False
        MTypeName = "SupplierAddEdit"

        Dim fr As FrmSupplier_Add
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is FrmSupplier_Add Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New FrmSupplier_Add
        fr.MdiParent = MDIMain
        fr.Show()


       
    End Sub

    Private Sub PopEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopEdit.Click
        On Error Resume Next
        If GridView1.RowCount <= 0 Then Exit Sub

        tempValue = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "S_Supplier")
        Dim sc As New SuppliersControler
        Dim si As New SuppliersInfo
        si = sc.Suppliers_Get(tempValue, Nothing)

        If si.S_Check = True Or si.S_ReCheck = True Then
            MsgBox("不能修改已審核或已終審的記錄", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        Edit = True
        MTypeName = "SupplierAddEdit"

        Dim fr As FrmSupplier_Add
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is FrmSupplier_Add Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New FrmSupplier_Add
        fr.MdiParent = MDIMain
        fr.Show()


    End Sub

  

    Private Sub popDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popDel.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        tempValue = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "S_Supplier")
        Dim sc As New SuppliersControler
        Dim si As New SuppliersInfo
        si = sc.Suppliers_Get(tempValue, Nothing)

        If si.S_Check = True Or si.S_ReCheck = True Then
            MsgBox("不能刪除已審核或已終審的記錄", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        If MsgBox("你確定刪除供應商代號為  '" & tempValue & "'  的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim mc As New SuppliersInfo
            Dim mt As New SuppliersControler
            mc.S_Supplier = tempValue
            If mt.Suppliers_Delete(mc) = True Then
                Grid1.DataSource = mt.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)


            Else
                MsgBox("刪除失敗")
            End If

        End If
    End Sub

  

    Private Sub PopRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopRefresh.Click
        Dim strA As String
        strA = TreeList1.FocusedNode.Item("S_TypeID").ToString()
        If TreeList1.FocusedNode.Id = 0 Then
            strA = Nothing
        End If
        Grid1.DataSource = mt.GetSuppliersList(Nothing, Nothing, strA, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub PopSelect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopSelect.Click
        Dim Myfrm As New frmSupplierSelect
        Dim sc As New SuppliersControler
        tempValue = ""
        tempValue2 = ""
        Myfrm.ShowDialog()
        Select Case tempValue
            Case "1"
                Grid1.DataSource = sc.GetSuppliersList(tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "2"
                Grid1.DataSource = sc.GetSuppliersList(Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing)

            Case "3"
                Grid1.DataSource = sc.GetSuppliersList(Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing)

            Case "4"
                Grid1.DataSource = sc.GetSuppliersList(Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing)

        End Select
        tempValue = ""
        tempValue2 = ""
    End Sub

  

    Private Sub TreeList1_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList1.FocusedNodeChanged
        Dim mt As New SuppliersControler
        Dim strA As String
        strA = TreeList1.FocusedNode.Item("S_TypeID").ToString()
        If TreeList1.FocusedNode.Id = 0 Then
            strA = Nothing
        End If
        Grid1.DataSource = mt.GetSuppliersList(Nothing, Nothing, strA, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Sub LoadUserPower()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "900201")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "900202")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then PopEdit.Enabled = True
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "900203")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popDel.Enabled = True
        End If


        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "900204")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then PopCheck.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "900211")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popReCheck.Enabled = True
        End If
 

    End Sub

    Private Sub PopView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopView.Click
        On Error Resume Next
        If GridView1.RowCount <= 0 Then Exit Sub

        Edit = False
        MTypeName = "SupplierView"

        tempValue = GridView1.GetFocusedRowCellValue("S_Supplier").ToString

        Dim fr As FrmSupplier_Add
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is FrmSupplier_Add Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New FrmSupplier_Add
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub PopCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopCheck.Click
        On Error Resume Next
        If GridView1.RowCount <= 0 Then Exit Sub

        tempValue = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "S_Supplier")
        Dim sc As New SuppliersControler
        Dim si As New SuppliersInfo
        si = sc.Suppliers_Get(tempValue, Nothing)

        '＠ 2012/7/5 添加 判斷是否已終審
        If si.S_ReCheck = True Then
            MsgBox("該供應商已終審，不需再審核！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        MTypeName = "SupplierCheck"

        Dim fr As FrmSupplier_Add
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is FrmSupplier_Add Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New FrmSupplier_Add
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub Popfujia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Popfujia.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim open As Boolean
        Dim update As Boolean
        Dim down As Boolean
        Dim edit As Boolean
        Dim del As Boolean
        Dim detail As Boolean

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As New List(Of PermissionModuleWarrantSubInfo)

        If GridView1.RowCount = 0 Then Exit Sub
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "900205")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then update = True Else update = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "900206")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then down = True Else down = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "900207")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then edit = True Else edit = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "900208")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then del = True Else del = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "900209")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then detail = True Else detail = False
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "900210")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then open = True Else open = False
        End If

        FileShow("9002", GridView1.GetFocusedRowCellValue("S_Supplier").ToString, open, update, down, edit, del, detail)

    End Sub

    '＠ 2012/7/5 添加 終審右鍵菜單
    Private Sub popReCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popReCheck.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        tempValue = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "S_Supplier")

        Dim sc As New SuppliersControler
        Dim si As New SuppliersInfo
        si = sc.Suppliers_Get(tempValue, Nothing)

        If si.S_Check = False Then
            MsgBox("該供應商尚未審核，不能復核！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If


        MTypeName = "SupplierReCheck"

        Dim fr As FrmSupplier_Add
        fr = New FrmSupplier_Add
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub
End Class