Namespace LFERP.Library.KnifeWare
    Public Class InventoryKnifeMoneyInfoKnife

        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Price As String
        Private _M_Unit As String
        Private _WH_ID As String
        Private _WH_Type As String
        Private _WH_Name As String

        Public Sub New()

            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Price = Nothing
            _M_Unit = Nothing
            _WH_ID = Nothing
            _WH_Type = Nothing
            _WH_Name = Nothing

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


        Public Property M_Price() As String
            Get
                Return _M_Price
            End Get
            Set(ByVal value As String)
                _M_Price = value
            End Set
        End Property


        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
            End Set
        End Property

        Public Property WH_ID() As String
            Get
                Return _WH_ID
            End Get
            Set(ByVal value As String)
                _WH_ID = value
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

        Public Property WH_Name() As String
            Get
                Return _WH_Name
            End Get
            Set(ByVal value As String)
                _WH_Name = value
            End Set
        End Property


    End Class
End Namespace