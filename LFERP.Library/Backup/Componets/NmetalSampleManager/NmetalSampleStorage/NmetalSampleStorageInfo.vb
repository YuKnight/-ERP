Namespace LFERP.Library.NmetalSampleManager.NmetalSampleStorage


    Public Class NmetalSampleStorageInfo
        Private _AutoID As Decimal
        Private _D_ID As String
        Private _Code_ID As String
        Private _SS_StorageLocation As String
        Private _SS_ShelveID As String
        Private _SO_ID As String
        Private _CreateUserID As String
        Private _CreateDate As DateTime
        Private _ModifyUserID As String
        Private _ModifyDate As DateTime
        Private _CheckBit As Boolean
        Private _CheckDate As DateTime
        Private _CheckRemark As String
        Private _CheckUserID As String
        Private _Remark As String
        Private _CreateUserName As String
        Private _ModifyUserName As String
        Private _CheckUserName As String
        Private _DepName As String
        Private _Qty As Decimal
        Private _SE_ID As String
        Private _PM_M_Code As String
        Private _SO_SampleID As String
        Private _PK_Code_ID As String
        Public Sub New()
            _AutoID = Nothing
            _D_ID = Nothing
            _Code_ID = Nothing
            _SS_StorageLocation = Nothing
            _SS_ShelveID = Nothing
            _SO_ID = Nothing
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _CheckBit = Nothing
            _CheckDate = Nothing
            _CheckRemark = Nothing
            _CheckUserID = Nothing
            _Remark = Nothing
            _CreateUserName = Nothing
            _ModifyUserName = Nothing
            _CheckUserName = Nothing
            _DepName = Nothing
            _Qty = 0
            _SE_ID = Nothing
            _PM_M_Code = Nothing
            _SO_SampleID = Nothing
            _PK_Code_ID = Nothing
        End Sub
        Public Property PK_Code_ID() As String
            Get
                Return _PK_Code_ID
            End Get
            Set(ByVal value As String)
                _PK_Code_ID = value
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
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
            End Set
        End Property
        Public Property SE_ID() As String
            Get
                Return _SE_ID
            End Get
            Set(ByVal value As String)
                _SE_ID = value
            End Set
        End Property
        Public Property Qty() As Decimal
            Get
                Return _Qty
            End Get
            Set(ByVal value As Decimal)
                _Qty = value
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
        Public Property CreateUserName() As String
            Get
                Return _CreateUserName
            End Get
            Set(ByVal value As String)
                _CreateUserName = value
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
        Public Property CheckUserName() As String
            Get
                Return _CheckUserName
            End Get
            Set(ByVal value As String)
                _CheckUserName = value
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
        Public Property CheckBit() As Boolean
            Get
                Return _CheckBit
            End Get
            Set(ByVal value As Boolean)
                _CheckBit = value
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
        Public Property CheckRemark() As String
            Get
                Return _CheckRemark
            End Get
            Set(ByVal value As String)
                _CheckRemark = value
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
        Public Property Remark() As String
            Get
                Return _Remark
            End Get
            Set(ByVal value As String)
                _Remark = value
            End Set
        End Property
    End Class
End Namespace