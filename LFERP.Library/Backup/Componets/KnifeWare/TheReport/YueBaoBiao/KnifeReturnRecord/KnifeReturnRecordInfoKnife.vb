Namespace LFERP.Library.KnifeWare
    Public Class KnifeReturnRecordInfoKnife

        Private _R_NO As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _R_Qty As Double
        Private _R_Type As String
        Private _R_Action As String
        Private _R_Date As Date
        Private _RR_Mark As String
        Private _R_Check As Boolean

        Public Sub New()

            _R_NO = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _R_Qty = 0
            _R_Type = Nothing
            _R_Action = Nothing
            _R_Date = Nothing
            _RR_Mark = Nothing
            _R_Check = False

        End Sub

        Public Property R_NO() As String
            Get
                Return _R_NO
            End Get
            Set(ByVal value As String)
                _R_NO = value
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

        Public Property R_Qty() As Double
            Get
                Return _R_Qty
            End Get
            Set(ByVal value As Double)
                _R_Qty = value
            End Set
        End Property

        Public Property R_Type() As String
            Get
                Return _R_Type
            End Get
            Set(ByVal value As String)
                _R_Type = value
            End Set
        End Property

        Public Property R_Action() As String
            Get
                Return _R_Action
            End Get
            Set(ByVal value As String)
                _R_Action = value
            End Set
        End Property

        Public Property R_Date() As Date
            Get
                Return _R_Date
            End Get
            Set(ByVal value As Date)
                _R_Date = value
            End Set
        End Property

        Public Property RR_Mark() As String
            Get
                Return _RR_Mark
            End Get
            Set(ByVal value As String)
                _RR_Mark = value
            End Set
        End Property

        Public Property R_Check() As Boolean
            Get
                Return _R_Check
            End Get
            Set(ByVal value As Boolean)
                _R_Check = value
            End Set
        End Property

    End Class
End Namespace