Namespace LFERP.Library.NmetalSampleManager.NmetalSampleBorrow
    Public Class NmetalSampleBorrowInfo
        Private _AutoID As Decimal
        Private _BorrowID As String
        Private _D_ID As String
        Private _PM_M_Code As String
        Private _Borrow_Qty As Integer
        Private _NoBorrow_Qty As Integer
        Private _OutCardID As String
        Private _CheckBit As Boolean
        Private _CheckDate As DateTime
        Private _CheckUserID As String
        Private _CreateUserID As String
        Private _CreateDate As DateTime
        Private _ModifyUserID As String
        Private _ModifyDate As DateTime
        Private _Remark As String

        Private _BorrowDate As Date
        Private _CheckUserName As String
        Private _CreateUserName As String
        Private _D_Dep As String
        Private _MaterialTypeID As String
        Private _MaterialTypeName As String
        Private _SO_SampleID As String
        Private _PS_NO As String
        Private _SO_ID As String
        Private _RepayQty As Integer
        Private _PS_Name As String

        Public Sub New()
            _CheckUserName = Nothing
            _CreateUserName = Nothing
            _D_Dep = Nothing
            _AutoID = 0
            _BorrowID = Nothing
            _D_ID = Nothing
            _PM_M_Code = Nothing
            _Borrow_Qty = 0
            _NoBorrow_Qty = 0
            _RepayQty = 0
            _OutCardID = Nothing
            _CheckBit = False
            _CheckDate = Nothing
            _CheckUserID = Nothing
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _Remark = Nothing
            _BorrowDate = Nothing
            _MaterialTypeID = Nothing
            _MaterialTypeName = Nothing
            _SO_SampleID = Nothing
            _PS_NO = Nothing
            _SO_ID = Nothing
            _PS_Name = Nothing
        End Sub

        Public Property PS_Name() As String
            Get
                Return _PS_Name
            End Get
            Set(ByVal value As String)
                _PS_Name = value
            End Set
        End Property
        Public Property RepayQty() As Integer
            Get
                Return _RepayQty
            End Get
            Set(ByVal value As Integer)
                _RepayQty = value
            End Set
        End Property
        Public Property SO_ID() As String
            Get
                Return _SO_ID
            End Get
            Set(ByVal value As String)
                _SO_ID = value
            End Set
        End Property
        Public Property PS_NO() As String
            Get
                Return _PS_NO
            End Get
            Set(ByVal value As String)
                _PS_NO = value
            End Set
        End Property
        Public Property SO_SampleID() As String
            Get
                Return _SO_SampleID
            End Get
            Set(ByVal value As String)
                _SO_SampleID = value
            End Set
        End Property

        Public Property MaterialTypeName() As String
            Get
                Return _MaterialTypeName
            End Get
            Set(ByVal value As String)
                _MaterialTypeName = value
            End Set
        End Property

        Public Property MaterialTypeID() As String
            Get
                Return _MaterialTypeID
            End Get
            Set(ByVal value As String)
                _MaterialTypeID = value
            End Set
        End Property

        Public Property CheckUserName() As String
            Get
                Return _CheckUserName
            End Get
            Set(ByVal value As String)
                _CheckUserName = value
            End Set
        End Property
        Public Property CreateUserName() As String
            Get
                Return _CreateUserName
            End Get
            Set(ByVal value As String)
                _CreateUserName = value
            End Set
        End Property
        Public Property D_Dep() As String
            Get
                Return _D_Dep
            End Get
            Set(ByVal value As String)
                _D_Dep = value
            End Set
        End Property

        Public Property BorrowDate() As Date
            Get
                Return _BorrowDate
            End Get
            Set(ByVal value As DateTime)
                _BorrowDate = value
            End Set
        End Property

        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property BorrowID() As String
            Get
                Return _BorrowID
            End Get
            Set(ByVal value As String)
                _BorrowID = value
            End Set
        End Property
        Public Property D_ID() As String
            Get
                Return _D_ID
            End Get
            Set(ByVal value As String)
                _D_ID = value
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
        Public Property Borrow_Qty() As Int64
            Get
                Return _Borrow_Qty
            End Get
            Set(ByVal value As Int64)
                _Borrow_Qty = value
            End Set
        End Property

        Public Property NoBorrow_Qty() As Int64
            Get
                Return _NoBorrow_Qty
            End Get
            Set(ByVal value As Int64)
                _NoBorrow_Qty = value
            End Set
        End Property

        Public Property OutCardID() As String
            Get
                Return _OutCardID
            End Get
            Set(ByVal value As String)
                _OutCardID = value
            End Set
        End Property

        Public Property CheckBit() As Boolean
            Get
                Return _CheckBit
            End Get
            Set(ByVal value As Boolean)
                _CheckBit = value
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

        Public Property CheckUserID() As String
            Get
                Return _CheckUserID
            End Get
            Set(ByVal value As String)
                _CheckUserID = value
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

        Public Property Remark() As String
            Get
                Return _Remark
            End Get
            Set(ByVal value As String)
                _Remark = value
            End Set
        End Property
    End Class
End Namespace