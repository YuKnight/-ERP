Namespace LFERP.Library.SampleManager.SamplePacking
    Public Class SamplePackingInfo
        Private _AutoID As Double
        Private _PK_ID As String
        Private _Shelves_ID As String
        Private _Qty As Integer
        Private _Code_ID As String
        Private _PM_M_Code As String
        Private _Remark As String
        Private _PackingType As String
        Private _PackingUserID As String
        Private _PackingDate As Date
        Private _AddUserID As String
        Private _AddUserName As String
        Private _AddDate As Date
        Private _ModifyUserID As String
        Private _ModifyDate As Date
        Private _CheckUserID As String
        Private _CheckUserName As String
        Private _CheckBit As Boolean
        Private _CheckDate As Date
        Private _CheckRemark As String
        '-----------------------------
        Private _PB_ID As String
        Private _D_ID As String
        Private _D_Dep As String
        Private _SO_SampleID As String
        Private _SE_ID As String
        Private _SE_IDNO As String
        Private _BitNeed As Boolean
        Private _SealCode_ID As String
        Private _UsePKCount As Integer
        Private _UseCount As Integer


        Public Sub New()
            _AutoID = 0
            _PK_ID = Nothing
            _Shelves_ID = Nothing
            _Qty = 0
            _Code_ID = Nothing
            _PM_M_Code = Nothing
            _Remark = Nothing
            _PackingType = Nothing
            _PackingUserID = Nothing
            _PackingDate = Nothing
            _AddUserID = Nothing
            _AddDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _CheckUserID = Nothing
            _CheckBit = False
            _CheckDate = Nothing
            _CheckRemark = Nothing
            _PB_ID = Nothing
            _AddUserName = Nothing
            _CheckUserName = Nothing
            _D_ID = Nothing
            _D_Dep = Nothing
            _SO_SampleID = Nothing
            _SE_ID = Nothing
            _SE_IDNO = Nothing
            _BitNeed = Nothing
            _SealCode_ID = Nothing
            _UsePKCount = Nothing
            _UseCount = Nothing
        End Sub
        Public Property UseCount() As Integer
            Get
                Return _UseCount
            End Get
            Set(ByVal value As Integer)
                _UseCount = value
            End Set
        End Property
        Public Property UsePKCount() As Integer
            Get
                Return _UsePKCount
            End Get
            Set(ByVal value As Integer)
                _UsePKCount = value
            End Set
        End Property

        Public Property SealCode_ID() As String
            Get
                Return _SealCode_ID
            End Get
            Set(ByVal value As String)
                _SealCode_ID = value
            End Set
        End Property
        Public Property BitNeed() As Boolean
            Get
                Return _BitNeed
            End Get
            Set(ByVal value As Boolean)
                _BitNeed = value
            End Set
        End Property

        Public Property SE_IDNO() As String
            Get
                Return _SE_IDNO
            End Get
            Set(ByVal value As String)
                _SE_IDNO = value
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
        Public Property SO_SampleID() As String
            Get
                Return _SO_SampleID
            End Get
            Set(ByVal value As String)
                _SO_SampleID = value
            End Set
        End Property
        Public Property D_Dep() As String
            Get
                Return _D_Dep
            End Get
            Set(ByVal value As String)
                _D_Dep = value
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
        Public Property PackingType() As String
            Get
                Return _PackingType
            End Get
            Set(ByVal value As String)
                _PackingType = value
            End Set
        End Property
        Public Property AddUserName() As String
            Get
                Return _AddUserName
            End Get
            Set(ByVal value As String)
                _AddUserName = value
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
        Public Property AutoID() As Double
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Double)
                _AutoID = value
            End Set
        End Property
        Public Property PK_ID() As String
            Get
                Return _PK_ID
            End Get
            Set(ByVal value As String)
                _PK_ID = value
            End Set
        End Property
        Public Property Shelves_ID() As String
            Get
                Return _Shelves_ID
            End Get
            Set(ByVal value As String)
                _Shelves_ID = value
            End Set
        End Property
        Public Property Qty() As Integer
            Get
                Return _Qty
            End Get
            Set(ByVal value As Integer)
                _Qty = value
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
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
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
        Public Property PackingUserID() As String
            Get
                Return _PackingUserID
            End Get
            Set(ByVal value As String)
                _PackingUserID = value
            End Set
        End Property
        Public Property PackingDate() As Date
            Get
                Return _PackingDate
            End Get
            Set(ByVal value As Date)
                _PackingDate = value
            End Set
        End Property
        Public Property AddUserID() As String
            Get
                Return _AddUserID
            End Get
            Set(ByVal value As String)
                _AddUserID = value
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
        Public Property PB_ID() As String
            Get
                Return _PB_ID
            End Get
            Set(ByVal value As String)
                _PB_ID = value
            End Set
        End Property
    End Class
End Namespace



