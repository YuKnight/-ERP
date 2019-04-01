Namespace LFERP.Library.KnifeWare
    Public Class UseKnifeQtyInfoKnife

        Private _WH_ID As String
        Private _WH_Action As String
        Private _WH_Name As String
        Private _WH_Type As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _B_Qty As Double

        Public Sub New()

            _WH_ID = Nothing
            _WH_Action = Nothing
            _WH_Name = Nothing
            _WH_Type = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _B_Qty = 0

        End Sub

        Public Property WH_ID() As String
            Get
                Return _WH_ID
            End Get
            Set(ByVal value As String)
                _WH_ID = value
            End Set
        End Property

        Public Property WH_Action() As String
            Get
                Return _WH_Action
            End Get
            Set(ByVal value As String)
                _WH_Action = value
            End Set
        End Property

        Public Property WH_Name() As String
            Get
                Return _WH_Name
            End Get
            Set(ByVal value As String)
                _WH_Name = value
            End Set
        End Property

        Public Property WH_Type() As String
            Get
                Return _WH_Type
            End Get
            Set(ByVal value As String)
                _WH_Type = value
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

        Public Property B_Qty() As Double
            Get
                Return _B_Qty
            End Get
            Set(ByVal value As Double)
                _B_Qty = value
            End Set
        End Property

    End Class
End Namespace