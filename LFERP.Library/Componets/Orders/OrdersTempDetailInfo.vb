Namespace LFERP.Library.Orders
    Public Class OrdersTempDetailInfo

        Private _OS_BatchID As String
        Private _OT_ID As String
        Private _OT_Detail As String
        Private _OT_AddDate As String
        Private _OT_EditDate As String
        Private _OT_Check As String
        Private _OT_Action As String

        Private _OS_Qty As String
        Private _OS_SendDate As String
        Private _PM_M_Code As String
        Private _PM_JiYu As String
        Private _OM_CusterID As String
        Private _OM_CusterNo As String
        Private _OS_Remark As String
        Private _OS_Fac As String

        Public Sub New()
            _OS_BatchID = Nothing
            _OT_ID = Nothing
            _OT_Detail = Nothing
            _OT_AddDate = Nothing
            _OT_EditDate = Nothing
            _OT_Check = Nothing
            _OT_Action = Nothing

            _OS_Qty = Nothing
            _OS_SendDate = Nothing
            _PM_M_Code = Nothing
            _PM_JiYu = Nothing
            _OM_CusterID = Nothing
            _OM_CusterNo = Nothing
            _OS_Remark = Nothing
            _OS_Fac = Nothing

        End Sub

        ''' <summary>
        ''' 生產批次
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_BatchID() As String
            Get
                Return _OS_BatchID
            End Get
            Set(ByVal value As String)
                _OS_BatchID = value
            End Set
        End Property

        ''' <summary>
        ''' 臨時單編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OT_ID() As String
            Get
                Return _OT_ID
            End Get
            Set(ByVal value As String)
                _OT_ID = value
            End Set
        End Property

        ''' <summary>
        ''' 內容
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OT_Detail() As String
            Get
                Return _OT_Detail
            End Get
            Set(ByVal value As String)
                _OT_Detail = value
            End Set
        End Property

        ''' <summary>
        ''' 建立日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OT_AddDate() As String
            Get
                Return _OT_AddDate
            End Get
            Set(ByVal value As String)
                _OT_AddDate = value
            End Set
        End Property

        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OT_EditDate() As String
            Get
                Return _OT_EditDate
            End Get
            Set(ByVal value As String)
                _OT_EditDate = value
            End Set
        End Property

        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OT_Check() As String
            Get
                Return _OT_Check
            End Get
            Set(ByVal value As String)
                _OT_Check = value
            End Set
        End Property

        ''' <summary>
        ''' 操作員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OT_Action() As String
            Get
                Return _OT_Action
            End Get
            Set(ByVal value As String)
                _OT_Action = value
            End Set
        End Property

        ''' <summary>
        ''' 生產數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_Qty() As String
            Get
                Return _OS_Qty
            End Get
            Set(ByVal value As String)
                _OS_Qty = value
            End Set
        End Property

        ''' <summary>
        ''' 交貨日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_SendDate() As String
            Get
                Return _OS_SendDate
            End Get
            Set(ByVal value As String)
                _OS_SendDate = value
            End Set
        End Property

        ''' <summary>
        ''' 本廠編號
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

        ''' <summary>
        ''' 客戶ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_CusterID() As String
            Get
                Return _OM_CusterID
            End Get
            Set(ByVal value As String)
                _OM_CusterID = value
            End Set
        End Property

        ''' <summary>
        ''' 客戶編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_CusterNo() As String
            Get
                Return _OM_CusterNo
            End Get
            Set(ByVal value As String)
                _OM_CusterNo = value
            End Set
        End Property

        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_Remark() As String
            Get
                Return _OS_Remark
            End Get
            Set(ByVal value As String)
                _OS_Remark = value
            End Set
        End Property

        ''' <summary>
        ''' 生產部門
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_Fac() As String
            Get
                Return _OS_Fac
            End Get
            Set(ByVal value As String)
                _OS_Fac = value
            End Set
        End Property

    End Class
End Namespace