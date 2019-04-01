Namespace LFERP.Library.KnifeWare
    Public Class KnifeInventoryInfoKnife

        Private _M_Name As String
        Private _M_Type As String
        Private _M_Gauge As String
        Private _WI_SQty As Double
        Private _WI_SReQty As Double
        Private _M_Unit As String
        Private _M_Remark As String
        Private _WH_ID As String
        Private _WH_Name As String

        Public Sub New()
            _M_Name = Nothing
            _M_Type = Nothing
            _M_Gauge = Nothing
            _WI_SQty = 0
            _WI_SReQty = 0
            _M_Unit = Nothing
            _M_Remark = Nothing
            _WH_ID = Nothing
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

        Public Property M_Type() As String
            Get
                Return _M_Type
            End Get
            Set(ByVal value As String)
                _M_Type = value
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

        Public Property WI_SQty() As Double
            Get
                Return _WI_SQty
            End Get
            Set(ByVal value As Double)
                _WI_SQty = value
            End Set
        End Property

        Public Property WI_SReQty() As Double
            Get
                Return _WI_SReQty
            End Get
            Set(ByVal value As Double)
                _WI_SReQty = value
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

        Public Property M_Remark() As String
            Get
                Return _M_Remark
            End Get
            Set(ByVal value As String)
                _M_Remark = value
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