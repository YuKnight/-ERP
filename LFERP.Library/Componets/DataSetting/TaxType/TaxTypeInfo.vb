Namespace LFERP.DataSetting

    Public Class TaxTypeInfo

        Private _AutoID As Decimal
        Private _TaxTypeID As String
        Private _TaxTypeName As String
        Public Sub New()
            _AutoID = 0
            _TaxTypeID = Nothing
            _TaxTypeName = Nothing

        End Sub
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property TaxTypeID() As String
            Get
                Return _TaxTypeID
            End Get
            Set(ByVal value As String)
                _TaxTypeID = value
            End Set
        End Property
        Public Property TaxTypeName() As String
            Get
                Return _TaxTypeName
            End Get
            Set(ByVal value As String)
                _TaxTypeName = value
            End Set
        End Property

    End Class

End Namespace