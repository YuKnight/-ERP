Namespace LFERP.Library.KnifeWare
    Public Class KnifeReturnInfoKnife

        Private _R_NUM As String
        Private _R_NO As String
        Private _M_Code As String
        Private _R_Qty As Double
        Private _RPer_ID As String
        Private _RPer_Name As String
        Private _RRPer_ID As String
        Private _RRPer_Name As String
        Private _R_Type As String
        Private _R_Date As Date
        Private _RR_Mark As String
        Private _WH_ID As String
        Private _R_Action As String
        Private _R_EndQty As Double
        Private _R_AllEndQty As Double
        Private _R_Check As Boolean
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _WH_Name As String

        Public Sub New()

            _R_NUM = Nothing
            _R_NO = Nothing
            _M_Code = Nothing
            _R_Qty = 0
            _RPer_ID = Nothing
            _RPer_Name = Nothing
            _RRPer_ID = Nothing
            _RRPer_Name = Nothing
            _R_Type = Nothing
            _R_Date = Nothing
            _RR_Mark = Nothing
            _WH_ID = Nothing
            _R_Action = Nothing
            _R_EndQty = 0
            _R_AllEndQty = 0
            _R_Check = False
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _WH_Name = Nothing

        End Sub

        Public Property R_NUM() As String
            Get
                Return _R_NUM
            End Get
            Set(ByVal value As String)
                _R_NUM = value
            End Set
        End Property

        Public Property R_NO() As String
            Get
                Return _R_NO
            End Get
            Set(ByVal value As String)
                _R_NO = value
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

        Public Property R_Qty() As Double
            Get
                Return _R_Qty
            End Get
            Set(ByVal value As Double)
                _R_Qty = value
            End Set
        End Property

        Public Property RPer_ID() As String
            Get
                Return _RPer_ID
            End Get
            Set(ByVal value As String)
                _RPer_ID = value
            End Set
        End Property

        Public Property RPer_Name() As String
            Get
                Return _RPer_Name
            End Get
            Set(ByVal value As String)
                _RPer_Name = value
            End Set
        End Property

        Public Property RRPer_ID() As String
            Get
                Return _RRPer_ID
            End Get
            Set(ByVal value As String)
                _RRPer_ID = value
            End Set
        End Property

        Public Property RRPer_Name() As String
            Get
                Return _RRPer_Name
            End Get
            Set(ByVal value As String)
                _RRPer_Name = value
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

        Public Property WH_ID() As String
            Get
                Return _WH_ID
            End Get
            Set(ByVal value As String)
                _WH_ID = value
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

        Public Property R_EndQty() As Double
            Get
                Return _R_EndQty
            End Get
            Set(ByVal value As Double)
                _R_EndQty = value
            End Set
        End Property

        Public Property R_AllEndQty() As Double
            Get
                Return _R_AllEndQty
            End Get
            Set(ByVal value As Double)
                _R_AllEndQty = value
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