Namespace LFERP.Library.MrpManager.MrpInfo
    Public Class MrpPurchaseCalcRecordInfo

        Private _AutoID As Decimal
        Private _SN As String
        Private _MRP_ID As String
        Private _MRPType As Byte
        Private _Ware_ID As String
        Private _M_Code As String
        Private _NeedBeginDate As Date
        Private _NeedEndDate As Date
        Private _ForecastID As String
        Private _CalcType As Byte
        Private _NeedQty As Decimal
        Private _MRPQty As Decimal
        Private _InventoryQty As Decimal
        Private _InTransitQty As Decimal
        Private _Inspection As Decimal
        Private _NoCollar As Decimal
        Private _RetreatQty As Decimal
        Private _RelatedQty As Decimal
        Private _CreateUserID As String
        Private _CreateDate As Date
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _Source As String
        Private _CreateUserName As String
        Public Sub New()
            _AutoID = 0
            _SN = Nothing
            _MRP_ID = Nothing
            _MRPType = Nothing
            _Ware_ID = Nothing
            _M_Code = Nothing
            _NeedBeginDate = Nothing
            _NeedEndDate = Nothing
            _ForecastID = Nothing
            _CalcType = Nothing
            _NeedQty = 0
            _MRPQty = 0
            _InventoryQty = 0
            _InTransitQty = 0
            _Inspection = 0
            _NoCollar = 0
            _RetreatQty = 0
            _RelatedQty = 0
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _Source = Nothing
            _CreateUserName = Nothing
        End Sub
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property SN() As String
            Get
                Return _SN
            End Get
            Set(ByVal value As String)
                _SN = value
            End Set
        End Property
        Public Property MRP_ID() As String
            Get
                Return _MRP_ID
            End Get
            Set(ByVal value As String)
                _MRP_ID = value
            End Set
        End Property
        Public Property MRPType() As Byte
            Get
                Return _MRPType
            End Get
            Set(ByVal value As Byte)
                _MRPType = value
            End Set
        End Property
        Public Property Ware_ID() As String
            Get
                Return _Ware_ID
            End Get
            Set(ByVal value As String)
                _Ware_ID = value
            End Set
        End Property
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property
        Public Property NeedBeginDate() As Date
            Get
                Return _NeedBeginDate
            End Get
            Set(ByVal value As Date)
                _NeedBeginDate = value
            End Set
        End Property
        Public Property NeedEndDate() As Date
            Get
                Return _NeedEndDate
            End Get
            Set(ByVal value As Date)
                _NeedEndDate = value
            End Set
        End Property
        Public Property ForecastID() As String
            Get
                Return _ForecastID
            End Get
            Set(ByVal value As String)
                _ForecastID = value
            End Set
        End Property
        Public Property CalcType() As Byte
            Get
                Return _CalcType
            End Get
            Set(ByVal value As Byte)
                _CalcType = value
            End Set
        End Property
        Public Property NeedQty() As Decimal
            Get
                Return _NeedQty
            End Get
            Set(ByVal value As Decimal)
                _NeedQty = value
            End Set
        End Property
        Public Property MRPQty() As Decimal
            Get
                Return _MRPQty
            End Get
            Set(ByVal value As Decimal)
                _MRPQty = value
            End Set
        End Property
        Public Property InventoryQty() As Decimal
            Get
                Return _InventoryQty
            End Get
            Set(ByVal value As Decimal)
                _InventoryQty = value
            End Set
        End Property
        Public Property InTransitQty() As Decimal
            Get
                Return _InTransitQty
            End Get
            Set(ByVal value As Decimal)
                _InTransitQty = value
            End Set
        End Property
        Public Property Inspection() As Decimal
            Get
                Return _Inspection
            End Get
            Set(ByVal value As Decimal)
                _Inspection = value
            End Set
        End Property
        Public Property NoCollar() As Decimal
            Get
                Return _NoCollar
            End Get
            Set(ByVal value As Decimal)
                _NoCollar = value
            End Set
        End Property
        Public Property RetreatQty() As Decimal
            Get
                Return _RetreatQty
            End Get
            Set(ByVal value As Decimal)
                _RetreatQty = value
            End Set
        End Property
        Public Property RelatedQty() As Decimal
            Get
                Return _RelatedQty
            End Get
            Set(ByVal value As Decimal)
                _RelatedQty = value
            End Set
        End Property
        Public Property CreateUserID() As String
            Get
                Return _CreateUserID
            End Get
            Set(ByVal value As String)
                _CreateUserID = value
            End Set
        End Property
        Public Property CreateDate() As Date
            Get
                Return _CreateDate
            End Get
            Set(ByVal value As Date)
                _CreateDate = value
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
        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
            End Set
        End Property
        Public Property Source() As String
            Get
                Return _Source
            End Get
            Set(ByVal value As String)
                _Source = value
            End Set
        End Property

        Public Property CreateUserName() As String
            Get
                Return _CreateUserName
            End Get
            Set(ByVal value As String)
                _CreateUserName = value
            End Set
        End Property
    End Class
End Namespace