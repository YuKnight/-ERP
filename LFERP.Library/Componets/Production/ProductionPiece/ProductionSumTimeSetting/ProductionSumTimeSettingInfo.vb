Namespace LFERP.Library.ProductionSumTimeSetting
    Public Class ProductionSumTimeSettingInfo
        'AutoID	decimal(18, 0)	Unchecked
        'StartTime	nvarchar(50)	Checked
        'EndTime	nvarchar(50)	Checked
        'TotalTime	float	Checked
        'ActionID	nvarchar(50)	Checked
        'ModifyDate	datetime	Checked

        Private _AutoID As String
        Private _StartTime As String
        Private _EndTime As String

        Private _TotalTime As Double
        Private _ActionID As String
        Private _ModifyDate As Date

        Private _ActionName As String

        Sub New()
            _AutoID = Nothing
            _StartTime = Nothing
            _EndTime = Nothing

            _TotalTime = 0
            _ActionID = Nothing
            _ModifyDate = Nothing

            _ActionName = Nothing
        End Sub


        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property

        Public Property StartTime() As String
            Get
                Return _StartTime
            End Get
            Set(ByVal value As String)
                _StartTime = value
            End Set
        End Property

        Public Property EndTime() As String
            Get
                Return _EndTime
            End Get
            Set(ByVal value As String)
                _EndTime = value
            End Set
        End Property

        Public Property TotalTime() As Double
            Get
                Return _TotalTime
            End Get
            Set(ByVal value As Double)
                _TotalTime = value
            End Set
        End Property

        ''---------------------------------------------------------------
        Public Property ActionID() As String
            Get
                Return _ActionID
            End Get
            Set(ByVal value As String)
                _ActionID = value
            End Set
        End Property

        Public Property ModifyDate() As Date
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As Date)
                _ModifyDate = value
            End Set
        End Property

        Public Property ActionName() As String
            Get
                Return _ActionName
            End Get
            Set(ByVal value As String)
                _ActionName = value
            End Set
        End Property


    End Class
End Namespace


