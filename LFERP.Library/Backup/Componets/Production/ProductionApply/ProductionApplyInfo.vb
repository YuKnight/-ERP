
Namespace LFERP.Library.ProductionApply

    Public Class ProductionApplyInfo
        Private _autoid As String
        Private _pa_id As String
        Private _pm_m_code As String
        Private _m_code As String
        Private _m_gauge As String

        Private _m_unit As String
        Private _m_name As String
        Private _pa_qty As Single
        Private _pa_applyreason As String
        Private _pa_applydate As Date

        Private _dpt_id As String
        Private _dpt_name As String
        Private _pa_applypersonname As String
        Private _pa_adduserid As String
        Private _pa_adddate As Date

        Private _pa_modifyuserid As String
        Private _pa_modifydate As Date
        Private _pa_remark As String
        Private _pa_check As Boolean
        Private _pa_checkdate As Date

        Private _pa_checkuserid As String
        Private _pa_checkusername As String
        Private _pa_checktype As String
        Private _pa_checkremark As String

        Sub New()
            _autoid = Nothing
            _pa_id = Nothing
            _pm_m_code = Nothing
            _m_code = Nothing
            _m_gauge = Nothing

            _m_unit = Nothing
            _m_name = Nothing
            _pa_qty = 0
            _pa_applyreason = Nothing
            _pa_applydate = Nothing

            _dpt_id = Nothing
            _dpt_name = Nothing
            _pa_applypersonname = Nothing
            _pa_adduserid = Nothing
            _pa_adddate = Nothing

            _pa_modifyuserid = Nothing
            _pa_modifydate = Nothing
            _pa_remark = Nothing
            _pa_check = False
            _pa_checkdate = Nothing

            _pa_checkuserid = Nothing
            _pa_checkusername = Nothing
            _pa_checktype = Nothing
            _pa_checkremark = Nothing
        End Sub
        ''' <summary>
        ''' 申購單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PA_ID() As String
            Get
                Return _pa_id
            End Get
            Set(ByVal value As String)
                _pa_id = value
            End Set
        End Property

        ''' <summary>
        ''' 自動ID（記錄唯一）
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AutoID() As String
            Get
                Return _autoid
            End Get
            Set(ByVal value As String)
                _autoid = value
            End Set
        End Property

        ''' <summary>
        ''' 產品編號
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
        ''' 物料規格
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
        ''' 數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PA_Qty() As Single
            Get
                Return _pa_qty
            End Get
            Set(ByVal value As Single)
                _pa_qty = value
            End Set
        End Property

        ''' <summary>
        ''' 申購原因
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PA_ApplyReason() As String
            Get
                Return _pa_applyreason
            End Get
            Set(ByVal value As String)
                _pa_applyreason = value
            End Set
        End Property

        ''' <summary>
        ''' 申購日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PA_ApplyDate() As Date
            Get
                Return _pa_applydate
            End Get
            Set(ByVal value As Date)
                _pa_applydate = value
            End Set
        End Property

        ''' <summary>
        ''' 申購部門代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Dpt_ID() As String
            Get
                Return _dpt_id
            End Get
            Set(ByVal value As String)
                _dpt_id = value
            End Set
        End Property

        ''' <summary>
        ''' 申購部門名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Dpt_Name() As String
            Get
                Return _dpt_name
            End Get
            Set(ByVal value As String)
                _dpt_name = value
            End Set
        End Property

        ''' <summary>
        ''' 申購人姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PA_ApplyPersonName() As String
            Get
                Return _pa_applypersonname
            End Get
            Set(ByVal value As String)
                _pa_applypersonname = value
            End Set
        End Property

        ''' <summary>
        ''' 添加人ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PA_AddUserID() As String
            Get
                Return _pa_adduserid
            End Get
            Set(ByVal value As String)
                _pa_adduserid = value
            End Set
        End Property

        ''' <summary>
        ''' 添加日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PA_AddDate() As Date
            Get
                Return _pa_adddate
            End Get
            Set(ByVal value As Date)
                _pa_adddate = value
            End Set
        End Property

        ''' <summary>
        ''' 修改人ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PA_ModifyUserID() As String
            Get
                Return _pa_modifyuserid
            End Get
            Set(ByVal value As String)
                _pa_modifyuserid = value
            End Set
        End Property

        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PA_ModifyDate() As Date
            Get
                Return _pa_modifydate
            End Get
            Set(ByVal value As Date)
                _pa_modifydate = value
            End Set
        End Property

        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PA_Remark() As String
            Get
                Return _pa_remark
            End Get
            Set(ByVal value As String)
                _pa_remark = value
            End Set
        End Property

        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PA_Check() As Boolean
            Get
                Return _pa_check
            End Get
            Set(ByVal value As Boolean)
                _pa_check = value
            End Set
        End Property

        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PA_CheckDate() As Date
            Get
                Return _pa_checkdate
            End Get
            Set(ByVal value As Date)
                _pa_checkdate = value
            End Set
        End Property

        ''' <summary>
        ''' 審核人ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PA_CheckUserID() As String
            Get
                Return _pa_checkuserid
            End Get
            Set(ByVal value As String)
                _pa_checkuserid = value
            End Set
        End Property

        ''' <summary>
        ''' 審核人姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PA_CheckUserName() As String
            Get
                Return _pa_checkusername
            End Get
            Set(ByVal value As String)
                _pa_checkusername = value
            End Set
        End Property

        ''' <summary>
        ''' 審核類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PA_CheckType() As String
            Get
                Return _pa_checktype
            End Get
            Set(ByVal value As String)
                _pa_checktype = value
            End Set
        End Property

        ''' <summary>
        ''' 審核備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PA_CheckRemark() As String
            Get
                Return _pa_checkremark
            End Get
            Set(ByVal value As String)
                _pa_checkremark = value
            End Set
        End Property

    End Class

End Namespace

