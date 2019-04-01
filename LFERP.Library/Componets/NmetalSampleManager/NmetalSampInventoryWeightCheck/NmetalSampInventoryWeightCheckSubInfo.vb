Namespace LFERP.Library.NmetalSampleManager.NmetalSampInventoryWeightCheck

    Public Class NmetalSampInventoryWeightCheckSubInfo

        Private _AutoID As String
        Private _CH_NO As String
        Private _Code_ID As String
        Private _SO_SampleID As String
        Private _CH_QQty As Integer

        Private _CH_QWeight As Decimal
        Private _CH_Qty As Integer
        Private _CH_Weight As Decimal
        Private _ErrorRate As Decimal
        Private _Remark As String

        Private _StatusType As String
        Private _D_ID As String
        Private _StatusTypeName As String
        Private _D_Name As String



        Public Sub New()

            _AutoID = Nothing
            _CH_NO = Nothing
            _Code_ID = Nothing
            _SO_SampleID = Nothing
            _CH_QQty = Nothing

            _CH_QWeight = Nothing
            _CH_Qty = Nothing
            _CH_Weight = Nothing
            _ErrorRate = Nothing
            _Remark = Nothing

            _StatusType = Nothing
            _D_ID = Nothing
            _StatusTypeName = Nothing
            _D_Name = Nothing

        End Sub

        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property
        Public Property CH_NO() As String
            Get
                Return _CH_NO
            End Get
            Set(ByVal value As String)
                _CH_NO = value
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
        Public Property SO_SampleID() As String
            Get
                Return _SO_SampleID
            End Get
            Set(ByVal value As String)
                _SO_SampleID = value
            End Set
        End Property
        Public Property CH_QQty() As Integer
            Get
                Return _CH_QQty
            End Get
            Set(ByVal value As Integer)
                _CH_QQty = value
            End Set
        End Property


        Public Property CH_QWeight() As Decimal
            Get
                Return _CH_QWeight
            End Get
            Set(ByVal value As Decimal)
                _CH_QWeight = value
            End Set
        End Property
        Public Property CH_Qty() As Integer
            Get
                Return _CH_Qty
            End Get
            Set(ByVal value As Integer)
                _CH_Qty = value
            End Set
        End Property
        Public Property CH_Weight() As Decimal
            Get
                Return _CH_Weight
            End Get
            Set(ByVal value As Decimal)
                _CH_Weight = value
            End Set
        End Property
        Public Property ErrorRate() As Decimal
            Get
                Return _ErrorRate
            End Get
            Set(ByVal value As Decimal)
                _ErrorRate = value
            End Set
        End Property
        Public Property Remark() As String
            Get
                Return _Remark
            End Get
            Set(ByVal value As String)
                _Remark = value
            End Set
        End Property

        Public Property StatusType() As String
            Get
                Return _StatusType
            End Get
            Set(ByVal value As String)
                _StatusType = value
            End Set
        End Property

        Public Property D_ID() As String
            Get
                Return _D_ID
            End Get
            Set(ByVal value As String)
                _D_ID = value
            End Set
        End Property

        Public Property StatusTypeName() As String
            Get
                Return _StatusTypeName
            End Get
            Set(ByVal value As String)
                _StatusTypeName = value
            End Set
        End Property

        Public Property D_Name() As String
            Get
                Return _D_Name
            End Get
            Set(ByVal value As String)
                _D_Name = value
            End Set
        End Property


    End Class
End Namespace