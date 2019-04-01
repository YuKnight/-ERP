

Namespace LFERP.Library.ProductionFieldType

    Public Class ProductionFieldTypeInfo

        Private _PT_NO As String
        Private _PT_Type As String
        Private _PT_Detail As String
        Private _PT_DataValue As Integer

        Sub New()
            _PT_NO = Nothing
            _PT_Type = Nothing
            _PT_Detail = Nothing
            _PT_DataValue = 0
        End Sub

        Public Property PT_NO() As String
            Get
                Return _PT_NO
            End Get
            Set(ByVal value As String)
                _PT_NO = value
            End Set
        End Property

        Public Property PT_Type() As String
            Get
                Return _PT_Type
            End Get
            Set(ByVal value As String)
                _PT_Type = value
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
        Public Property PT_DataValue() As Integer
            Get
                Return _PT_DataValue
            End Get
            Set(ByVal value As Integer)
                _PT_DataValue = value
            End Set
        End Property
    End Class

End Namespace


