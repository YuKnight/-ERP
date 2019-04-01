Namespace LFERP.Library.KnifeWare
    Public Class KnifeWhiteUserInfo

        Private _DPT_ID As String       '' 部門編號
        Private _WH_ID As String        '' 倉庫編號
        Private _W_UserID As String     '' 工號
        Private _W_UserName As String   '' 姓名
        Private _W_Remark As String     '' 備註
        Private _DepName As String      '' 部門
        Private _FacName As String      '' 廠別
        Private _WType As String        '' 倉庫類型
        Private _WMax As Double         '' 可領上限
        Private _WH_Name As String      '' 倉庫名稱
        Private _GNO As String          ''組別
        Private _GName As String
        Private _AutoID As String
        Private _QuitBit As Boolean
        Private _Per_ID As String
        Private _Per_Name As String


        Public Sub New()
            _DPT_ID = Nothing
            _WH_ID = Nothing
            _W_UserID = Nothing
            _W_UserName = Nothing
            _W_Remark = Nothing
            _DepName = Nothing
            _FacName = Nothing
            _WType = Nothing
            _WMax = 0
            _WH_Name = Nothing
            _GNO = Nothing
            _GName = Nothing

            _AutoID = Nothing
            _QuitBit = False

            _Per_ID = Nothing
            _Per_Name = Nothing
        End Sub

        Public Property Per_Name() As String
            Get
                Return _Per_Name
            End Get
            Set(ByVal value As String)
                _Per_Name = value
            End Set
        End Property

        Public Property Per_ID() As String
            Get
                Return _Per_ID
            End Get
            Set(ByVal value As String)
                _Per_ID = value
            End Set
        End Property

        Public Property QuitBit() As Boolean
            Get
                Return _QuitBit
            End Get
            Set(ByVal value As Boolean)
                _QuitBit = value
            End Set
        End Property

        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property

        Public Property GName() As String
            Get
                Return _GName
            End Get
            Set(ByVal value As String)
                _GName = value
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

        Public Property WH_ID() As String
            Get
                Return _WH_ID
            End Get
            Set(ByVal value As String)
                _WH_ID = value
            End Set
        End Property

        Public Property W_UserID() As String
            Get
                Return _W_UserID
            End Get
            Set(ByVal value As String)
                _W_UserID = value
            End Set
        End Property

        Public Property W_UserName() As String
            Get
                Return _W_UserName
            End Get
            Set(ByVal value As String)
                _W_UserName = value
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

        Public Property W_Remark() As String
            Get
                Return _W_Remark
            End Get
            Set(ByVal value As String)
                _W_Remark = value
            End Set
        End Property

        Public Property FacName() As String
            Get
                Return _FacName
            End Get
            Set(ByVal value As String)
                _FacName = value
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

        Public Property WMax() As Double
            Get
                Return _WMax
            End Get
            Set(ByVal value As Double)
                _WMax = value
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

        Public Property GNO() As String
            Get
                Return _GNO
            End Get
            Set(ByVal value As String)
                _GNO = value
            End Set
        End Property

    End Class
End Namespace