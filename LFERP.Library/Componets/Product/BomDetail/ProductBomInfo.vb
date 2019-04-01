Namespace LFERP.Library.Product
    Public Class ProductBomInfo
        Private _pm_m_code As String
        Private _pm_id As String
        Private _m_code As String
        Private _m_codepid As String
        Private _pm_qty As Single
        Private _pm_makeremark As String
        Private _pm_make As Boolean
        Private _pm_check As Boolean
        Private _m_supplier As String
        Private _m_supplierno As String
        Private _m_suppliername As String
        '此三個子段取自MaterialCode表,只用於顯示資料
        Private _m_name As String
        Private _m_gauge As String
        Private _m_unit As String
        Private _m_price As Single
        '樹等級,自動生成
        Private _pm_lvl As Integer
        Private _pm_key As String
        Private _pm_pid As String

        Private _m_codetype As String
        Private _m_codemouldno As String
        'Private _m_weight As Single
        Private _m_weight As Decimal


        Public Sub New()
            _pm_m_code = Nothing
            _pm_id = Nothing
            _m_code = Nothing
            _m_codepid = Nothing
            _pm_qty = 0
            _pm_makeremark = Nothing
            _pm_make = False
            _pm_check = False
            _m_supplier = Nothing
            _m_supplierno = Nothing

            '此三個子段取自MaterialCode表,只用於顯示資料
            _m_name = Nothing
            _m_gauge = Nothing
            _m_unit = Nothing

            _m_suppliername = Nothing

            _m_price = 0
            _pm_lvl = 0
            _pm_key = Nothing
            _pm_pid = Nothing

            _m_codetype = Nothing
            _m_codemouldno = Nothing
            _m_weight = 0
        End Sub
        ''' <summary>
        ''' 聯豐編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_M_Code() As String
            Get
                Return _pm_m_code
            End Get
            Set(ByVal value As String)
                _pm_m_code = value
            End Set
        End Property
        ''' <summary>
        ''' 序號,排序用
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_ID() As String
            Get
                Return _pm_id
            End Get
            Set(ByVal value As String)
                _pm_id = value
            End Set
        End Property
        ''' <summary>
        ''' 物料編號
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
        ''' 父項物料編碼
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_CodePID() As String
            Get
                Return _m_codepid
            End Get
            Set(ByVal value As String)
                _m_codepid = value
            End Set
        End Property
        ''' <summary>
        ''' 用量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Qty() As Single
            Get
                Return _pm_qty
            End Get
            Set(ByVal value As Single)
                _pm_qty = value
            End Set
        End Property
        ''' <summary>
        ''' 加工要求
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_MakeRemark() As String
            Get
                Return _pm_makeremark
            End Get
            Set(ByVal value As String)
                _pm_makeremark = value
            End Set
        End Property
        ''' <summary>
        ''' 是否再加工
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Make() As Boolean
            Get
                Return _pm_make
            End Get
            Set(ByVal value As Boolean)
                _pm_make = value
            End Set
        End Property
        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Check() As Boolean
            Get
                Return _pm_check
            End Get
            Set(ByVal value As Boolean)
                _pm_check = value
            End Set
        End Property
        ''' <summary>
        ''' 供應商代號
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
        Public Property M_Price() As Single
            Get
                Return _m_price
            End Get
            Set(ByVal value As Single)
                _m_price = value
            End Set
        End Property

        ''' <summary>
        ''' 樹等級
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_LVL() As Integer
            Get
                Return _pm_lvl
            End Get
            Set(ByVal value As Integer)
                _pm_lvl = value
            End Set
        End Property
        ''' <summary>
        ''' BOM子項的path如100.101.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Key() As String
            Get
                Return _pm_key
            End Get
            Set(ByVal value As String)
                _pm_key = value
            End Set
        End Property
        ''' <summary>
        ''' BOM子項的父項PID如100.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_PID() As String
            Get
                Return _pm_pid
            End Get
            Set(ByVal value As String)
                _pm_pid = value
            End Set
        End Property
        ''' <summary>
        ''' 供應商名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_SupplierName() As String
            Get
                Return _m_suppliername
            End Get
            Set(ByVal value As String)
                _m_suppliername = value
            End Set
        End Property
        ''' <summary>
        ''' 配件類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_CodeType() As String
            Get
                Return _m_codetype
            End Get
            Set(ByVal value As String)
                _m_codetype = value
            End Set
        End Property
        ''' <summary>
        ''' 模具編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_CodeMouldNO() As String
            Get
                Return _m_codemouldno
            End Get
            Set(ByVal value As String)
                _m_codemouldno = value
            End Set
        End Property
        ''' <summary>
        ''' 此配件在當前單個產品中所需重量(大概數)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Weight() As Decimal
            Get
                Return _m_weight
            End Get
            Set(ByVal value As Decimal)
                _m_weight = value
            End Set
        End Property
    End Class
End Namespace

