Imports System
Imports LFERP.SystemManager
Imports LFERP.Library.ProductProcess

Public Class frmPDProductMain

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        On Error Resume Next
        Edit = False
        Dim fr As frmPDProduct
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmPDProduct Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "產品資料工藝流程單"
        tempValue3 = TreeView1.SelectedNode.Text
        fr = New frmPDProduct
        fr.MdiParent = MDIMain
        fr.Show()

    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pc As New ProcessMainControl
        Dim piL As List(Of ProcessMainInfo)
        piL = pc.ProcessMain_GetList1(GridView1.GetFocusedRowCellValue("Pro_NO"), Nothing, Nothing, Nothing)
        If piL(0).Pro_Check Then
            MsgBox("此工藝流程單已審核或復核，不允許修改！")
            Exit Sub
        End If

        Edit = True
        Dim fr As frmPDProduct
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmPDProduct Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "產品資料工藝流程單"
        tempValue2 = GridView1.GetFocusedRowCellValue("Pro_NO").ToString
        fr = New frmPDProduct
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pc As New ProcessMainControl
        Dim piL As New List(Of ProcessMainInfo)
        piL = pc.ProcessMain_GetList1(GridView1.GetFocusedRowCellValue("Pro_NO"), Nothing, Nothing, Nothing)
        If piL(0).Pro_Check Then
            MsgBox("此工藝流程單已審核或復核，不允許刪除！")
            Exit Sub
        End If
        Dim piL2 As New List(Of ProcessMainInfo)
        Dim pcc As New LFERP.Library.ProductionField.ProductionFieldControl
        piL2 = pc.ProcessSub_GetList(GridView1.GetFocusedRowCellValue("Pro_NO"), Nothing, Nothing, Nothing, Nothing, Nothing)
        For i As Integer = 0 To piL2.Count - 1
            If pcc.ProductionField_GetList1(Nothing, Nothing, Nothing, Nothing, piL2(i).PS_NO.ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing).Count > 0 Then
                MsgBox("此工藝流程單已進入物料流轉,不能刪除!", , "提示")
                Exit Sub
            End If
        Next

        If MsgBox("確定要刪除單號為:" & GridView1.GetFocusedRowCellValue("Pro_NO"), MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        If pc.ProcessMain_Delete(GridView1.GetFocusedRowCellValue("Pro_NO")) Then '刪除主表
            If pc.ProcessSub_Delete(GridView1.GetFocusedRowCellValue("Pro_NO"), Nothing) Then ' 刪除子表
                MsgBox("已刪除成功！")
            End If
        End If

        For i As Integer = 0 To piL2.Count - 1 '刪除物料編碼表
            pc.MaterialCode2_Del(piL2(i).PS_NO.ToString)
        Next

        GridControl1.DataSource = pc.ProcessMain_GetList1(Nothing, Nothing, TreeView1.SelectedNode.Text, Nothing)
    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim fr As frmPDProduct
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmPDProduct Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "查看"
        tempValue2 = GridView1.GetFocusedRowCellValue("Pro_NO").ToString
        fr = New frmPDProduct
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        Dim myfrm As New frmPDProduckSelect
        myfrm.ComboBoxEdit1.Text = TreeView1.SelectedNode.Text
        myfrm.ShowDialog()
        Dim pc As New ProcessMainControl

        If tempValue5 = "單擊查詢按鈕" Then
            GridControl1.DataSource = pc.ProcessMain_GetList(tempValue, tempValue3, tempValue2, tempValue4, Nothing, Nothing)
        End If

        tempValue = ""
        tempValue2 = ""
        tempValue3 = ""
        tempValue4 = ""
        tempValue5 = ""
    End Sub

    Private Sub cmdCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheck.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim fr As frmPDProduct
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmPDProduct Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "審核"
        tempValue2 = GridView1.GetFocusedRowCellValue("Pro_NO").ToString
        fr = New frmPDProduct
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub frmPDProductMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "850106")
        Dim StrAarray As Array = Split(pmwiL.Item(0).PMWS_Value, ",")
        For i As Integer = 0 To UBound(StrAarray)
            TreeView1.Nodes.Add(StrAarray(i))
        Next
        TreeView1.Select()
        PowerUser()
    End Sub
    '設置權限
    Sub PowerUser()

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "850101")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "850102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "850103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdDel.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "850104")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdCheck.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "850107")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripModifyPSName.Enabled = True
        End If


    End Sub
    Private Sub cmdRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRef.Click
        Dim pc As New ProcessMainControl
        GridControl1.DataSource = pc.ProcessMain_GetList1(Nothing, Nothing, TreeView1.SelectedNode.Text, Nothing)
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim pc As New ProcessMainControl
        GridControl1.DataSource = pc.ProcessMain_GetList1(Nothing, Nothing, TreeView1.SelectedNode.Text, Nothing)
    End Sub

    Private Sub PreViewMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreViewMenuItem.Click
        Dim ds As New DataSet
        If GridView1.RowCount = 0 Then Exit Sub
        Dim PC_NO As String, Str As String
        Str = GridView1.GetFocusedRowCellValue("Pro_NO").ToString

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet


        Dim Pc As New LFERP.Library.ProductProcess.ProcessMainControl
        Dim Pmc As New LFERP.Library.ProductProcess.ProductComplaintMainControl

        ds.Tables.Clear()

        ltc.CollToDataSet(ds, "ProcessMain", Pc.ProcessMain_GetList1(Str, Nothing, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "ProcessSub", Pc.ProcessSub_GetList(Str, Nothing, Nothing, Nothing, Nothing, Nothing))

        If Pmc.ProductComplaintMain_GetList(Nothing, Str, Nothing).Count > 0 Then

            ltc2.CollToDataSet(ds, "ProductComplaintMain", Pmc.ProductComplaintMain_GetList(Nothing, Str, Nothing))

            PC_NO = Pmc.ProductComplaintMain_GetList(Nothing, Str, Nothing)(0).PC_NO

            ltc3.CollToDataSet(ds, "ProductComplaintSub", Pmc.ProductComplaintSub_GetList(PC_NO, Nothing, Nothing))
        Else
            With ds.Tables.Add("ProductComplaintMain")

                .Columns.Add("PC_NO", GetType(String))
                .Columns.Add("Pro_NO", GetType(String))
                .Columns.Add("PM_M_Code", GetType(String))
                .Columns.Add("PC_Remark", GetType(String))
                .Columns.Add("PC_Action", GetType(String))
                .Columns.Add("PC_AddDate", GetType(Date))
                .Columns.Add("PC_EditDate", GetType(Date))
                .Columns.Add("ActionName", GetType(String))
            End With
            Dim row As DataRow = ds.Tables("ProductComplaintMain").NewRow
            ds.Tables("ProductComplaintMain").Rows.Add(row)

            With ds.Tables.Add("ProductComplaintSub")

                .Columns.Add("IndexNO", GetType(Integer))
                .Columns.Add("PS_Num", GetType(String))
                .Columns.Add("PS_NO", GetType(String))
                .Columns.Add("PS_Name", GetType(String))
                .Columns.Add("D_Name", GetType(String))
                .Columns.Add("PS_Question", GetType(String))
                .Columns.Add("PC_NO", GetType(String))
                .Columns.Add("PS_Photo", GetType(Byte()))
            End With
            Dim row1 As DataRow = ds.Tables("ProductComplaintSub").NewRow
            ds.Tables("ProductComplaintSub").Rows.Add(row1)
        End If

        ds.Tables("ProcessMain").Columns.Add("P_ID", GetType(Integer))
        Dim i As Long

        For i = 0 To ds.Tables("ProcessMain").Rows.Count - 1
            ds.Tables("ProcessMain").Rows(i)("P_ID") = i + 1
        Next

        PreviewRPT(ds, "rptProcessMain", "產品工藝流程單", True, True)

        ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing
        ltc3 = Nothing

    End Sub

    Private Sub ToolStripModifyPSName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripModifyPSName.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pc As New ProcessMainControl
        Dim piL As List(Of ProcessMainInfo)
        piL = pc.ProcessMain_GetList1(GridView1.GetFocusedRowCellValue("Pro_NO"), Nothing, Nothing, Nothing)
        

        Edit = True
        Dim fr As frmPDProduct
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmPDProduct Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "ModifyPsName"
        tempValue2 = GridView1.GetFocusedRowCellValue("Pro_NO").ToString
        fr = New frmPDProduct
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub EXToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXToolStripMenuItem.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim saveFileDialog As New SaveFileDialog()

        saveFileDialog.Title = "導出Excel"

        saveFileDialog.Filter = "Excel2003文件(*.xls)|*.xls"
        '|Excel2007及以上文件(*.xlsx)|*.xlsx  '當前測試2007 以及以上版本有誤！

        Dim dialogResult__1 As DialogResult = saveFileDialog.ShowDialog(Me)

        If dialogResult__1 = Windows.Forms.DialogResult.OK Then

            GridControl1.ExportToExcelOld(saveFileDialog.FileName)

            DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
End Class