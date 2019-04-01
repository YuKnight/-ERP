Namespace LFERP.Library.MrpManager.MrpPurchaseOrder
    Public Class MrpPurchaseOrderEntryInfo

        Private _AutoID As Decimal
        Private _PO As String
        Private _M_Code As String
        Private _PurchaseQty As Decimal
        Private _NeedDate As Date
        Private _DeliveryDate As Date
        Private _UnitPrice As Decimal
        Private _Remarks As String
        Private _CreateUserID As String
        Private _CreateDate As DateTime
        Private _ModifyUserID As String
        Private _ModifyDate As DateTime
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _Source As String
        Public Sub New()
            _AutoID = 0
            _PO = Nothing
            _M_Code = Nothing
            _PurchaseQty = 0
            _NeedDate = Nothing
            _DeliveryDate = Nothing
            _UnitPrice = 0
            _Remarks = Nothing
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
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
        Public Property PO() As String
            Get
                Return _PO
            End Get
            Set(ByVal value As String)
                _PO = value
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
        Public Property PurchaseQty() As Decimal
            Get
                Return _PurchaseQty
            End Get
            Set(ByVal value As Decimal)
                _PurchaseQty = value
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
        Public Property DeliveryDate() As Date
            Get
                Return _DeliveryDate
            End Get
            Set(ByVal value As Date)
                _DeliveryDate = value
            End Set
        End Property
        Public Property UnitPrice() As Decimal
            Get
                Return _UnitPrice
            End Get
            Set(ByVal value As Decimal)
                _UnitPrice = value
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
        Public Property CreateUserID() As String
            Get
                Return _CreateUserID
            End Get
            Set(ByVal value As String)
                _CreateUserID = value
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
        Public Property ModifyUserID() As String
            Get
                Return _ModifyUserID
            End Get
            Set(ByVal value As String)
                _ModifyUserID = value
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