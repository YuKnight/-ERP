Namespace LFERP.DataSetting
    Public Class DepartmentInfo
        Private _DPT_ID As String
        Private _DPT_Name As String
        Private _DPT_PID As String

        '--生產用部門
        Private _DepID As String
        Private _DepName As String
        Private _FacID As String
        Private _ArtType As String

        Private _FacName As String
        Private _DPT_PName As String

        Private _D_Alarm As Boolean
        Private _D_Enabled As Boolean
        Private _IsWeight As Boolean
        Private _ErrorRate As Decimal
        Private _D_Cycle As Boolean

        ''針對貴金屬
        Private _CheckLock As Boolean
        Private _CheckDwonRate As Decimal
        Private _CheckUpRate As Decimal
        Private _OutDwonRate As Decimal
        Private _OutUpRate As Decimal
        Private _InDwonRate As Decimal
        Private _InUpRate As Decimal
        Private _WasteDwonRate As Decimal
        Private _WasteUpRate As Decimal


        Sub New()
            _DPT_ID = ""
            _DPT_Name = ""
            _DPT_PID = ""

            '----------------------
            _DepID = Nothing
            _DepName = Nothing
            _FacID = Nothing
            _ArtType = Nothing
            '----------------------
            _FacName = Nothing
            _DPT_PName = Nothing

            _D_Alarm = Nothing
            _D_Enabled = Nothing
            _IsWeight = Nothing
            _ErrorRate = Nothing
            _D_Cycle = Nothing

            _CheckLock = False
            _CheckDwonRate = 0
            _CheckUpRate = 0
            _OutDwonRate = 0
            _OutUpRate = 0
            _InDwonRate = 0
            _InUpRate = 0

            _WasteDwonRate = 0
            _WasteUpRate = 0
        End Sub
        Public Property D_Cycle() As Boolean
            Get
                Return _D_Cycle
            End Get
            Set(ByVal value As Boolean)
                _D_Cycle = value
            End Set
        End Property

        Public Property ErrorRate() As Decimal
            Get
                Return _ErrorRate
            End Get
            Set(ByVal value As Decimal)
                _ErrorRate = value
            End Set
        End Property
        Public Property IsWeight() As Boolean
            Get
                Return _IsWeight
            End Get
            Set(ByVal value As Boolean)
                _IsWeight = value
            End Set
        End Property
        Public Property D_Enabled() As Boolean
            Get
                Return _D_Enabled
            End Get
            Set(ByVal value As Boolean)
                _D_Enabled = value
            End Set
        End Property
        Public Property D_Alarm() As Boolean
            Get
                Return _D_Alarm
            End Get
            Set(ByVal value As Boolean)
                _D_Alarm = value
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

        Public Property DPT_Name() As String
            Get
                Return _DPT_Name
            End Get
            Set(ByVal value As String)
                _DPT_Name = value
            End Set
        End Property

        Public Property DPT_PID() As String
            Get
                Return _DPT_PID
            End Get
            Set(ByVal value As String)
                _DPT_PID = value
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
        Public Property FacID() As String
            Get
                Return _FacID
            End Get
            Set(ByVal value As String)
                _FacID = value
            End Set
        End Property
        Public Property ArtType() As String
            Get
                Return _ArtType
            End Get
            Set(ByVal value As String)
                _ArtType = value
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
        Public Property DPT_PName() As String
            Get
                Return _DPT_PName
            End Get
            Set(ByVal value As String)
                _DPT_PName = value
            End Set
        End Property


        Public Property WasteUpRate() As Decimal
            Get
                Return _WasteUpRate
            End Get
            Set(ByVal value As Decimal)
                _WasteUpRate = value
            End Set
        End Property


        Public Property WasteDwonRate() As Decimal
            Get
                Return _WasteDwonRate
            End Get
            Set(ByVal value As Decimal)
                _WasteDwonRate = value
            End Set
        End Property

        Public Property CheckDwonRate() As Decimal
            Get
                Return _CheckDwonRate
            End Get
            Set(ByVal value As Decimal)
                _CheckDwonRate = value
            End Set
        End Property

        Public Property CheckUpRate() As Decimal
            Get
                Return _CheckUpRate
            End Get
            Set(ByVal value As Decimal)
                _CheckUpRate = value
            End Set
        End Property

        Public Property OutDwonRate() As Decimal
            Get
                Return _OutDwonRate
            End Get
            Set(ByVal value As Decimal)
                _OutDwonRate = value
            End Set
        End Property


        Public Property OutUpRate() As Decimal
            Get
                Return _OutUpRate
            End Get
            Set(ByVal value As Decimal)
                _OutUpRate = value
            End Set
        End Property


        Public Property InDwonRate() As Decimal
            Get
                Return _InDwonRate
            End Get
            Set(ByVal value As Decimal)
                _InDwonRate = value
            End Set
        End Property

        Public Property InUpRate() As Decimal
            Get
                Return _InUpRate
            End Get
            Set(ByVal value As Decimal)
                _InUpRate = value
            End Set
        End Property


        ''' <summary>
        ''' 盤點鎖定
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CheckLock() As Boolean
            Get
                Return _CheckLock
            End Get
            Set(ByVal value As Boolean)
                _CheckLock = value
            End Set
        End Property

    End Class

End Namespace

