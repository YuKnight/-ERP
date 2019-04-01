Namespace LFERP.DataSetting

    Public Class CompanyInfo
        Private _CO_ID As String
        Private _CO_ChsName As String
        Private _CO_EngName As String
        Private _CO_ChsAddress As String
        Private _CO_EngAddress As String
        Private _CO_ChsTel As String
        Private _CO_EngTel As String
        Private _CO_ChsFax As String
        Private _CO_EngFax As String
        Private _CO_ChsShipTo As String
        Private _CO_EngShipTo As String
        Private _CO_ChsDeliverTo As String
        Private _CO_ChsDeliverTel As String
        Private _CO_ChsDeliverFax As String
        Private _CO_EngDeliverTo As String
        Private _CO_EngDeliverTel As String
        Private _CO_EngDeliverFax As String
        Private _CO_Logo As Byte()

        Private _DPT_ID As String
        Private _CO_KaoQinConn As String


        Public Sub New()
            _CO_ID = Nothing
            _CO_ChsName = Nothing
            _CO_EngName = Nothing
            _CO_ChsAddress = Nothing
            _CO_EngAddress = Nothing
            _CO_ChsTel = Nothing
            _CO_EngTel = Nothing
            _CO_ChsFax = Nothing
            _CO_EngFax = Nothing
            _CO_ChsShipTo = Nothing
            _CO_EngShipTo = Nothing
            _CO_ChsDeliverTo = Nothing
            _CO_ChsDeliverTel = Nothing
            _CO_ChsDeliverFax = Nothing
            _CO_EngDeliverTo = Nothing
            _CO_EngDeliverTel = Nothing
            _CO_EngDeliverFax = Nothing
            _CO_Logo = Nothing

            _DPT_ID = Nothing
            _CO_KaoQinConn = Nothing

        End Sub
        ''' <summary>
        ''' 考勤連接字符串,后臺設置
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_KaoQinConn() As String
            Get
                Return _CO_KaoQinConn
            End Get
            Set(ByVal value As String)
                _CO_KaoQinConn = value
            End Set
        End Property


        ''' <summary>
        ''' 公司編號
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
        ''' 公司中文名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_ChsName() As String
            Get
                Return _CO_ChsName
            End Get
            Set(ByVal value As String)
                _CO_ChsName = value
            End Set
        End Property

        ''' <summary>
        ''' 公司英文名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_EngName() As String
            Get
                Return _CO_EngName
            End Get
            Set(ByVal value As String)
                _CO_EngName = value
            End Set
        End Property

        ''' <summary>
        ''' 公司中文地址
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_ChsAddress() As String
            Get
                Return _CO_ChsAddress
            End Get
            Set(ByVal value As String)
                _CO_ChsAddress = value
            End Set
        End Property

        ''' <summary>
        ''' 公司英文地址
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_EngAddress() As String
            Get
                Return _CO_EngAddress
            End Get
            Set(ByVal value As String)
                _CO_EngAddress = value
            End Set
        End Property

        ''' <summary>
        ''' 公司中文電話
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_ChsTel() As String
            Get
                Return _CO_ChsTel
            End Get
            Set(ByVal value As String)
                _CO_ChsTel = value
            End Set
        End Property

        ''' <summary>
        ''' 公司英文電話
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_EngTel() As String
            Get
                Return _CO_EngTel
            End Get
            Set(ByVal value As String)
                _CO_EngTel = value
            End Set
        End Property

        ''' <summary>
        ''' 公司中文傳真
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' 
        Public Property CO_ChsFax() As String
            Get
                Return _CO_ChsFax
            End Get
            Set(ByVal value As String)
                _CO_ChsFax = value
            End Set
        End Property

        ''' <summary>
        ''' 公司英文傳真
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' 
        Public Property CO_EngFax() As String
            Get
                Return _CO_EngFax
            End Get
            Set(ByVal value As String)
                _CO_EngFax = value
            End Set
        End Property

        ''' <summary>
        ''' 公司中文船運地址
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_ChsShipTo() As String
            Get
                Return _CO_ChsShipTo
            End Get
            Set(ByVal value As String)
                _CO_ChsShipTo = value
            End Set
        End Property

        ''' <summary>
        ''' 公司英文船運地址
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_EngShipTo() As String
            Get
                Return _CO_EngShipTo
            End Get
            Set(ByVal value As String)
                _CO_EngShipTo = value
            End Set
        End Property

        ''' <summary>
        ''' 公司中文送貨地址
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_ChsDeliverTo() As String
            Get
                Return _CO_ChsDeliverTo
            End Get
            Set(ByVal value As String)
                _CO_ChsDeliverTo = value
            End Set
        End Property

        ''' <summary>
        ''' 中文送貨地址電話
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_ChsDeliverTel() As String
            Get
                Return _CO_ChsDeliverTel
            End Get
            Set(ByVal value As String)
                _CO_ChsDeliverTel = value
            End Set
        End Property

        ''' <summary>
        ''' 中文送貨地址傳真
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_ChsDeliverFax() As String
            Get
                Return _CO_ChsDeliverFax
            End Get
            Set(ByVal value As String)
                _CO_ChsDeliverFax = value
            End Set
        End Property

        ''' <summary>
        ''' 英文送貨地址
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_EngDeliverTo() As String
            Get
                Return _CO_EngDeliverTo
            End Get
            Set(ByVal value As String)
                _CO_EngDeliverTo = value
            End Set
        End Property


        ''' <summary>
        ''' 公司英文送貨地址電話
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_EngDeliverTel() As String
            Get
                Return _CO_EngDeliverTel
            End Get
            Set(ByVal value As String)
                _CO_EngDeliverTel = value
            End Set
        End Property

        ''' <summary>
        ''' 公司英文送貨地址傳真
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_EngDeliverFax() As String
            Get
                Return _CO_EngDeliverFax
            End Get
            Set(ByVal value As String)
                _CO_EngDeliverFax = value
            End Set
        End Property

        ''' <summary>
        ''' 公司LOGO
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_Logo() As Byte()
            Get
                Return _CO_Logo
            End Get
            Set(ByVal value As Byte())
                _CO_Logo = value
            End Set
        End Property
        ''' <summary>
        ''' 公司內部編號
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

    End Class

End Namespace
