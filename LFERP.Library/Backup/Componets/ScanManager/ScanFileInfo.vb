Namespace LFERP.Library.ScanManager
    Public Class ScanFileInfo
        Private _sf_no As String
        Private _sf_remark As String
        Private _sf_date As String
        Private _sf_action As String
        Private _sf_actionname As String
        Private _sf_per As String
        Private _sf_pername As String
        Private _sf_filename As String
        Private _sf_filetype As String
        Private _sf_filepath As String
        Private _sf_length As String

        Public Sub New()
            _sf_no = Nothing
            _sf_remark = Nothing
            _sf_date = Nothing
            _sf_action = Nothing
            _sf_actionname = Nothing
            _sf_per = Nothing
            _sf_pername = Nothing
            _sf_filename = Nothing
            _sf_filetype = Nothing
            _sf_filepath = Nothing
            _sf_length = Nothing
        End Sub

        Public Property SF_No() As String
            Get
                Return _sf_no
            End Get
            Set(ByVal value As String)
                _sf_no = value
            End Set
        End Property
        Public Property SF_Remark() As String
            Get
                Return _sf_remark
            End Get
            Set(ByVal value As String)
                _sf_remark = value
            End Set
        End Property
        Public Property SF_Date() As String
            Get
                Return _sf_date
            End Get
            Set(ByVal value As String)
                _sf_date = value
            End Set
        End Property
        Public Property SF_Action() As String
            Get
                Return _sf_action
            End Get
            Set(ByVal value As String)
                _sf_action = value
            End Set
        End Property
        Public Property SF_ActionName() As String
            Get
                Return _sf_actionname
            End Get
            Set(ByVal value As String)
                _sf_actionname = value
            End Set
        End Property
        Public Property SF_Per() As String
            Get
                Return _sf_per
            End Get
            Set(ByVal value As String)
                _sf_per = value
            End Set
        End Property
        Public Property SF_PerName() As String
            Get
                Return _sf_pername
            End Get
            Set(ByVal value As String)
                _sf_pername = value
            End Set
        End Property
        Public Property SF_FileName() As String
            Get
                Return _sf_filename
            End Get
            Set(ByVal value As String)
                _sf_filename = value
            End Set
        End Property
        Public Property SF_FileType() As String
            Get
                Return _sf_filetype
            End Get
            Set(ByVal value As String)
                _sf_filetype = value
            End Set
        End Property
        Public Property SF_FilePath() As String
            Get
                Return _sf_filepath
            End Get
            Set(ByVal value As String)
                _sf_filepath = value
            End Set
        End Property
        ''' <summary>
        ''' 文件大小
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property SF_Length() As String
            Get
                Return _sf_length
            End Get
            Set(ByVal value As String)
                _sf_length = value
            End Set
        End Property
    End Class

End Namespace
