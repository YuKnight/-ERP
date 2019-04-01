Imports LFERPDB
Module Setting

    Public strSQL As String
    'Public Const FtpUser As String = "ftpuser"
    'Public Const FtpPassWord As String = "ftppass"
    'Public Const FtpServer As String = "ftp://192.168.1.48:55/LFERP"   
    ''' <summary>
    ''' 連接考勤表數據
    ''' </summary>
    ''' <remarks></remarks>
    Public ConnString As String = "Provider=SQLOLEDB.1;Password=lpflpf;Persist Security Info=True;User ID=sa;Initial Catalog=KaoQin;Data Source=DataServer"
    ''' <summary>
    ''' 數據庫連接
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ConnStr() As String
        Dim dbc As New LFERPDataBase
        ConnStr = dbc.LoadConnStr
    End Function

    Public Function ConnStrPersonnal() As String
        Dim dbc As New LFERPDataBase
        ConnStrPersonnal = dbc.LoadConnStrPersonnal
    End Function

    ''' <summary>
    ''' FTP服務器
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FtpServer() As String
        Dim dbc As New LFERPDataBase
        FtpServer = dbc.FtpServer
    End Function
    Public Function FtpServerIP() As String
        Dim dbc As New LFERPDataBase
        FtpServerIP = dbc.FtpServerip

    End Function
    ''' <summary>
    ''' FTP用戶
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FtpUser() As String
        Dim dbc As New LFERPDataBase
        FtpUser = dbc.FtpUser
    End Function
    ''' <summary>
    ''' FTP密碼
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FtpPassWord() As String
        Dim dbc As New LFERPDataBase
        FtpPassWord = dbc.FtpPassWord
    End Function

    Public Function FtpServerPort() As Integer
        Dim dbc As New LFERPDataBase
        FtpServerPort = dbc.FtpServerPort
    End Function
    ''' <summary>
    ''' 掃描文件存放服務器
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FtpScanServer() As String
        Dim dbc As New LFERPDataBase
        FtpScanServer = dbc.FtpScanServer
    End Function
End Module
