

Namespace LFERP.Library.ProductionWareInventory

    Public Class ProductionWareInventoryInfo

        Private _PH_ID As String
        Private _M_Code As String
        Private _PI_Qty As Integer

        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _PH_Name As String
        Private _PM_JiYu As String

        Sub New()

            _PH_ID = Nothing
            _M_Code = Nothing
            _PI_Qty = 0

            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _PH_Name = Nothing
            _PM_JiYu = Nothing

        End Sub

        Public Property PM_JiYu() As String
            Get
                Return _PM_JiYu
            End Get
            Set(ByVal value As String)
                _PM_JiYu = value
            End Set
        End Property


        Public Property PH_ID() As String
            Get
                Return _PH_ID
            End Get
            Set(ByVal value As String)
                _PH_ID = value
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

        Public Property PI_Qty() As Integer
            Get
                Return _PI_Qty
            End Get
            Set(ByVal value As Integer)
                _PI_Qty = value
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
        Public Property PH_Name() As String
            Get
                Return _PH_Name
            End Get
            Set(ByVal value As String)
                _PH_Name = value
            End Set
        End Property
    End Class

End Namespace

