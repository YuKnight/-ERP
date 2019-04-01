Namespace LFERP.Library.Positive
    Public Class PositiveDeliverTypeInfo
#Region "緩存參數"
        Private _AutoID As String
        Private _D_TypeID As String
        Private _D_TypeName As String
#End Region

#Region "構造函數"
        Public Sub New()
            _AutoID = Nothing
            _D_TypeID = Nothing
            _D_TypeName = Nothing
        End Sub
#End Region

#Region "屬性"

        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property

        Public Property D_TypeID() As String
            Get
                Return _D_TypeID
            End Get
            Set(ByVal value As String)
                _D_TypeID = value
            End Set
        End Property

        Public Property D_TypeName() As String
            Get
                Return _D_TypeName
            End Get
            Set(ByVal value As String)
                _D_TypeName = value
            End Set
        End Property

#End Region
    End Class
End Namespace
