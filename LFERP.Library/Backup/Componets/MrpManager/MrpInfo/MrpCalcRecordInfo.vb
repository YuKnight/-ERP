Namespace LFERP.Library.MrpManager.MrpInfo
    Public Class MrpCalcRecordInfo

        Private _AutoID As Decimal
        Private _MrpCalcDateTime As Date
        Private _MrpCalcBeginDate As Date
        Private _MrpCalcEndDate As Date
        Private _UsedTime As Decimal
        Private _CreateUserID As String
        Private _CreateUserName As String
        Private _Mrp_ID As String
        Private _ProductNum As Int64
        Private _PurchaseNum As Int64
        Public Sub New()
            _AutoID = 0
            _MrpCalcDateTime = Nothing
            _MrpCalcBeginDate = Nothing
            _MrpCalcEndDate = Nothing
            _UsedTime = 0
            _CreateUserID = Nothing
            _CreateUserName = Nothing
            _Mrp_ID = Nothing
            _ProductNum = 0
            _PurchaseNum = 0

        End Sub
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property MrpCalcDateTime() As Date
            Get
                Return _MrpCalcDateTime
            End Get
            Set(ByVal value As Date)
                _MrpCalcDateTime = value
            End Set
        End Property
        Public Property MrpCalcBeginDate() As Date
            Get
                Return _MrpCalcBeginDate
            End Get
            Set(ByVal value As Date)
                _MrpCalcBeginDate = value
            End Set
        End Property
        Public Property MrpCalcEndDate() As Date
            Get
                Return _MrpCalcEndDate
            End Get
            Set(ByVal value As Date)
                _MrpCalcEndDate = value
            End Set
        End Property
        Public Property UsedTime() As Decimal
            Get
                Return _UsedTime
            End Get
            Set(ByVal value As Decimal)
                _UsedTime = value
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
        Public Property CreateUserName() As String
            Get
                Return _CreateUserName
            End Get
            Set(ByVal value As String)
                _CreateUserName = value
            End Set
        End Property
        Public Property Mrp_ID() As String
            Get
                Return _Mrp_ID
            End Get
            Set(ByVal value As String)
                _Mrp_ID = value
            End Set
        End Property
        Public Property ProductNum() As Int64
            Get
                Return _ProductNum
            End Get
            Set(ByVal value As Int64)
                _ProductNum = value
            End Set
        End Property
        Public Property PurchaseNum() As Int64
            Get
                Return _PurchaseNum
            End Get
            Set(ByVal value As Int64)
                _PurchaseNum = value
            End Set
        End Property

    End Class
End Namespace