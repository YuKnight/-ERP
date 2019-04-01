
Namespace LFERP.Library.MrpManager.MrpMps
    Public Class MrpMpsInfo

        Private _AutoID As Decimal
        Private _MO As String
        Private _ForecastID As String
        Private _CusterID As String
        Private _CusterName As String
        Private _M_Code As String
        Private _ProductionQty As Decimal
        Private _CheckBit As Boolean
        Private _CheckDate As DateTime
        Private _CheckUserID As String
        Private _CheckRemarks As String
        Private _CreateDate As DateTime
        Private _CreateUserID As String
        Private _ModifyDate As DateTime
        Private _ModifyUserID As String
        Private _Remarks As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _M_Source As String
        Private _ModifyUserName As String
        Private _CreateUserName As String
        Private _CheckUserName As String

        Public Sub New()
            _AutoID = 0
            _MO = Nothing
            _ForecastID = Nothing
            _CusterID = Nothing
            _CusterName = Nothing
            _M_Code = Nothing
            _ProductionQty = 0
            _CheckBit = False
            _CheckDate = Nothing
            _CheckUserID = Nothing
            _CheckRemarks = Nothing
            _CreateDate = Nothing
            _CreateUserID = Nothing
            _ModifyDate = Nothing
            _ModifyUserID = Nothing
            _Remarks = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _M_Source = Nothing
            _ModifyUserName = Nothing
            _CreateUserName = Nothing
            _CheckUserName = Nothing
        End Sub
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property MO() As String
            Get
                Return _MO
            End Get
            Set(ByVal value As String)
                _MO = value
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
        Public Property CusterID() As String
            Get
                Return _CusterID
            End Get
            Set(ByVal value As String)
                _CusterID = value
            End Set
        End Property
        Public Property CusterName() As String
            Get
                Return _CusterName
            End Get
            Set(ByVal value As String)
                _CusterName = value
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
        Public Property ProductionQty() As Decimal
            Get
                Return _ProductionQty
            End Get
            Set(ByVal value As Decimal)
                _ProductionQty = value
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
        Public Property CheckDate() As DateTime
            Get
                Return _CheckDate
            End Get
            Set(ByVal value As DateTime)
                _CheckDate = value
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
        Public Property CheckRemarks() As String
            Get
                Return _CheckRemarks
            End Get
            Set(ByVal value As String)
                _CheckRemarks = value
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
        Public Property CreateUserID() As String
            Get
                Return _CreateUserID
            End Get
            Set(ByVal value As String)
                _CreateUserID = value
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
        Public Property Remarks() As String
            Get
                Return _Remarks
            End Get
            Set(ByVal value As String)
                _Remarks = value
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
        Public Property M_Source() As String
            Get
                Return _M_Source
            End Get
            Set(ByVal value As String)
                _M_Source = value
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

    End Class
End Namespace