Namespace LFERP.Library.KnifeWare
    Public Class KnifeUseInfoKnife

        Private _M_Name As String
        Private _M_Gauge As String
        Private _WI_SQtySub As Double
        Private _WI_SReQtySub As Double
        Private _WI_SQtyMain As Double
        Private _WI_SReQtyMain As Double
        Private _R_Date As Date
        Private _R_Qty As Double
        Private _M_Code As String

        Public Sub New()

            _M_Name = Nothing
            _M_Gauge = Nothing
            _WI_SQtySub = 0
            _WI_SReQtySub = 0
            _WI_SQtyMain = 0
            _WI_SReQtyMain = 0
            _R_Date = Nothing
            _R_Qty = 0
            _M_Code = Nothing

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

        Public Property WI_SQtySub() As Double
            Get
                Return _WI_SQtySub
            End Get
            Set(ByVal value As Double)
                _WI_SQtySub = value
            End Set
        End Property
        Public Property WI_SReQtySub() As Double
            Get
                Return _WI_SReQtySub
            End Get
            Set(ByVal value As Double)
                _WI_SReQtySub = value
            End Set
        End Property
        Public Property WI_SQtyMain() As Double
            Get
                Return _WI_SQtyMain
            End Get
            Set(ByVal value As Double)
                _WI_SQtyMain = value
            End Set
        End Property
        Public Property WI_SReQtyMain() As Double
            Get
                Return _WI_SReQtyMain
            End Get
            Set(ByVal value As Double)
                _WI_SReQtyMain = value
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
        Public Property R_Qty() As Double
            Get
                Return _R_Qty
            End Get
            Set(ByVal value As Double)
                _R_Qty = value
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

    End Class
End Namespace