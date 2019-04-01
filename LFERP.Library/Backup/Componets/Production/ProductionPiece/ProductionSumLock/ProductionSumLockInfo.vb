Namespace LFERP.Library.ProductionSumLock
    Public Class ProductionSumLockInfo

        Private _AutoID As String
        Private _FacID As String
        Private _DepID As String
        Private _LockYYYYMM As String
        Private _LockCheck As Boolean
        Private _AddDate As Date
        Private _AddAction As String
        Private _DepName As String
        Private _FacName As String
        Private _U_Name As String


        'AutoID	numeric(18, 0)	Unchecked
        'FacID	nvarchar(50)	Checked
        'DepID	nvarchar(50)	Checked
        'LockYYYYMM	nvarchar(20)	Checked
        'LockCheck	bit	Checked
        'AddDate	datetime	Checked
        'AddAction	nvarchar(50)	Checked
        'DepName
        'FacName
        'U_Name

        Sub New()
            _AutoID = Nothing

            _FacID = Nothing
            _DepID = Nothing
            _LockYYYYMM = Nothing
            _LockCheck = False
            _AddDate = Nothing
            _AddAction = Nothing
            _DepName = Nothing
            _FacName = Nothing
            _U_Name = Nothing

        End Sub
        ''' <summary>
        ''' 自動ID（記錄唯一）
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property

        Public Property FacID() As String
            Get
                Return _FacID
            End Get
            Set(ByVal value As String)
                _FacID = value
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

        Public Property LockYYYYMM() As String
            Get
                Return _LockYYYYMM
            End Get
            Set(ByVal value As String)
                _LockYYYYMM = value
            End Set
        End Property

        Public Property LockCheck() As Boolean
            Get
                Return _LockCheck
            End Get
            Set(ByVal value As Boolean)
                _LockCheck = value
            End Set
        End Property

        Public Property AddDate() As Date
            Get
                Return _AddDate
            End Get
            Set(ByVal value As Date)
                _AddDate = value
            End Set
        End Property


        Public Property AddAction() As String
            Get
                Return _AddAction
            End Get
            Set(ByVal value As String)
                _AddAction = value
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

        Public Property FacName() As String
            Get
                Return _FacName
            End Get
            Set(ByVal value As String)
                _FacName = value
            End Set
        End Property

        Public Property U_Name() As String
            Get
                Return _U_Name
            End Get
            Set(ByVal value As String)
                _U_Name = value
            End Set
        End Property


    End Class


End Namespace