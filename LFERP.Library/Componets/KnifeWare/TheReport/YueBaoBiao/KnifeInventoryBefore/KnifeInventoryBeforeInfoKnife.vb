Namespace LFERP.Library.KnifeWare
    Public Class KnifeInventoryBeforeInfoKnife

        Private _M_Name As String
        Private _M_Gauge As String

        Public Sub New()

            _M_Name = Nothing
            _M_Gauge = Nothing

        End Sub

        Public Property M_Name() As String
            Get
                Return _M_Name
            End Get
            Set(ByVal value As String)
                _M_Name = value
            End Set
        End Property

        Public Property M_Gauge() As String
            Get
                Return _M_Gauge
            End Get
            Set(ByVal value As String)
                _M_Gauge = value
            End Set
        End Property

    End Class
End Namespace