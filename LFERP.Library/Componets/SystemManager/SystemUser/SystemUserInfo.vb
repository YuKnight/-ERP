
Namespace LFERP.SystemManager.SystemUser
    Public Class SystemUserInfo
        Private _u_id As String
        Private _u_name As String
        Private _u_password As String
        Private _DPT_ID As String
        Private _U_DPT_Name As String
        Private _u_keyimage As Byte()

        Private _UserID As String
        Private _UserName As String
        Private _UserRank As String
        Private _DepID As String
        Private _DepName As String
        Private _UserType As String
        Private _U_Enabled As Boolean
        Private _JobNo As String

        '2014.4.21 鄭少釗新增----------
        Private _U_Online As String
        Private _U_LoginDate As String
        Private _U_LogoutDate As String
        Private _U_OnlineUserNum As Integer
        '--------------------------
        '2014.4.23 劉祥松
        Private _CO_ID As String
        Private _CO_ChsName As String
        '------------------------

        Public Sub New()
            _CO_ID = Nothing
            _CO_ChsName = Nothing

            _u_id = ""
            _u_name = ""
            _u_password = ""
            _DPT_ID = Nothing
            _U_DPT_Name = Nothing
            _u_keyimage = Nothing

            _UserID = ""
            _UserName = Nothing
            _UserRank = Nothing
            _DepID = Nothing
            _DepName = Nothing
            _UserType = Nothing
            _U_Enabled = True
            _JobNo = Nothing
            '2014.4.21 鄭少釗新增----------
            _U_Online = Nothing
            _U_LoginDate = Nothing
            _U_LogoutDate = Nothing
            _U_OnlineUserNum = 0
            '--------------------------
        End Sub
        ''' <summary>
        ''' 用戶所在公司的編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_ID() As String
            Get
                Return _CO_ID
            End Get
            Set(ByVal value As String)
                _CO_ID = value
            End Set
        End Property
        ''' <summary>
        ''' 用戶所在公司的名字
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_ChsName() As String
            Get
                Return _CO_ChsName
            End Get
            Set(ByVal value As String)
                _CO_ChsName = value
            End Set
        End Property
        ''' <summary>
        ''' 用戶編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property U_ID() As String
            Get
                Return _u_id
            End Get
            Set(ByVal value As String)
                _u_id = value
            End Set
        End Property
        ''' <summary>
        ''' 用戶名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property U_Name() As String
            Get
                Return _u_name
            End Get
            Set(ByVal value As String)
                _u_name = value
            End Set
        End Property
        ''' <summary>
        ''' 用戶密碼
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property U_PassWord() As String
            Get
                Return _u_password
            End Get
            Set(ByVal value As String)
                _u_password = value
            End Set
        End Property

        Public Property DPT_ID() As String
            Get
                Return _DPT_ID
            End Get
            Set(ByVal value As String)
                _DPT_ID = value
            End Set
        End Property

        Public Property U_DPT_Name() As String
            Get
                Return _U_DPT_Name
            End Get
            Set(ByVal value As String)
                _U_DPT_Name = value
            End Set
        End Property



        Public Property U_KeyImage() As Byte()
            Get
                Return _u_keyimage
            End Get
            Set(ByVal value As Byte())
                _u_keyimage = value
            End Set
        End Property


        Public Property UserID() As String
            Get
                Return _UserID
            End Get
            Set(ByVal value As String)
                _UserID = value
            End Set
        End Property
        Public Property UserName() As String
            Get
                Return _UserName
            End Get
            Set(ByVal value As String)
                _UserName = value
            End Set
        End Property
        Public Property UserRank() As String
            Get
                Return _UserRank
            End Get
            Set(ByVal value As String)
                _UserRank = value
            End Set
        End Property
        Public Property DepID() As String
            Get
                Return _DepID
            End Get
            Set(ByVal value As String)
                _DepID = value
            End Set
        End Property
        Public Property DepName() As String
            Get
                Return _DepName
            End Get
            Set(ByVal value As String)
                _DepName = value
            End Set
        End Property
        Public Property UserType() As String
            Get
                Return _UserType
            End Get
            Set(ByVal value As String)
                _UserType = value
            End Set
        End Property

        Public Property U_Enabled() As Boolean
            Get
                Return _U_Enabled
            End Get
            Set(ByVal value As Boolean)
                _U_Enabled = value
            End Set
        End Property
        Public Property JobNo() As String
            Get
                Return _JobNo
            End Get
            Set(ByVal value As String)
                _JobNo = value
            End Set
        End Property
        '2014.4.21 鄭少釗新增----------
        Public Property U_Online() As String
            Get
                Return _U_Online
            End Get
            Set(ByVal value As String)
                _U_Online = value
            End Set
        End Property
        Public Property U_LoginDate() As String
            Get
                Return _U_LoginDate
            End Get
            Set(ByVal value As String)
                _U_LoginDate = value
            End Set
        End Property
        Public Property U_LogoutDate() As String
            Get
                Return _U_LogoutDate
            End Get
            Set(ByVal value As String)
                _U_LogoutDate = value
            End Set
        End Property
        Public Property U_OnlineUserNum() As Integer
            Get
                Return _U_OnlineUserNum
            End Get
            Set(ByVal value As Integer)
                _U_OnlineUserNum = value
            End Set
        End Property
        '---------------------------------
    End Class
End Namespace

