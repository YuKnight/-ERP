
Namespace LFERP.Library.ProductionField

    Public Class ProductionFieldInfo

        Private _AutoID As Integer
        Private _FP_NO As String
        Private _FP_Num As String
        private _Pro_Type as String 
        Private _PM_M_Code As String
        Private _PM_Type As String

        Private _Pro_Type1 As String
        Private _PM_M_Code1 As String
        Private _PM_Type1 As String

        Private _Pro_NO As String
        Private _Pro_NO1 As String

        'Private _M_Code As String
        Private _Pro_M_NO As String   '發料工序單號
        Private _PS_Num As Integer    '發料工序次序
        Private _FP_Qty As Integer

        Private _FP_Weight As Single  '每次收發物料重量 當備註使用以數量為準

        Private _FP_Date As Date
        Private _FP_Type As String
        Private _FP_InDep As String
        Private _FP_OutDep As String
        Private _FP_Detail As String
        Private _FP_InAction As String
        Private _FP_OutAction As String
        Private _FP_InCheck As Boolean
        Private _FP_Check As Boolean
        Private _FP_CheckAction As String
        Private _FP_Remark As String
        Private _FP_CheckRemark As String

        Private _FP_InCheckDate As Date '確認時間
        Private _FP_InCheckDates As String '確認時間
        Private _FP_EndQty As Decimal  '當前大貨結餘數
        Private _FP_EndReQty As Decimal  '當前返修結餘數

        Private _PS_Num1 As Integer    '收料工序次序

        Private _FP_OutActionName As String
        Private _FP_InActionName As String
        Private _FP_CheckActionName As String
        Private _PS_Name As String  '發料工序名稱


        Private _PH_ID As String
        Private _M_Code As String
        Private _PI_Qty As Integer

        Private _FacOutName As String '發料廠別名稱
        Private _FacInName As String  '收料廠別名稱
        Private _DepOutName As String  '發料部門名稱
        Private _DepInName As String   '收料部門名稱
        Private _PS_Name1 As String    '收料工序名稱
        Private _PT_Type As String  '物料收發屬性

        Private _FP_SendType As String  '物料發送類型 (正常/組合)
        Private _FP_Qty1 As Single     '組合數量
        Private _OW_NO As String     '外發單號 --自動生產
        Private _IW_NO As String    '外發送回單號--聯豐提供(聯豐生產單號)

        Private _FP_SubtractReQty As Boolean    '記錄是否要扣返修數
        Private _CardID As String   '標記實際刷卡人ID
        Private _FP_OutType As String   '外發類型
        Private _FP_OutOK As Boolean    '@ 2012/7/12 記錄是否確認發出
        Private _PB_ID As String            '不良原因編號
        Private _PB_Cause As String       '不良原因
        Private _BadnessQty As Integer  '不良數量
        Private _Remark As String          '不良原因備注


        Private _PM_JiYu As String

        ''-----------留辦-加存相關
        Private _LBFP_NO As String
        Private _LBQty As Int32
        Private _JCFP_NO As String
        Private _JCQty As Int32
        Private _JCLBCheck As Boolean
        Private _ReturnQty As Int32

        '2014-03-11 姚駿
        Private _FP_Balance As Double
        Private _M_Name As String
        Private _M_Gauge As String

        Private _ShouRu As Double
        Private _FaChu As Double
        Private _ShunHuai As Double
        Private _YesterdayQty As Double
        Private _DayQty As Double
        Private _PM_Date As String

        Private _NowQty As Double

        Private _FP_QtyS As Int64




        Sub New()

            _PM_JiYu = Nothing

            _AutoID = 0
            _FP_NO = Nothing
            _FP_Num = Nothing
            _Pro_NO = Nothing
            _Pro_NO1 = Nothing
            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing

            _Pro_Type1 = Nothing  '收料工藝類型
            _PM_M_Code1 = Nothing  '收料產品編號    主要針對正常物料收發
            _PM_Type1 = Nothing  '收料類型


            _Pro_M_NO = Nothing
            _PS_Num = 0
            _FP_Qty = 0
            _FP_Weight = 0
            _FP_Date = Nothing
            _FP_Type = Nothing
            _FP_InDep = Nothing
            _FP_OutDep = Nothing
            _FP_Detail = Nothing
            _FP_InAction = Nothing
            _FP_OutAction = Nothing
            _FP_InCheck = False
            _FP_Check = False
            _FP_CheckAction = Nothing
            _FP_Remark = Nothing
            _FP_CheckRemark = Nothing

            _FP_InCheckDate = Nothing
            _FP_InCheckDates = ""
            _FP_EndQty = 0
            _FP_EndReQty = 0

            _PS_Num1 = 0

            _FP_OutActionName = Nothing
            _FP_InActionName = Nothing
            _FP_CheckActionName = Nothing
            _PS_Name = Nothing

            _PH_ID = Nothing
            _M_Code = Nothing
            _PI_Qty = 0

            _FacOutName = Nothing
            _FacInName = Nothing
            _DepOutName = Nothing
            _DepInName = Nothing
            _PS_Name1 = Nothing
            _PT_Type = Nothing

            _FP_SendType = Nothing
            _FP_Qty1 = 0
            _OW_NO = Nothing
            _IW_NO = Nothing

            _FP_SubtractReQty = False
            _CardID = Nothing
            _FP_OutType = Nothing
            _FP_OutOK = False

            _PB_ID = Nothing
            _PB_Cause = Nothing
            _BadnessQty = 0
            _Remark = Nothing

            ''-----------留辦-加存相關
            _LBFP_NO = Nothing
            _LBQty = 0
            _JCFP_NO = Nothing
            _JCQty = 0
            _JCLBCheck = False
            _ReturnQty = 0


            '2014-03-11 姚駿
            _FP_Balance = 0
            _M_Name = Nothing
            _M_Gauge = Nothing
            _PM_Date = Nothing

            _ShouRu = 0
            _FaChu = 0
            _ShunHuai = 0
            _YesterdayQty = 0
            _DayQty = 0

            _NowQty = 0
            _FP_QtyS = 0


        End Sub

        Public Property FP_QtyS() As Double
            Get
                Return _FP_QtyS
            End Get
            Set(ByVal value As Double)
                _FP_QtyS = value
            End Set
        End Property

        Public Property NowQty() As Double
            Get
                Return _NowQty
            End Get
            Set(ByVal value As Double)
                _NowQty = value
            End Set
        End Property


        '2014-03-11 姚駿
        ''' <summary>
        ''' 日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Date() As String
            Get
                Return _PM_Date
            End Get
            Set(ByVal value As String)
                _PM_Date = value
            End Set
        End Property

        ''' <summary>
        ''' 規格
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
        ''' 損壞
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ShunHuai() As Double
            Get
                Return _ShunHuai
            End Get
            Set(ByVal value As Double)
                _ShunHuai = value
            End Set
        End Property
        ''' <summary>
        ''' 上日結餘
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property YesterdayQty() As Double
            Get
                Return _YesterdayQty
            End Get
            Set(ByVal value As Double)
                _YesterdayQty = value
            End Set
        End Property

        ''' <summary>
        ''' 當日結餘
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DayQty() As Double
            Get
                Return _DayQty
            End Get
            Set(ByVal value As Double)
                _DayQty = value
            End Set
        End Property

        ''' <summary>
        ''' 收入
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ShouRu() As Double
            Get
                Return _ShouRu
            End Get
            Set(ByVal value As Double)
                _ShouRu = value
            End Set
        End Property

        ''' <summary>
        ''' 發出
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FaChu() As Double
            Get
                Return _FaChu
            End Get
            Set(ByVal value As Double)
                _FaChu = value
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
        ''' 結餘
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FP_Balance() As Double
            Get
                Return _FP_Balance
            End Get
            Set(ByVal value As Double)
                _FP_Balance = value
            End Set
        End Property

  

        Public Property LBFP_NO() As String
            Get
                Return _LBFP_NO
            End Get
            Set(ByVal value As String)
                _LBFP_NO = value
            End Set
        End Property

        Public Property LBQty() As Int32
            Get
                Return _LBQty
            End Get
            Set(ByVal value As Int32)
                _LBQty = value
            End Set
        End Property

        Public Property JCFP_NO() As String
            Get
                Return _JCFP_NO
            End Get
            Set(ByVal value As String)
                _JCFP_NO = value
            End Set
        End Property

        Public Property JCQty() As Int32
            Get
                Return _JCQty
            End Get
            Set(ByVal value As Int32)
                _JCQty = value
            End Set
        End Property

        Public Property JCLBCheck() As Boolean
            Get
                Return _JCLBCheck
            End Get
            Set(ByVal value As Boolean)
                _JCLBCheck = value
            End Set
        End Property

        Public Property ReturnQty() As Int32
            Get
                Return _ReturnQty
            End Get
            Set(ByVal value As Int32)
                _ReturnQty = value
            End Set
        End Property

        '--------------------------------------------------------------------------------------
        '--------------------------------------------------------------------------------------



        ''
        Public Property PM_JiYu() As String
            Get
                Return _PM_JiYu
            End Get
            Set(ByVal value As String)
                _PM_JiYu = value
            End Set
        End Property


        Public Property AutoID() As Integer
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Integer)
                _AutoID = value
            End Set
        End Property
        Public Property FP_NO() As String
            Get
                Return _FP_NO
            End Get
            Set(ByVal value As String)
                _FP_NO = value
            End Set
        End Property
        Public Property FP_Num() As String
            Get
                Return _FP_Num
            End Get
            Set(ByVal value As String)
                _FP_Num = value
            End Set
        End Property

        Public Property Pro_NO() As String
            Get
                Return _Pro_NO
            End Get
            Set(ByVal value As String)
                _Pro_NO = value
            End Set
        End Property

        Public Property Pro_NO1() As String
            Get
                Return _Pro_NO1
            End Get
            Set(ByVal value As String)
                _Pro_NO1 = value
            End Set
        End Property
        Public Property Pro_Type() As String
            Get
                Return _Pro_Type
            End Get
            Set(ByVal value As String)
                _Pro_Type = value
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
        Public Property PM_Type() As String
            Get
                Return _PM_Type
            End Get
            Set(ByVal value As String)
                _PM_Type = value
            End Set
        End Property
        Public Property Pro_Type1() As String
            Get
                Return _Pro_Type1
            End Get
            Set(ByVal value As String)
                _Pro_Type1 = value
            End Set
        End Property
        Public Property PM_M_Code1() As String
            Get
                Return _PM_M_Code1
            End Get
            Set(ByVal value As String)
                _PM_M_Code1 = value
            End Set
        End Property
        Public Property PM_Type1() As String
            Get
                Return _PM_Type1
            End Get
            Set(ByVal value As String)
                _PM_Type1 = value
            End Set
        End Property
        Public Property Pro_M_NO() As String
            Get
                Return _Pro_M_NO
            End Get
            Set(ByVal value As String)
                _Pro_M_NO = value
            End Set
        End Property
        Public Property PS_Num() As Integer
            Get
                Return _PS_Num
            End Get
            Set(ByVal value As Integer)
                _PS_Num = value
            End Set
        End Property
        Public Property FP_Qty() As Integer
            Get
                Return _FP_Qty
            End Get
            Set(ByVal value As Integer)
                _FP_Qty = value
            End Set
        End Property
        Public Property FP_Date() As Date
            Get
                Return _FP_Date
            End Get
            Set(ByVal value As Date)
                _FP_Date = value
            End Set
        End Property
        Public Property FP_Type() As String
            Get
                Return _FP_Type
            End Get
            Set(ByVal value As String)
                _FP_Type = value
            End Set
        End Property
        Public Property FP_InDep() As String
            Get
                Return _FP_InDep
            End Get
            Set(ByVal value As String)
                _FP_InDep = value
            End Set
        End Property
        Public Property FP_OutDep() As String
            Get
                Return _FP_OutDep
            End Get
            Set(ByVal value As String)
                _FP_OutDep = value
            End Set
        End Property
        Public Property FP_Detail() As String
            Get
                Return _FP_Detail
            End Get
            Set(ByVal value As String)
                _FP_Detail = value
            End Set
        End Property
        Public Property FP_InAction() As String
            Get
                Return _FP_InAction
            End Get
            Set(ByVal value As String)
                _FP_InAction = value
            End Set
        End Property
        Public Property FP_OutAction() As String
            Get
                Return _FP_OutAction
            End Get
            Set(ByVal value As String)
                _FP_OutAction = value
            End Set
        End Property
        Public Property FP_InCheck() As Boolean
            Get
                Return _FP_InCheck
            End Get
            Set(ByVal value As Boolean)
                _FP_InCheck = value
            End Set
        End Property
        Public Property FP_Check() As Boolean
            Get
                Return _FP_Check
            End Get
            Set(ByVal value As Boolean)
                _FP_Check = value
            End Set
        End Property
        Public Property FP_CheckAction() As String
            Get
                Return _FP_CheckAction
            End Get
            Set(ByVal value As String)
                _FP_CheckAction = value
            End Set
        End Property
        Public Property FP_Remark() As String
            Get
                Return _FP_Remark
            End Get
            Set(ByVal value As String)
                _FP_Remark = value
            End Set
        End Property

        Public Property FP_InActionName() As String
            Get
                Return _FP_InActionName
            End Get
            Set(ByVal value As String)
                _FP_InActionName = value
            End Set
        End Property
        Public Property FP_OutActionName() As String
            Get
                Return _FP_OutActionName
            End Get
            Set(ByVal value As String)
                _FP_OutActionName = value
            End Set
        End Property
        Public Property FP_CheckActionName() As String
            Get
                Return _FP_CheckActionName
            End Get
            Set(ByVal value As String)
                _FP_CheckActionName = value
            End Set
        End Property

        Public Property PS_Num1() As Integer
            Get
                Return _PS_Num1
            End Get
            Set(ByVal value As Integer)
                _PS_Num1 = value
            End Set
        End Property

        Public Property FP_CheckRemark() As String
            Get
                Return _FP_CheckRemark
            End Get
            Set(ByVal value As String)
                _FP_CheckRemark = value
            End Set
        End Property

        Public Property PH_ID() As String
            Get
                Return _PH_ID
            End Get
            Set(ByVal value As String)
                _PH_ID = value
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
        Public Property PI_Qty() As Integer
            Get
                Return _PI_Qty
            End Get
            Set(ByVal value As Integer)
                _PI_Qty = value
            End Set
        End Property

        Public Property PS_Name() As String   '工序名稱
            Get
                Return _PS_Name
            End Get
            Set(ByVal value As String)
                _PS_Name = value
            End Set
        End Property
        Public Property FacOutName() As String
            Get
                Return _FacOutName
            End Get
            Set(ByVal value As String)
                _FacOutName = value
            End Set
        End Property
        Public Property FacInName() As String
            Get
                Return _FacInName
            End Get
            Set(ByVal value As String)
                _FacInName = value
            End Set
        End Property
        Public Property DepOutName() As String
            Get
                Return _DepOutName
            End Get
            Set(ByVal value As String)
                _DepOutName = value
            End Set
        End Property
        Public Property DepInName() As String
            Get
                Return _DepInName
            End Get
            Set(ByVal value As String)
                _DepInName = value
            End Set
        End Property
        Public Property PS_Name1() As String
            Get
                Return _PS_Name1
            End Get
            Set(ByVal value As String)
                _PS_Name1 = value
            End Set
        End Property
        Public Property PT_Type() As String
            Get
                Return _PT_Type
            End Get
            Set(ByVal value As String)
                _PT_Type = value
            End Set
        End Property
        Public Property FP_Weight() As Single
            Get
                Return _FP_Weight
            End Get
            Set(ByVal value As Single)
                _FP_Weight = value
            End Set
        End Property
        Public Property FP_SendType() As String
            Get
                Return _FP_SendType
            End Get
            Set(ByVal value As String)
                _FP_SendType = value
            End Set
        End Property
        Public Property FP_Qty1() As Single
            Get
                Return _FP_Qty1
            End Get
            Set(ByVal value As Single)
                _FP_Qty1 = value
            End Set
        End Property
        Public Property OW_NO() As String
            Get
                Return _OW_NO
            End Get
            Set(ByVal value As String)
                _OW_NO = value
            End Set
        End Property
        Public Property IW_NO() As String
            Get
                Return _IW_NO
            End Get
            Set(ByVal value As String)
                _IW_NO = value
            End Set
        End Property
        Public Property FP_InCheckDate() As Date
            Get
                Return _FP_InCheckDate
            End Get
            Set(ByVal value As Date)
                _FP_InCheckDate = value
            End Set
        End Property
        Public Property FP_InCheckDates() As String
            Get
                Return _FP_InCheckDates
            End Get
            Set(ByVal value As String)
                _FP_InCheckDates = value
            End Set
        End Property

        Public Property FP_EndQty() As Single
            Get
                Return _FP_EndQty
            End Get
            Set(ByVal value As Single)
                _FP_EndQty = value
            End Set
        End Property
        Public Property FP_EndReQty() As Single
            Get
                Return _FP_EndReQty
            End Get
            Set(ByVal value As Single)
                _FP_EndReQty = value
            End Set
        End Property
        Public Property FP_SubtractReQty() As Boolean
            Get
                Return _FP_SubtractReQty
            End Get
            Set(ByVal value As Boolean)
                _FP_SubtractReQty = value
            End Set
        End Property
        Public Property CardID() As String
            Get
                Return _CardID
            End Get
            Set(ByVal value As String)
                _CardID = value
            End Set
        End Property
        Public Property FP_OutType() As String
            Get
                Return _FP_OutType
            End Get
            Set(ByVal value As String)
                _FP_OutType = value
            End Set
        End Property

        Public Property FP_OutOK() As Boolean
            Get
                Return _FP_OutOK
            End Get
            Set(ByVal value As Boolean)
                _FP_OutOK = value
            End Set
        End Property

        Public Property PB_ID() As String
            Get
                Return _PB_ID
            End Get
            Set(ByVal value As String)
                _PB_ID = value
            End Set
        End Property

        Public Property PB_Cause() As String
            Get
                Return _PB_Cause
            End Get
            Set(ByVal value As String)
                _PB_Cause = value
            End Set
        End Property

        Public Property BadnessQty() As Integer
            Get
                Return _BadnessQty
            End Get
            Set(ByVal value As Integer)
                _BadnessQty = value
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
    End Class

End Namespace

