Namespace LFERP.Library.ProductionSumPiecePersonnel


    Public Class ProductionSumPiecePersonnelInfo



        Private _PP_NO As String '            *  nvarchar(50)                /計件單號
        Private _Per_NO As String '           *  nvarchar(50)                /員工編號
        Private _G_NO As String '              *  nvarchar(50)                /組別編號
        Private _DepID As String '             *  nvarchar(50)                /部門編號
        Private _FacID As String '             *  nvarchar(50)                /廠別

        Private _Pro_Type As String '          *  nvarchar(50)                /工藝類型
        Private _PM_M_Code As String '         *  nvarchar(50)                /產品編號
        Private _PM_Type As String '          *  nvarchar(50)                /配件名稱

        Private _PS_NameS As String '          *  nvarchar(50)                /小工序名稱

        Private _PP_factor As Double '         *  float                       /承包系數
        Private _PP_Qty As Integer '            *  int                         /數量 
        Private _PP_Date As String '           *  datetime                    /計件日期
        Private _PP_AddDate As String '        *  datetime                 /記錄日期
        Private _PP_Action As String  '        *  nvarchar(50)                /操作人

        Private _PP_Remark As String '         *  nvarchar(MAX)               /備注

        '外表字段
        Private _PP_ActionName As String ' 操作員名 (SystemUser)
        Private _PP_Per_Name As String '    員工名姓名(ProductionPiecePersonnel)
        Private _PP_DepName As String '    部門名
        Private _PP_FacName As String '    廠別名
        Private _PP_G_Name As String '      組別名(ProductionPieceWorkGroup)    本模不用

        Private _PS_Name As String                    '    /大工序名稱  ProcessSub
        Private _PS_NO As String                      '    大工序編號   ProductionPieceProcess

        Private _PP_AutoID As String ''工藝表中流程
        Private _PP_Price As Double  ''工價

        Private _PP_DateEnd As String
        Private _PP_DateStart As String

        Private _Print_Action As String ''供打印使 用
        Private _Per_Class As String '班制


        Sub New()
            _Print_Action = Nothing

            _PP_DateEnd = Nothing
            _PP_DateStart = Nothing


            _PP_AutoID = Nothing
            _PP_Price = 0

            _PP_NO = Nothing
            _Per_NO = Nothing
            _G_NO = Nothing
            _DepID = Nothing
            _FacID = Nothing

            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _PS_Name = Nothing
            _PS_NameS = Nothing

            _PP_factor = Nothing
            _PP_Qty = Nothing
            _PP_Date = Nothing
            _PP_AddDate = Nothing
            _PP_Action = Nothing

            _PP_Remark = Nothing

            _PP_ActionName = Nothing
            _PP_Per_Name = Nothing
            _PP_DepName = Nothing
            _PP_FacName = Nothing
            _PP_G_Name = Nothing

            _PS_NO = Nothing

            _Per_Class = Nothing

        End Sub
        ''' <summary>
        ''' 班制
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_Class() As String
            Get
                Return _Per_Class
            End Get
            Set(ByVal value As String)
                _Per_Class = value
            End Set
        End Property
        ''' <summary>
        ''' 打印時用的操作人
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
        '_PP_DateEnd
        Public Property PP_DateEnd() As String
            Get
                Return _PP_DateEnd
            End Get
            Set(ByVal value As String)
                _PP_DateEnd = value
            End Set
        End Property

        Public Property PP_DateStart() As String
            Get
                Return _PP_DateStart
            End Get
            Set(ByVal value As String)
                _PP_DateStart = value
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
        Public Property PP_Price() As Double
            Get
                Return _PP_Price
            End Get
            Set(ByVal value As Double)
                _PP_Price = value
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
        Public Property PP_NO() As String
            Get
                Return _PP_NO
            End Get
            Set(ByVal value As String)
                _PP_NO = value
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
        Public Property PP_factor() As Double
            Get
                Return _PP_factor
            End Get
            Set(ByVal value As Double)
                _PP_factor = value
            End Set
        End Property
        ''' <summary>
        ''' 數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_Qty() As Integer
            Get
                Return _PP_Qty
            End Get
            Set(ByVal value As Integer)
                _PP_Qty = value
            End Set
        End Property
        ''' <summary>
        ''' 計件日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_Date() As String
            Get
                Return _PP_Date
            End Get
            Set(ByVal value As String)
                _PP_Date = value
            End Set
        End Property
        ''' <summary>
        ''' 記錄日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_AddDate() As String
            Get
                Return _PP_AddDate
            End Get
            Set(ByVal value As String)
                _PP_AddDate = value
            End Set
        End Property
        ''' <summary>
        ''' 操作人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_Action() As String
            Get
                Return _PP_Action
            End Get
            Set(ByVal value As String)
                _PP_Action = value
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
        Public Property PP_Remark() As String
            Get
                Return _PP_Remark
            End Get
            Set(ByVal value As String)
                _PP_Remark = value
            End Set
        End Property
        ''外表字段
        ''' <summary>
        ''' 操作員名 (SystemUser)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_ActionName() As String
            Get
                Return _PP_ActionName
            End Get
            Set(ByVal value As String)
                _PP_ActionName = value
            End Set
        End Property
        ''' <summary>
        '''  員工名姓名(ProductionPiecePersonnel)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Property PP_Per_Name() As String
            Get
                Return _PP_Per_Name
            End Get
            Set(ByVal value As String)
                _PP_Per_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 部門名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Property PP_DepName() As String
            Get
                Return _PP_DepName
            End Get
            Set(ByVal value As String)
                _PP_DepName = value
            End Set
        End Property
        ''' <summary>
        ''' 廠別名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_FacName() As String
            Get
                Return _PP_FacName
            End Get
            Set(ByVal value As String)
                _PP_FacName = value
            End Set
        End Property
        ''' <summary>
        '''  組別名(ProductionPieceWorkGroup)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_G_Name() As String
            Get
                Return _PP_G_Name
            End Get
            Set(ByVal value As String)
                _PP_G_Name = value
            End Set
        End Property

    End Class

End Namespace