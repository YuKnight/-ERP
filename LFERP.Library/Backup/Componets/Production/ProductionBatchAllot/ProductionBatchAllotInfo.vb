Namespace LFERP.Library.ProductionBatchAllot
    Public Class ProductionBatchAllotInfo
        Private _AutoID As String               '自動編號
        Private _PBA_ID As String     '派工單號
        Private _OS_BatchID As String         '批次編號
        Private _PBA_AddUserID As String        '添加人ID
        Private _PBA_AddUserName As String        '添加人姓名

        Private _PBA_AddDate As String     '添加日期
        Private _PBA_ModifyUserID As String     '修改人ID
        Private _PBA_ModifyUserName As String     '修改人姓名
        Private _PBA_ModifyDate As String     '修改日期
        Private _PBA_Check As Boolean      '審核

        Private _PBA_CheckUserID As String     '審核人ID
        Private _PBA_CheckUserName As String     '審核人姓名
        Private _PBA_CheckDate As String     '審核日期
        Private _FacID As String     '廠別編號
        Private _FacName As String     '廠別名稱

        Private _M_Code As String     '物料編碼
        Private _M_Name As String     '物料名稱
        Private _M_Gauge As String     '物料規格
        Private _M_Unit As String     '物料單位
        Private _ON_NeedQty As Double      '需求量

        Private _PBA_Qty As Double     '分派數量
        Private _PBA_Remark As String     '備注


        Sub New()
            _AutoID = Nothing
            _PBA_ID = Nothing
            _OS_BatchID = Nothing
            _PBA_AddUserID = Nothing
            _PBA_AddUserName = Nothing

            _PBA_AddDate = Nothing
            _PBA_ModifyUserID = Nothing
            _PBA_ModifyUserName = Nothing
            _PBA_ModifyDate = Nothing
            _PBA_Check = False

            _PBA_CheckUserID = Nothing
            _PBA_CheckUserName = Nothing
            _PBA_CheckDate = Nothing
            _FacID = Nothing
            _FacName = Nothing

            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _ON_NeedQty = 0

            _PBA_Qty = 0
            _PBA_Remark = Nothing
        End Sub

        ''' <summary>
        ''' 自動編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property
        ''' <summary>
        ''' 派工單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PBA_ID() As String
            Get
                Return _PBA_ID
            End Get
            Set(ByVal value As String)
                _PBA_ID = value
            End Set
        End Property
        ''' <summary>
        ''' 批次編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_BatchID() As String
            Get
                Return _OS_BatchID
            End Get
            Set(ByVal value As String)
                _OS_BatchID = value
            End Set
        End Property
        ''' <summary>
        ''' 添加人ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PBA_AddUserID() As String
            Get
                Return _PBA_AddUserID
            End Get
            Set(ByVal value As String)
                _PBA_AddUserID = value
            End Set
        End Property
        ''' <summary>
        ''' 添加人姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PBA_AddUserName() As String
            Get
                Return _PBA_AddUserName
            End Get
            Set(ByVal value As String)
                _PBA_AddUserName = value
            End Set
        End Property

        ''' <summary>
        ''' 添加日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PBA_AddDate() As String
            Get
                Return _PBA_AddDate
            End Get
            Set(ByVal value As String)
                _PBA_AddDate = value
            End Set
        End Property
        ''' <summary>
        ''' 修改人ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PBA_ModifyUserID() As String
            Get
                Return _PBA_ModifyUserID
            End Get
            Set(ByVal value As String)
                _PBA_ModifyUserID = value
            End Set
        End Property
        ''' <summary>
        ''' 修改人姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PBA_ModifyUserName() As String
            Get
                Return _PBA_ModifyUserName
            End Get
            Set(ByVal value As String)
                _PBA_ModifyUserName = value
            End Set
        End Property
        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PBA_ModifyDate() As String
            Get
                Return _PBA_ModifyDate
            End Get
            Set(ByVal value As String)
                _PBA_ModifyDate = value
            End Set
        End Property
        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PBA_Check() As Boolean
            Get
                Return _PBA_Check
            End Get
            Set(ByVal value As Boolean)
                _PBA_Check = value
            End Set
        End Property

        ''' <summary>
        ''' 審核人ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PBA_CheckUserID() As String
            Get
                Return _PBA_CheckUserID
            End Get
            Set(ByVal value As String)
                _PBA_CheckUserID = value
            End Set
        End Property
        ''' <summary>
        ''' 審核人姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PBA_CheckUserName() As String
            Get
                Return _PBA_CheckUserName
            End Get
            Set(ByVal value As String)
                _PBA_CheckUserName = value
            End Set
        End Property
        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PBA_CheckDate() As String
            Get
                Return _PBA_CheckDate
            End Get
            Set(ByVal value As String)
                _PBA_CheckDate = value
            End Set
        End Property
        ''' <summary>
        ''' 廠別編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FacID() As String
            Get
                Return _FacID
            End Get
            Set(ByVal value As String)
                _FacID = value
            End Set
        End Property
        ''' <summary>
        ''' 廠別名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FacName() As String
            Get
                Return _FacName
            End Get
            Set(ByVal value As String)
                _FacName = value
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
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
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
        ''' 物料規格
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
        ''' 物料單位
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
            End Set
        End Property
        ''' <summary>
        ''' 需求量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ON_NeedQty() As Double
            Get
                Return _ON_NeedQty
            End Get
            Set(ByVal value As Double)
                _ON_NeedQty = value
            End Set
        End Property

        ''' <summary>
        ''' 分派數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PBA_Qty() As Double
            Get
                Return _PBA_Qty
            End Get
            Set(ByVal value As Double)
                _PBA_Qty = value
            End Set
        End Property
        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PBA_Remark() As String
            Get
                Return _PBA_Remark
            End Get
            Set(ByVal value As String)
                _PBA_Remark = value
            End Set
        End Property

    End Class
End Namespace

