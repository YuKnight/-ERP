Namespace LFERP.Library.Positive
    Public Class PositiveDeliverInfo
#Region "絯把计"
        Private _AutoID As String
        Private _D_NO As String
        Private _P_OM_ID As String
        Private _P_OM_Num As String
        Private _D_TypeID As String
        Private _Qty As Double
        Private _D_AddAction As String
        Private _D_AddDate As String
        Private _D_Remark As String
        Private _D_Check As Boolean
        Private _D_CheckDate As String
        Private _D_CheckRemark As String
        Private _D_CheckAction As String


        Private _D_OM_Num As String
        Private _D_OMCheckRemark As String

        Private _P_OM_CusterPO As String
        Private _P_OM_CusterNo As String
        Private _P_M_Code As String

        Private _ActionName As String
        Private _CheckActionName As String


        Private _PartNumber As String
        Private _NoSendQty As String
        Private _P_SalesPrice As String
        Private _P_ProductPrice As String
        Private _D_TypeName As String

        Private _ChineseName As String
        Private _CusterAddr As String
        Private _M_Unit As String

        Private _OrderQty As Double
        Private _People As String

        '2014.04.30 糂不猀
        Private _NoTaxPrice As Decimal
        Private _TaxRate As Decimal
        Private _Discount As Decimal
        Private _Sequence As Int16
        Private _M_Name As String
        Private _M_Gauge As String
        Private _UnitID As String
        Private _UnitName As String
#End Region

#Region "篶硑ㄧ计"
        Public Sub New()
            _NoTaxPrice = 0
            _TaxRate = 0
            _Discount = 0
            _Sequence = 0
            _M_Name = Nothing
            _M_Gauge = Nothing
            _UnitID = Nothing
            _UnitName = Nothing

            _AutoID = Nothing
            _D_NO = Nothing
            _P_OM_ID = Nothing
            _P_OM_Num = Nothing
            _D_TypeID = Nothing
            _Qty = 0.0
            _D_AddAction = Nothing
            _D_AddDate = Nothing
            _D_Remark = Nothing
            _D_Check = Nothing
            _D_CheckDate = Nothing
            _D_CheckRemark = Nothing

            _D_OM_Num = Nothing
            _D_OMCheckRemark = Nothing

            _P_OM_CusterPO = Nothing
            _P_OM_CusterNo = Nothing
            _P_M_Code = Nothing

            _PartNumber = Nothing
            _NoSendQty = Nothing
            _P_SalesPrice = Nothing
            _P_ProductPrice = Nothing
            _D_TypeName = Nothing
            _D_CheckAction = Nothing
            _ChineseName = Nothing
            _M_Unit = Nothing

            _OrderQty = 0.0

            _ActionName = Nothing
            _CheckActionName = Nothing
            _CusterAddr = Nothing
            _People = Nothing



        End Sub
#End Region

