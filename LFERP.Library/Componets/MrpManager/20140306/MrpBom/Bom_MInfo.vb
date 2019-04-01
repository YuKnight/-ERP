Namespace LFERP.Library.MrpManager.Bom_M
    Public Class Bom_MInfo
        Private _ParentGroup As String              ''''組件編碼（產品編碼）
        Private _M_Name As String                   ''''名稱
        Private _M_Gauge As String                  ''''規格
        Private _SourceID As String                 ''''來源碼
        Private _CheckDate As String              ''''審核日期
        Private _M_Unit As String           ''''生產單位
        Private _EffectiveDate As String          ''''生效日期
        Private _InvalidDate As String            ''''失效日期
        Private _Version As String                  ''''版本
        Private _CheckUserID As String              ''''審核人員
        Private _CheckUserName As String
        Private _CheckBit As Boolean                ''''是否審核
        Private _CheckRemark As String              ''''審核備註

        Private _CreateUserName As String             ''''創建人員
        Private _CreateUserID As String             ''''創建人員
        Private _CreateDate As String             ''''創建時間
        Private _ModifyUserID As String             ''''修改人員
        Private _ModifyDate As String             ''''修改時間
        Private _AutoID As Decimal                  ''''自動編號
        Private _M_Source As String
        Public Sub New()
            _ParentGroup = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _SourceID = Nothing
            _CheckDate = Nothing
            _M_Unit = Nothing
            _EffectiveDate = Nothing
            _InvalidDate = Nothing
            _Version = Nothing
            _CheckUserID = Nothing
            _CheckBit = False
            _CheckRemark = Nothing
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _AutoID = 0
            _CheckUserName = Nothing
            _CreateUserName = Nothing
            _M_Source = Nothing
        End Sub
        Public Property CheckUserName() As String
            Get
                Return _CheckUserName
            End Get
            Set(ByVal value As String)
                _CheckUserName = value
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
        Public Property CreateUserName() As String
            Get
                Return _CreateUserName
            End Get
            Set(ByVal value As String)
                _CreateUserName = value
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
        Public Property SourceID() As String
            Get
                Return _SourceID
            End Get
            Set(ByVal value As String)
                _SourceID = value
            End Set
        End Property
        Public Property CheckDate() As String
            Get
                Return _CheckDate
            End Get
            Set(ByVal value As String)
                _CheckDate = value
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
        Public Property Version() As String
            Get
                Return _Version
            End Get
            Set(ByVal value As String)
                _Version = value
            End Set
        End Property
        Public Property CheckUserID() As String
            Get
                Return _CheckUserID
            End Get
            Set(ByVal value As String)
                _CheckUserID = value
            End Set
        End Property
        Public Property CheckBit() As Boolean
            Get
                Return _CheckBit
            End Get
            Set(ByVal value As Boolean)
                _CheckBit = value
            End Set
        End Property
        Public Property CheckRemark() As String
            Get
                Return _CheckRemark
            End Get
            Set(ByVal value As String)
                _CheckRemark = value
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