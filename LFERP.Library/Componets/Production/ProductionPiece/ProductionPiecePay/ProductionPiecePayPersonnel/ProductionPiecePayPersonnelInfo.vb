
Namespace LFERP.Library.ProductionPiecePayPersonnel


    Public Class ProductionPiecePayPersonnelInfo
        Private _AutoID As String                ' * int                 /自動編號ID
        Private _Per_NO As String                 ' * nvarchar(20)        /廠證編號
        Private _Per_Name As String               ' * nvarchar(20)        /姓名
        Private _PL_YYMM As String                '* datetime            /年月
        Private _DepID As String                   '* nvarchar(10)        /部門
        Private _Per_DayPrice As Double           '* real                /日薪  

        Private _PL_OnDutyDays As Double           '* real                  /上班天數
        Private _PL_UsualOverHours As Double       ' * real                  /平時加班小時數
        Private _PL_HolidayOVerHours As Double     ' * real                  /節假日加班小時數
        Private _PL_TimeHours As Double           ' * real                  /計時工時
        Private _PL_CompensateSum As Double        ' * real                  /應補金額

        Private _PL_SubtractSum As Double          '* real                /應扣金額
        Private _PL_TimePay As Double              '* real                /計時工資
        Private _PL_PiecePay As Double             '* real                /計件工資
        Private _PL_MeritedPay As Double          '* real                /應得工資
        Private _PL_Remark As String              ' * nvarchar(MAX)       /備注

        Private _PL_Check As Boolean               '* bit                   /審核
        Private _PL_CheckUserID As String          '   * nvarchar(20)          /審核編號
        Private _PL_CheckDate As String           ' * datetime              /審核日期
        Private _PL_AddUserID As String          '  * nvarchar(20)          /添加人(操作人)編號
        Private _PL_AddDate As String         '* datetime             /添加日期

        Private _PL_ModifyUserID As String      '    * nvarchar(20)         /修改人
        Private _PL_ModifyDate As String         ' * datetime             /修改日期

        Private _PL_AddUserName As String      '     記錄添加人員名
        Private _PL_CheckUserName As String    '   審核人員名
        Private _PL_ModifyUserName As String   '    修改人員名
        Private _PL_DepName As String          '    部門名

        Private _PL_DateEnd As String         ''打印用開始時間
        Private _PL_DateStart As String
        Private _Print_Action As String

        Private _FacID As String
        Private _PL_FacName As String

        Private _PPGtotal_P As Double  '個人計件總額
        Private _PPGtotal_T As Double  '個人計時總額

        Private _WPdate As String
        Private _Per_Class As String

        Private _PT_Total_Sum As Double '個人計時,匯總工時


        Sub New()
            _WPdate = Nothing
            _PPGtotal_P = 0
            _PPGtotal_T = 0

            _AutoID = Nothing                ' * int                 /自動編號ID
            _Per_NO = Nothing                 ' * nvarchar(20)        /廠證編號
            _Per_Name = Nothing               ' * nvarchar(20)        /姓名
            _PL_YYMM = Nothing                '* datetime            /年月
            _DepID = Nothing                   '* nvarchar(10)        /部門
            _Per_DayPrice = Nothing           '* real                /日薪  

            _PL_OnDutyDays = Nothing           '* real                  /上班天數
            _PL_UsualOverHours = Nothing      ' * real                  /平時加班小時數
            _PL_HolidayOVerHours = Nothing    ' * real                  /節假日加班小時數
            _PL_TimeHours = Nothing          ' * real                  /計時工時
            _PL_CompensateSum = Nothing       ' * real                  /應補金額

            _PL_SubtractSum = Nothing         '* real                /應扣金額
            _PL_TimePay = Nothing             '* real                /計時工資
            _PL_PiecePay = Nothing            '* real                /計件工資
            _PL_MeritedPay = Nothing         '* real                /應得工資
            _PL_Remark = Nothing              ' * nvarchar(MAX)       /備注

            _PL_Check = False              '* bit                   /審核
            _PL_CheckUserID = Nothing          '   * nvarchar(20)          /審核編號
            _PL_CheckDate = Nothing           ' * datetime              /審核日期
            _PL_AddUserID = Nothing          '  * nvarchar(20)          /添加人(操作人)編號
            _PL_AddDate = Nothing         '* datetime             /添加日期

            _PL_ModifyUserID = Nothing      '    * nvarchar(20)         /修改人
            _PL_ModifyDate = Nothing         ' * datetime             /修改日期

            _PL_AddUserName = Nothing      '     記錄添加人員名
            _PL_CheckUserName = Nothing    '   審核人員名
            _PL_ModifyUserName = Nothing   '    修改人員名
            _PL_DepName = Nothing          '    部門名

            _PL_DateEnd = Nothing         ''打印用開始時間
            _PL_DateStart = Nothing
            _Print_Action = Nothing

            _FacID = Nothing
            _PL_FacName = Nothing

            _Per_Class = Nothing

            _PT_Total_Sum = 0

        End Sub

        Public Property PT_Total_Sum() As Double
            Get
                Return _PT_Total_Sum
            End Get
            Set(ByVal value As Double)
                _PT_Total_Sum = value
            End Set
        End Property


        Public Property Per_Class() As String
            Get
                Return _Per_Class
            End Get
            Set(ByVal value As String)
                _Per_Class = value
            End Set
        End Property

        Public Property WPdate() As String
            Get
                Return _WPdate
            End Get
            Set(ByVal value As String)
                _WPdate = value
            End Set
        End Property
        ''' <summary>
        ''' 個人計時工時
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PPGtotal_T() As Double
            Get
                Return _PPGtotal_T
            End Get
            Set(ByVal value As Double)
                _PPGtotal_T = value
            End Set
        End Property
        ''' <summary>
        ''' 個人計件總額匯總
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PPGtotal_P() As Double
            Get
                Return _PPGtotal_P
            End Get
            Set(ByVal value As Double)
                _PPGtotal_P = value
            End Set
        End Property

        Public Property PL_FacName() As String
            Get
                Return _PL_FacName
            End Get
            Set(ByVal value As String)
                _PL_FacName = value
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
        ''' <summary>
        ''' 打印人名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Print_Action() As String
            Get
                Return _Print_Action
            End Get
            Set(ByVal value As String)
                _Print_Action = value
            End Set
        End Property
        ''' <summary>
        ''' 打印結束時間
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_DateStart() As String
            Get
                Return _PL_DateStart
            End Get
            Set(ByVal value As String)
                _PL_DateStart = value
            End Set
        End Property
        ''' <summary>
        ''' 打印用開始時間
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_DateEnd() As String
            Get
                Return _PL_DateEnd
            End Get
            Set(ByVal value As String)
                _PL_DateEnd = value
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
        '''  /廠證編號
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
        ''' 年月
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_YYMM() As String
            Get
                Return _PL_YYMM
            End Get
            Set(ByVal value As String)
                _PL_YYMM = value
            End Set
        End Property
        ''' <summary>
        ''' 部門
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DepID() As String
            Get
                Return _DepID
            End Get
            Set(ByVal value As String)
                _DepID = value
            End Set
        End Property
        ''' <summary>
        ''' 日薪
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_DayPrice() As Double
            Get
                Return _Per_DayPrice
            End Get
            Set(ByVal value As Double)
                _Per_DayPrice = value
            End Set
        End Property
        ''' <summary>
        ''' 上班天數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_OnDutyDays() As Double
            Get
                Return _PL_OnDutyDays
            End Get
            Set(ByVal value As Double)
                _PL_OnDutyDays = value
            End Set
        End Property
        ''' <summary>
        ''' 平時加班小時數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_UsualOverHours() As Double
            Get
                Return _PL_UsualOverHours
            End Get
            Set(ByVal value As Double)
                _PL_UsualOverHours = value
            End Set
        End Property

        ''' <summary>
        ''' 節假日加班小時數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_HolidayOVerHours() As Double
            Get
                Return _PL_HolidayOVerHours
            End Get
            Set(ByVal value As Double)
                _PL_HolidayOVerHours = value
            End Set
        End Property
        ''' <summary>
        '''  /計時工時
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_TimeHours() As Double
            Get
                Return _PL_TimeHours
            End Get
            Set(ByVal value As Double)
                _PL_TimeHours = value
            End Set
        End Property

        ''' <summary>
        ''' 應補金額
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_CompensateSum() As Double
            Get
                Return _PL_CompensateSum
            End Get
            Set(ByVal value As Double)
                _PL_CompensateSum = value
            End Set
        End Property

        ''' <summary>
        ''' 應扣金額
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_SubtractSum() As Double
            Get
                Return _PL_SubtractSum
            End Get
            Set(ByVal value As Double)
                _PL_SubtractSum = value
            End Set
        End Property
        ''' <summary>
        ''' 計時工資
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_TimePay() As Double
            Get
                Return _PL_TimePay
            End Get
            Set(ByVal value As Double)
                _PL_TimePay = value
            End Set
        End Property
        ''' <summary>
        ''' 計件工資
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_PiecePay() As Double
            Get
                Return _PL_PiecePay
            End Get
            Set(ByVal value As Double)
                _PL_PiecePay = value
            End Set
        End Property
        ''' <summary>
        ''' 應得工資
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_MeritedPay() As Double
            Get
                Return _PL_MeritedPay
            End Get
            Set(ByVal value As Double)
                _PL_MeritedPay = value
            End Set
        End Property
        ''' <summary>
        ''' /備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_Remark() As String
            Get
                Return _PL_Remark
            End Get
            Set(ByVal value As String)
                _PL_Remark = value
            End Set
        End Property
        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_Check() As Boolean
            Get
                Return _PL_Check
            End Get
            Set(ByVal value As Boolean)
                _PL_Check = value
            End Set
        End Property
        ''' <summary>
        ''' 審核編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_CheckUserID() As String
            Get
                Return _PL_CheckUserID
            End Get
            Set(ByVal value As String)
                _PL_CheckUserID = value
            End Set
        End Property
        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_CheckDate() As String
            Get
                Return _PL_CheckDate
            End Get
            Set(ByVal value As String)
                _PL_CheckDate = value
            End Set
        End Property
        ''' <summary>
        ''' 添加人(操作人)編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_AddUserID() As String
            Get
                Return _PL_AddUserID
            End Get
            Set(ByVal value As String)
                _PL_AddUserID = value
            End Set
        End Property
        ''' <summary>
        ''' 添加日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_AddDate() As String
            Get
                Return _PL_AddDate
            End Get
            Set(ByVal value As String)
                _PL_AddDate = value
            End Set
        End Property
        ''' <summary>
        ''' 修改人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_ModifyUserID() As String
            Get
                Return _PL_ModifyUserID
            End Get
            Set(ByVal value As String)
                _PL_ModifyUserID = value
            End Set
        End Property
        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_ModifyDate() As String
            Get
                Return _PL_ModifyDate
            End Get
            Set(ByVal value As String)
                _PL_ModifyDate = value
            End Set
        End Property
        ''' <summary>
        ''' 記錄添加人員名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_AddUserName() As String
            Get
                Return _PL_AddUserName
            End Get
            Set(ByVal value As String)
                _PL_AddUserName = value
            End Set
        End Property
        ''' <summary>
        ''' 審核人員名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_CheckUserName() As String
            Get
                Return _PL_CheckUserName
            End Get
            Set(ByVal value As String)
                _PL_CheckUserName = value
            End Set
        End Property
        ''' <summary>
        '''  修改人員名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_ModifyUserName() As String
            Get
                Return _PL_ModifyUserName
            End Get
            Set(ByVal value As String)
                _PL_ModifyUserName = value
            End Set
        End Property
        ''' <summary>
        ''' 部門名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_DepName() As String
            Get
                Return _PL_DepName
            End Get
            Set(ByVal value As String)
                _PL_DepName = value
            End Set
        End Property
    End Class

End Namespace