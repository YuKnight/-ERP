Namespace LFERP.Library.Purchase.Retrocede
    Public Class RetrocedeInfo
        Private _R_NO As String

        Private _R_RetrocedeNO As String

        Private _A_AcceptanceNO As String

        Private _PM_NO As String

        Private _DepotNO As String

        Private _S_Supplier As String

        Private _S_SupplierNO As String

        Private _A_SendNo As String

        Private _R_ReturnDate As String

        Private _M_Code As String

        Private _M_Unit As String

        Private _M_Name As String

        Private _M_Gauge As String

        Private _OS_BatchID As String

        Private _R_Qty As String

        Private _R_RemarkS As String

        Private _R_Reason As String

        Private _R_RemarkT As String

        Private _R_SendDate As String

        Private _R_ReturnType As String

        Private _R_Check As Boolean

        Private _R_CheckAction As String

        Private _R_CheckDate As String

        Private _R_CheckType As String

        Private _R_CheckRemark As String

        Private _R_AccountCheck As Boolean

        Private _R_AccountAction As String

        Private _R_AccountCheckDate As String

        Private _R_AccountCheckType As String
        Private _R_AccountCheckRemark As String
        Private _PM_M_Code As String
        Private _R_Detail As String
        Private _R_Ver As String
        Private _R_Action As String
        Private _R_UpdateDate As String
        Private _CO_ID As String

        Private _R_Date1 As String
        Private _R_Date2 As String
        Private _S_SupplierName As String


        Public Sub New()
            _R_NO = Nothing
            _R_RetrocedeNO = Nothing
            _A_AcceptanceNO = Nothing
            _PM_NO = Nothing
            _DepotNO = Nothing
            _S_Supplier = Nothing
            _S_SupplierNO = Nothing
            _A_SendNo = Nothing
            _R_ReturnDate = Nothing
            _M_Code = Nothing
            _M_Unit = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _OS_BatchID = Nothing
            _R_Qty = Nothing
            _R_RemarkS = Nothing
            _R_Reason = Nothing
            _R_RemarkT = Nothing
            _R_SendDate = Nothing
            _R_ReturnType = Nothing
            _R_Check = Nothing
            _R_CheckAction = Nothing
            _R_CheckDate = Nothing
            _R_CheckType = Nothing
            _R_CheckRemark = Nothing
            _R_AccountCheck = Nothing
            _R_AccountAction = Nothing
            _R_AccountCheckDate = Nothing
            _R_AccountCheckType = Nothing
            _R_AccountCheckRemark = Nothing
            _PM_M_Code = Nothing
            _R_Detail = Nothing
            _R_Action = Nothing
            _R_Ver = Nothing
            _R_UpdateDate = Nothing
            _CO_ID = Nothing

            _R_Date1 = Nothing
            _R_Date2 = Nothing
            _S_SupplierName = Nothing
        End Sub


        ''' <summary>
        ''' 退貨流水號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_NO() As String

            Get
                Return _R_NO
            End Get
            Set(ByVal value As String)
                _R_NO = value
            End Set
        End Property

        ''' <summary>
        ''' 退貨單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_RetrocedeNO() As String
            Get
                Return _R_RetrocedeNO
            End Get
            Set(ByVal value As String)
                _R_RetrocedeNO = value
            End Set
        End Property

        ''' <summary>
        ''' 驗收單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_AcceptanceNO() As String
            Get
                Return _A_AcceptanceNO
            End Get
            Set(ByVal value As String)
                _A_AcceptanceNO = value
            End Set
        End Property

        ''' <summary>
        ''' 採購單號
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
        ''' 倉庫編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DepotNO() As String
            Get
                Return _DepotNO
            End Get
            Set(ByVal value As String)
                _DepotNO = value
            End Set
        End Property


        ''' <summary>
        ''' 供應商代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Supplier() As String
            Get
                Return _S_Supplier
            End Get
            Set(ByVal value As String)
                _S_Supplier = value
            End Set
        End Property

        ''' <summary>
        ''' 供應商編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_SupplierNO() As String
            Get
                Return _S_SupplierNO
            End Get
            Set(ByVal value As String)
                _S_SupplierNO = value
            End Set
        End Property


        ''' <summary>
        ''' 送貨單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_SendNo() As String
            Get
                Return _A_SendNo
            End Get
            Set(ByVal value As String)
                _A_SendNo = value
            End Set
        End Property

        ''' <summary>
        ''' 退貨日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_ReturnDate() As String
            Get
                Return _R_ReturnDate
            End Get
            Set(ByVal value As String)
                _R_ReturnDate = value
            End Set
        End Property

        ''' <summary>
        ''' 物料編碼
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property

        ''' <summary>
        ''' 單位
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
            End Set
        End Property

        ''' <summary>
        ''' 物料名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Name() As String
            Get
                Return _M_Name
            End Get
            Set(ByVal value As String)
                _M_Name = value
            End Set
        End Property

        ''' <summary>
        ''' 規格
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Gauge() As String
            Get
                Return _M_Gauge
            End Get
            Set(ByVal value As String)
                _M_Gauge = value
            End Set
        End Property

        ''' <summary>
        ''' 批次編號
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
        '''退貨數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_Qty() As String
            Get
                Return _R_Qty
            End Get
            Set(ByVal value As String)
                _R_Qty = value
            End Set
        End Property


        ''' <summary>
        ''' 單項備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_RemarkS() As String
            Get
                Return _R_RemarkS
            End Get
            Set(ByVal value As String)
                _R_RemarkS = value
            End Set
        End Property


        ''' <summary>
        ''' 退貨原因
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_Reason() As String
            Get
                Return _R_Reason
            End Get
            Set(ByVal value As String)
                _R_Reason = value
            End Set
        End Property


        ''' <summary>
        ''' 總備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_RemarkT() As String
            Get
                Return _R_RemarkT
            End Get
            Set(ByVal value As String)
                _R_RemarkT = value
            End Set
        End Property

        ''' <summary>
        ''' 交回日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_SendDate() As String
            Get
                Return _R_SendDate
            End Get
            Set(ByVal value As String)
                _R_SendDate = value
            End Set
        End Property


        ''' <summary>
        ''' 退貨類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_ReturnType() As String
            Get
                Return _R_ReturnType
            End Get
            Set(ByVal value As String)
                _R_ReturnType = value
            End Set
        End Property


        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_Check() As Boolean
            Get
                Return _R_Check
            End Get
            Set(ByVal value As Boolean)
                _R_Check = value
            End Set
        End Property


        ''' <summary>
        ''' 審核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_CheckAction() As String
            Get
                Return _R_CheckAction
            End Get
            Set(ByVal value As String)
                _R_CheckAction = value
            End Set
        End Property


        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_CheckDate() As String
            Get
                Return _R_CheckDate
            End Get
            Set(ByVal value As String)
                _R_CheckDate = value
            End Set
        End Property


        ''' <summary>
        ''' 審核類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_CheckType() As String
            Get
                Return _R_CheckType
            End Get
            Set(ByVal value As String)
                _R_CheckType = value
            End Set
        End Property


        ''' <summary>
        ''' 審核備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_CheckRemark() As String
            Get
                Return _R_CheckRemark
            End Get
            Set(ByVal value As String)
                _R_CheckRemark = value
            End Set
        End Property


        ''' <summary>
        ''' 會計部審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_AccountCheck() As Boolean
            Get
                Return _R_AccountCheck
            End Get
            Set(ByVal value As Boolean)
                _R_AccountCheck = value
            End Set
        End Property


        ''' <summary>
        ''' 會計部審核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_AccountAction() As String
            Get
                Return _R_AccountAction
            End Get
            Set(ByVal value As String)
                _R_AccountAction = value
            End Set

        End Property

        ''' <summary>
        ''' 會計部審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_AccountCheckDate() As String
            Get
                Return _R_AccountCheckDate
            End Get
            Set(ByVal value As String)
                _R_AccountCheckDate = value
            End Set
        End Property



        ''' <summary>
        ''' 會計部審核類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_AccountCheckType() As String
            Get
                Return _R_AccountCheckType
            End Get
            Set(ByVal value As String)
                _R_AccountCheckType = value
            End Set
        End Property


        ''' <summary>
        ''' 會計部審核備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_AccountCheckRemark() As String
            Get
                Return _R_AccountCheckRemark
            End Get
            Set(ByVal value As String)
                _R_AccountCheckRemark = value
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
        ''' 狀態
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_Detail() As String
            Get
                Return _R_Detail
            End Get
            Set(ByVal value As String)
                _R_Detail = value
            End Set
        End Property


        ''' <summary>
        ''' 版本
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_Ver() As String
            Get
                Return _R_Ver
            End Get
            Set(ByVal value As String)
                _R_Ver = value
            End Set
        End Property



        ''' <summary>
        ''' 操作員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_Action() As String
            Get
                Return _R_Action
            End Get
            Set(ByVal value As String)
                _R_Action = value
            End Set
        End Property


        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_UpdateDate() As String
            Get
                Return _R_UpdateDate
            End Get
            Set(ByVal value As String)
                _R_UpdateDate = value
            End Set
        End Property


        ''' <summary>
        ''' 公司代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CO_ID() As String
            Get
                Return _CO_ID
            End Get
            Set(ByVal value As String)
                _CO_ID = value
            End Set
        End Property

        Public Property R_Date1() As String
            Get
                Return _R_Date1
            End Get
            Set(ByVal value As String)
                _R_Date1 = value
            End Set
        End Property

        Public Property R_Date2() As String
            Get
                Return _R_Date2
            End Get
            Set(ByVal value As String)
                _R_Date2 = value
            End Set
        End Property
        '供應商名稱
        Public Property S_SupplierName() As String
            Get
                Return _S_SupplierName
            End Get
            Set(ByVal value As String)
                _S_SupplierName = value
            End Set
        End Property


    End Class
End Namespace
