Namespace LFERP.Library.Production.ProductionFieldDaySummaryInput


    Public Class ProductionFieldDaySummaryInputInfo
        Private _AutoID As String     '自動編號ID
        Private _PM_NO As String     '單號
        Private _Pro_Type As String     '生產工藝
        Private _PM_M_Code As String     '產品編號
        Private _PM_Type As String     '類型
        Private _Pro_NO As String     '工序編號
        Private _FP_OutDep As String     '部門
        Private _OutInType As String     '米亞 聯豐 瓦克
        Private _PM_Date As String     '日期
        Private _AccIn As Double     '收入數量
        Private _ReIn As Double     '收入返修
        Private _AccOut As Double     '發出數量
        Private _ReOut As Double     '發出返修
        Private _LiuBan As Double     '留辨
        Private _SunHuai As Double     '損壞
        Private _DiuShi As Double     '丟失
        Private _BuNiang As Double     '不良
        Private _SaveNow As Double     '當前節余
        Private _SaveEnd As Double     '節余
        Private _PM_Check As Boolean      '審核(鎖定)
        Private _Remark As String     '備注

        Private _PS_Name As String
        Private _Dep_Name As String

        Private _PM_Action As String
        Private _PM_Check_Action As String
        Private _PM_Action_Name As String
        Private _PM_Check_Action_Name As String

        Private _Qty As Double

        Private _ID As String
        Private _TypeName As String
        Private _CO_ID As String
        Private _Sum_Content As String
        Private _Statistical_Type As String

        Sub New()

            _ID = Nothing
            _TypeName = Nothing
            _CO_ID = Nothing
            _Sum_Content = Nothing

            _Qty = 0
            _PM_Action = Nothing
            _PM_Check_Action = Nothing
            _PM_Action_Name = Nothing
            _PM_Check_Action_Name = Nothing

            _Dep_Name = Nothing
            _PS_Name = Nothing

            _AutoID = Nothing
            _PM_NO = Nothing
            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _Pro_NO = Nothing
            _FP_OutDep = Nothing
            _OutInType = Nothing
            _PM_Date = Nothing
            _AccIn = 0
            _ReIn = 0
            _AccOut = 0
            _ReOut = 0
            _LiuBan = 0
            _SunHuai = 0
            _DiuShi = 0
            _BuNiang = 0
            _SaveNow = 0
            _SaveEnd = 0
            _PM_Check = Nothing
            _Remark = Nothing

            _Statistical_Type = Nothing
        End Sub

        Public Property Statistical_Type() As String
            Get
                Return _Statistical_Type
            End Get
            Set(ByVal value As String)
                _Statistical_Type = value
            End Set
        End Property


        Public Property Sum_Content() As String
            Get
                Return _Sum_Content
            End Get
            Set(ByVal value As String)
                _Sum_Content = value
            End Set
        End Property


        Public Property CO_ID() As String
            Get
                Return _CO_ID
            End Get
            Set(ByVal value As String)
                _CO_ID = value
            End Set
        End Property

        Public Property TypeName() As String
            Get
                Return _TypeName
            End Get
            Set(ByVal value As String)
                _TypeName = value
            End Set
        End Property

        Public Property ID() As String
            Get
                Return _ID
            End Get
            Set(ByVal value As String)
                _ID = value
            End Set
        End Property

        Public Property Qty() As String
            Get
                Return _Qty
            End Get
            Set(ByVal value As String)
                _Qty = value
            End Set
        End Property

        Public Property PM_Check_Action_Name() As String
            Get
                Return _PM_Check_Action_Name
            End Get
            Set(ByVal value As String)
                _PM_Check_Action_Name = value
            End Set
        End Property

        Public Property PM_Action_Name() As String
            Get
                Return _PM_Action_Name
            End Get
            Set(ByVal value As String)
                _PM_Action_Name = value
            End Set
        End Property


        Public Property PM_Check_Action() As String
            Get
                Return _PM_Check_Action
            End Get
            Set(ByVal value As String)
                _PM_Check_Action = value
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

        ''' <summary>
        ''' 部門
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Dep_Name() As String
            Get
                Return _Dep_Name
            End Get
            Set(ByVal value As String)
                _Dep_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 工序名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Name() As String
            Get
                Return _PS_Name
            End Get
            Set(ByVal value As String)
                _PS_Name = value
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
        Public Property PM_NO() As String
            Get
                Return _PM_NO
            End Get
            Set(ByVal value As String)
                _PM_NO = value
            End Set
        End Property


        ''' <summary>
        ''' 生產工藝
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_Type() As String
            Get
                Return _Pro_Type
            End Get
            Set(ByVal value As String)
                _Pro_Type = value
            End Set
        End Property


        ''' <summary>
        ''' 產品編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
            End Set
        End Property


        ''' <summary>
        ''' 類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Type() As String
            Get
                Return _PM_Type
            End Get
            Set(ByVal value As String)
                _PM_Type = value
            End Set
        End Property


        ''' <summary>
        ''' 工序編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_NO() As String
            Get
                Return _Pro_NO
            End Get
            Set(ByVal value As String)
                _Pro_NO = value
            End Set
        End Property


        ''' <summary>
        ''' 部門
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FP_OutDep() As String
            Get
                Return _FP_OutDep
            End Get
            Set(ByVal value As String)
                _FP_OutDep = value
            End Set
        End Property


        ''' <summary>
        ''' 米亞 聯豐 瓦克
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OutInType() As String
            Get
                Return _OutInType
            End Get
            Set(ByVal value As String)
                _OutInType = value
            End Set
        End Property


        ''' <summary>
        ''' 日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Date() As String
            Get
                Return _PM_Date
            End Get
            Set(ByVal value As String)
                _PM_Date = value
            End Set
        End Property


        ''' <summary>
        ''' 收入數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AccIn() As Double
            Get
                Return _AccIn
            End Get
            Set(ByVal value As Double)
                _AccIn = value
            End Set
        End Property


        ''' <summary>
        ''' 收入返修
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ReIn() As Double
            Get
                Return _ReIn
            End Get
            Set(ByVal value As Double)
                _ReIn = value
            End Set
        End Property


        ''' <summary>
        ''' 發出數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AccOut() As Double
            Get
                Return _AccOut
            End Get
            Set(ByVal value As Double)
                _AccOut = value
            End Set
        End Property


        ''' <summary>
        ''' 發出返修
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ReOut() As Double
            Get
                Return _ReOut
            End Get
            Set(ByVal value As Double)
                _ReOut = value
            End Set
        End Property


        ''' <summary>
        ''' 留辨
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property LiuBan() As Double
            Get
                Return _LiuBan
            End Get
            Set(ByVal value As Double)
                _LiuBan = value
            End Set
        End Property


        ''' <summary>
        ''' 損壞
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property SunHuai() As Double
            Get
                Return _SunHuai
            End Get
            Set(ByVal value As Double)
                _SunHuai = value
            End Set
        End Property


        ''' <summary>
        ''' 丟失
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DiuShi() As Double
            Get
                Return _DiuShi
            End Get
            Set(ByVal value As Double)
                _DiuShi = value
            End Set
        End Property


        ''' <summary>
        ''' 不良
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property BuNiang() As Double
            Get
                Return _BuNiang
            End Get
            Set(ByVal value As Double)
                _BuNiang = value
            End Set
        End Property


        ''' <summary>
        ''' 當前節余
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property SaveNow() As Double
            Get
                Return _SaveNow
            End Get
            Set(ByVal value As Double)
                _SaveNow = value
            End Set
        End Property


        ''' <summary>
        ''' 節余
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property SaveEnd() As Double
            Get
                Return _SaveEnd
            End Get
            Set(ByVal value As Double)
                _SaveEnd = value
            End Set
        End Property


        ''' <summary>
        ''' 審核(鎖定)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Check() As Boolean
            Get
                Return _PM_Check
            End Get
            Set(ByVal value As Boolean)
                _PM_Check = value
            End Set
        End Property


        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Remark() As String
            Get
                Return _Remark
            End Get
            Set(ByVal value As String)
                _Remark = value
            End Set
        End Property

    End Class
End Namespace