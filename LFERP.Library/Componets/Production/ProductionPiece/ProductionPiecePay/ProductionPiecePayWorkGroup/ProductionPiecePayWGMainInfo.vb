Namespace LFERP.Library.ProductionPiecePayWGMain

    Public Class ProductionPiecePayWGMainInfo
        Private _PY_ID As String     '單號
        Private _G_NO As String     '組別編號
        Private _PY_YYMM As String     '年月
        Private _PY_CompleteSum As Double     '完成總金額
        Private _PY_UseSum As Double     '耗用總金額
        Private _PY_TimeAllSum As Double     '計時總金額
        Private _PY_PieceAllSum As Double     '計件總金額
        Private _PY_CompensateSum As Double     '應補金額
        Private _PY_SubtractSum As Double     '應扣金額
        Private _PY_BonusSum As Double     '獎金
        Private _PY_Remark As String     '備注
        Private _PY_Check As Boolean      '審核
        Private _PY_CheckUserID As String     '審核編號
        Private _PY_CheckDate As String     '審核日期
        Private _PY_AddUserID As String     '添加人(操作人)編號
        Private _PY_AddDate As String     '添加日期
        Private _PY_ModifyUserID As String     '修改人
        Private _PY_ModifyDate As String     '修改日期
        Private _DepID As String     '部門
        Private _FacID As String     '廠別

        Private _PY_CheckUserName As String     '審核人姓名
        Private _PY_ModifyUserName As String     '修改人姓名
        Private _PY_DepName As String     '部門名稱
        Private _PY_FacName As String     '廠別名稱

        Private _AutoID As String
        Private _PY_TimeSum As Double     '計時金額
        Private _PY_PieceSum As Double     '計件金額

        Private _PY_G_Name As String '組別編號

        Private _PWGtotal_P As Double '查詢統計出指定組別某一月份計件總額
        Private _PWGtotal_T As Double '查詢統計出指定組別某一月份計時總額

        Private _PY_AddUserName As String

        Private _G_NO_OUTSum As Double '              --  組別轉出
        Private _G_NO_InSum As Double '              --  組別轉入   


        Sub New()
            _PY_AddUserName = Nothing

            _PWGtotal_P = 0
            _PWGtotal_T = 0

            _PY_ID = Nothing
            _G_NO = Nothing
            _PY_YYMM = Nothing
            _PY_CompleteSum = 0
            _PY_UseSum = 0
            _PY_TimeSum = 0
            _PY_PieceSum = 0
            _PY_CompensateSum = 0
            _PY_SubtractSum = 0
            _PY_BonusSum = 0
            _PY_Remark = Nothing
            _PY_Check = Nothing
            _PY_CheckUserID = Nothing
            _PY_CheckDate = Nothing
            _PY_AddUserID = Nothing
            _PY_AddDate = Nothing
            _PY_ModifyUserID = Nothing
            _PY_ModifyDate = Nothing
            _DepID = Nothing
            _FacID = Nothing

            _PY_CheckUserName = Nothing
            _PY_ModifyUserName = Nothing
            _PY_DepName = Nothing
            _PY_FacName = Nothing

            _AutoID = Nothing
            _PY_G_Name = Nothing

            _G_NO_OUTSum = 0
            _G_NO_InSum = 0

        End Sub

        ''' <summary>
        ''' 轉出組別金額
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_NO_OUTSum() As Double
            Get
                Return _G_NO_OUTSum
            End Get
            Set(ByVal value As Double)
                _G_NO_OUTSum = value
            End Set
        End Property

        ''' <summary>
        ''' 轉入組別金額
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_NO_InSum() As Double
            Get
                Return _G_NO_InSum
            End Get
            Set(ByVal value As Double)
                _G_NO_InSum = value
            End Set
        End Property


        Public Property PY_AddUserName() As String
            Get
                Return _PY_AddUserName
            End Get
            Set(ByVal value As String)
                _PY_AddUserName = value
            End Set
        End Property

        ''' <summary>
        ''' 查詢統計出指定組別某一月份計件總額
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PWGtotal_P() As Double
            Get
                Return _PWGtotal_P
            End Get
            Set(ByVal value As Double)
                _PWGtotal_P = value
            End Set
        End Property
        ''' <summary>
        ''' 查詢統計出指定組別某一月份計時總額
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PWGtotal_T() As Double
            Get
                Return _PWGtotal_T
            End Get
            Set(ByVal value As Double)
                _PWGtotal_T = value
            End Set
        End Property


        ''' <summary>
        ''' 組別編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_G_Name() As String
            Get
                Return _PY_G_Name
            End Get
            Set(ByVal value As String)
                _PY_G_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 自動編號
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
        ''' 組別編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_NO() As String
            Get
                Return _G_NO
            End Get
            Set(ByVal value As String)
                _G_NO = value
            End Set
        End Property


        ''' <summary>
        ''' 年月
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_YYMM() As String
            Get
                Return _PY_YYMM
            End Get
            Set(ByVal value As String)
                _PY_YYMM = value
            End Set
        End Property


        ''' <summary>
        ''' 完成總金額
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_CompleteSum() As Double
            Get
                Return _PY_CompleteSum
            End Get
            Set(ByVal value As Double)
                _PY_CompleteSum = value
            End Set
        End Property


        ''' <summary>
        ''' 耗用總金額
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_UseSum() As Double
            Get
                Return _PY_UseSum
            End Get
            Set(ByVal value As Double)
                _PY_UseSum = value
            End Set
        End Property


        ''' <summary>
        ''' 計時總金額
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_TimeAllSum() As Double
            Get
                Return _PY_TimeAllSum
            End Get
            Set(ByVal value As Double)
                _PY_TimeAllSum = value
            End Set
        End Property


        ''' <summary>
        ''' 計件總金額
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_PieceAllSum() As Double
            Get
                Return _PY_PieceAllSum
            End Get
            Set(ByVal value As Double)
                _PY_PieceAllSum = value
            End Set
        End Property

        ''' <summary>
        ''' 計時總金額
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_TimeSum() As Double
            Get
                Return _PY_TimeSum
            End Get
            Set(ByVal value As Double)
                _PY_TimeSum = value
            End Set
        End Property


        ''' <summary>
        ''' 計件總金額
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_PieceSum() As Double
            Get
                Return _PY_PieceSum
            End Get
            Set(ByVal value As Double)
                _PY_PieceSum = value
            End Set
        End Property


        ''' <summary>
        ''' 應補金額
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_CompensateSum() As Double
            Get
                Return _PY_CompensateSum
            End Get
            Set(ByVal value As Double)
                _PY_CompensateSum = value
            End Set
        End Property


        ''' <summary>
        ''' 應扣金額
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_SubtractSum() As Double
            Get
                Return _PY_SubtractSum
            End Get
            Set(ByVal value As Double)
                _PY_SubtractSum = value
            End Set
        End Property


        ''' <summary>
        ''' 獎金
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_BonusSum() As Double
            Get
                Return _PY_BonusSum
            End Get
            Set(ByVal value As Double)
                _PY_BonusSum = value
            End Set
        End Property


        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_Remark() As String
            Get
                Return _PY_Remark
            End Get
            Set(ByVal value As String)
                _PY_Remark = value
            End Set
        End Property


        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_Check() As Boolean
            Get
                Return _PY_Check
            End Get
            Set(ByVal value As Boolean)
                _PY_Check = value
            End Set
        End Property


        ''' <summary>
        ''' 審核編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_CheckUserID() As String
            Get
                Return _PY_CheckUserID
            End Get
            Set(ByVal value As String)
                _PY_CheckUserID = value
            End Set
        End Property


        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_CheckDate() As String
            Get
                Return _PY_CheckDate
            End Get
            Set(ByVal value As String)
                _PY_CheckDate = value
            End Set
        End Property


        ''' <summary>
        ''' 添加人(操作人)編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_AddUserID() As String
            Get
                Return _PY_AddUserID
            End Get
            Set(ByVal value As String)
                _PY_AddUserID = value
            End Set
        End Property


        ''' <summary>
        ''' 添加日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_AddDate() As String
            Get
                Return _PY_AddDate
            End Get
            Set(ByVal value As String)
                _PY_AddDate = value
            End Set
        End Property


        ''' <summary>
        ''' 修改人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_ModifyUserID() As String
            Get
                Return _PY_ModifyUserID
            End Get
            Set(ByVal value As String)
                _PY_ModifyUserID = value
            End Set
        End Property


        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_ModifyDate() As String
            Get
                Return _PY_ModifyDate
            End Get
            Set(ByVal value As String)
                _PY_ModifyDate = value
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
        ''' 廠別
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FacID() As String
            Get
                Return _FacID
            End Get
            Set(ByVal value As String)
                _FacID = value
            End Set
        End Property


        ''' <summary>
        ''' 審核人姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_CheckUserName() As String
            Get
                Return _PY_CheckUserName
            End Get
            Set(ByVal value As String)
                _PY_CheckUserName = value
            End Set
        End Property


        ''' <summary>
        ''' 修改人姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_ModifyUserName() As String
            Get
                Return _PY_ModifyUserName
            End Get
            Set(ByVal value As String)
                _PY_ModifyUserName = value
            End Set
        End Property


        ''' <summary>
        ''' 部門名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_DepName() As String
            Get
                Return _PY_DepName
            End Get
            Set(ByVal value As String)
                _PY_DepName = value
            End Set
        End Property


        ''' <summary>
        ''' 廠別名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PY_FacName() As String
            Get
                Return _PY_FacName
            End Get
            Set(ByVal value As String)
                _PY_FacName = value
            End Set
        End Property

    End Class
End Namespace