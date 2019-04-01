Namespace LFERP.Library.Purchase.purselect
    Public Class PurSelectInfo
        Private _PurModule As String
        Private _strWhere As String

        Public Sub New()
            _PurModule = ""
            _strWhere = ""
        End Sub
        Public Property PurModule() As String
            Get
                Return _PurModule
            End Get
            Set(ByVal value As String)
                _PurModule = value
            End Set
        End Property
    
        Public Property strWhere() As String
            Get
                Return _strWhere
            End Get
            Set(ByVal value As String)
                _strWhere = value
            End Set
        End Property
    End Class
End Namespace

