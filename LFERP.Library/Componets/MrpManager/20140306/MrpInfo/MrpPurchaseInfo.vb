Namespace LFERP.Library.MrpManager.MrpInfo
    Public Class MrpPurchaseInfo

        Private _MRP_ID As String
        Private _M_Code As String
        Private _MP_NeedQty As Decimal
        Private _MP_BatchQty As Decimal
        Private _MP_BatFixEconomy As Decimal
        Private _MP_OrderMax As Decimal
        Private _MP_OrderMin As Decimal
        Private _MP_SecInv As Decimal
        Private _MP_LowLimit As Decimal
        Private _MP_RetreatQty As Decimal
        Private _MP_InventoryQty As Decimal
        Private _MP_InTransitQty As Decimal
        Private _MP_Inspection As Decimal
        Private _MP_NoCollar As Decimal
        Private _MP_MRPQty As Decimal
        Private _MP_CreateUserID As String
        Private _MP_CreateDate As Date
        Private _MP_ModifyUserID As String
        Private _MP_ModifyDate As Date
        Private _AutoID As Decimal
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _Source As String
        Private _MP_RelatedQty As Decimal

        Public Sub New()
            _MRP_ID = Nothing
            _M_Code = Nothing
            _MP_NeedQty = 0
            _MP_BatchQty = 0
            _MP_BatFixEconomy = 0
            _MP_OrderMax = 0
            _MP_OrderMin = 0
            _MP_SecInv = 0
            _MP_LowLimit = 0
            _MP_RetreatQty = 0
            _MP_InventoryQty = 0
            _MP_InTransitQty = 0
            _MP_Inspection = 0
            _MP_NoCollar = 0
            _MP_MRPQty = 0
            _MP_CreateUserID = Nothing
            _MP_CreateDate = Nothing
            _MP_ModifyUserID = Nothing
            _MP_ModifyDate = Nothing
            _AutoID = 0
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _Source = Nothing
            _MP_relatedQty = 0
        End Sub
        Public Property MRP_ID() As String
            Get
                Return _MRP_ID
            End Get
            Set(ByVal value As String)
                _MRP_ID = value
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
        Public Property MP_NeedQty() As Decimal
            Get
                Return _MP_NeedQty
            End Get
            Set(ByVal value As Decimal)
                _MP_NeedQty = value
            End Set
        End Property
        Public Property MP_BatchQty() As Decimal
            Get
                Return _MP_BatchQty
            End Get
            Set(ByVal value As Decimal)
                _MP_BatchQty = value
            End Set
        End Property
        Public Property MP_BatFixEconomy() As Decimal
            Get
                Return _MP_BatFixEconomy
            End Get
            Set(ByVal value As Decimal)
                _MP_BatFixEconomy = value
            End Set
        End Property
        Public Property MP_OrderMax() As Decimal
            Get
                Return _MP_OrderMax
            End Get
            Set(ByVal value As Decimal)
                _MP_OrderMax = value
            End Set
        End Property
        Public Property MP_OrderMin() As Decimal
            Get
                Return _MP_OrderMin
            End Get
            Set(ByVal value As Decimal)
                _MP_OrderMin = value
            End Set
        End Property
        Public Property MP_SecInv() As Decimal
            Get
                Return _MP_SecInv
            End Get
            Set(ByVal value As Decimal)
                _MP_SecInv = value
            End Set
        End Property
        Public Property MP_LowLimit() As Decimal
            Get
                Return _MP_LowLimit
            End Get
            Set(ByVal value As Decimal)
                _MP_LowLimit = value
            End Set
        End Property
        Public Property MP_RetreatQty() As Decimal
            Get
                Return _MP_RetreatQty
            End Get
            Set(ByVal value As Decimal)
                _MP_RetreatQty = value
            End Set
        End Property
        Public Property MP_InventoryQty() As Decimal
            Get
                Return _MP_InventoryQty
            End Get
            Set(ByVal value As Decimal)
                _MP_InventoryQty = value
            End Set
        End Property
        Public Property MP_InTransitQty() As Decimal
            Get
                Return _MP_InTransitQty
            End Get
            Set(ByVal value As Decimal)
                _MP_InTransitQty = value
            End Set
        End Property
        Public Property MP_Inspection() As Decimal
            Get
                Return _MP_Inspection
            End Get
            Set(ByVal value As Decimal)
                _MP_Inspection = value
            End Set
        End Property
        Public Property MP_NoCollar() As Decimal
            Get
                Return _MP_NoCollar
            End Get
            Set(ByVal value As Decimal)
                _MP_NoCollar = value
            End Set
        End Property
        Public Property MP_MRPQty() As Decimal
            Get
                Return _MP_MRPQty
            End Get
            Set(ByVal value As Decimal)
                _MP_MRPQty = value
            End Set
        End Property
        Public Property MP_CreateUserID() As String
            Get
                Return _MP_CreateUserID
            End Get
            Set(ByVal value As String)
                _MP_CreateUserID = value
            End Set
        End Property
        Public Property MP_CreateDate() As Date
            Get
                Return _MP_CreateDate
            End Get
            Set(ByVal value As Date)
                _MP_CreateDate = value
            End Set
        End Property
        Public Property MP_ModifyUserID() As String
            Get
                Return _MP_ModifyUserID
            End Get
            Set(ByVal value As String)
                _MP_ModifyUserID = value
            End Set
        End Property
        Public Property MP_ModifyDate() As Date
            Get
                Return _MP_ModifyDate
            End Get
            Set(ByVal value As Date)
                _MP_ModifyDate = value
            End Set
        End Property
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
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
        Public Property MP_RelatedQty() As Decimal
            Get
                Return _MP_relatedQty
            End Get
            Set(ByVal value As Decimal)
                _MP_relatedQty = value
            End Set
        End Property
    End Class
End Namespace