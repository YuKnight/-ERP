Namespace LFERP.Library.ProductionShipment



    Public Class ProductionShipmentInfo

        Private _PS_NO As String ''             出貨單號                
        Private _PM_M_Code As String '        產品編號                     
        Private _PM_Type As String '         產品類型                 
        Private _M_Code As String '            物料編碼
        Private _PS_WareID As String          '' 出貨倉庫
        Private _PS_Qty As Integer '            出貨數量int

        Private _PS_Type As String '          出貨類型
        Private _PS_Action As String '         出貨人工號   
        Private _PS_Date As String '          出貨日期 smalldatetime
        Private _PS_Remark As String '         出貨備註
        Private _PS_Check As Boolean '          審核（是否確認出貨）bit

        Private _PS_CheckAction As String '    審核人 編號
        Private _PS_CheckDate As String  '     審核日期 smalldatetime
        Private _PS_CheckRemark As String '    審核備註

        ' 在與其它表相連接的字段

        Private _PS_OutName As String
        Private _PS_M_Unit As String
        Private _PS_M_Name As String
        Private _PS_CheckAction_N As String '    審核人名
        Private _PS_Action_N As String '         出貨人工號   
        Private _PS_M_Gauge As String

        Private _PS_NO_Sub As String   ''單一物料流水號
        Private _PS_Detail As String  ''出貨。入貨
        Private _PS_SubRemark As String

        Sub New()

            _PS_NO = Nothing     '1
            _PM_M_Code = Nothing '2
            _PM_Type = Nothing '3
            _M_Code = Nothing '4
            _PS_WareID = Nothing '5
            _PS_Qty = 0

            _PS_Type = Nothing
            _PS_Action = Nothing
            _PS_Date = Nothing
            _PS_Remark = Nothing
            _PS_Check = False

            _PS_CheckAction = Nothing
            _PS_CheckDate = Nothing
            _PS_CheckRemark = Nothing

            _PS_OutName = Nothing
            _PS_M_Unit = Nothing
            _PS_M_Name = Nothing
            _PS_CheckAction_N = Nothing
            _PS_Action_N = Nothing

            _PS_NO_Sub = Nothing
            _PS_Detail = Nothing

            _PS_SubRemark = Nothing
        End Sub

        Public Property PS_NO() As String
            Get
                Return _PS_NO
            End Get
            Set(ByVal value As String)
                _PS_NO = value
            End Set
        End Property
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
            End Set
        End Property
        Public Property PM_Type() As String
            Get
                Return _PM_Type
            End Get
            Set(ByVal value As String)
                _PM_Type = value
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

        Public Property PS_WareID() As String
            Get
                Return _PS_WareID
            End Get
            Set(ByVal value As String)
                _PS_WareID = value
            End Set
        End Property

        Public Property PS_Qty() As Integer
            Get
                Return _PS_Qty
            End Get
            Set(ByVal value As Integer)
                _PS_Qty = value
            End Set
        End Property

        ' _PS_Type = Nothing
        '_PS_Action = Nothing
        '_PS_Date = Nothing
        '_PS_Remark = Nothing
        '_PS_Check = Nothing
        ''---------------------------------------------------
        Public Property PS_Type() As String
            Get
                Return _PS_Type
            End Get
            Set(ByVal value As String)
                _PS_Type = value
            End Set
        End Property

        Public Property PS_Action() As String
            Get
                Return _PS_Action
            End Get
            Set(ByVal value As String)
                _PS_Action = value
            End Set
        End Property


        Public Property PS_Date() As String
            Get
                Return _PS_Date
            End Get
            Set(ByVal value As String)
                _PS_Date = value
            End Set
        End Property

        Public Property PS_Remark() As String
            Get
                Return _PS_Remark
            End Get
            Set(ByVal value As String)
                _PS_Remark = value
            End Set
        End Property

        Public Property PS_Check() As Boolean
            Get
                Return _PS_Check
            End Get
            Set(ByVal value As Boolean)
                _PS_Check = value
            End Set
        End Property

        '_       PS_CheckAction = False
        '       _PS_CheckDate = Nothing
        '       _PS_CheckRemark = Nothing

        Public Property PS_CheckAction() As String
            Get
                Return _PS_CheckAction
            End Get
            Set(ByVal value As String)
                _PS_CheckAction = value
            End Set
        End Property

        Public Property PS_CheckDate() As String
            Get
                Return _PS_CheckDate
            End Get
            Set(ByVal value As String)
                _PS_CheckDate = value
            End Set
        End Property

        Public Property PS_CheckRemark() As String
            Get
                Return _PS_CheckRemark
            End Get
            Set(ByVal value As String)
                _PS_CheckRemark = value
            End Set
        End Property



        Public Property PS_OutName() As String
            Get
                Return _PS_OutName
            End Get
            Set(ByVal value As String)
                _PS_OutName = value
            End Set
        End Property


        Public Property PS_M_Unit() As String
            Get
                Return _PS_M_Unit
            End Get
            Set(ByVal value As String)
                _PS_M_Unit = value
            End Set
        End Property


        Public Property PS_M_Name() As String
            Get
                Return _PS_M_Name
            End Get
            Set(ByVal value As String)
                _PS_M_Name = value
            End Set
        End Property


        Public Property PS_CheckAction_N() As String
            Get
                Return _PS_CheckAction_N
            End Get
            Set(ByVal value As String)
                _PS_CheckAction_N = value
            End Set
        End Property


        Public Property PS_Action_N() As String
            Get
                Return _PS_Action_N
            End Get
            Set(ByVal value As String)
                _PS_Action_N = value
            End Set
        End Property


        Public Property PS_M_Gauge() As String
            Get
                Return _PS_M_Gauge
            End Get
            Set(ByVal value As String)
                _PS_M_Gauge = value
            End Set
        End Property


        Public Property PS_NO_Sub() As String
            Get
                Return _PS_NO_Sub
            End Get
            Set(ByVal value As String)
                _PS_NO_Sub = value
            End Set
        End Property

        Public Property PS_Detail() As String
            Get
                Return _PS_Detail
            End Get
            Set(ByVal value As String)
                _PS_Detail = value
            End Set
        End Property


        Public Property PS_SubRemark() As String
            Get
                Return _PS_SubRemark
            End Get
            Set(ByVal value As String)
                _PS_SubRemark = value
            End Set
        End Property

    End Class


End Namespace