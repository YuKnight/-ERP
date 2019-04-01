Namespace LFERP.Library.MrpManager.MrpCalendar
    Public Class MrpCalendarInfo

        Private _AutoID As Decimal
        Private _CalendarID As String
        Private _CalendarName As String
        Private _BeginDate As DateTime
        Private _EndDate As DateTime
        Private _CreateUserID As String
        Private _CreateDate As DateTime
        Private _ModifyUserID As String
        Private _ModifyDate As DateTime
        Private _Remarks As String
        Public Sub New()
            _AutoID = 0
            _CalendarID = Nothing
            _CalendarName = Nothing
            _BeginDate = Nothing
            _EndDate = Nothing
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _Remarks = Nothing

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
        Public Property CalendarName() As String
            Get
                Return _CalendarName
            End Get
            Set(ByVal value As String)
                _CalendarName = value
            End Set
        End Property
        Public Property BeginDate() As DateTime
            Get
                Return _BeginDate
            End Get
            Set(ByVal value As DateTime)
                _BeginDate = value
            End Set
        End Property
        Public Property EndDate() As DateTime
            Get
                Return _EndDate
            End Get
            Set(ByVal value As DateTime)
                _EndDate = value
            End Set
        End Property
        Public Property CreateUserID() As String
            Get
                Return _CreateUserID
            End Get
            Set(ByVal value As String)
                _CreateUserID = value
            End Set
        End Property
        Public Property CreateDate() As DateTime
            Get
                Return _CreateDate
            End Get
            Set(ByVal value As DateTime)
                _CreateDate = value
            End Set
        End Property
        Public Property ModifyUserID() As String
            Get
                Return _ModifyUserID
            End Get
            Set(ByVal value As String)
                _ModifyUserID = value
            End Set
        End Property
        Public Property ModifyDate() As DateTime
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As DateTime)
                _ModifyDate = value
            End Set
        End Property
        Public Property Remarks() As String
            Get
                Return _Remarks
            End Get
            Set(ByVal value As String)
                _Remarks = value
            End Set
        End Property

    End Class
End Namespace