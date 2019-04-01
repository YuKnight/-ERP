
Namespace LFERP.Library.ProductionController

    Public Class ProductionFieldControlInfo
        Private _UserID As String
        Private _ControlDep As String

        Private _DepName As String

        Sub New()
            _UserID = Nothing
            _ControlDep = Nothing
            _DepName = Nothing
        End Sub

        Public Property UserID() As String
            Get
                Return _UserID
            End Get
            Set(ByVal value As String)
                _UserID = value
            End Set
        End Property

        Public Property ControlDep() As String
            Get
                Return _ControlDep
            End Get
            Set(ByVal value As String)
                _ControlDep = value
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
    End Class

End Namespace
