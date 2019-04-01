Namespace LFERP.Library.ProductionPiecePaySampType

    Public Class ProductionPiecePaySampTypeInfo

        Private _SampID As String
        Private _SampName As String
        Private _SampPrice As Double
        Private _SampCheck As Boolean
       
        Sub New()
            _SampID = Nothing
            _SampName = Nothing
            _SampPrice = 0
            _SampCheck = False            
        End Sub

        Public Property SampID() As String
            Get
                Return _SampID
            End Get
            Set(ByVal value As String)
                _SampID = value
            End Set
        End Property

        Public Property SampName() As String
            Get
                Return _SampName
            End Get
            Set(ByVal value As String)
                _SampName = value
            End Set
        End Property


        Public Property SampPrice() As Double
            Get
                Return _SampPrice
            End Get
            Set(ByVal value As Double)
                _SampPrice = value
            End Set
        End Property

        Public Property SampCheck() As Boolean
            Get
                Return _SampCheck
            End Get
            Set(ByVal value As Boolean)
                _SampCheck = value
            End Set
        End Property


    End Class
End Namespace