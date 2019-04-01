
Namespace LFERP.Library.ProductionSumPieceWorkGroup

    Public Class ProductionSumPieceWorkGroupInfo

        Private _GP_NO As String '            *  nvarchar(50)                /計件單號
        Private _Per_NO As String '           *  nvarchar(50)                /員工編號
        Private _G_NO As String '              *  nvarchar(50)                /組別編號
        Private _DepID As String '             *  nvarchar(50)                /部門編號
        Private _FacID As String '             *  nvarchar(50)                /廠別

        Private _Pro_Type As String '          *  nvarchar(50)                /工藝類型
        Private _PM_M_Code As String '         *  nvarchar(50)                /產品編號
        Private _PM_Type As String '          *  nvarchar(50)                /配件名稱

        Private _PS_NameS As String '          *  nvarchar(50)                /小工序名稱

        Private _GP_factor As Double '         *  float                       /承包系數
        Private _GP_Qty As Integer '            *  int                         /數量 
        Private _GP_Date As String '           *  datetime                    /計件日期
        Private _GP_AddDate As String '        *  datetime                 /記錄日期
        Private _GP_Action As String  '        *  nvarchar(50)                /操作人

        Private _GP_Remark As String '         *  nvarchar(MAX)               /備注

        '外表字段
        Private _GP_ActionName As String ' 操作員名 (SystemUser)
        Private _GP_Per_Name As String '    員工名姓名(ProductionPiecePersonnel)
        Private _GP_DepName As String '    部門名
        Private _GP_FacName As String '    廠別名
        Private _GP_G_Name As String '      組別名(ProductionPieceWorkGroup)    本模不用

        Private _PS_Name As String                    '    /大工序名稱  ProcessSub
        Private _PS_NO As String                      '    大工序編號   ProductionPieceProcess

        Private _PP_AutoID As String ''工藝表中流程
        Private _GP_Price As Double  ''工價

        Private _GP_DateEnd As String
        Private _GP_DateStart As String

        Private _Print_Action As String


        Sub New()
            _Print_Action = Nothing

            _GP_DateEnd = Nothing
            _GP_DateStart = Nothing

            _PP_AutoID = Nothing
            _GP_Price = 0

            _GP_NO = Nothing
            _Per_NO = Nothing
            _G_NO = Nothing
            _DepID = Nothing
            _FacID = Nothing

            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _PS_Name = Nothing
            _PS_NameS = Nothing

            _GP_factor = Nothing
            _GP_Qty = Nothing
            _GP_Date = Nothing
            _GP_AddDate = Nothing
            _GP_Action = Nothing

            _GP_Remark = Nothing

            _GP_ActionName = Nothing
            _GP_Per_Name = Nothing
            _GP_DepName = Nothing
            _GP_FacName = Nothing
            _GP_G_Name = Nothing

            _PS_NO = Nothing

        End Sub

        ''' <summary>
        ''' 打印專用，打印操作人員名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Print_Action() As String
            Get
                Return _Print_Action
            End Get
            Set(ByVal value As String)
                _Print_Action = value
            End Set
        End Property

        Public Property GP_DateEnd() As String
            Get
                Return _GP_DateEnd
            End Get
            Set(ByVal value As String)
                _GP_DateEnd = value
            End Set
        End Property

        Public Property GP_DateStart() As String
            Get
                Return _GP_DateStart
            End Get
            Set(ByVal value As String)
                _GP_DateStart = value
            End Set
        End Property
        ''' <summary>
        ''' 工藝流程中的編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_AutoID() As String
            Get
                Return _PP_AutoID
            End Get
            Set(ByVal value As String)
                _PP_AutoID = value
            End Set
        End Property
        ''' <summary>
        ''' 工價 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GP_Price() As Double
            Get
                Return _GP_Price
            End Get
            Set(ByVal value As Double)
                _GP_Price = value
            End Set
        End Property
        ''' <summary>
        ''' 大工序編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_NO() As String
            Get
                Return _PS_NO
            End Get
            Set(ByVal value As String)
                _PS_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 計件單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GP_NO() As String
            Get
                Return _GP_NO
            End Get
            Set(ByVal value As String)
                _GP_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 員工編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_NO() As String
            Get
                Return _Per_NO
            End Get
            Set(ByVal value As String)
                _Per_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 組別編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_NO() As String
            Get
                Return _G_NO
            End Get
            Set(ByVal value As String)
                _G_NO = value
            End Set
        End Property
        ''' <summary>
        ''' ''部門編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DepID() As String
            Get
                Return _DepID
            End Get
            Set(ByVal value As String)
                _DepID = value
            End Set
        End Property
        ''' <summary>
        ''' 廠別
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
        ''' 工藝類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_Type() As String
            Get
                Return _Pro_Type
            End Get
            Set(ByVal value As String)
                _Pro_Type = value
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
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
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
                Return _PM_Type
            End Get
            Set(ByVal value As String)
                _PM_Type = value
            End Set
        End Property
        ''' <summary>
        ''' 大工序名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Name() As String
            Get
                Return _PS_Name
            End Get
            Set(ByVal value As String)
                _PS_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 小工序名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_NameS() As String
            Get
                Return _PS_NameS
            End Get
            Set(ByVal value As String)
                _PS_NameS = value
            End Set
        End Property

        ''' <summary>
        ''' 承包系數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GP_factor() As Double
            Get
                Return _GP_factor
            End Get
            Set(ByVal value As Double)
                _GP_factor = value
            End Set
        End Property
        ''' <summary>
        ''' 數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GP_Qty() As Integer
            Get
                Return _GP_Qty
            End Get
            Set(ByVal value As Integer)
                _GP_Qty = value
            End Set
        End Property
        ''' <summary>
        ''' 計件日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GP_Date() As String
            Get
                Return _GP_Date
            End Get
            Set(ByVal value As String)
                _GP_Date = value
            End Set
        End Property
        ''' <summary>
        ''' 記錄日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GP_AddDate() As String
            Get
                Return _GP_AddDate
            End Get
            Set(ByVal value As String)
                _GP_AddDate = value
            End Set
        End Property
        ''' <summary>
        ''' 操作人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GP_Action() As String
            Get
                Return _GP_Action
            End Get
            Set(ByVal value As String)
                _GP_Action = value
            End Set
        End Property

        'Private _PP_ActionName As String ' 
        'Private _PP_Per_Name As String '   
        'Private _PP_DepName As String '    
        'Private _PP_FacName As String '    
        'Private _PP_G_Name As String '     
        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GP_Remark() As String
            Get
                Return _GP_Remark
            End Get
            Set(ByVal value As String)
                _GP_Remark = value
            End Set
        End Property
        ''外表字段
        ''' <summary>
        ''' 操作員名 (SystemUser)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GP_ActionName() As String
            Get
                Return _GP_ActionName
            End Get
            Set(ByVal value As String)
                _GP_ActionName = value
            End Set
        End Property
        ''' <summary>
        '''  員工名姓名(ProductionPiecePersonnel)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Property GP_Per_Name() As String
            Get
                Return _GP_Per_Name
            End Get
            Set(ByVal value As String)
                _GP_Per_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 部門名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Property GP_DepName() As String
            Get
                Return _GP_DepName
            End Get
            Set(ByVal value As String)
                _GP_DepName = value
            End Set
        End Property
        ''' <summary>
        ''' 廠別名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GP_FacName() As String
            Get
                Return _GP_FacName
            End Get
            Set(ByVal value As String)
                _GP_FacName = value
            End Set
        End Property
        ''' <summary>
        '''  組別名(ProductionPieceWorkGroup)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GP_G_Name() As String
            Get
                Return _GP_G_Name
            End Get
            Set(ByVal value As String)
                _GP_G_Name = value
            End Set
        End Property
    End Class

End Namespace