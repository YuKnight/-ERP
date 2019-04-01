Namespace LFERP.Library.MrpManager.Mrp_Info

    Public Class Mrp_InfoMainInfo
        Private _MRP_ID As String
        Private _PM_M_Code As String
        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String

        Private _FixLeadTime As Integer
        Private _SafetyTime As Integer
        Private _SafetyStock As Decimal
        Private _FixedQty As Decimal
        Private _MinOrderQty As Decimal
        Private _MaxOrderQty As Decimal
        Private _SoureType As Decimal
        Private _SoureTypeName As String
        Private _M_LowestBomCode As Integer
        Private _ReOrderPoint As Integer ' --再訂貨點
        Private _OrderInterval As Integer '--訂購間隔期
        Private _IncreasBatch As Integer '--批量遞增
        Private _OrderStrategy As Integer
        Private _OrderStrategyName As String
        Private _DemandType As String

        Private _CreateUserID As String
        Private _CreateDate As Date
        Private _ModifyUserID As String
        Private _ModifyDate As Date
        Private _CreateUserName As String
        Private _ModifyUserName As String
        Private _AutoID As Decimal


        Public Sub New()
            _MRP_ID = Nothing
            _PM_M_Code = Nothing
            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing

            _FixLeadTime = Nothing
            _SafetyTime = Nothing
            _SafetyStock = Nothing
            _FixedQty = Nothing
            _MinOrderQty = Nothing
            _MaxOrderQty = Nothing
            _SoureTypeName = Nothing
            _SoureType = Nothing
            _M_LowestBomCode = Nothing
            _ReOrderPoint = Nothing ' --再訂貨點
            _OrderInterval = Nothing '--訂購間隔期
            _IncreasBatch = Nothing '--批量遞增
            _OrderStrategy = Nothing
            _OrderStrategyName = Nothing
            _DemandType = Nothing

            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _CreateUserName = Nothing
            _ModifyUserName = Nothing
            _AutoID = Nothing
        End Sub
        Public Property ReOrderPoint() As Integer
            Get
                Return _ReOrderPoint
            End Get
            Set(ByVal value As Integer)
                _ReOrderPoint = value
            End Set
        End Property

        Public Property OrderInterval() As Integer
            Get
                Return _OrderInterval
            End Get
            Set(ByVal value As Integer)
                _OrderInterval = value
            End Set
        End Property

        Public Property IncreasBatch() As Integer
            Get
                Return _IncreasBatch
            End Get
            Set(ByVal value As Integer)
                _IncreasBatch = value
            End Set
        End Property

        Public Property OrderStrategyName() As String
            Get
                Return _OrderStrategyName
            End Get
            Set(ByVal value As String)
                _OrderStrategyName = value
            End Set
        End Property

        Public Property OrderStrategy() As Integer
            Get
                Return _OrderStrategy
            End Get
            Set(ByVal value As Integer)
                _OrderStrategy = value
            End Set
        End Property

        Public Property SoureTypeName() As String
            Get
                Return _SoureTypeName
            End Get
            Set(ByVal value As String)
                _SoureTypeName = value
            End Set
        End Property

        Public Property DemandType() As String
            Get
                Return _DemandType
            End Get
            Set(ByVal value As String)
                _DemandType = value
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
        Public Property M_LowestBomCode() As Integer
            Get
                Return _M_LowestBomCode
            End Get
            Set(ByVal value As Integer)
                _M_LowestBomCode = value
            End Set
        End Property

        Public Property SoureType() As String
            Get
                Return _SoureType
            End Get
            Set(ByVal value As String)
                _SoureType = value
            End Set
        End Property

        Public Property MaxOrderQty() As Decimal
            Get
                Return _MaxOrderQty
            End Get
            Set(ByVal value As Decimal)
                _MaxOrderQty = value
            End Set
        End Property
        Public Property MinOrderQty() As Decimal
            Get
                Return _MinOrderQty
            End Get
            Set(ByVal value As Decimal)
                _MinOrderQty = value
            End Set
        End Property

        Public Property FixedQty() As Decimal
            Get
                Return _FixedQty
            End Get
            Set(ByVal value As Decimal)
                _FixedQty = value
            End Set
        End Property

        Public Property SafetyStock() As Decimal
            Get
                Return _SafetyStock
            End Get
            Set(ByVal value As Decimal)
                _SafetyStock = value
            End Set
        End Property

        Public Property SafetyTime() As Integer
            Get
                Return _SafetyTime
            End Get
            Set(ByVal value As Integer)
                _SafetyTime = value
            End Set
        End Property

        Public Property FixLeadTime() As Integer
            Get
                Return _FixLeadTime
            End Get
            Set(ByVal value As Integer)
                _FixLeadTime = value
            End Set
        End Property


        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
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

        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property ModifyUserName() As String
            Get
                Return _ModifyUserName
            End Get
            Set(ByVal value As String)
                _ModifyUserName = value
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
        Public Property ModifyUserID() As String
            Get
                Return _ModifyUserID
            End Get
            Set(ByVal value As String)
                _ModifyUserID = value
            End Set
        End Property

        Public Property ModifyDate() As Date
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As Date)
                _ModifyDate = value
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

        Public Property CreateUserID() As String
            Get
                Return _CreateUserID
            End Get
            Set(ByVal value As String)
                _CreateUserID = value
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


    End Class
End Namespace