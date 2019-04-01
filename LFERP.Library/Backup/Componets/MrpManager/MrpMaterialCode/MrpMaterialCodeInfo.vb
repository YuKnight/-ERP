Namespace LFERP.Library.MrpManager.MrpMaterialCode
    Public Class MrpMaterialCodeInfo

        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _MC_BatchQty As Double
        Private _MC_BatFixEconomy As Double
        Private _MC_OrderInterVal As Int64
        Private _MC_OrderMan As String
        Private _MC_QtyMax As Double
        Private _MC_QtyMin As Double
        Private _MC_LowLimit As Double
        Private _MC_SecInv As Double
        Private _MC_Source As String
        Private _MC_SourceID As String
        Private _MC_MRPCon As Boolean
        Private _MC_WH_ID As String
        Private _MC_WH_Name As String
        Private _CheckUserID As String
        Private _CheckBit As Boolean
        Private _CheckRemark As String
        Private _CreateUserID As String
        Private _CreateDate As DateTime
        Private _ModifyUserID As String
        Private _ModifyDate As DateTime
        Private _MC_Remark As String
        Private _MC_OrderRemark As String
        Private _MC_WareHouseRemark As String
        Private _AutoID As Double
        Private _IsEnabled As String
        Private _CheckDate As DateTime
        Private _M_Supplier As String
        Private _M_SupplierName As String

        Public Sub New()
            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _M_Supplier = Nothing
            _MC_BatchQty = 0
            _MC_BatFixEconomy = 0
            _MC_OrderInterVal = 0
            _MC_OrderMan = Nothing
            _MC_QtyMax = 0
            _MC_QtyMin = 0
            _MC_LowLimit = 0
            _MC_SecInv = 0
            _MC_Source = Nothing
            _MC_SourceID = Nothing
            _MC_MRPCon = False
            _MC_WH_ID = Nothing
            _MC_WH_Name = Nothing
            _CheckUserID = Nothing
            _CheckBit = False
            _CheckRemark = Nothing
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _MC_Remark = Nothing
            _MC_OrderRemark = Nothing
            _MC_WareHouseRemark = Nothing
            _AutoID = 0
            _IsEnabled = Nothing
            _CheckDate = Nothing
            _M_SupplierName = Nothing
        End Sub
        Public Property M_SupplierName() As String
            Get
                Return _M_SupplierName
            End Get
            Set(ByVal value As String)
                _M_SupplierName = value
            End Set
        End Property
        Public Property M_Supplier() As String
            Get
                Return _M_Supplier
            End Get
            Set(ByVal value As String)
                _M_Supplier = value
            End Set
        End Property
        Public Property CheckDate() As DateTime
            Get
                Return _CheckDate
            End Get
            Set(ByVal value As DateTime)
                _CheckDate = value
            End Set
        End Property

        Public Property MC_SourceID() As String
            Get
                Return _MC_SourceID
            End Get
            Set(ByVal value As String)
                _MC_SourceID = value
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
        Public Property MC_BatchQty() As Double
            Get
                Return _MC_BatchQty
            End Get
            Set(ByVal value As Double)
                _MC_BatchQty = value
            End Set
        End Property
        Public Property MC_BatFixEconomy() As Double
            Get
                Return _MC_BatFixEconomy
            End Get
            Set(ByVal value As Double)
                _MC_BatFixEconomy = value
            End Set
        End Property
        Public Property MC_OrderInterVal() As Int64
            Get
                Return _MC_OrderInterVal
            End Get
            Set(ByVal value As Int64)
                _MC_OrderInterVal = value
            End Set
        End Property
        Public Property MC_OrderMan() As String
            Get
                Return _MC_OrderMan
            End Get
            Set(ByVal value As String)
                _MC_OrderMan = value
            End Set
        End Property
        Public Property MC_QtyMax() As Double
            Get
                Return _MC_QtyMax
            End Get
            Set(ByVal value As Double)
                _MC_QtyMax = value
            End Set
        End Property
        Public Property MC_QtyMin() As Double
            Get
                Return _MC_QtyMin
            End Get
            Set(ByVal value As Double)
                _MC_QtyMin = value
            End Set
        End Property
        Public Property MC_LowLimit() As Double
            Get
                Return _MC_LowLimit
            End Get
            Set(ByVal value As Double)
                _MC_LowLimit = value
            End Set
        End Property
        Public Property MC_SecInv() As Double
            Get
                Return _MC_SecInv
            End Get
            Set(ByVal value As Double)
                _MC_SecInv = value
            End Set
        End Property
        Public Property MC_Source() As String
            Get
                Return _MC_Source
            End Get
            Set(ByVal value As String)
                _MC_Source = value
            End Set
        End Property
        Public Property MC_MRPCon() As Boolean
            Get
                Return _MC_MRPCon
            End Get
            Set(ByVal value As Boolean)
                _MC_MRPCon = value
            End Set
        End Property
        Public Property MC_WH_ID() As String
            Get
                Return _MC_WH_ID
            End Get
            Set(ByVal value As String)
                _MC_WH_ID = value
            End Set
        End Property
        Public Property MC_WH_Name() As String
            Get
                Return _MC_WH_Name
            End Get
            Set(ByVal value As String)
                _MC_WH_Name = value
            End Set
        End Property
        Public Property CheckUserID() As String
            Get
                Return _CheckUserID
            End Get
            Set(ByVal value As String)
                _CheckUserID = value
            End Set
        End Property
        Public Property CheckBit() As Boolean
            Get
                Return _CheckBit
            End Get
            Set(ByVal value As Boolean)
                _CheckBit = value
            End Set
        End Property
        Public Property CheckRemark() As String
            Get
                Return _CheckRemark
            End Get
            Set(ByVal value As String)
                _CheckRemark = value
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
        Public Property CreateDate() As DateTime
            Get
                Return _CreateDate
            End Get
            Set(ByVal value As DateTime)
                _CreateDate = value
            End Set
        End Property
        Public Property MC_Remark() As String
            Get
                Return _MC_Remark
            End Get
            Set(ByVal value As String)
                _MC_Remark = value
            End Set
        End Property
        Public Property ModifyDate() As DateTime
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As DateTime)
                _ModifyDate = value
            End Set
        End Property
        Public Property ModifyUserID() As String
            Get
                Return _ModifyUserID
            End Get
            Set(ByVal value As String)
                _ModifyUserID = value
            End Set
        End Property
        Public Property MC_OrderRemark() As String
            Get
                Return _MC_OrderRemark
            End Get
            Set(ByVal value As String)
                _MC_OrderRemark = value
            End Set
        End Property
        Public Property MC_WareHouseRemark() As String
            Get
                Return _MC_WareHouseRemark
            End Get
            Set(ByVal value As String)
                _MC_WareHouseRemark = value
            End Set
        End Property
        Public Property AutoID() As Double
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Double)
                _AutoID = value
            End Set
        End Property
        Public Property IsEnabled() As String
            Get
                Return _IsEnabled
            End Get
            Set(ByVal value As String)
                _IsEnabled = value
            End Set
        End Property
    End Class
End Namespace
