Namespace LFERP.Library.MrpManager.MrpPurchaseOrder
    Public Class MrpPurchaseOrderInfo

        Private _AutoID As Decimal
        Private _PO As String
        Private _PR As String
        Private _PurchaseDate As DateTime
        Private _RequestUserID As String
        Private _RequestDate As Date
        Private _SupplierID As String
        Private _WareHouseID As String
        Private _CheckBit As Boolean
        Private _CheckRemark As String
        Private _CheckDate As DateTime
        Private _CheckUserID As String
        Private _CheckUserName As String
        Private _ReCheckBit As Boolean
        Private _ReCheckRemark As String
        Private _ReCheckUserID As String
        Private _ReCheckUserName As String
        Private _ReCheckDate As DateTime
        Private _DeliveryType As String
        Private _Remarks As String
        Private _CreateDate As DateTime
        Private _CreateUserID As String
        Private _ModifyDate As DateTime
        Private _ModifyUserID As String
        Private _CreateUserName As String
        Private _RequestUserName As String
        Private _SupplierName As String
        Private _WareHouseName As String
        Private _DeptID As String
        Private _DeptName As String
        Private _CurrencyName As String
        Private _PaymentType As String
        Private _IsUrgency As Boolean
        Public Sub New()
            _AutoID = 0
            _PO = Nothing
            _PR = Nothing
            _PurchaseDate = Nothing
            _RequestUserID = Nothing
            _RequestDate = Nothing
            _SupplierID = Nothing
            _WareHouseID = Nothing
            _CheckBit = False
            _CheckRemark = Nothing
            _CheckDate = Nothing
            _CheckUserID = Nothing
            _CheckUserName = Nothing
            _ReCheckBit = False
            _ReCheckRemark = Nothing
            _ReCheckUserID = Nothing
            _ReCheckUserName = Nothing
            _ReCheckDate = Nothing
            _DeliveryType = Nothing
            _Remarks = Nothing
            _CreateDate = Nothing
            _CreateUserID = Nothing
            _ModifyDate = Nothing
            _ModifyUserID = Nothing
            _CreateUserName = Nothing
            _RequestUserName = Nothing
            _SupplierName = Nothing
            _WareHouseName = Nothing
            _DeptID = Nothing
            _DeptName = Nothing
            _CurrencyName = Nothing
            _PaymentType = Nothing
            _IsUrgency = Nothing
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
        Public Property PR() As String
            Get
                Return _PR
            End Get
            Set(ByVal value As String)
                _PR = value
            End Set
        End Property
        Public Property PurchaseDate() As DateTime
            Get
                Return _PurchaseDate
            End Get
            Set(ByVal value As DateTime)
                _PurchaseDate = value
            End Set
        End Property
        Public Property RequestUserID() As String
            Get
                Return _RequestUserID
            End Get
            Set(ByVal value As String)
                _RequestUserID = value
            End Set
        End Property
        Public Property RequestDate() As DateTime
            Get
                Return _RequestDate
            End Get
            Set(ByVal value As DateTime)
                _RequestDate = value
            End Set
        End Property
        Public Property SupplierID() As String
            Get
                Return _SupplierID
            End Get
            Set(ByVal value As String)
                _SupplierID = value
            End Set
        End Property
        Public Property WareHouseID() As String
            Get
                Return _WareHouseID
            End Get
            Set(ByVal value As String)
                _WareHouseID = value
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
        Public Property CheckRemark() As String
            Get
                Return _CheckRemark
            End Get
            Set(ByVal value As String)
                _CheckRemark = value
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
        Public Property CheckUserName() As String
            Get
                Return _CheckUserName
            End Get
            Set(ByVal value As String)
                _CheckUserName = value
            End Set
        End Property
        Public Property ReCheckBit() As Boolean
            Get
                Return _ReCheckBit
            End Get
            Set(ByVal value As Boolean)
                _ReCheckBit = value
            End Set
        End Property
        Public Property ReCheckRemark() As String
            Get
                Return _ReCheckRemark
            End Get
            Set(ByVal value As String)
                _ReCheckRemark = value
            End Set
        End Property
        Public Property ReCheckUserID() As String
            Get
                Return _ReCheckUserID
            End Get
            Set(ByVal value As String)
                _ReCheckUserID = value
            End Set
        End Property
        Public Property ReCheckUserName() As String
            Get
                Return _ReCheckUserName
            End Get
            Set(ByVal value As String)
                _ReCheckUserName = value
            End Set
        End Property
        Public Property ReCheckDate() As DateTime
            Get
                Return _ReCheckDate
            End Get
            Set(ByVal value As DateTime)
                _ReCheckDate = value
            End Set
        End Property
        Public Property DeliveryType() As String
            Get
                Return _DeliveryType
            End Get
            Set(ByVal value As String)
                _DeliveryType = value
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
        Public Property CreateUserName() As String
            Get
                Return _CreateUserName
            End Get
            Set(ByVal value As String)
                _CreateUserName = value
            End Set
        End Property
        Public Property RequestUserName() As String
            Get
                Return _RequestUserName
            End Get
            Set(ByVal value As String)
                _RequestUserName = value
            End Set
        End Property
        Public Property SupplierName() As String
            Get
                Return _SupplierName
            End Get
            Set(ByVal value As String)
                _SupplierName = value
            End Set
        End Property
        Public Property WareHouseName() As String
            Get
                Return _WareHouseName
            End Get
            Set(ByVal value As String)
                _WareHouseName = value
            End Set
        End Property
        Public Property DeptID() As String
            Get
                Return _DeptID
            End Get
            Set(ByVal value As String)
                _DeptID = value
            End Set
        End Property
        Public Property DeptName() As String
            Get
                Return _DeptName
            End Get
            Set(ByVal value As String)
                _DeptName = value
            End Set
        End Property
        Public Property CurrencyName() As String
            Get
                Return _CurrencyName
            End Get
            Set(ByVal value As String)
                _CurrencyName = value
            End Set
        End Property
        Public Property PaymentType() As String
            Get
                Return _PaymentType
            End Get
            Set(ByVal value As String)
                _PaymentType = value
            End Set
        End Property
        Public Property IsUrgency() As Boolean
            Get
                Return _IsUrgency
            End Get
            Set(ByVal value As Boolean)
                _IsUrgency = value
            End Set
        End Property
    End Class
End Namespace