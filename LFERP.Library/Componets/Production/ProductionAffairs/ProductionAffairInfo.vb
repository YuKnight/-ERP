Namespace LFERP.Library.Production.ProductionAffair

    Public Class ProductionAffairInfo

        Private _Pro_Type As String
        Private _PM_M_Code As String
        Private _PM_Type As String
        Private _Pro_Type1 As String
        Private _PM_M_Code1 As String
        Private _PM_Type1 As String

        Private _Pro_NO As String '發料工序
        Private _Pro_NO1 As String '收料工序
        Private _FP_OutDep As String '發料部門

        Private _ShouLiao As Integer
        Private _JiaCun As Integer
        Private _QuCun As Integer
        Private _FaLiao As Integer
        Private _CunHuo As Integer
        Private _FanXiuIn As Integer
        Private _FanXiuOut As Integer
        Private _LiuBan As Integer
        Private _SunHuai As Integer
        Private _DiuShi As Integer
        Private _BuNiang As Integer
        Private _CunCang As Integer
        Private _QuCang As Integer
        Private _ChuHuo As Integer  '完工
        Private _WaiFaOut As Integer '外發發出
        Private _WaiFaIn As Integer  '外發收入
        Private _AccIn As Integer  '調賬收入
        Private _AccOut As Integer '調賬發出
        Private _RePairOut As Integer  '補返修發出 (無補返修收入---對應大貨數量)
        Private _ZuheOut As Integer
        Private _TuiLiao As Int32

        Private _ShouLiao1 As Integer
        Private _JiaCun1 As Integer
        Private _QuCun1 As Integer
        Private _FaLiao1 As Integer
        Private _CunHuo1 As Integer
        Private _FanXiuIn1 As Integer
        Private _FanXiuOut1 As Integer
        Private _LiuBan1 As Integer
        Private _SunHuai1 As Integer
        Private _DiuShi1 As Integer
        Private _BuNiang1 As Integer
        Private _CunCang1 As Integer
        Private _QuCang1 As Integer
        Private _ChuHuo1 As Integer  '完工
        Private _WaiFaOut1 As Integer '外發發出
        Private _WaiFaIn1 As Integer  '外發收入
        Private _AccIn1 As Integer  '調賬收入
        Private _AccOut1 As Integer '調賬發出
        Private _RePairOut1 As Integer  '補返修發出 (無補返修收入---對應大貨數量)
        Private _ZuheOut1 As Integer

        Private _TuiLiao1 As Int32


        Private _FP_NO As String  '外發單號
        Private _FP_Type As String '收發類型
        Private _FP_InAction As String '確認人
        Private _FP_InCheck As Boolean '確認審核
        Private _FP_InCheckDate As Date '確認時間
        Private _CardID As String  '刷卡人

        Private _FP_Detail As String '外發屬性
        Private _FP_InDep As String '收料部門
        Private _WI_Qty As Integer '部門大貨結餘
        Private _WI_ReQty As Integer '部門返修結餘
        Private _WI_Qty1 As Integer
        Private _WI_ReQty1 As Integer

        Private _Type As String  '判斷當前盤盈/盤虧狀態(應用於當前生產更改單--對應調賬屬性)

        Private _PM_Date As Date '日期

        Sub New()
            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _Pro_Type1 = Nothing
            _PM_M_Code1 = Nothing
            _PM_Type1 = Nothing

            _Pro_NO = Nothing
            _FP_OutDep = Nothing

            _ShouLiao = 0
            _JiaCun = 0
            _QuCun = 0
            _FaLiao = 0
            _CunHuo = 0
            _FanXiuIn = 0
            _FanXiuOut = 0
            _LiuBan = 0
            _SunHuai = 0
            _DiuShi = 0
            _BuNiang = 0
            _CunCang = 0
            _QuCang = 0
            _ChuHuo = 0
            _WaiFaOut = 0
            _WaiFaIn = 0

            _AccIn = 0
            _AccOut = 0
            _RePairOut = 0
            _ZuheOut = 0

            _ShouLiao1 = 0
            _JiaCun1 = 0
            _QuCun1 = 0
            _FaLiao1 = 0
            _CunHuo1 = 0
            _FanXiuIn1 = 0
            _FanXiuOut1 = 0
            _LiuBan1 = 0
            _SunHuai1 = 0
            _DiuShi1 = 0
            _BuNiang1 = 0
            _CunCang1 = 0
            _QuCang1 = 0
            _ChuHuo1 = 0
            _WaiFaOut1 = 0
            _WaiFaIn1 = 0

            _AccIn1 = 0
            _AccOut1 = 0
            _RePairOut1 = 0
            _ZuheOut1 = 0

            _PM_Date = Nothing
       
            _FP_NO = Nothing
            _FP_Type = Nothing
            _FP_InAction = Nothing
            _FP_InCheck = False
            _FP_InCheckDate = Nothing
            _CardID = Nothing
            _FP_Detail = Nothing
            _FP_InDep = Nothing
            _WI_Qty = 0
            _WI_ReQty = 0

            _TuiLiao = 0
            _TuiLiao1 = 0

        End Sub

        Public Property TuiLiao1() As Int32
            Get
                Return _TuiLiao1
            End Get
            Set(ByVal value As Int32)
                _TuiLiao1 = value
            End Set
        End Property

        Public Property TuiLiao() As Int32
            Get
                Return _TuiLiao
            End Get
            Set(ByVal value As Int32)
                _TuiLiao = value
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

        Public Property Pro_NO() As String
            Get
                Return _Pro_NO
            End Get
            Set(ByVal value As String)
                _Pro_NO = value
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
        Public Property ShouLiao() As Integer
            Get
                Return _ShouLiao
            End Get
            Set(ByVal value As Integer)
                _ShouLiao = value
            End Set
        End Property
        Public Property JiaCun() As Integer
            Get
                Return _JiaCun
            End Get
            Set(ByVal value As Integer)
                _JiaCun = value
            End Set
        End Property
        Public Property QuCun() As Integer
            Get
                Return _QuCun
            End Get
            Set(ByVal value As Integer)
                _QuCun = value
            End Set
        End Property
        Public Property FaLiao() As Integer
            Get
                Return _FaLiao
            End Get
            Set(ByVal value As Integer)
                _FaLiao = value
            End Set
        End Property
        Public Property CunHuo() As Integer
            Get
                Return _CunHuo
            End Get
            Set(ByVal value As Integer)
                _CunHuo = value
            End Set
        End Property
        Public Property FanXiuIn() As Integer
            Get
                Return _FanXiuIn
            End Get
            Set(ByVal value As Integer)
                _FanXiuIn = value
            End Set
        End Property
        Public Property FanXiuOut() As Integer
            Get
                Return _FanXiuOut
            End Get
            Set(ByVal value As Integer)
                _FanXiuOut = value
            End Set
        End Property
        Public Property LiuBan() As Integer
            Get
                Return _LiuBan
            End Get
            Set(ByVal value As Integer)
                _LiuBan = value
            End Set
        End Property
        Public Property SunHuai() As Integer
            Get
                Return _SunHuai
            End Get
            Set(ByVal value As Integer)
                _SunHuai = value
            End Set
        End Property
        Public Property DiuShi() As Integer
            Get
                Return _DiuShi
            End Get
            Set(ByVal value As Integer)
                _DiuShi = value
            End Set
        End Property
        Public Property BuNiang() As Integer
            Get
                Return _BuNiang
            End Get
            Set(ByVal value As Integer)
                _BuNiang = value
            End Set
        End Property
        Public Property CunCang() As Integer
            Get
                Return _CunCang
            End Get
            Set(ByVal value As Integer)
                _CunCang = value
            End Set
        End Property
        Public Property QuCang() As Integer
            Get
                Return _QuCang
            End Get
            Set(ByVal value As Integer)
                _QuCang = value
            End Set
        End Property
        Public Property ChuHuo() As Integer
            Get
                Return _ChuHuo
            End Get
            Set(ByVal value As Integer)
                _ChuHuo = value
            End Set
        End Property
        Public Property WaiFaIn() As Integer
            Get
                Return _WaiFaIn
            End Get
            Set(ByVal value As Integer)
                _WaiFaIn = value
            End Set
        End Property
        Public Property WaiFaOut() As Integer
            Get
                Return _WaiFaOut
            End Get
            Set(ByVal value As Integer)
                _WaiFaOut = value
            End Set
        End Property
        Public Property AccIn() As Integer
            Get
                Return _AccIn
            End Get
            Set(ByVal value As Integer)
                _AccIn = value
            End Set
        End Property
        Public Property AccOut() As Integer
            Get
                Return _AccOut
            End Get
            Set(ByVal value As Integer)
                _AccOut = value
            End Set
        End Property
        Public Property RePairOut() As Integer
            Get
                Return _RePairOut
            End Get
            Set(ByVal value As Integer)
                _RePairOut = value
            End Set
        End Property

        '----------------------------------------------------變更工序處理字段
        Public Property ShouLiao1() As Integer
            Get
                Return _ShouLiao1
            End Get
            Set(ByVal value As Integer)
                _ShouLiao1 = value
            End Set
        End Property
        Public Property JiaCun1() As Integer
            Get
                Return _JiaCun1
            End Get
            Set(ByVal value As Integer)
                _JiaCun1 = value
            End Set
        End Property
        Public Property QuCun1() As Integer
            Get
                Return _QuCun1
            End Get
            Set(ByVal value As Integer)
                _QuCun1 = value
            End Set
        End Property
        Public Property FaLiao1() As Integer
            Get
                Return _FaLiao1
            End Get
            Set(ByVal value As Integer)
                _FaLiao1 = value
            End Set
        End Property
        Public Property CunHuo1() As Integer
            Get
                Return _CunHuo1
            End Get
            Set(ByVal value As Integer)
                _CunHuo1 = value
            End Set
        End Property
        Public Property FanXiuIn1() As Integer
            Get
                Return _FanXiuIn1
            End Get
            Set(ByVal value As Integer)
                _FanXiuIn1 = value
            End Set
        End Property
        Public Property FanXiuOut1() As Integer
            Get
                Return _FanXiuOut1
            End Get
            Set(ByVal value As Integer)
                _FanXiuOut1 = value
            End Set
        End Property
        Public Property LiuBan1() As Integer
            Get
                Return _LiuBan1
            End Get
            Set(ByVal value As Integer)
                _LiuBan1 = value
            End Set
        End Property
        Public Property SunHuai1() As Integer
            Get
                Return _SunHuai1
            End Get
            Set(ByVal value As Integer)
                _SunHuai1 = value
            End Set
        End Property
        Public Property DiuShi1() As Integer
            Get
                Return _DiuShi1
            End Get
            Set(ByVal value As Integer)
                _DiuShi1 = value
            End Set
        End Property
        Public Property BuNiang1() As Integer
            Get
                Return _BuNiang1
            End Get
            Set(ByVal value As Integer)
                _BuNiang1 = value
            End Set
        End Property
        Public Property CunCang1() As Integer
            Get
                Return _CunCang1
            End Get
            Set(ByVal value As Integer)
                _CunCang1 = value
            End Set
        End Property
        Public Property QuCang1() As Integer
            Get
                Return _QuCang1
            End Get
            Set(ByVal value As Integer)
                _QuCang1 = value
            End Set
        End Property
        Public Property ChuHuo1() As Integer
            Get
                Return _ChuHuo1
            End Get
            Set(ByVal value As Integer)
                _ChuHuo1 = value
            End Set
        End Property
        Public Property WaiFaIn1() As Integer
            Get
                Return _WaiFaIn1
            End Get
            Set(ByVal value As Integer)
                _WaiFaIn1 = value
            End Set
        End Property
        Public Property WaiFaOut1() As Integer
            Get
                Return _WaiFaOut1
            End Get
            Set(ByVal value As Integer)
                _WaiFaOut1 = value
            End Set
        End Property
        Public Property AccIn1() As Integer
            Get
                Return _AccIn1
            End Get
            Set(ByVal value As Integer)
                _AccIn1 = value
            End Set
        End Property
        Public Property AccOut1() As Integer
            Get
                Return _AccOut1
            End Get
            Set(ByVal value As Integer)
                _AccOut1 = value
            End Set
        End Property
        Public Property RePairOut1() As Integer
            Get
                Return _RePairOut1
            End Get
            Set(ByVal value As Integer)
                _RePairOut1 = value
            End Set
        End Property

        '----------------------------------------------------

        Public Property PM_Date() As Date
            Get
                Return _PM_Date
            End Get
            Set(ByVal value As Date)
                _PM_Date = value
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
        Public Property FP_Type() As String
            Get
                Return _FP_Type
            End Get
            Set(ByVal value As String)
                _FP_Type = value
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
        Public Property FP_InCheck() As Boolean
            Get
                Return _FP_InCheck
            End Get
            Set(ByVal value As Boolean)
                _FP_InCheck = value
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
        Public Property FP_Detail() As String
            Get
                Return _FP_Detail
            End Get
            Set(ByVal value As String)
                _FP_Detail = value
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
        Public Property WI_Qty() As Single
            Get
                Return _WI_Qty
            End Get
            Set(ByVal value As Single)
                _WI_Qty = value
            End Set
        End Property
        Public Property WI_ReQty() As Single
            Get
                Return _WI_ReQty
            End Get
            Set(ByVal value As Single)
                _WI_ReQty = value
            End Set
        End Property

        Public Property WI_Qty1() As Single
            Get
                Return _WI_Qty1
            End Get
            Set(ByVal value As Single)
                _WI_Qty1 = value
            End Set
        End Property
        Public Property WI_ReQty1() As Single
            Get
                Return _WI_ReQty1
            End Get
            Set(ByVal value As Single)
                _WI_ReQty1 = value
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
        Public Property Type() As String
            Get
                Return _Type
            End Get
            Set(ByVal value As String)
                _Type = value
            End Set
        End Property
        Public Property ZuheOut() As Integer
            Get
                Return _ZuheOut
            End Get
            Set(ByVal value As Integer)
                _ZuheOut = value
            End Set
        End Property
        Public Property ZuheOut1() As Integer
            Get
                Return _ZuheOut1
            End Get
            Set(ByVal value As Integer)
                _ZuheOut1 = value
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

    End Class

End Namespace

