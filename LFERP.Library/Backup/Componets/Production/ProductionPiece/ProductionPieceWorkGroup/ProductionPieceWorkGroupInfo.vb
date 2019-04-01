Namespace LFERP.Library.ProductionPieceWorkGroup




    Public Class ProductionPieceWorkGroupInfo
        Private _G_NO As String              ' *  nvarchar(50)              /組別編號
        Private _G_Name As String            ' *  nvarchar(50)              /組別名稱
        Private _G_Manager As String '        ' *  nvarchar(50)              /組別負責人
        Private _DepID As String            ' *  nvarchar(50)              /部門編號
        Private _FacID As String           ' *  nvarchar(50)              /廠別
        Private _G_Date As Date           ' *  datetime                  /建立日期
        Private _G_Action As String          ' *  nvarchar(50)              /操作人
        Private _G_Remark As String         ' *  nvarchar(MAX)             /備注
        ''連接了外表的字段
        Private _G_ActionName As String '     操作人員姓名
        Private _G_DepName As String '    部門名稱
        Private _G_FacName As String '   廠別名稱

        ''利用用戶編號得到部門編號
        Private _UserName As String
        Private _UserID As String
        Private _UserRank As String
        Private _UserDep_Fac As String '部門編號-廠別名-

        Private _G_NOName As String '組別編號，組別名稱聯起來


        Sub New()
            _G_NO = Nothing
            _G_Name = Nothing
            _G_Manager = Nothing
            _G_DepName = Nothing
            _G_FacName = Nothing '
            _G_Date = Nothing
            _G_Action = Nothing
            _G_Remark = Nothing

            _UserName = Nothing
            _UserID = Nothing
            _UserRank = Nothing
            _UserDep_Fac = Nothing
            _G_NOName = Nothing
        End Sub
        ''' <summary>
        ''' 組別編號  組別名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_NOName() As String
            Get
                Return _G_NOName
            End Get
            Set(ByVal value As String)
                _G_NOName = value
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
        ''' 組別名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_Name() As String
            Get
                Return _G_Name
            End Get
            Set(ByVal value As String)
                _G_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 組別負責人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_Manager() As String
            Get
                Return _G_Manager
            End Get
            Set(ByVal value As String)
                _G_Manager = value
            End Set
        End Property
        ''' <summary>
        ''' 部門編號
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
        ''' 建立日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_Date() As Date
            Get
                Return _G_Date
            End Get
            Set(ByVal value As Date)
                _G_Date = value
            End Set
        End Property
        ''' <summary>
        ''' 操作人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_Action() As String
            Get
                Return _G_Action
            End Get
            Set(ByVal value As String)
                _G_Action = value
            End Set
        End Property
        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_Remark() As String
            Get
                Return _G_Remark
            End Get
            Set(ByVal value As String)
                _G_Remark = value
            End Set
        End Property

        ''連接了外表的字段
        'Private _G_ActionName As String '     操作人員姓名
        'Private _G_DPT_ID_Name As String '    部門名稱
        'Private _G_DPT_PID_Name As String '   廠別名稱
        ''' <summary>
        ''' 操作人員姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_ActionName() As String
            Get
                Return _G_ActionName
            End Get
            Set(ByVal value As String)
                _G_ActionName = value
            End Set
        End Property
        ''' <summary>
        ''' 部門名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_DepName() As String
            Get
                Return _G_DepName
            End Get
            Set(ByVal value As String)
                _G_DepName = value
            End Set
        End Property
        ''' <summary>
        ''' 廠別名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_FacName() As String
            Get
                Return _G_FacName
            End Get
            Set(ByVal value As String)
                _G_FacName = value
            End Set
        End Property


        ''利用用戶編號得到部門編號
        'Private _UserName As String
        ''' <summary>
        ''' 用戶名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property UserName() As String
            Get
                Return _UserName
            End Get
            Set(ByVal value As String)
                _UserName = value
            End Set
        End Property
        'Private _UserID As String
        ''' <summary>
        ''' 用戶編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property UserID() As String
            Get
                Return _UserID
            End Get
            Set(ByVal value As String)
                _UserID = value
            End Set
        End Property
        'Private _UserRank As String
        ''' <summary>
        ''' 用戶權限
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property UserRank() As String
            Get
                Return _UserRank
            End Get
            Set(ByVal value As String)
                _UserRank = value
            End Set
        End Property
        'Private _UserDep_Fac As String '部門編號-廠別名-
        ''' <summary>
        ''' 部門編號-廠別名-聯
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property UserDep_Fac() As String
            Get
                Return _UserDep_Fac
            End Get
            Set(ByVal value As String)
                _UserDep_Fac = value
            End Set
        End Property

    End Class
End Namespace