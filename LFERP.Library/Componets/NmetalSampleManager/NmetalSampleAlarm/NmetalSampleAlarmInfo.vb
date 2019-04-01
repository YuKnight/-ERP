Namespace LFERP.Library.NmetalSampleManager.NmetalSampleAlarm
    Public Class NmetalSampleAlarmInfo
        Private _SE_ID As String
        Private _SE_OutD_ID As String
        Private _SE_InD_ID As String
        Private _SE_Qty As Integer
        Private _SE_AddUserID As String
        Private _SE_OutD_Dep As String
        Private _SE_InD_Dep As String
        Private _SE_AddUserName As String
        Private _SE_AddDate As Date
        Private _SE_OutCardID As String
        Private _SE_InCardID As String
        Private _ProcessResult As String
        Private _AddUserID As String
        Private _AddDate As Date
        Private _CheckBit As Boolean
        Private _CheckAction As String
        Private _CheckDate As Date
        Private _CheckRemark As String
        Private _AddUserName As String
        Private _CheckActionName As String
        Private _ModifyUserID As String
        Private _ModifyDate As Date
        Private _PM_M_Code As String
        Private _SO_SampleID As String
        Private _D_ID As String
        Private _OccurReason As String
        Private _D_Dep As String
        Private _OccurAddress As String
        Private _Remark As String
        Private _PutInQty As Integer
        Private _PutInCount As Integer
        Private _RatioQty As Decimal
        Private _RatioCount As Decimal
        Private _EmailTilte As String
        Private _SE_DelUserID As String
        Private _SE_InTime As Date
        Private _DutyUserID As String
        Private _SE_TypeName As String



        Public Sub New()
            _SE_TypeName = Nothing
            _SE_DelUserID = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _SE_ID = Nothing
            _SE_OutD_ID = Nothing
            _SE_InD_ID = Nothing
            _SE_AddUserID = Nothing

            _SE_OutD_Dep = Nothing
            _SE_InD_Dep = Nothing
            _SE_Qty = Nothing

            _SE_AddUserName = Nothing
            _SE_AddDate = Nothing
            _AddDate = Nothing
            _SE_OutCardID = Nothing
            _SE_InCardID = Nothing
            _ProcessResult = Nothing

            _AddUserID = Nothing
            _CheckBit = Nothing
            _CheckAction = Nothing
            _CheckDate = Nothing
            _CheckRemark = Nothing
            _AddUserName = Nothing
            _CheckActionName = Nothing
            _PM_M_Code = Nothing
            _SO_SampleID = Nothing
            _D_ID = Nothing
            _OccurReason = Nothing
            _D_Dep = Nothing
            _OccurAddress = Nothing
            _Remark = Nothing

            _PutInQty = Nothing
            _PutInCount = Nothing
            _RatioQty = Nothing
            _RatioCount = Nothing
            _EmailTilte = Nothing
            _SE_InTime = Nothing
            _DutyUserID = Nothing
        End Sub
        Public Property SE_TypeName() As String
            Get
                Return _SE_TypeName
            End Get
            Set(ByVal value As String)
                _SE_TypeName = value
            End Set
        End Property
        Public Property DutyUserID() As String
            Get
                Return _DutyUserID
            End Get
            Set(ByVal value As String)
                _DutyUserID = value
            End Set
        End Property

        Public Property SE_InTime() As Date
            Get
                Return _SE_InTime
            End Get
            Set(ByVal value As Date)
                _SE_InTime = value
            End Set
        End Property
        Public Property SE_DelUserID() As String
            Get
                Return _SE_DelUserID
            End Get
            Set(ByVal value As String)
                _SE_DelUserID = value
            End Set
        End Property
        Public Property EmailTilte() As String
            Get
                Return _EmailTilte
            End Get
            Set(ByVal value As String)
                _EmailTilte = value
            End Set
        End Property
        Public Property RatioQty() As Decimal
            Get
                Return _RatioQty
            End Get
            Set(ByVal value As Decimal)
                _RatioQty = value
            End Set
        End Property
        Public Property RatioCount() As Decimal
            Get
                Return _RatioCount
            End Get
            Set(ByVal value As Decimal)
                _RatioCount = value
            End Set
        End Property

        Public Property PutInQty() As Integer
            Get
                Return _PutInQty
            End Get
            Set(ByVal value As Integer)
                _PutInQty = value
            End Set
        End Property
        Public Property PutInCount() As Integer
            Get
                Return _PutInCount
            End Get
            Set(ByVal value As Integer)
                _PutInCount = value
            End Set
        End Property

        Public Property OccurAddress() As String
            Get
                Return _OccurAddress
            End Get
            Set(ByVal value As String)
                _OccurAddress = value
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
        Public Property D_Dep() As String
            Get
                Return _D_Dep
            End Get
            Set(ByVal value As String)
                _D_Dep = value
            End Set
        End Property
        Public Property OccurReason() As String
            Get
                Return _OccurReason
            End Get
            Set(ByVal value As String)
                _OccurReason = value
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
        Public Property ModifyDate() As String
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As String)
                _ModifyDate = value
            End Set
        End Property
        Public Property SE_Qty() As String
            Get
                Return _SE_Qty
            End Get
            Set(ByVal value As String)
                _SE_Qty = value
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
        Public Property SE_OutD_ID() As String
            Get
                Return _SE_OutD_ID
            End Get
            Set(ByVal value As String)
                _SE_OutD_ID = value
            End Set
        End Property
        Public Property SE_InD_ID() As String
            Get
                Return _SE_InD_ID
            End Get
            Set(ByVal value As String)
                _SE_InD_ID = value
            End Set
        End Property
        Public Property SE_AddUserID() As String
            Get
                Return _SE_AddUserID
            End Get
            Set(ByVal value As String)
                _SE_AddUserID = value
            End Set
        End Property
        Public Property SE_OutD_Dep() As String
            Get
                Return _SE_OutD_Dep
            End Get
            Set(ByVal value As String)
                _SE_OutD_Dep = value
            End Set
        End Property
        Public Property SE_InD_Dep() As String
            Get
                Return _SE_InD_Dep
            End Get
            Set(ByVal value As String)
                _SE_InD_Dep = value
            End Set
        End Property


        Public Property SE_AddUserName() As String
            Get
                Return _SE_AddUserName
            End Get
            Set(ByVal value As String)
                _SE_AddUserName = value
            End Set
        End Property

        Public Property SE_AddDate() As Date
            Get
                Return _SE_AddDate
            End Get
            Set(ByVal value As Date)
                _SE_AddDate = value
            End Set
        End Property

        Public Property SE_OutCardID() As String
            Get
                Return _SE_OutCardID
            End Get
            Set(ByVal value As String)
                _SE_OutCardID = value
            End Set
        End Property
        Public Property SE_InCardID() As String
            Get
                Return _SE_InCardID
            End Get
            Set(ByVal value As String)
                _SE_InCardID = value
            End Set
        End Property


        Public Property ProcessResult() As String
            Get
                Return _ProcessResult
            End Get
            Set(ByVal value As String)
                _ProcessResult = value
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

        Public Property CheckBit() As Boolean
            Get
                Return _CheckBit
            End Get
            Set(ByVal value As Boolean)
                _CheckBit = value
            End Set
        End Property

        Public Property CheckAction() As String
            Get
                Return _CheckAction
            End Get
            Set(ByVal value As String)
                _CheckAction = value
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
        Public Property AddUserName() As String
            Get
                Return _AddUserName
            End Get
            Set(ByVal value As String)
                _AddUserName = value
            End Set
        End Property
        Public Property CheckActionName() As String
            Get
                Return _CheckActionName
            End Get
            Set(ByVal value As String)
                _CheckActionName = value
            End Set
        End Property


    End Class
End Namespace