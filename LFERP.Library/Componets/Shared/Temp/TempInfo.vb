Namespace LFERP.Library.Shared

    Public Class TempInfo

        Private _str1 As String
        Private _str2 As String
        Private _str3 As String

        Sub New()
            _str1 = ""
            _str2 = ""
            _str3 = ""

        End Sub

        Public Property Str1() As String
            Get
                Return _str1
            End Get
            Set(ByVal value As String)
                _str1 = value
            End Set
        End Property
        Public Property Str2() As String
            Get
                Return _str2
            End Get
            Set(ByVal value As String)
                _str2 = value
            End Set
        End Property

        Public Property Str3() As String
            Get
                Return _str3
            End Get
            Set(ByVal value As String)
                _str3 = value
            End Set
        End Property
    End Class


End Namespace
