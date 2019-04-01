Namespace LFERP.Library.MrpManager.MrpInfo

    Public Class MrpInfoInfo

        Private _MRP_ID As String
        Private _MI_MRPDate As Date
        Private _MI_LogTxt As String
        Private _MI_NeedBeginDate As Date
        Private _MI_NeedEndDate As Date
        Private _MI_MRPType As String
        Private _MI_CheckUserID As String
        Private _MI_CheckBit As Boolean
        Private _MI_CheckDate As Date
        Private _MI_CheckRemark As String
        Private _MI_CreateUserID As String
        Private _MI_CreateDate As Date
        Private _MI_ModifyUserID As String
        Private _MI_ModifyDate As Date
        Private _AutoID As Decimal
        Private _MI_CreateUserName As String
        Private _MI_CheckUserName As String
        Private _MI_Remarks As String
        Private _MI_ForecastID As String
        Private _MI_CalcType As Int16
        Private _MI_WareID As String
        Public Sub New()
            _MRP_ID = Nothing
            _MI_MRPDate = Nothing
            _MI_LogTxt = Nothing
            _MI_NeedBeginDate = Nothing
            _MI_NeedEndDate = Nothing
            _MI_MRPType = Nothing
            _MI_CheckUserID = Nothing
            _MI_CheckBit = False
            _MI_CheckDate = Nothing
            _MI_CheckRemark = Nothing
            _MI_CreateUserID = Nothing
            _MI_CreateDate = Nothing
            _MI_ModifyUserID = Nothing
            _MI_ModifyDate = Nothing
            _AutoID = 0
            _MI_CreateUserName = Nothing
            _MI_CheckUserName = Nothing
            _MI_Remarks = Nothing
            _MI_ForecastID = Nothing
            _MI_CalcType = Nothing
            _MI_WareID = Nothing
        End Sub
        Public Property MRP_ID() As String
            Get
                Return _MRP_ID
            End Get
            Set(ByVal value As String)
                _MRP_ID = value
            End Set
        End Property
        Public Property MI_MRPDate() As Date
            Get
                Return _MI_MRPDate
            End Get
            Set(ByVal value As Date)
                _MI_MRPDate = value
            End Set
        End Property
        Public Property MI_LogTxt() As String
            Get
                Return _MI_LogTxt
            End Get
            Set(ByVal value As String)
                _MI_LogTxt = value
            End Set
        End Property
        Public Property MI_NeedBeginDate() As Date
            Get
                Return _MI_NeedBeginDate
            End Get
            Set(ByVal value As Date)
                _MI_NeedBeginDate = value
            End Set
        End Property
        Public Property MI_NeedEndDate() As Date
            Get
                Return _MI_NeedEndDate
            End Get
            Set(ByVal value As Date)
                _MI_NeedEndDate = value
            End Set
        End Property
        Public Property MI_MRPType() As String
            Get
                Return _MI_MRPType
            End Get
            Set(ByVal value As String)
                _MI_MRPType = value
            End Set
        End Property
        Public Property MI_CheckUserID() As String
            Get
                Return _MI_CheckUserID
            End Get
            Set(ByVal value As String)
                _MI_CheckUserID = value
            End Set
        End Property
        Public Property MI_CheckBit() As Boolean
            Get
                Return _MI_CheckBit
            End Get
            Set(ByVal value As Boolean)
                _MI_CheckBit = value
            End Set
        End Property
        Public Property MI_CheckDate() As Date
            Get
                Return _MI_CheckDate
            End Get
            Set(ByVal value As Date)
                _MI_CheckDate = value
            End Set
        End Property
        Public Property MI_CheckRemark() As String
            Get
                Return _MI_CheckRemark
            End Get
            Set(ByVal value As String)
                _MI_CheckRemark = value
            End Set
        End Property
        Public Property MI_CreateUserID() As String
            Get
                Return _MI_CreateUserID
            End Get
            Set(ByVal value As String)
                _MI_CreateUserID = value
            End Set
        End Property
        Public Property MI_CreateDate() As Date
            Get
                Return _MI_CreateDate
            End Get
            Set(ByVal value As Date)
                _MI_CreateDate = value
            End Set
        End Property
        Public Property MI_ModifyUserID() As String
            Get
                Return _MI_ModifyUserID
            End Get
            Set(ByVal value As String)
                _MI_ModifyUserID = value
            End Set
        End Property
        Public Property MI_ModifyDate() As Date
            Get
                Return _MI_ModifyDate
            End Get
            Set(ByVal value As Date)
                _MI_ModifyDate = value
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
        Public Property MI_CreateUserName() As String
            Get
                Return _MI_CreateUserName
            End Get
            Set(ByVal value As String)
                _MI_CreateUserName = value
            End Set
        End Property
        Public Property MI_CheckUserName() As String
            Get
                Return _MI_CheckUserName
            End Get
            Set(ByVal value As String)
                _MI_CheckUserName = value
            End Set
        End Property
        Public Property MI_Remarks() As String
            Get
                Return _MI_Remarks
            End Get
            Set(ByVal value As String)
                _MI_Remarks = value
            End Set
        End Property
        Public Property MI_ForecastID() As String
            Get
                Return _MI_ForecastID
            End Get
            Set(ByVal value As String)
                _MI_ForecastID = value
            End Set
        End Property
        Public Property MI_CalcType() As Int16
            Get
                Return _MI_CalcType
            End Get
            Set(ByVal value As Int16)
                _MI_CalcType = value
            End Set
        End Property
        Public Property MI_WareID() As String
            Get
                Return _MI_WareID
            End Get
            Set(ByVal value As String)
                _MI_WareID = value
            End Set
        End Property

    End Class
End Namespace