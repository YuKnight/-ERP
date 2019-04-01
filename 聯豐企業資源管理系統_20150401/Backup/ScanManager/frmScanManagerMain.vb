Imports LFERP.SystemManager
Imports LFERP.Library.ScanManager
Public Class frmScanManagerMain

    Private Sub frmScanManagerMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Grid.AutoGenerateColumns = False
        Grid.RowHeadersWidth = 15
        GridUser.AutoGenerateColumns = False
        GridUser.RowHeadersWidth = 15

        Dim uls As New SystemUser.SystemUserController
        GridUser.DataSource = uls.SystemUser_GetList(InUserID, Nothing, Nothing)
        GridUser_Click(Nothing, Nothing)      '@ 2012/7/10 添加 調用單擊用戶事件
    End Sub

    Private Sub GridUser_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridUser.CellContentClick

    End Sub

    Private Sub GridUser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridUser.Click
        Dim mt As New ScanFileController
        Grid.DataSource = mt.ScanFile_GetList(Nothing, Nothing, GridUser.CurrentRow.Cells("U_ID").Value.ToString(), Nothing, Nothing, Nothing)

    End Sub

    Private Sub popScanManagerScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popScanManagerScan.Click
        'frmScan.MdiParent = MDIMain

        'frmScan.Show()
        Dim fr As New Form

        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmScan Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = frmScan
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub

    Private Sub popScanManagerOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popScanManagerOpen.Click
        Dim dt As New ScanFileController
        If Grid.Rows.Count = 0 Then Exit Sub
        'MsgBox(lvwFile.SelectedItems.Item(0).Text)
        dt.File_Open(Grid.CurrentRow.Cells("SF_No").Value.ToString)

    End Sub

    Private Sub popScanManagerDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popScanManagerDel.Click
        If Grid.Rows.Count = 0 Then Exit Sub
        If MsgBox("你確定要刪除 " & Grid.CurrentRow.Cells("SF_No").Value.ToString & " 這個文件嗎?", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.No Then Exit Sub

        Dim dt As New ScanFileController
        If dt.File_Delete(Grid.CurrentRow.Cells("SF_No").Value.ToString, Nothing, Nothing) = True Then
            Grid.DataSource = dt.ScanFile_GetList(Nothing, Nothing, InUserID, Nothing, Nothing, Nothing)
        Else
            MsgBox("刪除失敗", , "提示")

        End If
    End Sub

    Private Sub popScanManagerDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popScanManagerDown.Click
        Dim dt As New ScanFileController
        Dim objInfo As New List(Of ScanFileInfo)
        If Grid.Rows.Count = 0 Then Exit Sub
        objInfo = dt.ScanFile_GetList(Grid.CurrentRow.Cells("SF_No").Value.ToString, Nothing, Nothing, Nothing, Nothing, Nothing)

        SaveFileDialog1.Filter = "*" & objInfo(0).SF_FileType & "|" & "*" & objInfo(0).SF_FileType
        SaveFileDialog1.DefaultExt = objInfo(0).SF_FileType
        SaveFileDialog1.FileName = objInfo(0).SF_FileName
        SaveFileDialog1.InitialDirectory = Application.StartupPath & "\TempFile\"
        SaveFileDialog1.ShowDialog()
        'MsgBox(SaveFileDialog1.FileName)

        If SaveFileDialog1.FileName <> "" Then
            'txtSourcePath.Text = OpenFileDialog1.FileName
            dt.File_DownLoad(Grid.CurrentRow.Cells("SF_No").Value.ToString, SaveFileDialog1.FileName)
        End If

    End Sub

    Private Sub popScanManagerEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popScanManagerEmail.Click
        'On Error Resume Next

        If Grid.Rows.Count = 0 Then Exit Sub
        Dim dt As New ScanFileController
        Dim objInfo As New List(Of ScanFileInfo)

        Dim cpi As New DataSetting.CompanyControler
        Dim ci As List(Of DataSetting.CompanyInfo)

        Dim strAddress As String

        ci = cpi.Company_Getlist(Nothing, "LF", Nothing, Nothing)

        If ci.Count = 0 Then
            strAddress = Nothing
        Else
            strAddress = ci(0).CO_ChsAddress

        End If
        Dim strBody As String

        Dim FilePath As String

        objInfo = dt.ScanFile_GetList(Grid.CurrentRow.Cells("SF_No").Value.ToString, Nothing, Nothing, Nothing, Nothing, Nothing)
        If objInfo Is Nothing Then Exit Sub

        strBody = "" & Chr(13) & "" & Chr(13) & "                " & Chr(13) & Chr(13) & Chr(13) & "溫馨提示：此電郵只負責傳送，簽回資料請電郵於單據落款人!!" _
         & Chr(13) & Chr(13) & "Best Regards!" & Chr(13) & "-----------------------------------------------------------------------------------" & Chr(13) _
          & "聯豐表殼廠有限公司" & Chr(13) & "Tel: 0755-27748020                  Fax: 0755-27749753" _
           & Chr(13) & "Address: " & strAddress

        FilePath = dt.File_DownLoad(objInfo(0).SF_No, Application.StartupPath & "\TempFile\" & objInfo(0).SF_FileName)
        SendEmail(objInfo(0).SF_Remark, "", strBody, FilePath)
        objInfo = Nothing

    End Sub

    '@ 2012/7/10 添加 查詢功能
    Private Sub popScanManagerFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popScanManagerFind.Click
        Dim fr As New frmScanFind
        fr.ShowDialog()
        If fr.isClickbtnFind = True Then       '判斷是否單擊了查詢按鈕
            Dim mt As New ScanFileController
            Grid.DataSource = mt.ScanFile_GetList(tempValue, Nothing, GridUser.CurrentRow.Cells("U_ID").Value.ToString(), tempValue2, tempValue3, tempValue4)
        End If
        tempValue = ""
        tempValue2 = ""
        tempValue3 = ""
        tempValue4 = ""
    End Sub

    '@ 2012/7/10 添加 刷新功能
    Private Sub popScanManagerRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popScanManagerRef.Click
        GridUser_Click(Nothing, Nothing)      '調用單擊用戶事件
    End Sub
End Class