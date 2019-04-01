
Namespace LFERP.Library.Material
    Public Class MaterialInfo
        Private _m_code As String
        Private _BlocCode As String     '集團編碼
        Private _m_name As String
        Private _m_gauge As String
        Private _m_unit As String
        ' Private _m_type As String
        Private _m_price As Double
        Private _m_currency As String
        Private _m_isenabled As Boolean
        Private _m_maker As String
        Private _m_photo As Byte()    '圖片功能獨立出來，避免數據過大造成網絡堵塞，圖片只用於單獨記錄時取得
        Private _m_adddate As String
        Private _m_editdate As String
        Private _m_remark As String
        Private _type3id As String
        Private _m_accountcheck As Boolean
        Private _inuser As String
        Private _m_issub As Boolean
        Private _m_qty As Integer         '用量,子表中的
        Private _m_supplier As String
        Private _m_supplierno As String
        Private _m_savekucun As String
        Private _u_name As String

        Private _M_TeSu As String

        Private _M_Weight As Double
        Private _M_WeightUnit As String
        Private _M_FinalDate As String
        Private _Type3Name As String
        Private _M_ChangeDate As Date

        Private _M_CodeSub As String
        Private _M_CheckRemark As String

        '2014/4/11
        Private _MaterialProperty As Int32
        Private _SoureType As Int32
        Private _ObtainingMode As Int32
        Private _MinStock As Decimal
        Private _MaxStock As Decimal
        Private _SafetyStock As Decimal
        Private _GrossWeight As Decimal
        Private _NetWeight As Decimal
        Private _WeightUnit As String
        Private _CustormerMaterial As String
        Private _InVerfyMode As Int32
        Private _ProductVerifyMode As Int32
        Private _OutSourceExcessProportion As Decimal
        Private _OutSourceLessProportion As Decimal
        Private _SalesExcessProportion As Decimal
        Private _SalesLessProportion As Decimal
        Private _CompleteExcessProportion As Decimal
        Private _ComoleteLessProportion As Decimal
        Private _PlanStrategy As Int32
        Private _OrderStrategy As Int32
        Private _FixLeadTime As Int32
        Private _OrderInterval As Int32
        Private _MinOrderQty As Decimal
        Private _MaxOrderQty As Decimal
        Private _IncreasBatch As Decimal
        Private _ReOrderPoint As Decimal
        Private _FixedQty As Decimal
        Private _DefaultProductionType As Int32
        Private _DayConsumption As Decimal
        Private _ValuationMethods As Int32
        Private _OrderUnitPrice As Decimal
        Private _SaleUnitPrice As Decimal
        Private _SaleSubjectNo As String
        Private _SaleCostSubjectNo As String
        Private _SaleInSubjectNo As String
        Private _CostDiffSubjectNo As String
        Private _EscrowMaterialSubject As String
        Private _CostProject As Int32
        Private _M_Product As String
        Private _SoureName As String

        Public Sub New()
            '初始化數據
            _M_Product = Nothing
            _m_code = Nothing
            _BlocCode = Nothing
            _m_name = Nothing
            _m_gauge = Nothing
            _m_unit = Nothing
            ' _m_type = Nothing
            _m_price = 0
            _m_currency = Nothing
            _m_isenabled = True
            _m_photo = Nothing
            _m_adddate = Nothing
            _m_editdate = Nothing
            _m_remark = Nothing
            _type3id = Nothing
            _Type3Name = Nothing
            _m_accountcheck = False
            _inuser = Nothing
            _m_issub = False
            _m_qty = 0
            _m_supplier = Nothing
            _m_supplierno = Nothing
            _m_savekucun = Nothing
            _u_name = Nothing
            _M_TeSu = Nothing

            _M_Weight = 0
            _M_WeightUnit = Nothing
            _M_FinalDate = Nothing
            _M_ChangeDate = Nothing

            _M_CodeSub = Nothing
            _M_CheckRemark = Nothing
            '2014/4/11
            _MaterialProperty = 0
            _SoureType = 0
            _ObtainingMode = 0
            _MinStock = 0
            _MaxStock = 0
            _SafetyStock = 0
            _GrossWeight = 0
            _NetWeight = 0
            _WeightUnit = Nothing
            _CustormerMaterial = Nothing
            _InVerfyMode = 0
            _ProductVerifyMode = 0
            _OutSourceExcessProportion = 0
            _OutSourceLessProportion = 0
            _SalesExcessProportion = 0
            _SalesLessProportion = 0
            _CompleteExcessProportion = 0
            _ComoleteLessProportion = 0
            _PlanStrategy = 0
            _OrderStrategy = 0
            _FixLeadTime = 0
            _OrderInterval = 0
            _MinOrderQty = 0
            _MaxOrderQty = 0
            _IncreasBatch = 0
            _ReOrderPoint = 0
            _FixedQty = 0
            _DefaultProductionType = 0
            _DayConsumption = 0
            _ValuationMethods = 0
            _OrderUnitPrice = 0
            _SaleUnitPrice = 0
            _SaleSubjectNo = Nothing
            _SaleCostSubjectNo = Nothing
            _SaleInSubjectNo = Nothing
            _CostDiffSubjectNo = Nothing
            _EscrowMaterialSubject = Nothing
            _CostProject = 0
            _SoureName = Nothing
        End Sub
        '2014/5/22
        Public Property SoureName() As String
            Get
                Return _SoureName
            End Get
            Set(ByVal value As String)
                _SoureName = value
            End Set
        End Property
        ''' <summary>
        ''' 產品名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Product() As String
            Get
                Return _M_Product
            End Get
            Set(ByVal value As String)
                _M_Product = value
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
        ''' 集團編碼
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property BlocCode() As String
            Get
                Return _BlocCode
            End Get
            Set(ByVal value As String)
                _BlocCode = value
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
        '''' <summary>
        '''' 類型:配件，半成品，材料，成品
        '''' </summary>
        '''' <value></value>
        '''' <returns></returns>
        '''' <remarks></remarks>
        'Public Property M_Type() As String
        '    Get
        '        Return _m_type
        '    End Get
        '    Set(ByVal value As String)
        '        _m_type = value
        '    End Set
        'End Property
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
        ''' 圖片,Byte格式
        ''' 寫入數據庫
        ''' Dim photo(fs.Length) As Byte
        ''' fs.Read(photo, 0, Int(fs.Length))
        ''' 讀取圖片
        ''' Dim photo As New MemoryStream(objMaterial.M_Photo)
        ''' PictureBox1.Image = Image.FromStream(photo)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Photo() As Byte()
            Get
                Return _m_photo
            End Get
            Set(ByVal value As Byte())
                _m_photo = value
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
        ''' 類別3編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Type3ID() As String
            Get
                Return _type3id
            End Get
            Set(ByVal value As String)
                _type3id = value
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
        ''' 特殊類
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_TeSu() As String
            Get
                Return _M_TeSu
            End Get
            Set(ByVal value As String)
                _M_TeSu = value
            End Set
        End Property
        Public Property M_Weight() As Double
            Get
                Return _M_Weight
            End Get
            Set(ByVal value As Double)
                _M_Weight = value
            End Set
        End Property
        Public Property M_WeightUnit() As String
            Get
                Return _M_WeightUnit
            End Get
            Set(ByVal value As String)
                _M_WeightUnit = value
            End Set
        End Property

        Public Property M_FinalDate() As String
            Get
                Return _M_FinalDate
            End Get
            Set(ByVal value As String)
                _M_FinalDate = value
            End Set
        End Property
        Public Property M_ChangeDate() As Date
            Get
                Return _M_ChangeDate
            End Get
            Set(ByVal value As Date)
                _M_ChangeDate = value
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
        Public Property M_CodeSub() As String
            Get
                Return _M_CodeSub
            End Get
            Set(ByVal value As String)
                _M_CodeSub = value
            End Set
        End Property
        Public Property M_CheckRemark() As String
            Get
                Return _M_CheckRemark
            End Get
            Set(ByVal value As String)
                _M_CheckRemark = value
            End Set
        End Property
        '2014/4/11
        Public Property MaterialProperty() As Integer
            Get
                Return _MaterialProperty
            End Get
            Set(ByVal value As Integer)
                _MaterialProperty = value
            End Set
        End Property
        Public Property SoureType() As Integer
            Get
                Return _SoureType
            End Get
            Set(ByVal value As Integer)
                _SoureType = value
            End Set
        End Property
        Public Property ObtainingMode() As Integer
            Get
                Return _ObtainingMode
            End Get
            Set(ByVal value As Integer)
                _ObtainingMode = value
            End Set
        End Property
        Public Property MinStock() As Decimal
            Get
                Return _MinStock
            End Get
            Set(ByVal value As Decimal)
                _MinStock = value
            End Set
        End Property
        Public Property MaxStock() As Decimal
            Get
                Return _MaxStock
            End Get
            Set(ByVal value As Decimal)
                _MaxStock = value
            End Set
        End Property
        Public Property SafetyStock() As Decimal
            Get
                Return _SafetyStock
            End Get
            Set(ByVal value As Decimal)
                _SafetyStock = value
            End Set
        End Property
        Public Property GrossWeight() As Decimal
            Get
                Return _GrossWeight
            End Get
            Set(ByVal value As Decimal)
                _GrossWeight = value
            End Set
        End Property
        Public Property NetWeight() As Decimal
            Get
                Return _NetWeight
            End Get
            Set(ByVal value As Decimal)
                _NetWeight = value
            End Set
        End Property

        Public Property WeightUnit() As String
            Get
                Return _WeightUnit
            End Get
            Set(ByVal value As String)
                _WeightUnit = value
            End Set
        End Property
        Public Property CustormerMaterial() As String
            Get
                Return _CustormerMaterial
            End Get
            Set(ByVal value As String)
                _CustormerMaterial = value
            End Set
        End Property
        Public Property InVerfyMode() As Integer
            Get
                Return _InVerfyMode
            End Get
            Set(ByVal value As Integer)
                _InVerfyMode = value
            End Set
        End Property
        Public Property ProductVerifyMode() As Integer
            Get
                Return _ProductVerifyMode
            End Get
            Set(ByVal value As Integer)
                _ProductVerifyMode = value
            End Set
        End Property

        Public Property OutSourceExcessProportion() As Decimal
            Get
                Return _OutSourceExcessProportion
            End Get
            Set(ByVal value As Decimal)
                _OutSourceExcessProportion = value
            End Set
        End Property
        Public Property OutSourceLessProportion() As Decimal
            Get
                Return _OutSourceLessProportion
            End Get
            Set(ByVal value As Decimal)
                _OutSourceLessProportion = value
            End Set
        End Property
        Public Property SalesExcessProportion() As Decimal
            Get
                Return _SalesExcessProportion
            End Get
            Set(ByVal value As Decimal)
                _SalesExcessProportion = value
            End Set
        End Property
        Public Property SalesLessProportion() As Decimal
            Get
                Return _SalesLessProportion
            End Get
            Set(ByVal value As Decimal)
                _SalesLessProportion = value
            End Set
        End Property
        Public Property CompleteExcessProportion() As Decimal
            Get
                Return _CompleteExcessProportion
            End Get
            Set(ByVal value As Decimal)
                _CompleteExcessProportion = value
            End Set
        End Property
        Public Property ComoleteLessProportion() As Decimal
            Get
                Return _ComoleteLessProportion
            End Get
            Set(ByVal value As Decimal)
                _ComoleteLessProportion = value
            End Set
        End Property
        Public Property PlanStrategy() As Integer
            Get
                Return _PlanStrategy
            End Get
            Set(ByVal value As Integer)
                _PlanStrategy = value
            End Set
        End Property
        Public Property OrderStrategy() As Integer
            Get
                Return _OrderStrategy
            End Get
            Set(ByVal value As Integer)
                _OrderStrategy = value
            End Set
        End Property
        Public Property FixLeadTime() As Int32
            Get
                Return _FixLeadTime
            End Get
            Set(ByVal value As Int32)
                _FixLeadTime = value
            End Set
        End Property
        Public Property OrderInterval() As Int32
            Get
                Return _OrderInterval
            End Get
            Set(ByVal value As Int32)
                _OrderInterval = value
            End Set
        End Property
        Public Property MinOrderQty() As Decimal
            Get
                Return _MinOrderQty
            End Get
            Set(ByVal value As Decimal)
                _MinOrderQty = value
            End Set
        End Property
        Public Property MaxOrderQty() As Decimal
            Get
                Return _MaxOrderQty
            End Get
            Set(ByVal value As Decimal)
                _MaxOrderQty = value
            End Set
        End Property
        Public Property IncreasBatch() As Decimal
            Get
                Return _IncreasBatch
            End Get
            Set(ByVal value As Decimal)
                _IncreasBatch = value
            End Set
        End Property
        Public Property ReOrderPoint() As Decimal
            Get
                Return _ReOrderPoint
            End Get
            Set(ByVal value As Decimal)
                _ReOrderPoint = value
            End Set
        End Property
        Public Property FixedQty() As Decimal
            Get
                Return _FixedQty
            End Get
            Set(ByVal value As Decimal)
                _FixedQty = value
            End Set
        End Property
        Public Property DefaultProductionType() As Integer
            Get
                Return _DefaultProductionType
            End Get
            Set(ByVal value As Integer)
                _DefaultProductionType = value
            End Set
        End Property
        Public Property DayConsumption() As Decimal
            Get
                Return _DayConsumption
            End Get
            Set(ByVal value As Decimal)
                _DayConsumption = value
            End Set
        End Property
        Public Property ValuationMethods() As Integer
            Get
                Return _ValuationMethods
            End Get
            Set(ByVal value As Integer)
                _ValuationMethods = value
            End Set
        End Property

        Public Property SaleUnitPrice() As Decimal
            Get
                Return _SaleUnitPrice
            End Get
            Set(ByVal value As Decimal)
                _SaleUnitPrice = value
            End Set
        End Property
        Public Property OrderUnitPrice() As Decimal
            Get
                Return _OrderUnitPrice
            End Get
            Set(ByVal value As Decimal)
                _OrderUnitPrice = value
            End Set
        End Property
        Public Property SaleSubjectNo() As String
            Get
                Return _SaleSubjectNo
            End Get
            Set(ByVal value As String)
                _SaleSubjectNo = value
            End Set
        End Property
        Public Property SaleCostSubjectNo() As String
            Get
                Return _SaleCostSubjectNo
            End Get
            Set(ByVal value As String)
                _SaleCostSubjectNo = value
            End Set
        End Property
        Public Property SaleInSubjectNo() As String
            Get
                Return _SaleInSubjectNo
            End Get
            Set(ByVal value As String)
                _SaleInSubjectNo = value
            End Set
        End Property
        Public Property CostDiffSubjectNo() As String
            Get
                Return _CostDiffSubjectNo
            End Get
            Set(ByVal value As String)
                _CostDiffSubjectNo = value
            End Set
        End Property
        Public Property EscrowMaterialSubject() As String
            Get
                Return _EscrowMaterialSubject
            End Get
            Set(ByVal value As String)
                _EscrowMaterialSubject = value
            End Set
        End Property

        Public Property CostProject() As Integer
            Get
                Return _CostProject
            End Get
            Set(ByVal value As Integer)
                _CostProject = value
            End Set
        End Property
    End Class

End Namespace

