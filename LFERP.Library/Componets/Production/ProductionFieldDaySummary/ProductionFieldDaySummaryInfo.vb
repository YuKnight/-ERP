

Namespace LFERP.Library.Production.ProductionFieldDaySummary

    Public Class ProductionFieldDaySummaryInfo

        Private _Pro_Type As String
        Private _PM_M_Code As String
        Private _PM_Type As String
        Private _Pro_NO As String
        Private _FP_OutDep As String

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
        Private _ZuheOut As Integer '組合發出數量

        Private _PM_Date As Date
        Private _Type As String


        Private _FacName As String
        Private _DepName As String
        Private _DepName1 As String
        Private _PS_Name As String
        Private _PS_Num As String
        Private _RemainQty As Integer '大貨結餘數量(從部門庫存表中導入)
        Private _ReturnQty As Integer '返修結餘數據(從部門庫存表中導入)
        Private _TotalQty As Integer  '結餘總數(大貨結餘數量+)
        Private _DayNumber As Integer  '計劃數量
        Private _ActualNumber As Integer


        '--------------------------
        Private _Str1 As Date
        Private _Str2 As Date

        Private _P_ID As String
        Private _WI_Qty As Integer
        Private _WI_ReQty As Integer

        '---------通過計算得來的--------------------

        Private _OutINSum As Double

        Private _InUpdate As Double
        Private _OutUpdate As Double
        '------------對接程序加-------------------------------
        Private _WaiFaASS As Int32
        Private _WareFaLiao As Int32
        Private _ASSBuNiang As Int32

        Private _TuiLiao As Int32


        Sub New()
            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
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

            _PM_Date = Nothing
            _Type = Nothing

            _FacName = Nothing
            _DepName = Nothing
            _DepName1 = Nothing
            _PS_Name = Nothing
            _PS_Num = Nothing
            _RemainQty = 0
            _ReturnQty = 0
            _TotalQty = 0
            _DayNumber = 0
            _ActualNumber = 0
            '------------------------------
            _Str1 = Nothing
            _Str2 = Nothing
            _P_ID = 0
            _WI_ReQty = 0
            _WI_Qty = 0

            _OutINSum = 0

            _OutUpdate = 0
            _InUpdate = 0

            _WaiFaASS = 0
            _WareFaLiao = 0

            _ASSBuNiang = 0
            _TuiLiao = 0

        End Sub

        Public Property TuiLiao() As Int32
            Get
                Return _TuiLiao
            End Get
            Set(ByVal value As Int32)
                _TuiLiao = value
            End Set
        End Property


        Public Property ASSBuNiang() As Int32
            Get
                Return _ASSBuNiang
            End Get
            Set(ByVal value As Int32)
                _ASSBuNiang = value
            End Set
        End Property

        Public Property WaiFaASS() As Int32
            Get
                Return _WaiFaASS
            End Get
            Set(ByVal value As Int32)
                _WaiFaASS = value
            End Set
        End Property

        Public Property WareFaLiao() As Int32
            Get
                Return _WareFaLiao
            End Get
            Set(ByVal value As Int32)
                _WareFaLiao = value
            End Set
        End Property



        Public Property InUpdate() As Double
            Get
                Return _InUpdate
            End Get
            Set(ByVal value As Double)
                _InUpdate = value
            End Set
        End Property


        Public Property OutUpdate() As Double
            Get
                Return _OutUpdate
            End Get
            Set(ByVal value As Double)
                _OutUpdate = value
            End Set
        End Property

        ''_OutINSum

        Public Property OutINSum() As Double
            Get
                Return _OutINSum
            End Get
            Set(ByVal value As Double)
                _OutINSum = value
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

        Public Property PM_Date() As Date
            Get
                Return _PM_Date
            End Get
            Set(ByVal value As Date)
                _PM_Date = value
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
        Public Property FacName() As String
            Get
                Return _FacName
            End Get
            Set(ByVal value As String)
                _FacName = value
            End Set
        End Property
        Public Property DepName() As String
            Get
                Return _DepName
            End Get
            Set(ByVal value As String)
                _DepName = value
            End Set
        End Property
        Public Property DepName1() As String
            Get
                Return _DepName1
            End Get
            Set(ByVal value As String)
                _DepName1 = value
            End Set
        End Property
        Public Property PS_Name() As String
            Get
                Return _PS_Name
            End Get
            Set(ByVal value As String)
                _PS_Name = value
            End Set
        End Property
        Public Property PS_Num() As String
            Get
                Return _PS_Num
            End Get
            Set(ByVal value As String)
                _PS_Num = value
            End Set
        End Property
        Public Property RemainQty() As Integer
            Get
                Return _RemainQty
            End Get
            Set(ByVal value As Integer)
                _RemainQty = value
            End Set
        End Property
        Public Property DayNumber() As Integer
            Get
                Return _DayNumber
            End Get
            Set(ByVal value As Integer)
                _DayNumber = value
            End Set
        End Property
        Public Property ActualNumber() As Integer
            Get
                Return _ActualNumber
            End Get
            Set(ByVal value As Integer)
                _ActualNumber = value
            End Set
        End Property
        '------------------------------------------
        Public Property Str1() As Date
            Get
                Return _Str1
            End Get
            Set(ByVal value As Date)
                _Str1 = value
            End Set
        End Property
        Public Property Str2() As Date
            Get
                Return _Str2
            End Get
            Set(ByVal value As Date)
                _Str2 = value
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
        Public Property ReturnQty() As Integer
            Get
                Return _ReturnQty
            End Get
            Set(ByVal value As Integer)
                _ReturnQty = value
            End Set
        End Property
        Public Property TotalQty() As Integer
            Get
                Return _TotalQty
            End Get
            Set(ByVal value As Integer)
                _TotalQty = value
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
        Public Property ZuheOut() As Integer
            Get
                Return _ZuheOut
            End Get
            Set(ByVal value As Integer)
                _ZuheOut = value
            End Set
        End Property
        Public Property P_ID() As String
            Get
                Return _P_ID
            End Get
            Set(ByVal value As String)
                _P_ID = value
            End Set
        End Property

        Public Property WI_Qty() As Integer
            Get
                Return _WI_Qty
            End Get
            Set(ByVal value As Integer)
                _WI_Qty = value
            End Set
        End Property

        Public Property WI_ReQty() As Integer
            Get
                Return _WI_ReQty
            End Get
            Set(ByVal value As Integer)
                _WI_ReQty = value
            End Set
        End Property

    End Class

End Namespace