#Region "妮┦"

        Public Property NoTaxPrice() As Decimal
            Get
                Return _NoTaxPrice
            End Get
            Set(ByVal value As Decimal)
                _NoTaxPrice = value
            End Set
        End Property
        Public Property TaxRate() As Decimal
            Get
                Return _TaxRate
            End Get
            Set(ByVal value As Decimal)
                _TaxRate = value
            End Set
        End Property
        Public Property Discount() As Decimal
            Get
                Return _Discount
            End Get
            Set(ByVal value As Decimal)
                _Discount = value
            End Set
        End Property
        Public Property Sequence() As Int16
            Get
                Return _Sequence
            End Get
            Set(ByVal value As Int16)
                _Sequence = value
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
        Public Property UnitID() As String
            Get
                Return _UnitID
            End Get
            Set(ByVal value As String)
                _UnitID = value
            End Set
        End Property
        Public Property UnitName() As String
            Get
                Return _UnitName
            End Get
            Set(ByVal value As String)
                _UnitName = value
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

        Public Property P_OM_Num() As String
            Get
                Return _P_OM_Num
            End Get
            Set(ByVal value As String)
                _P_OM_Num = value
            End Set
        End Property

        Public Property P_M_Code() As String
            Get
                Return _P_M_Code
            End Get
            Set(ByVal value As String)
                _P_M_Code = value
            End Set
        End Property


        Public Property P_OM_CusterPO() As String
            Get
                Return _P_OM_CusterPO
            End Get
            Set(ByVal value As String)
                _P_OM_CusterPO = value
            End Set
        End Property

        Public Property P_OM_CusterNo() As String
            Get
                Return _P_OM_CusterNo
            End Get
            Set(ByVal value As String)
                _P_OM_CusterNo = value
            End Set
        End Property


        Public Property P_OM_ID() As String
            Get
                Return _P_OM_ID
            End Get
            Set(ByVal value As String)
                _P_OM_ID = value
            End Set
        End Property

        Public Property D_NO() As String
            Get
                Return _D_NO
            End Get
            Set(ByVal value As String)
                _D_NO = value
            End Set
        End Property

        Public Property Qty() As Double
            Get
                Return _Qty
            End Get
            Set(ByVal value As Double)
                _Qty = value
            End Set
        End Property


     
        Public Property D_AddAction() As String
            Get
                Return _D_AddAction
            End Get
            Set(ByVal value As String)
                _D_AddAction = value
            End Set
        End Property

     

        Public Property D_AddDate() As String
            Get
                Return _D_AddDate
            End Get
            Set(ByVal value As String)
                _D_AddDate = value
            End Set
        End Property

        Public Property D_Remark() As String
            Get
                Return _D_Remark
            End Get
            Set(ByVal value As String)
                _D_Remark = value
            End Set
        End Property

        Public Property D_Check() As Boolean
            Get
                Return _D_Check
            End Get
            Set(ByVal value As Boolean)
                _D_Check = value
            End Set
        End Property


        Public Property D_CheckDate() As String
            Get
                Return _D_CheckDate
            End Get
            Set(ByVal value As String)
                _D_CheckDate = value
            End Set
        End Property

        Public Property D_CheckRemark() As String
            Get
                Return _D_CheckRemark
            End Get
            Set(ByVal value As String)
                _D_CheckRemark = value
            End Set
        End Property


        Public Property D_OM_Num() As String
            Get
                Return _D_OM_Num
            End Get
            Set(ByVal value As String)
                _D_OM_Num = value
            End Set
        End Property

        Public Property D_OMCheckRemark() As String
            Get
                Return _D_OMCheckRemark
            End Get
            Set(ByVal value As String)
                _D_OMCheckRemark = value
            End Set
        End Property

        Public Property P_SalesPrice() As String
            Get
                Return _P_SalesPrice
            End Get
            Set(ByVal value As String)
                _P_SalesPrice = value
            End Set
        End Property

        Public Property P_ProductPrice() As String
            Get
                Return _P_ProductPrice
            End Get
            Set(ByVal value As String)
                _P_ProductPrice = value
            End Set
        End Property

        Public Property NoSendQty() As String
            Get
                Return _NoSendQty
            End Get
            Set(ByVal value As String)
                _NoSendQty = value
            End Set
        End Property

        Public Property PartNumber() As String
            Get
                Return _PartNumber
            End Get
            Set(ByVal value As String)
                _PartNumber = value
            End Set
        End Property

        Public Property D_TypeName() As String
            Get
                Return _D_TypeName
            End Get
            Set(ByVal value As String)
                _D_TypeName = value
            End Set
        End Property

        Public Property D_TypeID() As String
            Get
                Return _D_TypeID
            End Get
            Set(ByVal value As String)
                _D_TypeID = value
            End Set
        End Property


        Public Property OrderQty() As Double
            Get
                Return _OrderQty
            End Get
            Set(ByVal value As Double)
                _OrderQty = value
            End Set
        End Property

        Public Property D_CheckAction() As String
            Get
                Return _D_CheckAction
            End Get
            Set(ByVal value As String)
                _D_CheckAction = value
            End Set
        End Property

        Public Property ChineseName() As String
            Get
                Return _ChineseName
            End Get
            Set(ByVal value As String)
                _ChineseName = value
            End Set
        End Property

        Public Property ActionName() As String
            Get
                Return _ActionName
            End Get
            Set(ByVal value As String)
                _ActionName = value
            End Set
        End Property

        Public Property CheckActionName() As String
            Get
                Return _CheckActionName
            End Get
            Set(ByVal value As String)
                _CheckActionName = value
            End Set
        End Property

        Public Property CusterAddr() As String
            Get
                Return _CusterAddr
            End Get
            Set(ByVal value As String)
                _CusterAddr = value
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

        Public Property People() As String
            Get
                Return _People
            End Get
            Set(ByVal value As String)
                _People = value
            End Set
        End Property



#End Region
    End Class
End Namespace

