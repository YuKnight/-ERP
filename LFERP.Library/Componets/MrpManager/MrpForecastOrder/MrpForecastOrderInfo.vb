Namespace LFERP.Library.MrpManager.MrpForecastOrder
    Public Class MrpForecastOrderInfo

#Region "字段和屬性"
        '字段和屬性
        Private _ForecastID As String
        Private _MO_ForecastDate As String
        Private _MO_Status As String
        Private _MO_Cancellation As Boolean
        Private _OrderInterID As String
        Private _MO_PlanType As String
        Private _CheckUserID As String
        Private _CheckBit As Boolean
        Private _CheckDate As Date
        Private _CheckRemark As String
        Private _CreateUserID As String
        Private _CreateDate As String
        Private _ModifyUserID As String
        Private _ModifyDate As String
        Private _ModifyUserName As String
        Private _CreateUserName As String
        Private _CheckUserName As String
        Private _AutoID As Double
        Private _MO_CusterID As String
        Private _MO_CusterName As String
        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _M_Source As String
        Private _NeedQty As Decimal

#End Region

#Region "初始化"
        '初始化
        Public Sub New()
            _ForecastID = Nothing
            _MO_ForecastDate = Nothing
            _MO_Status = Nothing
            _MO_Cancellation = False
            _OrderInterID = Nothing
            _MO_PlanType = Nothing
            _CheckUserID = Nothing
            _CheckBit = False
            _CheckDate = Nothing
            _CheckRemark = Nothing
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _AutoID = 0
            _ModifyUserName = Nothing
            _CreateUserName = Nothing
            _CheckUserName = Nothing
            _MO_CusterID = Nothing
            _MO_CusterName = Nothing
            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _M_Source = Nothing
            _NeedQty = Nothing
        End Sub
#End Region

#Region "實例"
        Public Property NeedQty() As Decimal
            Get
                Return _NeedQty
            End Get
            Set(ByVal value As Decimal)
                _NeedQty = value
            End Set
        End Property
        Public Property M_Source() As String
            Get
                Return _M_Source
            End Get
            Set(ByVal value As String)
                _M_Source = value
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
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property
        Public Property MO_CusterID() As String
            Get
                Return _MO_CusterID
            End Get
            Set(ByVal value As String)
                _MO_CusterID = value
            End Set
        End Property
        Public Property MO_CusterName() As String
            Get
                Return _MO_CusterName
            End Get
            Set(ByVal value As String)
                _MO_CusterName = value
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
        Public Property MO_ForecastDate() As String
            Get
                Return _MO_ForecastDate
            End Get
            Set(ByVal value As String)
                _MO_ForecastDate = value
            End Set
        End Property
        Public Property MO_Status() As String
            Get
                Return _MO_Status
            End Get
            Set(ByVal value As String)
                _MO_Status = value
            End Set
        End Property
        Public Property MO_Cancellation() As Boolean
            Get
                Return _MO_Cancellation
            End Get
            Set(ByVal value As Boolean)
                _MO_Cancellation = value
            End Set
        End Property
        Public Property OrderInterID() As String
            Get
                Return _OrderInterID
            End Get
            Set(ByVal value As String)
                _OrderInterID = value
            End Set
        End Property
        Public Property MO_PlanType() As String
            Get
                Return _MO_PlanType
            End Get
            Set(ByVal value As String)
                _MO_PlanType = value
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

        Public Property CheckDate() As Date
            Get
                Return _CheckDate
            End Get
            Set(ByVal value As Date)
                _CheckDate = value
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
        Public Property CreateDate() As String
            Get
                Return _CreateDate
            End Get
            Set(ByVal value As String)
                _CreateDate = value
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
        Public Property ModifyDate() As String
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As String)
                _ModifyDate = value
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
        Public Property CheckUserName() As String
            Get
                Return _CheckUserName
            End Get
            Set(ByVal value As String)
                _CheckUserName = value
            End Set
        End Property

#End Region

    End Class


End Namespace