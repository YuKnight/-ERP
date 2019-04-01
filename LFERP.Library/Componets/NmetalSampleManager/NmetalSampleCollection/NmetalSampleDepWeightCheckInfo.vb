Namespace LFERP.Library.NmetalSampleManager.NmetalSampleCollection
    ''' <summary>
    ''' Mark
    ''' 2014-07-01
    ''' 部門重量信息表
    ''' </summary>
    ''' <remarks></remarks>
    Public Class NmetalSampleDepWeightCheckInfo
        Private _AutoID As String
        Private _ChangeNO As String
        Private _PM_M_Code As String
        Private _PM_Type As String
        Private _D_ID As String

        Private _DepWightOld As Decimal
        Private _DepWightNew As Decimal
        Private _AddAction As String
        Private _AddDate As Date
        Private _Remark As String

        Private _CheckStatus As Boolean
        Private _CheckAction As String
        Private _CheckDate As Date
        Private _CheckRemark As String
        Private _M_CodePID As String

        Private _ModifyUserID As String
        Private _ModifyDate As Date
        Private _DepName As String
        Private _Add_Name As String
        Private _Check_Name As String


        Private _Modify_Name As String
        Private _PS_NO As String
        Private _PS_Name As String
        Private _SubRemark As String

        Private _ProductWightOld As Decimal

        Public Sub New()
            _AutoID = Nothing
            _ChangeNO = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _D_ID = Nothing

            _DepWightOld = 0
            _DepWightNew = 0
            _AddAction = Nothing
            _AddDate = Nothing
            _Remark = Nothing

            _CheckStatus = Nothing
            _CheckAction = Nothing
            _CheckDate = Nothing
            _CheckRemark = Nothing
            _M_CodePID = Nothing

            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _DepName = Nothing
            _Add_Name = Nothing
            _Check_Name = Nothing

            _Modify_Name = Nothing
            _PS_NO = Nothing
            _PS_Name = Nothing
            _SubRemark = Nothing

            _ProductWightOld = Nothing
        End Sub

        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property
        Public Property ChangeNO() As String
            Get
                Return _ChangeNO
            End Get
            Set(ByVal value As String)
                _ChangeNO = value
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
        Public Property PM_Type() As String
            Get
                Return _PM_Type
            End Get
            Set(ByVal value As String)
                _PM_Type = value
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
        Public Property DepWightOld() As Decimal
            Get
                Return _DepWightOld
            End Get
            Set(ByVal value As Decimal)
                _DepWightOld = value
            End Set
        End Property
        Public Property DepWightNew() As Decimal
            Get
                Return _DepWightNew
            End Get
            Set(ByVal value As Decimal)
                _DepWightNew = value
            End Set
        End Property
        Public Property AddAction() As String
            Get
                Return _AddAction
            End Get
            Set(ByVal value As String)
                _AddAction = value
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
        Public Property Remark() As String
            Get
                Return _Remark
            End Get
            Set(ByVal value As String)
                _Remark = value
            End Set
        End Property
        Public Property CheckStatus() As Boolean
            Get
                Return _CheckStatus
            End Get
            Set(ByVal value As Boolean)
                _CheckStatus = value
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
        Public Property DepName() As String
            Get
                Return _DepName
            End Get
            Set(ByVal value As String)
                _DepName = value
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
        Public Property Add_Name() As String
            Get
                Return _Add_Name
            End Get
            Set(ByVal value As String)
                _Add_Name = value
            End Set
        End Property
        Public Property Check_Name() As String
            Get
                Return _Check_Name
            End Get
            Set(ByVal value As String)
                _Check_Name = value
            End Set
        End Property
        Public Property Modify_Name() As String
            Get
                Return _Modify_Name
            End Get
            Set(ByVal value As String)
                _Modify_Name = value
            End Set
        End Property
        Public Property PS_NO() As String
            Get
                Return _PS_NO
            End Get
            Set(ByVal value As String)
                _PS_NO = value
            End Set
        End Property
        Public Property PS_Name() As String
            Get
                Return _PS_Name
            End Get
            Set(ByVal value As String)
                _PS_Name = value
            End Set
        End Property
        Public Property SubRemark() As String
            Get
                Return _SubRemark
            End Get
            Set(ByVal value As String)
                _SubRemark = value
            End Set
        End Property


        Public Property ProductWightOld() As Decimal
            Get
                Return _ProductWightOld
            End Get
            Set(ByVal value As Decimal)
                _ProductWightOld = value
            End Set
        End Property
    End Class
End Namespace