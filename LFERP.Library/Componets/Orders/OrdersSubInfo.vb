Namespace LFERP.Library.Orders
    Public Class OrdersSubInfo
        Private _OM_ID As String
        Private _OS_BatchID As String
        Private _PM_M_Code As String
        Private _OS_Qty As String
        Private _OS_Sprace As String
        Private _OS_SpraceQty As String
        Private _OS_NoSendQty As String
        Private _OS_NoOutQty As String
        Private _OS_SendDate As String
        Private _OS_CheckDate As String
        Private _OS_Price As String
        Private _OS_Type As String
        Private _OS_MakeDetail As String
        Private _OS_Fac As String
        Private _OS_Plate As String
        Private _OS_ToHK As String
        Private _OS_AccountCheck As String
        Private _OS_AccountAction As String
        Private _OS_AccountRemark As String
        Private _OS_Check As Boolean
        Private _OS_Action As String
        Private _OS_CheckRemark As String
        Private _OS_Remark As String
        Private _OS_AddDate As String
        Private _OS_EditDate As String
        Private _OM_CusterID As String
        Private _OM_CusterPO As String
        Private _OM_CusterNo As String
        Private _OM_No As String
        Private _FacName As String
        Private _OS_CheckAction As String

        Private _OS_SendNeed As String
        Private _PM_JiYu As String
        Private _U_Name As String
        Private _OS_SendType As String
        Private _PM_Rank As String
        Private _OS_ProductAction As String

        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_BatchID As String
        Private _OS_ProductionWeek As String


        Public Sub New()
            _OM_ID = Nothing
            _OS_BatchID = Nothing
            _PM_M_Code = Nothing
            _OS_Qty = Nothing
            _OS_Sprace = Nothing
            _OS_SpraceQty = Nothing
            _OS_NoSendQty = Nothing
            _OS_NoOutQty = Nothing
            _OS_SendDate = Nothing
            _OS_CheckDate = Nothing
            _OS_Price = Nothing
            _OS_Type = Nothing
            _OS_MakeDetail = Nothing
            _OS_Fac = Nothing
            _OS_Plate = Nothing
            _OS_ToHK = Nothing
            _OS_AccountCheck = Nothing
            _OS_AccountAction = Nothing
            _OS_AccountRemark = Nothing
            _OS_Check = False
            _OS_Action = Nothing
            _OS_CheckRemark = Nothing
            _OS_Remark = Nothing
            _OS_AddDate = Nothing
            _OS_EditDate = Nothing
            _OM_CusterID = Nothing
            _OM_CusterPO = Nothing
            _OM_CusterNo = Nothing
            _FacName = Nothing
            _OS_CheckAction = Nothing
            _OS_SendNeed = Nothing
            _PM_JiYu = Nothing
            _U_Name = Nothing
            _OS_SendType = Nothing
            _PM_Rank = Nothing
            _OS_ProductAction = Nothing

            _M_Name = Nothing
            _M_Code = Nothing
            _M_Gauge = Nothing
            _M_BatchID = Nothing
            _OS_ProductionWeek = Nothing

        End Sub

        ''' <summary>
        ''' 訂單流水號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_ID() As String
            Get
                Return _OM_ID
            End Get
            Set(ByVal value As String)
                _OM_ID = value
            End Set
        End Property

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
        ''' 士啤
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_Sprace() As String
            Get
                Return _OS_Sprace
            End Get
            Set(ByVal value As String)
                _OS_Sprace = value
            End Set
        End Property


        ''' <summary>
        ''' 連士啤數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_SpraceQty() As String
            Get
                Return _OS_SpraceQty
            End Get
            Set(ByVal value As String)
                _OS_SpraceQty = value
            End Set
        End Property


        ''' <summary>
        ''' 未交數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_NoSendQty() As String
            Get
                Return _OS_NoSendQty
            End Get
            Set(ByVal value As String)
                _OS_NoSendQty = value
            End Set
        End Property


        ''' <summary>
        ''' 未出廠數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_NoOutQty() As String
            Get
                Return _OS_NoOutQty
            End Get
            Set(ByVal value As String)
                _OS_NoOutQty = value
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
        ''' 驗貨日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_CheckDate() As String
            Get
                Return _OS_CheckDate
            End Get
            Set(ByVal value As String)
                _OS_CheckDate = value
            End Set
        End Property

        ''' <summary>
        ''' 單價
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_Price() As String
            Get
                Return _OS_Price
            End Get
            Set(ByVal value As String)
                _OS_Price = value
            End Set
        End Property


        ''' <summary>
        ''' 類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_Type() As String
            Get
                Return _OS_Type
            End Get
            Set(ByVal value As String)
                _OS_Type = value
            End Set
        End Property


        ''' <summary>
        ''' 完成狀況
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_MakeDetail() As String
            Get
                Return _OS_MakeDetail
            End Get
            Set(ByVal value As String)
                _OS_MakeDetail = value
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

        ''' <summary>
        ''' 電鍍
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_Plate() As String
            Get
                Return _OS_Plate
            End Get
            Set(ByVal value As String)
                _OS_Plate = value
            End Set
        End Property


        ''' <summary>
        ''' 送香港
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_ToHK() As String
            Get
                Return _OS_ToHK
            End Get
            Set(ByVal value As String)
                _OS_ToHK = value
            End Set
        End Property

        ''' <summary>
        ''' 會計部審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_AccountCheck() As String
            Get
                Return _OS_AccountCheck
            End Get
            Set(ByVal value As String)
                _OS_AccountCheck = value
            End Set
        End Property

        ''' <summary>
        ''' 會計部審核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_AccountAction() As String
            Get
                Return _OS_AccountAction
            End Get
            Set(ByVal value As String)
                _OS_AccountAction = value
            End Set
        End Property

        ''' <summary>
        ''' 會計部備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_AccountRemark() As String
            Get
                Return _OS_AccountRemark
            End Get
            Set(ByVal value As String)
                _OS_AccountRemark = value
            End Set
        End Property

        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_Check() As Boolean
            Get
                Return _OS_Check
            End Get
            Set(ByVal value As Boolean)
                _OS_Check = value
            End Set
        End Property

        ''' <summary>
        ''' 審核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_CheckAction() As String
            Get
                Return _OS_CheckAction
            End Get
            Set(ByVal value As String)
                _OS_CheckAction = value
            End Set
        End Property

        ''' <summary>
        ''' 操作員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_Action() As String
            Get
                Return _OS_Action
            End Get
            Set(ByVal value As String)
                _OS_Action = value
            End Set
        End Property

        ''' <summary>
        ''' 審核備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_CheckRemark() As String
            Get
                Return _OS_CheckRemark
            End Get
            Set(ByVal value As String)
                _OS_CheckRemark = value
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
        ''' 建立日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_AddDate() As String
            Get
                Return _OS_AddDate
            End Get
            Set(ByVal value As String)
                _OS_AddDate = value
            End Set
        End Property

        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_EditDate() As String
            Get
                Return _OS_EditDate
            End Get
            Set(ByVal value As String)
                _OS_EditDate = value
            End Set
        End Property

        ''' <summary>
        ''' 客戶
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
        ''' 客戶PO
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_CusterPO() As String
            Get
                Return _OM_CusterPO
            End Get
            Set(ByVal value As String)
                _OM_CusterPO = value
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
        ''' 訂單編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OM_No() As String
            Get
                Return _OM_No
            End Get
            Set(ByVal value As String)
                _OM_No = value
            End Set
        End Property


        ''' <summary>
        ''' 廠別名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FacName() As String
            Get
                Return _FacName
            End Get
            Set(ByVal value As String)
                _FacName = value
            End Set
        End Property

        ''' <summary>
        ''' 出貨要求
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_SendNeed() As String
            Get
                Return _OS_SendNeed
            End Get
            Set(ByVal value As String)
                _OS_SendNeed = value
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
        ''' 操作人(姓名)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property U_Name() As String
            Get
                Return _U_Name
            End Get
            Set(ByVal value As String)

                _U_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 交貨類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_SendType() As String
            Get
                Return _OS_SendType
            End Get
            Set(ByVal value As String)
                _OS_SendType = value
            End Set
        End Property
        Public Property PM_Rank() As String
            Get
                Return _PM_Rank
            End Get
            Set(ByVal value As String)
                _PM_Rank = value
            End Set
        End Property
        Public Property OS_ProductAction() As String
            Get
                Return _OS_ProductAction
            End Get
            Set(ByVal value As String)
                _OS_ProductAction = value
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
        Public Property M_BatchID() As String
            Get
                Return _M_BatchID
            End Get
            Set(ByVal value As String)
                _M_BatchID = value
            End Set
        End Property

        Public Property OS_ProductionWeek() As String
            Get
                Return _OS_ProductionWeek
            End Get
            Set(ByVal value As String)
                _OS_ProductionWeek = value
            End Set
        End Property
    End Class



End Namespace
