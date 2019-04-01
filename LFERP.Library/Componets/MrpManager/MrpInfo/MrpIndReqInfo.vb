Namespace LFERP.Library.MrpManager.MrpInfo
    Public Class MrpIndReqInfo

        Private _AutoID As Decimal
        Private _MRP_ID As String
        Private _PID As String
        Private _ID As String
        Private _sonsNum As Int16
        Private _ForecastID As String
        Private _NeedDate As Date
        Private _InvalidDate As Date
        Private _M_Code As String
        Private _NeedQty As Decimal
        Private _CreateUserID As String
        Private _CreateDate As Date
        Private _ModifyUserID As String
        Private _ModifyDate As Date
        Private _CustomerName As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _Source As String
        Public Sub New()
            _AutoID = 0
            _MRP_ID = Nothing
            _PID = Nothing
            _ID = Nothing
            _sonsNum = 0
            _ForecastID = Nothing
            _NeedDate = Nothing
            _InvalidDate = Nothing
            _M_Code = Nothing
            _NeedQty = 0
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _CustomerName = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _Source = Nothing
        End Sub
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
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
        Public Property PID() As String
            Get
                Return _PID
            End Get
            Set(ByVal value As String)
                _PID = value
            End Set
        End Property
        Public Property ID() As String
            Get
                Return _ID
            End Get
            Set(ByVal value As String)
                _ID = value
            End Set
        End Property
        Public Property sonsNum() As Int16
            Get
                Return _sonsNum
            End Get
            Set(ByVal value As Int16)
                _sonsNum = value
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
        Public Property NeedDate() As Date
            Get
                Return _NeedDate
            End Get
            Set(ByVal value As Date)
                _NeedDate = value
            End Set
        End Property

        Public Property InvalidDate() As Date
            Get
                Return _InvalidDate
            End Get
            Set(ByVal value As Date)
                _InvalidDate = value
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
        Public Property NeedQty() As Decimal
            Get
                Return _NeedQty
            End Get
            Set(ByVal value As Decimal)
                _NeedQty = value
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
        Public Property CustomerName() As String
            Get
                Return _CustomerName
            End Get
            Set(ByVal value As String)
                _CustomerName = value
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
    End Class
End Namespace