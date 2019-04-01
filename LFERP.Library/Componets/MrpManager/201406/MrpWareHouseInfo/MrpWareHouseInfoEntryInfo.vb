Namespace LFERP.Library.MrpManager.MrpWareHouseInfo
    Public Class MrpWareHouseInfoEntryInfo

        Private _Ware_ID As String
        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _SourceID As String
        Private _Source As String
        Private _MP_InventoryQty As Decimal
        Private _MP_InTransitQty As Decimal
        Private _MP_Inspection As Decimal
        Private _MP_NoCollar As Decimal
        Private _MP_RetreatQty As Decimal
        Private _CreateUserID As String
        Private _CreateDate As Date
        Private _ModifyUserID As String
        Private _ModifyDate As Date
        Private _MP_Remark As String
        Private _AutoID As String
        Public Sub New()
            _Ware_ID = Nothing
            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _SourceID = Nothing
            _Source = Nothing
            _MP_InventoryQty = 0
            _MP_InTransitQty = 0
            _MP_Inspection = 0
            _MP_NoCollar = 0
            _MP_RetreatQty = 0
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _MP_Remark = Nothing
            _AutoID = Nothing

        End Sub
        Public Property Ware_ID() As String
            Get
                Return _Ware_ID
            End Get
            Set(ByVal value As String)
                _Ware_ID = value
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
        Public Property SourceID() As String
            Get
                Return _SourceID
            End Get
            Set(ByVal value As String)
                _SourceID = value
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
        Public Property MP_InventoryQty() As Decimal
            Get
                Return _MP_InventoryQty
            End Get
            Set(ByVal value As Decimal)
                _MP_InventoryQty = value
            End Set
        End Property
        Public Property MP_InTransitQty() As Decimal
            Get
                Return _MP_InTransitQty
            End Get
            Set(ByVal value As Decimal)
                _MP_InTransitQty = value
            End Set
        End Property
        Public Property MP_Inspection() As Decimal
            Get
                Return _MP_Inspection
            End Get
            Set(ByVal value As Decimal)
                _MP_Inspection = value
            End Set
        End Property
        Public Property MP_NoCollar() As Decimal
            Get
                Return _MP_NoCollar
            End Get
            Set(ByVal value As Decimal)
                _MP_NoCollar = value
            End Set
        End Property
        Public Property MP_RetreatQty() As Decimal
            Get
                Return _MP_RetreatQty
            End Get
            Set(ByVal value As Decimal)
                _MP_RetreatQty = value
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
        Public Property MP_Remark() As String
            Get
                Return _MP_Remark
            End Get
            Set(ByVal value As String)
                _MP_Remark = value
            End Set
        End Property
        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property

    End Class
End Namespace