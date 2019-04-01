
Namespace LFERP.Library.MrpManager.MrpMps
Public Class MrpMpsEntryInfo

    Private _AutoID As Decimal
    Private _MO As String
    Private _PlanQty As Decimal
    Private _ProducedQty As Decimal
        Private _NeedDate As DateTime
        Private _WeeksNumber As String
        Private _TimeSpan As String
        Private _Remarks As String
        Private _CreateDate As DateTime
        Private _CreateUserID As String
        Private _ModifyDate As DateTime
        Private _ModifyUserID As String

    Public Sub New()
        _AutoID = 0
        _MO = Nothing
        _PlanQty = 0
        _ProducedQty = 0
            _NeedDate = Nothing
            _WeeksNumber = Nothing
            _TimeSpan = Nothing
        _Remarks = Nothing
            _CreateDate = Nothing
            _CreateUserID = Nothing
            _ModifyDate = Nothing
            _ModifyUserID = Nothing
    End Sub
    Public Property AutoID() As Decimal
        Get
            Return _AutoID
        End Get
        Set(ByVal value As Decimal)
            _AutoID = value
        End Set
    End Property
    Public Property MO() As String
        Get
            Return _MO
        End Get
        Set(ByVal value As String)
            _MO = value
        End Set
    End Property
    Public Property PlanQty() As Decimal
        Get
            Return _PlanQty
        End Get
        Set(ByVal value As Decimal)
            _PlanQty = value
        End Set
    End Property
    Public Property ProducedQty() As Decimal
        Get
            Return _ProducedQty
        End Get
        Set(ByVal value As Decimal)
            _ProducedQty = value
        End Set
    End Property
    Public Property NeedDate() As DateTime
        Get
            Return _NeedDate
        End Get
        Set(ByVal value As DateTime)
            _NeedDate = value
        End Set
        End Property
        Public Property WeeksNumber() As String
            Get
                Return _WeeksNumber
            End Get
            Set(ByVal value As String)
                _WeeksNumber = value
            End Set
        End Property
        Public Property TimeSpan() As String
            Get
                Return _TimeSpan
            End Get
            Set(ByVal value As String)
                _TimeSpan = value
            End Set
        End Property
    Public Property Remarks() As String
        Get
            Return _Remarks
        End Get
        Set(ByVal value As String)
            _Remarks = value
        End Set
    End Property
        Public Property CreateDate() As DateTime
            Get
                Return _CreateDate
            End Get
            Set(ByVal value As DateTime)
                _CreateDate = value
            End Set
        End Property
        Public Property CreateUserID() As String
            Get
                Return _CreateUserID
            End Get
            Set(ByVal value As String)
                _CreateUserID = value
            End Set
        End Property
        Public Property ModifyDate() As DateTime
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As DateTime)
                _ModifyDate = value
            End Set
        End Property
        Public Property ModifyUserID() As String
            Get
                Return _ModifyUserID
            End Get
            Set(ByVal value As String)
                _ModifyUserID = value
            End Set
        End Property
End Class
End Namespace