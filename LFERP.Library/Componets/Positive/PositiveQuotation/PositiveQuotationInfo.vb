Namespace LFERP.Library.Positive
    Public Class PositiveQuotationInfo

        Private _AutoID As Decimal
        Private _BillNo As String
        Private _CustomerID As String
        Private _CreateUserID As String
        Private _CreateDate As DateTime
        Private _IsCheck As Boolean
        Private _CheckUserID As String
        Private _CheckDate As DateTime
        Private _CheckRemarks As String
        Private _ModifyUserID As String
        Private _ModifyDate As DateTime
        Public Sub New()
            _AutoID = 0
            _BillNo = Nothing
            _CustomerID = Nothing
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _IsCheck = False
            _CheckUserID = Nothing
            _CheckDate = Nothing
            _CheckRemarks = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing

        End Sub
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property BillNo() As String
            Get
                Return _BillNo
            End Get
            Set(ByVal value As String)
                _BillNo = value
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
        Public Property CreateUserID() As String
            Get
                Return _CreateUserID
            End Get
            Set(ByVal value As String)
                _CreateUserID = value
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
        Public Property IsCheck() As Boolean
            Get
                Return _IsCheck
            End Get
            Set(ByVal value As Boolean)
                _IsCheck = value
            End Set
        End Property
        Public Property CheckUserID() As String
            Get
                Return _CheckUserID
            End Get
            Set(ByVal value As String)
                _CheckUserID = value
            End Set
        End Property
        Public Property CheckDate() As DateTime
            Get
                Return _CheckDate
            End Get
            Set(ByVal value As DateTime)
                _CheckDate = value
            End Set
        End Property
        Public Property CheckRemarks() As String
            Get
                Return _CheckRemarks
            End Get
            Set(ByVal value As String)
                _CheckRemarks = value
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
        Public Property ModifyDate() As DateTime
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As DateTime)
                _ModifyDate = value
            End Set
        End Property

    End Class

End Namespace