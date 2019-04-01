Namespace LFERP.Library.MrpManager.MrpWareHouseInfo
    Public Class MrpWareHouseInfoInfo

        Private _Ware_ID As String
        Private _M_Code As String
        Private _MRP_ID As String
        Private _MD_ISMrp As Boolean
        Private _MD_RecordCreateDate As String
        Private _CheckUserName As String
        Private _CheckUserID As String
        Private _CheckBit As Boolean
        Private _CheckRemark As String
        Private _CreateUserID As String
        Private _CreateDate As String
        Private _ModifyUserID As String
        Private _ModifyDate As String
        Private _AutoID As String
        Public Sub New()
            _Ware_ID = Nothing
            _M_Code = Nothing
            _MRP_ID = Nothing
            _MD_ISMrp = Nothing
            _MD_RecordCreateDate = Nothing
            _CheckUserName = Nothing
            _CheckUserID = Nothing
            _CheckBit = Nothing
            _CheckRemark = Nothing
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _AutoID = Nothing
        End Sub
        Public Property Ware_ID() As String
            Get
                Return _Ware_ID
            End Get
            Set(ByVal value As String)
                _Ware_ID = value
            End Set
        End Property
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
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
        Public Property MD_ISMrp() As Boolean
            Get
                Return _MD_ISMrp
            End Get
            Set(ByVal value As Boolean)
                _MD_ISMrp = value
            End Set
        End Property
        Public Property MD_RecordCreateDate() As String
            Get
                Return _MD_RecordCreateDate
            End Get
            Set(ByVal value As String)
                _MD_RecordCreateDate = value
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
        Public Property CheckUserID() As String
            Get
                Return _CheckUserID
            End Get
            Set(ByVal value As String)
                _CheckUserID = value
            End Set
        End Property
        Public Property CheckBit() As Boolean
            Get
                Return _CheckBit
            End Get
            Set(ByVal value As Boolean)
                _CheckBit = value
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
        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property
    End Class
End Namespace