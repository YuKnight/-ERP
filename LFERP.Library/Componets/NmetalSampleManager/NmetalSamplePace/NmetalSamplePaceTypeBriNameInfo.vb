Namespace LFERP.Library.NmetalSampleManager.NmetalSamplePaceTypeBriName
    Public Class NmetalSamplePaceTypeBriNameInfo
        Private _DepID As String
        Private _SE_Type As String

        Private _DepName As String
        Private _SE_TypeName As String


        '2014-07-19     Mark
        Private _PE_User As String
        Private _PE_Name As String
        Private _PE_PSW As String

        Private _AutoID As String

        Public Sub New()
            _DepID = Nothing
            _SE_Type = Nothing
            _DepName = Nothing
            _SE_TypeName = Nothing

            _PE_User = Nothing
            _PE_Name = Nothing
            _PE_PSW = Nothing

            _AutoID = Nothing
        End Sub
        Public Property DepID() As String
            Get
                Return _DepID
            End Get
            Set(ByVal value As String)
                _DepID = value
            End Set
        End Property

        Public Property SE_Type() As String
            Get
                Return _SE_Type
            End Get
            Set(ByVal value As String)
                _SE_Type = value
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

        Public Property SE_TypeName() As String
            Get
                Return _SE_TypeName
            End Get
            Set(ByVal value As String)
                _SE_TypeName = value
            End Set
        End Property


        Public Property PE_User() As String
            Get
                Return _PE_User
            End Get
            Set(ByVal value As String)
                _PE_User = value
            End Set
        End Property

        Public Property PE_Name() As String
            Get
                Return _PE_Name
            End Get
            Set(ByVal value As String)
                _PE_Name = value
            End Set
        End Property

        Public Property PE_PSW() As String
            Get
                Return _PE_PSW
            End Get
            Set(ByVal value As String)
                _PE_PSW = value
            End Set
        End Property

        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property

    End Class
End Namespace