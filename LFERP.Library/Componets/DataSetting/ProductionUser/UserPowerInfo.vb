

Namespace LFERP.DataSetting


    Public Class UserPowerInfo
        Private _UserID As String
        Private _UserName As String
        Private _UserRank As String
        Private _DepID As String

        Private _DepName As String
        Private _UserType As String

        Sub New()
            _UserID = Nothing
            _UserName = Nothing
            _UserRank = Nothing
            _DepID = Nothing
            _UserType = Nothing
        End Sub

        Public Property UserID() As String
            Get
                Return _UserID
            End Get
            Set(ByVal value As String)
                _UserID = value
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
        Public Property UserRank() As String
            Get
                Return _UserRank
            End Get
            Set(ByVal value As String)
                _UserRank = value
            End Set
        End Property
        Public Property DepID() As String
            Get
                Return _DepID
            End Get
            Set(ByVal value As String)
                _DepID = value
            End Set
        End Property
        Public Property DepName() As String
            Get
                Return _DepName
            End Get
            Set(ByVal value As String)
                _DepName = value
            End Set
        End Property
        Public Property UserType() As String
            Get
                Return _UserType
            End Get
            Set(ByVal value As String)
                _UserType = value
            End Set
        End Property
    End Class

End Namespace

