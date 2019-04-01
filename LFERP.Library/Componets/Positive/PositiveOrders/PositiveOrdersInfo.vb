Namespace LFERP.Library.Positive
    Public Class PositiveOrdersInfo
#Region "絯把计"
        Private _AutoID As String
        Private _P_OM_Num As String
        Private _P_OM_ID As String
        Private _P_OM_CusterPO As String
        Private _P_OM_CusterNo As String
        Private _P_M_Code As String
        Private _PartNumber As String
        Private _Qty As String
        Private _NoSendQty As String
        Private _P_OM_AddDate As String
        Private _P_OM_AddAction As String
        Private _P_OM_Check As Boolean
        Private _P_OM_CheckAction As String
        Private _P_OM_CheckDate As String
        Private _P_SalesPrice As String
        Private _P_ProductPrice As String
        Private _P_Remark As String
        Private _P_CheckRemark As String


        Private _ActionName As String
        Private _CheckActionName As String
        Private _P_OMRemark As String

        Private _P_OMComplateDate As String

        Private _People As String
        Private _ChineseName As String

        '2014.04.30 糂不猀
        Private _NoTaxPrice As Decimal
        Private _TaxRate As Decimal
        Private _Discount As Decimal
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
            _M_Name = Nothing
            _M_Gauge = Nothing
            _UnitID = Nothing
            _UnitName = Nothing

            _AutoID = Nothing
            _P_OM_Num = Nothing
            _P_OM_ID = Nothing
            _P_OM_CusterPO = Nothing
            _P_OM_CusterNo = Nothing
            _P_M_Code = Nothing
            _PartNumber = Nothing
            _Qty = Nothing
            _NoSendQty = Nothing
            _P_OM_AddDate = Nothing
            _P_OM_AddAction = Nothing
            _P_OM_Check = False
            _P_OM_CheckAction = Nothing
            _P_OM_CheckDate = Nothing
            _P_SalesPrice = Nothing
            _P_ProductPrice = Nothing
            _P_Remark = Nothing
            _P_CheckRemark = Nothing

            _ActionName = Nothing
            _CheckActionName = Nothing
            _P_OMRemark = Nothing
            _P_OMComplateDate = Nothing

            _People = Nothing
            _ChineseName = Nothing

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

        Public Property P_OM_ID() As String
            Get
                Return _P_OM_ID
            End Get
            Set(ByVal value As String)
                _P_OM_ID = value
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

        Public Property P_M_Code() As String
            Get
                Return _P_M_Code
            End Get
            Set(ByVal value As String)
                _P_M_Code = value
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

        Public Property Qty() As String
            Get
                Return _Qty
            End Get
            Set(ByVal value As String)
                _Qty = value
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

     
        Public Property P_OM_AddDate() As String
            Get
                Return _P_OM_AddDate
            End Get
            Set(ByVal value As String)
                _P_OM_AddDate = value
            End Set
        End Property

        Public Property P_OM_Check() As Boolean
            Get
                Return _P_OM_Check
            End Get
            Set(ByVal value As Boolean)
                _P_OM_Check = value
            End Set
        End Property

        Public Property P_OM_CheckAction() As String
            Get
                Return _P_OM_CheckAction
            End Get
            Set(ByVal value As String)
                _P_OM_CheckAction = value
            End Set
        End Property

        Public Property P_OM_AddAction() As String
            Get
                Return _P_OM_AddAction
            End Get
            Set(ByVal value As String)
                _P_OM_AddAction = value
            End Set
        End Property

        Public Property P_OM_CheckDate() As String
            Get
                Return _P_OM_CheckDate
            End Get
            Set(ByVal value As String)
                _P_OM_CheckDate = value
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

        Public Property P_Remark() As String
            Get
                Return _P_Remark
            End Get
            Set(ByVal value As String)
                _P_Remark = value
            End Set
        End Property

        Public Property P_CheckRemark() As String
            Get
                Return _P_CheckRemark
            End Get
            Set(ByVal value As String)
                _P_CheckRemark = value
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

        Public Property P_OMRemark() As String
            Get
                Return _P_OMRemark
            End Get
            Set(ByVal value As String)
                _P_OMRemark = value
            End Set
        End Property


        Public Property P_OMComplateDate() As String
            Get
                Return _P_OMComplateDate
            End Get
            Set(ByVal value As String)
                _P_OMComplateDate = value
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

        Public Property ChineseName() As String
            Get
                Return _ChineseName
            End Get
            Set(ByVal value As String)
                _ChineseName = value
            End Set
        End Property
#End Region
    End Class
End Namespace
