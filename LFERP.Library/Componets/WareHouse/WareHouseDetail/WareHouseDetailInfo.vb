

Namespace LFERP.Library.WareHouseDetail

    Public Class WareHouseDetailInfo
        '----------此模塊為了實際掌握倉庫模塊中關於物料實際的入庫,出庫,調撥入,調撥出的詳細記錄狀況信息-------------

        Private _M_Code As String  '物料編碼
        Private _M_Name As String  '物料名稱
        Private _WH_ID As String  '倉庫編碼
        Private _WH_Name As String  '倉庫名稱
        Private _WH_UpName As String  '上一級倉庫名稱

        Private _ID As String '實際操作ID,入庫單號.出庫單號.調撥單號
        Private _Qty As Double  '當前單號操作時數量
        Private _strDate As Date '操作審核時間
        Private _EndQty As Double '當前操作完畢后結餘數(期末結餘數)
        Private _strType As String   '類型屬性(入庫,出庫,調撥入,調撥出)

        Private _Remark As String   '備註信息
        Private _AP_NO As String   '出庫申領單號
        Private _WO_PerName As String '倉庫領料人
        Private _CardID As String '刷卡人

        '2013-3-11
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _W_Type As String '入庫,出庫,調撥入,調撥出,拆分

        ''2013-5-13

        Private _type1id As String
        Private _type1name As String
        Private _type2id As String
        Private _type2name As String
        Private _type3id As String
        Private _type3name As String

        Private _WType As String '入庫,出庫,調撥入,調撥出,拆分
        Private _SType As String


        Sub New()
            _M_Code = Nothing
            _M_Name = Nothing
            _WH_ID = Nothing
            _WH_Name = Nothing
            _WH_UpName = Nothing

            _ID = Nothing
            _Qty = 0
            _strDate = Nothing
            _EndQty = 0
            _strType = Nothing

            _Remark = Nothing
            _AP_NO = Nothing
            _WO_PerName = Nothing
            _CardID = Nothing
            '2013-3-11
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _W_Type = Nothing

            '2013-5-13
            _type1id = Nothing
            _type1name = Nothing
            _type2id = Nothing
            _type2name = Nothing
            _type3id = Nothing
            _type3name = Nothing
            _WType = Nothing
            _SType = Nothing


        End Sub

        ''--2013-5-13------------------------------------------------------------------------------
        Public Property SType() As String
            Get
                Return _SType
            End Get
            Set(ByVal value As String)
                _SType = value
            End Set
        End Property

        Public Property WType() As String
            Get
                Return _WType
            End Get
            Set(ByVal value As String)
                _WType = value
            End Set
        End Property

        Public Property Type1ID() As String
            Get
                Return _type1id
            End Get
            Set(ByVal value As String)
                _type1id = value
            End Set
        End Property
        Public Property Type1Name() As String
            Get
                Return _type1name
            End Get
            Set(ByVal value As String)
                _type1name = value
            End Set
        End Property
        Public Property Type2ID() As String
            Get
                Return _type2id
            End Get
            Set(ByVal value As String)
                _type2id = value
            End Set
        End Property
        Public Property Type2Name() As String
            Get
                Return _type2name
            End Get
            Set(ByVal value As String)
                _type2name = value
            End Set
        End Property
        Public Property Type3ID() As String
            Get
                Return _type3id
            End Get
            Set(ByVal value As String)
                _type3id = value
            End Set
        End Property
        Public Property Type3Name() As String
            Get
                Return _type3name
            End Get
            Set(ByVal value As String)
                _type3name = value
            End Set
        End Property

        ''--------------------------------------------------------------------------------
        Public Property W_Type() As String
            Get
                Return _W_Type
            End Get
            Set(ByVal value As String)
                _W_Type = value
            End Set
        End Property


        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
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
        Public Property WH_ID() As String
            Get
                Return _WH_ID
            End Get
            Set(ByVal value As String)
                _WH_ID = value
            End Set
        End Property
        Public Property WH_Name() As String
            Get
                Return _WH_Name
            End Get
            Set(ByVal value As String)
                _WH_Name = value
            End Set
        End Property
        Public Property WH_UpName() As String
            Get
                Return _WH_UpName
            End Get
            Set(ByVal value As String)
                _WH_UpName = value
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
        Public Property Qty() As Double
            Get
                Return _Qty
            End Get
            Set(ByVal value As Double)
                _Qty = value
            End Set
        End Property
        Public Property strDate() As Date
            Get
                Return _strDate
            End Get
            Set(ByVal value As Date)
                _strDate = value
            End Set
        End Property
        Public Property EndQty() As Double
            Get
                Return _EndQty
            End Get
            Set(ByVal value As Double)
                _EndQty = value
            End Set
        End Property

        Public Property strType() As String
            Get
                Return _strType
            End Get
            Set(ByVal value As String)
                _strType = value
            End Set
        End Property
        Public Property Remark() As String
            Get
                Return _Remark
            End Get
            Set(ByVal value As String)
                _Remark = value
            End Set
        End Property
        Public Property AP_NO() As String
            Get
                Return _AP_NO
            End Get
            Set(ByVal value As String)
                _AP_NO = value
            End Set
        End Property
        Public Property WO_PerName() As String
            Get
                Return _WO_PerName
            End Get
            Set(ByVal value As String)
                _WO_PerName = value
            End Set
        End Property
        Public Property CardID() As String
            Get
                Return _CardID
            End Get
            Set(ByVal value As String)
                _CardID = value
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

    End Class

End Namespace

