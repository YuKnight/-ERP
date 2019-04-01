Namespace LFERP.Library.SampleManager.SampleSetting
    Public Class SampleSettingInfo
        Private _AutoID As Decimal
        Private _U_ID As String
        Private _SampleOrdersBeginDate As DateTime
        Private _SampleOrdersCheck As String
        Private _SampleOrdersCreateUserID As String
        '---------------------------------------------
        Private _SampleProcessBeginDate As DateTime
        Private _SampleProcessCheck As String
        Private _SampleProcessCreateUserID As String
        '---------------------------------------------
        Private _SamplePaceBeginDate As DateTime
        Private _SamplePaceCheck As String
        Private _SamplePaceCreateUserID As String

        Private _SamplePacePortName As String
        Private _SamplePaceBaudRate As Integer
        Private _SamplePaceBitWeighing As Boolean
        '---------------------------------------------
        Private _SampleSendBeginDate As DateTime
        Private _SampleSendCheck As String
        Private _SampleSendCreateUserID As String
        '---------------------------------------------
        Private _SampleCustomerFeedbackBeginDate As DateTime
        Private _SampleCustomerFeedbackCheck As String
        Private _SampleCustomerFeedbackCreateUserID As String
        '---------------------------------------------
        Private _SampleCollectionBeginDate As DateTime
        Private _SampleCollectionCheck As String
        Private _SampleCollectionCreateUserID As String
        Private _SampleCollectionStatusType As String
        Private _SampleCollectionD_ID As String
        '---------------------------------------------
        Private _SampleTransactionBeginDate As DateTime
        Private _SampleTransactionCheck As String
        Private _SampleTransactionCreateUserID As String
        '---------------------------------------------
        Private _SampleWareInventoryBeginDate As DateTime
        Private _SampleWareInventoryCheck As String
        Private _SampleWareInventoryCreateUserID As String
        '---------------------------------------------
        Private _SamplePackingBeginDate As DateTime
        Private _SamplePackingCheck As String
        Private _SamplePackingCreateUserID As String
        '---------------------------------------------
        Private _SamplePlanBeginDate As DateTime
        Private _SamplePlanCheck As String
        Private _SamplePlanCreateUserID As String
        '---------------------------------------------
        Private _SampleDivertBeginDate As DateTime
        Private _SampleDivertCheck As String
        Private _SampleDivertCreateUserID As String

        Public Sub New()
            _AutoID = 0
            _U_ID = Nothing
            '---------------------------------------------
            _SampleOrdersBeginDate = Nothing
            _SampleOrdersCheck = Nothing
            _SampleOrdersCreateUserID = Nothing
            '---------------------------------------------
            _SampleProcessBeginDate = Nothing
            _SampleProcessCheck = Nothing
            _SampleProcessCreateUserID = Nothing
            '---------------------------------------------
            _SamplePaceBeginDate = Nothing
            _SamplePaceCheck = Nothing
            _SamplePaceCreateUserID = Nothing
            _SamplePacePortName = Nothing
            _SamplePaceBaudRate = Nothing
            _SamplePaceBitWeighing = Nothing
            '---------------------------------------------
            _SampleSendBeginDate = Nothing
            _SampleSendCheck = Nothing
            _SampleSendCreateUserID = Nothing
            '---------------------------------------------
            _SampleCustomerFeedbackBeginDate = Nothing
            _SampleCustomerFeedbackCheck = Nothing
            _SampleCustomerFeedbackCreateUserID = Nothing
            '---------------------------------------------
            _SampleCollectionBeginDate = Nothing
            _SampleCollectionCheck = Nothing
            _SampleCollectionCreateUserID = Nothing
            _SampleCollectionStatusType = Nothing
            _SampleCollectionD_ID = Nothing
            '---------------------------------------------
            _SampleTransactionBeginDate = Nothing
            _SampleTransactionCheck = Nothing
            _SampleTransactionCreateUserID = Nothing
            '---------------------------------------------
            _SampleWareInventoryBeginDate = Nothing
            _SampleWareInventoryCheck = Nothing
            _SampleWareInventoryCreateUserID = Nothing
            '---------------------------------------------
            _SamplePackingBeginDate = Nothing
            _SamplePackingCheck = Nothing
            _SamplePackingCreateUserID = Nothing
            '---------------------------------------------
            _SamplePlanBeginDate = Nothing
            _SamplePlanCheck = Nothing
            _SamplePlanCreateUserID = Nothing
            '---------------------------------------------
            _SampleDivertBeginDate = Nothing
            _SampleDivertCheck = Nothing
            _SampleDivertCreateUserID = Nothing
        End Sub
        Public Property SampleDivertBeginDate() As DateTime
            Get
                Return _SampleDivertBeginDate
            End Get
            Set(ByVal value As DateTime)
                _SampleDivertBeginDate = value
            End Set
        End Property
        Public Property SampleDivertCheck() As String
            Get
                Return _SampleDivertCheck
            End Get
            Set(ByVal value As String)
                _SampleDivertCheck = value
            End Set
        End Property
        Public Property SamplePaceBitWeighing() As Boolean
            Get
                Return _SamplePaceBitWeighing
            End Get
            Set(ByVal value As Boolean)
                _SamplePaceBitWeighing = value
            End Set
        End Property

        Public Property SampleDivertCreateUserID() As String
            Get
                Return _SampleDivertCreateUserID
            End Get
            Set(ByVal value As String)
                _SampleDivertCreateUserID = value
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
        Public Property U_ID() As String
            Get
                Return _U_ID
            End Get
            Set(ByVal value As String)
                _U_ID = value
            End Set
        End Property
        '---------------------------------------------
        Public Property SampleOrdersBeginDate() As DateTime
            Get
                Return _SampleOrdersBeginDate
            End Get
            Set(ByVal value As DateTime)
                _SampleOrdersBeginDate = value
            End Set
        End Property
        Public Property SampleOrdersCheck() As String
            Get
                Return _SampleOrdersCheck
            End Get
            Set(ByVal value As String)
                _SampleOrdersCheck = value
            End Set
        End Property
        Public Property SampleOrdersCreateUserID() As String
            Get
                Return _SampleOrdersCreateUserID
            End Get
            Set(ByVal value As String)
                _SampleOrdersCreateUserID = value
            End Set
        End Property
        '---------------------------------------------
        Public Property SampleProcessBeginDate() As DateTime
            Get
                Return _SampleProcessBeginDate
            End Get
            Set(ByVal value As DateTime)
                _SampleProcessBeginDate = value
            End Set
        End Property
        Public Property SampleProcessCheck() As String
            Get
                Return _SampleProcessCheck
            End Get
            Set(ByVal value As String)
                _SampleProcessCheck = value
            End Set
        End Property
        Public Property SampleProcessCreateUserID() As String
            Get
                Return _SampleProcessCreateUserID
            End Get
            Set(ByVal value As String)
                _SampleProcessCreateUserID = value
            End Set
        End Property
        '---------------------------------------------
        Public Property SamplePaceBeginDate() As DateTime
            Get
                Return _SamplePaceBeginDate
            End Get
            Set(ByVal value As DateTime)
                _SamplePaceBeginDate = value
            End Set
        End Property
        Public Property SamplePaceCheck() As String
            Get
                Return _SamplePaceCheck
            End Get
            Set(ByVal value As String)
                _SamplePaceCheck = value
            End Set
        End Property
        Public Property SamplePacePortName() As String
            Get
                Return _SamplePacePortName
            End Get
            Set(ByVal value As String)
                _SamplePacePortName = value
            End Set
        End Property
        Public Property SamplePaceBaudRate() As Integer
            Get
                Return _SamplePaceBaudRate
            End Get
            Set(ByVal value As Integer)
                _SamplePaceBaudRate = value
            End Set
        End Property
        Public Property SamplePaceCreateUserID() As String
            Get
                Return _SamplePaceCreateUserID
            End Get
            Set(ByVal value As String)
                _SamplePaceCreateUserID = value
            End Set
        End Property
        '---------------------------------------------
        Public Property SampleSendBeginDate() As DateTime
            Get
                Return _SampleSendBeginDate
            End Get
            Set(ByVal value As DateTime)
                _SampleSendBeginDate = value
            End Set
        End Property
        Public Property SampleSendCheck() As String
            Get
                Return _SampleSendCheck
            End Get
            Set(ByVal value As String)
                _SampleSendCheck = value
            End Set
        End Property
        Public Property SampleSendCreateUserID() As String
            Get
                Return _SampleSendCreateUserID
            End Get
            Set(ByVal value As String)
                _SampleSendCreateUserID = value
            End Set
        End Property
        '---------------------------------------------
        Public Property SampleCustomerFeedbackBeginDate() As DateTime
            Get
                Return _SampleCustomerFeedbackBeginDate
            End Get
            Set(ByVal value As DateTime)
                _SampleCustomerFeedbackBeginDate = value
            End Set
        End Property
        Public Property SampleCustomerFeedbackCheck() As String
            Get
                Return _SampleCustomerFeedbackCheck
            End Get
            Set(ByVal value As String)
                _SampleCustomerFeedbackCheck = value
            End Set
        End Property
        Public Property SampleCustomerFeedbackCreateUserID() As String
            Get
                Return _SampleCustomerFeedbackCreateUserID
            End Get
            Set(ByVal value As String)
                _SampleCustomerFeedbackCreateUserID = value
            End Set
        End Property
        '---------------------------------------------
        Public Property SampleCollectionBeginDate() As DateTime
            Get
                Return _SampleCollectionBeginDate
            End Get
            Set(ByVal value As DateTime)
                _SampleCollectionBeginDate = value
            End Set
        End Property
        Public Property SampleCollectionCheck() As String
            Get
                Return _SampleCollectionCheck
            End Get
            Set(ByVal value As String)
                _SampleCollectionCheck = value
            End Set
        End Property
        Public Property SampleCollectionCreateUserID() As String
            Get
                Return _SampleCollectionCreateUserID
            End Get
            Set(ByVal value As String)
                _SampleCollectionCreateUserID = value
            End Set
        End Property
        Public Property SampleCollectionD_ID() As String
            Get
                Return _SampleCollectionD_ID
            End Get
            Set(ByVal value As String)
                _SampleCollectionD_ID = value
            End Set
        End Property
        Public Property SampleCollectionStatusType() As String
            Get
                Return _SampleCollectionStatusType
            End Get
            Set(ByVal value As String)
                _SampleCollectionStatusType = value
            End Set
        End Property
        '---------------------------------------------
        Public Property SampleTransactionBeginDate() As DateTime
            Get
                Return _SampleTransactionBeginDate
            End Get
            Set(ByVal value As DateTime)
                _SampleTransactionBeginDate = value
            End Set
        End Property
        Public Property SampleTransactionCheck() As String
            Get
                Return _SampleTransactionCheck
            End Get
            Set(ByVal value As String)
                _SampleTransactionCheck = value
            End Set
        End Property
        Public Property SampleTransactionCreateUserID() As String
            Get
                Return _SampleTransactionCreateUserID
            End Get
            Set(ByVal value As String)
                _SampleTransactionCreateUserID = value
            End Set
        End Property
        '---------------------------------------------
        Public Property SampleWareInventoryBeginDate() As DateTime
            Get
                Return _SampleWareInventoryBeginDate
            End Get
            Set(ByVal value As DateTime)
                _SampleWareInventoryBeginDate = value
            End Set
        End Property
        Public Property SampleWareInventoryCheck() As String
            Get
                Return _SampleWareInventoryCheck
            End Get
            Set(ByVal value As String)
                _SampleWareInventoryCheck = value
            End Set
        End Property
        Public Property SampleWareInventoryCreateUserID() As String
            Get
                Return _SampleWareInventoryCreateUserID
            End Get
            Set(ByVal value As String)
                _SampleWareInventoryCreateUserID = value
            End Set
        End Property
        '---------------------------------------------
        Public Property SamplePackingBeginDate() As DateTime
            Get
                Return _SamplePackingBeginDate
            End Get
            Set(ByVal value As DateTime)
                _SamplePackingBeginDate = value
            End Set
        End Property
        Public Property SamplePackingCheck() As String
            Get
                Return _SamplePackingCheck
            End Get
            Set(ByVal value As String)
                _SamplePackingCheck = value
            End Set
        End Property
        Public Property SamplePackingCreateUserID() As String
            Get
                Return _SamplePackingCreateUserID
            End Get
            Set(ByVal value As String)
                _SamplePackingCreateUserID = value
            End Set
        End Property
        '---------------------------------------------
        Public Property SamplePlanBeginDate() As DateTime
            Get
                Return _SamplePlanBeginDate
            End Get
            Set(ByVal value As DateTime)
                _SamplePlanBeginDate = value
            End Set
        End Property
        Public Property SamplePlanCheck() As String
            Get
                Return _SamplePlanCheck
            End Get
            Set(ByVal value As String)
                _SamplePlanCheck = value
            End Set
        End Property
        Public Property SamplePlanCreateUserID() As String
            Get
                Return _SamplePlanCreateUserID
            End Get
            Set(ByVal value As String)
                _SamplePlanCreateUserID = value
            End Set
        End Property
    End Class
End Namespace