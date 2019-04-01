Namespace LFERP.Library.MrpManager.MrpCalendar
    Public Class MrpCalendarEntryInfo

        Private _AutoID As Decimal
        Private _CalendarID As String
        Private _CalendarDate As DateTime
        Private _IsWorkDay As Boolean
        Public Sub New()
            _AutoID = 0
            _CalendarID = Nothing
            _CalendarDate = Nothing
            _IsWorkDay = False

        End Sub
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property CalendarID() As String
            Get
                Return _CalendarID
            End Get
            Set(ByVal value As String)
                _CalendarID = value
            End Set
        End Property
        Public Property CalendarDate() As DateTime
            Get
                Return _CalendarDate
            End Get
            Set(ByVal value As DateTime)
                _CalendarDate = value
            End Set
        End Property
        Public Property IsWorkDay() As Boolean
            Get
                Return _IsWorkDay
            End Get
            Set(ByVal value As Boolean)
                _IsWorkDay = value
            End Set
        End Property

    End Class
End Namespace