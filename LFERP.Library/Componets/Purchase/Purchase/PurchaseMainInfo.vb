Namespace LFERP.Library.Purchase.Purchase
    Public Class PurchaseMainInfo

        Private _PM_NO As String
        Private _PM_Associate As String
        Private _PM_Tel As String
        Private _PM_Fax As String
        Private _S_Supplier As String
        Private _PM_PurchaseDate As Date
        Private _PM_Remark As String
        Private _PM_Action As String
        Private _PM_ToFrom As String
        Private _PM_ComeType As String
        Private _PM_Rebate As Single
        Private _PM_PurchaseType As String
        Private _PM_Version As Integer
        Private _CO_ID As String
        Private _PM_Check As Boolean
        Private _PM_CheckAction As String
        Private _PM_CheckType As String
        Private _PM_CheckRemark As String
        Private _PM_CheckDate As Date
        Private _PM_AccountCheck As Boolean
        Private _PM_AccountCheckAction As String
        Private _PM_AccountCheckType As String
        Private _PM_AccountCheckRemark As String
        Private _PM_AccountCheckDate As Date

        Private _PM_Type As String   '採購單類型


        Private _PS_NO As String

        Private _Q_QuoID As String
        Private _M_Code As String
        Private _S_SupplierNo As String
        Private _OS_BatchID As String
        Private _M_Unit As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _PN_NO As String
        Private _DPT_ID As String
        Private _U_ID As String
        Private _PS_NeedPurchaseUse As String
        Private _C_ID As String
        Private _PS_QTY As Double
        Private _PS_NoSendQty As Double
        Private _PS_Price As Double
        Private _PS_SendDate As Date
        Private _PS_Depict As String
        Private _PS_Detail As String
        Private _PS_Tarriff As Double
        Private _PS_TffCost As Double
        Private _PS_AmountBf As Double
        Private _PS_AmountAf As Double
        Private _PM_M_Code As String

        Private _PM_AccCheckActionName As String
        Private _PM_CheckActionName As String
        Private _PM_ActionName As String
        Private _S_SupplierName As String
        Private _Type3Name As String
        Private _Type2Name As String
        Private _Type1Name As String
        Private _MaterialTypeID As String
        Private _MaterialTypeName As String
        Private _PM_OS_SendDate As String
        Private _BeginPurchaseDate As String
        Private _EndPurchaseDate As String

        Private _PSs_Date As String
        Private _PSs_Remark As String
        Private _M_BatchID As String


        Private _PM_Date1 As String
        Private _PM_Date2 As String
        Private _PM_U_Name As String '單位名稱
        '----------------------------------------- 更改單中更改採購數
        Private _C_Qty As Single

        Private _HKDRate As Double
        Private _WI_Qty As Double '2013-4-2 顯示當前庫存
        Private _PS_Sum As Double '@2013/4/8 金額

        Public Sub New()
            _PM_NO = Nothing
            _PM_Associate = Nothing
            _S_Supplier = Nothing
            _PM_PurchaseDate = Nothing
            _PM_Remark = Nothing
            _PM_Action = Nothing
            _PM_ToFrom = Nothing
            _PM_ComeType = Nothing
            _PM_Rebate = 0
            _PM_PurchaseType = Nothing
            _PM_Version = Nothing
            _CO_ID = Nothing
            _PM_Check = False
            _PM_CheckAction = Nothing
            _PM_CheckType = Nothing
            _PM_CheckRemark = Nothing
            _PM_CheckDate = Nothing
            _PM_AccountCheck = False
            _PM_AccountCheckAction = Nothing
            _PM_AccountCheckType = Nothing
            _PM_AccountCheckRemark = Nothing
            _PM_AccountCheckDate = Nothing

            _PM_Type = Nothing

            _PS_NO = Nothing

            _Q_QuoID = Nothing
            _M_Code = Nothing
            _S_SupplierNo = Nothing
            _OS_BatchID = Nothing
            _M_Unit = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _PN_NO = Nothing
            _DPT_ID = Nothing
            _U_ID = Nothing
            _PS_NeedPurchaseUse = Nothing
            _C_ID = Nothing
            _PS_QTY = 0
            _PS_NoSendQty = 0
            _PS_Price = 0
            _PS_SendDate = Nothing
            _PS_Depict = Nothing
            _PS_Detail = Nothing
            _PS_Tarriff = 0
            _PS_TffCost = 0
            _PS_AmountBf = 0
            _PS_AmountAf = 0
            _PM_M_Code = Nothing

            _PM_AccCheckActionName = Nothing
            _PM_CheckActionName = Nothing
            _PM_ActionName = Nothing
            _S_SupplierName = Nothing
            _Type3Name = Nothing
            _Type2Name = Nothing
            _Type1Name = Nothing
            _MaterialTypeID = Nothing
            _MaterialTypeName = Nothing
            _PM_OS_SendDate = Nothing
            _BeginPurchaseDate = Nothing
            _EndPurchaseDate = Nothing

            _PSs_Date = Nothing
            _PSs_Remark = Nothing
            _M_BatchID = Nothing

            _PM_Date1 = Nothing
            _PM_Date2 = Nothing
            _PM_U_Name = Nothing
            '--------------------
            _C_Qty = 0

            _HKDRate = 0

            _WI_Qty = 0
            _PS_Sum = 0
        End Sub
        ''' <summary>
        ''' 顯示當前庫存
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WI_Qty() As Double
            Get
                Return _WI_Qty
            End Get
            Set(ByVal value As Double)
                _WI_Qty = value
            End Set
        End Property

        ''' <summary>
        ''' 港幣匯率
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
        ''' 採購單號，唯一
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_NO() As String
            Get
                Return _PM_NO
            End Get
            Set(ByVal value As String)
                _PM_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 聯系人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Associate() As String
            Get
                Return _PM_Associate
            End Get
            Set(ByVal value As String)
                _PM_Associate = value
            End Set
        End Property
        ''' <summary>
        ''' 聯系人電話
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Tel() As String
            Get
                Return _PM_Tel
            End Get
            Set(ByVal value As String)
                _PM_Tel = value
            End Set
        End Property
        ''' <summary>
        ''' 聯系人傳真
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Fax() As String
            Get
                Return _PM_Fax
            End Get
            Set(ByVal value As String)
                _PM_Fax = value
            End Set
        End Property

        ''' <summary>
        ''' 供應商代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Supplier() As String
            Get
                Return _S_Supplier
            End Get
            Set(ByVal value As String)
                _S_Supplier = value
            End Set
        End Property

        ''' <summary>
        ''' 採購日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_PurchaseDate() As Date
            Get
                Return _PM_PurchaseDate
            End Get
            Set(ByVal value As Date)
                _PM_PurchaseDate = value
            End Set
        End Property

        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Property PM_Remark() As String
            Get
                Return _PM_Remark
            End Get
            Set(ByVal value As String)
                _PM_Remark = value
            End Set
        End Property

        ''' <summary>
        ''' 操作員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Action() As String
            Get
                Return _PM_Action
            End Get
            Set(ByVal value As String)
                _PM_Action = value
            End Set
        End Property

        ''' <summary>
        ''' 付款方式
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_ToFrom() As String
            Get
                Return _PM_ToFrom
            End Get
            Set(ByVal value As String)
                _PM_ToFrom = value
            End Set
        End Property

        ''' <summary>
        ''' 送貨方式
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_ComeType() As String
            Get
                Return _PM_ComeType
            End Get
            Set(ByVal value As String)
                _PM_ComeType = value
            End Set
        End Property
        ''' <summary>
        ''' 折扣金額
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Rebate() As Single
            Get
                Return _PM_Rebate
            End Get
            Set(ByVal value As Single)
                _PM_Rebate = value
            End Set
        End Property

        ''' <summary>
        ''' 採購類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_PurchaseType() As String
            Get
                Return _PM_PurchaseType
            End Get
            Set(ByVal value As String)
                _PM_PurchaseType = value
            End Set
        End Property

        ''' <summary>
        ''' 版本
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Version() As Integer
            Get
                Return _PM_Version
            End Get
            Set(ByVal value As Integer)
                _PM_Version = value
            End Set
        End Property

        ''' <summary>
        ''' 公司
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
        ''' 部門審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Check() As Boolean
            Get
                Return _PM_Check
            End Get
            Set(ByVal value As Boolean)
                _PM_Check = value
            End Set
        End Property

        ''' <summary>
        ''' 審核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_CheckAction() As String
            Get
                Return _PM_CheckAction
            End Get
            Set(ByVal value As String)
                _PM_CheckAction = value
            End Set
        End Property


        ''' <summary>
        ''' 審核類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_CheckType() As String
            Get
                Return _PM_CheckType
            End Get
            Set(ByVal value As String)
                _PM_CheckType = value
            End Set
        End Property

        ''' <summary>
        ''' 審核備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_CheckRemark() As String
            Get
                Return _PM_CheckRemark
            End Get
            Set(ByVal value As String)
                _PM_CheckRemark = value
            End Set
        End Property
        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_CheckDate() As Date
            Get
                Return _PM_CheckDate
            End Get
            Set(ByVal value As Date)
                _PM_CheckDate = value
            End Set
        End Property

        ''' <summary>
        ''' 會計審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_AccountCheck() As Boolean
            Get
                Return _PM_AccountCheck
            End Get
            Set(ByVal value As Boolean)
                _PM_AccountCheck = value
            End Set
        End Property
        ''' <summary>
        ''' 會計審核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_AccountCheckAction() As String
            Get
                Return _PM_AccountCheckAction
            End Get
            Set(ByVal value As String)
                _PM_AccountCheckAction = value
            End Set
        End Property

        ''' <summary>
        ''' 會計審核類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_AccountCheckType() As String
            Get
                Return _PM_AccountCheckType
            End Get
            Set(ByVal value As String)
                _PM_AccountCheckType = value
            End Set
        End Property

        ''' <summary>
        ''' 會計審核備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_AccountCheckRemark() As String
            Get
                Return _PM_AccountCheckRemark
            End Get
            Set(ByVal value As String)
                _PM_AccountCheckRemark = value
            End Set
        End Property

        ''' <summary>
        ''' 會計審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_AccountCheckDate() As Date
            Get
                Return _PM_AccountCheckDate
            End Get
            Set(ByVal value As Date)
                _PM_AccountCheckDate = value
            End Set
        End Property
        ''' <summary>
        ''' 採購編號，區別每一張採購單下的每一條小記錄
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_NO() As String
            Get
                Return _PS_NO
            End Get
            Set(ByVal value As String)
                _PS_NO = value
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
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property

        ''' <summary>
        ''' 供應商編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_SupplierNo() As String
            Get
                Return _S_SupplierNo
            End Get
            Set(ByVal value As String)
                _S_SupplierNo = value
            End Set
        End Property

        ''' <summary>
        ''' 批次
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_BatchID() As String
            Get
                Return _OS_BatchID
            End Get
            Set(ByVal value As String)
                _OS_BatchID = value
            End Set
        End Property

        ''' <summary>
        ''' 單位
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
        ''' 申購部門
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DPT_ID() As String
            Get
                Return _DPT_ID
            End Get
            Set(ByVal value As String)
                _DPT_ID = value
            End Set
        End Property


        ''' <summary>
        ''' 申購人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property U_ID() As String
            Get
                Return _U_ID
            End Get
            Set(ByVal value As String)
                _U_ID = value
            End Set
        End Property

        ''' <summary>
        ''' 申購用途
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_NeedPurchaseUse() As String
            Get
                Return _PS_NeedPurchaseUse
            End Get
            Set(ByVal value As String)
                _PS_NeedPurchaseUse = value
            End Set
        End Property

        ''' <summary>
        ''' 幣別
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_ID() As String
            Get
                Return _C_ID
            End Get
            Set(ByVal value As String)
                _C_ID = value
            End Set
        End Property

        ''' <summary>
        ''' 採購數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_QTY() As Double
            Get
                Return _PS_QTY
            End Get
            Set(ByVal value As Double)
                _PS_QTY = value
            End Set
        End Property

        ''' <summary>
        ''' 未交數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_NoSendQty() As Double
            Get
                Return _PS_NoSendQty
            End Get
            Set(ByVal value As Double)
                _PS_NoSendQty = value
            End Set
        End Property

        ''' <summary>
        ''' 單價
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Price() As Double
            Get
                Return _PS_Price
            End Get
            Set(ByVal value As Double)
                _PS_Price = value
            End Set
        End Property

        ''' <summary>
        ''' 交貨日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_SendDate() As Date
            Get
                Return _PS_SendDate
            End Get
            Set(ByVal value As Date)
                _PS_SendDate = value
            End Set
        End Property

        ''' <summary>
        ''' 要求描述
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Depict() As String
            Get
                Return _PS_Depict
            End Get
            Set(ByVal value As String)
                _PS_Depict = value
            End Set
        End Property

        ''' <summary>
        ''' 狀態
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Detail() As String
            Get
                Return _PS_Detail
            End Get
            Set(ByVal value As String)
                _PS_Detail = value
            End Set
        End Property

        ''' <summary>
        ''' 稅率
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Tarriff() As Double
            Get
                Return _PS_Tarriff
            End Get
            Set(ByVal value As Double)
                _PS_Tarriff = value
            End Set
        End Property

        ''' <summary>
        ''' 稅額
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_TffCost() As Double
            Get
                Return _PS_TffCost
            End Get
            Set(ByVal value As Double)
                _PS_TffCost = value
            End Set
        End Property

        ''' <summary>
        ''' 稅前合計
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_AmountBf() As Double
            Get
                Return _PS_AmountBf
            End Get
            Set(ByVal value As Double)
                _PS_AmountBf = value
            End Set
        End Property

        ''' <summary>
        ''' 稅後合計
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_AmountAf() As Double
            Get
                Return _PS_AmountAf
            End Get
            Set(ByVal value As Double)
                _PS_AmountAf = value
            End Set
        End Property
        ''' <summary>
        ''' 產品編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
            End Set
        End Property

        ''' <summary>
        ''' 會計審核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_AccCheckActionName() As String
            Get
                Return _PM_AccCheckActionName
            End Get
            Set(ByVal value As String)
                _PM_AccCheckActionName = value
            End Set
        End Property

        ''' <summary>
        ''' 部門審核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_CheckActionName() As String
            Get
                Return _PM_CheckActionName
            End Get
            Set(ByVal value As String)
                _PM_CheckActionName = value
            End Set
        End Property

        ''' <summary>
        ''' 操作員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_ActionName() As String
            Get
                Return _PM_ActionName
            End Get
            Set(ByVal value As String)
                _PM_ActionName = value
            End Set
        End Property
        ''' <summary>
        ''' 供應商名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_SupplierName() As String
            Get
                Return _S_SupplierName
            End Get
            Set(ByVal value As String)
                _S_SupplierName = value
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

        Public Property Type2Name() As String
            Get
                Return _Type2Name
            End Get
            Set(ByVal value As String)
                _Type2Name = value
            End Set
        End Property
     
        Public Property Type1Name() As String
            Get
                Return _Type1Name
            End Get
            Set(ByVal value As String)
                _Type1Name = value
            End Set
        End Property

        Public Property MaterialTypeID() As String
            Get
                Return _MaterialTypeID
            End Get
            Set(ByVal value As String)
                _MaterialTypeID = value
            End Set
        End Property

        Public Property MaterialTypeName() As String
            Get
                Return _MaterialTypeName
            End Get
            Set(ByVal value As String)
                _MaterialTypeName = value
            End Set
        End Property

        Public Property PM_Type() As String
            Get
                Return _PM_Type
            End Get
            Set(ByVal value As String)
                _PM_Type = value
            End Set
        End Property


        Public Property PM_OS_SendDate() As String
            Get
                Return _PM_OS_SendDate
            End Get
            Set(ByVal value As String)
                _PM_OS_SendDate = value
            End Set
        End Property

        Public Property BeginPurchaseDate() As String
            Get
                Return _BeginPurchaseDate
            End Get
            Set(ByVal value As String)
                _BeginPurchaseDate = value
            End Set
        End Property

        Public Property EndPurchaseDate() As String
            Get
                Return _EndPurchaseDate
            End Get
            Set(ByVal value As String)
                _EndPurchaseDate = value
            End Set
        End Property

        Public Property PSs_Date() As String
            Get
                Return _PSs_Date
            End Get
            Set(ByVal value As String)
                _PSs_Date = value
            End Set
        End Property
        Public Property PSs_Remark() As String
            Get
                Return _PSs_Remark
            End Get
            Set(ByVal value As String)
                _PSs_Remark = value
            End Set
        End Property
     
        Public Property M_BatchID() As String
            Get
                Return _M_BatchID
            End Get
            Set(ByVal value As String)
                _M_BatchID = value
            End Set
        End Property

        Public Property PM_Date1() As String
            Get
                Return _PM_Date1
            End Get
            Set(ByVal value As String)
                _PM_Date1 = value
            End Set
        End Property
        Public Property PM_Date2() As String
            Get
                Return _PM_Date2
            End Get
            Set(ByVal value As String)
                _PM_Date2 = value
            End Set
        End Property
        '--------------------------------------------------------
        Public Property C_Qty() As Double
            Get
                Return _C_Qty
            End Get
            Set(ByVal value As Double)
                _C_Qty = value
            End Set
        End Property


        Public Property PM_U_Name() As String
            Get
                Return _PM_U_Name
            End Get
            Set(ByVal value As String)
                _PM_U_Name = value
            End Set
        End Property

        Public Property PS_Sum() As Double
            Get
                Return _PS_Sum
            End Get
            Set(ByVal value As Double)
                _PS_Sum = value
            End Set
        End Property
    End Class
End Namespace
