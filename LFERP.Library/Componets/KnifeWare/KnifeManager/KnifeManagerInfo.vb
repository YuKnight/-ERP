Namespace LFERP.Library.KnifeWare
    Public Class KnifeManagerInfo
        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _Qty As Double
        Private _WI_SQty As Double
        Private _WI_SReQty As Double

        Private _FacName As String
        Private _DepName As String
        Private _NOReturn As Double



        Sub New()
            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _Qty = 0
            _WI_SReQty = 0
            _WI_SQty = 0

            _FacName = Nothing
            _DepName = Nothing
            _NOReturn = 0


        End Sub


        Public Property WI_SReQty() As Double
            Get
                Return _WI_SReQty
            End Get
            Set(ByVal value As Double)
                _WI_SReQty = value
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

        Public Property Qty() As Double
            Get
                Return _Qty
            End Get
            Set(ByVal value As Double)
                _Qty = value
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

        Public Property NOReturn() As Double
            Get
                Return _NOReturn
            End Get
            Set(ByVal value As Double)
                _NOReturn = value
            End Set
        End Property

        Public Property FacName() As String
            Get
                Return _FacName
            End Get
            Set(ByVal value As String)
                _FacName = value
            End Set
        End Property

        Public Property DepName() As String
            Get
                Return _DepName
            End Get
            Set(ByVal value As String)
                _DepName = value
            End Set
        End Property

    End Class
End Namespace
