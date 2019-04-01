Namespace LFERP.Library.ProductionPieceProcess

    Public Class ProductionPieceProcessInfo

        Private _AutoID As String
        Private _PP_ID As String
        Private _PP_Num As String
        Private _Pro_Type As String
        Private _PM_M_Code As String

        Private _PM_Type As String
        Private _PP_Remark As String
        Private _PP_ActionUser As String
        Private _PP_ActionDate As Date
        Private _PS_NO As String

        Private _PS_Name As String
        Private _PP_N_Name As String
        Private _DPT_ID As String
        Private _DPT_Name As String
        Private _DPT_PName As String

        Private _PP_Price As Decimal
        Private _PP_Factor As Single
        Private _PP_Explain As String
        Private _PP_Type As String
        Private _PP_BeginUseDate As Date

        Private _PP_EndUseDate As Date
        Private _PP_BeginUse As Boolean
        Private _PP_Check As Boolean
        Private _PP_CheckUserID As String
        Private _PP_CheckUserName As String

        Private _PP_CheckDate As String
        Private _AddUserID As String
        Private _AddDate As Date
        Private _ModifyUserID As String
        Private _ModifyDate As Date

        Private _PP_ActionDateBegin As String
        Private _PP_ActionDateEnd As String

        Private _PP_PriceCheck As Boolean
        Private _PP_FactorCheck As Boolean
        Private _PP_PriceCheckUserID As String
        Private _PP_PriceCheckDate As String
        Private _PP_PriceCheckUserName As String



        Private _PP_PriceType As String                     '2014-06-03  姚駿
        Private _PName As String
        Private _PID As String
        Private _ID As String

        Sub New()

            _PP_PriceCheck = False
            _PP_FactorCheck = False
            _PP_PriceCheckUserID = Nothing
            _PP_PriceCheckDate = Nothing
            _PP_PriceCheckUserName = Nothing


            _AutoID = Nothing
            _PP_ID = Nothing
            _PP_Num = Nothing
            _Pro_Type = Nothing
            _PM_M_Code = Nothing

            _PM_Type = Nothing
            _PP_Remark = Nothing
            _PP_ActionUser = Nothing
            _PP_ActionDate = Nothing
            _PS_NO = Nothing

            _PS_Name = Nothing
            _PP_N_Name = Nothing
            _DPT_ID = Nothing
            _DPT_Name = Nothing
            _DPT_PName = Nothing

            _PP_Price = 0
            _PP_Factor = 0
            _PP_Explain = Nothing
            _PP_Type = Nothing
            _PP_BeginUseDate = Nothing

            _PP_EndUseDate = Nothing
            _PP_BeginUse = False
            _PP_Check = False
            _PP_CheckUserID = Nothing
            _PP_CheckUserName = Nothing

            _PP_CheckDate = Nothing
            _AddUserID = Nothing
            _AddDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing

            _PP_ActionDateBegin = Nothing
            _PP_ActionDateEnd = Nothing

            _PP_PriceType = Nothing                          '2014-06-03  姚駿
            _PName = Nothing
            _PID = Nothing
            _ID = Nothing

        End Sub
        ''' <summary>
        ''' 自動ID（記錄唯一）
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
        ''' 計件工藝單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_ID() As String
            Get
                Return _PP_ID
            End Get
            Set(ByVal value As String)
                _PP_ID = value
            End Set
        End Property
        ''' <summary>
        ''' 工序流水號(次序)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_Num() As String
            Get
                Return _PP_Num
            End Get
            Set(ByVal value As String)
                _PP_Num = value
            End Set
        End Property
        ''' <summary>
        ''' 工藝類型
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
        ''' 配件名稱
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
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_Remark() As String
            Get
                Return _PP_Remark
            End Get
            Set(ByVal value As String)
                _PP_Remark = value
            End Set
        End Property
        ''' <summary>
        ''' 操作人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_ActionUser() As String
            Get
                Return _PP_ActionUser
            End Get
            Set(ByVal value As String)
                _PP_ActionUser = value
            End Set
        End Property
        ''' <summary>
        ''' 建立日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_ActionDate() As Date
            Get
                Return _PP_ActionDate
            End Get
            Set(ByVal value As Date)
                _PP_ActionDate = value
            End Set
        End Property
        ''' <summary>
        ''' 工序編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_NO() As String
            Get
                Return _PS_NO
            End Get
            Set(ByVal value As String)
                _PS_NO = value
            End Set
        End Property

        ''' <summary>
        ''' 大工序名稱
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
        ''' 小工序名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_N_Name() As String
            Get
                Return _PP_N_Name
            End Get
            Set(ByVal value As String)
                _PP_N_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 部門編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DPT_ID() As String
            Get
                Return _DPT_ID
            End Get
            Set(ByVal value As String)
                _DPT_ID = value
            End Set
        End Property
        ''' <summary>
        ''' 部門名稱 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DPT_Name() As String
            Get
                Return _DPT_Name
            End Get
            Set(ByVal value As String)
                _DPT_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 廠別名稱 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DPT_PName() As String
            Get
                Return _DPT_PName
            End Get
            Set(ByVal value As String)
                _DPT_PName = value
            End Set
        End Property

        ''' <summary>
        ''' 工價
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_Price() As Decimal
            Get
                Return _PP_Price
            End Get
            Set(ByVal value As Decimal)
                _PP_Price = value
            End Set
        End Property
        ''' <summary>
        ''' 承包係數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_Factor() As Single
            Get
                Return _PP_Factor
            End Get
            Set(ByVal value As Single)
                _PP_Factor = value
            End Set
        End Property
        ''' <summary>
        ''' 說明
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_Explain() As String
            Get
                Return _PP_Explain
            End Get
            Set(ByVal value As String)
                _PP_Explain = value
            End Set
        End Property
        ''' <summary>
        ''' 類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_Type() As String
            Get
                Return _PP_Type
            End Get
            Set(ByVal value As String)
                _PP_Type = value
            End Set
        End Property
        ''' <summary>
        ''' 開始使用日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_BeginUseDate() As Date
            Get
                Return _PP_BeginUseDate
            End Get
            Set(ByVal value As Date)
                _PP_BeginUseDate = value
            End Set
        End Property

        ''' <summary>
        ''' 結束使用日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_EndUseDate() As Date
            Get
                Return _PP_EndUseDate
            End Get
            Set(ByVal value As Date)
                _PP_EndUseDate = value
            End Set
        End Property
        ''' <summary>
        ''' 啟用
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_BeginUse() As Boolean
            Get
                Return _PP_BeginUse
            End Get
            Set(ByVal value As Boolean)
                _PP_BeginUse = value
            End Set
        End Property
        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_Check() As Boolean
            Get
                Return _PP_Check
            End Get
            Set(ByVal value As Boolean)
                _PP_Check = value
            End Set
        End Property
        ''' <summary>
        ''' 審核人ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_CheckUserID() As String
            Get
                Return _PP_CheckUserID
            End Get
            Set(ByVal value As String)
                _PP_CheckUserID = value
            End Set
        End Property
        ''' <summary>
        ''' 審核人姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_CheckUserName() As String
            Get
                Return _PP_CheckUserName
            End Get
            Set(ByVal value As String)
                _PP_CheckUserName = value
            End Set
        End Property

        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_CheckDate() As String
            Get
                Return _PP_CheckDate
            End Get
            Set(ByVal value As String)
                _PP_CheckDate = value
            End Set
        End Property
        ''' <summary>
        ''' 添加人ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AddUserID() As String
            Get
                Return _AddUserID
            End Get
            Set(ByVal value As String)
                _AddUserID = value
            End Set
        End Property
        ''' <summary>
        ''' 添加日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AddDate() As Date
            Get
                Return _AddDate
            End Get
            Set(ByVal value As Date)
                _AddDate = value
            End Set
        End Property
        ''' <summary>
        ''' 修改人ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ModifyUserID() As String
            Get
                Return _ModifyUserID
            End Get
            Set(ByVal value As String)
                _ModifyUserID = value
            End Set
        End Property
        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ModifyDate() As Date
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As Date)
                _ModifyDate = value
            End Set
        End Property

        ''' <summary>
        ''' 建立開始日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_ActionDateBegin() As String
            Get
                Return _PP_ActionDateBegin
            End Get
            Set(ByVal value As String)
                _PP_ActionDateBegin = value
            End Set
        End Property
        ''' <summary>
        ''' 建立結束日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PP_ActionDateEnd() As String
            Get
                Return _PP_ActionDateEnd
            End Get
            Set(ByVal value As String)
                _PP_ActionDateEnd = value
            End Set
        End Property


        ''-------------------- 2012-12-24
        Public Property PP_PriceCheck() As Boolean
            Get
                Return _PP_PriceCheck
            End Get
            Set(ByVal value As Boolean)
                _PP_PriceCheck = value
            End Set
        End Property


        Public Property PP_FactorCheck() As Boolean
            Get
                Return _PP_FactorCheck
            End Get
            Set(ByVal value As Boolean)
                _PP_FactorCheck = value
            End Set
        End Property


        Public Property PP_PriceCheckUserID() As String
            Get
                Return _PP_PriceCheckUserID
            End Get
            Set(ByVal value As String)
                _PP_PriceCheckUserID = value
            End Set
        End Property


        Public Property PP_PriceCheckDate() As String
            Get
                Return _PP_PriceCheckDate
            End Get
            Set(ByVal value As String)
                _PP_PriceCheckDate = value
            End Set
        End Property
        '_PP_PriceCheckUserName
        Public Property PP_PriceCheckUserName() As String
            Get
                Return _PP_PriceCheckUserName
            End Get
            Set(ByVal value As String)
                _PP_PriceCheckUserName = value
            End Set
        End Property

        '2014-06-03  姚駿
        Public Property PP_PriceType() As String
            Get
                Return _PP_PriceType
            End Get
            Set(ByVal value As String)
                _PP_PriceType = value
            End Set
        End Property

        Public Property PName() As String
            Get
                Return _PName
            End Get
            Set(ByVal value As String)
                _PName = value
            End Set
        End Property

        Public Property PID() As String
            Get
                Return _PID
            End Get
            Set(ByVal value As String)
                _PID = value
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

    End Class

End Namespace


