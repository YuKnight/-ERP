Namespace LFERP.SystemManager

    Public Class SNRuleInfo

        Private _AutoID As Decimal
        Private _CodeFormat As String
        Private _Name As String
        Private _Type As String
        Private _Description As String
        Private _Sample As String
        Private _CanAlterBillNo As Int64
        Private _CheckAfterSave As Int64
        Private _UseBillCodeRule As Int64
        Private _SingleApproval As Int64
        Private _SingleUnApproval As Int64
        Private _CreateDate As DateTime
        Private _CreateUserID As String
        Private _ModifyDate As DateTime
        Private _ModifyUserID As String
        Private _Remarks As String
        Public Sub New()
            _AutoID = 0
            _CodeFormat = Nothing
            _Name = Nothing
            _Type = Nothing
            _Description = Nothing
            _Sample = Nothing
            _CanAlterBillNo = 0
            _CheckAfterSave = 0
            _UseBillCodeRule = 0
            _SingleApproval = 0
            _SingleUnApproval = 0
            _CreateDate = Nothing
            _CreateUserID = Nothing
            _ModifyDate = Nothing
            _ModifyUserID = Nothing
            _Remarks = Nothing

        End Sub
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property CodeFormat() As String
            Get
                Return _CodeFormat
            End Get
            Set(ByVal value As String)
                _CodeFormat = value
            End Set
        End Property
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal value As String)
                _Name = value
            End Set
        End Property
        Public Property Type() As String
            Get
                Return _Type
            End Get
            Set(ByVal value As String)
                _Type = value
            End Set
        End Property
        Public Property Description() As String
            Get
                Return _Description
            End Get
            Set(ByVal value As String)
                _Description = value
            End Set
        End Property
        Public Property Sample() As String
            Get
                Return _Sample
            End Get
            Set(ByVal value As String)
                _Sample = value
            End Set
        End Property
        Public Property CanAlterBillNo() As Int64
            Get
                Return _CanAlterBillNo
            End Get
            Set(ByVal value As Int64)
                _CanAlterBillNo = value
            End Set
        End Property
        Public Property CheckAfterSave() As Int64
            Get
                Return _CheckAfterSave
            End Get
            Set(ByVal value As Int64)
                _CheckAfterSave = value
            End Set
        End Property
        Public Property UseBillCodeRule() As Int64
            Get
                Return _UseBillCodeRule
            End Get
            Set(ByVal value As Int64)
                _UseBillCodeRule = value
            End Set
        End Property
        Public Property SingleApproval() As Int64
            Get
                Return _SingleApproval
            End Get
            Set(ByVal value As Int64)
                _SingleApproval = value
            End Set
        End Property
        Public Property SingleUnApproval() As Int64
            Get
                Return _SingleUnApproval
            End Get
            Set(ByVal value As Int64)
                _SingleUnApproval = value
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
        Public Property Remarks() As String
            Get
                Return _Remarks
            End Get
            Set(ByVal value As String)
                _Remarks = value
            End Set
        End Property

    End Class

End Namespace