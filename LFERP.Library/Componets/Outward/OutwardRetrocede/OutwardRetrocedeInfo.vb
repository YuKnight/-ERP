
Namespace LFERP.Library.Outward

    Public Class OutwardRetrocedeInfo
        Private _r_no As String
        Private _r_retrocedeno As String
        Private _a_acceptanceno As String
        Private _o_no As String
        Private _wh_id As String
        Private _s_supplier As String
        Private _a_sendno As String
        Private _r_returndate As Date
        Private _m_code As String
        Private _os_batchid As String
        Private _pm_m_code As String
        Private _r_qty As Double
        Private _r_remarks As String
        Private _r_reason As String
        Private _r_remarkt As String
        Private _r_senddate As Date
        Private _r_returntype As String
        Private _r_detail As String
        Private _r_action As String
        Private _r_ver As Double
        Private _r_updatedate As String

        Private _r_check As Boolean
        Private _r_checkaction As String
        Private _r_checkdate As Date
        Private _r_checktype As String
        Private _r_checkremark As String

        Private _r_accountcheck As Boolean
        Private _r_accountaction As String
        Private _r_accountcheckdate As Date
        Private _r_accountchecktype As String
        Private _r_accountcheckremark As String

        Private _m_name As String
        Private _m_gauge As String
        Private _m_unit As String
        Private _wh_name As String

        Sub New()

            _r_no = Nothing
            _r_retrocedeno = Nothing
            _a_acceptanceno = Nothing
            _o_no = Nothing
            _wh_id = Nothing
            _s_supplier = Nothing
            _a_sendno = Nothing
            _r_returndate = Nothing
            _m_code = Nothing
            _os_batchid = Nothing
            _pm_m_code = Nothing
            _r_qty = 0
            _r_remarks = Nothing
            _r_reason = Nothing
            _r_remarkt = Nothing
            _r_senddate = Nothing
            _r_returntype = Nothing
            _r_detail = Nothing
            _r_action = Nothing
            _r_ver = 0
            _r_updatedate = Nothing

            _r_check = False
            _r_checkaction = Nothing
            _r_checkdate = Nothing
            _r_checktype = Nothing
            _r_checkremark = Nothing

            _r_accountcheck = False
            _r_accountaction = Nothing
            _r_accountcheckdate = Nothing
            _r_accountchecktype = Nothing
            _r_accountcheckremark = Nothing

            _m_name = Nothing
            _m_gauge = Nothing
            _m_unit = Nothing
            _wh_name = Nothing

        End Sub

        ''' <summary>
        ''' 退貨流水號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_NO() As String
            Get
                Return _r_no
            End Get
            Set(ByVal value As String)
                _r_no = value
            End Set
        End Property
        ''' <summary>
        ''' 退貨單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_RetrocedeNO() As String
            Get
                Return _r_retrocedeno
            End Get
            Set(ByVal value As String)
                _r_retrocedeno = value
            End Set
        End Property
        ''' <summary>
        ''' 外發驗收單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_AcceptanceNO() As String
            Get
                Return _a_acceptanceno
            End Get
            Set(ByVal value As String)
                _a_acceptanceno = value
            End Set
        End Property
        ''' <summary>
        ''' 外發單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property O_NO() As String
            Get
                Return _o_no
            End Get
            Set(ByVal value As String)
                _o_no = value
            End Set
        End Property
        ''' <summary>
        ''' 倉庫代號
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
        ''' <summary>
        ''' 供應商代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Supplier() As String
            Get
                Return _s_supplier
            End Get
            Set(ByVal value As String)
                _s_supplier = value
            End Set
        End Property
        ''' <summary>
        ''' 送貨單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_SendNO() As String
            Get
                Return _a_sendno
            End Get
            Set(ByVal value As String)
                _a_sendno = value
            End Set
        End Property
        ''' <summary>
        ''' 退貨日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_ReturnDate() As Date
            Get
                Return _r_returndate
            End Get
            Set(ByVal value As Date)
                _r_returndate = value
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
        ''' 批次編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_BatchID() As String
            Get
                Return _os_batchid
            End Get
            Set(ByVal value As String)
                _os_batchid = value
            End Set
        End Property
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
        ''' 退貨數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_Qty() As Double
            Get
                Return _r_qty
            End Get
            Set(ByVal value As Double)
                _r_qty = value
            End Set
        End Property
        ''' <summary>
        ''' 退貨單項備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_RemarkS() As String
            Get
                Return _r_remarks
            End Get
            Set(ByVal value As String)
                _r_remarks = value
            End Set
        End Property
        ''' <summary>
        ''' 退貨原因
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_Reason() As String
            Get
                Return _r_reason
            End Get
            Set(ByVal value As String)
                _r_reason = value
            End Set
        End Property
        ''' <summary>
        ''' 退貨總備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_RemarkT() As String
            Get
                Return _r_remarkt
            End Get
            Set(ByVal value As String)
                _r_remarkt = value
            End Set
        End Property
        ''' <summary>
        ''' 交回日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_SendDate() As Date
            Get
                Return _r_senddate
            End Get
            Set(ByVal value As Date)
                _r_senddate = value
            End Set
        End Property
        ''' <summary>
        ''' 退貨類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_ReturnType() As String
            Get
                Return _r_returntype
            End Get
            Set(ByVal value As String)
                _r_returntype = value
            End Set
        End Property
        ''' <summary>
        ''' 退貨狀態
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_Detail() As String
            Get
                Return _r_detail
            End Get
            Set(ByVal value As String)
                _r_detail = value
            End Set
        End Property
        ''' <summary>
        ''' 操作員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_Action() As String
            Get
                Return _r_action
            End Get
            Set(ByVal value As String)
                _r_action = value
            End Set
        End Property
        ''' <summary>
        ''' 版本號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_Ver() As Double
            Get
                Return _r_ver
            End Get
            Set(ByVal value As Double)
                _r_ver = value
            End Set
        End Property
        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_UpdateDate() As String
            Get
                Return _r_updatedate
            End Get
            Set(ByVal value As String)
                _r_updatedate = value
            End Set
        End Property
        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_Check() As Boolean
            Get
                Return _r_check
            End Get
            Set(ByVal value As Boolean)
                _r_check = value
            End Set
        End Property
        ''' <summary>
        ''' 審核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_CheckAction() As String
            Get
                Return _r_checkaction
            End Get
            Set(ByVal value As String)
                _r_checkaction = value
            End Set
        End Property
        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_CheckDate() As Date
            Get
                Return _r_checkdate
            End Get
            Set(ByVal value As Date)
                _r_checkdate = value
            End Set
        End Property
        ''' <summary>
        ''' 審核類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_CheckType() As String
            Get
                Return _r_checktype
            End Get
            Set(ByVal value As String)
                _r_checktype = value
            End Set
        End Property
        ''' <summary>
        ''' 審核備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_CheckRemark() As String
            Get
                Return _r_checkremark
            End Get
            Set(ByVal value As String)
                _r_checkremark = value
            End Set
        End Property
        ''' <summary>
        ''' 復核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_AccountCheck() As Boolean
            Get
                Return _r_accountcheck
            End Get
            Set(ByVal value As Boolean)
                _r_accountcheck = value
            End Set
        End Property
        ''' <summary>
        ''' 復核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_AccountAction() As String
            Get
                Return _r_accountaction
            End Get
            Set(ByVal value As String)
                _r_accountaction = value
            End Set
        End Property
        ''' <summary>
        ''' 復核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_AccountCheckDate() As Date
            Get
                Return _r_accountcheckdate
            End Get
            Set(ByVal value As Date)
                _r_accountcheckdate = value
            End Set
        End Property
        ''' <summary>
        ''' 復核類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_AccountCheckType() As String
            Get
                Return _r_accountchecktype
            End Get
            Set(ByVal value As String)
                _r_accountchecktype = value
            End Set
        End Property
        ''' <summary>
        ''' 復核備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_AccountCheckRemark() As String
            Get
                Return _r_accountcheckremark
            End Get
            Set(ByVal value As String)
                _r_accountcheckremark = value
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
        Public Property WH_Name() As String
            Get
                Return _wh_name
            End Get
            Set(ByVal value As String)
                _wh_name = value
            End Set
        End Property

    End Class

End Namespace


