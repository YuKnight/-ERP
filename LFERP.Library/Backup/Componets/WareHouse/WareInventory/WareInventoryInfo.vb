Namespace LFERP.Library.WareHouse.WareInventory
    Public Class WareInventoryInfo
        Private _materialtypeid As String
        Private _materialtypename As String
        Private _type1id As String
        Private _type1name As String
        Private _type2id As String
        Private _type2name As String
        Private _type3id As String
        Private _type3name As String

        Private _m_code As String
        Private _m_name As String
        Private _m_gauge As String
        Private _m_unit As String
        ' Private _m_type As String
        Private _m_price As Double
        Private _m_currency As String
        Private _m_isenabled As Boolean
        Private _m_maker As String
        Private _m_adddate As String
        Private _m_editdate As String
        Private _m_remark As String
        Private _m_accountcheck As Boolean
        Private _inuser As String
        Private _m_issub As Boolean
        Private _m_qty As Integer         '用量,子表中的
        Private _m_supplier As String
        Private _m_supplierno As String
        Private _m_savekucun As String
        Private _u_name As String

        Private _wi_qty As Double

        Private _wh_id As String
        Private _wh_name As String '倉庫名稱
        Private _wh_sname As String '倉庫上級名稱
        Private _wh_allname As String '倉庫全名

        Private _wi_safeqty As Double
        '2014.5.5 新增最大庫存量、需申領量 鄭少釗新增
        Private _wi_maxqty As Double

        Private _Date1 As Date   '停滯物料所有日期
        Private _Date2 As Date

        '------------------------------用於匯總某物料某段日期範圍內的所有入庫,出庫,調撥記錄信息
        Private _InQty As Double
        Private _OutQty As Double
        Private _MVInQty As Double
        Private _MVOutQty As Double

        Private _BeginQty As Double     '期初庫存
        Private _AllInQty As Double     '本期入庫
        Private _AllOutQty As Double    '本期出庫
        Private _BeginDate As String    '收發存匯總日期
        Private _EndDate As String

        '------------------------------
        Private _BackUpTime As Date
        Private _WI_UserID As String
        Private _WI_EditDate As Date

        ''--------
        Private _WIP_ID As String
        Private _WIP_AddDate As String
        Private _WIP_Qty As Double

        Private _MV_NO_OUT As String
        Private _MV_Date_OUT As String
        Private _MV_Qty_OUT As Double

        Private _MV_NO_IN As String
        Private _MV_Date_IN As String
        Private _MV_Qty_IN As Double

        Private _DateOut As String
        Private _DateIn As String
        Private _strTypeIN As String
        Private _strTypeOut As String

        Private _WO_Qty1 As Double         '@ 2012/9/10       出庫數量月匯總
        Private _WO_Qty2 As Double
        Private _WO_Qty3 As Double


        ''------------------------------------------
        Private _SumOut As Double
        Private _SumIN As Double
        Private _QTYStart As Double
        Private _QTYEnd As Double

        Private _NO_ReQty As Double
        Private _PM_JiYu As String


        Private _NGType As String
        Private _NGName As String
        Private _NGMaterial As String
        Private _NGReamrk As String

        Private _WI_SQty As Double
        Private _WI_SReQty As Double

        Private _M_Product As String
        Private _WI_Address As String

        Public Sub New()
            _M_Product = Nothing
            _WI_Address = Nothing

            _WI_SQty = 0
            _WI_SReQty = 0


            _NGType = Nothing
            _NGName = Nothing
            _NGMaterial = Nothing
            _NGReamrk = Nothing


            _DateOut = Nothing
            _DateIn = Nothing
            _strTypeIN = Nothing
            _strTypeOut = Nothing


            _WIP_ID = Nothing
            _WIP_AddDate = Nothing
            _WIP_Qty = 0

            _MV_NO_OUT = Nothing
            _MV_Date_OUT = Nothing
            _MV_Qty_OUT = 0

            _MV_NO_IN = Nothing
            _MV_Date_IN = Nothing
            _MV_Qty_IN = 0


            _materialtypeid = ""
            _materialtypename = ""
            _type1id = ""
            _type1name = ""
            _type2id = ""
            _type2name = ""
            _type3id = ""
            _type3name = ""

            _m_code = Nothing
            _m_name = Nothing
            _m_gauge = Nothing
            _m_unit = Nothing
            _m_price = 0
            _m_currency = Nothing
            _m_isenabled = True
            _m_adddate = Nothing
            _m_editdate = Nothing
            _m_remark = Nothing

            _m_accountcheck = False
            _inuser = Nothing
            _m_issub = False
            _m_qty = 0
            _m_supplier = Nothing
            _m_supplierno = Nothing
            _m_savekucun = Nothing
            _u_name = Nothing

            _wi_qty = 0
            _wh_id = Nothing

            _wh_name = Nothing
            _wh_sname = Nothing
            _wh_allname = Nothing

            _wi_safeqty = 0
            _wi_maxqty = 0

            _Date1 = Nothing
            _Date2 = Nothing
            '---------------------------
            _InQty = 0
            _OutQty = 0
            _MVInQty = 0
            _MVOutQty = 0

            _BeginQty = 0
            _AllInQty = 0
            _AllOutQty = 0
            _BeginDate = Nothing
            _EndDate = Nothing
            '---------------------------
            _BackUpTime = Nothing
            _WI_UserID = Nothing
            _WI_EditDate = Nothing

            _WO_Qty1 = 0
            _WO_Qty2 = 0
            _WO_Qty3 = 0

            ''-------------------------------------
            _SumOut = 0
            _SumIN = 0
            _QTYStart = 0
            _QTYEnd = 0

            _NO_ReQty = 0

            _PM_JiYu = Nothing


        End Sub


        '_WI_SQty = 0
        '_WI_SReQty = 0
        Public Property M_Product() As String
            Get
                Return _M_Product
            End Get
            Set(ByVal value As String)
                _M_Product = value
            End Set
        End Property
        Public Property WI_Address() As String
            Get
                Return _WI_Address
            End Get
            Set(ByVal value As String)
                _WI_Address = value
            End Set
        End Property

        Public Property WI_SQty() As Double
            Get
                Return _WI_SQty
            End Get
            Set(ByVal value As Double)
                _WI_SQty = value
            End Set
        End Property

        Public Property WI_SReQty() As Double
            Get
                Return _WI_SReQty
            End Get
            Set(ByVal value As Double)
                _WI_SReQty = value
            End Set
        End Property



        '
        Public Property NGReamrk() As String
            Get
                Return _NGReamrk
            End Get
            Set(ByVal value As String)
                _NGReamrk = value
            End Set
        End Property

        Public Property NGType() As String
            Get
                Return _NGType
            End Get
            Set(ByVal value As String)
                _NGType = value
            End Set
        End Property


        Public Property NGName() As String
            Get
                Return _NGName
            End Get
            Set(ByVal value As String)
                _NGName = value
            End Set
        End Property


        Public Property NGMaterial() As String
            Get
                Return _NGMaterial
            End Get
            Set(ByVal value As String)
                _NGMaterial = value
            End Set
        End Property



        Public Property NO_ReQty() As Double
            Get
                Return _NO_ReQty
            End Get
            Set(ByVal value As Double)
                _NO_ReQty = value
            End Set
        End Property

        '_strType _strTypeOut

        Public Property strTypeIN() As String
            Get
                Return _strTypeIN
            End Get
            Set(ByVal value As String)
                _strTypeIN = value
            End Set
        End Property

        Public Property strTypeOut() As String
            Get
                Return _strTypeOut
            End Get
            Set(ByVal value As String)
                _strTypeOut = value
            End Set
        End Property
        Public Property DateOut() As String
            Get
                Return _DateOut
            End Get
            Set(ByVal value As String)
                _DateOut = value
            End Set
        End Property

        Public Property DateIn() As String
            Get
                Return _DateIn
            End Get
            Set(ByVal value As String)
                _DateIn = value
            End Set
        End Property

        Public Property WIP_ID() As String
            Get
                Return _WIP_ID
            End Get
            Set(ByVal value As String)
                _WIP_ID = value
            End Set
        End Property

        Public Property WIP_AddDate() As String
            Get
                Return _WIP_AddDate
            End Get
            Set(ByVal value As String)
                _WIP_AddDate = value
            End Set
        End Property

        Public Property WIP_Qty() As Double
            Get
                Return _WIP_Qty
            End Get
            Set(ByVal value As Double)
                _WIP_Qty = value
            End Set
        End Property

        Public Property MV_NO_OUT() As String
            Get
                Return _MV_NO_OUT
            End Get
            Set(ByVal value As String)
                _MV_NO_OUT = value
            End Set
        End Property

        Public Property MV_Date_OUT() As String
            Get
                Return _MV_Date_OUT
            End Get
            Set(ByVal value As String)
                _MV_Date_OUT = value
            End Set
        End Property

        Public Property MV_Qty_OUT() As Double
            Get
                Return _MV_Qty_OUT
            End Get
            Set(ByVal value As Double)
                _MV_Qty_OUT = value
            End Set
        End Property


        'Private _MV_NO_IN As String
        'Private _MV_Date_IN As String
        'Private _MV_Qty_IN As Single

        Public Property MV_NO_IN() As String
            Get
                Return _MV_NO_IN
            End Get
            Set(ByVal value As String)
                _MV_NO_IN = value
            End Set
        End Property

        Public Property MV_Date_IN() As String
            Get
                Return _MV_Date_IN
            End Get
            Set(ByVal value As String)
                _MV_Date_IN = value
            End Set
        End Property

        Public Property MV_Qty_IN() As Double
            Get
                Return _MV_Qty_IN
            End Get
            Set(ByVal value As Double)
                _MV_Qty_IN = value
            End Set
        End Property



        Public Property MaterialTypeID() As String
            Get
                Return _materialtypeid
            End Get
            Set(ByVal value As String)
                _materialtypeid = value
            End Set
        End Property
        Public Property MaterialTypeName() As String
            Get
                Return _materialtypename
            End Get
            Set(ByVal value As String)
                _materialtypename = value
            End Set
        End Property
        Public Property Type1ID() As String
            Get
                Return _type1id
            End Get
            Set(ByVal value As String)
                _type1id = value
            End Set
        End Property
        Public Property Type1Name() As String
            Get
                Return _type1name
            End Get
            Set(ByVal value As String)
                _type1name = value
            End Set
        End Property
        Public Property Type2ID() As String
            Get
                Return _type2id
            End Get
            Set(ByVal value As String)
                _type2id = value
            End Set
        End Property
        Public Property Type2Name() As String
            Get
                Return _type2name
            End Get
            Set(ByVal value As String)
                _type2name = value
            End Set
        End Property
        Public Property Type3ID() As String
            Get
                Return _type3id
            End Get
            Set(ByVal value As String)
                _type3id = value
            End Set
        End Property
        Public Property Type3Name() As String
            Get
                Return _type3name
            End Get
            Set(ByVal value As String)
                _type3name = value
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
                Return _m_code
            End Get
            Set(ByVal value As String)
                _m_code = value
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
                Return _m_name
            End Get
            Set(ByVal value As String)
                _m_name = value
            End Set
        End Property
        ''' <summary>
        ''' 規格,樣式: 規格參數1  ; 規格參數2 ; 規格參數3...
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Gauge() As String
            Get
                Return _m_gauge
            End Get
            Set(ByVal value As String)
                _m_gauge = value
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
                Return _m_unit
            End Get
            Set(ByVal value As String)
                _m_unit = value
            End Set
        End Property
        ''' <summary>
        ''' 單價
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Price() As Double
            Get
                Return _m_price
            End Get
            Set(ByVal value As Double)
                _m_price = value
            End Set
        End Property
        ''' <summary>
        ''' 幣別
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Currency() As String
            Get
                Return _m_currency
            End Get
            Set(ByVal value As String)
                _m_currency = value
            End Set
        End Property
        ''' <summary>
        ''' 是否啟用
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_IsEnabled() As Boolean
            Get
                Return _m_isenabled
            End Get
            Set(ByVal value As Boolean)
                _m_isenabled = value
            End Set
        End Property
        ''' <summary>
        ''' 制造商
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Maker() As String
            Get
                Return _m_maker
            End Get
            Set(ByVal value As String)
                _m_maker = value
            End Set
        End Property
        ''' <summary>
        ''' 建立日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_AddDate() As String
            Get
                Return _m_adddate
            End Get
            Set(ByVal value As String)
                _m_adddate = value
            End Set
        End Property
        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_EditDate() As String
            Get
                Return _m_editdate
            End Get
            Set(ByVal value As String)
                _m_editdate = value
            End Set
        End Property
        ''' <summary>
        ''' 備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Remark() As String
            Get
                Return _m_remark
            End Get
            Set(ByVal value As String)
                _m_remark = value
            End Set
        End Property
        ''' <summary>
        ''' 會計部審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_AccountCheck() As Boolean
            Get
                Return _m_accountcheck
            End Get
            Set(ByVal value As Boolean)
                _m_accountcheck = value
            End Set
        End Property
        ''' <summary>
        ''' 操作員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property InUser() As String
            Get
                Return _inuser
            End Get
            Set(ByVal value As String)
                _inuser = value
            End Set
        End Property
        ''' <summary>
        ''' 是否有子物料
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_IsSub() As Boolean
            Get
                Return _m_issub
            End Get
            Set(ByVal value As Boolean)
                _m_issub = value
            End Set
        End Property
        ''' <summary>
        ''' 子物料用量,只用於讀取子物料時使用
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Qty() As Integer
            Get
                Return _m_qty
            End Get
            Set(ByVal value As Integer)
                _m_qty = value
            End Set
        End Property
        ''' <summary>
        ''' 供應商
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Supplier() As String
            Get
                Return _m_supplier
            End Get
            Set(ByVal value As String)
                _m_supplier = value
            End Set
        End Property
        ''' <summary>
        ''' 供應商編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_SupplierNo() As String
            Get
                Return _m_supplierno
            End Get
            Set(ByVal value As String)
                _m_supplierno = value
            End Set
        End Property
        ''' <summary>
        ''' 安全庫存
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_SaveKuCun() As String
            Get
                Return _m_savekucun
            End Get
            Set(ByVal value As String)
                _m_savekucun = value
            End Set
        End Property
        ''' <summary>
        ''' 操作人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property U_Name() As String
            Get
                Return _u_name
            End Get
            Set(ByVal value As String)
                _u_name = value
            End Set
        End Property
        ''' <summary>
        ''' 庫存數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WI_Qty() As Double
            Get
                Return _wi_qty
            End Get
            Set(ByVal value As Double)
                _wi_qty = value
            End Set
        End Property
        ''' <summary>
        ''' 倉庫
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WH_ID() As String
            Get
                Return _wh_id
            End Get
            Set(ByVal value As String)
                _wh_id = value
            End Set
        End Property
        Public Property WH_Name() As String
            Get
                Return _wh_name
            End Get
            Set(ByVal value As String)
                _wh_name = value
            End Set
        End Property

        Public Property WH_SName() As String
            Get
                Return _wh_sname
            End Get
            Set(ByVal value As String)
                _wh_sname = value
            End Set
        End Property

        Public Property WH_AllName() As String
            Get
                Return _wh_allname
            End Get
            Set(ByVal value As String)
                _wh_allname = value
            End Set
        End Property

        Public Property WI_SafeQty() As Double
            Get
                Return _wi_safeqty
            End Get
            Set(ByVal value As Double)
                _wi_safeqty = value
            End Set
        End Property

        ''' <summary>
        ''' 最大庫存
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WI_MaxQty() As Double
            Get
                Return _wi_maxqty
            End Get
            Set(ByVal value As Double)
                _wi_maxqty = value
            End Set
        End Property

        Public Property Date1() As Date
            Get
                Return _Date1
            End Get
            Set(ByVal value As Date)
                _Date1 = value
            End Set
        End Property
        Public Property Date2() As Date
            Get
                Return _Date2
            End Get
            Set(ByVal value As Date)
                _Date2 = value
            End Set
        End Property
        Public Property InQty() As Double
            Get
                Return _InQty
            End Get
            Set(ByVal value As Double)
                _InQty = value
            End Set
        End Property
        Public Property OutQty() As Double
            Get
                Return _OutQty
            End Get
            Set(ByVal value As Double)
                _OutQty = value
            End Set
        End Property
        Public Property MVInQty() As Double
            Get
                Return _MVInQty
            End Get
            Set(ByVal value As Double)
                _MVInQty = value
            End Set
        End Property
        Public Property MVOutQty() As Double
            Get
                Return _MVOutQty
            End Get
            Set(ByVal value As Double)
                _MVOutQty = value
            End Set
        End Property
        Public Property BeginQty() As Double
            Get
                Return _BeginQty
            End Get
            Set(ByVal value As Double)
                _BeginQty = value
            End Set
        End Property
        Public Property AllInQty() As Double
            Get
                Return _AllInQty
            End Get
            Set(ByVal value As Double)
                _AllInQty = value
            End Set
        End Property
        Public Property AllOutQty() As Double
            Get
                Return _AllOutQty
            End Get
            Set(ByVal value As Double)
                _AllOutQty = value
            End Set
        End Property
        Public Property BeginDate() As String
            Get
                Return _BeginDate
            End Get
            Set(ByVal value As String)
                _BeginDate = value
            End Set
        End Property
        Public Property EndDate() As String
            Get
                Return _EndDate
            End Get
            Set(ByVal value As String)
                _EndDate = value
            End Set
        End Property
        Public Property BackUpTime() As Date
            Get
                Return _BackUpTime
            End Get
            Set(ByVal value As Date)
                _BackUpTime = value
            End Set
        End Property
        Public Property WI_UserID() As String
            Get
                Return _WI_UserID
            End Get
            Set(ByVal value As String)
                _WI_UserID = value
            End Set
        End Property
        Public Property WI_EditDate() As Date
            Get
                Return _WI_EditDate
            End Get
            Set(ByVal value As Date)
                _WI_EditDate = value
            End Set
        End Property
        Public Property WO_Qty1() As Double
            Get
                Return _WO_Qty1
            End Get
            Set(ByVal value As Double)
                _WO_Qty1 = value
            End Set
        End Property
        Public Property WO_Qty2() As Double
            Get
                Return _WO_Qty2
            End Get
            Set(ByVal value As Double)
                _WO_Qty2 = value
            End Set
        End Property
        Public Property WO_Qty3() As Double
            Get
                Return _WO_Qty3
            End Get
            Set(ByVal value As Double)
                _WO_Qty3 = value
            End Set
        End Property


        '------------------

        Public Property SumOut() As Double
            Get
                Return _SumOut
            End Get
            Set(ByVal value As Double)
                _SumOut = value
            End Set
        End Property

        Public Property SumIN() As Double
            Get
                Return _SumIN
            End Get
            Set(ByVal value As Double)
                _SumIN = value
            End Set
        End Property

        Public Property QTYStart() As Double
            Get
                Return _QTYStart
            End Get
            Set(ByVal value As Double)
                _QTYStart = value
            End Set
        End Property

        Public Property QTYEnd() As Double
            Get
                Return _QTYEnd
            End Get
            Set(ByVal value As Double)
                _QTYEnd = value
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


    End Class
End Namespace

