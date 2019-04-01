
Namespace LFERP.SystemManager

    Public Class SNRuleSubInfo

        Private _AutoID As Decimal
        Private _SNRuleID As Decimal
        Private _PreFix As String
        Private _DateFormat As String
        Private _SNDigits As Int64
        Private _SNRuleName As String
        Private _SNRuleType As String
        Public Sub New()
            _AutoID = 0
            _SNRuleID = 0
            _PreFix = Nothing
            _DateFormat = Nothing
            _SNDigits = 0
            _SNRuleName = Nothing
            _SNRuleType = Nothing
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
        Public Property PreFix() As String
            Get
                Return _PreFix
            End Get
            Set(ByVal value As String)
                _PreFix = value
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
        Public Property SNDigits() As Int64
            Get
                Return _SNDigits
            End Get
            Set(ByVal value As Int64)
                _SNDigits = value
            End Set
        End Property
        Public Property SNRuleName() As String
            Get
                Return _SNRuleName
            End Get
            Set(ByVal value As String)
                _SNRuleName = value
            End Set
        End Property
        Public Property SNRuleType() As String
            Get
                Return _SNRuleType
            End Get
            Set(ByVal value As String)
                _SNRuleType = value
            End Set
        End Property
    End Class

End Namespace