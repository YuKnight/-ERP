Namespace LFERP.SystemManager.OperationLog
    Public Class OperationLogInfo

        Private _AutoID As Decimal
        Private _ComputerName As String
        Private _DomainUser As String
        Private _MAC As String
        Private _UserID As String
        Private _FormName As String
        Private _OperationType As String
        Private _BeginTime As DateTime
        Private _EndTime As DateTime
        Private _OperationNotes As String
        Private _UserName As String
        Private _StaySpan As TimeSpan

        Public Sub New()
            _AutoID = 0
            _ComputerName = Nothing
            _DomainUser = Nothing
            _MAC = Nothing
            _UserID = Nothing
            _FormName = Nothing
            _OperationType = Nothing
            _BeginTime = Nothing
            _EndTime = Nothing
            _OperationNotes = Nothing
            _UserName = Nothing
            _StaySpan = TimeSpan.Zero
        End Sub

        Public Property StaySpan() As TimeSpan
            Get
                Return _StaySpan
            End Get
            Set(ByVal value As TimeSpan)
                _StaySpan = value
            End Set
        End Property

        Public Property UserName() As String
            Get
                Return _UserName
            End Get
            Set(ByVal value As String)
                _UserName = value
            End Set
        End Property

        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property ComputerName() As String
            Get
                Return _ComputerName
            End Get
            Set(ByVal value As String)
                _ComputerName = value
            End Set
        End Property
        Public Property DomainUser() As String
            Get
                Return _DomainUser
            End Get
            Set(ByVal value As String)
                _DomainUser = value
            End Set
        End Property
        Public Property MAC() As String
            Get
                Return _MAC
            End Get
            Set(ByVal value As String)
                _MAC = value
            End Set
        End Property
        Public Property UserID() As String
            Get
                Return _UserID
            End Get
            Set(ByVal value As String)
                _UserID = value
            End Set
        End Property
        Public Property FormName() As String
            Get
                Return _FormName
            End Get
            Set(ByVal value As String)
                _FormName = value
            End Set
        End Property
        Public Property OperationType() As String
            Get
                Return _OperationType
            End Get
            Set(ByVal value As String)
                _OperationType = value
            End Set
        End Property
        Public Property BeginTime() As DateTime
            Get
                Return _BeginTime
            End Get
            Set(ByVal value As DateTime)
                _BeginTime = value
            End Set
        End Property
        Public Property EndTime() As DateTime
            Get
                Return _EndTime
            End Get
            Set(ByVal value As DateTime)
                _EndTime = value
            End Set
        End Property
        Public Property OperationNotes() As String
            Get
                Return _OperationNotes
            End Get
            Set(ByVal value As String)
                _OperationNotes = value
            End Set
        End Property

    End Class
End Namespace