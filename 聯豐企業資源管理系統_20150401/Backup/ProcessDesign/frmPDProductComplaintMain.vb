Imports LFERP.Library.ProductProcess
Imports LFERP.SystemManager


Public Class frmPDProductComplaintMain

    Dim pc As New ProductComplaintMainControl

    Private Sub frmPDProductComplaintMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grid.DataSource = pc.ProductComplaintMain_GetList(Nothing, Nothing, Nothing)
        PowerUser()
    End Sub
    '設置權限
    Sub PowerUser()

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "850201")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmsComplaintAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "850202")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmsComplaintEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "850203")
        If pmwiL.Count > 0 Then

            If pmwiL.Item(0).PMWS_Value = "是" Then cmsComplaintDel.Enabled = True
        End If

      
    End Sub

    Private Sub cmsComplaintAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsComplaintAdd.Click
        On Error Resume Next
        Edit = False

        Dim fr As frmPDProductComplaint
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmPDProductComplaint Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "工藝流程投訴"
        fr = New frmPDProductComplaint
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub cmsComplaintEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsComplaintEdit.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Edit = True

        Dim fr As frmPDProductComplaint
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmPDProductComplaint Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "工藝流程投訴"
        tempValue2 = GridView1.GetFocusedRowCellValue("PC_NO").ToString
        fr = New frmPDProductComplaint
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub cmsComplaintDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsComplaintDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        If MsgBox("確定要刪除單號為:" & GridView1.GetFocusedRowCellValue("PC_NO").ToString, MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        If pc.ProductComplaintMain_Delete(GridView1.GetFocusedRowCellValue("PC_NO").ToString) = True Then
            If pc.ProductComplaintSub_Delete(GridView1.GetFocusedRowCellValue("PC_NO").ToString, Nothing) = True Then
                MsgBox("刪除成功！", , "提示")
            End If
        End If
        Grid.DataSource = pc.ProductComplaintMain_GetList(Nothing, Nothing, Nothing)
    End Sub

    Private Sub cmsComplaintView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsComplaintView.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim fr As frmPDProductComplaint
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmPDProductComplaint Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "PreView"
        tempValue2 = GridView1.GetFocusedRowCellValue("PC_NO").ToString
        fr = New frmPDProductComplaint
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub cmsComplaintRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsComplaintRef.Click
        Grid.DataSource = pc.ProductComplaintMain_GetList(Nothing, Nothing, Nothing)
    End Sub

    Private Sub cmsComplaintQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsComplaintQuery.Click
        Dim pc As New ProductComplaintMainControl
        Dim pi As New ProductComplaintMainInfo
        ForPDProductComplaintSelect.ShowDialog()
        Select Case tempValue
            Case "1"
                Grid.DataSource = pc.ProductComplaintMain_GetList(Nothing, tempValue2, Nothing)
            Case "2"
                Grid.DataSource = pc.ProductComplaintMain_GetList(tempValue2, Nothing, Nothing)
            Case "3"
                Grid.DataSource = pc.ProductComplaintMain_GetList(Nothing, Nothing, tempValue2)
           
        End Select

        tempValue = ""
        tempValue2 = ""
    End Sub

    Private Sub ReViewMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReViewMenuItem.Click
        Dim ds As New DataSet
        If GridView1.RowCount = 0 Then Exit Sub
        Dim StrA As String, StrB As String
        StrA = GridView1.GetFocusedRowCellValue("Pro_NO").ToString
        StrB = GridView1.GetFocusedRowCellValue("PC_NO").ToString

        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet


        Dim Pc As New LFERP.Library.ProductProcess.ProcessMainControl
        Dim Pmc As New LFERP.Library.ProductProcess.ProductComplaintMainControl

        ds.Tables.Clear()

        ltc.CollToDataSet(ds, "ProcessMain", Pc.ProcessMain_GetList1(StrA, Nothing, Nothing, Nothing))
        ltc1.CollToDataSet(ds, "ProcessSub", Pc.ProcessSub_GetList(StrA, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc2.CollToDataSet(ds, "ProductComplaintMain", Pmc.ProductComplaintMain_GetList(StrB, Nothing, Nothing))
        ltc3.CollToDataSet(ds, "ProductComplaintSub", Pmc.ProductComplaintSub_GetList(StrB, Nothing, Nothing))

        ds.Tables("ProductComplaintMain").Columns.Add("PC_ID", GetType(Integer))
        Dim i As Long

        For i = 0 To ds.Tables("ProductComplaintMain").Rows.Count - 1
            ds.Tables("ProductComplaintMain").Rows(i)("PC_ID") = i + 1
        Next

        PreviewRPT(ds, "rptProductComplaintMain", "產品工藝投訴單", True, True)

        ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing
        ltc3 = Nothing
    End Sub
End Class