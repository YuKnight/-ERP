
Namespace LFERP.Library.ProductionSchedule

    Public Class ProductionScheduleInfo
        '-----------------------------------------主從表均用字段
        Private _PS_NO As String
        Private _PS_Num As String
        '------------------------------------------
        Private _Pro_Type As String   '工藝類型
        Private _PM_M_Code As String
        Private _M_Code As String
        Private _PM_Type As String
        Private _PS_Date As Date
        Private _PS_DayNumber As Integer
        Private _PS_ActualNumber As Integer
        Private _PS_Remark As String
        Private _PS_KaiLiao As Boolean
        Private _PS_Detail As String
        Private _PS_Action As String
        Private _PS_Dep As String
        Private _PS_AddDate As Date
        Private _PS_Check As Boolean
        Private _PS_CheckDate As Date
        Private _PS_CheckAction As String
        Private _PS_CheckRemark As String

        Private _M_Name As String
        Private _M_Gauge As String
        Private _ActionName As String
        Private _CheckActionName As String
        Private _FacID As String
        Private _FacName As String
        Private _DepName As String

        '-----------------------------------------------以下為部門級生產計劃
        Private _AutoID As Integer
        Private _PS_S_NO As String
        Private _PS_S_Dep As String
        Private _PS_S_DayNumber As Integer
        Private _PS_S_ActualNumber As Integer
        Private _PS_S_Date As Date
        Private _PS_S_Remark As String
        Private _PS_S_Check As Boolean
        Private _PS_S_CheckAction As String
        Private _PS_S_CheckRemark As String


        Private _PM_JiYu As String

        '2014-03-05  姚駿
        Private _SumNoSendQty As Double
        Private _SumDayQty As Double
        Private _SumPIQty As Double
        Private _C_Qty As Double

		
        Sub New()
            _PM_JiYu = Nothing
            '------------------------------------------------------
            _PS_NO = Nothing
            _PS_Num = Nothing
            '------------------------------------------------------
            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _M_Code = Nothing
            _PM_Type = Nothing
            _PS_Date = Nothing
            _PS_DayNumber = 0
            _PS_ActualNumber = 0
            _PS_Remark = Nothing
            _PS_KaiLiao = False
            _PS_Detail = Nothing
            _PS_Action = Nothing
            _PS_Dep = Nothing
            _PS_AddDate = Nothing
            _PS_Check = False
            _PS_CheckDate = Nothing
            _PS_CheckAction = Nothing
            _PS_CheckRemark = Nothing

            '------------------------------------------------------
            _M_Name = Nothing
            _M_Gauge = Nothing          '延伸可用字段
            _ActionName = Nothing
            _CheckActionName = Nothing
            _FacID = Nothing
            _FacName = Nothing
            _DepName = Nothing
            '------------------------------------------------------
            _AutoID = 0
            _PS_S_NO = Nothing
            _PS_S_Dep = Nothing
            _PS_S_DayNumber = 0
            _PS_S_ActualNumber = 0
            _PS_S_Date = Nothing
            _PS_S_Remark = Nothing
            _PS_S_Check = False
            _PS_S_CheckAction = Nothing
            _PS_S_CheckRemark = Nothing

            '------------------------------------------------------


            '2014-03-05  姚駿
            _SumNoSendQty = 0
            _SumDayQty = 0
            _SumPIQty = 0
            _C_Qty = 0

        End Sub

        '2014-03-05  姚駿



        Public Property C_Qty() As Double
            Get
                Return _C_Qty
            End Get
            Set(ByVal value As Double)
                _C_Qty = value
            End Set
        End Property
        Public Property SumNoSendQty() As Double
            Get
                Return _SumNoSendQty
            End Get
            Set(ByVal value As Double)
                _SumNoSendQty = value
            End Set
        End Property
        Public Property SumDayQty() As Double
            Get
                Return _SumDayQty
            End Get
            Set(ByVal value As Double)
                _SumDayQty = value
            End Set
        End Property
        Public Property SumPIQty() As Double
            Get
                Return _SumPIQty
            End Get
            Set(ByVal value As Double)
                _SumPIQty = value
            End Set
        End Property


        '
        ''' <summary>
        ''' 機玉
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_JiYu() As String
            Get
                Return _PM_JiYu
            End Get
            Set(ByVal value As String)
                _PM_JiYu = value
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
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
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
        Public Property PS_Date() As Date
            Get
                Return _PS_Date
            End Get
            Set(ByVal value As Date)
                _PS_Date = value
            End Set
        End Property
        Public Property PS_DayNumber() As Integer
            Get
                Return _PS_DayNumber
            End Get
            Set(ByVal value As Integer)
                _PS_DayNumber = value
            End Set
        End Property
        Public Property PS_ActualNumber() As Integer
            Get
                Return _PS_ActualNumber
            End Get
            Set(ByVal value As Integer)
                _PS_ActualNumber = value
            End Set
        End Property
        Public Property PS_Remark() As String
            Get
                Return _PS_Remark
            End Get
            Set(ByVal value As String)
                _PS_Remark = value
            End Set
        End Property
        Public Property PS_KaiLiao() As Boolean
            Get
                Return _PS_KaiLiao
            End Get
            Set(ByVal value As Boolean)
                _PS_KaiLiao = value
            End Set
        End Property
        Public Property PS_Detail() As String
            Get
                Return _PS_Detail
            End Get
            Set(ByVal value As String)
                _PS_Detail = value
            End Set
        End Property
        Public Property PS_Action() As String
            Get
                Return _PS_Action
            End Get
            Set(ByVal value As String)
                _PS_Action = value
            End Set
        End Property
        Public Property PS_Dep() As String
            Get
                Return _PS_Dep
            End Get
            Set(ByVal value As String)
                _PS_Dep = value
            End Set
        End Property
        Public Property PS_AddDate() As Date
            Get
                Return _PS_AddDate
            End Get
            Set(ByVal value As Date)
                _PS_AddDate = value
            End Set
        End Property
        Public Property PS_Check() As Boolean
            Get
                Return _PS_Check
            End Get
            Set(ByVal value As Boolean)
                _PS_Check = value
            End Set
        End Property
        Public Property PS_CheckDate() As Date
            Get
                Return _PS_CheckDate
            End Get
            Set(ByVal value As Date)
                _PS_CheckDate = value
            End Set
        End Property
        Public Property PS_CheckAction() As String
            Get
                Return _PS_CheckAction
            End Get
            Set(ByVal value As String)
                _PS_CheckAction = value
            End Set
        End Property
        Public Property PS_CheckRemark() As String
            Get
                Return _PS_CheckRemark
            End Get
            Set(ByVal value As String)
                _PS_CheckRemark = value
            End Set
        End Property

        '------------------------------------------------------
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
        Public Property FacID() As String
            Get
                Return _FacID
            End Get
            Set(ByVal value As String)
                _FacID = value
            End Set
        End Property
        Public Property FacName() As String
            Get
                Return _FacName
            End Get
            Set(ByVal value As String)
                _FacName = value
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
        '------------------------------------------------------
        Public Property AutoID() As Integer
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Integer)
                _AutoID = value
            End Set
        End Property
        Public Property PS_S_NO() As String
            Get
                Return _PS_S_NO
            End Get
            Set(ByVal value As String)
                _PS_S_NO = value
            End Set
        End Property
        Public Property PS_S_Dep() As String
            Get
                Return _PS_S_Dep
            End Get
            Set(ByVal value As String)
                _PS_S_Dep = value
            End Set
        End Property
        Public Property PS_S_DayNumber() As Integer
            Get
                Return _PS_S_DayNumber
            End Get
            Set(ByVal value As Integer)
                _PS_S_DayNumber = value
            End Set
        End Property
        Public Property PS_S_ActualNumber() As Integer
            Get
                Return _PS_S_ActualNumber
            End Get
            Set(ByVal value As Integer)
                _PS_S_ActualNumber = value
            End Set
        End Property
        Public Property PS_S_Date() As Date
            Get
                Return _PS_S_Date
            End Get
            Set(ByVal value As Date)
                _PS_S_Date = value
            End Set
        End Property
        Public Property PS_S_Remark() As String
            Get
                Return _PS_S_Remark
            End Get
            Set(ByVal value As String)
                _PS_S_Remark = value
            End Set
        End Property
        Public Property PS_S_Check() As Boolean
            Get
                Return _PS_S_Check
            End Get
            Set(ByVal value As Boolean)
                _PS_S_Check = value
            End Set
        End Property
        Public Property PS_S_CheckAction() As String
            Get
                Return _PS_S_CheckAction
            End Get
            Set(ByVal value As String)
                _PS_S_CheckAction = value
            End Set
        End Property
        Public Property PS_S_CheckRemark() As String
            Get
                Return _PS_S_CheckRemark
            End Get
            Set(ByVal value As String)
                _PS_S_CheckRemark = value
            End Set
        End Property
        '------------------------------------------------------
    End Class

End Namespace

