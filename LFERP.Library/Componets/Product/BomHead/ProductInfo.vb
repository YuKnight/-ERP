Namespace LFERP.Library.Product
    Public Class ProductInfo
        Private _PM_M_Code As String
        Private _pm_custerid As String
        Private _pm_custerno As String
        Private _pm_action As String
        Private _pm_check As String
        Private _type3id As String
        Private _pm_rank As String
        Private _pm_jiyu As String
        Private _pm_bowei As String
        Private _pm_fangshui As String
        Private _pm_zhuhe As String
        Private _pm_dai As String
        Private _pm_spare As Single
        Private _pm_price As Single
        Private _pm_dinazi As String
        Private _pm_diwaizi As String
        Private _pm_adddate As Date
        Private _pm_editdate As Date
        Private _pm_image As Byte()
        Private _pm_remark As String
        Private _pm_weight As Single

        Private _M_Gauge As String '加產品規格
        Private _Type3Name As String

        Private _PM_ActionName As String

        Private _Prod_Check As Boolean
        Private _Prod_CheckDate As Date
        Private _Prod_CheckID As String
        Private _Prod_CheckName As String
        Private _M_IsEnabled As Boolean
        Private _M_Name As String
        Private _M_Currency As String

        Private _PM_Hide As Boolean
        Private _PM_HideDate As Date
        Private _PM_HideID As String
        Private _PM_HideName As String

        Private _LossRate As Decimal
        Private _PM_Name As String
        Private _PM_ColorCategory As String
        Private _PM_FProductCategory As String

        Private _QPN As String           '2014-05-20  姚駿


        Public Sub New()
            _LossRate = 0
            _PM_Name = Nothing
            _PM_ColorCategory = Nothing
            _PM_FProductCategory = Nothing

            _PM_Hide = False
            _PM_HideDate = Nothing
            _PM_HideID = Nothing
            _PM_HideName = Nothing


            _PM_ActionName = Nothing
            _Type3Name = Nothing
            _M_Gauge = Nothing

            _PM_M_Code = Nothing
            _pm_custerid = Nothing
            _pm_custerno = Nothing
            _pm_action = Nothing
            _pm_check = Nothing
            _type3id = Nothing
            _pm_rank = Nothing
            _pm_jiyu = Nothing
            _pm_bowei = Nothing
            _pm_fangshui = Nothing
            _pm_zhuhe = Nothing
            _pm_dai = Nothing
            _pm_spare = Nothing
            _pm_price = Nothing
            _pm_dinazi = Nothing
            _pm_diwaizi = Nothing
            _pm_adddate = Nothing
            _pm_editdate = Nothing
            _pm_image = Nothing
            _pm_remark = Nothing
            _pm_weight = 0

            _Prod_Check = False
            _Prod_CheckDate = Nothing
            _Prod_CheckID = Nothing
            _Prod_CheckName = Nothing

            _M_IsEnabled = False
            _M_Name = Nothing
            _M_Currency = Nothing

            _QPN = Nothing        '2014-05-20  姚駿

        End Sub

        Public Property LossRate() As Decimal
            Get
                Return _LossRate
            End Get
            Set(ByVal value As Decimal)
                _LossRate = value
            End Set
        End Property

        Public Property PM_Name() As String
            Get
                Return _PM_Name
            End Get
            Set(ByVal value As String)
                _PM_Name = value
            End Set
        End Property

        Public Property PM_ColorCategory() As String
            Get
                Return _PM_ColorCategory
            End Get
            Set(ByVal value As String)
                _PM_ColorCategory = value
            End Set
        End Property

        Public Property PM_FProductCategory() As String
            Get
                Return _PM_FProductCategory
            End Get
            Set(ByVal value As String)
                _PM_FProductCategory = value
            End Set
        End Property

        Public Property PM_Hide() As Boolean
            Get
                Return _PM_Hide
            End Get
            Set(ByVal value As Boolean)
                _PM_Hide = value
            End Set
        End Property

        Public Property PM_HideDate() As Date
            Get
                Return _PM_HideDate
            End Get
            Set(ByVal value As Date)
                _PM_HideDate = value
            End Set
        End Property


        Public Property PM_HideID() As String
            Get
                Return _PM_HideID
            End Get
            Set(ByVal value As String)
                _PM_HideID = value
            End Set
        End Property

        Public Property PM_HideName() As String
            Get
                Return _PM_HideName
            End Get
            Set(ByVal value As String)
                _PM_HideName = value
            End Set
        End Property


        Public Property M_Currency() As String
            Get
                Return _M_Currency
            End Get
            Set(ByVal value As String)
                _M_Currency = value
            End Set
        End Property
        '
        Public Property M_Name() As String
            Get
                Return _M_Name
            End Get
            Set(ByVal value As String)
                _M_Name = value
            End Set
        End Property

        Public Property PM_ActionName() As String
            Get
                Return _PM_ActionName
            End Get
            Set(ByVal value As String)
                _PM_ActionName = value
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

        ''' <summary>
        ''' 產品規格
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
        ''' 聯豐編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
            End Set
        End Property
        ''' <summary>
        ''' 客戶代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_CusterID() As String
            Get
                Return _pm_custerid
            End Get
            Set(ByVal value As String)
                _pm_custerid = value
            End Set
        End Property
        ''' <summary>
        ''' 客戶編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_CusterNO() As String
            Get
                Return _pm_custerno
            End Get
            Set(ByVal value As String)
                _pm_custerno = value
            End Set
        End Property
        ''' <summary>
        ''' 操作員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Action() As String
            Get
                Return _pm_action
            End Get
            Set(ByVal value As String)
                _pm_action = value
            End Set
        End Property
        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Check() As String
            Get
                Return _pm_check
            End Get
            Set(ByVal value As String)
                _pm_check = value
            End Set
        End Property
        ''' <summary>
        ''' 產品類型代號
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
        ''' 等級
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Rank() As String
            Get
                Return _pm_rank
            End Get
            Set(ByVal value As String)
                _pm_rank = value
            End Set
        End Property
        ''' <summary>
        ''' 機玉
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_JiYu() As String
            Get
                Return _pm_jiyu
            End Get
            Set(ByVal value As String)
                _pm_jiyu = value
            End Set
        End Property
        ''' <summary>
        ''' 拔位
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_BoWei() As String
            Get
                Return _pm_bowei
            End Get
            Set(ByVal value As String)
                _pm_bowei = value
            End Set
        End Property
        ''' <summary>
        ''' 防水
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_FangShui() As String
            Get
                Return _pm_fangshui
            End Get
            Set(ByVal value As String)
                _pm_fangshui = value
            End Set
        End Property
        ''' <summary>
        ''' 產品級合
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_ZhuHe() As String
            Get
                Return _pm_zhuhe
            End Get
            Set(ByVal value As String)
                _pm_zhuhe = value
            End Set
        End Property
        ''' <summary>
        ''' 帶
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Dai() As String
            Get
                Return _pm_dai
            End Get
            Set(ByVal value As String)
                _pm_dai = value
            End Set
        End Property
        ''' <summary>
        ''' 士啤
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Spare() As Single
            Get
                Return _pm_spare
            End Get
            Set(ByVal value As Single)
                _pm_spare = value
            End Set
        End Property
        ''' <summary>
        ''' 單價
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Price() As Single
            Get
                Return _pm_price
            End Get
            Set(ByVal value As Single)
                _pm_price = value
            End Set
        End Property
        ''' <summary>
        ''' 底內字
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_DiNaZi() As String
            Get
                Return _pm_dinazi
            End Get
            Set(ByVal value As String)
                _pm_dinazi = value
            End Set
        End Property
        ''' <summary>
        ''' 底外字
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_DiWaiZi() As String
            Get
                Return _pm_diwaizi
            End Get
            Set(ByVal value As String)
                _pm_diwaizi = value
            End Set
        End Property
        ''' <summary>
        ''' 建立日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_AddDate() As Date
            Get
                Return _pm_adddate
            End Get
            Set(ByVal value As Date)
                _pm_adddate = value
            End Set
        End Property
        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_EditDate() As Date
            Get
                Return _pm_editdate
            End Get
            Set(ByVal value As Date)
                _pm_editdate = value
            End Set
        End Property
        ''' <summary>
        ''' 圖片
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Image() As Byte()
            Get
                Return _pm_image
            End Get
            Set(ByVal value As Byte())
                _pm_image = value
            End Set
        End Property
        ''' <summary>
        ''' 備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Remark() As String
            Get
                Return _pm_remark
            End Get
            Set(ByVal value As String)
                _pm_remark = value
            End Set
        End Property
        ''' <summary>
        ''' 產品估算重量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Weight() As Single
            Get
                Return _pm_weight
            End Get
            Set(ByVal value As Single)
                _pm_weight = value
            End Set
        End Property

        Public Property Prod_Check() As Boolean
            Get
                Return _Prod_Check
            End Get
            Set(ByVal value As Boolean)
                _Prod_Check = value
            End Set
        End Property

        Public Property Prod_CheckDate() As Date
            Get
                Return _Prod_CheckDate
            End Get
            Set(ByVal value As Date)
                _Prod_CheckDate = value
            End Set
        End Property


        Public Property Prod_CheckID() As String
            Get
                Return _Prod_CheckID
            End Get
            Set(ByVal value As String)
                _Prod_CheckID = value
            End Set
        End Property

        Public Property Prod_CheckName() As String
            Get
                Return _Prod_CheckName
            End Get
            Set(ByVal value As String)
                _Prod_CheckName = value
            End Set
        End Property

        '
        Public Property M_IsEnabled() As Boolean
            Get
                Return _M_IsEnabled
            End Get
            Set(ByVal value As Boolean)
                _M_IsEnabled = value
            End Set
        End Property

        '2014-05-20  姚駿
        Public Property QPN() As String
            Get
                Return _QPN
            End Get
            Set(ByVal value As String)
                _QPN = value
            End Set
        End Property


    End Class
End Namespace
