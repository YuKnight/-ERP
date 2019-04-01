Namespace LFERP.Library.MrpManager.Mrp_Info

    Public Class Mrp_InfoInfo
        Private _MRP_ID As String
        Private _FNeedBeginDate As Date
        Private _FNeedEndDate As Date
        Private _FType As String
        Private _FWayBeginDate As Date
        Private _SchemeID As String
        Private _FLogTxt As String
        Private _CreateUserID As String
        Private _CreateDate As Date
        Private _ModifyUserID As String
        Private _ModifyDate As Date
        Private _CreateUserName As String
        Private _ModifyUserName As String
        Private _AutoID As Decimal


        Public Sub New()
            _MRP_ID = Nothing
            _FNeedBeginDate = Nothing
            _FNeedEndDate = Nothing
            _FType = Nothing
            _FWayBeginDate = Nothing
            _SchemeID = Nothing
            _FLogTxt = Nothing
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _CreateUserName = Nothing
            _ModifyUserName = Nothing
            _AutoID = Nothing
        End Sub
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property ModifyUserName() As String
            Get
                Return _ModifyUserName
            End Get
            Set(ByVal value As String)
                _ModifyUserName = value
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


        Public Property CreateDate() As Date
            Get
                Return _CreateDate
            End Get
            Set(ByVal value As Date)
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
        Public Property FLogTxt() As String
            Get
                Return _FLogTxt
            End Get
            Set(ByVal value As String)
                _FLogTxt = value
            End Set
        End Property
        Public Property SchemeID() As String
            Get
                Return _SchemeID
            End Get
            Set(ByVal value As String)
                _SchemeID = value
            End Set
        End Property
        Public Property FWayBeginDate() As Date
            Get
                Return _FWayBeginDate
            End Get
            Set(ByVal value As Date)
                _FWayBeginDate = value
            End Set
        End Property

        Public Property FType() As String
            Get
                Return _FType
            End Get
            Set(ByVal value As String)
                _FType = value
            End Set
        End Property
        Public Property FNeedEndDate() As Date
            Get
                Return _FNeedEndDate
            End Get
            Set(ByVal value As Date)
                _FNeedEndDate = value
            End Set
        End Property
        Public Property FNeedBeginDate() As Date
            Get
                Return _FNeedBeginDate
            End Get
            Set(ByVal value As Date)
                _FNeedBeginDate = value
            End Set
        End Property
        Public Property MRP_ID() As String
            Get
                Return _MRP_ID
            End Get
            Set(ByVal value As String)
                _MRP_ID = value
            End Set
        End Property
    

    End Class
End Namespace