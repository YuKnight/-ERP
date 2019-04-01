Namespace LFERP.Library.NmetalSampleManager.NmetalSampInventoryWeightCheck
    Public Class NmetalSampInventoryWeightCheckMainInfo

        Private _AutoID As String
        Private _CH_NO As String
        Private _DepID As String
        Private _CH_Date As Date
        Private _CH_Action As String

        Private _CH_Remark As String
        Private _AddAction As String
        Private _AddDate As Date
        Private _ModifyUserID As String
        Private _ModifyDate As Date

        Private _CheckStatus As Boolean
        Private _CheckAction As String
        Private _CheckDate As Date
        Private _CheckRemark As String

        Private _DepName As String
        Private _CHAction_Name As String
        Private _Add_Name As String
        Private _Modify_Name As String
        Private _Check_Name As String
        Private _CheckWastWeight As Decimal
        Private _CheckType As String

        Private _CheckDwonRate As Decimal
        Private _CheckUpRate As Decimal
        Private _Code_ID As String


        Public Sub New()
           

            _AutoID = Nothing
            _CH_NO = Nothing
            _DepID = Nothing
            _CH_Date = Nothing
            _CH_Action = Nothing

            _CH_Remark = Nothing
            _AddAction = Nothing
            _AddDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing

            _CheckStatus = Nothing
            _CheckAction = Nothing
            _CheckDate = Nothing
            _CheckRemark = Nothing

            _DepName = Nothing
            _CHAction_Name = Nothing
            _Add_Name = Nothing
            _Modify_Name = Nothing
            _Check_Name = Nothing

            _CheckWastWeight = Nothing
            _CheckType = Nothing

            _CheckDwonRate = 0
            _CheckUpRate = 0

            _Code_ID = Nothing

        End Sub
        Public Property Code_ID() As String
            Get
                Return _Code_ID
            End Get
            Set(ByVal value As String)
                _Code_ID = value
            End Set
        End Property


        Public Property CheckUpRate() As Decimal
            Get
                Return _CheckUpRate
            End Get
            Set(ByVal value As Decimal)
                _CheckUpRate = value
            End Set
        End Property


        Public Property CheckDwonRate() As Decimal
            Get
                Return _CheckDwonRate
            End Get
            Set(ByVal value As Decimal)
                _CheckDwonRate = value
            End Set
        End Property

        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property
        Public Property CH_NO() As String
            Get
                Return _CH_NO
            End Get
            Set(ByVal value As String)
                _CH_NO = value
            End Set
        End Property
        Public Property DepID() As String
            Get
                Return _DepID
            End Get
            Set(ByVal value As String)
                _DepID = value
            End Set
        End Property
        Public Property CH_Date() As Date
            Get
                Return _CH_Date
            End Get
            Set(ByVal value As Date)
                _CH_Date = value
            End Set
        End Property
        Public Property CH_Action() As String
            Get
                Return _CH_Action
            End Get
            Set(ByVal value As String)
                _CH_Action = value
            End Set
        End Property


        Public Property CH_Remark() As String
            Get
                Return _CH_Remark
            End Get
            Set(ByVal value As String)
                _CH_Remark = value
            End Set
        End Property
        Public Property AddAction() As String
            Get
                Return _AddAction
            End Get
            Set(ByVal value As String)
                _AddAction = value
            End Set
        End Property
        Public Property AddDate() As Date
            Get
                Return _AddDate
            End Get
            Set(ByVal value As Date)
                _AddDate = value
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
        Public Property ModifyDate() As Date
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As Date)
                _ModifyDate = value
            End Set
        End Property


        Public Property CheckStatus() As Boolean
            Get
                Return _CheckStatus
            End Get
            Set(ByVal value As Boolean)
                _CheckStatus = value
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
        Public Property CheckDate() As Date
            Get
                Return _CheckDate
            End Get
            Set(ByVal value As Date)
                _CheckDate = value
            End Set
        End Property
        Public Property CheckRemark() As String
            Get
                Return _CheckRemark
            End Get
            Set(ByVal value As String)
                _CheckRemark = value
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
        Public Property CHAction_Name() As String
            Get
                Return _CHAction_Name
            End Get
            Set(ByVal value As String)
                _CHAction_Name = value
            End Set
        End Property
        Public Property Add_Name() As String
            Get
                Return _Add_Name
            End Get
            Set(ByVal value As String)
                _Add_Name = value
            End Set
        End Property
        Public Property Modify_Name() As String
            Get
                Return _Modify_Name
            End Get
            Set(ByVal value As String)
                _Modify_Name = value
            End Set
        End Property
        Public Property Check_Name() As String
            Get
                Return _Check_Name
            End Get
            Set(ByVal value As String)
                _Check_Name = value
            End Set
        End Property


        Public Property CheckWastWeight() As Decimal
            Get
                Return _CheckWastWeight
            End Get
            Set(ByVal value As Decimal)
                _CheckWastWeight = value
            End Set
        End Property
        Public Property CheckType() As String
            Get
                Return _CheckType
            End Get
            Set(ByVal value As String)
                _CheckType = value
            End Set
        End Property
    End Class
End Namespace