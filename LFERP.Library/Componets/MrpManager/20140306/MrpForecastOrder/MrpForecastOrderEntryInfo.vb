Namespace LFERP.Library.MrpManager.MrpForecastOrder
    Public Class MrpForecastOrderEntryInfo

#Region "字段和屬性"
        '字段和屬性
        Private _ForecastID As String
        Private _M_Code As String
        Private _MI_Qty As Double
        Private _MI_NeedDate As String
        Private _MI_Note As String
        Private _MI_WeekNumber As Int64
        Private _MI_ISpurchase As Boolean
        Private _MI_ISPpurchase As Boolean
        Private _MI_ISWorkOrder As Boolean
        Private _CreateUserID As String
        Private _CreateDate As String
        Private _ModifyUserID As String
        Private _ModifyDate As String
        Private _AutoID As Double
        Private _ModifyUserName As String
        Private _CreateUserName As String
        Private _M_Unit As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Source As String
        Private _DateCross As String
        Private _PurchasedQty As String

#End Region

#Region "初始化"
        '初始化
        Public Sub New()
            _ForecastID = Nothing
            _M_Code = Nothing
            _MI_Qty = 0
            _MI_NeedDate = Nothing
            _MI_Note = Nothing
            _MI_WeekNumber = 0
            _MI_ISpurchase = False
            _MI_ISPpurchase = False
            _MI_ISWorkOrder = False
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _AutoID = 0
            _ModifyUserName = Nothing
            _CreateUserName = Nothing
            _M_Unit = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Source = Nothing
            _DateCross = Nothing
        End Sub
#End Region

#Region "實例"
        '實例
   

        Public Property ForecastID() As String
            Get
                Return _ForecastID
            End Get
            Set(ByVal value As String)
                _ForecastID = value
            End Set
        End Property
        Public Property PurchasedQty() As Double
            Get
                Return _PurchasedQty
            End Get
            Set(ByVal value As Double)
                _PurchasedQty = value
            End Set
        End Property
        Public Property MI_Qty() As Double
            Get
                Return _MI_Qty
            End Get
            Set(ByVal value As Double)
                _MI_Qty = value
            End Set
        End Property
        Public Property MI_NeedDate() As String
            Get
                Return _MI_NeedDate
            End Get
            Set(ByVal value As String)
                _MI_NeedDate = value
            End Set
        End Property
        Public Property MI_Note() As String
            Get
                Return _MI_Note
            End Get
            Set(ByVal value As String)
                _MI_Note = value
            End Set
        End Property
        Public Property MI_WeekNumber() As Int64
            Get
                Return _MI_WeekNumber
            End Get
            Set(ByVal value As Int64)
                _MI_WeekNumber = value
            End Set
        End Property
        Public Property MI_ISpurchase() As Boolean
            Get
                Return _MI_ISpurchase
            End Get
            Set(ByVal value As Boolean)
                _MI_ISpurchase = value
            End Set
        End Property
        Public Property MI_ISPpurchase() As Boolean
            Get
                Return _MI_ISPpurchase
            End Get
            Set(ByVal value As Boolean)
                _MI_ISPpurchase = value
            End Set
        End Property
        Public Property MI_ISWorkOrder() As Boolean
            Get
                Return _MI_ISWorkOrder
            End Get
            Set(ByVal value As Boolean)
                _MI_ISWorkOrder = value
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
        Public Property M_Source() As String
            Get
                Return _M_Source
            End Get
            Set(ByVal value As String)
                _M_Source = value
            End Set
        End Property
        Public Property DateCross() As String
            Get
                Return _DateCross
            End Get
            Set(ByVal value As String)
                _DateCross = value
            End Set
        End Property
#End Region

    End Class
End Namespace