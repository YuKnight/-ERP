Namespace LFERP.Library.MrpManager.MrpInfo

    Public Class MrpOrderDestBillsInfo

        Private _MRP_ID As String
        Private _OD_ID As String
        Private _MOB_ForecastID As String
        Private _MOB_NeedDate As Date
        Private _M_Code As String
        Private _MOB_MRPQty As Decimal
        Private _MOB_CreateUserID As String
        Private _MOB_CreateDate As Date
        Private _MOB_ModifyUserID As String
        Private _MOB_ModifyDate As Date
        Private _AutoID As Decimal
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _customerName As String
        Private _Source As String
        Public Sub New()
            _MRP_ID = Nothing
            _OD_ID = Nothing
            _MOB_ForecastID = Nothing
            _MOB_NeedDate = Nothing
            _M_Code = Nothing
            _MOB_MRPQty = 0
            _MOB_CreateUserID = Nothing
            _MOB_CreateDate = Nothing
            _MOB_ModifyUserID = Nothing
            _MOB_ModifyDate = Nothing
            _AutoID = 0
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _customerName = Nothing
            _Source = Nothing
        End Sub
        Public Property MRP_ID() As String
            Get
                Return _MRP_ID
            End Get
            Set(ByVal value As String)
                _MRP_ID = value
            End Set
        End Property
        Public Property OD_ID() As String
            Get
                Return _OD_ID
            End Get
            Set(ByVal value As String)
                _OD_ID = value
            End Set
        End Property
        Public Property MOB_ForecastID() As String
            Get
                Return _MOB_ForecastID
            End Get
            Set(ByVal value As String)
                _MOB_ForecastID = value
            End Set
        End Property
        Public Property MOB_NeedDate() As Date
            Get
                Return _MOB_NeedDate
            End Get
            Set(ByVal value As Date)
                _MOB_NeedDate = value
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
        Public Property MOB_MRPQty() As Decimal
            Get
                Return _MOB_MRPQty
            End Get
            Set(ByVal value As Decimal)
                _MOB_MRPQty = value
            End Set
        End Property
        Public Property MOB_CreateUserID() As String
            Get
                Return _MOB_CreateUserID
            End Get
            Set(ByVal value As String)
                _MOB_CreateUserID = value
            End Set
        End Property
        Public Property MOB_CreateDate() As Date
            Get
                Return _MOB_CreateDate
            End Get
            Set(ByVal value As Date)
                _MOB_CreateDate = value
            End Set
        End Property
        Public Property MOB_ModifyUserID() As String
            Get
                Return _MOB_ModifyUserID
            End Get
            Set(ByVal value As String)
                _MOB_ModifyUserID = value
            End Set
        End Property
        Public Property MOB_ModifyDate() As Date
            Get
                Return _MOB_ModifyDate
            End Get
            Set(ByVal value As Date)
                _MOB_ModifyDate = value
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
        Public Property customerName() As String
            Get
                Return _customerName
            End Get
            Set(ByVal value As String)
                _customerName = value
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