Namespace LFERP.Library.SampleManager.SampleBorrow
    Public Class SampleRepayInfo
        Private _AutoID As Decimal
        Private _RepayID As String
        Private _BorrowID As String
        Private _D_ID As String
        Private _PM_M_Code As String
        Private _RepayQty As Integer
        Private _Borrow_Qty As Integer
        Private _NoBorrow_Qty As Integer
        Private _RepayDate As Date
        Private _InCardID As String
        Private _CheckBit As Boolean
        Private _CheckDate As Date
        Private _CheckAction As String
        Private _CreateUserID As String
        Private _CreateDate As Date
        Private _ModifyUserID As String
        Private _ModifyDate As Date
        Private _Remarks As String
        Private _D_Dep As String
        Private _CheckUserName As String
        Private _CreateUserName As String
        Private _MaterialTypeID As String
        Private _MaterialTypeName As String
        Private _SO_SampleID As String
        Private _Code_ID As String
        Private _Qty As Integer
        Private _PS_NO As String
        Private _SO_ID As String
        Private _InputType As String
        Private _InputID As String
        Private _UseBit As Boolean

        Public Sub New()
            _AutoID = 0
            _RepayID = Nothing
            _BorrowID = Nothing
            _D_ID = Nothing
            _PM_M_Code = Nothing
            _RepayQty = 0
            _Borrow_Qty = 0
            _NoBorrow_Qty = 0
            _RepayDate = Nothing
            _InCardID = Nothing
            _CheckBit = False
            _CheckDate = Nothing
            _CheckAction = Nothing
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _Remarks = Nothing
            _D_Dep = Nothing
            _CheckUserName = Nothing
            _CreateUserName = Nothing
            _MaterialTypeID = Nothing
            _MaterialTypeName = Nothing
            _SO_SampleID = Nothing
            _PS_NO = Nothing
            _SO_ID = Nothing
            _Code_ID = Nothing
            _Qty = Nothing
            _InputType = Nothing
            _InputID = Nothing
            _UseBit = Nothing
        End Sub
        Public Property UseBit() As Boolean
            Get
                Return _UseBit
            End Get
            Set(ByVal value As Boolean)
                _UseBit = value
            End Set
        End Property
        Public Property InputType() As String
            Get
                Return _InputType
            End Get
            Set(ByVal value As String)
                _InputType = value
            End Set
        End Property

        Public Property InputID() As String
            Get
                Return _InputID
            End Get
            Set(ByVal value As String)
                _InputID = value
            End Set
        End Property

        Public Property Code_ID() As String
            Get
                Return _Code_ID
            End Get
            Set(ByVal value As String)
                _Code_ID = value
            End Set
        End Property
        Public Property Qty() As Integer
            Get
                Return _Qty
            End Get
            Set(ByVal value As Integer)
                _Qty = value
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
        Public Property SO_ID() As String
            Get
                Return _SO_ID
            End Get
            Set(ByVal value As String)
                _SO_ID = value
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
        Public Property BorrowID() As String
            Get
                Return _BorrowID
            End Get
            Set(ByVal value As String)
                _BorrowID = value
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
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property RepayID() As String
            Get
                Return _RepayID
            End Get
            Set(ByVal value As String)
                _RepayID = value
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
        Public Property RepayQty() As Int64
            Get
                Return _RepayQty
            End Get
            Set(ByVal value As Int64)
                _RepayQty = value
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

        Public Property RepayDate() As DateTime
            Get
                Return _RepayDate
            End Get
            Set(ByVal value As DateTime)
                _RepayDate = value
            End Set
        End Property
        Public Property InCardID() As String
            Get
                Return _InCardID
            End Get
            Set(ByVal value As String)
                _InCardID = value
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
        Public Property CheckAction() As String
            Get
                Return _CheckAction
            End Get
            Set(ByVal value As String)
                _CheckAction = value
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
        Public Property Remarks() As String
            Get
                Return _Remarks
            End Get
            Set(ByVal value As String)
                _Remarks = value
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
    End Class

End Namespace