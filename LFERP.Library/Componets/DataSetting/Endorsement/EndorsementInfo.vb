
Namespace LFERP.DataSetting

    Public Class EndorsementInfo
        Private _AM_ID As String
        Private _AM_Type As String
        Private _AM_Check As Boolean
        Private _AM_Time As Date

        Sub New()
            _AM_ID = Nothing
            _AM_Type = Nothing
            _AM_Check = Nothing
            _AM_Time = Nothing
        End Sub

        Public Property AM_ID() As String
            Get
                Return _AM_ID
            End Get
            Set(ByVal value As String)
                _AM_ID = value
            End Set
        End Property
        Public Property AM_Type() As String
            Get
                Return _AM_Type
            End Get
            Set(ByVal value As String)
                _AM_Type = value
            End Set
        End Property
        Public Property AM_Check() As Boolean
            Get
                Return _AM_Check
            End Get
            Set(ByVal value As Boolean)
                _AM_Check = value
            End Set
        End Property
        Public Property AM_Time() As Date
            Get
                Return _AM_Time
            End Get
            Set(ByVal value As Date)
                _AM_Time = value
            End Set
        End Property
    End Class

End Namespace


