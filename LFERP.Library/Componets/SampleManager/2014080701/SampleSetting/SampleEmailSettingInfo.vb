Public Class SampleEmailSettingInfo

    Private _AutoID As Double
    Private _Email_UserID As String
    Private _Email_UserName As String
    Private _Email As String
    Private _CheckOrder As Int64
    Private _CreateUserID As String
    Private _CreateDate As DateTime
    Private _ModifyUserID As String
    Private _ModifyDate As DateTime
    Private _StateAlarmTime As Integer
    Private _EndAlarmTime As Integer
    Private _Remark As String



    ''2014-04-13  «ÀÂ@
    Private _StoreTime As String
    Private _CycleTime As String

 

    Public Sub New()
        _AutoID = 0
        _Email_UserID = Nothing
        _Email_UserName = Nothing
        _Email = Nothing
        _CheckOrder = 0
        _CreateUserID = Nothing
        _CreateDate = Nothing
        _ModifyUserID = Nothing
        _ModifyDate = Nothing
        _Remark = Nothing
        _StateAlarmTime = 0
        _EndAlarmTime = 0

        ''2014-04-13  «ÀÂ@
        _StoreTime = Nothing
        _CycleTime = Nothing

        '_AlarmFlag = Nothing

    End Sub

    Public Property EndAlarmTime() As Integer
        Get
            Return _EndAlarmTime
        End Get
        Set(ByVal value As Integer)
            _EndAlarmTime = value
        End Set
    End Property

    Public Property StateAlarmTime() As Integer
        Get
            Return _StateAlarmTime
        End Get
        Set(ByVal value As Integer)
            _StateAlarmTime = value
        End Set
    End Property

    Public Property AutoID() As Double
        Get
            Return _AutoID
        End Get
        Set(ByVal value As Double)
            _AutoID = value
        End Set
    End Property
    Public Property Email_UserID() As String
        Get
            Return _Email_UserID
        End Get
        Set(ByVal value As String)
            _Email_UserID = value
        End Set
    End Property
    Public Property Email_UserName() As String
        Get
            Return _Email_UserName
        End Get
        Set(ByVal value As String)
            _Email_UserName = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property
    Public Property CheckOrder() As Int64
        Get
            Return _CheckOrder
        End Get
        Set(ByVal value As Int64)
            _CheckOrder = value
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

    '2014-04-13  «ÀÂ@
    Public Property StoreTime() As String
        Get
            Return _StoreTime
        End Get
        Set(ByVal value As String)
            _StoreTime = value
        End Set
    End Property

    '2014-04-13  «ÀÂ@
    Public Property CycleTime() As String
        Get
            Return _CycleTime
        End Get
        Set(ByVal value As String)
            _CycleTime = value
        End Set
    End Property


    '_StoreTime = Nothing
    '   _CycleTime = Nothing

End Class
