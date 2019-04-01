
Namespace LFERP.Library.ProductionDPTWareInventory

    Public Class ProductionDPTWareInventoryInfo


        Private _DPT_ID As String
        Private _M_Code As String
        Private _WI_Qty As Double

        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _DPT_Name As String
        Private _WI_ReQty As Double

        Private _Type As String
        Private _WI_Date As Date

        '20130315
        Private _PM_M_Code As String
        Private _M_NameS As String

        '2014-4-29¥[Ãþ§O
        Private _Type3ID As String

        '2014.5.7 
        Private _DayQty As Double

        Sub New()

            _PM_M_Code = Nothing

            _DPT_ID = Nothing
            _M_Code = Nothing
            _WI_Qty = 0

            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _DPT_Name = Nothing
            _WI_ReQty = 0
            _Type = Nothing
            _WI_Date = Nothing
            _M_NameS = Nothing

            _Type3ID = Nothing
            _DayQty = Nothing

        End Sub

        Public Property Type3ID() As String
            Get
                Return _Type3ID
            End Get
            Set(ByVal value As String)
                _Type3ID = value
            End Set
        End Property


        Public Property M_NameS() As String
            Get
                Return _M_NameS
            End Get
            Set(ByVal value As String)
                _M_NameS = value
            End Set
        End Property


        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
            End Set
        End Property

        Public Property DPT_ID() As String
            Get
                Return _DPT_ID
            End Get
            Set(ByVal value As String)
                _DPT_ID = value
            End Set
        End Property
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
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

        Public Property DayQty() As Double
            Get
                Return _DayQty
            End Get
            Set(ByVal value As Double)
                _DayQty = value
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
        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
            End Set
        End Property
        Public Property DPT_Name() As String
            Get
                Return _DPT_Name
            End Get
            Set(ByVal value As String)
                _DPT_Name = value
            End Set
        End Property
        Public Property WI_ReQty() As Double
            Get
                Return _WI_ReQty
            End Get
            Set(ByVal value As Double)
                _WI_ReQty = value
            End Set
        End Property
        Public Property Type() As String
            Get
                Return _Type
            End Get
            Set(ByVal value As String)
                _Type = value
            End Set
        End Property
        Public Property WI_Date() As Date
            Get
                Return _WI_Date
            End Get
            Set(ByVal value As Date)
                _WI_Date = value
            End Set
        End Property
    End Class

End Namespace



