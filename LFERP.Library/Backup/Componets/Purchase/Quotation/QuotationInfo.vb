Namespace LFERP.Library.Purchase.Quotation
    ''' <summary>
    ''' 報價單
    ''' </summary>
    ''' <remarks></remarks>
    Public Class QuotationInfo
        Private _AutoID As String
        Private _Q_QuoID As String
        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _Q_Supplier As String
        Private _Q_SupplierNo As String

        Private _Q_Type As String  '報價單類型

        Private _Q_Price As Double
        Private _Q_Currency As String
        Private _Q_AddDate As Date
        Private _Q_EditDate As Date
        Private _Q_Associate As String
        Private _Q_Edition As Integer
        Private _Q_Check As Boolean
        Private _Q_CheckAction As String
        Private _Q_CheckDate As Date
        Private _Q_CheckRemark As String
        Private _Q_CheckType As String
        Private _Q_AccCheck As Boolean
        Private _Q_AccCheckDate As Date
        Private _Q_AccCheckRemark As String
        Private _Q_AccCheckType As String
        Private _Q_AccCheckAction As String
        Private _Q_Action As String
        Private _Q_Remark As String
        Private _Q_RetrDate As String
        Private _CO_ID As String
        Private _Q_Qty As Double
        Private _Q_Depict As String
        Private _PN_NO As String
        Private _Q_ActionName As String
        Private _Q_CheckActionName As String
        Private _Q_AccCheckActionName As String
        Private _Q_SupplierName As String

        Private _Q_Brand As String
        Private _Q_Origine As String
        Private _Q_StandardPack As String
        Private _Q_MOQ As String
        Private _Q_ProductionCycle As String
        Private _Q_DeliveredCycle As String
        Private _Q_DeliveredAddress As String
        Private _Q_ExchangeRate As String
        Private _Q_Validity As String
        Private _Q_MoldExpense As String
        Private _Q_PriceType As String
        Private _Q_ToForm As String
        Private _Q_Tarriff As Single

        Private _QuotationID As String
        Private _codemain As String
        Private _codesub As String
        Private _codemain_name As String
        Private _codemain_gauge As String
        Private _codemain_unit As String
        Private _codesub_name As String
        Private _codesub_gauge As String
        Private _codesub_unit As String
        Private _tagid As String
        Private _UserID As String
        Private _Code_UserName As String
        Private _Checked As Boolean

        Private _Type3Name As String
        Private _Q_Total As Single
        Private _Q_SubTotal As Single


        Private _Q_XH As Integer ''2012-5-16
        Private _HKDRate As Double '2013-6-17


        Public Sub New()
            _Q_XH = 0

            _Q_QuoID = Nothing
            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _Q_Supplier = Nothing
            _Q_SupplierNo = Nothing
            _Q_Price = 0
            _Q_Currency = Nothing
            _Q_AddDate = Nothing
            _Q_EditDate = Nothing
            _Q_Associate = Nothing
            _Q_Edition = Nothing
            _Q_Check = False
            _Q_CheckAction = Nothing
            _Q_CheckDate = Nothing
            _Q_CheckRemark = Nothing
            _Q_CheckType = Nothing
            _Q_AccCheck = False
            _Q_AccCheckDate = Nothing
            _Q_AccCheckRemark = Nothing
            _Q_AccCheckType = Nothing
            _Q_AccCheckAction = Nothing
            _Q_Action = Nothing
            _Q_Remark = Nothing
            _Q_RetrDate = Nothing
            _CO_ID = Nothing
            _Q_Qty = 0
            _Q_Depict = Nothing
            _PN_NO = Nothing
            _Q_ActionName = Nothing
            _Q_CheckActionName = Nothing
            _Q_AccCheckActionName = Nothing
            _Q_SupplierName = Nothing

            _Q_Brand = Nothing
            _Q_Origine = Nothing
            _Q_StandardPack = Nothing
            _Q_MOQ = Nothing
            _Q_ProductionCycle = Nothing
            _Q_DeliveredCycle = Nothing
            _Q_DeliveredAddress = Nothing
            _Q_ExchangeRate = Nothing
            _Q_Validity = Nothing
            _Q_MoldExpense = Nothing
            _Q_PriceType = Nothing
            _Q_ToForm = Nothing
            _Q_Tarriff = Nothing

            _QuotationID = ""
            _codemain = ""
            _codesub = ""
            _codemain_name = ""
            _codemain_gauge = ""
            _codemain_unit = ""
            _codesub_name = ""
            _codesub_gauge = ""
            _codesub_unit = ""
            _tagid = ""
            _UserID = Nothing
            _Code_UserName = Nothing
            _Checked = False

            _Type3Name = Nothing

            _Q_Total = 0
            _Q_SubTotal = 0

            _HKDRate = 0

        End Sub
        ''' <summary>
        ''' 匯率
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property HKDRate() As Double
            Get
                Return _HKDRate
            End Get
            Set(ByVal value As Double)
                _HKDRate = value
            End Set
        End Property

        ''' <summary>
        '''  序號。增加排序功能 2012-5-16
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_XH() As Integer
            Get
                Return _Q_XH
            End Get
            Set(ByVal value As Integer)
                _Q_XH = value
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

        ''' <summary>
        ''' 報價單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_QuoID() As String
            Get
                Return _Q_QuoID
            End Get
            Set(ByVal value As String)
                _Q_QuoID = value
            End Set
        End Property

        ''' <summary>
        ''' 物料編碼
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' 
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property

        ''' <summary>
        ''' 物料名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Name() As String
            Get
                Return _M_Name
            End Get
            Set(ByVal value As String)
                _M_Name = value
            End Set
        End Property

        ''' <summary>
        ''' 物料規格
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Gauge() As String
            Get
                Return _M_Gauge
            End Get
            Set(ByVal value As String)
                _M_Gauge = value
            End Set
        End Property

        ''' <summary>
        ''' 物料單位
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
            End Set
        End Property

        ''' <summary>
        ''' 供應商
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_Supplier() As String
            Get
                Return _Q_Supplier
            End Get
            Set(ByVal value As String)
                _Q_Supplier = value
            End Set
        End Property

        ''' <summary>
        ''' 供應商編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_SupplierNo() As String
            Get
                Return _Q_SupplierNo
            End Get
            Set(ByVal value As String)
                _Q_SupplierNo = value
            End Set
        End Property
        ''' <summary>
        ''' 報價單類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_Type() As String
            Get
                Return _Q_Type
            End Get
            Set(ByVal value As String)
                _Q_Type = value
            End Set
        End Property
        ''' <summary>
        ''' 單價
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_Price() As Double
            Get
                Return _Q_Price
            End Get
            Set(ByVal value As Double)
                _Q_Price = value
            End Set
        End Property

        ''' <summary>
        ''' 幣別
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_Currency() As String
            Get
                Return _Q_Currency
            End Get
            Set(ByVal value As String)
                _Q_Currency = value
            End Set
        End Property

        ''' <summary>
        ''' 報價日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_AddDate() As Date
            Get
                Return _Q_AddDate
            End Get
            Set(ByVal value As Date)
                _Q_AddDate = value
            End Set
        End Property

        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_EditDate() As Date
            Get
                Return _Q_EditDate
            End Get
            Set(ByVal value As Date)
                _Q_EditDate = value
            End Set
        End Property

        ''' <summary>
        ''' 聯系人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_Associate() As String
            Get
                Return _Q_Associate
            End Get
            Set(ByVal value As String)
                _Q_Associate = value
            End Set
        End Property

        ''' <summary>
        ''' 版本
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_Edition() As Integer
            Get
                Return _Q_Edition
            End Get
            Set(ByVal value As Integer)
                _Q_Edition = value
            End Set
        End Property

        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_Check() As Boolean
            Get
                Return _Q_Check
            End Get
            Set(ByVal value As Boolean)
                _Q_Check = value
            End Set
        End Property

        ''' <summary>
        ''' 審核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_CheckAction() As String
            Get
                Return _Q_CheckAction
            End Get
            Set(ByVal value As String)
                _Q_CheckAction = value
            End Set
        End Property
        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_CheckDate() As Date
            Get
                Return _Q_CheckDate
            End Get
            Set(ByVal value As Date)
                _Q_CheckDate = value
            End Set
        End Property

        ''' <summary>
        ''' 審核備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_CheckRemark() As String
            Get
                Return _Q_CheckRemark
            End Get
            Set(ByVal value As String)
                _Q_CheckRemark = value
            End Set
        End Property

        ''' <summary>
        ''' 審核類別
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_CheckType() As String
            Get
                Return _Q_CheckType
            End Get
            Set(ByVal value As String)
                _Q_CheckType = value
            End Set
        End Property

        ''' <summary>
        ''' 會計部審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_AccCheck() As Boolean
            Get
                Return _Q_AccCheck
            End Get
            Set(ByVal value As Boolean)
                _Q_AccCheck = value
            End Set
        End Property

        ''' <summary>
        ''' 會計部審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_AccCheckDate() As Date
            Get
                Return _Q_AccCheckDate
            End Get
            Set(ByVal value As Date)
                _Q_AccCheckDate = value
            End Set
        End Property

        ''' <summary>
        ''' 會計部審核備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_AccCheckRemark() As String
            Get
                Return _Q_AccCheckRemark
            End Get
            Set(ByVal value As String)
                _Q_AccCheckRemark = value
            End Set
        End Property

        ''' <summary>
        ''' 會計部審核類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_AccCheckType() As String
            Get
                Return _Q_AccCheckType
            End Get
            Set(ByVal value As String)
                _Q_AccCheckType = value
            End Set
        End Property

        ''' <summary>
        ''' 會計部審核人員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_AccCheckAction() As String
            Get
                Return _Q_AccCheckAction
            End Get
            Set(ByVal value As String)
                _Q_AccCheckAction = value
            End Set
        End Property


        ''' <summary>
        ''' 報價員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_Action() As String
            Get
                Return _Q_Action
            End Get
            Set(ByVal value As String)
                _Q_Action = value
            End Set
        End Property

        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_Remark() As String
            Get
                Return _Q_Remark
            End Get
            Set(ByVal value As String)
                _Q_Remark = value
            End Set
        End Property


        ''' <summary>
        ''' 交貨期限
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_RetrDate() As String
            Get
                Return _Q_RetrDate
            End Get
            Set(ByVal value As String)
                _Q_RetrDate = value
            End Set
        End Property

        ''' <summary>
        ''' 公司代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_ID() As String
            Get
                Return _CO_ID
            End Get
            Set(ByVal value As String)
                _CO_ID = value
            End Set
        End Property

        ''' <summary>
        ''' 訂貨數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_Qty() As Double
            Get
                Return _Q_Qty
            End Get
            Set(ByVal value As Double)
                _Q_Qty = value
            End Set
        End Property

        ''' <summary>
        ''' 要求描述
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_Depict() As String
            Get
                Return _Q_Depict
            End Get
            Set(ByVal value As String)
                _Q_Depict = value
            End Set
        End Property

        ''' <summary>
        ''' 申購單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PN_NO() As String
            Get
                Return _PN_NO
            End Get
            Set(ByVal value As String)
                _PN_NO = value
            End Set
        End Property

        ''' <summary>
        ''' 會計審核人名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_AccCheckActionName() As String
            Get
                Return _Q_AccCheckActionName
            End Get
            Set(ByVal value As String)
                _Q_AccCheckActionName = value
            End Set
        End Property

        ''' <summary>
        ''' 審核人名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_CheckActionName() As String
            Get
                Return _Q_CheckActionName
            End Get
            Set(ByVal value As String)
                _Q_CheckActionName = value
            End Set
        End Property

        ''' <summary>
        ''' 報價人名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_ActionName() As String
            Get
                Return _Q_ActionName
            End Get
            Set(ByVal value As String)
                _Q_ActionName = value
            End Set
        End Property

        ''' <summary>
        ''' 供應商名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_SupplierName() As String
            Get
                Return _Q_SupplierName
            End Get
            Set(ByVal value As String)
                _Q_SupplierName = value
            End Set
        End Property

        ''' <summary>
        ''' 品牌
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_Brand() As String
            Get
                Return _Q_Brand
            End Get
            Set(ByVal value As String)
                _Q_Brand = value
            End Set
        End Property


        ''' <summary>
        ''' 產地
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_Origine() As String
            Get
                Return _Q_Origine
            End Get
            Set(ByVal value As String)
                _Q_Origine = value
            End Set
        End Property


        ''' <summary>
        ''' 最小包裝
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_StandardPack() As String
            Get
                Return _Q_StandardPack
            End Get
            Set(ByVal value As String)
                _Q_StandardPack = value
            End Set
        End Property

        ''' <summary>
        ''' 最小訂購數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_MOQ() As String
            Get
                Return _Q_MOQ
            End Get
            Set(ByVal value As String)
                _Q_MOQ = value
            End Set
        End Property


        ''' <summary>
        ''' 生產周期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_ProductionCycle() As String
            Get
                Return _Q_ProductionCycle
            End Get
            Set(ByVal value As String)
                _Q_ProductionCycle = value
            End Set
        End Property

        ''' <summary>
        ''' 送貨周期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_DeliveredCycle() As String
            Get
                Return _Q_DeliveredCycle
            End Get
            Set(ByVal value As String)
                _Q_DeliveredCycle = value
            End Set
        End Property


        ''' <summary>
        ''' 送貨地址
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_DeliveredAddress() As String
            Get
                Return _Q_DeliveredAddress
            End Get
            Set(ByVal value As String)
                _Q_DeliveredAddress = value
            End Set
        End Property


        ''' <summary>
        ''' 匯率
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_ExchangeRate() As String
            Get
                Return _Q_ExchangeRate
            End Get
            Set(ByVal value As String)
                _Q_ExchangeRate = value
            End Set
        End Property

        ''' <summary>
        ''' 報價有效期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_Validity() As String
            Get
                Return _Q_Validity
            End Get
            Set(ByVal value As String)
                _Q_Validity = value
            End Set
        End Property

        ''' <summary>
        ''' 模具費用
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_MoldExpense() As String
            Get
                Return _Q_MoldExpense
            End Get
            Set(ByVal value As String)
                _Q_MoldExpense = value
            End Set
        End Property

        ''' <summary>
        ''' 價格類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_PriceType() As String
            Get
                Return _Q_PriceType
            End Get
            Set(ByVal value As String)
                _Q_PriceType = value
            End Set
        End Property

        ''' <summary>
        ''' 結款方式
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_ToForm() As String
            Get
                Return _Q_ToForm
            End Get
            Set(ByVal value As String)
                _Q_ToForm = value
            End Set
        End Property

        ''' <summary>
        ''' 稅率
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Q_Tarriff() As Single
            Get
                Return _Q_Tarriff
            End Get
            Set(ByVal value As Single)
                _Q_Tarriff = value
            End Set
        End Property

        '--------------------------------------------報價範圍關聯管理
        Public Property CodeMain() As String
            Get
                Return _codemain
            End Get
            Set(ByVal value As String)
                _codemain = value
            End Set
        End Property
        Public Property CodeSub() As String
            Get
                Return _codesub
            End Get
            Set(ByVal value As String)
                _codesub = value
            End Set
        End Property
        Public Property CodeMain_Name() As String
            Get
                Return _codemain_name
            End Get
            Set(ByVal value As String)
                _codemain_name = value
            End Set
        End Property
        Public Property CodeMain_Gauge() As String
            Get
                Return _codemain_gauge
            End Get
            Set(ByVal value As String)
                _codemain_gauge = value
            End Set
        End Property
        Public Property CodeMain_Unit() As String
            Get
                Return _codemain_unit
            End Get
            Set(ByVal value As String)
                _codemain_unit = value
            End Set
        End Property
        Public Property CodeSub_Name() As String
            Get
                Return _codesub_name
            End Get
            Set(ByVal value As String)
                _codesub_name = value
            End Set
        End Property
        Public Property CodeSub_Gauge() As String
            Get
                Return _codesub_gauge
            End Get
            Set(ByVal value As String)
                _codesub_gauge = value
            End Set
        End Property
        Public Property CodeSub_Unit() As String
            Get
                Return _codesub_unit
            End Get
            Set(ByVal value As String)
                _codesub_unit = value
            End Set
        End Property
        Public Property TagID() As String
            Get
                Return _tagid
            End Get
            Set(ByVal value As String)
                _tagid = value
            End Set
        End Property

        Public Property UserID() As String
            Get
                Return _UserID
            End Get
            Set(ByVal value As String)
                _UserID = value
            End Set
        End Property

        Public Property Code_UserName() As String
            Get
                Return _Code_UserName
            End Get
            Set(ByVal value As String)
                _Code_UserName = value
            End Set
        End Property
        Public Property QuotationID() As String
            Get
                Return _QuotationID
            End Get
            Set(ByVal value As String)
                _QuotationID = value
            End Set
        End Property
        Public Property Checked() As Boolean
            Get
                Return _Checked
            End Get
            Set(ByVal value As Boolean)
                _Checked = value
            End Set
        End Property

        Public Property Q_Total() As Single
            Get
                Return _Q_Total
            End Get
            Set(ByVal value As Single)
                _Q_Total = value
            End Set
        End Property
        Public Property Q_SubTotal() As Single
            Get
                Return _Q_SubTotal
            End Get
            Set(ByVal value As Single)
                _Q_SubTotal = value
            End Set
        End Property
        Public Property Type3Name() As String
            Get
                Return _Type3Name
            End Get
            Set(ByVal value As String)
                _Type3Name = value
            End Set
        End Property

    End Class
End Namespace

