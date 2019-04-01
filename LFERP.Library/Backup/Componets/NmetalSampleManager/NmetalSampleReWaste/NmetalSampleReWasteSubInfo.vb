
Namespace LFERP.Library.NmetalSampleManager.NmetalSampleReWaste

    Public Class NmetalSampleReWasteSubInfo
        Private _AutoID As String
        Private _ReNO As String
        Private _Code_ID As String
        Private _Qty As Integer
        Private _WeightS As Decimal

        Private _InQty As Integer
        Private _InWeightS As Decimal

        Sub New()
            _AutoID = Nothing
            _ReNO = Nothing
            _Code_ID = Nothing
            _Qty = 0
            _WeightS = 0

            _InQty = 0
            _InWeightS = 0
        End Sub

        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property


        Public Property ReNO() As String
            Get
                Return _ReNO
            End Get
            Set(ByVal value As String)
                _ReNO = value
            End Set
        End Property

        Public Property Code_ID() As String
            Get
                Return _Code_ID
            End Get
            Set(ByVal value As String)
                _Code_ID = value
            End Set
        End Property

        Public Property Qty() As Integer
            Get
                Return _Qty
            End Get
            Set(ByVal value As Integer)
                _Qty = value
            End Set
        End Property

        Public Property WeightS() As Decimal
            Get
                Return _WeightS
            End Get
            Set(ByVal value As Decimal)
                _WeightS = value
            End Set
        End Property
        '----------------------

        Public Property InQty() As Integer
            Get
                Return _InQty
            End Get
            Set(ByVal value As Integer)
                _InQty = value
            End Set
        End Property

        Public Property InWeightS() As Decimal
            Get
                Return _InWeightS
            End Get
            Set(ByVal value As Decimal)
                _InWeightS = value
            End Set
        End Property

    End Class
End Namespace
