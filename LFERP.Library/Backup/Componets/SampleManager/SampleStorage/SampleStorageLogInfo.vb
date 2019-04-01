Public Class SampleStorageLogInfo

	Private _AutoID As Decimal
	Private _D_ID As String
	Private _Code_ID As String
	Private _SS_StorageLocation As String
	Private _SS_ShelveID As String
    Private _SO_ID As String
	Private _CreateUserID As String
	Private _CreateDate As DateTime
	Private _Remark As String
    Private _OperateType As String
    Private _DepName As String
    Private _CreateUserName As String
    Private _Operate As String
    Private _SO_SampleID As String
    Private _PM_M_Code As String

	Public Sub New()
		_AutoID =  0
		_D_ID =  Nothing
		_Code_ID =  Nothing
		_SS_StorageLocation =  Nothing
		_SS_ShelveID =  Nothing
        _SO_ID = Nothing
        _CreateUserID = Nothing
        _CreateDate = Nothing
        _Remark = Nothing
        _OperateType = Nothing
        _DepName = Nothing
        _CreateUserName = Nothing
        _Operate = Nothing
        _SO_SampleID = Nothing
        _PM_M_Code = Nothing
    End Sub

    Public Property PM_M_Code() As String
        Get
            Return _PM_M_Code
        End Get
        Set(ByVal value As String)
            _PM_M_Code = value
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
    Public Property Operate() As String
        Get
            Return _Operate
        End Get
        Set(ByVal value As String)
            _Operate = value
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
    Public Property DepName() As String
        Get
            Return _DepName
        End Get
        Set(ByVal value As String)
            _DepName = value
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
    Public Property D_ID() As String
        Get
            Return _D_ID
        End Get
        Set(ByVal value As String)
            _D_ID = value
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
    Public Property SS_StorageLocation() As String
        Get
            Return _SS_StorageLocation
        End Get
        Set(ByVal value As String)
            _SS_StorageLocation = value
        End Set
    End Property
    Public Property SS_ShelveID() As String
        Get
            Return _SS_ShelveID
        End Get
        Set(ByVal value As String)
            _SS_ShelveID = value
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
	Public Property CreateUserID() As String
		Get
			Return _CreateUserID
		End Get
		Set(ByVal value As String)
			_CreateUserID =value
		End Set
	End Property
	Public Property CreateDate() As DateTime
		Get
			Return _CreateDate
		End Get
		Set(ByVal value As DateTime)
			_CreateDate =value
		End Set
	End Property
	Public Property Remark() As String
		Get
			Return _Remark
		End Get
		Set(ByVal value As String)
			_Remark =value
		End Set
	End Property
	Public Property OperateType() As String
		Get
			Return _OperateType
		End Get
		Set(ByVal value As String)
			_OperateType =value
		End Set
	End Property

End Class
