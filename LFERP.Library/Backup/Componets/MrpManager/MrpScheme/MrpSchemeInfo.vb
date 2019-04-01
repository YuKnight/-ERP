Namespace LFERP.Library.MrpManager.MrpScheme
    Public Class MrpSchemeInfo
        Private _AutoID As Double
        Private _CreateUserID As String
        Private _CreateUserName As String
        Private _CreateDate As Date
        Private _ModifyUserID As String
        Private _ModifyUserName As String
        Private _ModifyDate As Date

        Private _SchemeID As String
        Private _SchemeDesc As String
        Private _SysDefault As Boolean
        Private _CalculateRange As Integer
        Private _BitSalesOrder As Boolean
        Private _BitProductForecast As Boolean
        Private _BitSalesUnaudited As Boolean
        Private _BitProductUnaudited As Boolean

        Private _BitLossRate As Boolean
        Private _BitProductRate As Boolean
        Private _BitDemandQty As Boolean
        Private _BitTempQty As Boolean
        Private _BitSecurityStockQty As Boolean
        Private _BitStockQty As Boolean
        Private _BitPurchaseQty As Boolean
        Private _BitInWayQty As Boolean
        Private _BitSubStitateQty As Boolean
        Private _BitAssignQty As Boolean
        Private _ValidMonth As Integer
        Private _BitSubDetails As Boolean
        Private _BitSubRelation As Boolean
        Private _BitSalesMerger As Boolean
        Private _SalesMergerValue As Integer
        Private _BitForecastMerger As Boolean
        Private _ForecastMergerValue As Integer
        Private _BitDemandMerger As Boolean
        Private _BitPutInPlan As Boolean
        Private _PurchEmtryNumber As Integer
        Private _CarrentDateDays As Integer
        Private _ProduceStatus As Integer
        Private _PurchaseStatus As Integer
        Private _GroupPrinciple As Integer
        Private _OrderPrinciple As Integer
        Private _BitLowestBomCode As Boolean
        Private _ShowType As Integer
        Private _ComputeType As Integer

        Public Sub New()
            _AutoID = 0
            _CreateUserID = Nothing
            _CreateUserName = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyUserName = Nothing
            _ModifyDate = Nothing

            _SchemeID = Nothing
            _SchemeDesc = Nothing
            _SysDefault = Nothing
            _CalculateRange = Nothing
            _BitSalesOrder = Nothing
            _BitProductForecast = Nothing

            _BitSalesUnaudited = Nothing
            _BitProductUnaudited = Nothing

            _BitLossRate = Nothing
            _BitProductRate = Nothing
            _BitDemandQty = Nothing
            _BitTempQty = Nothing
            _BitSecurityStockQty = Nothing
            _BitStockQty = Nothing
            _BitPurchaseQty = Nothing
            _BitInWayQty = Nothing
            _BitSubStitateQty = Nothing
            _BitAssignQty = Nothing
            _ValidMonth = Nothing
            _BitSubDetails = Nothing
            _BitSubRelation = Nothing
            _BitSalesMerger = Nothing
            _SalesMergerValue = Nothing
            _BitForecastMerger = Nothing
            _ForecastMergerValue = Nothing
            _BitDemandMerger = Nothing
            _BitPutInPlan = Nothing
            _PurchEmtryNumber = Nothing
            _CarrentDateDays = Nothing
            _ProduceStatus = Nothing
            _PurchaseStatus = Nothing
            _GroupPrinciple = Nothing
            _OrderPrinciple = Nothing
            _BitLowestBomCode = Nothing
            _ShowType = Nothing
            _ComputeType = Nothing
        End Sub
        Public Property BitLowestBomCode() As Boolean
            Get
                Return _BitLowestBomCode
            End Get
            Set(ByVal value As Boolean)
                _BitLowestBomCode = value
            End Set
        End Property
        Public Property ShowType() As Integer
            Get
                Return _ShowType
            End Get
            Set(ByVal value As Integer)
                _ShowType = value
            End Set
        End Property
        Public Property ComputeType() As Integer
            Get
                Return _ComputeType
            End Get
            Set(ByVal value As Integer)
                _ComputeType = value
            End Set
        End Property
        Public Property SysDefault() As Boolean
            Get
                Return _SysDefault
            End Get
            Set(ByVal value As Boolean)
                _SysDefault = value
            End Set
        End Property
        Public Property BitLossRate() As Boolean
            Get
                Return _BitLossRate
            End Get
            Set(ByVal value As Boolean)
                _BitLossRate = value
            End Set
        End Property
        Public Property BitProductRate() As Boolean
            Get
                Return _BitProductRate
            End Get
            Set(ByVal value As Boolean)
                _BitProductRate = value
            End Set
        End Property
        Public Property BitDemandQty() As Boolean
            Get
                Return _BitDemandQty
            End Get
            Set(ByVal value As Boolean)
                _BitDemandQty = value
            End Set
        End Property
        Public Property BitTempQty() As Boolean
            Get
                Return _BitTempQty
            End Get
            Set(ByVal value As Boolean)
                _BitTempQty = value
            End Set
        End Property
        Public Property BitSecurityStockQty() As Boolean
            Get
                Return _BitSecurityStockQty
            End Get
            Set(ByVal value As Boolean)
                _BitSecurityStockQty = value
            End Set
        End Property
        Public Property BitStockQty() As Boolean
            Get
                Return _BitStockQty
            End Get
            Set(ByVal value As Boolean)
                _BitStockQty = value
            End Set
        End Property
        Public Property BitPurchaseQty() As Boolean
            Get
                Return _BitPurchaseQty
            End Get
            Set(ByVal value As Boolean)
                _BitPurchaseQty = value
            End Set
        End Property
        Public Property BitInWayQty() As Boolean
            Get
                Return _BitInWayQty
            End Get
            Set(ByVal value As Boolean)
                _BitInWayQty = value
            End Set
        End Property
        Public Property BitSubStitateQty() As Boolean
            Get
                Return _BitSubStitateQty
            End Get
            Set(ByVal value As Boolean)
                _BitSubStitateQty = value
            End Set
        End Property
        Public Property BitAssignQty() As Boolean
            Get
                Return _BitAssignQty
            End Get
            Set(ByVal value As Boolean)
                _BitAssignQty = value
            End Set
        End Property
        Public Property ValidMonth() As Integer
            Get
                Return _ValidMonth
            End Get
            Set(ByVal value As Integer)
                _ValidMonth = value
            End Set
        End Property
        Public Property BitSubDetails() As Boolean
            Get
                Return _BitSubDetails
            End Get
            Set(ByVal value As Boolean)
                _BitSubDetails = value
            End Set
        End Property
        Public Property BitSubRelation() As Boolean
            Get
                Return _BitSubRelation
            End Get
            Set(ByVal value As Boolean)
                _BitSubRelation = value
            End Set
        End Property
        Public Property BitSalesMerger() As Boolean
            Get
                Return _BitSalesMerger
            End Get
            Set(ByVal value As Boolean)
                _BitSalesMerger = value
            End Set
        End Property
        Public Property SalesMergerValue() As Integer
            Get
                Return _SalesMergerValue
            End Get
            Set(ByVal value As Integer)
                _SalesMergerValue = value
            End Set
        End Property
        Public Property BitForecastMerger() As Boolean
            Get
                Return _BitForecastMerger
            End Get
            Set(ByVal value As Boolean)
                _BitForecastMerger = value
            End Set
        End Property
        Public Property ForecastMergerValue() As Integer
            Get
                Return _ForecastMergerValue
            End Get
            Set(ByVal value As Integer)
                _ForecastMergerValue = value
            End Set
        End Property
        Public Property BitDemandMerger() As Boolean
            Get
                Return _BitDemandMerger
            End Get
            Set(ByVal value As Boolean)
                _BitDemandMerger = value
            End Set
        End Property
        Public Property BitPutInPlan() As Boolean
            Get
                Return _BitPutInPlan
            End Get
            Set(ByVal value As Boolean)
                _BitPutInPlan = value
            End Set
        End Property
        Public Property PurchEmtryNumber() As Integer
            Get
                Return _PurchEmtryNumber
            End Get
            Set(ByVal value As Integer)
                _PurchEmtryNumber = value
            End Set
        End Property
        Public Property CarrentDateDays() As Integer
            Get
                Return _CarrentDateDays
            End Get
            Set(ByVal value As Integer)
                _CarrentDateDays = value
            End Set
        End Property
        Public Property ProduceStatus() As Integer
            Get
                Return _ProduceStatus
            End Get
            Set(ByVal value As Integer)
                _ProduceStatus = value
            End Set
        End Property
        Public Property PurchaseStatus() As Integer
            Get
                Return _PurchaseStatus
            End Get
            Set(ByVal value As Integer)
                _PurchaseStatus = value
            End Set
        End Property
        Public Property GroupPrinciple() As Integer
            Get
                Return _GroupPrinciple
            End Get
            Set(ByVal value As Integer)
                _GroupPrinciple = value
            End Set
        End Property
        Public Property OrderPrinciple() As Integer
            Get
                Return _OrderPrinciple
            End Get
            Set(ByVal value As Integer)
                _OrderPrinciple = value
            End Set
        End Property

        Public Property BitSalesUnaudited() As Boolean
            Get
                Return _BitSalesUnaudited
            End Get
            Set(ByVal value As Boolean)
                _BitSalesUnaudited = value
            End Set
        End Property
        Public Property BitProductUnaudited() As Boolean
            Get
                Return _BitProductUnaudited
            End Get
            Set(ByVal value As Boolean)
                _BitProductUnaudited = value
            End Set
        End Property


        Public Property BitProductForecast() As Boolean
            Get
                Return _BitProductForecast
            End Get
            Set(ByVal value As Boolean)
                _BitProductForecast = value
            End Set
        End Property
        Public Property BitSalesOrder() As Boolean
            Get
                Return _BitSalesOrder
            End Get
            Set(ByVal value As Boolean)
                _BitSalesOrder = value
            End Set
        End Property
        Public Property CalculateRange() As Integer
            Get
                Return _CalculateRange
            End Get
            Set(ByVal value As Integer)
                _CalculateRange = value
            End Set
        End Property
        Public Property SchemeDesc() As String
            Get
                Return _SchemeDesc
            End Get
            Set(ByVal value As String)
                _SchemeDesc = value
            End Set
        End Property

        Public Property SchemeID() As String
            Get
                Return _SchemeID
            End Get
            Set(ByVal value As String)
                _SchemeID = value
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
        Public Property ModifyUserName() As String
            Get
                Return _ModifyUserName
            End Get
            Set(ByVal value As String)
                _ModifyUserName = value
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
        Public Property CreateDate() As Date
            Get
                Return _CreateDate
            End Get
            Set(ByVal value As Date)
                _CreateDate = value
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
        Public Property CreateUserID() As String
            Get
                Return _CreateUserID
            End Get
            Set(ByVal value As String)
                _CreateUserID = value
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