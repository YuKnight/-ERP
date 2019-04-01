Namespace LFERP.Library.ProductionOutProcess

    Public Class ProductionOutProcessInfo

        Private _autoid As String
        Private _po_id As String
        Private _po_type As String
        Private _po_outdate As Date
        Private _po_username As String

        Private _s_supplier As String
        Private _s_suppliername As String
        Private _po_remark As String
        Private _pm_m_code As String
        Private _pm_type As String

        Private _po_proattribute As String
        Private _ps_no As String
        Private _ps_name As String
        Private _ow_do As String
        Private _po_qty As Integer

        Private _po_nosendqty As Integer
        Private _po_pm_remark As String
        Private _po_check As Boolean
        Private _po_checkdate As Date
        Private _po_checkuserid As String

        Private _po_checkusername As String
        Private _po_checkremark As String
        Private _adduserid As String
        Private _adddate As Date
        Private _modifyuserid As String

        Private _modifydate As Date
        Private _PM_JiYu As String


        ''2013-3-9 增加更改單
        Private _RecordNO As String
        Private _R_Qty As Double
        Private _N_Qty As Double
        Private _R_Action As String
        Private _R_Date As Date
        Private _R_Remark As String
        Private _R_ActionName As String

        '2014-04-04  姚駿
        Private _PO_PM_NO As String
        Private _PO_PM_Type As String

        Private _PO_PM_People As String
        Private _PO_PM_BefRemark As String
        Private _PO_PM_LstRemark As String
        Private _PM_RemarkTime As String


        Sub New()

            PM_JiYu = Nothing
            _autoid = Nothing
            _po_id = Nothing
            _po_type = Nothing
            _po_outdate = Nothing
            _po_username = Nothing

            _s_supplier = Nothing
            _s_suppliername = Nothing
            _po_remark = Nothing
            _pm_m_code = Nothing
            _pm_type = Nothing

            _po_proattribute = Nothing
            _ps_no = Nothing
            _ps_name = Nothing
            _ow_do = Nothing
            _po_qty = 0

            _po_nosendqty = 0
            _po_pm_remark = Nothing
            _po_check = False
            _po_checkdate = Nothing
            _po_checkuserid = Nothing

            _po_checkusername = Nothing
            _po_checkremark = Nothing
            _adduserid = Nothing
            _adddate = Nothing
            _modifyuserid = Nothing

            _modifydate = Nothing


            ''2013-3-9 增加更改單
            _RecordNO = Nothing
            _R_Qty = 0
            _N_Qty = 0
            _R_Action = Nothing
            _R_Date = Nothing
            _R_Remark = Nothing
            _R_ActionName = Nothing

            '2014-04-04  姚駿
            _PO_PM_People = Nothing
            _PO_PM_BefRemark = Nothing
            _PO_PM_LstRemark = Nothing
            _PM_RemarkTime = Nothing

            _PO_PM_NO = Nothing
            _PO_PM_Type = Nothing

        End Sub

        ''' <summary>
        ''' 機玉
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_JiYu() As String
            Get
                Return _PM_JiYu
            End Get
            Set(ByVal value As String)
                _PM_JiYu = value
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
        ''' 外發單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_ID() As String
            Get
                Return _po_id
            End Get
            Set(ByVal value As String)
                _po_id = value
            End Set
        End Property
        ''' <summary>
        ''' 外發類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_Type() As String
            Get
                Return _po_type
            End Get
            Set(ByVal value As String)
                _po_type = value
            End Set
        End Property
        ''' <summary>
        ''' 外發日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_OutDate() As Date
            Get
                Return _po_outdate
            End Get
            Set(ByVal value As Date)
                _po_outdate = value
            End Set
        End Property
        ''' <summary>
        ''' 外發人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_UserName() As String
            Get
                Return _po_username
            End Get
            Set(ByVal value As String)
                _po_username = value
            End Set
        End Property
        ''' <summary>
        ''' 外發供應商編號
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
        ''' 外發供應商名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_SupplierName() As String
            Get
                Return _s_suppliername
            End Get
            Set(ByVal value As String)
                _s_suppliername = value
            End Set
        End Property
        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_Remark() As String
            Get
                Return _po_remark
            End Get
            Set(ByVal value As String)
                _po_remark = value
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
        ''' 配件名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Type() As String
            Get
                Return _pm_type
            End Get
            Set(ByVal value As String)
                _pm_type = value
            End Set
        End Property
        ''' <summary>
        ''' 加工屬性
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_ProAttribute() As String
            Get
                Return _po_proattribute
            End Get
            Set(ByVal value As String)
                _po_proattribute = value
            End Set
        End Property
        ''' <summary>
        ''' 工序編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_NO() As String
            Get
                Return _ps_no
            End Get
            Set(ByVal value As String)
                _ps_no = value
            End Set
        End Property
        ''' <summary>
        ''' 工序名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Name() As String
            Get
                Return _ps_name
            End Get
            Set(ByVal value As String)
                _ps_name = value
            End Set
        End Property
        ''' <summary>
        ''' 加工要求
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OW_Do() As String
            Get
                Return _ow_do
            End Get
            Set(ByVal value As String)
                _ow_do = value
            End Set
        End Property
        ''' <summary>
        ''' 數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_Qty() As Integer
            Get
                Return _po_qty
            End Get
            Set(ByVal value As Integer)
                _po_qty = value
            End Set
        End Property
        ''' <summary>
        ''' 未交數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_NoSendQty() As Integer
            Get
                Return _po_nosendqty
            End Get
            Set(ByVal value As Integer)
                _po_nosendqty = value
            End Set
        End Property

        ''' <summary>
        ''' 產品備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_PM_Remark() As String
            Get
                Return _po_pm_remark
            End Get
            Set(ByVal value As String)
                _po_pm_remark = value
            End Set
        End Property
        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_Check() As Boolean
            Get
                Return _po_check
            End Get
            Set(ByVal value As Boolean)
                _po_check = value
            End Set
        End Property
        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_CheckDate() As Date
            Get
                Return _po_checkdate
            End Get
            Set(ByVal value As Date)
                _po_checkdate = value
            End Set
        End Property
        ''' <summary>
        ''' 審核人ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_CheckUserID() As String
            Get
                Return _po_checkuserid
            End Get
            Set(ByVal value As String)
                _po_checkuserid = value
            End Set
        End Property
        ''' <summary>
        ''' 審核人姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_CheckUserName() As String
            Get
                Return _po_checkusername
            End Get
            Set(ByVal value As String)
                _po_checkusername = value
            End Set
        End Property

        ''' <summary>
        ''' 審核備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_CheckRemark() As String
            Get
                Return _po_checkremark
            End Get
            Set(ByVal value As String)
                _po_checkremark = value
            End Set
        End Property
        ''' <summary>
        ''' 添加人ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AddUserID() As String
            Get
                Return _adduserid
            End Get
            Set(ByVal value As String)
                _adduserid = value
            End Set
        End Property
        ''' <summary>
        ''' 添加日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AddDate() As Date
            Get
                Return _adddate
            End Get
            Set(ByVal value As Date)
                _adddate = value
            End Set
        End Property
        ''' <summary>
        ''' 修改人ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ModifyUserID() As String
            Get
                Return _modifyuserid
            End Get
            Set(ByVal value As String)
                _modifyuserid = value
            End Set
        End Property
        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ModifyDate() As Date
            Get
                Return _modifydate
            End Get
            Set(ByVal value As Date)
                _modifydate = value
            End Set
        End Property


        ''2013-3-9 增加更改單
        '_RecordNO = 0
        '_R_Qty = 0
        '_N_Qty = 0
        '_R_Action = Nothing
     
        Public Property RecordNO() As String
            Get
                Return _RecordNO
            End Get
            Set(ByVal value As String)
                _RecordNO = value
            End Set
        End Property

        Public Property R_Qty() As Double
            Get
                Return _R_Qty
            End Get
            Set(ByVal value As Double)
                _R_Qty = value
            End Set
        End Property

        Public Property N_Qty() As Double
            Get
                Return _N_Qty
            End Get
            Set(ByVal value As Double)
                _N_Qty = value
            End Set
        End Property

        Public Property R_Action() As String
            Get
                Return _R_Action
            End Get
            Set(ByVal value As String)
                _R_Action = value
            End Set
        End Property

        '_R_Date = Nothing
        '_R_Remark = Nothing
        '_R_ActionName = Nothing

        Public Property R_Date() As Date
            Get
                Return _R_Date
            End Get
            Set(ByVal value As Date)
                _R_Date = value
            End Set
        End Property

        Public Property R_Remark() As String
            Get
                Return _R_Remark
            End Get
            Set(ByVal value As String)
                _R_Remark = value
            End Set
        End Property

        Public Property R_ActionName() As String
            Get
                Return _R_ActionName
            End Get
            Set(ByVal value As String)
                _R_ActionName = value
            End Set
        End Property

        '2014-04-04 姚駿
        Public Property PO_People() As String
            Get
                Return _PO_PM_People
            End Get
            Set(ByVal value As String)
                _PO_PM_People = value
            End Set
        End Property

        Public Property PO_PM_BefRemark() As String
            Get
                Return _PO_PM_BefRemark
            End Get
            Set(ByVal value As String)
                _PO_PM_BefRemark = value
            End Set
        End Property

        Public Property PO_PM_LstRemark() As String
            Get
                Return _PO_PM_LstRemark
            End Get
            Set(ByVal value As String)
                _PO_PM_LstRemark = value
            End Set
        End Property

        Public Property PM_RemarkTime() As String
            Get
                Return _PM_RemarkTime
            End Get
            Set(ByVal value As String)
                _PM_RemarkTime = value
            End Set
        End Property

        Public Property PO_PM_NO() As String
            Get
                Return _PO_PM_NO
            End Get
            Set(ByVal value As String)
                _PO_PM_NO = value
            End Set
        End Property

        Public Property PO_PM_Type() As String
            Get
                Return _PO_PM_Type
            End Get
            Set(ByVal value As String)
                _PO_PM_Type = value
            End Set
        End Property


    End Class

End Namespace


