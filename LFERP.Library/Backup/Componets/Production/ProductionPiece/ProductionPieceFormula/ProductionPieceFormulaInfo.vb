Namespace LFERP.Library.ProductionPieceFormula

    Public Class ProductionPieceFormulaInfo

        Private _AutoID As String
        Private _FormulaID As String
        Private _FormulaName As String
        Private _Formula As String
        Private _InCheck As Boolean


        Sub New()
            _AutoID = Nothing
            _FormulaID = Nothing
            _FormulaName = Nothing
            _Formula = Nothing
            _InCheck = False
        End Sub

        Public Property InCheck() As Boolean
            Get
                Return _InCheck
            End Get
            Set(ByVal value As Boolean)
                _InCheck = value
            End Set
        End Property

        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
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

        Public Property Formula() As String
            Get
                Return _Formula
            End Get
            Set(ByVal value As String)
                _Formula = value
            End Set
        End Property
    End Class
End Namespace