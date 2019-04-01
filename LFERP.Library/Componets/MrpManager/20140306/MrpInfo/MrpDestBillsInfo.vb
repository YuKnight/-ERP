Namespace LFERP.Library.MrpManager.MrpInfo
    Public Class MrpDestBillsInfo

        Private _AutoID As Decimal
        Private _MRP_ID As String
        Private _M_Code As String
        Private _MB_MRPQty As Decimal
        Private _MB_CreateUserID As String
        Private _MB_CreateDate As Date
        Private _MB_ModifyUserID As String
        Private _MB_ModifyDate As Date
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _MP_InventoryQty As Decimal
        Private _Source As String
        Public Sub New()
            _AutoID = 0
            _MRP_ID = Nothing
            _M_Code = Nothing
            _MB_MRPQty = 0
            _MB_CreateUserID = Nothing
            _MB_CreateDate = Nothing
            _MB_ModifyUserID = Nothing
            _MB_ModifyDate = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _MP_InventoryQty = 0
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
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property
        Public Property MB_MRPQty() As Decimal
            Get
                Return _MB_MRPQty
            End Get
            Set(ByVal value As Decimal)
                _MB_MRPQty = value
            End Set
        End Property
        Public Property MB_CreateUserID() As String
            Get
                Return _MB_CreateUserID
            End Get
            Set(ByVal value As String)
                _MB_CreateUserID = value
            End Set
        End Property
        Public Property MB_CreateDate() As Date
            Get
                Return _MB_CreateDate
            End Get
            Set(ByVal value As Date)
                _MB_CreateDate = value
            End Set
        End Property
        Public Property MB_ModifyUserID() As String
            Get
                Return _MB_ModifyUserID
            End Get
            Set(ByVal value As String)
                _MB_ModifyUserID = value
            End Set
        End Property
        Public Property MB_ModifyDate() As Date
            Get
                Return _MB_ModifyDate
            End Get
            Set(ByVal value As Date)
                _MB_ModifyDate = value
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
        Public Property MP_InventoryQty() As Decimal
            Get
                Return _MP_InventoryQty
            End Get
            Set(ByVal value As Decimal)
                _MP_InventoryQty = value
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
