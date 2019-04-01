Imports LFERP.Library.Purchase.WareQuality
Imports LFERP.SystemManager

Public Class frmWareQualityMain
    Dim wqc As New WareQualityController

    Private Sub frmWareQualityMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        popWQRef_Click(Nothing, Nothing)
    End Sub

    '單擊右鍵“添加”菜單
    Private Sub popWQAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWQAdd.Click
        'Dim frmWQAdd As New frmWareQualityAdd
        'frmWQAdd.MdiParent = MDIMain
        'frmWQAdd.WindowState = FormWindowState.Maximized
        'frmWQAdd.Show()

        frmWareQualityAdd.MdiParent = MDIMain
        frmWareQualityAdd.WindowState = FormWindowState.Maximized
        frmWareQualityAdd.Show()
    End Sub

    '單擊右鍵“刷新”菜單
    '此過程被以下過程調用：
    'frmWareQualityMain_Load()
    'popWQDelete_Click()
    'cmdSave_Click.frmWareQualityAdd()
    Public Sub popWQRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWQRef.Click
        Grid.DataSource = wqc.WareQuality_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    '單擊右鍵“修改”菜單
    Private Sub popWQEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWQEdit.Click

        If GridView1.RowCount = 0 Then Exit Sub

        Dim frmWQEdit As New frmWareQualityAdd
        frmWQEdit.MdiParent = MDIMain
        frmWQEdit.WindowState = FormWindowState.Maximized
        frmWQEdit.Text = "物料品質反饋單-修改"
        frmWQEdit.lblTitle.Text = "物料品質反饋單-修改"
        frmWQEdit.txtWQ_Code.Text = GridView1.GetFocusedRowCellValue("WQ_Code").ToString '把選中行的反饋單編號顯示在修改模塊的反饋單編號文本框中
        frmWQEdit.Show()

    End Sub

    '單擊右鍵“查看”菜單
    Private Sub popWQView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWQView.Click

        If GridView1.RowCount = 0 Then Exit Sub

        Dim frmWQView As New frmWareQualityAdd
        frmWQView.MdiParent = MDIMain
        frmWQView.WindowState = FormWindowState.Maximized
        frmWQView.Text = "物料品質反饋單-查看"
        frmWQView.lblTitle.Text = "物料品質反饋單-查看"
        frmWQView.txtWQ_Code.Text = GridView1.GetFocusedRowCellValue("WQ_Code").ToString '把選中行的反饋單編號顯示在查看模塊的反饋單編號文本框中
        frmWQView.Show()

    End Sub

    '單擊右鍵“查詢”菜單
    Private Sub popWQFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWQFind.Click
        frmWareQualityFind.ShowDialog()
    End Sub

    '單擊右鍵“刪除”菜單
    Private Sub popWQDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWQDelete.Click

        If GridView1.RowCount = 0 Then Exit Sub

        Dim wqi As List(Of WareQualityInfo)
        wqi = wqc.WareQuality_GetList(GridView1.GetFocusedRowCellValue("WQ_Code").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If wqi.Count > 0 Then
            If MsgBox("確定刪除反饋單編號為" & GridView1.GetFocusedRowCellValue("WQ_Code").ToString & "的記錄嗎？", MsgBoxStyle.YesNo + vbQuestion, "提示") = MsgBoxResult.Yes Then
                If wqc.WareQuality_Delete(GridView1.GetFocusedRowCellValue("WQ_Code").ToString) = True Then
                    popWQRef_Click(Nothing, Nothing)
                    MsgBox("記錄刪除成功!", 64, "提示")
                End If
            End If
        Else
            MsgBox("此記錄數據庫中不存在!", 64, "提示")
        End If
    End Sub
    '單擊右鍵“附加文件”菜單
    Private Sub popWQAddFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWQAddFile.Click
        'Dim open As Boolean
        'Dim update As Boolean
        'Dim down As Boolean
        'Dim edit As Boolean
        'Dim del As Boolean
        'Dim detail As Boolean
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As New List(Of PermissionModuleWarrantSubInfo)

        'If GridView1.RowCount = 0 Then Exit Sub
        'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400110")
        'If pmwiL.Count > 0 Then
        '    If pmwiL.Item(0).PMWS_Value = "是" Then update = True Else update = False
        'End If

        'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400111")
        'If pmwiL.Count > 0 Then
        '    If pmwiL.Item(0).PMWS_Value = "是" Then down = True Else down = False
        'End If


        'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400112")
        'If pmwiL.Count > 0 Then
        '    If pmwiL.Item(0).PMWS_Value = "是" Then edit = True Else edit = False
        'End If

        'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400113")
        'If pmwiL.Count > 0 Then
        '    If pmwiL.Item(0).PMWS_Value = "是" Then del = True Else del = False
        'End If

        'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400114")
        'If pmwiL.Count > 0 Then
        '    If pmwiL.Item(0).PMWS_Value = "是" Then detail = True Else detail = False
        'End If

        'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400115")
        'If pmwiL.Count > 0 Then
        '    If pmwiL.Item(0).PMWS_Value = "是" Then open = True Else open = False

        'End If
        'FileShow("40081", GridView1.GetFocusedRowCellValue("WQ_Code").ToString, open, update, down, edit, del, detail)

        '調用過程FileShow(),顯示附加文件客體
        FileShow("40081", GridView1.GetFocusedRowCellValue("WQ_Code").ToString, True, True, True, True, True, True)
    End Sub

    Private Sub popWQPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popWQPrint.Click

    End Sub
End Class