Namespace LFERP.Library.SampleManager.SampleAlarm
    Public Class SampleAlarmInfo
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

        Public Sub New()
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
        End Sub

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