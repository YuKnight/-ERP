Namespace LFERP.Library.MrpManager.MrpSupplierQuotation
    Public Class MrpSupplierQuotationInfo
        Private _MCode As String
        Private _S_Supplier As String
        Private _EconomicQty As Decimal
        Private _OrderQty As Decimal
        Private _DeliveryDate As Integer
        Private _MaxQty As Decimal
        Private _MinQty As Decimal
        Private _ResponsibleUserID As String
        Private _UnitPrice As Decimal
        Private _Remark As String
        Private _CreateUserID As String
        Private _CreateDate As DateTime
        Private _ModifyUserID As String
        Private _ModifyDate As DateTime
        Private _CheckUserID As String
        Private _CheckBit As Boolean
        Private _CheckRemark As String
        Private _AutoID As Decimal
        Private _S_SupplierName As String
        Private _M_Unit As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Source As String
        Private _CreateUserName As String
        Private _ModifyUserName As String
        Private _CheckUserName As String
        Private _MrpSQID As String

        Private _PaymentType As String
        Private _Tel As String
        Private _Contacts As String
        Private _CurrencyName As String
        Private _Fax As String
        Private _Email As String
        Private _DefaultBit As Boolean

        Public Sub New()
            _PaymentType = Nothing
            _Tel = Nothing
            _Contacts = Nothing
            _CurrencyName = Nothing
            _Fax = Nothing
            _Email = Nothing

            _MCode = Nothing
            _S_Supplier = Nothing
            _EconomicQty = 0
            _OrderQty = 0
            _DeliveryDate = 0
            _MaxQty = 0
            _MinQty = 0
            _ResponsibleUserID = Nothing
            _UnitPrice = 0
            _Remark = Nothing
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _CheckUserID = Nothing
            _CheckBit = False
            _CheckRemark = Nothing
            _AutoID = 0
            _S_SupplierName = Nothing
            _M_Unit = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Source = Nothing
            _CreateUserName = Nothing
            _ModifyUserName = Nothing
            _CheckUserName = Nothing
            _MrpSQID = Nothing
            _S_SupplierName = Nothing
            _DefaultBit = Nothing
        End Sub

        Public Property DefaultBit() As Boolean
            Get
                Return _DefaultBit
            End Get
            Set(ByVal value As Boolean)
                _DefaultBit = value
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
        Public Property Tel() As String
            Get
                Return _Tel
            End Get
            Set(ByVal value As String)
                _Tel = value
            End Set
        End Property
        Public Property Contacts() As String
            Get
                Return _Contacts
            End Get
            Set(ByVal value As String)
                _Contacts = value
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
        Public Property Fax() As String
            Get
                Return _Fax
            End Get
            Set(ByVal value As String)
                _Fax = value
            End Set
        End Property
        Public Property Email() As String
            Get
                Return _Email
            End Get
            Set(ByVal value As String)
                _Email = value
            End Set
        End Property
        Public Property MrpSQID() As String
            Get
                Return _MrpSQID
            End Get
            Set(ByVal value As String)
                _MrpSQID = value
            End Set
        End Property
        Public Property S_SupplierName() As String
            Get
                Return _S_SupplierName
            End Get
            Set(ByVal value As String)
                _S_SupplierName = value
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
                _MCode = value
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
        Public Property CreateUserName() As String
            Get
                Return _CreateUserName
            End Get
            Set(ByVal value As String)
                _CreateUserName = value
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
        Public Property CheckUserName() As String
            Get
                Return _CheckUserName
            End Get
            Set(ByVal value As String)
                _CheckUserName = value
            End Set
        End Property
        Public Property MCode() As String
            Get
                Return _MCode
            End Get
            Set(ByVal value As String)
                _MCode = value
            End Set
        End Property
        Public Property S_Supplier() As String
            Get
                Return _S_Supplier
            End Get
            Set(ByVal value As String)
                _S_Supplier = value
            End Set
        End Property
        Public Property EconomicQty() As Decimal
            Get
                Return _EconomicQty
            End Get
            Set(ByVal value As Decimal)
                _EconomicQty = value
            End Set
        End Property
        Public Property OrderQty() As Decimal
            Get
                Return _OrderQty
            End Get
            Set(ByVal value As Decimal)
                _OrderQty = value
            End Set
        End Property
        Public Property DeliveryDate() As Integer
            Get
                Return _DeliveryDate
            End Get
            Set(ByVal value As Integer)
                _DeliveryDate = value
            End Set
        End Property
        Public Property MaxQty() As Decimal
            Get
                Return _MaxQty
            End Get
            Set(ByVal value As Decimal)
                _MaxQty = value
            End Set
        End Property
        Public Property MinQty() As Decimal
            Get
                Return _MinQty
            End Get
            Set(ByVal value As Decimal)
                _MinQty = value
            End Set
        End Property
        Public Property ResponsibleUserID() As String
            Get
                Return _ResponsibleUserID
            End Get
            Set(ByVal value As String)
                _ResponsibleUserID = value
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
        Public Property Remark() As String
            Get
                Return _Remark
            End Get
            Set(ByVal value As String)
                _Remark = value
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
        Public Property CheckRemark() As String
            Get
                Return _CheckRemark
            End Get
            Set(ByVal value As String)
                _CheckRemark = value
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

    End Class
End Namespace