Namespace LFERP.Library.Orders
    Public Class OrdersMainInfo
        Private _OM_No As String
        Private _OM_CusterID As String
        Private _OM_ID As String
        Private _OM_Gauge As String
        Private _OM_CusterPO As String
        Private _OM_CusterNO As String
        Private _OM_SendDate As String
        Private _OM_CheckDate As String
        Private _OM_AddDate As String
        Private _OM_EditDate As String
        Private _OM_PoDate As String
        Private _OM_OrderQty As String
        Private _OM_NoMakeQty As String
        Private _OM_NoSendQty As String
        Private _OM_NoOutQty As String
        Private _OM_OrderSpare As String
        Private _OM_CurrencyID As String
        Private _OM_Action As String
        Private _OM_Remark As String
        Private _OM_MakeDetail As String
        Private _CO_ID As String

        Private _OM_Price As Decimal     '訂單單價
        Private _OM_PriceCheck As Boolean  '單價審核
        Private _OM_PriceReCheck As Boolean '單價鎖定
        Private _OM_Check As Boolean    '鎖定整張訂單
        Private _OM_PoDateBegin As String
        Private _OM_PoDateEnd As String
        Private _PM_M_Code As String
        Private _PM_JiYu As String

        Private _M_Gauge As String
        Private _M_Name As String
        Private _OS_BatchID As String
        Private _WI_Qty As Double

        Private _OM_CheckA As Boolean
        Private _OM_CheckADate As Date
        Private _OM_CheckAAction As String
        Private _OM_CheckAActionName As String

        Private _M_Price As Double
        Private _M_Currency As String

        Private _FP_Qty As Int32
        Private _BadQty As Int32
        Private _OW_Qty As Int32
        Private _SumQty As Int32


        '2014-02-20 姚駿--------------------------
        Private _VProWI_Qty As String
        Private _VProWI_ReQty As String
        '-----------------------------------------

        '2014-04-21 釗--------------------------
        Private _FColorPercent As String
        Private _FQianQty As String
        '-----------------------------------------

        Public Sub New()
            _OM_CheckA = False
            _OM_CheckADate = Nothing
            _OM_CheckAAction = Nothing
            _OM_CheckAActionName = Nothing


            _OM_No = ""
            _OM_CusterID = ""
            _OM_ID = ""
            _OM_Gauge = ""
            _OM_CusterPO = ""
            _OM_CusterNO = ""
            _OM_SendDate = Nothing
            _OM_CheckDate = Nothing
            _OM_AddDate = Nothing
            _OM_EditDate = Nothing
            _OM_PoDate = Nothing
            _OM_OrderQty = ""
            _OM_NoMakeQty = ""
            _OM_NoSendQty = ""
            _OM_NoOutQty = ""
            _OM_OrderSpare = ""
            _OM_CurrencyID = ""
            _OM_Action = ""
            _OM_Remark = ""
            _OM_MakeDetail = ""
            _CO_ID = ""

            _OM_Price = 0
            _OM_PriceCheck = False
            _OM_PriceReCheck = False
            _OM_Check = False
            _OM_PoDateBegin = Nothing
            _OM_PoDateEnd = Nothing
            _PM_M_Code = Nothing
            _PM_JiYu = Nothing

            _M_Gauge = Nothing
            _M_Name = Nothing
            _OS_BatchID = Nothing

            _WI_Qty = 0

            _M_Price = 0
            _M_Currency = Nothing

            _FP_Qty = 0
            _BadQty = 0
            _OW_Qty = 0
            _SumQty = 0

            '2014-02-20 姚駿--------------------------
            _VProWI_Qty = Nothing
            _VProWI_ReQty = Nothing
            '-----------------------------------------

            '2014-04-21 釗--------------------------
            _FColorPercent = Nothing
            _FQianQty = Nothing
            '-----------------------------------------

        End Sub

        '2014-02-20 姚駿--------------------------
        Public Property VProWI_Qty() As String
            Get
                Return _VProWI_Qty
            End Get
            Set(ByVal value As String)
                _VProWI_Qty = value
            End Set
        End Property
        Public Property VProWI_ReQty() As String
            Get
                Return _VProWI_ReQty
            End Get
            Set(ByVal value As String)
                _VProWI_ReQty = value
            End Set
        End Property
        '-----------------------------------------


        '2014-04-21 釗--------------------------
        Public Property FColorPercent() As String
            Get
                Return _FColorPercent
            End Get
            Set(ByVal value As String)
                _FColorPercent = value
            End Set
        End Property
        Public Property FQianQty() As String
            Get
                Return _FQianQty
            End Get
            Set(ByVal value As String)
                _FQianQty = value
            End Set
        End Property
        '-----------------------------------------

        Public Property SumQty() As Int32
            Get
                Return _SumQty
            End Get
            Set(ByVal value As Int32)
                _SumQty = value
            End Set
        End Property

        Public Property OW_Qty() As Int32
            Get
                Return _OW_Qty
            End Get
            Set(ByVal value As Int32)
                _OW_Qty = value
            End Set
        End Property

        Public Property BadQty() As Int32
            Get
                Return _BadQty
            End Get
            Set(ByVal value As Int32)
                _BadQty = value
            End Set
        End Property


        Public Property FP_Qty() As Int32
            Get
                Return _FP_Qty
            End Get
            Set(ByVal value As Int32)
                _FP_Qty = value
            End Set
        End Property


        Public Property M_Price() As Double
            Get
                Return _M_Price
            End Get
            Set(ByVal value As Double)
                _M_Price = value
            End Set
        End Property

        Public Property M_Currency() As String
            Get
                Return _M_Currency
            End Get
            Set(ByVal value As String)
                _M_Currency = value
            End Set
        End Property


        Public Property OS_BatchID() As String
            Get
                Return _OS_BatchID
            End Get
            Set(ByVal value As String)
                _OS_BatchID = value
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

        Public Property M_Name() As String
            Get
                Return _M_Name
            End Get
            Set(ByVal value As String)
                _M_Name = value
            End Set
        End Property

        ''' <summary>
        ''' 訂單編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_No() As String
            Get
                Return _OM_No
            End Get
            Set(ByVal value As String)
                _OM_No = value
            End Set
        End Property

        ''' <summary>
        ''' 客戶代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_CusterID() As String
            Get
                Return _OM_CusterID
            End Get
            Set(ByVal value As String)
                _OM_CusterID = value
            End Set
        End Property

        ''' <summary>
        ''' 訂單流水號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_ID() As String
            Get
                Return _OM_ID
            End Get
            Set(ByVal value As String)
                _OM_ID = value
            End Set
        End Property

        ''' <summary>
        ''' 規格描述
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_Gauge() As String
            Get
                Return _OM_Gauge
            End Get
            Set(ByVal value As String)
                _OM_Gauge = value
            End Set
        End Property

        ''' <summary>
        ''' 客戶PO
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_CusterPO() As String
            Get
                Return _OM_CusterPO
            End Get
            Set(ByVal value As String)
                _OM_CusterPO = value
            End Set
        End Property

        ''' <summary>
        ''' 客戶編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_CusterNO() As String
            Get
                Return _OM_CusterNO
            End Get
            Set(ByVal value As String)
                _OM_CusterNO = value
            End Set
        End Property

        ''' <summary>
        ''' 交貨日期 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_SendDate() As String
            Get
                Return _OM_SendDate
            End Get
            Set(ByVal value As String)
                _OM_SendDate = value
            End Set
        End Property

        ''' <summary>
        ''' 驗貨日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_CheckDate() As String
            Get
                Return _OM_CheckDate
            End Get
            Set(ByVal value As String)
                _OM_CheckDate = value
            End Set
        End Property

        ''' <summary>
        ''' 建立日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_AddDate() As String
            Get
                Return _OM_AddDate
            End Get
            Set(ByVal value As String)
                _OM_AddDate = value
            End Set
        End Property

        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_EditDate() As String
            Get
                Return _OM_EditDate
            End Get
            Set(ByVal value As String)
                _OM_EditDate = value
            End Set
        End Property

        ''' <summary>
        ''' PO日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_PoDate() As String
            Get
                Return _OM_PoDate
            End Get
            Set(ByVal value As String)
                _OM_PoDate = value
            End Set
        End Property

        ''' <summary>
        ''' 訂單數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_OrderQty() As String
            Get
                Return _OM_OrderQty
            End Get
            Set(ByVal value As String)
                _OM_OrderQty = value
            End Set
        End Property

        ''' <summary>
        ''' 未生產數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_NoMakeQty() As String
            Get
                Return _OM_NoMakeQty
            End Get
            Set(ByVal value As String)
                _OM_NoMakeQty = value
            End Set
        End Property

        ''' <summary>
        ''' 未交數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_NoSendQty() As String
            Get
                Return _OM_NoSendQty
            End Get
            Set(ByVal value As String)
                _OM_NoSendQty = value
            End Set
        End Property

        ''' <summary>
        ''' 未出廠數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_NoOutQty() As String
            Get
                Return _OM_NoOutQty
            End Get
            Set(ByVal value As String)
                _OM_NoOutQty = value
            End Set
        End Property

        ''' <summary>
        ''' 士啤
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_OrderSpare() As String
            Get
                Return _OM_OrderSpare
            End Get
            Set(ByVal value As String)
                _OM_OrderSpare = value
            End Set
        End Property

        ''' <summary>
        ''' 幣別
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_CurrencyID() As String
            Get
                Return _OM_CurrencyID
            End Get
            Set(ByVal value As String)
                _OM_CurrencyID = value
            End Set
        End Property

        ''' <summary>
        ''' 操作員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_Action() As String
            Get
                Return _OM_Action
            End Get
            Set(ByVal value As String)
                _OM_Action = value
            End Set
        End Property

        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_Remark() As String
            Get
                Return _OM_Remark
            End Get
            Set(ByVal value As String)
                _OM_Remark = value
            End Set
        End Property

        ''' <summary>
        ''' 完成狀況
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_MakeDetail() As String
            Get
                Return _OM_MakeDetail
            End Get
            Set(ByVal value As String)
                _OM_MakeDetail = value
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
        ''' 訂單單價
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_Price() As Decimal
            Get
                Return _OM_Price
            End Get
            Set(ByVal value As Decimal)
                _OM_Price = value
            End Set
        End Property
        Public Property OM_PriceCheck() As Boolean
            Get
                Return _OM_PriceCheck
            End Get
            Set(ByVal value As Boolean)
                _OM_PriceCheck = value
            End Set
        End Property
        Public Property OM_PriceReCheck() As Boolean
            Get
                Return _OM_PriceReCheck
            End Get
            Set(ByVal value As Boolean)
                _OM_PriceReCheck = value
            End Set
        End Property

        Public Property OM_Check() As Boolean
            Get
                Return _OM_Check
            End Get
            Set(ByVal value As Boolean)
                _OM_Check = value
            End Set
        End Property
        Public Property OM_PoDateBegin() As String
            Get
                Return _OM_PoDateBegin
            End Get
            Set(ByVal value As String)
                _OM_PoDateBegin = value
            End Set
        End Property
        Public Property OM_PoDateEnd() As String
            Get
                Return _OM_PoDateEnd
            End Get
            Set(ByVal value As String)
                _OM_PoDateEnd = value
            End Set
        End Property
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
            End Set
        End Property
        Public Property PM_JiYu() As String
            Get
                Return _PM_JiYu
            End Get
            Set(ByVal value As String)
                _PM_JiYu = value
            End Set
        End Property

        Public Property WI_Qty() As Double
            Get
                Return _WI_Qty
            End Get
            Set(ByVal value As Double)
                _WI_Qty = value
            End Set
        End Property

        Public Property OM_CheckA() As Boolean
            Get
                Return _OM_CheckA
            End Get
            Set(ByVal value As Boolean)
                _OM_CheckA = value
            End Set
        End Property

        Public Property OM_CheckADate() As Date
            Get
                Return _OM_CheckADate
            End Get
            Set(ByVal value As Date)
                _OM_CheckADate = value
            End Set
        End Property

        Public Property OM_CheckAAction() As String
            Get
                Return _OM_CheckAAction
            End Get
            Set(ByVal value As String)
                _OM_CheckAAction = value
            End Set
        End Property

        Public Property OM_CheckAActionName() As String
            Get
                Return _OM_CheckAActionName
            End Get
            Set(ByVal value As String)
                _OM_CheckAActionName = value
            End Set
        End Property


    End Class
End Namespace
