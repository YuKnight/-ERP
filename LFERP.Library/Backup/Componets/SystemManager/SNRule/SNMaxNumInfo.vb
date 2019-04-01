Namespace LFERP.SystemManager
    Public Class SNMaxNumInfo

        Private _AutoID As Decimal
        Private _SNRuleID As Decimal
        Private _DateFormat As Int64
        Private _MaxNum As Int64
        Public Sub New()
            _AutoID = 0
            _SNRuleID = 0
            _DateFormat = 0
            _MaxNum = 0

        End Sub
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property SNRuleID() As Decimal
            Get
                Return _SNRuleID
            End Get
            Set(ByVal value As Decimal)
                _SNRuleID = value
            End Set
        End Property
        Public Property DateFormat() As String
            Get
                Return _DateFormat
            End Get
            Set(ByVal value As String)
                _DateFormat = value
            End Set
        End Property
        Public Property MaxNum() As Int64
            Get
                Return _MaxNum
            End Get
            Set(ByVal value As Int64)
                _MaxNum = value
            End Set
        End Property

    End Class

End Namespace