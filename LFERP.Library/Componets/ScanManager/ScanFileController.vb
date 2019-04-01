Namespace LFERP.Library.ScanManager
    Public Class ScanFileController
#Region "文件管理"
        ''' <summary>
        ''' 檢查目錄是否存在,不存在帽建立
        ''' </summary>
        ''' <param name="FolderName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function CreateFolder(ByVal FolderName As String) As Boolean
            Try
                Dim Str_Folder As String = FolderName
                Dim ftpReq As Net.FtpWebRequest = Net.WebRequest.Create(Str_Folder)
                ftpReq.Method = Net.WebRequestMethods.Ftp.MakeDirectory
                ftpReq.Credentials = New Net.NetworkCredential(FtpUser, FtpPassWord)
                Dim ftpResp As Net.FtpWebResponse = ftpReq.GetResponse
                ftpResp.Close()
                CreateFolder = True
            Catch ex As Exception
                ' MsgBox(ex.Message & FolderName)
                CreateFolder = False
            End Try
        End Function
        ''' <summary>
        ''' 檢查目錄,以工號文件建立
        ''' </summary>
        ''' <remarks></remarks>
        Private Function CheckFolder(ByVal IsUserID As String) As String
            Dim temp As String
            temp = FtpScanServer() & "/" & IsUserID & "/"
            Try
                '依工號建立
                If System.IO.Directory.Exists(temp) = False Then
                    CreateFolder(temp)
                End If
                CheckFolder = temp
            Catch ex As Exception
                CheckFolder = ""
                MsgBox(ex.Message)
            End Try
        End Function
        ''' <summary>
        ''' 上傳文件
        ''' </summary>
        ''' <param name="sourcePathAndFileName">來源文件地址及文件名</param>
        ''' <param name="NewName">存放於服務器上的新文件名</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function UploadFile(ByVal sourcePathAndFileName As String, ByVal NewName As String, ByVal IsUserID As String) As String
            Dim temp As String
            temp = CheckFolder(IsUserID)
            If temp = "" Then
                UploadFile = ""
                Exit Function
            End If
            Try
                My.Computer.Network.UploadFile(sourcePathAndFileName, temp & "/" & NewName, FtpUser, FtpPassWord, True, 100, FileIO.UICancelOption.ThrowException)
                UploadFile = temp

            Catch ex As Exception
                UploadFile = ""
                MsgBox(ex.Message)
            End Try
        End Function
        ''' <summary>
        ''' 下載文件
        ''' </summary>
        ''' <param name="FileAddress"></param>
        ''' <param name="NewPathName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function DownloadFile(ByVal FileAddress As String, ByVal NewPathName As String) As String
            My.Computer.Network.DownloadFile(FtpScanServer() & "/" & FileAddress, NewPathName, FtpUser, FtpPassWord, True, 100, True)
            DownloadFile = NewPathName
        End Function
