Namespace LFERP.Library.MrpManager.Mrp_Info
    Public Class Mrp_InfoSubInfo
        Private _MRP_ID As String
        Private _PM_M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String

        Private _YearCount As Integer
        Private _WeekCount As Integer
        Private _Week As Integer
        Private _WeekStratDate As Date
        Private _WeekEndDate As Date

        Private _MrpDate As Date
        Private _DemandQty As Decimal
        Private _DependentQty As Decimal
        Private _GrossDemandQty As Decimal

        Private _StockQty As Decimal
        Private _AssignQty As Decimal
        Private _PurchaseQty As Decimal
        Private _InWayQty As Decimal
        Private _TempQty As Decimal
        Private _PlanProduceQty As Decimal
        Private _NetDemandQty As Decimal
        Private _PlanReceiveQty As Decimal
        Private _PlanIssueQty As Decimal
        Private _ForecastAvailableQty As Decimal

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
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing

            _YearCount = Nothing
            _WeekCount = Nothing
            _Week = Nothing
            _WeekStratDate = Nothing
            _WeekEndDate = Nothing
            _MrpDate = Nothing
            _DemandQty = Nothing
            _DependentQty = Nothing
            _GrossDemandQty = Nothing
            _StockQty = Nothing
            _AssignQty = Nothing
            _PurchaseQty = Nothing
            _InWayQty = Nothing
            _TempQty = Nothing
            _PlanProduceQty = Nothing
            _NetDemandQty = Nothing
            _PlanReceiveQty = Nothing
            _PlanIssueQty = Nothing
            _ForecastAvailableQty = Nothing

            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _CreateUserName = Nothing
            _ModifyUserName = Nothing
            _AutoID = Nothing
        End Sub
        Public Property Week() As Integer
            Get
                Return _Week
            End Get
            Set(ByVal value As Integer)
                _Week = value
            End Set
        End Property
        Public Property YearCount() As Integer
            Get
                Return _YearCount
            End Get
            Set(ByVal value As Integer)
                _YearCount = value
            End Set
        End Property
        Public Property WeekCount() As Integer
            Get
                Return _WeekCount
            End Get
            Set(ByVal value As Integer)
                _WeekCount = value
            End Set
        End Property
        Public Property WeekStratDate() As Date
            Get
                Return _WeekStratDate
            End Get
            Set(ByVal value As Date)
                _WeekStratDate = value
            End Set
        End Property
        Public Property WeekEndDate() As Date
            Get
                Return _WeekEndDate
            End Get
            Set(ByVal value As Date)
                _WeekEndDate = value
            End Set
        End Property


        Public Property DependentQty() As Decimal
            Get
                Return _DependentQty
            End Get
            Set(ByVal value As Decimal)
                _DependentQty = value
            End Set
        End Property

        Public Property GrossDemandQty() As Decimal
            Get
                Return _GrossDemandQty
            End Get
            Set(ByVal value As Decimal)
                _GrossDemandQty = value
            End Set
        End Property

        Public Property ForecastAvailableQty() As Decimal
            Get
                Return _ForecastAvailableQty
            End Get
            Set(ByVal value As Decimal)
                _ForecastAvailableQty = value
            End Set
        End Property
        Public Property PlanIssueQty() As Decimal
            Get
                Return _PlanIssueQty
            End Get
            Set(ByVal value As Decimal)
                _PlanIssueQty = value
            End Set
        End Property
        Public Property PlanReceiveQty() As Decimal
            Get
                Return _PlanReceiveQty
            End Get
            Set(ByVal value As Decimal)
                _PlanReceiveQty = value
            End Set
        End Property
        Public Property NetDemandQty() As Decimal
            Get
                Return _NetDemandQty
            End Get
            Set(ByVal value As Decimal)
                _NetDemandQty = value
            End Set
        End Property
        Public Property PlanProduceQty() As Decimal
            Get
                Return _PlanProduceQty
            End Get
            Set(ByVal value As Decimal)
                _PlanProduceQty = value
            End Set
        End Property
        Public Property TempQty() As Decimal
            Get
                Return _TempQty
            End Get
            Set(ByVal value As Decimal)
                _TempQty = value
            End Set
        End Property

        Public Property InWayQty() As Decimal
            Get
                Return _InWayQty
            End Get
            Set(ByVal value As Decimal)
                _InWayQty = value
            End Set
        End Property

        Public Property PurchaseQty() As Decimal
            Get
                Return _PurchaseQty
            End Get
            Set(ByVal value As Decimal)
                _PurchaseQty = value
            End Set
        End Property

        Public Property StockQty() As Decimal
            Get
                Return _StockQty
            End Get
            Set(ByVal value As Decimal)
                _StockQty = value
            End Set
        End Property
        Public Property AssignQty() As Decimal
            Get
                Return _AssignQty
            End Get
            Set(ByVal value As Decimal)
                _AssignQty = value
            End Set
        End Property
        Public Property DemandQty() As Decimal
            Get
                Return _DemandQty
            End Get
            Set(ByVal value As Decimal)
                _DemandQty = value
            End Set
        End Property

        Public Property MrpDate() As Date
            Get
                Return _MrpDate
            End Get
            Set(ByVal value As Date)
                _MrpDate = value
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
        '-----------------------------------------------------
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