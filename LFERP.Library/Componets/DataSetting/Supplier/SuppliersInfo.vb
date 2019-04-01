Namespace LFERP.DataSetting

    Public Class SuppliersInfo
        Private _s_supplier As String
        Private _s_suppliername As String
        Private _s_associate As String
        Private _s_associate1 As String
        Private _s_associate2 As String
        Private _s_tel As String
        Private _s_tel1 As String
        Private _s_tel2 As String
        Private _s_phone As String
        Private _s_phone1 As String
        Private _s_phone2 As String
        Private _s_fax As String
        Private _s_fax1 As String
        Private _s_fax2 As String
        Private _s_email As String
        Private _s_email1 As String
        Private _s_email2 As String
        Private _s_address As String
        Private _s_address1 As String
        Private _s_address2 As String
        Private _s_web As String
        Private _s_typeid As String
        Private _s_currency As String
        Private _s_remark As String
        Private _s_tofrom As String
        Private _s_rank As String
        Private _s_check As Boolean
        Private _s_action As String
        Private _s_CheckAction As String
        Private _s_adddate As String
        Private _s_editdate As String

        Private _s_checkdate As String
        Private _s_rankremark As String
        Private _s_type As String

        Private _s_Recheck As Boolean        '@2012/7/4 添加
        Private _s_ReCheckAction As String   '@2012/7/4 添加
        Private _s_Recheckdate As String     '@2012/7/4 添加

        Private _S_EditUser As String '2013-2-26 修改人


        Public Sub New()
            _s_supplier = Nothing
            _s_suppliername = Nothing
            _s_associate = Nothing
            _s_associate1 = Nothing
            _s_associate2 = Nothing
            _s_tel = Nothing
            _s_tel1 = Nothing
            _s_tel2 = Nothing
            _s_phone = Nothing
            _s_phone1 = Nothing
            _s_phone2 = Nothing
            _s_fax = Nothing
            _s_fax1 = Nothing
            _s_fax2 = Nothing
            _s_email = Nothing
            _s_email1 = Nothing
            _s_email2 = Nothing
            _s_address = Nothing
            _s_address1 = Nothing
            _s_address2 = Nothing
            _s_web = Nothing
            _s_typeid = Nothing
            _s_currency = Nothing
            _s_remark = Nothing
            _s_tofrom = Nothing
            _s_rank = Nothing
            _s_check = Nothing
            _s_action = False
            _s_CheckAction = Nothing
            _s_adddate = Nothing
            _s_editdate = Nothing

            _s_checkdate = Nothing
            _s_rankremark = Nothing
            _s_type = Nothing

            _s_Recheck = False
            _s_ReCheckAction = Nothing
            _s_Recheckdate = Nothing

            _S_EditUser = Nothing
        End Sub
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
        ''' 供應商名稱
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
        ''' 聯系人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Associate() As String
            Get
                Return _s_associate
            End Get
            Set(ByVal value As String)
                _s_associate = value
            End Set
        End Property

        ''' <summary>
        ''' 聯系人1
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Associate1() As String
            Get
                Return _s_associate1
            End Get
            Set(ByVal value As String)
                _s_associate1 = value
            End Set
        End Property

        ''' <summary>
        ''' 聯系人2
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Associate2() As String
            Get
                Return _s_associate2
            End Get
            Set(ByVal value As String)
                _s_associate2 = value
            End Set
        End Property

        ''' <summary>
        ''' 聯系電話
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Tel() As String
            Get
                Return _s_tel
            End Get
            Set(ByVal value As String)
                _s_tel = value
            End Set
        End Property

        ''' <summary>
        ''' 聯系電話1
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Tel1() As String
            Get
                Return _s_tel1
            End Get
            Set(ByVal value As String)
                _s_tel1 = value
            End Set
        End Property

        ''' <summary>
        ''' 聯系電話2
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Tel2() As String
            Get
                Return _s_tel2
            End Get
            Set(ByVal value As String)
                _s_tel2 = value
            End Set
        End Property

        ''' <summary>
        ''' 手機
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Phone() As String
            Get
                Return _s_phone
            End Get
            Set(ByVal value As String)
                _s_phone = value
            End Set
        End Property

        ''' <summary>
        ''' 手機1
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Phone1() As String
            Get
                Return _s_phone1
            End Get
            Set(ByVal value As String)
                _s_phone1 = value
            End Set
        End Property

        ''' <summary>
        ''' 手機2
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Phone2() As String
            Get
                Return _s_phone2
            End Get
            Set(ByVal value As String)
                _s_phone2 = value
            End Set
        End Property

        ''' <summary>
        ''' 傳真
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Fax() As String
            Get
                Return _s_fax
            End Get
            Set(ByVal value As String)
                _s_fax = value
            End Set
        End Property

        ''' <summary>
        ''' 傳真1
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Fax1() As String
            Get
                Return _s_fax1
            End Get
            Set(ByVal value As String)
                _s_fax1 = value
            End Set
        End Property

        ''' <summary>
        ''' 傳真2
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Fax2() As String
            Get
                Return _s_fax2
            End Get
            Set(ByVal value As String)
                _s_fax2 = value
            End Set
        End Property

        ''' <summary>
        ''' 郵箱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Email() As String
            Get
                Return _s_email
            End Get
            Set(ByVal value As String)
                _s_email = value
            End Set
        End Property

        ''' <summary>
        ''' 郵箱1
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Email1() As String
            Get
                Return _s_email1
            End Get
            Set(ByVal value As String)
                _s_email1 = value
            End Set
        End Property

        ''' <summary>
        ''' 郵箱2
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Email2() As String
            Get
                Return _s_email2
            End Get
            Set(ByVal value As String)
                _s_email2 = value
            End Set
        End Property

        ''' <summary>
        ''' 地址
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Address() As String
            Get
                Return _s_address
            End Get
            Set(ByVal value As String)
                _s_address = value
            End Set
        End Property

        ''' <summary>
        ''' 地址1
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Address1() As String
            Get
                Return _s_address1
            End Get
            Set(ByVal value As String)
                _s_address1 = value
            End Set
        End Property

        ''' <summary>
        ''' 地址2
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Address2() As String
            Get
                Return _s_address2
            End Get
            Set(ByVal value As String)
                _s_address2 = value
            End Set
        End Property

        ''' <summary>
        ''' 網站
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Web() As String
            Get
                Return _s_web
            End Get
            Set(ByVal value As String)
                _s_web = value
            End Set
        End Property

        ''' <summary>
        ''' 供應商類型代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_TypeID() As String
            Get
                Return _s_typeid
            End Get
            Set(ByVal value As String)
                _s_typeid = value
            End Set
        End Property

        ''' <summary>
        ''' 幣別
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Currency() As String
            Get
                Return _s_currency
            End Get
            Set(ByVal value As String)
                _s_currency = value
            End Set
        End Property

        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Remark() As String
            Get
                Return _s_remark
            End Get
            Set(ByVal value As String)
                _s_remark = value
            End Set
        End Property

        ''' <summary>
        ''' 付款方式
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_ToFrom() As String
            Get
                Return _s_tofrom
            End Get
            Set(ByVal value As String)
                _s_tofrom = value
            End Set
        End Property

        ''' <summary>
        ''' 信用等級
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Rank() As String
            Get
                Return _s_rank
            End Get
            Set(ByVal value As String)
                _s_rank = value
            End Set
        End Property

        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Check() As Boolean
            Get
                Return _s_check
            End Get
            Set(ByVal value As Boolean)
                _s_check = value
            End Set
        End Property

        ''' <summary>
        ''' 操作員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Action() As String
            Get
                Return _s_action
            End Get
            Set(ByVal value As String)
                _s_action = value
            End Set
        End Property

        ''' <summary>
        ''' 審核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_CheckAction() As String
            Get
                Return _s_CheckAction
            End Get
            Set(ByVal value As String)
                _s_CheckAction = value
            End Set
        End Property


        ''' <summary>
        ''' 新增日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_AddDate() As String
            Get
                Return _s_adddate
            End Get
            Set(ByVal value As String)
                _s_adddate = value
            End Set
        End Property

        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_EditDate() As String
            Get
                Return _s_editdate
            End Get
            Set(ByVal value As String)
                _s_editdate = value
            End Set
        End Property
        Public Property S_CheckDate() As String
            Get
                Return _s_checkdate
            End Get
            Set(ByVal value As String)
                _s_checkdate = value
            End Set
        End Property
        Public Property S_RankRemark() As String
            Get
                Return _s_rankremark
            End Get
            Set(ByVal value As String)
                _s_rankremark = value
            End Set
        End Property
        Public Property S_Type() As String  '2010-11-25 供應商類型
            Get
                Return _s_type
            End Get
            Set(ByVal value As String)
                _s_type = value
            End Set
        End Property

        ''' <summary>
        ''' 復核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_ReCheck() As Boolean
            Get
                Return _s_Recheck
            End Get
            Set(ByVal value As Boolean)
                _s_Recheck = value
            End Set
        End Property

        ''' <summary>
        ''' 復核人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_ReCheckAction() As String
            Get
                Return _s_ReCheckAction
            End Get
            Set(ByVal value As String)
                _s_ReCheckAction = value
            End Set
        End Property
        ''' <summary>
        ''' 復核時間
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_ReCheckDate() As String
            Get
                Return _s_Recheckdate
            End Get
            Set(ByVal value As String)
                _s_Recheckdate = value
            End Set
        End Property

        ''' <summary>
        ''' 修改人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_EditUser() As String
            Get
                Return _S_EditUser
            End Get
            Set(ByVal value As String)
                _S_EditUser = value
            End Set
        End Property

    End Class
End Namespace

