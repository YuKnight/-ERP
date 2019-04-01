Namespace LFERP.Library.MrpManager.BomGroup
    Public Class BOMGroupInfo

        Private _AutoID As Decimal
        Private _ParentAutoID As Decimal
        Private _GroupNumber As String
        Private _GroupName As String
        Private _GroupParentID As String
        Private _GroupParentName As String
        Private _CreateUserID As String
        Private _CreateDate As String
        Private _ModifyUserID As String
        Private _ModifyDate As String
        Public Sub New()
            _AutoID = 0
            _ParentAutoID = 0
            _GroupNumber = Nothing
            _GroupName = Nothing
            _GroupParentID = Nothing
            _GroupParentName = Nothing
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing

        End Sub
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property ParentAutoID() As Decimal
            Get
                Return _ParentAutoID
            End Get
            Set(ByVal value As Decimal)
                _ParentAutoID = value
            End Set
        End Property
        Public Property GroupNumber() As String
            Get
                Return _GroupNumber
            End Get
            Set(ByVal value As String)
                _GroupNumber = value
            End Set
        End Property
        Public Property GroupName() As String
            Get
                Return _GroupName
            End Get
            Set(ByVal value As String)
                _GroupName = value
            End Set
        End Property
        Public Property GroupParentName() As String
            Get
                Return _GroupParentName
            End Get
            Set(ByVal value As String)
                _GroupParentName = value
            End Set
        End Property
        Public Property GroupParentID() As String
            Get
                Return _GroupParentID
            End Get
            Set(ByVal value As String)
                _GroupParentID = value
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
        Public Property CreateDate() As String
            Get
                Return _CreateDate
            End Get
            Set(ByVal value As String)
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
        Public Property ModifyDate() As String
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As String)
                _ModifyDate = value
            End Set
        End Property

    End Class
End Namespace