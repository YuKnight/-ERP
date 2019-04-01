Namespace LFERP.Library.Outward.OutwardProjectType

    Public Class OutwardProjectTypeInfo

        Private _AutoID As Integer
        Private _PT_NO As String
        Private _PT_Name As String
        Private _PT_Detail As String

        Sub New()

            _AutoID = 0
            _PT_NO = Nothing
            _PT_Name = Nothing
            _PT_Detail = Nothing

        End Sub
        Public Property AutoID() As Integer
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Integer)
                _AutoID = value
            End Set
        End Property
        Public Property PT_NO() As String
            Get
                Return _PT_NO
            End Get
            Set(ByVal value As String)
                _PT_NO = value
            End Set
        End Property
        Public Property PT_Name() As String
            Get
                Return _PT_Name
            End Get
            Set(ByVal value As String)
                _PT_Name = value
            End Set
        End Property
        Public Property PT_Detail() As String
            Get
                Return _PT_Detail
            End Get
            Set(ByVal value As String)
                _PT_Detail = value
            End Set
        End Property

    End Class

End Namespace

