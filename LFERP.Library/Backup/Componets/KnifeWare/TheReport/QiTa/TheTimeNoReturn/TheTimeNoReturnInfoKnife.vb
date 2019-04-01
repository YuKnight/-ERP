Namespace LFERP.Library.KnifeWare
    Public Class TheTimeNoReturnInfoKnife

        Private _WH_ID As String
        Private _WH_Type As String
        Private _WH_Name As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _BPer_Name As String
        Private _BPer_ID As String
        Private _B_Qty As Double
        Private _NOReturn As Double
        Private _R_Qty As Double
        Private _MissQty As Double
        Private _B_Date As Date
        Private _Reason As String

        Public Sub New()
            _WH_ID = Nothing
            _WH_Type = Nothing
            _WH_Name = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _BPer_Name = Nothing
            _BPer_ID = Nothing
            _B_Qty = 0
            _NOReturn = 0
            _R_Qty = 0
            _MissQty = 0
            _B_Date = Nothing
            _Reason = Nothing
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

        Public Property BPer_Name() As String
            Get
                Return _BPer_Name
            End Get
            Set(ByVal value As String)
                _BPer_Name = value
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

        Public Property B_Qty() As Double
            Get
                Return _B_Qty
            End Get
            Set(ByVal value As Double)
                _B_Qty = value
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

        Public Property R_Qty() As Double
            Get
                Return _R_Qty
            End Get
            Set(ByVal value As Double)
                _R_Qty = value
            End Set
        End Property

        Public Property MissQty() As Double
            Get
                Return _MissQty
            End Get
            Set(ByVal value As Double)
                _MissQty = value
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

        Public Property Reason() As String
            Get
                Return _Reason
            End Get
            Set(ByVal value As String)
                _Reason = value
            End Set
        End Property


    End Class
End Namespace