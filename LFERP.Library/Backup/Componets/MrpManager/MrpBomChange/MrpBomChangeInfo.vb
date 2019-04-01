
Namespace LFERP.Library.MrpManager.MrpBomChange


    Public Class MrpBomChangeInfo

        Private _AutoID As Decimal
        Private _ChangeOrderNo As String
        Private _ApplyDate As DateTime
        Private _Reason As String
        Private _Affect As String
        Private _DealLevel As String
        Private _DataSource As String
        Private _AffectDept As String
        Private _Changer As String
        Private _DeptDirector As String
        Private _ExecuteDate As DateTime
        Private _ExecuteUserID As String
        Private _IsCheck As Boolean
        Private _CheckUserID As String
        Private _CheckDate As DateTime
        Private _CheckRemarks As String
        Private _CreateUserID As String
        Private _CreateDate As DateTime
        Private _ModifyUserID As String
        Private _ModifyDate As DateTime
        Private _Remarks As String

        Private _CreateUserName As String
        Private _CheckUserName As String
        Public Sub New()
            _AutoID = 0
            _ChangeOrderNo = Nothing
            _ApplyDate = Nothing
            _Reason = Nothing
            _Affect = Nothing
            _DealLevel = Nothing
            _DataSource = Nothing
            _AffectDept = Nothing
            _Changer = Nothing
            _DeptDirector = Nothing
            _ExecuteDate = Nothing
            _ExecuteUserID = Nothing
            _IsCheck = False
            _CheckUserID = Nothing
            _CheckDate = Nothing
            _CheckRemarks = Nothing
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _Remarks = Nothing

            _CreateUserName = Nothing
            _CheckUserName = Nothing
        End Sub
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property ChangeOrderNo() As String
            Get
                Return _ChangeOrderNo
            End Get
            Set(ByVal value As String)
                _ChangeOrderNo = value
            End Set
        End Property
        Public Property ApplyDate() As DateTime
            Get
                Return _ApplyDate
            End Get
            Set(ByVal value As DateTime)
                _ApplyDate = value
            End Set
        End Property
        Public Property Reason() As String
            Get
                Return _Reason
            End Get
            Set(ByVal value As String)
                _Reason = value
            End Set
        End Property
        Public Property Affect() As String
            Get
                Return _Affect
            End Get
            Set(ByVal value As String)
                _Affect = value
            End Set
        End Property
        Public Property DealLevel() As String
            Get
                Return _DealLevel
            End Get
            Set(ByVal value As String)
                _DealLevel = value
            End Set
        End Property
        Public Property DataSource() As String
            Get
                Return _DataSource
            End Get
            Set(ByVal value As String)
                _DataSource = value
            End Set
        End Property
        Public Property AffectDept() As String
            Get
                Return _AffectDept
            End Get
            Set(ByVal value As String)
                _AffectDept = value
            End Set
        End Property
        Public Property Changer() As String
            Get
                Return _Changer
            End Get
            Set(ByVal value As String)
                _Changer = value
            End Set
        End Property
        Public Property DeptDirector() As String
            Get
                Return _DeptDirector
            End Get
            Set(ByVal value As String)
                _DeptDirector = value
            End Set
        End Property
        Public Property ExecuteDate() As DateTime
            Get
                Return _ExecuteDate
            End Get
            Set(ByVal value As DateTime)
                _ExecuteDate = value
            End Set
        End Property
        Public Property ExecuteUserID() As String
            Get
                Return _ExecuteUserID
            End Get
            Set(ByVal value As String)
                _ExecuteUserID = value
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

        Public Property CreateUserName() As String
            Get
                Return _CreateUserName
            End Get
            Set(ByVal value As String)
                _CreateUserName = value
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
    End Class
End Namespace