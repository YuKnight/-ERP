Namespace LFERP.Library.ProductionPiecePayWGSub

    Public Class ProductionPiecePayWGSubInfo
        Private _AutoID As String     '自動編號ID
        Private _PY_ID As String     '單號
        Private _Per_NO As String     '廠證編號
        Private _Per_Name As String     '姓名
        Private _PYS_FormulaID As String     '計算公式編號
        Private _Per_DayPrice As Double '薪金類型
        Private _PYS_OnDutyDays As Double     '上班天數
        Private _PYS_UsualOverTime As Double     '平時加班小時數
        Private _PYS_HolidayOVerTime As Double     '節假日加班小時數
        Private _PYS_Proportion As Double     '工時比例
        Private _PYS_Bonus As Double     '獎金
        Private _PYS_AllHours As Double     '總工時
        Private _PYS_MeritedHours As Double     '應計工時
        Private _PYS_TimePay As Double     '計時工資
        Private _PYS_PiecePay As Double     '計件工資
        Private _PYS_MeritedPay As Double     '應得工資
        Private _PYS_Remark As String     '備注

        Private _PYS_WorkWGDay As Double '在指定組工作的天數
        Private _Per_PayType As String   '薪金類型

        Sub New()
            _Per_PayType = Nothing
            _PYS_WorkWGDay = 0
            _AutoID = Nothing
            _PY_ID = Nothing
            _Per_NO = Nothing
            _Per_Name = Nothing
            _PYS_FormulaID = Nothing
            _Per_DayPrice = 0
            _PYS_OnDutyDays = 0
            _PYS_UsualOverTime = 0
            _PYS_HolidayOVerTime = 0
            _PYS_Proportion = 0
            _PYS_Bonus = 0
            _PYS_AllHours = 0
            _PYS_MeritedHours = 0
            _PYS_TimePay = 0
            _PYS_PiecePay = 0
            _PYS_MeritedPay = 0
            _PYS_Remark = Nothing
        End Sub
        ''' <summary>
        ''' 薪金類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_PayType() As String
            Get
                Return _Per_PayType
            End Get
            Set(ByVal value As String)
                _Per_PayType = value
            End Set
        End Property
        ''' <summary>
        ''' 在指定組工作的天數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PYS_WorkWGDay() As String
            Get
                Return _PYS_WorkWGDay
            End Get
            Set(ByVal value As String)
                _PYS_WorkWGDay = value
            End Set
        End Property
        ''' <summary>
        ''' 自動編號ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property


        ''' <summary>
        ''' 單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_ID() As String
            Get
                Return _PY_ID
            End Get
            Set(ByVal value As String)
                _PY_ID = value
            End Set
        End Property


        ''' <summary>
        ''' 廠證編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_NO() As String
            Get
                Return _Per_NO
            End Get
            Set(ByVal value As String)
                _Per_NO = value
            End Set
        End Property


        ''' <summary>
        ''' 姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_Name() As String
            Get
                Return _Per_Name
            End Get
            Set(ByVal value As String)
                _Per_Name = value
            End Set
        End Property


        ''' <summary>
        ''' 計算公式編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PYS_FormulaID() As String
            Get
                Return _PYS_FormulaID
            End Get
            Set(ByVal value As String)
                _PYS_FormulaID = value
            End Set
        End Property


        ''' <summary>
        ''' 日薪薪
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_DayPrice() As String
            Get
                Return _Per_DayPrice
            End Get
            Set(ByVal value As String)
                _Per_DayPrice = value
            End Set
        End Property


        ''' <summary>
        ''' 上班天數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PYS_OnDutyDays() As Double
            Get
                Return _PYS_OnDutyDays
            End Get
            Set(ByVal value As Double)
                _PYS_OnDutyDays = value
            End Set
        End Property


        ''' <summary>
        ''' 平時加班小時數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PYS_UsualOverTime() As Double
            Get
                Return _PYS_UsualOverTime
            End Get
            Set(ByVal value As Double)
                _PYS_UsualOverTime = value
            End Set
        End Property


        ''' <summary>
        ''' 節假日加班小時數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PYS_HolidayOVerTime() As Double
            Get
                Return _PYS_HolidayOVerTime
            End Get
            Set(ByVal value As Double)
                _PYS_HolidayOVerTime = value
            End Set
        End Property


        ''' <summary>
        ''' 工時比例
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PYS_Proportion() As Double
            Get
                Return _PYS_Proportion
            End Get
            Set(ByVal value As Double)
                _PYS_Proportion = value
            End Set
        End Property


        ''' <summary>
        ''' 獎金
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PYS_Bonus() As Double
            Get
                Return _PYS_Bonus
            End Get
            Set(ByVal value As Double)
                _PYS_Bonus = value
            End Set
        End Property


        ''' <summary>
        ''' 總工時
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PYS_AllHours() As Double
            Get
                Return _PYS_AllHours
            End Get
            Set(ByVal value As Double)
                _PYS_AllHours = value
            End Set
        End Property


        ''' <summary>
        ''' 應計工時
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PYS_MeritedHours() As Double
            Get
                Return _PYS_MeritedHours
            End Get
            Set(ByVal value As Double)
                _PYS_MeritedHours = value
            End Set
        End Property


        ''' <summary>
        ''' 計時工資
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PYS_TimePay() As Double
            Get
                Return _PYS_TimePay
            End Get
            Set(ByVal value As Double)
                _PYS_TimePay = value
            End Set
        End Property


        ''' <summary>
        ''' 計件工資
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PYS_PiecePay() As Double
            Get
                Return _PYS_PiecePay
            End Get
            Set(ByVal value As Double)
                _PYS_PiecePay = value
            End Set
        End Property


        ''' <summary>
        ''' 應得工資
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PYS_MeritedPay() As Double
            Get
                Return _PYS_MeritedPay
            End Get
            Set(ByVal value As Double)
                _PYS_MeritedPay = value
            End Set
        End Property


        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PYS_Remark() As String
            Get
                Return _PYS_Remark
            End Get
            Set(ByVal value As String)
                _PYS_Remark = value
            End Set
        End Property
    End Class

End Namespace