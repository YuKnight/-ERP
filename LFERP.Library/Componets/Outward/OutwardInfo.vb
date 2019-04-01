Namespace LFERP.Library.Outward

    Public Class OutwardInfo
        '------------------------------------------主表基本信息
        Private _o_no As String
        Private _o_type As String
        Private _o_date As Date
        Private _o_action As String
        Private _o_remark As String
        Private _wh_id As String
        Private _s_supplier As String
        '------------------------------------------主表中審核
        Private _o_check As Boolean
        Private _o_checkaction As String
        Private _o_checkdate As Date
        Private _o_checkremark As String
        '------------------------------------------主表中復核
        Private _o_acccheck As Boolean
        Private _o_acccheckaction As String
        Private _o_acccheckdate As Date
        Private _o_acccheckremark As String
        Private _o_accchecktype As String
        '------------------------------------------ 子表基本信息
        Private _o_nosub As String
        Private _m_code As String
        Private _pm_m_code As String
        Private _os_qty As Double
        Private _os_nosendqty As Double
        Private _os_price As Double
        Private _os_itemtype As String
        Private _os_depict As String
        Private _os_batchid As String
        Private _os_remark As String
        '------------------------------------------ 
        Private _m_name As String
        Private _m_gauge As String
        Private _m_unit As String
        Private _suppliername As String
        Private _itemtype As String
        '-------------------------------------------
        Private _ot_no As String
        Private _ot_name As String
        Private _ot_ptype As String
        Private _actionname As String
        Private _checkactionname As String
        Private _acccheckactionname As String
        Private _wh_name As String

        Private _OP_NO As String
        Private _OP_Name As String
        Private _ExtraName As String




        Sub New()

            '------------------------------------------
            _o_no = Nothing
            _o_type = Nothing
            _o_date = Nothing
            _o_action = Nothing
            _o_remark = Nothing
            _wh_id = Nothing
            _s_supplier = Nothing

            '------------------------------------------
            _o_check = False
            _o_checkaction = Nothing
            _o_checkdate = Nothing
            _o_checkremark = Nothing

            '------------------------------------------
            _o_acccheck = False
            _o_acccheckaction = Nothing
            _o_acccheckdate = Nothing
            _o_acccheckremark = Nothing
            _o_accchecktype = Nothing

            '------------------------------------------
            _o_nosub = Nothing
            _m_code = Nothing
            _pm_m_code = Nothing
            _os_qty = 0
            _os_nosendqty = 0
            _os_price = 0
            _os_itemtype = Nothing
            _os_depict = Nothing
            _os_batchid = Nothing
            _os_remark = Nothing
            '------------------------------------------
            _m_name = Nothing
            _m_gauge = Nothing
            _m_unit = Nothing
            _suppliername = Nothing
            _itemtype = Nothing
            '------------------------------------------
            _ot_no = Nothing
            _ot_name = Nothing
            _ot_ptype = Nothing
            _actionname = Nothing
            _checkactionname = Nothing
            _acccheckactionname = Nothing
            _wh_name = Nothing

            _OP_NO = Nothing
            _OP_Name = Nothing
            _ExtraName = Nothing


        End Sub
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
        ''' 外發類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property O_Type() As String
            Get
                Return _o_type
            End Get
            Set(ByVal value As String)
                _o_type = value
            End Set
        End Property
        ''' <summary>
        ''' 外發日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property O_Date() As Date
            Get
                Return _o_date
            End Get
            Set(ByVal value As Date)
                _o_date = value
            End Set
        End Property
        ''' <summary>
        ''' 操作員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property O_Action() As String
            Get
                Return _o_action
            End Get
            Set(ByVal value As String)
                _o_action = value
            End Set
        End Property
        ''' <summary>
        ''' 主表備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property O_Remark() As String
            Get
                Return _o_remark
            End Get
            Set(ByVal value As String)
                _o_remark = value
            End Set
        End Property
        ''' <summary>
        ''' 倉庫編號
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
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property O_Check() As Boolean
            Get
                Return _o_check
            End Get
            Set(ByVal value As Boolean)
                _o_check = value
            End Set
        End Property
        ''' <summary>
        ''' 審核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property O_CheckAction() As String
            Get
                Return _o_checkaction
            End Get
            Set(ByVal value As String)
                _o_checkaction = value
            End Set
        End Property
        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property O_CheckDate() As Date
            Get
                Return _o_checkdate
            End Get
            Set(ByVal value As Date)
                _o_checkdate = value
            End Set
        End Property
        ''' <summary>
        ''' 審核備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property O_CheckRemark() As String
            Get
                Return _o_checkremark
            End Get
            Set(ByVal value As String)
                _o_checkremark = value
            End Set
        End Property
        ''' <summary>
        ''' 復核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property O_AccCheck() As Boolean
            Get
                Return _o_acccheck
            End Get
            Set(ByVal value As Boolean)
                _o_acccheck = value
            End Set
        End Property
        ''' <summary>
        ''' 復核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property O_AccCheckAction() As String
            Get
                Return _o_acccheckaction
            End Get
            Set(ByVal value As String)
                _o_acccheckaction = value
            End Set
        End Property
        ''' <summary>
        ''' 復核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property O_AccCheckDate() As Date
            Get
                Return _o_acccheckdate
            End Get
            Set(ByVal value As Date)
                _o_acccheckdate = value
            End Set
        End Property
        ''' <summary>
        ''' 復核備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property O_AccCheckRemark() As String
            Get
                Return _o_acccheckremark
            End Get
            Set(ByVal value As String)
                _o_acccheckremark = value
            End Set
        End Property
        ''' <summary>
        ''' 復核類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property O_AccCheckType() As String
            Get
                Return _o_accchecktype
            End Get
            Set(ByVal value As String)
                _o_accchecktype = value
            End Set
        End Property
        ''' <summary>
        ''' 外發流水號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property O_NOsub() As String
            Get
                Return _o_nosub
            End Get
            Set(ByVal value As String)
                _o_nosub = value
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
        Public Property PM_M_Code() As String
            Get
                Return _pm_m_code
            End Get
            Set(ByVal value As String)
                _pm_m_code = value
            End Set
        End Property
        ''' <summary>
        ''' 外發數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_Qty() As Double
            Get
                Return _os_qty
            End Get
            Set(ByVal value As Double)
                _os_qty = value
            End Set
        End Property
        ''' <summary>
        ''' 外發未交數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_NoSendQty() As Double
            Get
                Return _os_nosendqty
            End Get
            Set(ByVal value As Double)
                _os_nosendqty = value
            End Set
        End Property
        ''' <summary>
        ''' 外發單價
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_Price() As Double
            Get
                Return _os_price
            End Get
            Set(ByVal value As Double)
                _os_price = value
            End Set
        End Property
        ''' <summary>
        ''' 項目類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_ItemType() As String
            Get
                Return _os_itemtype
            End Get
            Set(ByVal value As String)
                _os_itemtype = value
            End Set
        End Property
        ''' <summary>
        ''' 描述
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_Depict() As String
            Get
                Return _os_depict
            End Get
            Set(ByVal value As String)
                _os_depict = value
            End Set
        End Property
        ''' <summary>
        ''' 批次
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
        ''' 子表備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_Remark() As String
            Get
                Return _os_remark
            End Get
            Set(ByVal value As String)
                _os_remark = value
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
        ''' <summary>
        ''' 供應商名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property SupplierName() As String
            Get
                Return _suppliername
            End Get
            Set(ByVal value As String)
                _suppliername = value
            End Set
        End Property
        ''' <summary>
        ''' 加工屬性(名稱)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ItemType() As String
            Get
                Return _itemtype
            End Get
            Set(ByVal value As String)
                _itemtype = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OT_NO() As String
            Get
                Return _ot_no
            End Get
            Set(ByVal value As String)
                _ot_no = value
            End Set
        End Property
        Public Property OT_Name() As String
            Get
                Return _ot_name
            End Get
            Set(ByVal value As String)
                _ot_name = value
            End Set
        End Property
        Public Property OT_PType() As String
            Get
                Return _ot_ptype
            End Get
            Set(ByVal value As String)
                _ot_ptype = value
            End Set
        End Property
        Public Property ActionName() As String
            Get
                Return _actionname
            End Get
            Set(ByVal value As String)
                _actionname = value
            End Set
        End Property
        Public Property CheckActionName() As String
            Get
                Return _checkactionname
            End Get
            Set(ByVal value As String)
                _checkactionname = value
            End Set
        End Property
        Public Property AccCheckActionName() As String
            Get
                Return _acccheckactionname
            End Get
            Set(ByVal value As String)
                _acccheckactionname = value
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
        Public Property OP_NO() As String
            Get
                Return _OP_NO
            End Get
            Set(ByVal value As String)
                _OP_NO = value
            End Set
        End Property
        Public Property OP_Name() As String
            Get
                Return _OP_Name
            End Get
            Set(ByVal value As String)
                _OP_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 供應商(附加名稱)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ExtraName() As String
            Get
                Return _ExtraName
            End Get
            Set(ByVal value As String)
                _ExtraName = value
            End Set
        End Property
    End Class

End Namespace

