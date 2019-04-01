Namespace LFERP.Library.KnifeWare
    Public Class KnifeCheckInfoKnife

        Private _M_Type As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _WI_Qty As Double
        Private _NOReturn As Double

        Public Sub New()

            _M_Type = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _WI_Qty = 0
            _NOReturn = 0

        End Sub

        Public Property M_Type() As String
            Get
                Return _M_Type
            End Get
            Set(ByVal value As String)
                _M_Type = value
            End Set
        End Property

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

        Public Property WI_Qty() As Double
            Get
                Return _WI_Qty
            End Get
            Set(ByVal value As Double)
                _WI_Qty = value
            End Set
        End Property

        Public Property NOReturn() As Double
            Get
                Return _NOReturn
            End Get
            Set(ByVal value As Double)
                _NOReturn = value
            End Set
        End Property

    End Class
End Namespace