#End Region




        ''' <summary>
        ''' 上傳文件
        ''' </summary>
        ''' <param name="strFilePath"></param>
        ''' <param name="objFile"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function File_Update(ByVal strFilePath As String, ByVal objFile As ScanFileInfo) As Boolean
            Dim tempPath As String
            '生成路徑
            tempPath = objFile.SF_Per
            If objFile Is Nothing Then
                File_Update = False
            Else
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ScanFile_Add")
                db.AddInParameter(dbComm, "@SF_No", DbType.String, objFile.SF_No)
                db.AddInParameter(dbComm, "@SF_Remark", DbType.String, objFile.SF_Remark)
                db.AddInParameter(dbComm, "@SF_Date", DbType.String, objFile.SF_Date)
                db.AddInParameter(dbComm, "@SF_Action", DbType.String, objFile.SF_Action)
                db.AddInParameter(dbComm, "@SF_Per", DbType.String, objFile.SF_Per)
                Dim returnValue As New SqlParameter("@SF_FileName", SqlDbType.VarChar, 88)
                returnValue.Direction = ParameterDirection.Output
                dbComm.Parameters.Add(returnValue)
                db.AddInParameter(dbComm, "@SF_FileType", DbType.String, objFile.SF_FileType)
                db.AddInParameter(dbComm, "@SF_FilePath", DbType.String, tempPath)
                db.AddInParameter(dbComm, "@SF_Length", DbType.String, objFile.SF_Length)
                Dim tTemp As String = ""
                db.ExecuteNonQuery(dbComm)
                tTemp = dbComm.Parameters("@SF_FileName").Value.ToString()
                'MsgBox(tTemp)

                File_Update = True
                UploadFile(strFilePath, tTemp, objFile.SF_Per)


            End If
        End Function
        ''' <summary>
        ''' 取得選定類型模塊內的單號所附加的檔案清單
        ''' </summary>
        ''' <param name="SF_No"></param>
        ''' <param name="SF_Action"></param>
        ''' <param name="SF_Per"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ScanFile_GetList(ByVal SF_No As String, ByVal SF_Action As String, ByVal SF_Per As String, ByVal SF_Remark As String, ByVal SF_DateBegin As String, ByVal SF_DateEnd As String) As List(Of ScanFileInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ScanFile_GetList")
            If SF_No Is Nothing Then
                db.AddInParameter(dbComm, "@SF_No", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@SF_No", DbType.String, SF_No)
            End If
            If SF_Action Is Nothing Then
                db.AddInParameter(dbComm, "@SF_Action", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@SF_Action", DbType.String, SF_Action)
            End If
            If SF_Per Is Nothing Then
                db.AddInParameter(dbComm, "@SF_Per", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@SF_Per", DbType.String, SF_Per)
            End If
            db.AddInParameter(dbComm, "@SF_Remark", DbType.String, SF_Remark)
            db.AddInParameter(dbComm, "@SF_DateBegin", DbType.String, SF_DateBegin)
            db.AddInParameter(dbComm, "@SF_DateEnd", DbType.String, SF_DateEnd)

            Dim FeatureList As New List(Of ScanFileInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillScanFileList(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Friend Function FillScanFileList(ByVal reader As IDataReader) As ScanFileInfo
            On Error Resume Next
            '對應取得的數據,多條記錄時使用，
            Dim objInfo As New ScanFileInfo
            objInfo.SF_No = reader("SF_No").ToString
            objInfo.SF_Remark = reader("SF_Remark").ToString
            objInfo.SF_ActionName = reader("SF_ActionName").ToString
            objInfo.SF_Action = reader("F_Action").ToString
            If reader("SF_Date") Is DBNull.Value Then
                objInfo.SF_Date = Nothing
            Else
                objInfo.SF_Date = CStr(reader("SF_Date"))
            End If
            objInfo.SF_Per = reader("SF_Per").ToString
            objInfo.SF_PerName = reader("SF_PerName").ToString
            objInfo.SF_FileType = reader("SF_FileType").ToString
            objInfo.SF_FilePath = reader("SF_FilePath").ToString
            objInfo.SF_FileName = reader("SF_FileName").ToString
            objInfo.SF_Length = reader("SF_Length").ToString
            Return objInfo
        End Function
        ''' <summary>
        ''' 打開文件
        ''' </summary>
        ''' <param name="SF_No"></param>       
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function File_Open(ByVal SF_No As String) As Boolean
            Dim objInfo As New List(Of ScanFileInfo)
            Dim strPath As String

            objInfo = ScanFile_GetList(SF_No, Nothing, Nothing, Nothing, Nothing, Nothing)
            If objInfo Is Nothing Then
                File_Open = False
            Else
                strPath = DownloadFile(objInfo(0).SF_FilePath & "/" & objInfo(0).SF_FileName, System.Windows.Forms.Application.StartupPath & _
                "\TempFile\" & objInfo(0).SF_FileName)

                System.Diagnostics.Process.Start(strPath)
                File_Open = True
            End If
            '

        End Function


        Public Function File_DownLoad(ByVal SF_No As String, ByVal SavePath As String) As String
            Dim objInfo As New List(Of ScanFileInfo)
            Dim strPath As String
            strPath = ""
            objInfo = ScanFile_GetList(SF_No, Nothing, Nothing, Nothing, Nothing, Nothing)
            If objInfo Is Nothing Then
                File_DownLoad = ""

            Else
                strPath = DownloadFile(objInfo(0).SF_FilePath & "/" & objInfo(0).SF_FileName, SavePath)
                '下載后打開文件
                'System.Diagnostics.Process.Start(strPath)
                File_DownLoad = strPath
            End If
        End Function
        ''' <summary>
        ''' 刪除文件
        ''' </summary>
        ''' <param name="SF_No"></param>
        ''' <param name="SF_Action"></param>
        ''' <param name="SF_Per"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function File_Delete(ByVal SF_No As String, ByVal SF_Action As String, ByVal SF_Per As String) As Boolean

            Dim objInfo As New List(Of ScanFileInfo)
            Dim objFTP As New FTPAccess


            objInfo = ScanFile_GetList(SF_No, SF_Action, SF_Per, Nothing, Nothing, Nothing)
            If objInfo Is Nothing Then
                File_Delete = False
            Else

                If objFTP.DeleteFile("/LFERPScan/" & objInfo(0).SF_FilePath & "/" & objInfo(0).SF_FileName) = True Then
                    Try
                        Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                        Dim dbComm As DbCommand = db.GetStoredProcCommand("ScanFile_Delete")
                        db.AddInParameter(dbComm, "@SF_No", DbType.String, SF_No)
                        db.ExecuteNonQuery(dbComm)
                        File_Delete = True
                    Catch ex As Exception
                        File_Delete = False
                    End Try
                    File_Delete = True
                End If


            End If

        End Function
    End Class
End Namespace

