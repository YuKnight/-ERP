'Namespace LFERP.Library.WareHouse.WareMove
Namespace LFERP.Library.KnifeWare
    Public Class KnifeWareMoveInfo

        Private _MV_NO As String
        Private _MV_Number As String
        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _MV_Qty As String
        Private _MV_Date As String
        Private _OS_BatchID As String
        Private _PM_M_Code As String
        Private _DepotNO As String
        Private _MV_ChangeDepotNO As String
        Private _MV_InOrOut As String
        Private _MV_Remark As String
        Private _MV_Ack As Boolean
        Private _MV_OutAction As String
        Private _MV_InAction As String
        Private _MV_Property As String
        Private _MV_Check As Boolean
        Private _MV_CheckAction As String
        Private _MV_CheckType As String
        Private _MV_CheckRemark As String
        Private _MV_InActionName As String
        Private _MV_OutActionName As String
        Private _MV_CheckActionName As String
        Private _Mode As String
        Private _MV_AckDate As Date
        Private _MV_EndQty As Double
        Private _KnifeType As String

        Private _DepotName As String
        Private _DepotPName As String
        Private _MV_ChangeDepotName As String
        Private _MV_ChangeDepotPName As String

        Private _DepotAllName As String
        Private _MV_ChangeDepotAllName As String

        '2014-02-28 姚駿
        Private _MV_Action As String
        Private _MV_ActionDate As String
        Private _MV_PreRemark As String
        Private _MV_LastRemark As String

        Public Sub New()
            _MV_NO = Nothing
            _MV_Number = Nothing
            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _MV_Qty = 0
            _MV_Date = Nothing
            _OS_BatchID = Nothing
            _PM_M_Code = Nothing
            _DepotNO = Nothing
            _MV_ChangeDepotNO = Nothing
            _MV_InOrOut = Nothing
            _MV_Remark = Nothing
            _MV_Ack = Nothing
            _MV_OutAction = Nothing
            _MV_InAction = Nothing
            _MV_Property = Nothing
            _MV_Check = Nothing
            _MV_CheckAction = Nothing
            _MV_CheckType = Nothing
            _MV_CheckRemark = Nothing
            _MV_InActionName = Nothing
            _MV_OutActionName = Nothing
            _MV_CheckActionName = Nothing
            _Mode = Nothing
            _MV_AckDate = Nothing
            _MV_EndQty = 0
            _KnifeType = Nothing


            _DepotName = Nothing
            _DepotPName = Nothing
            _MV_ChangeDepotName = Nothing
            _MV_ChangeDepotPName = Nothing

            _DepotAllName = Nothing
            _MV_ChangeDepotAllName = Nothing


            '2014-02-28 姚駿
            _MV_Action = Nothing
            _MV_ActionDate = Nothing
            _MV_PreRemark = Nothing
            _MV_LastRemark = Nothing

        End Sub
        ''' <summary>
        ''' 修改前的審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_PreRemark() As String
            Get
                Return _MV_PreRemark
            End Get
            Set(ByVal value As String)
                _MV_PreRemark = value
            End Set
        End Property

        ''' <summary>
        ''' 修改後的審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_LastRemark() As String
            Get
                Return _MV_LastRemark
            End Get
            Set(ByVal value As String)
                _MV_LastRemark = value
            End Set
        End Property


        ''' <summary>
        ''' 操作時間
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_ActionDate() As String
            Get
                Return _MV_ActionDate
            End Get
            Set(ByVal value As String)
                _MV_ActionDate = value
            End Set
        End Property

        ''' <summary>
        ''' 操作人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_Action() As String
            Get
                Return _MV_Action
            End Get
            Set(ByVal value As String)
                _MV_Action = value
            End Set
        End Property

        ''' <summary>
        ''' 調撥單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_NO() As String
            Get
                Return _MV_NO
            End Get
            Set(ByVal value As String)
                _MV_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 調撥單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property KnifeType() As String
            Get
                Return _KnifeType
            End Get
            Set(ByVal value As String)
                _KnifeType = value
            End Set
        End Property

        ''' <summary>
        ''' 調撥編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_Number() As String
            Get
                Return _MV_Number
            End Get
            Set(ByVal value As String)
                _MV_Number = value
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
        ''' 物料規格
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
        ''' 移交數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_Qty() As String
            Get
                Return _MV_Qty
            End Get
            Set(ByVal value As String)
                _MV_Qty = value
            End Set
        End Property

        ''' <summary>
        ''' 日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_Date() As String
            Get
                Return _MV_Date
            End Get
            Set(ByVal value As String)
                _MV_Date = value
            End Set
        End Property

        ''' <summary>
        ''' 批次
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
        ''' 倉庫代號
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
        ''' 變更倉庫代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_ChangeDepotNO() As String
            Get
                Return _MV_ChangeDepotNO
            End Get
            Set(ByVal value As String)
                _MV_ChangeDepotNO = value
            End Set
        End Property


        ''' <summary>
        ''' 收發
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_InOrOut() As String
            Get
                Return _MV_InOrOut
            End Get
            Set(ByVal value As String)
                _MV_InOrOut = value
            End Set
        End Property


        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_Remark() As String
            Get
                Return _MV_Remark
            End Get
            Set(ByVal value As String)
                _MV_Remark = value
            End Set
        End Property


        ''' <summary>
        ''' 確認
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_Ack() As Boolean
            Get
                Return _MV_Ack
            End Get
            Set(ByVal value As Boolean)
                _MV_Ack = value
            End Set
        End Property


        ''' <summary>
        ''' 發出操作人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_OutAction() As String
            Get
                Return _MV_OutAction
            End Get
            Set(ByVal value As String)
                _MV_OutAction = value
            End Set
        End Property

        ''' <summary>
        ''' 收入操作人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_InAction() As String
            Get
                Return _MV_InAction
            End Get
            Set(ByVal value As String)
                _MV_InAction = value
            End Set
        End Property

        ''' <summary>
        ''' 屬性
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_Property() As String
            Get
                Return _MV_Property
            End Get
            Set(ByVal value As String)
                _MV_Property = value
            End Set
        End Property

        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_Check() As Boolean
            Get
                Return _MV_Check
            End Get
            Set(ByVal value As Boolean)
                _MV_Check = value
            End Set
        End Property


        ''' <summary>
        ''' 審核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_CheckAction() As String
            Get
                Return _MV_CheckAction
            End Get
            Set(ByVal value As String)
                _MV_CheckAction = value
            End Set
        End Property


        ''' <summary>
        ''' 審核類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_CheckType() As String
            Get
                Return _MV_CheckType
            End Get
            Set(ByVal value As String)
                _MV_CheckType = value
            End Set
        End Property

        ''' <summary>
        ''' 審核備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_CheckRemark() As String
            Get
                Return _MV_CheckRemark
            End Get
            Set(ByVal value As String)
                _MV_CheckRemark = value
            End Set
        End Property

        ''' <summary>
        ''' 收入人姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_InActionName() As String
            Get
                Return _MV_InActionName
            End Get
            Set(ByVal value As String)
                _MV_InActionName = value
            End Set
        End Property

        ''' <summary>
        ''' 發出人姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_OutActionName() As String
            Get
                Return _MV_OutActionName
            End Get
            Set(ByVal value As String)
                _MV_OutActionName = value
            End Set
        End Property

        ''' <summary>
        ''' 審核人姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MV_CheckActionName() As String
            Get
                Return _MV_CheckActionName
            End Get
            Set(ByVal value As String)
                _MV_CheckActionName = value
            End Set
        End Property

        Public Property Mode() As String
            Get
                Return _Mode
            End Get
            Set(ByVal value As String)
                _Mode = value
            End Set
        End Property

        Public Property MV_AckDate() As Date
            Get
                Return _MV_AckDate
            End Get
            Set(ByVal value As Date)
                _MV_AckDate = value
            End Set
        End Property

        Public Property DepotName() As String
            Get
                Return _DepotName
            End Get
            Set(ByVal value As String)
                _DepotName = value
            End Set
        End Property

        Public Property MV_EndQty() As String
            Get
                Return _MV_EndQty
            End Get
            Set(ByVal value As String)
                _MV_EndQty = value
            End Set
        End Property

        Public Property DepotPName() As String
            Get
                Return _DepotPName
            End Get
            Set(ByVal value As String)
                _DepotPName = value
            End Set
        End Property

        Public Property MV_ChangeDepotName() As String
            Get
                Return _MV_ChangeDepotName
            End Get
            Set(ByVal value As String)
                _MV_ChangeDepotName = value
            End Set
        End Property

        Public Property MV_ChangeDepotPName() As String
            Get
                Return _MV_ChangeDepotPName
            End Get
            Set(ByVal value As String)
                _MV_ChangeDepotPName = value
            End Set
        End Property



        Public Property DepotAllName() As String
            Get
                Return _DepotAllName
            End Get
            Set(ByVal value As String)
                _DepotAllName = value
            End Set
        End Property


        Public Property MV_ChangeDepotAllName() As String
            Get
                Return _MV_ChangeDepotAllName
            End Get
            Set(ByVal value As String)
                _MV_ChangeDepotAllName = value
            End Set
        End Property


    End Class

End Namespace
