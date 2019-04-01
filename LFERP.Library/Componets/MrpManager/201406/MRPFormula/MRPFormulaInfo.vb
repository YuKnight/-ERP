Namespace LFERP.Library.MrpManager.MrpFormula
    Public Class MRPFormulaInfo

        Private _AutoID As Double
        Private _FormulaID As String
        Private _FormulaName As String
        Private _Formula_CH As String
        Private _Formula_EN As String
        Private _CreateUserID As String
        Private _CreateDate As DateTime
        Private _Remarks As String
        Private _ModifyUserID As String
        Private _ModifyDate As DateTime
        Private _InCheck As Boolean
        Public Sub New()
            _AutoID = 0
            _FormulaID = Nothing
            _FormulaName = Nothing
            _Formula_CH = Nothing
            _Formula_EN = Nothing
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _Remarks = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _InCheck = Nothing
        End Sub
        Public Property AutoID() As Double
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Double)
                _AutoID = value
            End Set
        End Property
        Public Property FormulaID() As String
            Get
                Return _FormulaID
            End Get
            Set(ByVal value As String)
                _FormulaID = value
            End Set
        End Property
        Public Property FormulaName() As String
            Get
                Return _FormulaName
            End Get
            Set(ByVal value As String)
                _FormulaName = value
            End Set
        End Property
        Public Property Formula_CH() As String
            Get
                Return _Formula_CH
            End Get
            Set(ByVal value As String)
                _Formula_CH = value
            End Set
        End Property
        Public Property Formula_EN() As String
            Get
                Return _Formula_EN
            End Get
            Set(ByVal value As String)
                _Formula_EN = value
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
        Public Property Remarks() As String
            Get
                Return _Remarks
            End Get
            Set(ByVal value As String)
                _Remarks = value
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
        Public Property InCheck() As Boolean
            Get
                Return _InCheck
            End Get
            Set(ByVal value As Boolean)
                _InCheck = value
            End Set
        End Property

    End Class
End Namespace