Namespace LFERP.Library.Positive
    Public Class PositiveQuotationEntryInfo

        Private _AutoID As Decimal
        Private _M_Name As String
        Private _M_Gauge As String
        Private _BillNo As String
        Private _EffectiveDate As DateTime
        Private _ExpiryDate As DateTime
        Private _PartNo As String
        Private _UnitID As String 
        Private _Color As String
        Private _QtyRangeFrom As Decimal
        Private _QtyRangeTo As Decimal
        Private _Price As Decimal
        Private _CurrencyID As String
        Private _Discount As Decimal
        Private _TaxType As String
        Private _TaxRate As Decimal
        Private _Remarks As String
        Public Sub New()
            _AutoID = 0
            _BillNo = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _EffectiveDate = Nothing
            _ExpiryDate = Nothing
            _PartNo = Nothing
            _UnitID = Nothing 
            _Color = Nothing
            _QtyRangeFrom = 0
            _QtyRangeTo = 0
            _Price = 0
            _CurrencyID = Nothing
            _Discount = 0
            _TaxType = Nothing
            _TaxRate = 0
            _Remarks = Nothing

        End Sub
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property BillNo() As String
            Get
                Return _BillNo
            End Get
            Set(ByVal value As String)
                _BillNo = value
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
        Public Property EffectiveDate() As DateTime
            Get
                Return _EffectiveDate
            End Get
            Set(ByVal value As DateTime)
                _EffectiveDate = value
            End Set
        End Property
        Public Property ExpiryDate() As DateTime
            Get
                Return _ExpiryDate
            End Get
            Set(ByVal value As DateTime)
                _ExpiryDate = value
            End Set
        End Property
        Public Property PartNo() As String
            Get
                Return _PartNo
            End Get
            Set(ByVal value As String)
                _PartNo = value
            End Set
        End Property
        Public Property UnitID() As String
            Get
                Return _UnitID
            End Get
            Set(ByVal value As String)
                _UnitID = value
            End Set
        End Property 
        Public Property Color() As String
            Get
                Return _Color
            End Get
            Set(ByVal value As String)
                _Color = value
            End Set
        End Property
        Public Property QtyRangeFrom() As Decimal
            Get
                Return _QtyRangeFrom
            End Get
            Set(ByVal value As Decimal)
                _QtyRangeFrom = value
            End Set
        End Property
        Public Property QtyRangeTo() As Decimal
            Get
                Return _QtyRangeTo
            End Get
            Set(ByVal value As Decimal)
                _QtyRangeTo = value
            End Set
        End Property
        Public Property Price() As Decimal
            Get
                Return _Price
            End Get
            Set(ByVal value As Decimal)
                _Price = value
            End Set
        End Property
        Public Property CurrencyID() As String
            Get
                Return _CurrencyID
            End Get
            Set(ByVal value As String)
                _CurrencyID = value
            End Set
        End Property
        Public Property Discount() As Decimal
            Get
                Return _Discount
            End Get
            Set(ByVal value As Decimal)
                _Discount = value
            End Set
        End Property
        Public Property TaxType() As String
            Get
                Return _TaxType
            End Get
            Set(ByVal value As String)
                _TaxType = value
            End Set
        End Property
        Public Property TaxRate() As Decimal
            Get
                Return _TaxRate
            End Get
            Set(ByVal value As Decimal)
                _TaxRate = value
            End Set
        End Property
        Public Property Remarks() As String
            Get
                Return _Remarks
            End Get
            Set(ByVal value As String)
                _Remarks = value
            End Set
        End Property

    End Class
End Namespace