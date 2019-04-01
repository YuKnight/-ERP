Imports LFERP.FileManager
Imports LFERP.Library.ScanManager
Public Class frmFileUpdate

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'Dim file As New IO.FileInfo("D:\001.pdf")
        'MsgBox(file.Name)
        If Len(txtName.Text) = 0 Then
            MsgBox("請輸入文件名稱!", , "提示")
            txtName.Focus()
            Exit Sub
        End If
        UpdateFile()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub

    Sub UpdateFile()
        Dim files As New FilesInfo
        Dim filesMtc As New FileController
        Dim file As New IO.FileInfo(txtSourcePath.EditValue)

        'files.F_No = "0000001"
        files.F_Name = txtName.Text
        files.F_Detail = txtDetail.Text
        files.F_AddDate = Format(Now, "yyyy-MM-dd")
        files.F_Action = InUser
        files.F_OldName = file.Name
        files.F_FileType = Mid(file.Name, Len(file.Name) - 3)
        'files.F_NewName = files.F_No & files.F_FileType
        'ftp存放路徑此處由服務器處理
        files.F_FilePath = ""
        files.F_Remark = txtRemark.Text
        files.F_TypeID = popTypeID.EditValue
        files.FB_Type = Label6.Text
        files.FB_TypeNo = Label7.Text

        If filesMtc.File_Update(txtSourcePath.Text, files) = True Then
            MsgBox("上傳成功")
            Me.Close()
        Else
            MsgBox("error")
        End If


    End Sub

    Private Sub txtSourcePath_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSourcePath.ButtonClick
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            txtSourcePath.Text = OpenFileDialog1.FileName

        End If

    End Sub

    Private Sub txtSourcePath_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSourcePath.EditValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(frmFileShow.Label2.Text)

    End Sub

    Private Sub frmFileUpdate_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
       


    End Sub

    Private Sub frmFileUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtName.Text = ""
        popTypeID.Text = ""
        txtSourcePath.Text = ""
        txtDetail.Text = ""
        txtRemark.Text = ""
        OpenFileDialog1.Filter = "|*.doc;*.xls;*.ppt;*.pdf;*.jpg;*.bmp;*.gif;*.txt;*.tif;*.dwg;*.rar"

    End Sub

    Private Sub popTypeID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popTypeID.EditValueChanged

    End Sub

    Private Sub cmdScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScan.Click
        '將選擇的掃描文件下載到本地
        frmScanFileSelect.ShowDialog()
        If frmScanFileSelect.SelectSF_ID <> "" Then

            Dim dt As New ScanFileController
            Dim objInfo As New List(Of ScanFileInfo)

            Dim FilePath As String

            objInfo = dt.ScanFile_GetList(frmScanFileSelect.SelectSF_ID, Nothing, Nothing, Nothing, Nothing, Nothing)
            If objInfo Is Nothing Then Exit Sub
            FilePath = dt.File_DownLoad(objInfo(0).SF_No, Application.StartupPath & "\TempFile\" & objInfo(0).SF_FileName)
            txtSourcePath.Text = FilePath
            txtDetail.Text = objInfo(0).SF_Remark
            objInfo = Nothing

        End If
    End Sub
End Class