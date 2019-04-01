Namespace LFERP.Library.Orders
    Public Class FOrdersSub_MRPInfo
        Private _OM_No As String
        Private _PM_M_Code As String
        Private _CustomerID As String
        Private _FMonth As String
        Private _FWeek As String
        Private _FDateRange As String
        Private _FDateRangeQty As String
        Private _FDate As String
        Public Sub New()
            _OM_No = Nothing
            _PM_M_Code = Nothing
            _CustomerID = Nothing
            _FMonth = Nothing
            _FWeek = Nothing
            _FDateRange = Nothing
            _FDateRangeQty = Nothing
            _FDate = Nothing
        End Sub
        Public Property OM_No() As String
            Get
                Return _OM_No
            End Get
            Set(ByVal value As String)
                _OM_No = value
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
        Public Property CustomerID() As String
            Get
                Return _CustomerID
            End Get
            Set(ByVal value As String)
                _CustomerID = value
            End Set
        End Property
        Public Property FMonth() As String
            Get
                Return _FMonth
            End Get
            Set(ByVal value As String)
                _FMonth = value
            End Set
        End Property
        Public Property FWeek() As String
            Get
                Return _FWeek
            End Get
            Set(ByVal value As String)
                _FWeek = value
            End Set
        End Property
        Public Property FDateRange() As String
            Get
                Return _FDateRange
            End Get
            Set(ByVal value As String)
                _FDateRange = value
            End Set
        End Property
        Public Property FDateRangeQty() As String
            Get
                Return _FDateRangeQty
            End Get
            Set(ByVal value As String)
                _FDateRangeQty = value
            End Set
        End Property
        Public Property FDate() As String
            Get
                Return _FDate
            End Get
            Set(ByVal value As String)
                _FDate = value
            End Set
        End Property
    End Class
End Namespace