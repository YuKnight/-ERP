Namespace LFERP.Library.MrpManager.Bom_D
    Public Class Bom_DInfo
        Private _ParentGroup As String ''''組件編號（成品產品編號、半成品）
        Private _ChildGroup As String ''''元件料件
        Private _IsUnfold As Boolean ''''是否展開
        Private _Item As String ''''項次
        Private _ReplaceType As String ''''取代類型數字
        Private _ReplaceType1 As String ''''取代類型漢字
        Private _UseFeatures As String ''''使用特性
        Private _EffectiveDate As String ''''生效日期 
        Private _InvalidDate As String ''''失效日期
        Private _Mount As Decimal ''''組成用量
        Private _Tmrtc As Decimal ''''主件底數
        Private _SendUnit As String ''''發料單位
        Private _LossRate As Decimal ''''損率
        Private _CreateUserID As String ''''創建人員
        Private _CreateDate As String ''''創建日期
        Private _ModifyUserID As String ''''修改人員
        Private _ModifyDate As String ''''修改時間
        Private _ChildName As String ''''物料名稱
        Private _ChildGauge As String ''''物料規格
        Private _ChildMC_Source As String
        Private _AutoID As Decimal ''''自動編號
        Private _PID As String
        Private _ID As String
        Private _IsBottom As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _M_Source As String
        Private _sonsNum As Integer
        Private _CreateUserName As String

        Private _SumQty As Decimal ''''總用量
        Private _QtyPer As Decimal ''''單位用量
        Private _ActualQty As Decimal '實際用量
        Private _LossQty As Decimal '損耗量


        Public Sub New()
            _PID = Nothing
            _ID = Nothing
            _IsBottom = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _M_Source = Nothing
            _sonsNum = 0
            _CreateUserName = Nothing

            _ParentGroup = Nothing
            _ChildGroup = Nothing
            _IsUnfold = False
            _Item = Nothing
            _ReplaceType = Nothing
            _ReplaceType1 = Nothing
            _UseFeatures = Nothing
            _EffectiveDate = Nothing
            _InvalidDate = Nothing
            _Mount = 0
            _Tmrtc = 0
            _SumQty = 0
            _LossQty = 0
            _ActualQty = 0
            _QtyPer = 0
            _SendUnit = Nothing
            _LossRate = 0
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _AutoID = 0
            _ChildName = Nothing
            _ChildGauge = Nothing
            _ChildMC_Source = Nothing

        End Sub
        Public Property CreateUserName() As String
            Get
                Return _CreateUserName
            End Get
            Set(ByVal value As String)
                _CreateUserName = value
            End Set
        End Property
        Public Property sonsNum() As Integer
            Get
                Return _sonsNum
            End Get
            Set(ByVal value As Integer)
                _sonsNum = value
            End Set
        End Property
        Public Property M_Source() As String
            Get
                Return _M_Source
            End Get
            Set(ByVal value As String)
                _M_Source = value
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
        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
            End Set
        End Property
        Public Property IsBottom() As String
            Get
                Return _IsBottom
            End Get
            Set(ByVal value As String)
                _IsBottom = value
            End Set
        End Property
        Public Property PID() As String
            Get
                Return _PID
            End Get
            Set(ByVal value As String)
                _PID = value
            End Set
        End Property
        Public Property ID() As String
            Get
                Return _ID
            End Get
            Set(ByVal value As String)
                _ID = value
            End Set
        End Property

        Public Property ChildMC_Source() As String
            Get
                Return _ChildMC_Source
            End Get
            Set(ByVal value As String)
                _ChildMC_Source = value
            End Set
        End Property
        Public Property ChildName() As String
            Get
                Return _ChildName
            End Get
            Set(ByVal value As String)
                _ChildName = value
            End Set
        End Property
        Public Property ChildGauge() As String
            Get
                Return _ChildGauge
            End Get
            Set(ByVal value As String)
                _ChildGauge = value
            End Set
        End Property
        Public Property ParentGroup() As String
            Get
                Return _ParentGroup
            End Get
            Set(ByVal value As String)
                _ParentGroup = value
            End Set
        End Property
        Public Property ChildGroup() As String
            Get
                Return _ChildGroup
            End Get
            Set(ByVal value As String)
                _ChildGroup = value
            End Set
        End Property
        Public Property IsUnfold() As Boolean
            Get
                Return _IsUnfold
            End Get
            Set(ByVal value As Boolean)
                _IsUnfold = value
            End Set
        End Property
        Public Property Item() As String
            Get
                Return _Item
            End Get
            Set(ByVal value As String)
                _Item = value
            End Set
        End Property
        Public Property ReplaceType() As String
            Get
                Return _ReplaceType
            End Get
            Set(ByVal value As String)
                _ReplaceType = value
            End Set
        End Property
        Public Property ReplaceType1() As String
            Get
                Return _ReplaceType1
            End Get
            Set(ByVal value As String)
                _ReplaceType1 = value
            End Set
        End Property
        Public Property UseFeatures() As String
            Get
                Return _UseFeatures
            End Get
            Set(ByVal value As String)
                _UseFeatures = value
            End Set
        End Property
        Public Property EffectiveDate() As String
            Get
                Return _EffectiveDate
            End Get
            Set(ByVal value As String)
                _EffectiveDate = value
            End Set
        End Property
        Public Property InvalidDate() As String
            Get
                Return _InvalidDate
            End Get
            Set(ByVal value As String)
                _InvalidDate = value
            End Set
        End Property
        Public Property Mount() As Decimal
            Get
                Return _Mount
            End Get
            Set(ByVal value As Decimal)
                _Mount = value
            End Set
        End Property
        Public Property Tmrtc() As Decimal
            Get
                Return _Tmrtc
            End Get
            Set(ByVal value As Decimal)
                _Tmrtc = value
            End Set
        End Property
        Public Property SumQty() As Decimal
            Get
                Return _SumQty
            End Get
            Set(ByVal value As Decimal)
                _SumQty = value
            End Set
        End Property

        Public Property LossQty() As Decimal
            Get
                Return _LossQty
            End Get
            Set(ByVal value As Decimal)
                _LossQty = value
            End Set
        End Property

        Public Property ActualQty() As Decimal
            Get
                Return _ActualQty
            End Get
            Set(ByVal value As Decimal)
                _ActualQty = value
            End Set
        End Property
        Public Property QtyPer() As Decimal
            Get
                Return _QtyPer
            End Get
            Set(ByVal value As Decimal)
                _QtyPer = value
            End Set
        End Property
        Public Property SendUnit() As String
            Get
                Return _SendUnit
            End Get
            Set(ByVal value As String)
                _SendUnit = value
            End Set
        End Property
        Public Property LossRate() As Decimal
            Get
                Return _LossRate
            End Get
            Set(ByVal value As Decimal)
                _LossRate = value
            End Set
        End Property
        Public Property CreateUserID() As String
            Get
                Return _CreateUserID
            End Get
            Set(ByVal value As String)
                _CreateUserID = value
            End Set
        End Property
        Public Property CreateDate() As String
            Get
                Return _CreateDate
            End Get
            Set(ByVal value As String)
                _CreateDate = value
            End Set
        End Property
        Public Property ModifyUserID() As String
            Get
                Return _ModifyUserID
            End Get
            Set(ByVal value As String)
                _ModifyUserID = value
            End Set
        End Property
        Public Property ModifyDate() As String
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As String)
                _ModifyDate = value
            End Set
        End Property
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property

    End Class
End Namespace