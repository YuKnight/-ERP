Namespace LFERP.DataSetting
    Public Class AuxiliaryDataSubInfo

        Private _BasicSubType As Decimal
        Private _BasicSubName As String
        Private _BasicMainType As Decimal
        Private _BasicMainName As String
        Private _BasicSubDescription As String
        Private _BasicSubFieldType As String
        Private _Sequence As Int64
        Private _IsEnable As Boolean
        Private _CreateUserID As String
        Private _CreateDate As DateTime
        Private _ModifyUserID As String
        Private _ModifyDate As DateTime
        Private _Remark As String
        Private _IsSysDefault As Boolean
        Public Sub New()
            _BasicSubType = 0
            _BasicSubName = Nothing
            _BasicSubDescription = Nothing
            _BasicSubFieldType = Nothing
            _BasicMainType = 0
            _BasicMainName = Nothing
            _Sequence = 0
            _IsEnable = False
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _Remark = Nothing
            _IsSysDefault = Nothing
        End Sub
        Public Property BasicSubType() As Decimal
            Get
                Return _BasicSubType
            End Get
            Set(ByVal value As Decimal)
                _BasicSubType = value
            End Set
        End Property
        Public Property BasicSubName() As String
            Get
                Return _BasicSubName
            End Get
            Set(ByVal value As String)
                _BasicSubName = value
            End Set
        End Property
        Public Property BasicMainName() As String
            Get
                Return _BasicMainName
            End Get
            Set(ByVal value As String)
                _BasicMainName = value
            End Set
        End Property
        Public Property BasicSubDescription() As String
            Get
                Return _BasicSubDescription
            End Get
            Set(ByVal value As String)
                _BasicSubDescription = value
            End Set
        End Property
        Public Property BasicSubFieldType() As String
            Get
                Return _BasicSubFieldType
            End Get
            Set(ByVal value As String)
                _BasicSubFieldType = value
            End Set
        End Property
        Public Property BasicMainType() As Decimal
            Get
                Return _BasicMainType
            End Get
            Set(ByVal value As Decimal)
                _BasicMainType = value
            End Set
        End Property
        Public Property Sequence() As Int64
            Get
                Return _Sequence
            End Get
            Set(ByVal value As Int64)
                _Sequence = value
            End Set
        End Property
        Public Property IsEnable() As Boolean
            Get
                Return _IsEnable
            End Get
            Set(ByVal value As Boolean)
                _IsEnable = value
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
        Public Property IsSysDefault() As Boolean
            Get
                Return _IsSysDefault
            End Get
            Set(ByVal value As Boolean)
                _IsSysDefault = value
            End Set
        End Property
    End Class
End Namespace
