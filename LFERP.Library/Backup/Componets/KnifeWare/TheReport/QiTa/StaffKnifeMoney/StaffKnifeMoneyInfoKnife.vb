Namespace LFERP.Library.KnifeWare
    Public Class StaffKnifeMoneyInfoKnife

        Private _WH_ID As String
        Private _WH_Type As String
        Private _WH_Name As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _B_Qty As Double
        Private _M_Unit As String
        Private _M_Price As Double
        Private _Total_Price As Double
        Private _B_Date As Date
        Private _Team_ID As String
        Private _B_Type As String
        Private _BPer_ID As String
        Private _BPer_Name As String
        Private _Per_ID As String
        Private _Per_Name As String

        Public Sub New()

            _WH_ID = Nothing
            _WH_Type = Nothing
            _WH_Name = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _B_Qty = 0
            _M_Unit = Nothing
            _M_Price = 0
            _Total_Price = 0
            _B_Date = Nothing
            _Team_ID = Nothing
            _B_Type = Nothing
            _BPer_ID = Nothing
            _BPer_Name = Nothing
            _Per_ID = Nothing
            _Per_Name = Nothing

        End Sub

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

        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
            End Set
        End Property

        Public Property M_Price() As Double
            Get
                Return _M_Price
            End Get
            Set(ByVal value As Double)
                _M_Price = value
            End Set
        End Property

        Public Property B_Date() As Date
            Get
                Return _B_Date
            End Get
            Set(ByVal value As Date)
                _B_Date = value
            End Set
        End Property

        Public Property Total_Price() As Double
            Get
                Return _Total_Price
            End Get
            Set(ByVal value As Double)
                _Total_Price = value
            End Set
        End Property

        Public Property Team_ID() As String
            Get
                Return _Team_ID
            End Get
            Set(ByVal value As String)
                _Team_ID = value
            End Set
        End Property

        Public Property B_Type() As String
            Get
                Return _B_Type
            End Get
            Set(ByVal value As String)
                _B_Type = value
            End Set
        End Property

        Public Property BPer_ID() As String
            Get
                Return _BPer_ID
            End Get
            Set(ByVal value As String)
                _BPer_ID = value
            End Set
        End Property

        Public Property BPer_Name() As String
            Get
                Return _BPer_Name
            End Get
            Set(ByVal value As String)
                _BPer_Name = value
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

        Public Property Per_ID() As String
            Get
                Return _Per_ID
            End Get
            Set(ByVal value As String)
                _Per_ID = value
            End Set
        End Property

        Public Property Per_Name() As String
            Get
                Return _Per_Name
            End Get
            Set(ByVal value As String)
                _Per_Name = value
            End Set
        End Property

    End Class
End Namespace