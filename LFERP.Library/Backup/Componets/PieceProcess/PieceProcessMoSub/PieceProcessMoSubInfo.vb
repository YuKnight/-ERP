Namespace LFERP.Library.PieceProcessMoSub
    Public Class PieceProcessMoSubInfo

        Private _PM_NO As String
        Private _Pro_M_NO As String
        Private _PM_Num As String
        Private _Pro_NO As String
        Private _Pro_Type As String
        Private _Type3ID As String
        Private _PS_NO As String
        Private _PS_Num As String
        Private _PM_DepNO As String
        Private _PM_DepName As String
        Private _PM_Name As String
        Private _PM_Price As String
        Private _PM_CheckPrice As Boolean
        Private _PM_Remark As String
        Private _PM_Factor As String
        Private _PM_CheckFactor As Boolean
        Private _PM_Type As String
        Private _PM_DayNight As String
        Private _PM_Enable As Boolean
        Private _PM_AddDate As Date
        Private _PM_M_Code As String
        Private _PM_Action As String
        Private _PM_CheckAction As String
        Private _PM_Explain As String

        Private _PM_Check As Boolean
        Private _PM_CheckType As String
        Private _PM_CheckRemark As String
        Private _PM_CheckDate As Date

        Private _ActionName As String
        Private _CheckActionName As String

        Private _M_Code As String
        Private _M_Gauge As String
        Private _M_Name As String


        Sub New()

            _PM_NO = Nothing
            _Pro_M_NO = Nothing
            _PM_Num = Nothing
            _Pro_NO = Nothing
            _Pro_Type = Nothing
            _PS_NO = Nothing
            _PS_Num = Nothing
            _PM_DepNO = Nothing
            _PM_DepName = Nothing
            _PM_Name = Nothing
            _PM_CheckPrice = False

            _PM_Remark = Nothing
            _PM_Factor = Nothing
            _PM_CheckFactor = False
            _PM_Type = Nothing
            _PM_DayNight = Nothing
            _PM_Enable = False
            _PM_AddDate = Nothing
            _PM_M_Code = Nothing
            _PM_Action = Nothing
            _PM_CheckAction = Nothing
            _PM_Explain = Nothing
            _ActionName = Nothing
            _CheckActionName = Nothing

            _PM_Check = False
            _PM_CheckType = Nothing
            _PM_CheckRemark = Nothing
            _PM_CheckDate = Nothing

            _M_Code = Nothing
            _M_Gauge = Nothing
            _M_Name = Nothing
            _Type3ID = Nothing
        End Sub
      
        Public Property PM_NO() As String
            Get
                Return _PM_NO
            End Get
            Set(ByVal value As String)
                _PM_NO = value
            End Set
        End Property
        Public Property Pro_M_NO() As String
            Get
                Return _Pro_M_NO
            End Get
            Set(ByVal value As String)
                _Pro_M_NO = value
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
        Public Property Type3ID() As String
            Get
                Return _Type3ID
            End Get
            Set(ByVal value As String)
                _Type3ID = value
            End Set
        End Property
        Public Property PM_Num() As String
            Get
                Return _PM_Num
            End Get
            Set(ByVal value As String)
                _PM_Num = value
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
        Public Property PS_NO() As String
            Get
                Return _PS_NO
            End Get
            Set(ByVal value As String)
                _PS_NO = value
            End Set
        End Property
        Public Property PS_Num() As String
            Get
                Return _PS_Num
            End Get
            Set(ByVal value As String)
                _PS_Num = value
            End Set
        End Property
        Public Property PM_DepNO() As String
            Get
                Return _PM_DepNO
            End Get
            Set(ByVal value As String)
                _PM_DepNO = value
            End Set
        End Property
        Public Property PM_DepName() As String
            Get
                Return _PM_DepName
            End Get
            Set(ByVal value As String)
                _PM_DepName = value
            End Set
        End Property
        Public Property PM_Name() As String
            Get
                Return _PM_Name
            End Get
            Set(ByVal value As String)
                _PM_Name = value
            End Set
        End Property
        Public Property PM_Price() As String
            Get
                Return _PM_Price
            End Get
            Set(ByVal value As String)
                _PM_Price = value
            End Set
        End Property
        Public Property PM_CheckPrice() As Boolean
            Get
                Return _PM_CheckPrice
            End Get
            Set(ByVal value As Boolean)
                _PM_CheckPrice = value
            End Set
        End Property
        Public Property PM_Remark() As String
            Get
                Return _PM_Remark
            End Get
            Set(ByVal value As String)
                _PM_Remark = value
            End Set
        End Property
        Public Property PM_Factor() As String
            Get
                Return _PM_Factor
            End Get
            Set(ByVal value As String)
                _PM_Factor = value
            End Set
        End Property
        Public Property PM_CheckFactor() As Boolean
            Get
                Return _PM_CheckFactor
            End Get
            Set(ByVal value As Boolean)
                _PM_CheckFactor = value
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
        Public Property PM_DayNight() As String
            Get
                Return _PM_DayNight
            End Get
            Set(ByVal value As String)
                _PM_DayNight = value
            End Set
        End Property
        Public Property PM_Enable() As Boolean
            Get
                Return _PM_Enable
            End Get
            Set(ByVal value As Boolean)
                _PM_Enable = value
            End Set
        End Property
        Public Property PM_Check() As Boolean
            Get
                Return _PM_Check
            End Get
            Set(ByVal value As Boolean)
                _PM_Check = value
            End Set
        End Property
        Public Property PM_AddDate() As Date
            Get
                Return _PM_AddDate
            End Get
            Set(ByVal value As Date)
                _PM_AddDate = value
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
        Public Property PM_Action() As String
            Get
                Return _PM_Action
            End Get
            Set(ByVal value As String)
                _PM_Action = value
            End Set
        End Property
        Public Property PM_CheckAction() As String
            Get
                Return _PM_CheckAction
            End Get
            Set(ByVal value As String)
                _PM_CheckAction = value
            End Set
        End Property
        Public Property PM_Explain() As String
            Get
                Return _PM_Explain
            End Get
            Set(ByVal value As String)
                _PM_Explain = value
            End Set
        End Property
        Public Property ActionName() As String
            Get
                Return _ActionName
            End Get
            Set(ByVal value As String)
                _ActionName = value
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

        '--------------------------------
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property
        Public Property M_Name() As String
            Get
                Return _M_Name
            End Get
            Set(ByVal value As String)
                _M_Name = value
            End Set
        End Property
        Public Property M_Gauge() As String
            Get
                Return _M_Gauge
            End Get
            Set(ByVal value As String)
                _M_Gauge = value
            End Set
        End Property

        Public Property PM_CheckDate() As Date
            Get
                Return _PM_CheckDate
            End Get
            Set(ByVal value As Date)
                _PM_CheckDate = value
            End Set
        End Property
        Public Property PM_CheckRemark() As String
            Get
                Return _PM_CheckRemark
            End Get
            Set(ByVal value As String)
                _PM_CheckRemark = value
            End Set
        End Property
        Public Property PM_CheckType() As String
            Get
                Return _PM_CheckType
            End Get
            Set(ByVal value As String)
                _PM_CheckType = value
            End Set
        End Property

    End Class

End Namespace

