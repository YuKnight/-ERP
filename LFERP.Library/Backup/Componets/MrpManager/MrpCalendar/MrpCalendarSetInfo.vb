Namespace LFERP.Library.MrpManager.MrpCalendar
    Public Class MrpCalendarSetInfo

        'Private _CalendarID As String
        'Private _CalendarName As String
        Private _BeginDate As Date
        Private _EndDate As Date
        Private _IsSunChecked As Boolean
        Private _IsMonChecked As Boolean
        Private _IsTueChecked As Boolean
        Private _IsWedChecked As Boolean
        Private _IsThuChecked As Boolean
        Private _IsFriChecked As Boolean
        Private _IsSatChecked As Boolean
        Public Sub New()
            '_CalendarID = Nothing
            '_CalendarName = Nothing
            _BeginDate = Nothing
            _EndDate = Nothing
            _IsSunChecked = True
            _IsMonChecked = False
            _IsTueChecked = False
            _IsWedChecked = False
            _IsThuChecked = False
            _IsFriChecked = False
            _IsSatChecked = False

        End Sub
        'Public Property CalendarID() As String
        '    Get
        '        Return _CalendarID
        '    End Get
        '    Set(ByVal value As String)
        '        _CalendarID = value
        '    End Set
        'End Property
        'Public Property CalendarName() As String
        '    Get
        '        Return _CalendarName
        '    End Get
        '    Set(ByVal value As String)
        '        _CalendarName = value
        '    End Set
        'End Property
        Public Property BeginDate() As Date
            Get
                Return _BeginDate
            End Get
            Set(ByVal value As Date)
                _BeginDate = value
            End Set
        End Property
        Public Property EndDate() As Date
            Get
                Return _EndDate
            End Get
            Set(ByVal value As Date)
                _EndDate = value
            End Set
        End Property
        Public Property IsSunChecked() As Boolean
            Get
                Return _IsSunChecked
            End Get
            Set(ByVal value As Boolean)
                _IsSunChecked = value
            End Set
        End Property
        Public Property IsMonChecked() As Boolean
            Get
                Return _IsMonChecked
            End Get
            Set(ByVal value As Boolean)
                _IsMonChecked = value
            End Set
        End Property
        Public Property IsTueChecked() As Boolean
            Get
                Return _IsTueChecked
            End Get
            Set(ByVal value As Boolean)
                _IsTueChecked = value
            End Set
        End Property
        Public Property IsWedChecked() As Boolean
            Get
                Return _IsWedChecked
            End Get
            Set(ByVal value As Boolean)
                _IsWedChecked = value
            End Set
        End Property
        Public Property IsThuChecked() As Boolean
            Get
                Return _IsThuChecked
            End Get
            Set(ByVal value As Boolean)
                _IsThuChecked = value
            End Set
        End Property
        Public Property IsFriChecked() As Boolean
            Get
                Return _IsFriChecked
            End Get
            Set(ByVal value As Boolean)
                _IsFriChecked = value
            End Set
        End Property
        Public Property IsSatChecked() As Boolean
            Get
                Return _IsSatChecked
            End Get
            Set(ByVal value As Boolean)
                _IsSatChecked = value
            End Set
        End Property
    End Class
End Namespace