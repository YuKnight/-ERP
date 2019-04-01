Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports LFERP.Library.ScanManager
Public Class frmScan


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click



        Dim document As New iTextSharp.text.Document
        'document = New iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 0, 0, 0, 0)

        Dim sngTemp As Single
        Dim jpeg1 As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(ds.Tables("Image").Rows(0)("Image"))
        sngTemp = jpeg1.ScaledWidth / jpeg1.ScaledHeight
        'MsgBox(sngTemp)
        If sngTemp > 2 Then
        ElseIf sngTemp > 1.3 Then
            document = New Document(PageSize.A4.Rotate, 0, 0, 0, 0)
        ElseIf sngTemp >= 1 And sngTemp < 1.3 Then
            document = New Document(PageSize.A4, 0, 0, 0, 0)
        ElseIf sngTemp >= 0.7 And sngTemp < 1 Then
            document = New Document(PageSize.A4, 0, 0, 0, 0)
        ElseIf sngTemp < 0.7 Then
            document = New Document(PageSize.A4, 0, 0, 0, 0)
        End If

        Dim FilePath As String
        FilePath = Application.StartupPath & "\TempFile\TempScan.PDF"

        Dim i As Integer
        If ds.Tables("Image").Rows.Count = 0 Then
            MsgBox("沒有掃描文件,請掃描后再保存!", , "提示")
            Exit Sub
        End If

        If txtPer.EditValue = "" Then
            MsgBox("沒有選擇接收人", , "提示")
            Exit Sub
        End If

        PdfWriter.GetInstance(document, New IO.FileStream(FilePath, FileMode.Create))
        document.Open()

        For i = 0 To ds.Tables("Image").Rows.Count - 1
            Dim jpeg As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(ds.Tables("Image").Rows(i)("Image"))

            'If i = 0 Then
            '    document.Add(SetImage(jpeg, document))

            'Else
            document.Add(CheckImage(jpeg))
            'End If
            '新增一頁
            document.NewPage()
        Next
        document.Close()
        ds.Tables("Image").Rows.Clear()
        pic.Image = Nothing
        document.Close()


        If UpdateFile(FilePath) = True Then
            MsgBox("添加成功!", , "提示")
        Else
            MsgBox("添加失敗!", , "提示")
        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmScan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With ds.Tables.Add("Image")
            .Columns.Add("Image", GetType(Byte()))
            .Columns.Add("Page", GetType(String))
        End With


        Grid.AutoGenerateColumns = False
        Grid.RowHeadersWidth = 15

        Grid.DataSource = ds.Tables("Image")

        Dim mt As New LFERP.SystemManager.SystemUser.SystemUserController
        txtPer.Properties.DisplayMember = "U_Name"
        txtPer.Properties.ValueMember = "U_ID"
        txtPer.Properties.DataSource = mt.SystemUser_GetList(Nothing, Nothing, Nothing)
        GridView3.StartIncrementalSearch(InUserID)

    End Sub

   

    Function SetImage(ByVal jpeg As iTextSharp.text.Image, ByVal document As iTextSharp.text.Document) As iTextSharp.text.Image
        Dim sngTemp As Single
        Dim lngTemp As Long
        sngTemp = jpeg.ScaledWidth / jpeg.ScaledHeight
        MsgBox(sngTemp)
        If sngTemp > 2 Then

        ElseIf sngTemp > 1.3 Then
            'document.PageSize.Rotate()
            'document = New Document(PageSize.A4.Rotate, 0, 0, 0, 0)
            lngTemp = (810 / jpeg.ScaledWidth) * jpeg.ScaledHeight
            jpeg.ScaleAbsoluteWidth(810 - 810 * 0.05)   '570
            jpeg.ScaleAbsoluteHeight(lngTemp - lngTemp * 0.05)  '356
            'document = New Document(PageSize.A4.Rotate, 0, 0, 0, 0)
            'lngTemp = (595 / jpeg.ScaledHeight) * jpeg.ScaledWidth
            'jpeg.ScaleAbsoluteWidth(lngTemp)
            'jpeg.ScaleAbsoluteHeight(595)
        ElseIf sngTemp >= 1 And sngTemp < 1.3 Then
            document = New Document(PageSize.A4, 0, 0, 0, 0)
            lngTemp = (810 / jpeg.ScaledWidth) * jpeg.ScaledHeight
            jpeg.ScaleAbsoluteWidth(810)   '570
            jpeg.ScaleAbsoluteHeight(lngTemp)  '356
        ElseIf sngTemp >= 0.7 And sngTemp < 1 Then
            document = New Document(PageSize.A4, 0, 0, 0, 0)
            lngTemp = (595 / jpeg.ScaledWidth) * jpeg.ScaledHeight
            jpeg.ScaleAbsoluteWidth(595)    '595 A4頁面相附
            jpeg.ScaleAbsoluteHeight(lngTemp)
        ElseIf sngTemp < 0.7 Then
            document = New Document(PageSize.A4, 0, 0, 0, 0)
            lngTemp = (790 / jpeg.ScaledHeight) * jpeg.ScaledWidth
            jpeg.ScaleAbsoluteWidth(lngTemp)
            jpeg.ScaleAbsoluteHeight(790)
        End If
        'MsgBox(jpeg.Width & "," & jpeg.Height)
        jpeg.SetDpi(72, 72)
        SetImage = jpeg

    End Function

    ''' <summary>
    ''' 設置圖片位置及參數
    ''' </summary>
    ''' <param name="jpeg"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function CheckImage(ByVal jpeg As iTextSharp.text.Image) As iTextSharp.text.Image
        Dim sngTemp As Single
        Dim lngTemp As Long
        sngTemp = jpeg.ScaledWidth / jpeg.ScaledHeight
        If sngTemp > 2 Then

        ElseIf sngTemp > 1.3 Then
            lngTemp = (595 / jpeg.ScaledHeight) * jpeg.ScaledWidth
            jpeg.ScaleAbsoluteWidth(lngTemp)
            jpeg.ScaleAbsoluteHeight(595)
        ElseIf sngTemp >= 1 And sngTemp < 1.3 Then
            lngTemp = (810 / jpeg.ScaledWidth) * jpeg.ScaledHeight
            jpeg.ScaleAbsoluteWidth(810)   '570
            jpeg.ScaleAbsoluteHeight(lngTemp)  '356
        ElseIf sngTemp >= 0.7 And sngTemp < 1 Then
            lngTemp = (595 / jpeg.ScaledWidth) * jpeg.ScaledHeight
            jpeg.ScaleAbsoluteWidth(595)    '595 A4頁面相附
            jpeg.ScaleAbsoluteHeight(lngTemp)
        ElseIf sngTemp < 0.7 Then
            lngTemp = (790 / jpeg.ScaledHeight) * jpeg.ScaledWidth
            jpeg.ScaleAbsoluteWidth(lngTemp)
            jpeg.ScaleAbsoluteHeight(790)
        End If
        '
        'jpeg.SetAbsolutePosition(10, 10)
        jpeg.SetDpi(72, 72)
        CheckImage = jpeg
    End Function



    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScan.Click
        '掃描文件
        MDIMain.ScanFile()

    End Sub



    Private Sub Grid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Click
        If Grid.RowCount = 0 Then Exit Sub

        pic.Image = ByteToImage(ds.Tables("Image").Rows(CInt(Grid.CurrentRow.Cells("Page").Value))("Image"))

    End Sub


    Function UpdateFile(ByVal FilePath As String) As Boolean
        Dim files As New ScanFileInfo
        Dim filesMtc As New ScanFileController
        Dim file As New IO.FileInfo(FilePath)

        'files.F_No = "0000001"
        files.SF_Remark = txtRemark.Text
        files.SF_Date = Format(Now, "yyyy-MM-dd hh:mm:ss")
        files.SF_Action = InUserID
        files.SF_Per = txtPer.EditValue
        'files.SF_FileName = file.Name
        files.SF_FileType = Mid(file.Name, Len(file.Name) - 3)
        'files.F_NewName = files.F_No & files.F_FileType
        'ftp存放路徑此處由服務器處理
        files.SF_FilePath = ""
        files.SF_Length = GetFileLength(file.Length)
        If filesMtc.File_Update(FilePath, files) = True Then
            UpdateFile = True
        Else
            UpdateFile = False
        End If

    End Function

    

    Private Sub cmdSelScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelScan.Click
        MDIMain.SelectScan()

    End Sub

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

  
   
    
End Class