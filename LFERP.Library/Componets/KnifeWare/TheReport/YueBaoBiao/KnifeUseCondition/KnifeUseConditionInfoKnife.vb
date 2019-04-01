Namespace LFERP.Library.KnifeWare
    Public Class KnifeUseConditionInfoKnife

        Private _B_Type As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _B_Qty As Double
        Private _M_Unit As String
        Private _M_Price As Double
        Private _B_Date As Date
        Private _B_NO As String
        Private _B_Action As String
        Private _TotalMoney As Double
        Private _WH_Name As String

        Public Sub New()

            _B_Type = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _B_Qty = 0
            _M_Unit = Nothing
            _M_Price = 0
            _B_Date = Nothing
            _B_NO = Nothing
            _B_Action = Nothing
            _TotalMoney = 0
            _WH_Name = Nothing

        End Sub

        Public Property B_Type() As String
            Get
                Return _B_Type
            End Get
            Set(ByVal value As String)
                _B_Type = value
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

        Public Property B_NO() As String
            Get
                Return _B_NO
            End Get
            Set(ByVal value As String)
                _B_NO = value
            End Set
        End Property

        Public Property B_Action() As String
            Get
                Return _B_Action
            End Get
            Set(ByVal value As String)
                _B_Action = value
            End Set
        End Property

        Public Property TotalMoney() As Double
            Get
                Return _TotalMoney
            End Get
            Set(ByVal value As Double)
                _TotalMoney = value
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