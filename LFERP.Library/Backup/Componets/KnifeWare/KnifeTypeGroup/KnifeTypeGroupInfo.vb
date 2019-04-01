Namespace LFERP.Library.KnifeWare
    Public Class KnifeTypeGroupInfo
        Private _AutoID As String
        Private _KnifeType As String
        Private _KnifePID As String
        Private _KnifeID As String

        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String

        Private _KnifePIDName As String
        Private _Type3ID As String
        Private _KnifeIDName As String


        Sub New()
            _AutoID = Nothing
            _KnifeType = Nothing
            _KnifePID = 0
            _KnifeID = Nothing

            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing

            _KnifePIDName = Nothing
            _Type3ID = Nothing
            _KnifeIDName = Nothing
        End Sub

        Public Property KnifeIDName() As String
            Get
                Return _KnifeIDName
            End Get
            Set(ByVal value As String)
                _KnifeIDName = value
            End Set
        End Property

        Public Property Type3ID() As String
            Get
                Return _Type3ID
            End Get
            Set(ByVal value As String)
                _Type3ID = value
            End Set
        End Property

        Public Property KnifePIDName() As String
            Get
                Return _KnifePIDName
            End Get
            Set(ByVal value As String)
                _KnifePIDName = value
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


        Public Property KnifeType() As String
            Get
                Return _KnifeType
            End Get
            Set(ByVal value As String)
                _KnifeType = value
            End Set
        End Property

        Public Property KnifePID() As String
            Get
                Return _KnifePID
            End Get
            Set(ByVal value As String)
                _KnifePID = value
            End Set
        End Property

        Public Property KnifeID() As String
            Get
                Return _KnifeID
            End Get
            Set(ByVal value As String)
                _KnifeID = value
            End Set
        End Property

        '--------------------------
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property

        Public Property M_Name() As String
            Get
                Return _M_Name
            End Get
            Set(ByVal value As String)
                _M_Name = value
            End Set
        End Property

        Public Property M_Gauge() As String
            Get
                Return _M_Gauge
            End Get
            Set(ByVal value As String)
                _M_Gauge = value
            End Set
        End Property



    End Class
End Namespace