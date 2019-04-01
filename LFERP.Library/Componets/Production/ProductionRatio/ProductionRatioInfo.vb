
Namespace LFERP.Library.Production.ProductionRatio


    Public Class ProductionRatioInfo
        Private _AutoID As String

        Private _PR_NO As String
        Private _Pro_NO As String
        Private _Pro_NO1 As String
        Private _PR_Ratio As Single

        '收料信息
        Private _Pro_Type As String
        Private _PM_M_Code As String
        Private _PM_Type As String
        Private _PS_Name As String
        '發料信息
        Private _Pro_Type1 As String
        Private _PM_M_Code1 As String
        Private _PM_Type1 As String
        Private _PS_Name1 As String

        Private _PR_Remark As String

        Private _PR_AddUserID As String
        Private _PR_AddDate As Date
        Private _PR_ModifyUserID As String
        Private _PR_ModifyDate As Date

        Private _PR_Check As Boolean
        Private _PR_CheckUserID As String
        Private _PR_CheckUserName As String
        Private _PR_CheckDate As Date
        Private _PM_JiYu As String


        Sub New()

            _PM_JiYu = Nothing
            _AutoID = Nothing

            _PR_NO = Nothing
            _Pro_NO = Nothing
            _Pro_NO1 = Nothing
            _PR_Ratio = 0

            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _PS_Name = Nothing
            _Pro_Type1 = Nothing
            _PM_M_Code1 = Nothing
            _PM_Type1 = Nothing
            _PS_Name1 = Nothing
            _PR_Remark = Nothing

            _PR_AddUserID = Nothing
            _PR_AddDate = Nothing
            _PR_ModifyUserID = Nothing
            _PR_ModifyDate = Nothing

            _PR_Check = False
            _PR_CheckUserID = Nothing
            _PR_CheckUserName = Nothing
            _PR_CheckDate = Nothing

        End Sub

        Public Property PM_JiYu() As String
            Get
                Return _PM_JiYu
            End Get
            Set(ByVal value As String)
                _PM_JiYu = value
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
        Public Property PR_NO() As String
            Get
                Return _PR_NO
            End Get
            Set(ByVal value As String)
                _PR_NO = value
            End Set
        End Property
        Public Property Pro_NO() As String
            Get
                Return _Pro_NO
            End Get
            Set(ByVal value As String)
                _Pro_NO = value
            End Set
        End Property
        Public Property Pro_NO1() As String
            Get
                Return _Pro_NO1
            End Get
            Set(ByVal value As String)
                _Pro_NO1 = value
            End Set
        End Property

        Public Property PR_Ratio() As Single
            Get
                Return _PR_Ratio
            End Get
            Set(ByVal value As Single)
                _PR_Ratio = value
            End Set
        End Property

        Public Property Pro_Type() As String
            Get
                Return _Pro_Type
            End Get
            Set(ByVal value As String)
                _Pro_Type = value
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
        Public Property Pro_Type1() As String
            Get
                Return _Pro_Type1
            End Get
            Set(ByVal value As String)
                _Pro_Type1 = value
            End Set
        End Property
        Public Property PM_M_Code1() As String
            Get
                Return _PM_M_Code1
            End Get
            Set(ByVal value As String)
                _PM_M_Code1 = value
            End Set
        End Property
        Public Property PM_Type1() As String
            Get
                Return _PM_Type1
            End Get
            Set(ByVal value As String)
                _PM_Type1 = value
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
        Public Property PS_Name1() As String
            Get
                Return _PS_Name1
            End Get
            Set(ByVal value As String)
                _PS_Name1 = value
            End Set
        End Property
        Public Property PR_Remark() As String
            Get
                Return _PR_Remark
            End Get
            Set(ByVal value As String)
                _PR_Remark = value
            End Set
        End Property
        Public Property PR_AddUserID() As String
            Get
                Return _PR_AddUserID
            End Get
            Set(ByVal value As String)
                _PR_AddUserID = value
            End Set
        End Property
        Public Property PR_AddDate() As Date
            Get
                Return _PR_AddDate
            End Get
            Set(ByVal value As Date)
                _PR_AddDate = value
            End Set
        End Property
        Public Property PR_ModifyUserID() As String
            Get
                Return _PR_ModifyUserID
            End Get
            Set(ByVal value As String)
                _PR_ModifyUserID = value
            End Set
        End Property
        Public Property PR_ModifyDate() As Date
            Get
                Return _PR_ModifyDate
            End Get
            Set(ByVal value As Date)
                _PR_ModifyDate = value
            End Set
        End Property
        Public Property PR_Check() As Boolean
            Get
                Return _PR_Check
            End Get
            Set(ByVal value As Boolean)
                _PR_Check = value
            End Set
        End Property
        Public Property PR_CheckUserID() As String
            Get
                Return _PR_CheckUserID
            End Get
            Set(ByVal value As String)
                _PR_CheckUserID = value
            End Set
        End Property
        Public Property PR_CheckUserName() As String
            Get
                Return _PR_CheckUserName
            End Get
            Set(ByVal value As String)
                _PR_CheckUserName = value
            End Set
        End Property
        Public Property PR_CheckDate() As Date
            Get
                Return _PR_CheckDate
            End Get
            Set(ByVal value As Date)
                _PR_CheckDate = value
            End Set
        End Property
    End Class

End Namespace

