
Namespace LFERP.Library.ProductionSelect

    Public Class ProductionSelectInfo

        Private _WareModule As String
        Private _strWhere As String
        Private _WareID As String

        Public Sub New()
            _WareModule = ""
            _strWhere = ""
            _WareID = ""
        End Sub
        Public Property WareModule() As String
            Get
                Return _WareModule
            End Get
            Set(ByVal value As String)
                _WareModule = value
            End Set
        End Property

        Public Property strWhere() As String
            Get
                Return _strWhere
            End Get
            Set(ByVal value As String)
                _strWhere = value
            End Set
        End Property


        Public Property WareID() As String
            Get
                Return _WareID
            End Get
            Set(ByVal value As String)
                _WareID = value
            End Set
        End Property
    End Class
End Namespace
